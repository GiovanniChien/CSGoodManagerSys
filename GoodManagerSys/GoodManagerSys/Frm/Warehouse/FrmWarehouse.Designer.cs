namespace GoodManagerSys.Frm.Warehouse {
    partial class FrmWarehouse {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvWarehouse = new System.Windows.Forms.DataGridView();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxtIdOrName = new System.Windows.Forms.TextBox();
            this.BtnQuery = new System.Windows.Forms.Button();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TlpWarehouse = new System.Windows.Forms.TableLayoutPanel();
            this.TlpWExit = new System.Windows.Forms.TableLayoutPanel();
            this.TlpWControllerMenu = new System.Windows.Forms.TableLayoutPanel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvWarehouse)).BeginInit();
            this.TlpWarehouse.SuspendLayout();
            this.TlpWExit.SuspendLayout();
            this.TlpWControllerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvWarehouse
            // 
            this.DgvWarehouse.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvWarehouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvWarehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column10,
            this.Column7,
            this.Column9,
            this.Column11});
            this.DgvWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvWarehouse.Location = new System.Drawing.Point(3, 47);
            this.DgvWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvWarehouse.Name = "DgvWarehouse";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvWarehouse.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvWarehouse.RowTemplate.Height = 20;
            this.DgvWarehouse.Size = new System.Drawing.Size(977, 356);
            this.DgvWarehouse.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExit.Location = new System.Drawing.Point(880, 2);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(92, 33);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "退出";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TxtIdOrName
            // 
            this.TxtIdOrName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIdOrName.Location = new System.Drawing.Point(609, 6);
            this.TxtIdOrName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtIdOrName.Name = "TxtIdOrName";
            this.TxtIdOrName.Size = new System.Drawing.Size(177, 25);
            this.TxtIdOrName.TabIndex = 3;
            // 
            // BtnQuery
            // 
            this.BtnQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnQuery.Location = new System.Drawing.Point(792, 2);
            this.BtnQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(180, 33);
            this.BtnQuery.TabIndex = 4;
            this.BtnQuery.Text = "查询";
            this.BtnQuery.UseVisualStyleBackColor = true;
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // CmbCategory
            // 
            this.CmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Items.AddRange(new object[] {
            "不限",
            "饮料",
            "酒",
            "香烟",
            "糕饼",
            "糖果",
            "奶制品",
            "休闲食品"});
            this.CmbCategory.Location = new System.Drawing.Point(186, 7);
            this.CmbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(177, 23);
            this.CmbCategory.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "商品大类";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(369, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "商品类别编号或名称";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TlpWarehouse
            // 
            this.TlpWarehouse.ColumnCount = 1;
            this.TlpWarehouse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpWarehouse.Controls.Add(this.DgvWarehouse, 0, 1);
            this.TlpWarehouse.Controls.Add(this.TlpWExit, 0, 2);
            this.TlpWarehouse.Controls.Add(this.TlpWControllerMenu, 0, 0);
            this.TlpWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpWarehouse.Location = new System.Drawing.Point(0, 0);
            this.TlpWarehouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TlpWarehouse.Name = "TlpWarehouse";
            this.TlpWarehouse.RowCount = 3;
            this.TlpWarehouse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpWarehouse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TlpWarehouse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpWarehouse.Size = new System.Drawing.Size(983, 450);
            this.TlpWarehouse.TabIndex = 8;
            // 
            // TlpWExit
            // 
            this.TlpWExit.ColumnCount = 2;
            this.TlpWExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.TlpWExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpWExit.Controls.Add(this.BtnExit, 1, 0);
            this.TlpWExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpWExit.Location = new System.Drawing.Point(4, 409);
            this.TlpWExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TlpWExit.Name = "TlpWExit";
            this.TlpWExit.RowCount = 1;
            this.TlpWExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpWExit.Size = new System.Drawing.Size(975, 37);
            this.TlpWExit.TabIndex = 1;
            // 
            // TlpWControllerMenu
            // 
            this.TlpWControllerMenu.ColumnCount = 5;
            this.TlpWControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.82353F));
            this.TlpWControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.82353F));
            this.TlpWControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.70588F));
            this.TlpWControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.82353F));
            this.TlpWControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.82353F));
            this.TlpWControllerMenu.Controls.Add(this.label1, 0, 0);
            this.TlpWControllerMenu.Controls.Add(this.BtnQuery, 4, 0);
            this.TlpWControllerMenu.Controls.Add(this.label2, 2, 0);
            this.TlpWControllerMenu.Controls.Add(this.TxtIdOrName, 3, 0);
            this.TlpWControllerMenu.Controls.Add(this.CmbCategory, 1, 0);
            this.TlpWControllerMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpWControllerMenu.Location = new System.Drawing.Point(4, 4);
            this.TlpWControllerMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TlpWControllerMenu.Name = "TlpWControllerMenu";
            this.TlpWControllerMenu.RowCount = 1;
            this.TlpWControllerMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpWControllerMenu.Size = new System.Drawing.Size(975, 37);
            this.TlpWControllerMenu.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "大类";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "厂商";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "单位";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "颜色";
            this.Column5.Name = "Column5";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "保质期";
            this.Column8.Name = "Column8";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "当前库存";
            this.Column10.Name = "Column10";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "最小库存";
            this.Column7.Name = "Column7";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "最大库存";
            this.Column9.Name = "Column9";
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "有效状态";
            this.Column11.Name = "Column11";
            // 
            // FrmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.TlpWarehouse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWarehouse";
            this.Text = "FrmWarehouse";
            ((System.ComponentModel.ISupportInitialize)(this.DgvWarehouse)).EndInit();
            this.TlpWarehouse.ResumeLayout(false);
            this.TlpWExit.ResumeLayout(false);
            this.TlpWControllerMenu.ResumeLayout(false);
            this.TlpWControllerMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvWarehouse;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TxtIdOrName;
        private System.Windows.Forms.Button BtnQuery;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel TlpWarehouse;
        private System.Windows.Forms.TableLayoutPanel TlpWExit;
        private System.Windows.Forms.TableLayoutPanel TlpWControllerMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}