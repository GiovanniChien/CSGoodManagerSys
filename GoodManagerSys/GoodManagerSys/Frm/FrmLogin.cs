using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Frm.Main;
using GoodManagerSys.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GoodManagerSys {
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e) {
            int account = int.Parse(TxtAccount.Text);
            string password = TxtPassword.Text;
            string pwd = Encrypt.GetMD5(password);
            List<EtStaff> staffs = StaffDao.QueryByStaffID(account);
            if (staffs.Count == 0)
                MsgBoxUtil.ErrMsgBox("用户不存在");
            else if (!pwd.Equals(staffs[0].Pwd))
                MsgBoxUtil.ErrMsgBox("密码错误");
            else {
                Form f = null;
                switch (staffs[0].Role) {
                    case Enums.ERole.未定义:
                        break;
                    case Enums.ERole.管理员:
                        f = new FrmMainAdmin();
                        break;
                    case Enums.ERole.采购员:
                        f = new FrmMainPurchase();
                        break;
                    case Enums.ERole.销售员:
                        f = new FrmMainSale();
                        break;
                }
                Hide();
                if (f != null)
                    f.ShowDialog();
                Close();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e) {
            LblPassword.Parent = PicLoginBackground;
            LblAccount.Parent = PicLoginBackground;
        }
    }
}