using GoodManagerSys.Frm;
using GoodManagerSys.Frm.Membership;
using GoodManagerSys.Frm.ReportForm;
using GoodManagerSys.Frm.Sale;
using GoodManagerSys.Frm.Staff;
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
    public partial class FrmMainAdmin : Form {
        public FrmMainAdmin() {
            InitializeComponent();
        }

        private void 员工管理ToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmStaff frmStaff = new FrmStaff {
                StartPosition = FormStartPosition.CenterParent
            };
            frmStaff.ShowDialog();
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

        private void 会员管理ToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmMembership frmMembership = new FrmMembership {
                StartPosition = FormStartPosition.CenterParent
            };
            frmMembership.ShowDialog();
        }

        private void 销售商品ToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmSale frmSale = new FrmSale {
                StartPosition = FormStartPosition.CenterParent
            };
            frmSale.ShowDialog();
        }

        private void 销售单查询ToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmSaleQuery frmSaleQuery = new FrmSaleQuery {
                StartPosition = FormStartPosition.CenterParent
            };
            frmSaleQuery.ShowDialog();
        }

        private void 采购报表ToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmPurchaseReport frmPurchaseReport = new FrmPurchaseReport {
                StartPosition = FormStartPosition.CenterParent
            };
            frmPurchaseReport.ShowDialog();
        }

        private void 商品管理ToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }
}
