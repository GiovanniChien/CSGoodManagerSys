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

namespace GoodManagerSys
{
    public partial class FrmMsInsert : Form
    {
        public FrmMsInsert()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e) {
            try {
                string MsName = TxtMsName.Text;
                string MsPhone = TxtMsPhone.Text;
                int MsPoint = int.Parse(TxtMsPoint.Text);
                EValid IsValid = (EValid)CmbIsValid.SelectedIndex;
                EtMembership newMembership = new EtMembership {
                    MsName = MsName,
                    MsPhone=MsPhone,
                    MsPoint=MsPoint,
                    IsValid=IsValid
                };
                Dispose();
            }
            catch (Exception) {
                MessageBox.Show("员工信息输入错误！", "非法输入", MessageBoxButtons.OK);
            }
        }
    }
}
