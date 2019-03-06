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

namespace GoodManagerSys.Frm.ReportForm
{
    public partial class FrmSaleReport : Form
    {
        private class ClsSaleDetail
        {
            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
            public int Count { get; set; }
            public double GrossSales { get; set; }
            public double Profits { get; set; }
        }

        private class ClsCategorySale
        {
            public string ParentCategoryName { get; set; }
            public int Count { get; set; }
            public double GrossSales { get; set; }
            public double Profits { get; set; }
        }

        private Dictionary<int, ClsSaleDetail> saleDetails;
        private Dictionary<int, ClsCategorySale> categorySales;
        private bool btnSearchClicked;
        private DataTable dt;

        public FrmSaleReport()
        {
            InitializeComponent();
            CmbCategory.SelectedIndex = 0;
            saleDetails = new Dictionary<int, ClsSaleDetail>();
            categorySales = new Dictionary<int, ClsCategorySale>();
            btnSearchClicked = false;
            dt = default(DataTable);
            
        }

        private List<EtSale> QuerySalesFromDB()
        {
            List<EtSale> sales = new List<EtSale>();
            string beginDate = DtpBegin.Value.ToString("yyyyMMdd");
            string endDate = DtpEnd.Value.ToString("yyyyMMdd");
            if (CmbCategory.SelectedIndex != 0)
            {
                ECategory parentCategoryID = (ECategory)(CmbCategory.SelectedIndex - 1);
                sales = SaleDao.QueryBySaleDate(beginDate, endDate, parentCategoryID);
            }
            else
            {
                sales = SaleDao.QueryBySaleDate(beginDate, endDate);
            }
            if (sales.Count == 0)
            {
                MsgBoxUtil.ErrMsgBox("没有符合条件的记录");
            }
            return sales;
        }

        private void ShowSaleDetail()
        {
            List<EtSale> sales = QuerySalesFromDB();
            SetSaleDetailsFromEtSales(sales);
            DgvSaleDetail.Rows.Clear();
            DgvSaleDetail.RowsDefaultCellStyle.BackColor = Color.FromArgb(240, 255, 255);
            DgvSaleDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            DgvSaleDetail.AllowUserToAddRows = false;
            DgvSaleDetail.RowHeadersVisible = false;
            foreach (KeyValuePair<int, ClsSaleDetail> kvp in saleDetails)
            {
                ClsSaleDetail saleDetail = kvp.Value;
                DgvSaleDetail.Rows.Add(new object[]
                {
                    saleDetail.CategoryID,
                    saleDetail.CategoryName,
                    saleDetail.Count,
                    saleDetail.GrossSales,
                    saleDetail.Profits
                });
            }
        }

        private void ShowCategorySale()
        {
            List<EtSale> sales = QuerySalesFromDB();
            SetCategorySalesFromEtSales(sales);
            DgvCategorySale.Rows.Clear();
            DgvCategorySale.RowsDefaultCellStyle.BackColor = Color.FromArgb(240, 255, 255);
            DgvCategorySale.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            DgvCategorySale.AllowUserToAddRows = false;
            DgvCategorySale.RowHeadersVisible = false;
            foreach(KeyValuePair<int,ClsCategorySale> kvp in categorySales)
            {
                ClsCategorySale categorySale = kvp.Value;
                DgvCategorySale.Rows.Add(new object[]
                {
                    categorySale.ParentCategoryName,
                    categorySale.Count,
                    categorySale.GrossSales,
                    categorySale.Profits
                });
            }
        }

        private void SetSaleDetailsFromEtSales(List<EtSale> sales)
        {
            saleDetails.Clear();
            foreach(EtSale sale in sales)
            {
                int categoryID = sale.Good.Category.CategoryID;
                if (saleDetails.ContainsKey(categoryID))
                {
                    saleDetails[categoryID].Count++;
                    saleDetails[categoryID].Profits += sale.Profit;
                    saleDetails[categoryID].GrossSales += sale.Good.Price;
                }
                else
                {
                    saleDetails.Add(categoryID, new ClsSaleDetail
                    {
                        CategoryID = categoryID,
                        CategoryName = sale.Good.Category.CategoryName,
                        Count = 1,
                        GrossSales=sale.Good.Price,
                        Profits=sale.Profit
                    });
                }
            }
        }

