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
            int res = MemberShipDao.DeleteByMsID(29006);
            Console.WriteLine(res);
        }
    }
}
