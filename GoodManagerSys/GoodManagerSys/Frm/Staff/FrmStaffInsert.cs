using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Frm.Staff;
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
    public partial class FrmStaffInsert : Form
    {
        public FrmStaffInsert()
        {
            InitializeComponent();
            CmbStaffRole.SelectedIndex = 0;
        }

        private void BtnBack_Click(object sender, EventArgs e) {
            Dispose();
        }

        private void BtnInsert_Click(object sender, EventArgs e) {
            try {
                string StaffName = TxtStaffName.Text;
                string Pwd = TxtStaffPwd.Text;
                string StaffPhone = TxtStaffPhone.Text;
                int Role = CmbStaffRole.SelectedIndex;
                EtStaff newStaff = new EtStaff {
                    StaffName = StaffName,
                    Pwd=Pwd,
                    StaffPhone=StaffPhone,
                    Role=Role
                };
                FrmStaff.Staffs.Add(newStaff);
                Dispose();
            }
            catch (Exception) {
                MessageBox.Show("员工信息输入错误！", "非法输入", MessageBoxButtons.OK);
            }
        }
    }
}
