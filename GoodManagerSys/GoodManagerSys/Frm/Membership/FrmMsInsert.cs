using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Frm.Membership;
using GoodManagerSys.Utils;
using System;
using System.Windows.Forms;

namespace GoodManagerSys {
    public partial class FrmMsInsert : Form {
        public FrmMsInsert() {
            InitializeComponent();
            CmbIsValid.SelectedIndex = 0;
        }

        private void BtnInsert_Click(object sender, EventArgs e) {
            try {
                string MsName = TxtMsName.Text;
                string MsPhone = TxtMsPhone.Text;
                int MsPoint = "" == TxtMsPoint.Text ? 0 : int.Parse(TxtMsPoint.Text);
                EValid IsValid = (EValid)CmbIsValid.SelectedIndex;
                FrmMembership.Ms = new EtMembership {
                    MsName = MsName,
                    MsPhone = MsPhone,
                    MsPoint = MsPoint,
                    IsValid = IsValid
                };
                Close();
            }
            catch (Exception) {
                MsgBoxUtil.ErrMsgBox("员工信息输入错误！");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e) {
            if ("" == TxtMsName.Text && "" == TxtMsPhone.Text && "" == TxtMsPoint.Text)
                Close();
            else if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗口有修改未保存，是否要退出？"))
                Close();
        }

        //private void FrmMsInsert_FormClosing(object sender, FormClosingEventArgs e) {
        //    if ("" == TxtMsName.Text && "" == TxtMsPhone.Text && "" == TxtMsPoint.Text)
        //        Close();
        //    else if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗口有修改未保存，是否要退出？"))
        //        Close();
        //}
    }
}
