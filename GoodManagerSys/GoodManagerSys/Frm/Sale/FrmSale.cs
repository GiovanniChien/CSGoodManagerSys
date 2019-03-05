using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodManagerSys.Frm.Sale {
    public partial class FrmSale : Form {
        internal static 
        public FrmSale() {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e) {
            Close();
        }

        private void BtnSingleSaleInsert_Click(object sender, EventArgs e) {
            FrmSaleInsert fsi = new FrmSaleInsert {
                StartPosition = FormStartPosition.CenterParent
            };
            fsi.ShowDialog();

        }
    }
}
