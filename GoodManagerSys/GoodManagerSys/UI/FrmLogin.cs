using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Utils;
using System;
using System.Collections.Generic;
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
            string account = TxtAccount.Text;
            string password = TxtPassword.Text;
            string pwd = Encrypt.GetMD5(password);
            List<EtStaff> staffs = StaffDao.QueryByStaffName(account);
            if (staffs.Count == 0)
                MsgBoxUtil.ErrMsgBox("用户不存在");
            else if(!pwd.Equals(staffs[0].Pwd))
                MsgBoxUtil.ErrMsgBox("密码错误");
            else
            {
                FrmMain f = new FrmMain();
                //   f.Show();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           
            LblPassword.Parent = PicLoginBackground;
            LblAccount.Parent = PicLoginBackground;
        }
    }
}