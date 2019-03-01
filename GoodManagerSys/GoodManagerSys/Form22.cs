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
            //List<EtSale> sales;
            ////sales = SaleDao.QueryAll();
            ////sales = SaleDao.QueryBySaleID(6001);
            ////sales = SaleDao.QueryByGoodID(1002);
            //sales = SaleDao.QueryByPrimaryID(6001, 1002);
            //foreach (EtSale sale in sales)
            //{
            //    Console.WriteLine(sale.ToString());
            //}
            //Console.WriteLine(sales.Count);
            List<EtGood> goods;
            //goods = GoodDao.QueryAll();
            //goods = GoodDao.QueryByGoodID(1001);
            //goods = GoodDao.QueryByCategoryID(19001);
            //goods = GoodDao.QueryByPurchaseDate("20190228");
            //goods = GoodDao.QueryByState(Enums.EState.ePrePutaway);
            //foreach(EtGood good in goods)
            //{
            //    Console.WriteLine(good.ToString());
            //}
            EtGood good = new EtGood
            {
                Category = new EtCategory
                {
                    CategoryID = 19001,
                },
                ProductionDate = "91020301",
                PurchaseDate = "91020301",
                Cost = 8.00,
                Price = 9.99,
                State = Enums.EState.eSaled
            };
            Console.WriteLine(GoodDao.InsertGood(good));

        }
    }
}
