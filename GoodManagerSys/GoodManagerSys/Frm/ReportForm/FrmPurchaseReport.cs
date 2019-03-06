using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GoodManagerSys.Frm.ReportForm {
    public partial class FrmPurchaseReport : Form {
        private List<EtPurchase> purchases;
        private List<ClsCategory> categories;
        private bool btnSearchClicked;
        DataTable dt;

        public FrmPurchaseReport() {
            InitializeComponent();
            CmbCategory.SelectedIndex = 0;
            purchases = new List<EtPurchase>();
            categories = new List<ClsCategory>();
            btnSearchClicked = false;
            dt = default(DataTable);
        }

        private void ShowPurchaseDetail() {
            string beginDate = DtpBegin.Value.ToString("yyyyMMdd");
            string endDate = DtpEnd.Value.ToString("yyyyMMdd");
            if (CmbCategory.SelectedIndex == 0)
                purchases = PurchaseDao.QueryByPurchaseDate(beginDate, endDate);
            else {
                ECategory parentCategoryID = (ECategory)(CmbCategory.SelectedIndex - 1);
                purchases = PurchaseDao.QueryByPurchaseDate(beginDate, endDate, parentCategoryID);
            }
            if (purchases.Count == 0)
                MsgBoxUtil.ErrMsgBox("没有符合条件的记录");
            DgvPurchaseDetailShow();
        }

        private void ShowCategoryDetail() {
            SetCategoryList();
            DgvCategoryDetailShow();
        }

        private void SetCategoryList() {
            categories.Clear();
            string beginDate = DtpBegin.Value.ToString("yyyyMMdd");
            string endDate = DtpEnd.Value.ToString("yyyyMMdd");
            if (CmbCategory.SelectedIndex != 0)
                AddCategories(beginDate, endDate, CmbCategory.SelectedIndex - 1);
            else
                for (int i = 0; i < 8; i++)
                    AddCategories(beginDate, endDate, i);
            if (categories.Count == 0)
                MsgBoxUtil.ErrMsgBox("没有符合条件的记录");
        }

        private void AddCategories(string beginDate, string endDate, int categoryID) {
            List<EtPurchase> tmpLists = new List<EtPurchase>();
            ECategory parentCategoryID = (ECategory)categoryID;
            tmpLists = PurchaseDao.QueryByPurchaseDate(beginDate, endDate, parentCategoryID);
            ClsCategory category = GetClsCategory(tmpLists);
            if (category != null)
                categories.Add(category);
        }

        private ClsCategory GetClsCategory(List<EtPurchase> tmpLists) {
            if (tmpLists.Count == 0) return null;
            string parentCategory = tmpLists[0].Category.ParentCategoryName;
            int count = 0;
            double costs = 0;
            foreach (EtPurchase purchase in tmpLists) {
                count += purchase.Quantity;
                costs += purchase.Quantity * purchase.Cost;
            }
            return new ClsCategory { ParentCategory = parentCategory, Count = count, Costs = costs };
        }

        private void DgvPurchaseDetailShow() {
            DgvPurchaseDetail.Rows.Clear();
            DgvPurchaseDetail.RowsDefaultCellStyle.BackColor = Color.FromArgb(240, 255, 255);
            DgvPurchaseDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            DgvPurchaseDetail.AllowUserToAddRows = false;
            DgvPurchaseDetail.RowHeadersVisible = false;
            foreach (EtPurchase purchase in purchases) {
                DgvPurchaseDetail.Rows.Add(new object[] {
                    purchase.PurchaseID,
                    purchase.PurchaseDate,
                    purchase.Category.CategoryName,
                    purchase.Category.Unit,
                    purchase.Cost,
                    purchase.Quantity,
                    purchase.Cost*purchase.Quantity,
                    purchase.Category.Color,
                    GetStaffName(purchase.StaffID)
                });
            }
        }

        private void DgvCategoryDetailShow() {
            DgvCategoryDetail.Rows.Clear();
            DgvCategoryDetail.RowsDefaultCellStyle.BackColor = Color.FromArgb(240, 255, 255);
            DgvCategoryDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            DgvCategoryDetail.AllowUserToAddRows = false;
            DgvCategoryDetail.RowHeadersVisible = false;
            foreach (ClsCategory category in categories) {
                DgvCategoryDetail.Rows.Add(new object[]
                {
                    category.ParentCategory,
                    category.Count,
                    category.Costs
                });
            }
        }

        private DataTable CreateDataTable() {
            SetCategoryList();
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryName");
            dt.Columns.Add("Count");
            dt.Columns.Add("Costs");
            foreach (ClsCategory category in categories) {
                DataRow dr = dt.NewRow();
                dr["CategoryName"] = category.ParentCategory;
                dr["Count"] = category.Count;
                dr["Costs"] = category.Costs;
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void DrawBarGraph() {
            dt = CreateDataTable();
            ChartBar.DataSource = dt;
            ChartBar.Series[0].YValueMembers = "Count";
            ChartBar.Series[1].YValueMembers = "Costs";
            ChartBar.Series[0].XValueMember = "CategoryName";
            ChartBar.DataBind();
        }

        private void DrawPieCount() {
            dt = CreateDataTable();
            ChartPieCount.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            ChartPieCount.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            ChartPieCount.Series[0].XValueType = ChartValueType.String;
            ChartPieCount.Series[0].Points.DataBind(dt.AsEnumerable(), "CategoryName", "Count", "");
        }

        private void DrawPieCosts() {
            ChartPieCosts.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            ChartPieCosts.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            ChartPieCosts.Series[0].XValueType = ChartValueType.String;
            ChartPieCosts.Series[0].Points.DataBind(dt.AsEnumerable(), "CategoryName", "Costs", "");
        }

        private string GetStaffName(int staffID) {
            return StaffDao.QueryByStaffID(staffID)[0].StaffName;
        }

        private void BtnSearch_Click(object sender, EventArgs e) {
            btnSearchClicked = true;
            switch (TabPurchaseReport.SelectedIndex) {
                case 0:
                    ShowPurchaseDetail();
                    break;
                case 1:
                    ShowCategoryDetail();
                    break;
                case 2:
                    if (RdoBarGraph.Checked) {
                        ChartBar.Visible = true;
                        ChartPieCount.Visible = false;
                        ChartPieCosts.Visible = false;
                        DrawBarGraph();
                    }
                    else {
                        ChartBar.Visible = false;
                        ChartPieCount.Visible = true;
                        ChartPieCosts.Visible = true;
                        DrawPieCount();
                        DrawPieCosts();
                    }
                    break;
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e) {
            Close();
        }

        private void RdoBarGraph_CheckedChanged(object sender, EventArgs e) {
            if (RdoBarGraph.Checked && btnSearchClicked) {
                ChartBar.Visible = true;
                ChartPieCount.Visible = false;
                ChartPieCosts.Visible = false;
                DrawBarGraph();
            }
        }

        private void RdoPieGraph_CheckedChanged(object sender, EventArgs e) {
            if (RdoPieGraph.Checked && btnSearchClicked) {
                ChartBar.Visible = false;
                ChartPieCount.Visible = true;
                ChartPieCosts.Visible = true;
                DrawPieCount();
                DrawPieCosts();
            }
        }
    }

    public class ClsCategory {
        internal string ParentCategory { get; set; }
        internal int Count { get; set; }
        internal double Costs { get; set; }
    }
}
