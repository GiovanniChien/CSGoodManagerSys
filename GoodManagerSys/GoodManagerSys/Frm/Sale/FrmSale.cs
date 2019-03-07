using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GoodManagerSys.Frm.Sale {
    public partial class FrmSale : Form {
        internal static List<EtSale> Sales;
        private int salesPreSize;
        private int salesCurSize;
        private bool hasUpdated;
        public FrmSale() {
            InitializeComponent();
            Sales = new List<EtSale>();
            salesPreSize = 0;
            salesCurSize = 0;
            hasUpdated = false;
            List<EtStaff> staffs = StaffDao.QueryByRole((int)ERole.销售员);
            LblSaleID.Text = (SaleDao.QueryAll().Last().SaleID + 1).ToString();
            foreach (EtStaff staff in staffs)
                CmbOperator.Items.Add(staff.StaffName);
        }

        private void BtnBack_Click(object sender, EventArgs e) {
            if (hasUpdated) {
                if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体有未提交的数据，是否确定退出？"))
                    Close();
            }
            else
                Close();
        }

        private void BtnSingleSaleInsert_Click(object sender, EventArgs e) {
            if (CmbOperator.SelectedIndex != -1) {
                salesPreSize = Sales.Count;
                FrmSaleInsert fsi = new FrmSaleInsert {
                    StartPosition = FormStartPosition.CenterParent
                };
                fsi.ShowDialog();
                hasUpdated = true;
                salesCurSize = Sales.Count;
                DgvAdd();
            }
            else
                MsgBoxUtil.ErrMsgBox("请先选择经办人！");
        }

        private void BtnMultiSaleInsert_Click(object sender, EventArgs e) {
            if (CmbOperator.SelectedIndex != -1) {
                salesPreSize = Sales.Count;
                FrmSaleFromExcel frmSaleFromExcel = new FrmSaleFromExcel {
                    StartPosition = FormStartPosition.CenterParent
                };
                frmSaleFromExcel.ShowDialog();
                hasUpdated = true;
                salesCurSize = Sales.Count;
                DgvAdd();
            }
            else
                MsgBoxUtil.ErrMsgBox("请先选择经办人！");
        }

        private void BtnSaleSubmit_Click(object sender, EventArgs e) {
            if (hasUpdated) {
                if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("确认提交？"))
                    if (Save()) {
                        Close();
                        hasUpdated = false;
                    }
            }
            else
                MsgBoxUtil.ErrMsgBox("没有待插入的表单！");
        }

        private void BtnSaleCancel_Click(object sender, EventArgs e) {
            if (hasUpdated) {
                Sales = SaleDao.QueryAll();
                salesPreSize = 0;
                salesCurSize = Sales.Count;
                DgvSaleInsert.Rows.Clear();
                DgvAdd();
                hasUpdated = false;
            }
        }

        private void DgvAdd() {
            if (salesPreSize == salesCurSize) return;
            for (int i = salesPreSize; i < salesCurSize; i++) {
                Sales[i].SaleID = Sales[i].SaleID != 0 ? Sales[i].SaleID : int.Parse(LblSaleID.Text);
                Sales[i].StaffID = 18001 + CmbOperator.SelectedIndex;
                Sales[i].SaleDate = DtpSaleDate.Value.ToString("yyyyMMdd");
                Sales[i].Good.State = EState.已出售;
                DgvSaleInsert.Rows.Add(new object[] {
                    Sales[i].SaleID,
                    Sales[i].Good.GoodID,
                    Sales[i].Good.Category.CategoryName,
                    Sales[i].Good.Category.Unit,
                    Sales[i].Profit
                });
            }
            DgvSaleInsert.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            DgvSaleInsert.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private bool Save() {
            if (CmbOperator.SelectedIndex == -1) {
                MsgBoxUtil.ErrMsgBox("经办人不能为空！");
                return false;
            }
            int res = 0;
            foreach (EtSale sale in Sales) {
                res += SaleDao.InsertSale(sale);
                GoodDao.UpdateGood(sale.Good);
            }
            if (res == Sales.Count) return true;
            else return false;
        }

        //private void FrmSale_FormClosing(object sender, FormClosingEventArgs e) {
        //    if (hasUpdated) {
        //        if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体有未提交的数据，是否确定退出？"))
        //            Close();
        //    }
        //    else
        //        Close();
        //}
    }
}
