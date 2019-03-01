using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodManagerSys
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EtSale> sales;
            //sales = SaleDao.QueryAll();
            //sales = SaleDao.QueryBySaleID(6001);
            //sales = SaleDao.QueryByGoodID(1002);
            sales = SaleDao.QueryByPrimaryID(6001, 10002);
            foreach (EtSale sale in sales)
            {
                Console.WriteLine(sale.ToString());
            }
            Console.WriteLine(sales.Count);
        }
    }
}
