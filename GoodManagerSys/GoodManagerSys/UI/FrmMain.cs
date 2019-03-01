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
            TlpMainMenu.Visible = false;
            TlpStaffMenu.Visible = true;
            TlpStaffSubmenu.Visible = true;
        }

        private void BtnWarehouse_Click(object sender, EventArgs e) {
            TlpMainMenu.Visible = false;
            TlpWarehouseMenu.Visible = true;
        }

        private void BtnSale_Click(object sender, EventArgs e) {
            TlpMainMenu.Visible = false;
            TlpSaleMenu.Visible = true;
        }

        private void BtnMembership_Click(object sender, EventArgs e) {
            TlpMainMenu.Visible = false;
            TlpMsMenu.Visible = true;
        }

        private void BtnTable_Click(object sender, EventArgs e) {
            TlpMainMenu.Visible = false;
            TlpTableMenu.Visible = true;
        }

        private void BtnStaffBack_Click(object sender, EventArgs e) {
            TlpStaffMenu.Visible = false;
            TlpMainMenu.Visible = true;
            TlpStaffSubmenu.Visible = false;
        }

        private void BtnWarehouseBack_Click(object sender, EventArgs e) {
            TlpWarehouseMenu.Visible = false;
            TlpMainMenu.Visible = true;
        }

        private void BtnSaleBack_Click(object sender, EventArgs e) {
            TlpSaleMenu.Visible = false;
            TlpMainMenu.Visible = true;
        }

        private void BtnMsBack_Click(object sender, EventArgs e) {
            TlpMsMenu.Visible = false;
            TlpMainMenu.Visible = true;
        }

        private void BtnTableBack_Click(object sender, EventArgs e) {
            TlpTableMenu.Visible = false;
            TlpMainMenu.Visible = true;
        }

        private void BtnExit_Click(object sender, EventArgs e) {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void BtnStaffInsert_Click(object sender, EventArgs e) {
            //FrmStaffInsert
        }

        private void BtnStaffDelete_Click(object sender, EventArgs e) {
            //FrmStaffDelete
        }

        private void BtnGoodIncome_Click(object sender, EventArgs e) {
            TlpWarehouseMenu.Visible = false;
            TlpWarehouseSSubmenu.Visible = true;
        }

        private void BtnWarehouseSubmenu_Click(object sender, EventArgs e) {
            TlpWarehouseSSubmenu.Visible = false;
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
            if (TlpWarehouseSubmenu.Visible == false)
                TlpWarehouseSubmenu.Visible = true;
            //读取
        }

        private void BtnSaleGood_Click(object sender, EventArgs e) {
            //FrmSaleInsert
        }
    }
}
