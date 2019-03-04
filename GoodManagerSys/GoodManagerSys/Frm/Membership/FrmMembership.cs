using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodManagerSys.Frm.Membership {
    public partial class FrmMembership : Form {
        public FrmMembership() {
            InitializeComponent();
        }

        private void BtnMsInsert_Click(object sender, EventArgs e) {
            FrmMsInsert fmi = new FrmMsInsert {
                StartPosition = FormStartPosition.CenterParent
            };
            fmi.ShowDialog();
        }
    }
}
