using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Frm.Sale;
using GoodManagerSys.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GoodManagerSys {
    public partial class FrmSaleInsert : Form {
        public FrmSaleInsert() {
            InitializeComponent();
            CmbGoodID.Items.Clear();
            List<EtGood> goods = GoodDao.QueryByState(Enums.EState.未出售);
            foreach (EtGood good in goods)
                if (null == FrmSale.Sales.Find(delegate (EtSale sale) { return sale.Good.GoodID.Equals(good.GoodID); }))
                    CmbGoodID.Items.Add(good.GoodID.ToString() + " " + good.Category.CategoryName);
        }

        private void BtnInsert_Click(object sender, EventArgs e) {
            try {
                EtSale sale = new EtSale {
                    SaleID = 0,
                    Good = GoodDao.QueryByGoodID(int.Parse(CmbGoodID.SelectedItem.ToString().Split(' ')[0]))[0]
                };
                sale.Profit = int.Parse(TxtPrice.Text) - sale.Good.Cost;
                sale.Good.State = Enums.EState.已出售;
                FrmSale.Sales.Add(sale);
                Close();
            }
            catch (Exception) {
                MsgBoxUtil.ErrMsgBox("输入不得为空！");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e) {
            if (CmbGoodID.SelectedIndex == -1 && TxtPrice.Text == "")
                Close();
            else if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体还有未保存的数据，是否要退出？"))
                    Close();
        }

        private void FrmSaleInsert_FormClosing(object sender, FormClosingEventArgs e) {
            if (CmbGoodID.SelectedIndex == -1 && TxtPrice.Text == "")
                Close();
            else if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体还有未保存的数据，是否要退出？"))
                    Close();
        }
    }
}
