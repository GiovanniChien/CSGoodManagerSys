﻿using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GoodManagerSys.Frm.Warehouse {
    public partial class FrmGoodIncome : Form {
        internal static List<ClsGood> Goods { get; set; }
        private int goodsPreSize;
        private int goodsCurSize;

        public FrmGoodIncome() {
            InitializeComponent();
            Goods = new List<ClsGood>();
            goodsPreSize = 0;
            goodsCurSize = 0;
            LblPurchaseID.Text = (PurchaseDao.QueryAll().Last().PurchaseID + 1).ToString();
            List<EtStaff> staffs = StaffDao.QueryByRole((int)ERole.采购员);
            foreach (EtStaff staff in staffs)
                CmbOperator.Items.Add(staff.StaffName);
        }

        private void BtnMIncome_Click(object sender, EventArgs e) {
            goodsPreSize = Goods.Count;
            FrmPurchaseFromExcel frmPurchaseFromExcel = new FrmPurchaseFromExcel {
                StartPosition = FormStartPosition.CenterParent
            };
            frmPurchaseFromExcel.ShowDialog();
            goodsCurSize = Goods.Count;
            DgvAdd();
        }

        private void BtnSIncome_Click(object sender, EventArgs e) {
            goodsPreSize = Goods.Count;
            FrmGoodInsert frmGoodInsert = new FrmGoodInsert {
                StartPosition = FormStartPosition.CenterParent
            };
            frmGoodInsert.ShowDialog();
            goodsCurSize = Goods.Count;
            DgvAdd();
        }

        private void DgvAdd() {
            if (goodsPreSize == goodsCurSize) return;
            for (int i = goodsPreSize; i < goodsCurSize; i++) {
                EtGood etGood = Goods[i].Good;
                DgvGoodIncome.Rows.Add(new object[] {
                    i +1,
                    etGood.Category.CategoryName,
                    etGood.Category.ParentCategoryName,
                    etGood.Category.Unit,
                    etGood.Category.Firm,
                    etGood.ProductionDate,
                    Goods[i].Count,
                    etGood.Cost,
                    etGood.Price,
                    etGood.State
                });
            }
            DgvGoodIncome.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            DgvGoodIncome.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private bool Save() {
            EtPurchase purchase;
            if (-1 == CmbOperator.SelectedIndex) {
                MsgBoxUtil.ErrMsgBox("经办人不能为空！");
                return false;
            }
            int staffId = StaffDao.QueryByStaffName(CmbOperator.SelectedItem.ToString())[0].StaffID;
            int res = 0;
            foreach (ClsGood good in Goods) {
                purchase = new EtPurchase {
                    PurchaseID = int.Parse(LblPurchaseID.Text),
                    Category = good.Good.Category,
                    PurchaseDate = DtpPurchaseDate.Value.ToString("yyyyMMdd"),
                    Quantity = good.Count,
                    Cost = good.Good.Cost,
                    StaffID = staffId
                };
                res += PurchaseDao.InsertPurchase(purchase);
                EtGood g = new EtGood {
                    Category = good.Good.Category,
                    ProductionDate = good.Good.ProductionDate,
                    PurchaseDate = purchase.PurchaseDate,
                    Cost = good.Good.Cost,
                    Price = good.Good.Price,
                    State = good.Good.State
                };
                for (int i = 0; i < good.Count; i++)
                    GoodDao.InsertGood(g);
            }
            if (res == Goods.Count) return true;
            else return false;
        }

        private void BtnComfirm_Click(object sender, EventArgs e) {
            if (0 == Goods.Count)
                MsgBoxUtil.ErrMsgBox("没有待插入的表单!");
            else if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("确认提交？"))
                if (Save())
                    Close();

        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            if (0 == DgvGoodIncome.Rows.Count)
                Close();
            else if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体有未提交的数据，是否确定退出？"))
                Close();
        }

        //private void FrmGoodIncome_FormClosing(object sender, FormClosingEventArgs e) {
        //    if (0 == DgvGoodIncome.Rows.Count)
        //        Close();
        //    else if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体有未提交的数据，是否确定退出？"))
        //        Close();
        //}
    }

    public class ClsGood {
        internal EtGood Good { get; set; }
        internal int Count { get; set; }
    }
}
