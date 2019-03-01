namespace WindowsFormsApp1
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.PnlStaff = new System.Windows.Forms.Panel();
            this.BtnStaffInsert = new System.Windows.Forms.Button();
            this.DgvStaff = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnStaffDelete = new System.Windows.Forms.Button();
            this.PnlWarehouse = new System.Windows.Forms.Panel();
            this.DgvWarehouse = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGoodSearch = new System.Windows.Forms.Button();
            this.BtnGoodManager = new System.Windows.Forms.Button();
            this.BtnGoodIncome = new System.Windows.Forms.Button();
            this.BtnGoodWarning = new System.Windows.Forms.Button();
            this.PnlSale = new System.Windows.Forms.Panel();
            this.DgvSale = new System.Windows.Forms.DataGridView();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSaleSearch = new System.Windows.Forms.Button();
            this.BtnSale = new System.Windows.Forms.Button();
            this.PnlMembership = new System.Windows.Forms.Panel();
            this.DgvMembership = new System.Windows.Forms.DataGridView();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnMembershipSignup = new System.Windows.Forms.Button();
            this.BtnMembershipClose = new System.Windows.Forms.Button();
            this.PnlTable = new System.Windows.Forms.Panel();
            this.BtnProfitTable = new System.Windows.Forms.Button();
            this.BtnSaleTable = new System.Windows.Forms.Button();
            this.BtnPurchaseTable = new System.Windows.Forms.Button();
            this.TsrMenu = new System.Windows.Forms.ToolStrip();
            this.TsbStaff = new System.Windows.Forms.ToolStripButton();
            this.TsbWarehouse = new System.Windows.Forms.ToolStripButton();
            this.TsbSale = new System.Windows.Forms.ToolStripButton();
            this.TsbMembership = new System.Windows.Forms.ToolStripButton();
            this.TsbTable = new System.Windows.Forms.ToolStripButton();
            this.TsbExit = new System.Windows.Forms.ToolStripButton();
            this.PicMainBackground = new System.Windows.Forms.PictureBox();
            this.PnlStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStaff)).BeginInit();
            this.PnlWarehouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvWarehouse)).BeginInit();
            this.PnlSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSale)).BeginInit();
            this.PnlMembership.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMembership)).BeginInit();
            this.PnlTable.SuspendLayout();
            this.TsrMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMainBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlStaff
            // 
            this.PnlStaff.BackColor = System.Drawing.Color.Transparent;
            this.PnlStaff.Controls.Add(this.BtnStaffInsert);
            this.PnlStaff.Controls.Add(this.DgvStaff);
            this.PnlStaff.Controls.Add(this.BtnStaffDelete);
            this.PnlStaff.Location = new System.Drawing.Point(152, 88);
            this.PnlStaff.Margin = new System.Windows.Forms.Padding(2);
            this.PnlStaff.Name = "PnlStaff";
            this.PnlStaff.Size = new System.Drawing.Size(496, 303);
            this.PnlStaff.TabIndex = 8;
            this.PnlStaff.Visible = false;
            // 
            // BtnStaffInsert
            // 
            this.BtnStaffInsert.Location = new System.Drawing.Point(2, 2);
            this.BtnStaffInsert.Margin = new System.Windows.Forms.Padding(2);
            this.BtnStaffInsert.Name = "BtnStaffInsert";
            this.BtnStaffInsert.Size = new System.Drawing.Size(103, 37);
            this.BtnStaffInsert.TabIndex = 4;
            this.BtnStaffInsert.Text = "添加员工";
            this.BtnStaffInsert.UseVisualStyleBackColor = true;
            // 
            // DgvStaff
            // 
            this.DgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvStaff.Location = new System.Drawing.Point(2, 51);
            this.DgvStaff.Margin = new System.Windows.Forms.Padding(2);
            this.DgvStaff.Name = "DgvStaff";
            this.DgvStaff.RowTemplate.Height = 27;
            this.DgvStaff.Size = new System.Drawing.Size(398, 225);
            this.DgvStaff.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "员工编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "员工姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "密码";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "手机号";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "员工权限";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // BtnStaffDelete
            // 
            this.BtnStaffDelete.Location = new System.Drawing.Point(110, 2);
            this.BtnStaffDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BtnStaffDelete.Name = "BtnStaffDelete";
            this.BtnStaffDelete.Size = new System.Drawing.Size(103, 37);
            this.BtnStaffDelete.TabIndex = 2;
            this.BtnStaffDelete.Text = "删除员工";
            this.BtnStaffDelete.UseVisualStyleBackColor = true;
            // 
            // PnlWarehouse
            // 
            this.PnlWarehouse.BackColor = System.Drawing.Color.Transparent;
            this.PnlWarehouse.Controls.Add(this.DgvWarehouse);
            this.PnlWarehouse.Controls.Add(this.BtnGoodSearch);
            this.PnlWarehouse.Controls.Add(this.BtnGoodManager);
            this.PnlWarehouse.Controls.Add(this.BtnGoodIncome);
            this.PnlWarehouse.Controls.Add(this.BtnGoodWarning);
            this.PnlWarehouse.Location = new System.Drawing.Point(220, 10);
            this.PnlWarehouse.Margin = new System.Windows.Forms.Padding(2);
            this.PnlWarehouse.Name = "PnlWarehouse";
            this.PnlWarehouse.Size = new System.Drawing.Size(571, 343);
            this.PnlWarehouse.TabIndex = 9;
            this.PnlWarehouse.Visible = false;
            // 
            // DgvWarehouse
            // 
            this.DgvWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvWarehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.DgvWarehouse.Location = new System.Drawing.Point(2, 44);
            this.DgvWarehouse.Margin = new System.Windows.Forms.Padding(2);
            this.DgvWarehouse.Name = "DgvWarehouse";
            this.DgvWarehouse.RowTemplate.Height = 27;
            this.DgvWarehouse.Size = new System.Drawing.Size(557, 253);
            this.DgvWarehouse.TabIndex = 9;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "商品编号";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "商品类别";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "生产日期";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "采购日期";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "采购单价";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "售价";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "有效状态";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // BtnGoodSearch
            // 
            this.BtnGoodSearch.Location = new System.Drawing.Point(324, 2);
            this.BtnGoodSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGoodSearch.Name = "BtnGoodSearch";
            this.BtnGoodSearch.Size = new System.Drawing.Size(103, 37);
            this.BtnGoodSearch.TabIndex = 4;
            this.BtnGoodSearch.Text = "库存查询";
            this.BtnGoodSearch.UseVisualStyleBackColor = true;
            // 
            // BtnGoodManager
            // 
            this.BtnGoodManager.Location = new System.Drawing.Point(110, 2);
            this.BtnGoodManager.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGoodManager.Name = "BtnGoodManager";
            this.BtnGoodManager.Size = new System.Drawing.Size(103, 37);
            this.BtnGoodManager.TabIndex = 3;
            this.BtnGoodManager.Text = "商品管理";
            this.BtnGoodManager.UseVisualStyleBackColor = true;
            // 
            // BtnGoodIncome
            // 
            this.BtnGoodIncome.Location = new System.Drawing.Point(2, 2);
            this.BtnGoodIncome.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGoodIncome.Name = "BtnGoodIncome";
            this.BtnGoodIncome.Size = new System.Drawing.Size(103, 37);
            this.BtnGoodIncome.TabIndex = 2;
            this.BtnGoodIncome.Text = "入库";
            this.BtnGoodIncome.UseVisualStyleBackColor = true;
            // 
            // BtnGoodWarning
            // 
            this.BtnGoodWarning.Location = new System.Drawing.Point(217, 2);
            this.BtnGoodWarning.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGoodWarning.Name = "BtnGoodWarning";
            this.BtnGoodWarning.Size = new System.Drawing.Size(103, 37);
            this.BtnGoodWarning.TabIndex = 1;
            this.BtnGoodWarning.Text = "库存预警";
            this.BtnGoodWarning.UseVisualStyleBackColor = true;
            // 
            // PnlSale
            // 
            this.PnlSale.BackColor = System.Drawing.Color.Transparent;
            this.PnlSale.Controls.Add(this.DgvSale);
            this.PnlSale.Controls.Add(this.BtnSaleSearch);
            this.PnlSale.Controls.Add(this.BtnSale);
            this.PnlSale.Location = new System.Drawing.Point(168, 64);
            this.PnlSale.Margin = new System.Windows.Forms.Padding(2);
            this.PnlSale.Name = "PnlSale";
            this.PnlSale.Size = new System.Drawing.Size(513, 327);
            this.PnlSale.TabIndex = 10;
            this.PnlSale.Visible = false;
            // 
            // DgvSale
            // 
            this.DgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column18,
            this.Column19});
            this.DgvSale.Location = new System.Drawing.Point(0, 55);
            this.DgvSale.Margin = new System.Windows.Forms.Padding(2);
            this.DgvSale.Name = "DgvSale";
            this.DgvSale.RowTemplate.Height = 27;
            this.DgvSale.Size = new System.Drawing.Size(411, 228);
            this.DgvSale.TabIndex = 4;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "销售单编号";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "商品编号";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "销售时间";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "盈利";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "员工编号";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // BtnSaleSearch
            // 
            this.BtnSaleSearch.Location = new System.Drawing.Point(110, 2);
            this.BtnSaleSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSaleSearch.Name = "BtnSaleSearch";
            this.BtnSaleSearch.Size = new System.Drawing.Size(103, 37);
            this.BtnSaleSearch.TabIndex = 2;
            this.BtnSaleSearch.Text = "销售单查询";
            this.BtnSaleSearch.UseVisualStyleBackColor = true;
            // 
            // BtnSale
            // 
            this.BtnSale.Location = new System.Drawing.Point(2, 2);
            this.BtnSale.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSale.Name = "BtnSale";
            this.BtnSale.Size = new System.Drawing.Size(103, 37);
            this.BtnSale.TabIndex = 1;
            this.BtnSale.Text = "销售商品";
            this.BtnSale.UseVisualStyleBackColor = true;
            // 
            // PnlMembership
            // 
            this.PnlMembership.BackColor = System.Drawing.Color.Transparent;
            this.PnlMembership.Controls.Add(this.DgvMembership);
            this.PnlMembership.Controls.Add(this.BtnMembershipSignup);
            this.PnlMembership.Controls.Add(this.BtnMembershipClose);
            this.PnlMembership.Location = new System.Drawing.Point(188, 48);
            this.PnlMembership.Margin = new System.Windows.Forms.Padding(2);
            this.PnlMembership.Name = "PnlMembership";
            this.PnlMembership.Size = new System.Drawing.Size(461, 341);
            this.PnlMembership.TabIndex = 11;
            this.PnlMembership.Visible = false;
            // 
            // DgvMembership
            // 
            this.DgvMembership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMembership.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24});
            this.DgvMembership.Location = new System.Drawing.Point(2, 54);
            this.DgvMembership.Margin = new System.Windows.Forms.Padding(2);
            this.DgvMembership.Name = "DgvMembership";
            this.DgvMembership.RowTemplate.Height = 27;
            this.DgvMembership.Size = new System.Drawing.Size(398, 225);
            this.DgvMembership.TabIndex = 5;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "会员编号";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "会员姓名";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "手机号";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            // 
            // Column23
            // 
            this.Column23.HeaderText = "积分";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            // 
            // Column24
            // 
            this.Column24.HeaderText = "有效状态";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            // 
            // BtnMembershipSignup
            // 
            this.BtnMembershipSignup.Location = new System.Drawing.Point(2, 2);
            this.BtnMembershipSignup.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMembershipSignup.Name = "BtnMembershipSignup";
            this.BtnMembershipSignup.Size = new System.Drawing.Size(103, 37);
            this.BtnMembershipSignup.TabIndex = 2;
            this.BtnMembershipSignup.Text = "会员注册";
            this.BtnMembershipSignup.UseVisualStyleBackColor = true;
            // 
            // BtnMembershipClose
            // 
            this.BtnMembershipClose.Location = new System.Drawing.Point(110, 2);
            this.BtnMembershipClose.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMembershipClose.Name = "BtnMembershipClose";
            this.BtnMembershipClose.Size = new System.Drawing.Size(103, 37);
            this.BtnMembershipClose.TabIndex = 1;
            this.BtnMembershipClose.Text = "销户";
            this.BtnMembershipClose.UseVisualStyleBackColor = true;
            // 
            // PnlTable
            // 
            this.PnlTable.BackColor = System.Drawing.Color.Transparent;
            this.PnlTable.Controls.Add(this.BtnProfitTable);
            this.PnlTable.Controls.Add(this.BtnSaleTable);
            this.PnlTable.Controls.Add(this.BtnPurchaseTable);
            this.PnlTable.Location = new System.Drawing.Point(208, 26);
            this.PnlTable.Margin = new System.Windows.Forms.Padding(2);
            this.PnlTable.Name = "PnlTable";
            this.PnlTable.Size = new System.Drawing.Size(344, 314);
            this.PnlTable.TabIndex = 12;
            this.PnlTable.Visible = false;
            // 
            // BtnProfitTable
            // 
            this.BtnProfitTable.Location = new System.Drawing.Point(217, 2);
            this.BtnProfitTable.Margin = new System.Windows.Forms.Padding(2);
            this.BtnProfitTable.Name = "BtnProfitTable";
            this.BtnProfitTable.Size = new System.Drawing.Size(103, 37);
            this.BtnProfitTable.TabIndex = 5;
            this.BtnProfitTable.Text = "营收报表";
            this.BtnProfitTable.UseVisualStyleBackColor = true;
            // 
            // BtnSaleTable
            // 
            this.BtnSaleTable.Location = new System.Drawing.Point(110, 2);
            this.BtnSaleTable.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSaleTable.Name = "BtnSaleTable";
            this.BtnSaleTable.Size = new System.Drawing.Size(103, 37);
            this.BtnSaleTable.TabIndex = 4;
            this.BtnSaleTable.Text = "销售报表";
            this.BtnSaleTable.UseVisualStyleBackColor = true;
            // 
            // BtnPurchaseTable
            // 
            this.BtnPurchaseTable.Location = new System.Drawing.Point(2, 2);
            this.BtnPurchaseTable.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPurchaseTable.Name = "BtnPurchaseTable";
            this.BtnPurchaseTable.Size = new System.Drawing.Size(103, 37);
            this.BtnPurchaseTable.TabIndex = 3;
            this.BtnPurchaseTable.Text = "采购报表";
            this.BtnPurchaseTable.UseVisualStyleBackColor = true;
            // 
            // TsrMenu
            // 
            this.TsrMenu.AutoSize = false;
            this.TsrMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TsrMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.TsrMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TsrMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbStaff,
            this.TsbWarehouse,
            this.TsbSale,
            this.TsbMembership,
            this.TsbTable,
            this.TsbExit});
            this.TsrMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.TsrMenu.Location = new System.Drawing.Point(0, 0);
            this.TsrMenu.Name = "TsrMenu";
            this.TsrMenu.Size = new System.Drawing.Size(150, 570);
            this.TsrMenu.TabIndex = 13;
            this.TsrMenu.Text = "TsrMenu";
            // 
            // TsbStaff
            // 
            this.TsbStaff.AutoSize = false;
            this.TsbStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TsbStaff.BackgroundImage")));
            this.TsbStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TsbStaff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbStaff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbStaff.Name = "TsbStaff";
            this.TsbStaff.Size = new System.Drawing.Size(145, 60);
            this.TsbStaff.Text = "TsbStaff";
            this.TsbStaff.Click += new System.EventHandler(this.TsbStaff_Click);
            // 
            // TsbWarehouse
            // 
            this.TsbWarehouse.AutoSize = false;
            this.TsbWarehouse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TsbWarehouse.BackgroundImage")));
            this.TsbWarehouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TsbWarehouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbWarehouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbWarehouse.Name = "TsbWarehouse";
            this.TsbWarehouse.Size = new System.Drawing.Size(145, 60);
            this.TsbWarehouse.Text = "TsbWarehouse";
            this.TsbWarehouse.Click += new System.EventHandler(this.TsbWarehouse_Click);
            // 
            // TsbSale
            // 
            this.TsbSale.AutoSize = false;
            this.TsbSale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TsbSale.BackgroundImage")));
            this.TsbSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TsbSale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSale.Name = "TsbSale";
            this.TsbSale.Size = new System.Drawing.Size(145, 60);
            this.TsbSale.Text = "TsbSale";
            this.TsbSale.Click += new System.EventHandler(this.TsbSale_Click);
            // 
            // TsbMembership
            // 
            this.TsbMembership.AutoSize = false;
            this.TsbMembership.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TsbMembership.BackgroundImage")));
            this.TsbMembership.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TsbMembership.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbMembership.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbMembership.Name = "TsbMembership";
            this.TsbMembership.Size = new System.Drawing.Size(145, 60);
            this.TsbMembership.Text = "TsbMembership";
            this.TsbMembership.Click += new System.EventHandler(this.TsbMembership_Click);
            // 
            // TsbTable
            // 
            this.TsbTable.AutoSize = false;
            this.TsbTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TsbTable.BackgroundImage")));
            this.TsbTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TsbTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbTable.Name = "TsbTable";
            this.TsbTable.Size = new System.Drawing.Size(145, 60);
            this.TsbTable.Text = "TsbTable";
            this.TsbTable.Click += new System.EventHandler(this.TsbTable_Click);
            // 
            // TsbExit
            // 
            this.TsbExit.AutoSize = false;
            this.TsbExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TsbExit.BackgroundImage")));
            this.TsbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbExit.Name = "TsbExit";
            this.TsbExit.Size = new System.Drawing.Size(145, 60);
            this.TsbExit.Text = "TsbExit";
            // 
            // PicMainBackground
            // 
            this.PicMainBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicMainBackground.Image = ((System.Drawing.Image)(resources.GetObject("PicMainBackground.Image")));
            this.PicMainBackground.Location = new System.Drawing.Point(0, 0);
            this.PicMainBackground.Margin = new System.Windows.Forms.Padding(2);
            this.PicMainBackground.Name = "PicMainBackground";
            this.PicMainBackground.Size = new System.Drawing.Size(740, 570);
            this.PicMainBackground.TabIndex = 14;
            this.PicMainBackground.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 570);
            this.Controls.Add(this.TsrMenu);
            this.Controls.Add(this.PnlTable);
            this.Controls.Add(this.PnlMembership);
            this.Controls.Add(this.PnlSale);
            this.Controls.Add(this.PnlWarehouse);
            this.Controls.Add(this.PnlStaff);
            this.Controls.Add(this.PicMainBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "商品管理系统";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.PnlStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStaff)).EndInit();
            this.PnlWarehouse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvWarehouse)).EndInit();
            this.PnlSale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSale)).EndInit();
            this.PnlMembership.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMembership)).EndInit();
            this.PnlTable.ResumeLayout(false);
            this.TsrMenu.ResumeLayout(false);
            this.TsrMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMainBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlStaff;
        private System.Windows.Forms.Button BtnStaffInsert;
        private System.Windows.Forms.DataGridView DgvStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnStafffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnStaffPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnStaffPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnStafffRole;
        private System.Windows.Forms.Button BtnStaffDelete;
        private System.Windows.Forms.Panel PnlWarehouse;
        private System.Windows.Forms.DataGridView DgvWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnGoodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnGoodCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnGoodProductionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnGoodPurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnGoodCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnGoodPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnGoodState;
        private System.Windows.Forms.Button BtnGoodSearch;
        private System.Windows.Forms.Button BtnGoodManager;
        private System.Windows.Forms.Button BtnGoodIncome;
        private System.Windows.Forms.Button BtnGoodWarning;
        private System.Windows.Forms.Panel PnlSale;
        private System.Windows.Forms.DataGridView DgvSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnSaleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnSaleGoodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnSaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnSaleProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnSaleStaffID;
        private System.Windows.Forms.Button BtnSaleSearch;
        private System.Windows.Forms.Button BtnSale;
        private System.Windows.Forms.Panel PnlMembership;
        private System.Windows.Forms.DataGridView DgvMembership;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnMembershipID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnMembershipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnMmembershipPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnMembershipPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnMembershipIsValid;
        private System.Windows.Forms.Button BtnMembershipSignup;
        private System.Windows.Forms.Button BtnMembershipClose;
        private System.Windows.Forms.Panel PnlTable;
        private System.Windows.Forms.Button BtnProfitTable;
        private System.Windows.Forms.Button BtnSaleTable;
        private System.Windows.Forms.Button BtnPurchaseTable;
        private System.Windows.Forms.ToolStrip TsrMenu;
        private System.Windows.Forms.ToolStripButton TsbWarehouse;
        private System.Windows.Forms.ToolStripButton TsbSale;
        private System.Windows.Forms.ToolStripButton TsbMembership;
        private System.Windows.Forms.ToolStripButton TsbTable;
        private System.Windows.Forms.ToolStripButton TsbExit;
        private System.Windows.Forms.PictureBox PicMainBackground;
        private System.Windows.Forms.ToolStripButton TsbStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
    }
}