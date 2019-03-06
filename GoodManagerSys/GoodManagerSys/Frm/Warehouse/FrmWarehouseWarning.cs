using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
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

namespace GoodManagerSys.Frm.Warehouse
{
    public partial class FrmWarehouseWarning : Form
    {
        private static List<EtCategory> categories;
        private static List<int> currentStocks;
        private static List<EtGood> goods;
        private static List<string> goodDeadlines;
        private static List<int> goodIntervalDays;
        public FrmWarehouseWarning()
        {
            InitializeComponent();
            categories = new List<EtCategory>();
            currentStocks = new List<int>();
            goods = new List<EtGood>();
            goodDeadlines = new List<string>();
            goodIntervalDays = new List<int>();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmWarehouseWarning_Load(object sender, EventArgs e)
        {
            List<EtCategory> list = CategoryDao.QueryAll();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].IsValid == Enums.EValid.有效)
                {
                    int currentStock = GetCurrentStock(list[i].CategoryID);
                    if (currentStock < list[i].MinStock || currentStock > list[i].MaxStock)
                    {
                        categories.Add(list[i]);
                        currentStocks.Add(currentStock);
                    }
                }
            }

            List<EtGood> list2 = GoodDao.QueryAll();
            for(int i=0;i<list2.Count;i++)
            {
                if(list2[i].State!=Enums.EState.已出售)
                {
                    int intervalDays = CalcDateUtil.IntervalDays(list2[i].ProductionDate, list2[i].Category.ExpirationDate);
                    if (intervalDays <= 10)
                    {
                        goods.Add(list2[i]);
                        goodDeadlines.Add(CalcDateUtil.NextDays(list2[i].ProductionDate, list2[i].Category.ExpirationDate).ToString("yyyyMMdd"));
                        goodIntervalDays.Add(intervalDays);
                    }
                }
            }

            DgvWarehouseShow();
        }

        private int GetCurrentStock(int categoryID)
        {
            List<EtGood> goods = GoodDao.QueryByCategoryID(categoryID);
            return goods.Count;
        }

        private void DgvWarehouseShow()
        {
            DgvWarehouse.Rows.Clear();
            DgvWarehouse.RowsDefaultCellStyle.BackColor = Color.White;
            DgvWarehouse.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            DgvWarehouse.AllowUserToAddRows = false;
            DgvWarehouse.RowHeadersVisible = false;
            for (int i = 0; i < categories.Count; i++)
            {
                DgvWarehouse.Rows.Add(new object[]
                {
                    categories[i].CategoryID,
                    categories[i].CategoryName,
                    categories[i].ParentCategoryName,
                    categories[i].Firm,
                    categories[i].Unit,
                    categories[i].Color,
                    categories[i].ExpirationDate,
                    currentStocks[i],
                    categories[i].MinStock,
                    categories[i].MaxStock,
                });
            }
        }

        private void DgvGoodShow()
        {
            DgvGood.Rows.Clear();
            DgvGood.RowsDefaultCellStyle.BackColor = Color.White;
            DgvGood.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            DgvGood.AllowUserToAddRows = false;
            DgvGood.RowHeadersVisible = false;
            for (int i = 0; i < goods.Count; i++)
            {
                DgvGood.Rows.Add(new object[]
                {
                    goods[i].GoodID,
                    goods[i].Category.CategoryName,
                    goods[i].Category.ParentCategoryName,
                    goods[i].Category.Firm,
                    goods[i].ProductionDate,
                    goods[i].Category.ExpirationDate,
                    goodDeadlines[i],
                    goodIntervalDays[i],
                    goods[i].Cost,
                    goods[i].State
                });
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "库存预警")
                DgvWarehouseShow();
            else
                DgvGoodShow();
        }
    }
}