        private void SetCategorySalesFromEtSales(List<EtSale> sales)
        {
            categorySales.Clear();
            foreach(EtSale sale in sales)
            {
                int parentCategoryID = (int)sale.Good.Category.ParentCategoryID;
                if (categorySales.ContainsKey(parentCategoryID))
                {
                    categorySales[parentCategoryID].Count++;
                    categorySales[parentCategoryID].Profits += sale.Profit;
                    categorySales[parentCategoryID].GrossSales += sale.Good.Price;
                }
                else
                {
                    categorySales.Add(parentCategoryID, new ClsCategorySale
                    {
                        ParentCategoryName = sale.Good.Category.ParentCategoryName,
                        Count = 1,
                        GrossSales = sale.Good.Price,
                        Profits = sale.Profit
                    });
                }
            }
        }

        private DataTable CreateDataTable()
        {
            List<EtSale> sales = QuerySalesFromDB();
            SetCategorySalesFromEtSales(sales);
            DataTable dt = new DataTable();
            dt.Columns.Add("ParentCategoryName");
            dt.Columns.Add("Count");
            dt.Columns.Add("GrossSales");
            dt.Columns.Add("Profits");
            foreach (KeyValuePair<int, ClsCategorySale> kvp in categorySales)
            {
                DataRow dr = dt.NewRow();
                ClsCategorySale categorySale = kvp.Value;
                dr["ParentCategoryName"] = categorySale.ParentCategoryName;
                dr["Count"] = categorySale.Count;
                dr["GrossSales"] = categorySale.GrossSales;
                dr["Profits"] = categorySale.Profits;
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void DrawBarGraph()
        {
            dt = CreateDataTable();
            ChartBar.DataSource = dt;
            ChartBar.Series[0].YValueMembers = "Count";
            ChartBar.Series[1].YValueMembers = "GrossSales";
            ChartBar.Series[2].YValueMembers = "Profits";
            ChartBar.Series[1].XValueMember = "ParentCategoryName";
            ChartBar.DataBind();
        }

        private void DrawPieCount()
        {
            dt = CreateDataTable();
            ChartPieCount.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            ChartPieCount.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            ChartPieCount.Series[0].XValueType = ChartValueType.String;
            ChartPieCount.Series[0].Points.DataBind(dt.AsEnumerable(), "ParentCategoryName", "Count", "");
        }

        private void DrawPieGrosssale()
        {
            ChartPieGrosssale.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            ChartPieGrosssale.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            ChartPieGrosssale.Series[0].XValueType = ChartValueType.String;
            ChartPieGrosssale.Series[0].Points.DataBind(dt.AsEnumerable(), "ParentCategoryName", "GrossSales", "");
        }

        private void DrawPieProfit()
        {
            ChartPieProfit.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            ChartPieProfit.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            ChartPieProfit.Series[0].XValueType = ChartValueType.String;
            ChartPieProfit.Series[0].Points.DataBind(dt.AsEnumerable(), "ParentCategoryName", "Profits", "");
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            btnSearchClicked = true;
            switch (TabSaleReport.SelectedIndex)
            {
                case 0:
                    ShowSaleDetail();
                    break;
                case 1:
                    ShowCategorySale();
                    break;
                case 2:
                    if (RdoBarGraph.Checked)
                    {
                        ChartBar.Visible = true;
                        ChartPieCount.Visible = false;
                        ChartPieGrosssale.Visible = false;
                        ChartPieProfit.Visible = false;
                        DrawBarGraph();
                    }
                    else
                    {
                        ChartBar.Visible = false;
                        ChartPieCount.Visible = true;
                        ChartPieGrosssale.Visible = true;
                        ChartPieProfit.Visible = true;
                        DrawPieCount();
                        DrawPieGrosssale();
                        DrawPieProfit();
                    }
                    break;
            }
        }

        private void RdoBarGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBarGraph.Checked && btnSearchClicked)
            {
                ChartBar.Visible = true;
                ChartPieCount.Visible = false;
                ChartPieGrosssale.Visible = false;
                ChartPieProfit.Visible = false;
                DrawBarGraph();
            }
        }

        private void RdoPieGraph_CheckedChanged(object sender, EventArgs e)
        {
            if(RdoPieGraph.Checked&& btnSearchClicked)
            {
                ChartBar.Visible = false;
                ChartPieCount.Visible = true;
                ChartPieGrosssale.Visible = true;
                ChartPieProfit.Visible = true;
                DrawPieCount();
                DrawPieGrosssale();
                DrawPieProfit();
            }
        }
    }
}
