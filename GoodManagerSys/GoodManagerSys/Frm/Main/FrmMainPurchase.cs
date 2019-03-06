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
        public const int ratio = 60;
        public FrmMainPurchase() {
            InitializeComponent();
        }

        private void 入库ToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmGoodIncome frmGoodIncome = new FrmGoodIncome {
                StartPosition = FormStartPosition.CenterParent,
                Size = new System.Drawing.Size(Width * ratio / 100, Height * ratio / 100)
            };
            frmGoodIncome.ShowDialog();
        }

        private void 库存查询ToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmWarehouse frmWarehouse = new FrmWarehouse {
                StartPosition = FormStartPosition.CenterParent,
                Size = new System.Drawing.Size(Width * ratio / 100, Height * ratio / 100)
            };
            frmWarehouse.ShowDialog();
        }
    }
}
