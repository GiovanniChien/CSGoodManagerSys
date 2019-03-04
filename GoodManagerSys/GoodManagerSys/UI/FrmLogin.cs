﻿using GoodManagerSys.Dao;
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
            if(staffs.Count==0)
                MessageBox.Show("用户不存在", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if(!pwd.Equals(staffs[0].Pwd))
                MessageBox.Show("密码错误", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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