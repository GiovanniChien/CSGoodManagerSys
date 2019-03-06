using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Frm.Staff;
using GoodManagerSys.Utils;
using System;
using System.Windows.Forms;

namespace GoodManagerSys {
    public partial class FrmStaffUpdate : Form
    {
        public FrmStaffUpdate()
        {
            InitializeComponent();
            TxtStaffName.Text = FrmStaff.Staff.StaffName;
            TxtStaffPhone.Text = FrmStaff.Staff.StaffPhone;
            CmbStaffRole.SelectedIndex = (int)FrmStaff.Staff.Role;
        }

        private void BtnSubmit_Click(object sender, EventArgs e) {
            try {
                if (TxtStaffName.Text != "") {
                    string StaffName = TxtStaffName.Text;
                    string StaffPhone = TxtStaffPhone.Text;
                    ERole Role = (ERole)CmbStaffRole.SelectedIndex;
                    FrmStaff.Staff = new EtStaff {
                        StaffName = StaffName,
                        StaffPhone = StaffPhone,
                        Role = Role
                    };
                    Dispose();
                }
                else {
                    MsgBoxUtil.ErrMsgBox("员工姓名不得为空！");
                }
            }
            catch (Exception) {
                MsgBoxUtil.ErrMsgBox("员工信息输入错误！");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e) {
            Dispose();
        }
    }
}
