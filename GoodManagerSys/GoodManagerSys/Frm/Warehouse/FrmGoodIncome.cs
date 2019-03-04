using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodManagerSys.Frm
{
    public partial class FrmGoodIncome : Form
    {
        internal static List<ClsGood> Goods { get; set; }
        private int goodsPreSize;
        private int goodsCurSize;

        public FrmGoodIncome()
        {
            InitializeComponent();
            Goods = new List<ClsGood>();
            goodsPreSize = 0;
            goodsCurSize = 0;
        }

        private void BtnSIncome_Click(object sender, EventArgs e)
        {
            goodsPreSize = Goods.Count;
            FrmGoodInsert frmGoodInsert = new FrmGoodInsert
            {
                StartPosition = FormStartPosition.CenterParent
            };
            frmGoodInsert.ShowDialog();
            goodsCurSize = Goods.Count;
            DgvAdd();
        }

        private void DgvAdd()
        {
            for (int i = goodsPreSize; i < goodsCurSize; i++)
            {
                EtGood etGood = Goods[i].Good;
                DgvGoodIncome.Rows.Add(new object[] { i,
                        etGood.Category.CategoryName,
                        etGood.Category.ParentCategoryName,
                        etGood.Category.Unit,etGood.Category.Firm,
                        etGood.ProductionDate,
                        Goods[i].Count,etGood.Cost,etGood.Price,
                        EStateToString(etGood.State)});
            }
        }

        private string EStateToString(EState state)
        {
            string res = "";
            switch (state)
            {
                case EState.ePrePutaway:
                    res = "未上架";
                    break;
                case EState.eUnsaled:
                    res = "未销售";
                    break;
                case EState.eSaled:
                    res = "已销售";
                    break;
            }
            return res;
        }

        private bool SavePurchaseOrder()
        {
            EtPurchase purchase;
            foreach(ClsGood good in Goods)
            {
                purchase = new EtPurchase
                {
                    Category = good.Good.Category,
                    PurchaseDate = DtpPurchaseDate.Value.ToString("yyyyMMdd"),
                };
            }
            return false;
        }

        private void BtnComfirm_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (Goods.Count > 0)
            {
                DialogResult res = MsgBoxUtil.YesNoCancelMsgBox("当前单据未保存，是否保存？");
                if(res==DialogResult.No)
                {
                    this.Close();
                }
                else if (res == DialogResult.Yes)
                {
                    //保存
                }
            }
        }
    }

    public class ClsGood
    {
        internal EtGood Good { get; set; }
        internal int Count { get; set; }
    }
}
