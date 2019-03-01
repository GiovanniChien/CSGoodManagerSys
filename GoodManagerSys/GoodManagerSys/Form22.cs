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
            List<EtPurchase> purchases;
            //purchases = PurchaseDao.QueryAll();
            purchases = PurchaseDao.QueryByPurchaseID(22001);
            //purchases = PurchaseDao.QueryByCategoryID();
            //purchases = PurchaseDao.QueryByPurchaseDate("");
            //purchases = PurchaseDao.QueryByStaffID();
            //EtPurchase purchase = new EtPurchase
            //{
            //    PurchaseID =,
            //    Category = new EtCategory
            //    {

            //    }
            //    PurchaseDate = "",
            //    Quantity = 3,
            //    Cost = 2,
            //    StaffID =
            //};
            //int res= PurchaseDao.InsertPurchase(purchase);
            foreach (EtPurchase purchase in purchases)
            {
                Console.WriteLine(purchase.ToString());
            }
            Console.WriteLine(purchases.Count);
        }
    }
}
