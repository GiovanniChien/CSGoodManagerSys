namespace GoodManagerSys.Frm
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
            this.BtnSIncome = new System.Windows.Forms.Button();
            this.BtnMIncome = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoodIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSIncome
            // 
            this.BtnSIncome.Location = new System.Drawing.Point(24, 12);
            this.BtnSIncome.Name = "BtnSIncome";
            this.BtnSIncome.Size = new System.Drawing.Size(190, 50);
            this.BtnSIncome.TabIndex = 0;
            this.BtnSIncome.Text = "单个商品入库";
            this.BtnSIncome.UseVisualStyleBackColor = true;
            this.BtnSIncome.Click += new System.EventHandler(this.BtnSIncome_Click);
            // 
            // BtnMIncome
            // 
            this.BtnMIncome.Location = new System.Drawing.Point(249, 12);
            this.BtnMIncome.Name = "BtnMIncome";
            this.BtnMIncome.Size = new System.Drawing.Size(190, 50);
            this.BtnMIncome.TabIndex = 1;
            this.BtnMIncome.Text = "批量商品入库";
            this.BtnMIncome.UseVisualStyleBackColor = true;
            this.BtnMIncome.Click += new System.EventHandler(this.BtnMIncome_Click);
            // 
            // DgvGoodIncome
            // 
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
            this.DgvGoodIncome.Location = new System.Drawing.Point(24, 81);
            this.DgvGoodIncome.Name = "DgvGoodIncome";
            this.DgvGoodIncome.RowTemplate.Height = 37;
            this.DgvGoodIncome.Size = new System.Drawing.Size(967, 437);
            this.DgvGoodIncome.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 103;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "商品名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 151;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "类别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 103;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "单位";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 103;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "厂商";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 103;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "生产日期";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 151;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "数量";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 103;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "进价";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 103;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "售价";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 103;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "状态";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 103;
            // 
            // BtnComfirm
            // 
            this.BtnComfirm.Location = new System.Drawing.Point(711, 542);
            this.BtnComfirm.Name = "BtnComfirm";
            this.BtnComfirm.Size = new System.Drawing.Size(117, 50);
            this.BtnComfirm.TabIndex = 3;
            this.BtnComfirm.Text = "确定";
            this.BtnComfirm.UseVisualStyleBackColor = true;
            this.BtnComfirm.Click += new System.EventHandler(this.BtnComfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "进货日期";
            // 
            // DtpPurchaseDate
            // 
            this.DtpPurchaseDate.Location = new System.Drawing.Point(791, 26);
            this.DtpPurchaseDate.Name = "DtpPurchaseDate";
            this.DtpPurchaseDate.Size = new System.Drawing.Size(200, 35);
            this.DtpPurchaseDate.TabIndex = 5;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(848, 542);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(117, 50);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "经办人";
            // 
            // CmbOperator
            // 
            this.CmbOperator.FormattingEnabled = true;
            this.CmbOperator.Location = new System.Drawing.Point(124, 552);
            this.CmbOperator.Name = "CmbOperator";
            this.CmbOperator.Size = new System.Drawing.Size(202, 32);
            this.CmbOperator.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "初始单号";
            // 
            // TxtPurchaseID
            // 
            this.TxtPurchaseID.Location = new System.Drawing.Point(469, 552);
            this.TxtPurchaseID.Name = "TxtPurchaseID";
            this.TxtPurchaseID.Size = new System.Drawing.Size(195, 35);
            this.TxtPurchaseID.TabIndex = 10;
            // 
            // FrmGoodIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 631);
            this.Controls.Add(this.TxtPurchaseID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbOperator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.DtpPurchaseDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnComfirm);
            this.Controls.Add(this.DgvGoodIncome);
            this.Controls.Add(this.BtnMIncome);
            this.Controls.Add(this.BtnSIncome);
            this.Name = "FrmGoodIncome";
            this.Text = "FrmGoodIncome";
            ((System.ComponentModel.ISupportInitialize)(this.DgvGoodIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSIncome;
        private System.Windows.Forms.Button BtnMIncome;
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
    }
}