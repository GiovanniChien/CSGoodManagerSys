using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
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
        internal static List<EtStaff> Staffs = new List<EtStaff>();
        public FrmStaff() {
            InitializeComponent();
            CmbStaffRole.SelectedIndex = 0;
            //Staffs从数据库读取数据
            //Staffs = StaffDao.QueryAll();
            foreach (EtStaff staff in Staffs)
                DgvStaffData.Rows.Add(new object[] { staff.StaffID, staff.StaffName, staff.StaffPhone, (ERole)staff.Role });
        }

        private void BtnStaffInsert_Click(object sender, EventArgs e) {
            FrmStaffInsert fsi = new FrmStaffInsert {
                StartPosition = FormStartPosition.CenterParent
            };
            fsi.ShowDialog();
            while (fsi.IsDisposed)
                foreach (EtStaff staff in Staffs)
                    DgvStaffData.Rows.Add(new object[] { staff.StaffID, staff.StaffName, staff.StaffPhone, (ERole)staff.Role });
        }

        private void BtnStaffSubmit_Click(object sender, EventArgs e) {
            foreach (EtStaff staff in Staffs) {
                StaffDao.InsertStaff(staff);
            }
        }
    }
}
