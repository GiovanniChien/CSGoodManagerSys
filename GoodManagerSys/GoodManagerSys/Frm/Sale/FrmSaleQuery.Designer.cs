namespace GoodManagerSys.Frm.Sale {
    partial class FrmSaleQuery {
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
            this.TlpSaleQuery = new System.Windows.Forms.TableLayoutPanel();
            this.DgvGoodInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvSaleResult = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RdoSale = new System.Windows.Forms.RadioButton();
            this.RdoGood = new System.Windows.Forms.RadioButton();
            this.TxtQuery = new System.Windows.Forms.TextBox();
            this.BtnQuery = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.TlpSaleQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoodInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaleResult)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpSaleQuery
            // 
            this.TlpSaleQuery.ColumnCount = 1;
            this.TlpSaleQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSaleQuery.Controls.Add(this.DgvGoodInfo, 0, 2);
            this.TlpSaleQuery.Controls.Add(this.DgvSaleResult, 0, 1);
            this.TlpSaleQuery.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.TlpSaleQuery.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.TlpSaleQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpSaleQuery.Location = new System.Drawing.Point(0, 0);
            this.TlpSaleQuery.Name = "TlpSaleQuery";
            this.TlpSaleQuery.RowCount = 4;
            this.TlpSaleQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.TlpSaleQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            this.TlpSaleQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            this.TlpSaleQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.TlpSaleQuery.Size = new System.Drawing.Size(572, 362);
            this.TlpSaleQuery.TabIndex = 5;
            // 
            // DgvGoodInfo
            // 
            this.DgvGoodInfo.AllowUserToAddRows = false;
            this.DgvGoodInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGoodInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column4});
            this.DgvGoodInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvGoodInfo.Location = new System.Drawing.Point(3, 183);
            this.DgvGoodInfo.Name = "DgvGoodInfo";
            this.DgvGoodInfo.RowTemplate.Height = 23;
            this.DgvGoodInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGoodInfo.Size = new System.Drawing.Size(566, 142);
            this.DgvGoodInfo.TabIndex = 1;
            this.DgvGoodInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGoodInfo_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "商品编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "商品名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "计量单位";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "售价";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DgvSaleResult
            // 
            this.DgvSaleResult.AllowUserToAddRows = false;
            this.DgvSaleResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSaleResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvSaleResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSaleResult.Location = new System.Drawing.Point(3, 35);
            this.DgvSaleResult.Name = "DgvSaleResult";
            this.DgvSaleResult.RowTemplate.Height = 23;
            this.DgvSaleResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSaleResult.Size = new System.Drawing.Size(566, 142);
            this.DgvSaleResult.TabIndex = 0;
            this.DgvSaleResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSaleResult_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "销售单号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "销售日期";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "经办人";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.RdoSale, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RdoGood, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtQuery, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnQuery, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 26);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // RdoSale
            // 
            this.RdoSale.AutoSize = true;
            this.RdoSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RdoSale.Location = new System.Drawing.Point(3, 3);
            this.RdoSale.Name = "RdoSale";
            this.RdoSale.Size = new System.Drawing.Size(135, 20);
            this.RdoSale.TabIndex = 0;
            this.RdoSale.TabStop = true;
            this.RdoSale.Text = "查询销售单";
            this.RdoSale.UseVisualStyleBackColor = true;
            // 
            // RdoGood
            // 
            this.RdoGood.AutoSize = true;
            this.RdoGood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RdoGood.Location = new System.Drawing.Point(144, 3);
            this.RdoGood.Name = "RdoGood";
            this.RdoGood.Size = new System.Drawing.Size(135, 20);
            this.RdoGood.TabIndex = 1;
            this.RdoGood.TabStop = true;
            this.RdoGood.Text = "查询商品";
            this.RdoGood.UseVisualStyleBackColor = true;
            // 
            // TxtQuery
            // 
            this.TxtQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtQuery.Location = new System.Drawing.Point(285, 3);
            this.TxtQuery.Name = "TxtQuery";
            this.TxtQuery.Size = new System.Drawing.Size(135, 21);
            this.TxtQuery.TabIndex = 2;
            // 
            // BtnQuery
            // 
            this.BtnQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnQuery.Location = new System.Drawing.Point(426, 3);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(137, 20);
            this.BtnQuery.TabIndex = 3;
            this.BtnQuery.Text = "查询";
            this.BtnQuery.UseVisualStyleBackColor = true;
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.BtnBack, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 331);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(566, 28);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // BtnBack
            // 
            this.BtnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBack.Location = new System.Drawing.Point(455, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(108, 22);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "退出";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmSaleQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 362);
            this.Controls.Add(this.TlpSaleQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSaleQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSaleQuery";
            this.TlpSaleQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoodInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaleResult)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpSaleQuery;
        private System.Windows.Forms.DataGridView DgvGoodInfo;
        private System.Windows.Forms.DataGridView DgvSaleResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton RdoSale;
        private System.Windows.Forms.RadioButton RdoGood;
        private System.Windows.Forms.TextBox TxtQuery;
        private System.Windows.Forms.Button BtnQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnBack;
    }
}