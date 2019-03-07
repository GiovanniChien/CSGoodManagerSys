using GoodManagerSys.Frm.Membership;
using GoodManagerSys.Frm.ReportForm;
using GoodManagerSys.Frm.Sale;
using GoodManagerSys.Frm.Staff;
using GoodManagerSys.Frm.Warehouse;
using System;
using System.Windows.Forms;

namespace GoodManagerSys.Frm.Main {
    public partial class FrmMainAdmin : Form {
        public const int ratio = 60;
        public FrmMainAdmin() {
            InitializeComponent();
        }

        private void 员工管理ToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmStaff frmStaff = new FrmStaff {
                StartPosition = FormStartPosition.CenterParent,
                Size=new System.Drawing.Size(Width*ratio/100,Height*ratio/100)
            };
            frmStaff.ShowDialog();
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

        private void 会员管理ToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmMembership frmMembership = new FrmMembership {
                StartPosition = FormStartPosition.CenterParent,
                Size = new System.Drawing.Size(Width * ratio / 100, Height * ratio / 100)
            };
            frmMembership.ShowDialog();
        }

        private void 销售商品ToolStripMenuItem1_Click(object sender, EventArgs e) {
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

        private void 采购报表ToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmPurchaseReport frmPurchaseReport = new FrmPurchaseReport {
                StartPosition = FormStartPosition.CenterParent,
                Size = new System.Drawing.Size(Width * ratio / 100, Height * ratio / 100)
            };
            frmPurchaseReport.ShowDialog();
        }

        private void 商品管理ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void FrmMainAdmin_Load(object sender, EventArgs e) {
            FrmWarehouseWarning fww = new FrmWarehouseWarning {
                StartPosition = FormStartPosition.CenterParent
            };
            fww.ShowDialog();
        }
    }
}
