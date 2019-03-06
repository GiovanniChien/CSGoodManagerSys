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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvWarehouse = new System.Windows.Forms.DataGridView();
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxtIdOrName = new System.Windows.Forms.TextBox();
            this.BtnQuery = new System.Windows.Forms.Button();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TlpWarehouse = new System.Windows.Forms.TableLayoutPanel();
            this.TlpWExit = new System.Windows.Forms.TableLayoutPanel();
            this.TlpWControllerMenu = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvWarehouse)).BeginInit();
            this.TlpWarehouse.SuspendLayout();
            this.TlpWExit.SuspendLayout();
            this.TlpWControllerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvWarehouse
            // 
            this.DgvWarehouse.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvWarehouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.DgvWarehouse.Location = new System.Drawing.Point(2, 38);
            this.DgvWarehouse.Margin = new System.Windows.Forms.Padding(2);
            this.DgvWarehouse.Name = "DgvWarehouse";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvWarehouse.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvWarehouse.RowTemplate.Height = 20;
            this.DgvWarehouse.Size = new System.Drawing.Size(733, 284);
            this.DgvWarehouse.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 54;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            this.Column2.Width = 54;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "大类";
            this.Column3.Name = "Column3";
            this.Column3.Width = 54;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "厂商";
            this.Column6.Name = "Column6";
            this.Column6.Width = 54;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "单位";
            this.Column4.Name = "Column4";
            this.Column4.Width = 54;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "颜色";
            this.Column5.Name = "Column5";
            this.Column5.Width = 54;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "保质期";
            this.Column8.Name = "Column8";
            this.Column8.Width = 66;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "当前库存";
            this.Column10.Name = "Column10";
            this.Column10.Width = 78;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "最小库存";
            this.Column7.Name = "Column7";
            this.Column7.Width = 78;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "最大库存";
            this.Column9.Name = "Column9";
            this.Column9.Width = 78;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column11.HeaderText = "有效状态";
            this.Column11.Name = "Column11";
            this.Column11.Width = 78;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExit.Location = new System.Drawing.Point(659, 2);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(70, 26);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "退出";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TxtIdOrName
            // 
            this.TxtIdOrName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIdOrName.Location = new System.Drawing.Point(456, 4);
            this.TxtIdOrName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdOrName.Name = "TxtIdOrName";
            this.TxtIdOrName.Size = new System.Drawing.Size(133, 21);
            this.TxtIdOrName.TabIndex = 3;
            // 
            // BtnQuery
            // 
            this.BtnQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnQuery.Location = new System.Drawing.Point(593, 2);
            this.BtnQuery.Margin = new System.Windows.Forms.Padding(2);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(136, 26);
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
            this.CmbCategory.Location = new System.Drawing.Point(139, 5);
            this.CmbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(133, 20);
            this.CmbCategory.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "商品大类";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(276, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 30);
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
            this.TlpWarehouse.Name = "TlpWarehouse";
            this.TlpWarehouse.RowCount = 3;
            this.TlpWarehouse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpWarehouse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TlpWarehouse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpWarehouse.Size = new System.Drawing.Size(737, 360);
            this.TlpWarehouse.TabIndex = 8;
            // 
            // TlpWExit
            // 
            this.TlpWExit.ColumnCount = 2;
            this.TlpWExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.TlpWExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpWExit.Controls.Add(this.BtnExit, 1, 0);
            this.TlpWExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpWExit.Location = new System.Drawing.Point(3, 327);
            this.TlpWExit.Name = "TlpWExit";
            this.TlpWExit.RowCount = 1;
            this.TlpWExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpWExit.Size = new System.Drawing.Size(731, 30);
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
            this.TlpWControllerMenu.Location = new System.Drawing.Point(3, 3);
            this.TlpWControllerMenu.Name = "TlpWControllerMenu";
            this.TlpWControllerMenu.RowCount = 1;
            this.TlpWControllerMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpWControllerMenu.Size = new System.Drawing.Size(731, 30);
            this.TlpWControllerMenu.TabIndex = 2;
            // 
            // FrmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 360);
            this.Controls.Add(this.TlpWarehouse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TableLayoutPanel TlpWarehouse;
        private System.Windows.Forms.TableLayoutPanel TlpWExit;
        private System.Windows.Forms.TableLayoutPanel TlpWControllerMenu;
    }
}