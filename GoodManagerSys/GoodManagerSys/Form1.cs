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
            List<EtCategory> categories = CategoryDao.QueryByIsValid(Enums.EValid.eExist);
            foreach(EtCategory category in categories)
            {
                Console.WriteLine(category.ToString());
            }
        }
    }
}
