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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
          
            FrmMain f = new FrmMain();    
         //   f.Show();
            this.Hide();
            f.ShowDialog();
            this.Close();

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           
            LblPassword.Parent = PicLoginBackground;
            LblAccount.Parent = PicLoginBackground;
        }
    }
}