using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Utils;
using System;
using System.Windows.Forms;

namespace GoodManagerSys.Frm.Membership {
    public partial class FrmMsUpdate : Form {
        public FrmMsUpdate() {
            InitializeComponent();
            TxtMsName.Text = FrmMembership.Ms.MsName;
            TxtMsPhone.Text = FrmMembership.Ms.MsPhone;
            TxtMsPoint.Text = FrmMembership.Ms.MsPoint.ToString();
            CmbIsValid.SelectedIndex = (int)FrmMembership.Ms.IsValid;
        }

        private void BtnMsUpdate_Click(object sender, EventArgs e) {
            if (TxtMsName.Text == "")
                MsgBoxUtil.ErrMsgBox("会员姓名不得为空！");
            else {
                FrmMembership.Ms = new EtMembership {
                    MsName = TxtMsName.Text,
                    MsPhone = TxtMsPhone.Text,
                    MsPoint = int.Parse(TxtMsPoint.Text),
                    IsValid = (EValid)CmbIsValid.SelectedIndex
                };
                Close();
            }
        }

        private void BtnMsCancel_Click(object sender, EventArgs e) {
            if ("" == TxtMsName.Text && "" == TxtMsPhone.Text && "" == TxtMsPoint.Text)
                Close();
            else if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗口有修改未保存，是否要退出？"))
                Close();
        }

        //private void FrmMsUpdate_FormClosing(object sender, FormClosingEventArgs e) {
        //    if ("" == TxtMsName.Text && "" == TxtMsPhone.Text && "" == TxtMsPoint.Text)
        //        Close();
        //    else if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗口有修改未保存，是否要退出？"))
        //        Close();
        //}
    }
}
