using GoodManagerSys.Dao;
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
            List<EtStaff> staffs = StaffDao.QueryByRole((int)ERole.eBuyer);
            foreach(EtStaff staff in staffs)
            {
                CmbOperator.Items.Add(staff.StaffName);
            }
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

        private bool Save()
        {
            EtPurchase purchase;
            if (CmbOperator.SelectedIndex == -1)
            {
                MsgBoxUtil.ErrMsgBox("经办人不能为空！");
                return false;
            }
            if (TxtPurchaseID.Text == "")
            {
                MsgBoxUtil.ErrMsgBox("初始单号不能为空！");
                return false;
            }
            int purchaseId = int.Parse(TxtPurchaseID.Text);
            if (PurchaseDao.QueryByPurchaseID(purchaseId).Count > 0)
            {
                MsgBoxUtil.ErrMsgBox("单号重复！");
                return false;
            }
            int staffId = StaffDao.QueryByStaffName(CmbOperator.SelectedItem.ToString())[0].StaffID;
            int res = 0;
            foreach (ClsGood good in Goods)
            {
                purchase = new EtPurchase
                {
                    PurchaseID = purchaseId,
                    Category = good.Good.Category,
                    PurchaseDate = DtpPurchaseDate.Value.ToString("yyyyMMdd"),
                    Quantity = good.Count,
                    Cost = good.Good.Cost,
                    StaffID = staffId
                };
                res += PurchaseDao.InsertPurchase(purchase);
                EtGood g = new EtGood
                {
                    Category = good.Good.Category,
                    ProductionDate = good.Good.ProductionDate,
                    PurchaseDate = purchase.PurchaseDate,
                    Cost = good.Good.Cost,
                    Price = good.Good.Price,
                    State = good.Good.State
                };
                for (int i = 0; i < good.Count; i++)
                {
                    GoodDao.InsertGood(g);
                }
            }
            if (res == Goods.Count) return true;
            else return false;
        }

        private void BtnComfirm_Click(object sender, EventArgs e)
        {
            if(Goods.Count==0)
            {
                MsgBoxUtil.ErrMsgBox("没有待插入的表单!");
            }
            else
            {
                DialogResult res = MsgBoxUtil.QuestionMsgBox("确认提交？");
                if (res == DialogResult.OK)
                {
                    if(Save()) this.Close();
                }
            }
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
                    if (Save()) this.Close();
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
