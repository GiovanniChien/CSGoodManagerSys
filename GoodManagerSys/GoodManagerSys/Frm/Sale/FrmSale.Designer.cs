namespace GoodManagerSys.Frm.Sale {
    partial class FrmSale {
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
            this.TlpSale = new System.Windows.Forms.TableLayoutPanel();
            this.TlpSaleSubmitMenu = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSaleCancel = new System.Windows.Forms.Button();
            this.BtnSaleSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbOperator = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSaleID = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.DgvSaleInsert = new System.Windows.Forms.DataGridView();
            this.ClnStaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnGoodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TlpSaleControllerMenu = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSingleSaleInsert = new System.Windows.Forms.Button();
            this.BtnMultiSaleInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.TlpSale.SuspendLayout();
            this.TlpSaleSubmitMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaleInsert)).BeginInit();
            this.TlpSaleControllerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpSale
            // 
            this.TlpSale.ColumnCount = 1;
            this.TlpSale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSale.Controls.Add(this.TlpSaleSubmitMenu, 0, 2);
            this.TlpSale.Controls.Add(this.DgvSaleInsert, 0, 1);
            this.TlpSale.Controls.Add(this.TlpSaleControllerMenu, 0, 0);
            this.TlpSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpSale.Location = new System.Drawing.Point(0, 0);
            this.TlpSale.Name = "TlpSale";
            this.TlpSale.RowCount = 3;
            this.TlpSale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpSale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TlpSale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpSale.Size = new System.Drawing.Size(507, 321);
            this.TlpSale.TabIndex = 4;
            // 
            // TlpSaleSubmitMenu
            // 
            this.TlpSaleSubmitMenu.ColumnCount = 7;
            this.TlpSaleSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.TlpSaleSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.TlpSaleSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.TlpSaleSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.TlpSaleSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.TlpSaleSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.TlpSaleSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.TlpSaleSubmitMenu.Controls.Add(this.BtnSaleCancel, 5, 0);
            this.TlpSaleSubmitMenu.Controls.Add(this.BtnSaleSubmit, 4, 0);
            this.TlpSaleSubmitMenu.Controls.Add(this.label2, 0, 0);
            this.TlpSaleSubmitMenu.Controls.Add(this.CmbOperator, 1, 0);
            this.TlpSaleSubmitMenu.Controls.Add(this.label3, 2, 0);
            this.TlpSaleSubmitMenu.Controls.Add(this.LblSaleID, 3, 0);
            this.TlpSaleSubmitMenu.Controls.Add(this.BtnBack, 6, 0);
            this.TlpSaleSubmitMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpSaleSubmitMenu.Location = new System.Drawing.Point(3, 291);
            this.TlpSaleSubmitMenu.Name = "TlpSaleSubmitMenu";
            this.TlpSaleSubmitMenu.RowCount = 1;
            this.TlpSaleSubmitMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSaleSubmitMenu.Size = new System.Drawing.Size(501, 27);
            this.TlpSaleSubmitMenu.TabIndex = 7;
            // 
            // BtnSaleCancel
            // 
            this.BtnSaleCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSaleCancel.Location = new System.Drawing.Point(358, 3);
            this.BtnSaleCancel.Name = "BtnSaleCancel";
            this.BtnSaleCancel.Size = new System.Drawing.Size(65, 21);
            this.BtnSaleCancel.TabIndex = 5;
            this.BtnSaleCancel.Text = "清空修改";
            this.BtnSaleCancel.UseVisualStyleBackColor = true;
            this.BtnSaleCancel.Click += new System.EventHandler(this.BtnSaleCancel_Click);
            // 
            // BtnSaleSubmit
            // 
            this.BtnSaleSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSaleSubmit.Location = new System.Drawing.Point(287, 3);
            this.BtnSaleSubmit.Name = "BtnSaleSubmit";
            this.BtnSaleSubmit.Size = new System.Drawing.Size(65, 21);
            this.BtnSaleSubmit.TabIndex = 4;
            this.BtnSaleSubmit.Text = "提交修改";
            this.BtnSaleSubmit.UseVisualStyleBackColor = true;
            this.BtnSaleSubmit.Click += new System.EventHandler(this.BtnSaleSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "经办人";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbOperator
            // 
            this.CmbOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbOperator.FormattingEnabled = true;
            this.CmbOperator.Location = new System.Drawing.Point(74, 3);
            this.CmbOperator.Name = "CmbOperator";
            this.CmbOperator.Size = new System.Drawing.Size(65, 20);
            this.CmbOperator.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(145, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "销售单号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSaleID
            // 
            this.LblSaleID.AutoSize = true;
            this.LblSaleID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSaleID.Location = new System.Drawing.Point(216, 0);
            this.LblSaleID.Name = "LblSaleID";
            this.LblSaleID.Size = new System.Drawing.Size(65, 27);
            this.LblSaleID.TabIndex = 9;
            this.LblSaleID.Text = "label4";
            this.LblSaleID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnBack
            // 
            this.BtnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBack.Location = new System.Drawing.Point(429, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(69, 21);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.Text = "退出";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DgvSaleInsert
            // 
            this.DgvSaleInsert.AllowUserToAddRows = false;
            this.DgvSaleInsert.AllowUserToDeleteRows = false;
            this.DgvSaleInsert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSaleInsert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnStaffID,
            this.ClnGoodID,
            this.ClnCategoryName,
            this.ClnUnit,
            this.ClnProfit});
            this.DgvSaleInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSaleInsert.Location = new System.Drawing.Point(3, 35);
            this.DgvSaleInsert.Name = "DgvSaleInsert";
            this.DgvSaleInsert.RowTemplate.Height = 23;
            this.DgvSaleInsert.Size = new System.Drawing.Size(501, 250);
            this.DgvSaleInsert.TabIndex = 1;
            // 
            // ClnStaffID
            // 
            this.ClnStaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnStaffID.HeaderText = "销售编号";
            this.ClnStaffID.Name = "ClnStaffID";
            this.ClnStaffID.ReadOnly = true;
            this.ClnStaffID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClnGoodID
            // 
            this.ClnGoodID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnGoodID.HeaderText = "商品编号";
            this.ClnGoodID.Name = "ClnGoodID";
            this.ClnGoodID.ReadOnly = true;
            this.ClnGoodID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClnCategoryName
            // 
            this.ClnCategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnCategoryName.HeaderText = "商品名称";
            this.ClnCategoryName.Name = "ClnCategoryName";
            this.ClnCategoryName.ReadOnly = true;
            this.ClnCategoryName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClnUnit
            // 
            this.ClnUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnUnit.HeaderText = "计量单位";
            this.ClnUnit.Name = "ClnUnit";
            this.ClnUnit.ReadOnly = true;
            this.ClnUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClnProfit
            // 
            this.ClnProfit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnProfit.HeaderText = "利润";
            this.ClnProfit.Name = "ClnProfit";
            this.ClnProfit.ReadOnly = true;
            this.ClnProfit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TlpSaleControllerMenu
            // 
            this.TlpSaleControllerMenu.ColumnCount = 4;
            this.TlpSaleControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpSaleControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpSaleControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpSaleControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpSaleControllerMenu.Controls.Add(this.BtnSingleSaleInsert, 0, 0);
            this.TlpSaleControllerMenu.Controls.Add(this.BtnMultiSaleInsert, 1, 0);
            this.TlpSaleControllerMenu.Controls.Add(this.label1, 2, 0);
            this.TlpSaleControllerMenu.Controls.Add(this.DtpSaleDate, 3, 0);
            this.TlpSaleControllerMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpSaleControllerMenu.Location = new System.Drawing.Point(3, 3);
            this.TlpSaleControllerMenu.Name = "TlpSaleControllerMenu";
            this.TlpSaleControllerMenu.RowCount = 1;
            this.TlpSaleControllerMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSaleControllerMenu.Size = new System.Drawing.Size(501, 26);
            this.TlpSaleControllerMenu.TabIndex = 8;
            // 
            // BtnSingleSaleInsert
            // 
            this.BtnSingleSaleInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSingleSaleInsert.Location = new System.Drawing.Point(3, 3);
            this.BtnSingleSaleInsert.Name = "BtnSingleSaleInsert";
            this.BtnSingleSaleInsert.Size = new System.Drawing.Size(119, 20);
            this.BtnSingleSaleInsert.TabIndex = 1;
            this.BtnSingleSaleInsert.Text = "添加商品";
            this.BtnSingleSaleInsert.UseVisualStyleBackColor = true;
            this.BtnSingleSaleInsert.Click += new System.EventHandler(this.BtnSingleSaleInsert_Click);
            // 
            // BtnMultiSaleInsert
            // 
            this.BtnMultiSaleInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMultiSaleInsert.Location = new System.Drawing.Point(128, 3);
            this.BtnMultiSaleInsert.Name = "BtnMultiSaleInsert";
            this.BtnMultiSaleInsert.Size = new System.Drawing.Size(119, 20);
            this.BtnMultiSaleInsert.TabIndex = 2;
            this.BtnMultiSaleInsert.Text = "批量销售";
            this.BtnMultiSaleInsert.UseVisualStyleBackColor = true;
            this.BtnMultiSaleInsert.Click += new System.EventHandler(this.BtnMultiSaleInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(253, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "销售日期";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DtpSaleDate
            // 
            this.DtpSaleDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpSaleDate.Location = new System.Drawing.Point(378, 3);
            this.DtpSaleDate.Name = "DtpSaleDate";
            this.DtpSaleDate.Size = new System.Drawing.Size(120, 21);
            this.DtpSaleDate.TabIndex = 4;
            // 
            // FrmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 321);
            this.Controls.Add(this.TlpSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSale";
            this.Text = "FrmSale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSale_FormClosing);
            this.TlpSale.ResumeLayout(false);
            this.TlpSaleSubmitMenu.ResumeLayout(false);
            this.TlpSaleSubmitMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaleInsert)).EndInit();
            this.TlpSaleControllerMenu.ResumeLayout(false);
            this.TlpSaleControllerMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpSale;
        private System.Windows.Forms.TableLayoutPanel TlpSaleSubmitMenu;
        private System.Windows.Forms.Button BtnSaleCancel;
        private System.Windows.Forms.Button BtnSaleSubmit;
        private System.Windows.Forms.DataGridView DgvSaleInsert;
        private System.Windows.Forms.TableLayoutPanel TlpSaleControllerMenu;
        private System.Windows.Forms.Button BtnSingleSaleInsert;
        private System.Windows.Forms.Button BtnMultiSaleInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpSaleDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbOperator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSaleID;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnStaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnGoodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnProfit;
    }
}