using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmStaffInsert f = new FrmStaffInsert();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmStaffUpdate f = new FrmStaffUpdate();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmStaffDelete f = new FrmStaffDelete();
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmStaffUpdate f = new FrmStaffUpdate();
            f.Show();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            FrmStaffUpdate f = new FrmStaffUpdate();
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmGoodInsert f = new FrmGoodInsert();
            f.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmCategory f = new FrmCategory();
            f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmWarehouseWarning f = new FrmWarehouseWarning();
            f.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FrmSaleInsert f = new FrmSaleInsert();
            f.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FrmMsInsert f = new FrmMsInsert();
            f.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PnlStaff.Parent = PicMainBackground;
            PnlWarehouse.Parent = PicMainBackground;
            PnlSale.Parent = PicMainBackground;
            PnlMembership.Parent = PicMainBackground;
            PnlTable.Parent = PicMainBackground;
        }

        private void TsbStaff_Click(object sender, EventArgs e)
        {
            PnlStaff.Visible = false;
            PnlWarehouse.Visible = false;
            PnlSale.Visible = false;
            PnlMembership.Visible = false;
            PnlTable.Visible = false;
            PnlStaff.Visible = true;
        }

        private void TsbWarehouse_Click(object sender, EventArgs e)
        {

            PnlStaff.Visible = false;
            PnlWarehouse.Visible = false;
            PnlSale.Visible = false;
            PnlMembership.Visible = false;
            PnlTable.Visible = false;
            PnlWarehouse.Visible = true;
        }

        private void TsbSale_Click(object sender, EventArgs e)
        {
            PnlStaff.Visible = false;
            PnlWarehouse.Visible = false;
            PnlSale.Visible = false;
            PnlMembership.Visible = false;
            PnlTable.Visible = false;
            PnlSale.Visible = true;
        }

        private void TsbMembership_Click(object sender, EventArgs e)
        {
            PnlStaff.Visible = false;
            PnlWarehouse.Visible = false;
            PnlSale.Visible = false;
            PnlMembership.Visible = false;
            PnlTable.Visible = false;
            PnlMembership.Visible = true;
        }

        private void TsbTable_Click(object sender, EventArgs e)
        {
            PnlStaff.Visible = false;
            PnlWarehouse.Visible = false;
            PnlSale.Visible = false;
            PnlMembership.Visible = false;
            PnlTable.Visible = false;
            PnlTable.Visible = true;
        }
    }
}
