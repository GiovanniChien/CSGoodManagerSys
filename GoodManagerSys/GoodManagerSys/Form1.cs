using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using System;
using System.Collections.Generic;
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
            //List<EtGood> goods;
            //goods = GoodDao.QueryAll();
            //goods = GoodDao.QueryByState(Enums.EState.eSaled);
            //foreach(EtGood good in goods)
            //{
            //    Console.WriteLine(good.ToString());
            //}
            //EtGood good = new EtGood
            //{
            //    CategoryID = 19001,
            //    ProductionDate = "91020301",
            //    PurchaseDate = "20190301",
            //    Cost = 8.0,
            //    Price = 9.0,
            //    State = Enums.EState.ePrePutaway
            //};
            int res;
            //res = GoodDao.InsertGood(good);
            //EtGood good = GoodDao.QueryByGoodID(1009)[0];
            //good.Price = 9.99;
            //res = GoodDao.UpdateGood(good);
            res = GoodDao.DeleteByGoodID(1009);
            Console.WriteLine(res);
        }
    }
}
