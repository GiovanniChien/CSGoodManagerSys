using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodManagerSys {
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
        }

        private void BtnStaff_Click(object sender, EventArgs e) {
            TlpMsMenu.Visible = false;
            TlpStaffMenu.Visible = true;
        }

        private void BtnWarehouse_Click(object sender, EventArgs e) {
            TlpMainMenu.Visible = false;
            TlpStaffMenu.Visible = false;
            TlpMsMenu.Visible = false;
            TlpWarehouseMenu.Visible = true;
        }

        private void BtnSale_Click(object sender, EventArgs e) {
            TlpMainMenu.Visible = false;
            TlpStaffMenu.Visible = false;
            TlpMsMenu.Visible = false;
            TlpSaleMenu.Visible = true;
        }

        private void BtnMembership_Click(object sender, EventArgs e) {
            TlpStaffMenu.Visible = false;
            TlpMsMenu.Visible = true;
        }

        private void BtnTable_Click(object sender, EventArgs e) {
            TlpMainMenu.Visible = false;
            TlpStaffMenu.Visible = false;
            TlpMsMenu.Visible = false;
            TlpTableMenu.Visible = true;
        }

        private void BtnStaffBack_Click(object sender, EventArgs e) {
            TlpStaffMenu.Visible = false;
            TlpMainMenu.Visible = true;
        }

        private void BtnWarehouseBack_Click(object sender, EventArgs e) {
            TlpWarehouseMenu.Visible = false;
            TlpWarehouseSubmenu.Visible = false;
            TlpIncomeEmptyMenu.Visible = false;
            TlpMainMenu.Visible = true;
        }

        private void BtnSaleBack_Click(object sender, EventArgs e) {
            TlpSaleMenu.Visible = false;
            TlpSaleEmptyMenu.Visible = false;
            TlpSaleSearchMenu.Visible = false;
            TlpMainMenu.Visible = true;
        }

        private void BtnTableBack_Click(object sender, EventArgs e) {
            TlpTableMenu.Visible = false;
            TabPurchase.Visible = false;
            TabSale.Visible = false;
            TabProfit.Visible = false;
            TlpMainMenu.Visible = true;
        }

        private void BtnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void BtnStaffInsert_Click(object sender, EventArgs e) {
            //FrmStaffInsert
        }

        private void BtnStaffDelete_Click(object sender, EventArgs e) {
            //FrmStaffDelete
        }

        private void BtnGoodIncome_Click(object sender, EventArgs e) {
            TlpWarehouseSubmenu.Visible = false;
            TlpIncomeEmptyMenu.Visible = true;
        }

        private void BtnWarehouseSubmenu_Click(object sender, EventArgs e) {
            TlpIncomeEmptyMenu.Visible = false;
            TlpWarehouseMenu.Visible = true;
        }

        private void BtnStaffUpdate_Click(object sender, EventArgs e) {
            //if a row of Dgv is selected
            //FrmStaffUpdate
        }

        private void BtnSingleIncome_Click(object sender, EventArgs e) {
            //FrmGoodInsert
        }

        private void BtnFileIncome_Click(object sender, EventArgs e) {
            //FrmGoodPath
        }

        private void BtnWarehouseSubmit_Click(object sender, EventArgs e) {
            //写入数据库
        }

        private void BtnWarehouseCancel_Click(object sender, EventArgs e) {
            //从数据库重新读取数据
        }

        private void BtnGoodManager_Click(object sender, EventArgs e) {
            TlpIncomeEmptyMenu.Visible = false;
            TlpWarehouseSubmenu.Visible = true;
            //刷新数据
        }

        private void BtnSaleGood_Click(object sender, EventArgs e) {
            TlpSaleSearchMenu.Visible = false;
            TlpSaleEmptyMenu.Visible = true;
            //FrmSaleInsert
        }

        private void BtnWareSearch_Click(object sender, EventArgs e) {
            TlpIncomeEmptyMenu.Visible = false;
            TlpWarehouseSubmenu.Visible = true;
            //按isValid==EExist查询
        }

        private void BtnWarehouseWarning_Click(object sender, EventArgs e) {
            TlpIncomeEmptyMenu.Visible = false;
            TlpWarehouseSubmenu.Visible = true;
            //按数量<minStock查询
        }

        private void BtnSaleSearch_Click(object sender, EventArgs e) {
            TlpSaleEmptyMenu.Visible = false;
            TlpSaleSearchMenu.Visible = true;
            //刷新数据
        }

        private void BtnPurchaseTable_Click(object sender, EventArgs e) {
            TabSale.Visible = false;
            TabProfit.Visible = false;
            TabPurchase.Visible = true;
        }

        private void BtnSaleTable_Click(object sender, EventArgs e) {
            TabProfit.Visible = false;
            TabPurchase.Visible = false;
            TabSale.Visible = true;
        }

        private void BtnProfitTable_Click(object sender, EventArgs e) {
            TabSale.Visible = false;
            TabPurchase.Visible = false;
            TabProfit.Visible = true;
        }
    }
}
