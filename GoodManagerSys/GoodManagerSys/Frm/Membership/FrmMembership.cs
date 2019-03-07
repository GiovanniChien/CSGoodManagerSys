using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GoodManagerSys.Frm.Membership {
    public partial class FrmMembership : Form {
        internal static EtMembership Ms;
        private static List<EtMembership> mses;
        private bool hasUpdated;
        public FrmMembership() {
            InitializeComponent();
            Ms = null;
            hasUpdated = false;
            mses = MembershipDao.QueryAll();
            foreach (EtMembership ms in mses)
                DgvMembership.Rows.Add(new object[] {
                    ms.MsID,
                    ms.MsName,
                    ms.MsPhone,
                    ms.MsPoint,
                    ms.IsValid
                });
        }

        private void BtnMsInsert_Click(object sender, EventArgs e) {
            FrmMsInsert fmi = new FrmMsInsert {
                StartPosition = FormStartPosition.CenterParent
            };
            fmi.ShowDialog();
            if (Ms != null) {
                mses.Add(Ms);
                Ms = null;
                if (mses.Count > 1)
                    mses[mses.Count - 1].MsID = mses[mses.Count - 2].MsID + 1;
                DgvMembership.Rows.Add(new object[] {
                    mses[mses.Count-1].MsID,
                    mses[mses.Count-1].MsName,
                    mses[mses.Count-1].MsPhone,
                    mses[mses.Count-1].MsPoint,
                    mses[mses.Count-1].IsValid
                });
                hasUpdated = true;
            }
        }

        private void BtnMsUpdate_Click(object sender, EventArgs e) {
            if (DgvMembership.SelectedRows.Count == 1) {
                int index = DgvMembership.SelectedRows[0].Index;
                Ms = mses[index];
                FrmMsUpdate fmu = new FrmMsUpdate {
                    StartPosition = FormStartPosition.CenterParent
                };
                fmu.ShowDialog();
                if (Ms != null) {
                    DgvMembership.Rows[index].Cells["ClnMsName"].Value = Ms.MsName;
                    DgvMembership.Rows[index].Cells["ClnMsPhone"].Value = Ms.MsPhone;
                    DgvMembership.Rows[index].Cells["ClnMsPoint"].Value = Ms.MsPoint;
                    DgvMembership.Rows[index].Cells["ClnMsIsValid"].Value = Ms.IsValid;
                    mses[index] = Ms;
                    Ms = null;
                }
                hasUpdated = true;
            }
            else
                MsgBoxUtil.ErrMsgBox("请选择要修改的会员信息！");
        }

        private void BtnMsPoint_Click(object sender, EventArgs e) {

        }

        private void BtnMsDelete_Click(object sender, EventArgs e) {
            if (DgvMembership.SelectedRows.Count == 1) {
                int index = DgvMembership.SelectedRows[0].Index;
                Ms = mses[index];
                if (EValid.有效 == Ms.IsValid) {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("确定删除当前会员？\n");
                    sb.Append("会员编号" + Ms.MsID.ToString() + "\n");
                    sb.Append("会员姓名" + Ms.MsName + "\n");
                    sb.Append("联系方式" + Ms.MsPhone + "\n");
                    sb.Append("会员积分" + Ms.MsPoint);
                    if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox(sb.ToString())) {
                        MembershipDao.DeleteByMsID(Ms.MsID);
                        mses[index].IsValid = EValid.已删除;
                        DgvMembership.Rows[index].Cells["ClnMsIsValid"].Value = EValid.已删除;
                        Ms = null;
                    }
                }
            }
            else
                MsgBoxUtil.ErrMsgBox("请选择要删除的会员！");
        }

        private void BtnSubmit_Click(object sender, EventArgs e) {
            foreach (EtMembership ms in mses)
                MembershipDao.UpdateOrInsert(ms);
            hasUpdated = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            DgvMembership.Rows.Clear();
            mses = MembershipDao.QueryAll();
            foreach (EtMembership ms in mses)
                DgvMembership.Rows.Add(new object[] {
                    ms.MsID,
                    ms.MsName,
                    ms.MsPhone,
                    ms.MsPoint,
                    ms.IsValid
                });
            hasUpdated = false;
        }

        private void BtnBack_Click(object sender, EventArgs e) {
            if (hasUpdated) {
                if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗口有修改未保存，是否要退出？"))
                    Close();
            }
            else
                Close();
        }

        //private void FrmMembership_FormClosing(object sender, FormClosingEventArgs e) {
        //    if (hasUpdated) {
        //        if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗口有修改未保存，是否要退出？"))
        //            Close();
        //    }
        //    else
        //        Close();
        //}
    }
}
