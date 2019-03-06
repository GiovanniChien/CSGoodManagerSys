﻿using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Frm.Staff;
using GoodManagerSys.Utils;
using System;
using System.Windows.Forms;

namespace GoodManagerSys {
    public partial class FrmStaffInsert : Form
    {
        public FrmStaffInsert()
        {
            InitializeComponent();
            CmbStaffRole.SelectedIndex = 0;
        }

        private void BtnInsert_Click(object sender, EventArgs e) {
            try {
                if (TxtStaffName.Text != "") {
                    string StaffName = TxtStaffName.Text;
                    string Pwd = Encrypt.GetMD5(TxtStaffPwd.Text);
                    string StaffPhone = TxtStaffPhone.Text;
                    ERole Role = (ERole)CmbStaffRole.SelectedIndex;
                    FrmStaff.Staff = new EtStaff {
                        StaffName = StaffName,
                        Pwd = Pwd,
                        StaffPhone = StaffPhone,
                        Role = Role
                    };
                    Close();
                }
                else
                    MsgBoxUtil.ErrMsgBox("员工姓名不得为空！");
            }
            catch (Exception) {
                MsgBoxUtil.ErrMsgBox("员工信息输入错误！");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e) {
            if ("" == TxtStaffName.Text ||""==TxtStaffPwd.Text || "" == TxtStaffPhone.Text)
                Close();
            else
                if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体有未提交的数据，是否确定退出？"))
                Close();
        }

        private void FrmStaffInsert_FormClosing(object sender, FormClosingEventArgs e) {
            if ("" == TxtStaffName.Text || "" == TxtStaffPwd.Text || "" == TxtStaffPhone.Text)
                Close();
            else
                if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体有未提交的数据，是否确定退出？"))
                Close();
        }
    }
}
