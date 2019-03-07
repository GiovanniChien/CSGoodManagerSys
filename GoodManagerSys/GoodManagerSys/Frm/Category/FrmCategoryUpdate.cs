using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Utils;
using System;
using System.Windows.Forms;

namespace GoodManagerSys.Frm.Category {
    public partial class FrmCategoryUpdate : Form {
        public FrmCategoryUpdate() {
            InitializeComponent();
            TxtCategoryName.Text = FrmCategory.category.CategoryName;
            CmbParentCategoryName.SelectedIndex = (int)FrmCategory.category.ParentCategoryID;
            TxtFirm.Text = FrmCategory.category.Firm;
            TxtUnit.Text = FrmCategory.category.Unit;
            TxtColor.Text = FrmCategory.category.Color;
            TxtExpirationDate.Text = FrmCategory.category.ExpirationDate.ToString();
            TxtMinStock.Text = FrmCategory.category.MinStock.ToString();
            TxtMaxStock.Text = FrmCategory.category.MaxStock.ToString();
        }

        private void BtnCommit_Click(object sender, EventArgs e) {
            try {
                string CategoryName = TxtCategoryName.Text;
                ECategory ParentCategoryEnum = (ECategory)CmbParentCategoryName.SelectedIndex;
                string ParentCategoryName = ParentCategoryEnum.ToString();
                string Firm = TxtFirm.Text;
                string Unit = TxtUnit.Text;
                string Color = TxtColor.Text;
                int ExpirationDate = int.Parse(TxtExpirationDate.Text);
                int MinStock = int.Parse(TxtMinStock.Text);
                int MaxStock = int.Parse(TxtMaxStock.Text);
                EtCategory category = new EtCategory {
                    CategoryID = FrmCategory.category.CategoryID,
                    CategoryName = CategoryName,
                    ParentCategoryID = ParentCategoryEnum,
                    ParentCategoryName = ParentCategoryName,
                    Unit = Unit,
                    Color = Color,
                    Firm = Firm,
                    MinStock = MinStock,
                    MaxStock = MaxStock,
                    ExpirationDate = ExpirationDate,
                    IsValid = FrmCategory.category.IsValid
                };
                CategoryDao.UpdateCategory(category);
                FrmCategory.category = category;
                Console.WriteLine(category.ToString());
                Close();
            }
            catch (Exception) {
                MsgBoxUtil.ErrMsgBox("商品信息输入错误！");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e) {
            if ("" == TxtCategoryName.Text && -1 == CmbParentCategoryName.SelectedIndex && "" == TxtFirm.Text &&
                "" == TxtUnit.Text && "" == TxtColor.Text && "" == TxtExpirationDate.Text &&
                "" == TxtMinStock.Text && "" == TxtMaxStock.Text)
                Close();
            else if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体有未提交的数据，是否确定退出？"))
                Close();
        }

        //private void FrmCategoryUpdate_FormClosing(object sender, FormClosingEventArgs e) {
        //    if ("" == TxtCategoryName.Text && -1 == CmbParentCategoryName.SelectedIndex && "" == TxtFirm.Text &&
        //        "" == TxtUnit.Text && "" == TxtColor.Text && "" == TxtExpirationDate.Text &&
        //        "" == TxtMinStock.Text && "" == TxtMaxStock.Text)
        //        Close();
        //    else if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体有未提交的数据，是否确定退出？"))
        //        Close();
        //}
    }
}
