namespace GoodManagerSys.Frm.Warehouse
{
    partial class FrmPurchaseFromExcel
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
            this.TxtExcelPath = new System.Windows.Forms.TextBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.DgvGoodFromExcel = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TlpPurchaseFomExcel = new System.Windows.Forms.TableLayoutPanel();
            this.TlpPFEControllerMenu = new System.Windows.Forms.TableLayoutPanel();
            this.TlpPFETip = new System.Windows.Forms.TableLayoutPanel();
            this.TlpPFESubmitMenu = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoodFromExcel)).BeginInit();
            this.TlpPurchaseFomExcel.SuspendLayout();
            this.TlpPFEControllerMenu.SuspendLayout();
            this.TlpPFETip.SuspendLayout();
            this.TlpPFESubmitMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtExcelPath
            // 
            this.TxtExcelPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtExcelPath.Location = new System.Drawing.Point(2, 2);
            this.TxtExcelPath.Margin = new System.Windows.Forms.Padding(2);
            this.TxtExcelPath.Name = "TxtExcelPath";
            this.TxtExcelPath.Size = new System.Drawing.Size(570, 21);
            this.TxtExcelPath.TabIndex = 0;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBrowse.Location = new System.Drawing.Point(576, 2);
            this.BtnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(140, 39);
            this.BtnBrowse.TabIndex = 1;
            this.BtnBrowse.Text = "浏览";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // DgvGoodFromExcel
            // 
            this.DgvGoodFromExcel.AllowUserToAddRows = false;
            this.DgvGoodFromExcel.AllowUserToDeleteRows = false;
            this.DgvGoodFromExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGoodFromExcel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DgvGoodFromExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvGoodFromExcel.Location = new System.Drawing.Point(2, 51);
            this.DgvGoodFromExcel.Margin = new System.Windows.Forms.Padding(2);
            this.DgvGoodFromExcel.Name = "DgvGoodFromExcel";
            this.DgvGoodFromExcel.RowTemplate.Height = 37;
            this.DgvGoodFromExcel.Size = new System.Drawing.Size(720, 178);
            this.DgvGoodFromExcel.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 54;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "类别编号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 78;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "生产日期";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 78;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "采购单价";
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
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "数量";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 54;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "有效状态";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 78;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "错误说明";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 78;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSubmit.Location = new System.Drawing.Point(504, 2);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(103, 41);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "提交";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.Location = new System.Drawing.Point(611, 2);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(105, 41);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "\"√\"表示能够正确导入";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(361, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 43);
            this.label2.TabIndex = 7;
            this.label2.Text = "\"×\"表示不能够正确导入，请见错误提示";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TlpPurchaseFomExcel
            // 
            this.TlpPurchaseFomExcel.ColumnCount = 1;
            this.TlpPurchaseFomExcel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPurchaseFomExcel.Controls.Add(this.DgvGoodFromExcel, 0, 1);
            this.TlpPurchaseFomExcel.Controls.Add(this.TlpPFEControllerMenu, 0, 0);
            this.TlpPurchaseFomExcel.Controls.Add(this.TlpPFETip, 0, 2);
            this.TlpPurchaseFomExcel.Controls.Add(this.TlpPFESubmitMenu, 0, 3);
            this.TlpPurchaseFomExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPurchaseFomExcel.Location = new System.Drawing.Point(0, 0);
            this.TlpPurchaseFomExcel.Name = "TlpPurchaseFomExcel";
            this.TlpPurchaseFomExcel.RowCount = 4;
            this.TlpPurchaseFomExcel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpPurchaseFomExcel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.TlpPurchaseFomExcel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpPurchaseFomExcel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpPurchaseFomExcel.Size = new System.Drawing.Size(724, 331);
            this.TlpPurchaseFomExcel.TabIndex = 8;
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
            this.TlpPFEControllerMenu.Size = new System.Drawing.Size(718, 43);
            this.TlpPFEControllerMenu.TabIndex = 3;
            // 
            // TlpPFETip
            // 
            this.TlpPFETip.ColumnCount = 2;
            this.TlpPFETip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPFETip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPFETip.Controls.Add(this.label2, 1, 0);
            this.TlpPFETip.Controls.Add(this.label1, 0, 0);
            this.TlpPFETip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPFETip.Location = new System.Drawing.Point(3, 234);
            this.TlpPFETip.Name = "TlpPFETip";
            this.TlpPFETip.RowCount = 1;
            this.TlpPFETip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPFETip.Size = new System.Drawing.Size(718, 43);
            this.TlpPFETip.TabIndex = 4;
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
            this.TlpPFESubmitMenu.Location = new System.Drawing.Point(3, 283);
            this.TlpPFESubmitMenu.Name = "TlpPFESubmitMenu";
            this.TlpPFESubmitMenu.RowCount = 1;
            this.TlpPFESubmitMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPFESubmitMenu.Size = new System.Drawing.Size(718, 45);
            this.TlpPFESubmitMenu.TabIndex = 5;
            // 
            // FrmPurchaseFromExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 331);
            this.Controls.Add(this.TlpPurchaseFomExcel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPurchaseFromExcel";
            this.Text = "FrmPurchaseFromExcel";
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoodFromExcel)).EndInit();
            this.TlpPurchaseFomExcel.ResumeLayout(false);
            this.TlpPFEControllerMenu.ResumeLayout(false);
            this.TlpPFEControllerMenu.PerformLayout();
            this.TlpPFETip.ResumeLayout(false);
            this.TlpPFETip.PerformLayout();
            this.TlpPFESubmitMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtExcelPath;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.DataGridView DgvGoodFromExcel;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel TlpPurchaseFomExcel;
        private System.Windows.Forms.TableLayoutPanel TlpPFEControllerMenu;
        private System.Windows.Forms.TableLayoutPanel TlpPFETip;
        private System.Windows.Forms.TableLayoutPanel TlpPFESubmitMenu;
    }
}