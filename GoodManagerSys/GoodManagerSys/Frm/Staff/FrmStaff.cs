using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodManagerSys.Frm.Staff {
    public partial class FrmStaff : Form {
        internal static EtStaff Staff;
        private List<EtStaff> staffs;
        public FrmStaff() {
            InitializeComponent();
            CmbStaffRole.SelectedIndex = 0;
            Staff = null;
            //staffs = new List<EtStaff>();
            staffs = StaffDao.QueryAll();
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
            }
        }

        private void BtnStaffSubmit_Click(object sender, EventArgs e) {
            foreach (EtStaff staff in staffs) {
                StaffDao.InsertStaff(staff);
            }
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
            }
            else {
                MsgBoxUtil.ErrMsgBox("请选择要修改信息的员工！");
            }
        }
    }
}
