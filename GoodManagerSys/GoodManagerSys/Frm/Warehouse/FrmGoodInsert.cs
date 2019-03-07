using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GoodManagerSys.Frm.Warehouse {
    public partial class FrmGoodInsert : Form {
        public FrmGoodInsert() {
            InitializeComponent();
            CmbIsValid.SelectedIndex = 0;
            foreach (EtCategory category in CategoryDao.QueryByIsValid(EValid.有效))
                CmbCategoryID.Items.Add(category.CategoryID + " " + category.CategoryName);
        }

        private void BtnInsert_Click(object sender, EventArgs e) {
            ClsGood good = GetGoodFromInput();
            if (good != null)
                if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("确认提交？")) {
                    FrmGoodIncome.Goods.Add(good);
                    Close();
                }
        }

        private ClsGood GetGoodFromInput() {
            ClsGood good = null;
            try {
                int categoryID = int.Parse(CmbCategoryID.SelectedItem.ToString().Split(' ')[0]);
                string productionDate = DtpProductionID.Value.ToString("yyyyMMdd");
                double cost = double.Parse(TxtCost.Text);
                double price = TxtPrice.Text != "" ? double.Parse(TxtPrice.Text) : 0;
                int count = TxtCount.Text != "" ? int.Parse(TxtCount.Text) : 0;
                EState state = (EState)CmbIsValid.SelectedIndex;
                List<EtCategory> categories = CategoryDao.QueryByCategoryID(categoryID);
                if (0 == count)
                    MsgBoxUtil.ErrMsgBox("商品数量不能为0！");
                else {
                    if (0 == categories.Count)
                        MsgBoxUtil.ErrMsgBox("不存在该商品！");
                    else
                        good = new ClsGood {
                            Good = new EtGood {
                                Category = categories[0],
                                ProductionDate = productionDate,
                                Cost = cost,
                                Price = price,
                                State = state
                            },
                            Count = count
                        };
                }
            }
            catch (Exception) {
                MsgBoxUtil.ErrMsgBox("非法输入！");
            }
            return good;
        }


        private void BtnBack_Click(object sender, EventArgs e) {
            if (-1 == CmbCategoryID.SelectedIndex && "" == TxtCost.Text && "" == TxtPrice.Text && "" == TxtCount.Text)
                Close();
            else if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体有未提交的数据，是否确定要退出？"))
                Close();
        }

        //private void FrmGoodInsert_FormClosing(object sender, FormClosingEventArgs e) {
        //    if (-1 == CmbCategoryID.SelectedIndex && "" == TxtCost.Text && "" == TxtPrice.Text && "" == TxtCount.Text)
        //        Close();
        //    else if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体有未提交的数据，是否确定要退出？"))
        //        Close();
        //}
    }
}
