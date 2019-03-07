using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GoodManagerSys.Frm.Staff {
    public partial class FrmStaff : Form {
        internal static EtStaff Staff;
        private List<EtStaff> staffs;
        private bool hasUpdated;
        public FrmStaff() {
            InitializeComponent();
            CmbStaffRole.SelectedIndex = 0;
            Staff = null;
            staffs = StaffDao.QueryAll();
            hasUpdated = false;
            foreach (EtStaff staff in staffs)
                DgvStaffData.Rows.Add(new object[] {
                    staff.StaffID,
                    staff.StaffName,
                    staff.StaffPhone,
                    staff.Role
                });
        }

        private void BtnStaffInsert_Click(object sender, EventArgs e) {
            FrmStaffInsert fsi = new FrmStaffInsert {
                StartPosition = FormStartPosition.CenterParent
            };
            fsi.ShowDialog();
            if (Staff != null) {
                staffs.Add(Staff);
                Staff = null;
                if (staffs.Count > 1)
                    staffs[staffs.Count - 1].StaffID = staffs[staffs.Count - 2].StaffID + 1;
                DgvStaffData.Rows.Add(new object[] {
                    staffs[staffs.Count - 1].StaffID,
                    staffs[staffs.Count - 1].StaffName,
                    staffs[staffs.Count - 1].StaffPhone,
                    staffs[staffs.Count - 1].Role
                });
                hasUpdated = true;
            }
        }

        private void BtnStaffSubmit_Click(object sender, EventArgs e) {
            if (hasUpdated) {
                if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("确认提交？")) {
                    foreach (EtStaff staff in staffs)
                        StaffDao.InsertStaff(staff);
                    hasUpdated = false;
                }
            }
            else
                MsgBoxUtil.ErrMsgBox("没有待添加的员工！");
        }

        private void BtnStaffUpdate_Click(object sender, EventArgs e) {
            if (DgvStaffData.SelectedRows.Count == 1) {
                int index = DgvStaffData.SelectedRows[0].Index;
                Staff = staffs[index];
                FrmStaffUpdate fsu = new FrmStaffUpdate {
                    StartPosition = FormStartPosition.CenterParent
                };
                fsu.ShowDialog();
                if (Staff != null) {
                    DgvStaffData.Rows[index].Cells["ClnStaffName"].Value = Staff.StaffName;
                    DgvStaffData.Rows[index].Cells["ClnStaffPhone"].Value = Staff.StaffPhone;
                    DgvStaffData.Rows[index].Cells["ClnStaffRole"].Value = Staff.Role;
                    Staff = null;
                }
                hasUpdated = true;
            }
            else
                MsgBoxUtil.ErrMsgBox("请选择要修改的员工信息！");
        }

        private void BtnStaffCancel_Click(object sender, EventArgs e) {
            DgvStaffData.Rows.Clear();
            staffs = StaffDao.QueryAll();
            foreach (EtStaff staff in staffs)
                DgvStaffData.Rows.Add(new object[] {
                    staff.StaffID,
                    staff.StaffName,
                    staff.StaffPhone,
                    staff.Role
                });
            hasUpdated = false;
        }

        private void BtnStaffDelete_Click(object sender, EventArgs e) {
            if (DgvStaffData.SelectedRows.Count == 1) {
                int index = DgvStaffData.SelectedRows[0].Index;
                Staff = staffs[index];
                StringBuilder sb = new StringBuilder();
                sb.Append("确定删除当前员工？\n");
                sb.Append("员工编号：" + Staff.StaffID.ToString() + "\n");
                sb.Append("员工姓名：" + Staff.StaffName + "\n");
                sb.Append("联系方式：" + Staff.StaffPhone + "\n");
                sb.Append("员工职称：" + Staff.Role);
                if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox(sb.ToString())) {
                    StaffDao.DeleteByStaffID(Staff.StaffID);
                    staffs.RemoveAt(index);
                    DgvStaffData.Rows.RemoveAt(index);
                    Staff = null;
                }
            }
            else
                MsgBoxUtil.ErrMsgBox("请选择要删除的员工！");
        }

        private void CmbStaffRole_SelectedIndexChanged(object sender, EventArgs e) {
            if (CmbStaffRole.SelectedIndex == -1)
                staffs = StaffDao.QueryAll();
            else
                staffs = StaffDao.QueryByRole(CmbStaffRole.SelectedIndex);
            DgvStaffData.Rows.Clear();
            foreach (EtStaff staff in staffs)
                DgvStaffData.Rows.Add(new object[] {
                    staff.StaffID,
                    staff.StaffName,
                    staff.StaffPhone,
                    staff.Role
                });
            TxtStaffSearch.Text = "";
        }

        private void BtnStaffSearch_Click(object sender, EventArgs e) {
            List<EtStaff> newStaffs;
            string idOrName = TxtStaffSearch.Text;
            string RegexStr = "^[0-9]+$";
            if (Regex.IsMatch(idOrName, RegexStr))
                newStaffs = StaffDao.QueryByStaffID(int.Parse(idOrName));
            else
                newStaffs = StaffDao.QueryByStaffName(idOrName);
            staffs = staffs.Intersect(newStaffs, new MyCompare()).ToList();
            DgvStaffData.Rows.Clear();
            foreach (EtStaff staff in staffs)
                DgvStaffData.Rows.Add(new object[] {
                    staff.StaffID,
                    staff.StaffName,
                    staff.StaffPhone,
                    staff.Role
                });
        }

        private void BtnBack_Click(object sender, EventArgs e) {
            if (hasUpdated) {
                if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体有未提交的数据，是否确定退出？"))
                    Close();
            }
            else
                Close();
        }


        //private void FrmStaff_FormClosing(object sender, FormClosingEventArgs e) {
        //    if (hasUpdated) {
        //        if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体有未提交的数据，是否确定退出？"))
        //            e.Cancel = false;
        //    }
        //    else
        //        e.Cancel = false;
        //}
    }
    class MyCompare : IEqualityComparer<EtStaff> {
        public bool Equals(EtStaff x, EtStaff y) {
            return x.StaffID == y.StaffID;
        }

        public int GetHashCode(EtStaff obj) {
            return obj.ToString().GetHashCode();
        }
    }
}
