namespace GoodManagerSys.Frm.Warehouse
{
    partial class FrmGoodIncome
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
            this.DgvGoodIncome = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnComfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbOperator = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPurchaseID = new System.Windows.Forms.TextBox();
            this.BtnMIncome = new System.Windows.Forms.Button();
            this.BtnSIncome = new System.Windows.Forms.Button();
            this.TlpGoodIncome = new System.Windows.Forms.TableLayoutPanel();
            this.TlpGIControllerMenu = new System.Windows.Forms.TableLayoutPanel();
            this.TlpGISubmitMenu = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoodIncome)).BeginInit();
            this.TlpGoodIncome.SuspendLayout();
            this.TlpGIControllerMenu.SuspendLayout();
            this.TlpGISubmitMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvGoodIncome
            // 
            this.DgvGoodIncome.AllowUserToAddRows = false;
            this.DgvGoodIncome.AllowUserToDeleteRows = false;
            this.DgvGoodIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGoodIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column10,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.DgvGoodIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvGoodIncome.Location = new System.Drawing.Point(2, 33);
            this.DgvGoodIncome.Margin = new System.Windows.Forms.Padding(2);
            this.DgvGoodIncome.Name = "DgvGoodIncome";
            this.DgvGoodIncome.RowTemplate.Height = 37;
            this.DgvGoodIncome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGoodIncome.Size = new System.Drawing.Size(713, 248);
            this.DgvGoodIncome.TabIndex = 2;
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
            this.Column2.HeaderText = "商品名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 78;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "类别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 54;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "单位";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 54;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "厂商";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 54;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "生产日期";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 78;
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
            this.Column7.HeaderText = "进价";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 54;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "售价";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 54;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "状态";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 54;
            // 
            // BtnComfirm
            // 
            this.BtnComfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnComfirm.Location = new System.Drawing.Point(474, 2);
            this.BtnComfirm.Margin = new System.Windows.Forms.Padding(2);
            this.BtnComfirm.Name = "BtnComfirm";
            this.BtnComfirm.Size = new System.Drawing.Size(114, 23);
            this.BtnComfirm.TabIndex = 3;
            this.BtnComfirm.Text = "确定";
            this.BtnComfirm.UseVisualStyleBackColor = true;
            this.BtnComfirm.Click += new System.EventHandler(this.BtnComfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(356, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "进货日期";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DtpPurchaseDate
            // 
            this.DtpPurchaseDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtpPurchaseDate.Location = new System.Drawing.Point(533, 2);
            this.DtpPurchaseDate.Margin = new System.Windows.Forms.Padding(2);
            this.DtpPurchaseDate.Name = "DtpPurchaseDate";
            this.DtpPurchaseDate.Size = new System.Drawing.Size(176, 21);
            this.DtpPurchaseDate.TabIndex = 5;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.Location = new System.Drawing.Point(592, 2);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(117, 23);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "经办人";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbOperator
            // 
            this.CmbOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbOperator.FormattingEnabled = true;
            this.CmbOperator.Location = new System.Drawing.Point(120, 2);
            this.CmbOperator.Margin = new System.Windows.Forms.Padding(2);
            this.CmbOperator.Name = "CmbOperator";
            this.CmbOperator.Size = new System.Drawing.Size(114, 20);
            this.CmbOperator.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(238, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "初始单号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPurchaseID
            // 
            this.TxtPurchaseID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPurchaseID.Location = new System.Drawing.Point(356, 2);
            this.TxtPurchaseID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPurchaseID.Name = "TxtPurchaseID";
            this.TxtPurchaseID.Size = new System.Drawing.Size(114, 21);
            this.TxtPurchaseID.TabIndex = 10;
            // 
            // BtnMIncome
            // 
            this.BtnMIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMIncome.Location = new System.Drawing.Point(179, 2);
            this.BtnMIncome.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMIncome.Name = "BtnMIncome";
            this.BtnMIncome.Size = new System.Drawing.Size(173, 21);
            this.BtnMIncome.TabIndex = 1;
            this.BtnMIncome.Text = "批量商品入库";
            this.BtnMIncome.UseVisualStyleBackColor = true;
            this.BtnMIncome.Click += new System.EventHandler(this.BtnMIncome_Click);
            // 
            // BtnSIncome
            // 
            this.BtnSIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSIncome.Location = new System.Drawing.Point(2, 2);
            this.BtnSIncome.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSIncome.Name = "BtnSIncome";
            this.BtnSIncome.Size = new System.Drawing.Size(173, 21);
            this.BtnSIncome.TabIndex = 0;
            this.BtnSIncome.Text = "单个商品入库";
            this.BtnSIncome.UseVisualStyleBackColor = true;
            this.BtnSIncome.Click += new System.EventHandler(this.BtnSIncome_Click);
            // 
            // TlpGoodIncome
            // 
            this.TlpGoodIncome.ColumnCount = 1;
            this.TlpGoodIncome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGoodIncome.Controls.Add(this.DgvGoodIncome, 0, 1);
            this.TlpGoodIncome.Controls.Add(this.TlpGIControllerMenu, 0, 0);
            this.TlpGoodIncome.Controls.Add(this.TlpGISubmitMenu, 0, 2);
            this.TlpGoodIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGoodIncome.Location = new System.Drawing.Point(0, 0);
            this.TlpGoodIncome.Name = "TlpGoodIncome";
            this.TlpGoodIncome.RowCount = 3;
            this.TlpGoodIncome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpGoodIncome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TlpGoodIncome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpGoodIncome.Size = new System.Drawing.Size(717, 316);
            this.TlpGoodIncome.TabIndex = 11;
            // 
            // TlpGIControllerMenu
            // 
            this.TlpGIControllerMenu.ColumnCount = 4;
            this.TlpGIControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpGIControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpGIControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpGIControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpGIControllerMenu.Controls.Add(this.BtnSIncome, 0, 0);
            this.TlpGIControllerMenu.Controls.Add(this.BtnMIncome, 1, 0);
            this.TlpGIControllerMenu.Controls.Add(this.label1, 2, 0);
            this.TlpGIControllerMenu.Controls.Add(this.DtpPurchaseDate, 3, 0);
            this.TlpGIControllerMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGIControllerMenu.Location = new System.Drawing.Point(3, 3);
            this.TlpGIControllerMenu.Name = "TlpGIControllerMenu";
            this.TlpGIControllerMenu.RowCount = 1;
            this.TlpGIControllerMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGIControllerMenu.Size = new System.Drawing.Size(711, 25);
            this.TlpGIControllerMenu.TabIndex = 3;
            // 
            // TlpGISubmitMenu
            // 
            this.TlpGISubmitMenu.ColumnCount = 6;
            this.TlpGISubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpGISubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpGISubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpGISubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpGISubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpGISubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpGISubmitMenu.Controls.Add(this.label2, 0, 0);
            this.TlpGISubmitMenu.Controls.Add(this.BtnCancel, 5, 0);
            this.TlpGISubmitMenu.Controls.Add(this.TxtPurchaseID, 3, 0);
            this.TlpGISubmitMenu.Controls.Add(this.BtnComfirm, 4, 0);
            this.TlpGISubmitMenu.Controls.Add(this.CmbOperator, 1, 0);
            this.TlpGISubmitMenu.Controls.Add(this.label3, 2, 0);
            this.TlpGISubmitMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGISubmitMenu.Location = new System.Drawing.Point(3, 286);
            this.TlpGISubmitMenu.Name = "TlpGISubmitMenu";
            this.TlpGISubmitMenu.RowCount = 1;
            this.TlpGISubmitMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGISubmitMenu.Size = new System.Drawing.Size(711, 27);
            this.TlpGISubmitMenu.TabIndex = 4;
            // 
            // FrmGoodIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 316);
            this.Controls.Add(this.TlpGoodIncome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGoodIncome";
            this.Text = "FrmGoodIncome";
//            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGoodIncome_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoodIncome)).EndInit();
            this.TlpGoodIncome.ResumeLayout(false);
            this.TlpGIControllerMenu.ResumeLayout(false);
            this.TlpGIControllerMenu.PerformLayout();
            this.TlpGISubmitMenu.ResumeLayout(false);
            this.TlpGISubmitMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvGoodIncome;
        private System.Windows.Forms.Button BtnComfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpPurchaseDate;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPurchaseID;
        private System.Windows.Forms.Button BtnMIncome;
        private System.Windows.Forms.Button BtnSIncome;
        private System.Windows.Forms.TableLayoutPanel TlpGoodIncome;
        private System.Windows.Forms.TableLayoutPanel TlpGIControllerMenu;
        private System.Windows.Forms.TableLayoutPanel TlpGISubmitMenu;
    }
}