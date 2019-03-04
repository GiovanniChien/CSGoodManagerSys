using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodManagerSys.UI
{
    public partial class FrmWarehouse : Form
    {
        private List<EtCategory> categories;
        public FrmWarehouse()
        {
            InitializeComponent();
        }

        private void FrmWarehouse_Load(object sender, EventArgs e)
        {
            CmbCategory.SelectedIndex = 0;
            categories = CategoryDao.QueryAll();
            DgvShow();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            List<EtCategory> list1, list2;
            int index = CmbCategory.SelectedIndex;
            if (index == 0)
                list1 = CategoryDao.QueryAll();
            else
                list1 = CategoryDao.QueryByParentCategoryID((ECategory)index);
            string idOrName = TxtIdOrName.Text;
            string RegexStr = "^[0-9]+$";
            if (Regex.IsMatch(idOrName, RegexStr))
                list2 = CategoryDao.QueryByCategoryID(int.Parse(idOrName));
            else
                list2 = CategoryDao.QueryByCategoryName(idOrName);
            Console.WriteLine(list1.Count());
            Console.WriteLine(list2.Count());
            categories = list1.Intersect(list2, new MyCompare()).ToList();
            Console.WriteLine(list1.Count());
            for (int i = 0; i < categories.Count(); i++)
            {
                Console.WriteLine(categories.ElementAt(i).ToString());
            }
            DgvShow();
        }

        private void DgvShow()
        {
            DgvWarehouse.Rows.Clear();
            DgvWarehouse.RowsDefaultCellStyle.BackColor = Color.White;
            DgvWarehouse.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            DgvWarehouse.AllowUserToAddRows = false;
            DgvWarehouse.RowHeadersVisible = false;
            for (int i=0;i<categories.Count;i++)
            {
                int currentStock = GetCurrentStock(categories[i].CategoryID);
                DgvWarehouse.Rows.Add(new object[]
                {
                    categories[i].CategoryID,
                    categories[i].CategoryName,
                    categories[i].ParentCategoryName,
                    categories[i].Firm,
                    categories[i].Unit,
                    categories[i].Color,
                    categories[i].ExpirationDate,
                    currentStock,
                    categories[i].MinStock,
                    categories[i].MaxStock,
                    categories[i].IsValid
                });
                if (currentStock < categories[i].MinStock || currentStock > categories[i].MaxStock)
                    DgvWarehouse.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private int GetCurrentStock(int categoryID)
        {
            List<EtGood> goods = GoodDao.QueryByCategoryID(categoryID);
            return goods.Count;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    class MyCompare : IEqualityComparer<EtCategory>
    {
        public bool Equals(EtCategory x, EtCategory y)
        {
            return x.CategoryID == y.CategoryID;
        }

        public int GetHashCode(EtCategory obj)
        {
            return obj.ToString().GetHashCode();
        }
    }
}
