using GoodManagerSys.Frm.Warehouse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodManagerSys.Frm.Main {
    public partial class FrmMainPurchase : Form {
        public FrmMainPurchase() {
            InitializeComponent();
        }

        private void 入库ToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmGoodIncome frmGoodIncome = new FrmGoodIncome {
                StartPosition = FormStartPosition.CenterParent
            };
            frmGoodIncome.ShowDialog();
        }

        private void 库存查询ToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmWarehouse frmWarehouse = new FrmWarehouse {
                StartPosition = FormStartPosition.CenterParent
            };
            frmWarehouse.ShowDialog();
        }
    }
}
