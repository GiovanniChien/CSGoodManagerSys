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
        //private List<EtCategory> categories;
        public FrmWarehouse()
        {
            InitializeComponent();
        }

        private void FrmWarehouse_Load(object sender, EventArgs e)
        {
            CmbCategory.SelectedIndex = 0;
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            List<EtCategory> list1, list2, list3;
            int index = CmbCategory.SelectedIndex;
            if (index == 0)
                list1 = CategoryDao.QueryAll();
            else
                list1 = CategoryDao.QueryByParentCategoryID((ECategory)index);
            string idOrName = TxtIdOrName.Text;
            string RegexStr = "^[0-9]+$";
            list2 = new List<EtCategory>();
            if (Regex.IsMatch(idOrName, RegexStr))
                list2 = CategoryDao.QueryByCategoryID(int.Parse(idOrName));
            list3 = CategoryDao.QueryByCategoryName(idOrName);
            Console.WriteLine(list1.Count());
            Console.WriteLine(list2.Count());
            Console.WriteLine(list3.Count());
            var union = list3.Union(list2);
            Console.WriteLine(union.Count());
            var categories = list1.Intersect(union);
            Console.WriteLine(categories.Count());
            for (int i=0;i< categories.Count();i++)
            {
                Console.WriteLine(categories.ElementAt(i).ToString());
            }
        }
    }
}
