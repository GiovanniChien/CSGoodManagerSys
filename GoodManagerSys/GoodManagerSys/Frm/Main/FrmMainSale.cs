using GoodManagerSys.Frm.Sale;
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
    public partial class FrmMainSale : Form {
        public const int ratio = 60;
        public FrmMainSale() {
            InitializeComponent();
        }

        private void 销售商品ToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmSale frmSale = new FrmSale {
                StartPosition = FormStartPosition.CenterParent,
                Size = new System.Drawing.Size(Width * ratio / 100, Height * ratio / 100)
            };
            frmSale.ShowDialog();
        }

        private void 销售单查询ToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmSaleQuery frmSaleQuery = new FrmSaleQuery {
                StartPosition = FormStartPosition.CenterParent,
                Size = new System.Drawing.Size(Width * ratio / 100, Height * ratio / 100)
            };
            frmSaleQuery.ShowDialog();
        }
    }
}
