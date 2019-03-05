using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Frm.Membership;
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
    public partial class FrmMsInsert : Form
    {
        public FrmMsInsert()
        {
            InitializeComponent();
            CmbIsValid.SelectedIndex = 0;
        }

        private void BtnInsert_Click(object sender, EventArgs e) {
            try {
                string MsName = TxtMsName.Text;
                string MsPhone = TxtMsPhone.Text;
                int MsPoint = int.Parse(TxtMsPoint.Text);
                EValid IsValid = (EValid)CmbIsValid.SelectedIndex;
                FrmMembership.Ms = new EtMembership {
                    MsName = MsName,
                    MsPhone=MsPhone,
                    MsPoint=MsPoint,
                    IsValid=IsValid
                };
                Close();
            }
            catch (Exception) {
                MessageBox.Show("员工信息输入错误！", "非法输入", MessageBoxButtons.OK);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
