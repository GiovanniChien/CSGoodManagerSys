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
            int res = StaffDao.DeleteByStaffID(18009);
            Console.WriteLine(res);
            List<EtStaff> staffs = StaffDao.QueryAll();
            for(int i = 0; i < staffs.Count; i++)
            {
                Console.WriteLine(staffs[i].ToString());
            }
        }
    }
}
