namespace GoodManagerSys.Frm.Sale {
    partial class FrmSaleFromExcel {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TlpPurchaseFomExcel = new System.Windows.Forms.TableLayoutPanel();
            this.DgvSaleFromExcel = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TlpPFEControllerMenu = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.TxtExcelPath = new System.Windows.Forms.TextBox();
            this.TlpPFETip = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TlpPFESubmitMenu = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TlpPurchaseFomExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaleFromExcel)).BeginInit();
            this.TlpPFEControllerMenu.SuspendLayout();
            this.TlpPFETip.SuspendLayout();
            this.TlpPFESubmitMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPurchaseFomExcel
            // 
            this.TlpPurchaseFomExcel.ColumnCount = 1;
            this.TlpPurchaseFomExcel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPurchaseFomExcel.Controls.Add(this.DgvSaleFromExcel, 0, 1);
            this.TlpPurchaseFomExcel.Controls.Add(this.TlpPFEControllerMenu, 0, 0);
            this.TlpPurchaseFomExcel.Controls.Add(this.TlpPFETip, 0, 2);
            this.TlpPurchaseFomExcel.Controls.Add(this.TlpPFESubmitMenu, 0, 3);
            this.TlpPurchaseFomExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPurchaseFomExcel.Location = new System.Drawing.Point(0, 0);
            this.TlpPurchaseFomExcel.Name = "TlpPurchaseFomExcel";
            this.TlpPurchaseFomExcel.RowCount = 4;
            this.TlpPurchaseFomExcel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.TlpPurchaseFomExcel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.TlpPurchaseFomExcel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpPurchaseFomExcel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpPurchaseFomExcel.Size = new System.Drawing.Size(539, 298);
            this.TlpPurchaseFomExcel.TabIndex = 9;
            // 
            // DgvSaleFromExcel
            // 
            this.DgvSaleFromExcel.AllowUserToAddRows = false;
            this.DgvSaleFromExcel.AllowUserToDeleteRows = false;
            this.DgvSaleFromExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSaleFromExcel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column1});
            this.DgvSaleFromExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSaleFromExcel.Location = new System.Drawing.Point(2, 37);
            this.DgvSaleFromExcel.Margin = new System.Windows.Forms.Padding(2);
            this.DgvSaleFromExcel.Name = "DgvSaleFromExcel";
            this.DgvSaleFromExcel.RowTemplate.Height = 37;
            this.DgvSaleFromExcel.Size = new System.Drawing.Size(535, 198);
            this.DgvSaleFromExcel.TabIndex = 2;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "编号";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "商品编号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 78;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "商品名称";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 78;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "计量单位";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 78;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "售价";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 54;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "错误说明";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // TlpPFEControllerMenu
            // 
            this.TlpPFEControllerMenu.ColumnCount = 2;
            this.TlpPFEControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TlpPFEControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpPFEControllerMenu.Controls.Add(this.BtnBrowse, 1, 0);
            this.TlpPFEControllerMenu.Controls.Add(this.TxtExcelPath, 0, 0);
            this.TlpPFEControllerMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPFEControllerMenu.Location = new System.Drawing.Point(3, 3);
            this.TlpPFEControllerMenu.Name = "TlpPFEControllerMenu";
            this.TlpPFEControllerMenu.RowCount = 1;
            this.TlpPFEControllerMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPFEControllerMenu.Size = new System.Drawing.Size(533, 29);
            this.TlpPFEControllerMenu.TabIndex = 3;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBrowse.Location = new System.Drawing.Point(428, 2);
            this.BtnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(103, 25);
            this.BtnBrowse.TabIndex = 1;
            this.BtnBrowse.Text = "浏览";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TxtExcelPath
            // 
            this.TxtExcelPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtExcelPath.Location = new System.Drawing.Point(2, 2);
            this.TxtExcelPath.Margin = new System.Windows.Forms.Padding(2);
            this.TxtExcelPath.Name = "TxtExcelPath";
            this.TxtExcelPath.Size = new System.Drawing.Size(422, 21);
            this.TxtExcelPath.TabIndex = 0;
            // 
            // TlpPFETip
            // 
            this.TlpPFETip.ColumnCount = 2;
            this.TlpPFETip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPFETip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPFETip.Controls.Add(this.label2, 1, 0);
            this.TlpPFETip.Controls.Add(this.label1, 0, 0);
            this.TlpPFETip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPFETip.Location = new System.Drawing.Point(3, 240);
            this.TlpPFETip.Name = "TlpPFETip";
            this.TlpPFETip.RowCount = 1;
            this.TlpPFETip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPFETip.Size = new System.Drawing.Size(533, 23);
            this.TlpPFETip.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(268, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "\"×\"表示不能够正确导入，请见错误提示";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "\"√\"表示能够正确导入";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TlpPFESubmitMenu
            // 
            this.TlpPFESubmitMenu.ColumnCount = 3;
            this.TlpPFESubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TlpPFESubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpPFESubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpPFESubmitMenu.Controls.Add(this.BtnSubmit, 1, 0);
            this.TlpPFESubmitMenu.Controls.Add(this.BtnCancel, 2, 0);
            this.TlpPFESubmitMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPFESubmitMenu.Location = new System.Drawing.Point(3, 269);
            this.TlpPFESubmitMenu.Name = "TlpPFESubmitMenu";
            this.TlpPFESubmitMenu.RowCount = 1;
            this.TlpPFESubmitMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPFESubmitMenu.Size = new System.Drawing.Size(533, 26);
            this.TlpPFESubmitMenu.TabIndex = 5;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSubmit.Location = new System.Drawing.Point(375, 2);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 22);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "提交";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.Location = new System.Drawing.Point(454, 2);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(77, 22);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmSaleFromExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 298);
            this.Controls.Add(this.TlpPurchaseFomExcel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSaleFromExcel";
            this.Text = "FrmSaleFromExcel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSaleFromExcel_FormClosing);
            this.TlpPurchaseFomExcel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaleFromExcel)).EndInit();
            this.TlpPFEControllerMenu.ResumeLayout(false);
            this.TlpPFEControllerMenu.PerformLayout();
            this.TlpPFETip.ResumeLayout(false);
            this.TlpPFETip.PerformLayout();
            this.TlpPFESubmitMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPurchaseFomExcel;
        private System.Windows.Forms.DataGridView DgvSaleFromExcel;
        private System.Windows.Forms.TableLayoutPanel TlpPFEControllerMenu;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TxtExcelPath;
        private System.Windows.Forms.TableLayoutPanel TlpPFETip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel TlpPFESubmitMenu;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}