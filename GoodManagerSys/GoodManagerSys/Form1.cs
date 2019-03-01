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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<EtCategory> categories = CategoryDao.QueryAll();
            //List<EtCategory> categories = CategoryDao.QueryByIsValid(Enums.EValid.eExist);
            //foreach(EtCategory category in categories)
            //{
            //    Console.WriteLine(category.ToString());
            //}
            //EtMembership membership = new EtMembership
            //{
            //    //MsID = dr.GetInt32("msID"),
            //    MsName = "test",
            //    MsPhone = "12345678987",
            //    MsPoint = 300,
            //    IsValid = Enums.EValid.eDeleted
            //};
            //int res = MemberShipDao.InsertMembership(membership);
            //EtMembership membership = MemberShipDao.QueryByMsID(29006)[0];
            //membership.MsPoint = 89;
            //int res = MemberShipDao.UpdateMembership(membership);
            //int res = MemberShipDao.DeleteByMsID(29006);
            //Console.WriteLine(res);


            /*
             *  添加采购单test 
             */
            //EtPurchase purchase = new EtPurchase
            //{
            //    PurchaseID=22003,
            //    CategoryID = 19001,
            //    PurchaseDate = "20190221",
            //    Quantity = 20,
            //    Cost = 2,
            //    StaffID = 18005
            //};
            //int res = PurchaseDao.InsertPurchase(purchase);
            //Console.WriteLine(res);
            //List<EtPurchase> purchases = PurchaseDao.QueryAll();
            //for (int i = 0; i < purchases.Count; i++)
            //{
            //    Console.WriteLine(purchases[i].ToString());
            //}

            /*
             *  添加销售单test 
             */
            //EtSale sale = new EtSale
            //{
            //    SaleID = 6002,
            //    GoodID = 1003,
            //    SaleDate = "20190302",
            //    Profit = 2,
            //    StaffID = 18003
            //};
            //int res = SaleDao.InsertSale(sale);
            //Console.WriteLine(res);
            //List<EtSale> sales = SaleDao.QueryAll();
            //for (int i = 0; i < sales.Count; i++)
            //{
            //    Console.WriteLine(sales[i].ToString());
            //}

            /*
             *  添加员工test 
             */
            //EtStaff staff = new EtStaff
            //{
            //    StaffID = 18007,
            //    StaffName = "小张",
            //    Pwd = "6D030E0DCCCB5649D6F34431CA2555C4",
            //    StaffPhone = "18120174104",
            //    Role = 2
            //};
            //int res = StaffDao.InsertStaff(staff);
            //Console.WriteLine(res);
            //List<EtStaff> staffs = StaffDao.QueryAll();
            //for (int i = 0; i < staffs.Count; i++)
            //{
            //    Console.WriteLine(staffs[i].ToString());
            //}

            /*
             *  修改员工test 
             */
            //EtStaff staff = new EtStaff
            //{
            //    StaffID = 18007,
            //    StaffName = "小张",
            //    Pwd = "6D030E0DCCCB5649D6F34431CA2555C4",
            //    StaffPhone = "18120745639",
            //    Role = 2
            //};
            //int res = StaffDao.UpdateStaff(staff);
            //Console.WriteLine(res);
            //List<EtStaff> staffs = StaffDao.QueryAll();
            //for (int i = 0; i < staffs.Count; i++)
            //{
            //    Console.WriteLine(staffs[i].ToString());
            //}

        }
    }
}
