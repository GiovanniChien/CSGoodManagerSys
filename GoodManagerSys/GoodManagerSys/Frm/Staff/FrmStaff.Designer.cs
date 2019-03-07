namespace GoodManagerSys.Frm.Staff {
    partial class FrmStaff {
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
            this.TlpStaffMenu = new System.Windows.Forms.TableLayoutPanel();
            this.TlpStaffSubmitMenu = new System.Windows.Forms.TableLayoutPanel();
            this.BtnStaffCancel = new System.Windows.Forms.Button();
            this.BtnStaffSubmit = new System.Windows.Forms.Button();
            this.BtnStaffDelete = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.TlpStaffControllerMenu = new System.Windows.Forms.TableLayoutPanel();
            this.BtnStaffSearch = new System.Windows.Forms.Button();
            this.TxtStaffSearch = new System.Windows.Forms.TextBox();
            this.BtnStaffInsert = new System.Windows.Forms.Button();
            this.BtnStaffUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbStaffRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvStaffData = new System.Windows.Forms.DataGridView();
            this.ClnStaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnStaffPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnStaffRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TlpStaffMenu.SuspendLayout();
            this.TlpStaffSubmitMenu.SuspendLayout();
            this.TlpStaffControllerMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStaffData)).BeginInit();
            this.SuspendLayout();
            // 
            // TlpStaffMenu
            // 
            this.TlpStaffMenu.ColumnCount = 1;
            this.TlpStaffMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpStaffMenu.Controls.Add(this.TlpStaffSubmitMenu, 0, 2);
            this.TlpStaffMenu.Controls.Add(this.TlpStaffControllerMenu, 0, 0);
            this.TlpStaffMenu.Controls.Add(this.DgvStaffData, 0, 1);
            this.TlpStaffMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpStaffMenu.Location = new System.Drawing.Point(0, 0);
            this.TlpStaffMenu.Margin = new System.Windows.Forms.Padding(4);
            this.TlpStaffMenu.Name = "TlpStaffMenu";
            this.TlpStaffMenu.RowCount = 3;
            this.TlpStaffMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpStaffMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TlpStaffMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpStaffMenu.Size = new System.Drawing.Size(949, 401);
            this.TlpStaffMenu.TabIndex = 1;
            // 
            // TlpStaffSubmitMenu
            // 
            this.TlpStaffSubmitMenu.ColumnCount = 5;
            this.TlpStaffSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpStaffSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpStaffSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpStaffSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpStaffSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpStaffSubmitMenu.Controls.Add(this.BtnStaffCancel, 3, 0);
            this.TlpStaffSubmitMenu.Controls.Add(this.BtnStaffSubmit, 2, 0);
            this.TlpStaffSubmitMenu.Controls.Add(this.BtnStaffDelete, 0, 0);
            this.TlpStaffSubmitMenu.Controls.Add(this.BtnBack, 4, 0);
            this.TlpStaffSubmitMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpStaffSubmitMenu.Location = new System.Drawing.Point(4, 364);
            this.TlpStaffSubmitMenu.Margin = new System.Windows.Forms.Padding(4);
            this.TlpStaffSubmitMenu.Name = "TlpStaffSubmitMenu";
            this.TlpStaffSubmitMenu.RowCount = 1;
            this.TlpStaffSubmitMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpStaffSubmitMenu.Size = new System.Drawing.Size(941, 33);
            this.TlpStaffSubmitMenu.TabIndex = 6;
            // 
            // BtnStaffCancel
            // 
            this.BtnStaffCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnStaffCancel.Location = new System.Drawing.Point(629, 4);
            this.BtnStaffCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStaffCancel.Name = "BtnStaffCancel";
            this.BtnStaffCancel.Size = new System.Drawing.Size(148, 25);
            this.BtnStaffCancel.TabIndex = 20;
            this.BtnStaffCancel.Text = "清空修改";
            this.BtnStaffCancel.UseVisualStyleBackColor = true;
            this.BtnStaffCancel.Click += new System.EventHandler(this.BtnStaffCancel_Click);
            // 
            // BtnStaffSubmit
            // 
            this.BtnStaffSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnStaffSubmit.Location = new System.Drawing.Point(473, 4);
            this.BtnStaffSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStaffSubmit.Name = "BtnStaffSubmit";
            this.BtnStaffSubmit.Size = new System.Drawing.Size(148, 25);
            this.BtnStaffSubmit.TabIndex = 18;
            this.BtnStaffSubmit.Text = "提交修改";
            this.BtnStaffSubmit.UseVisualStyleBackColor = true;
            this.BtnStaffSubmit.Click += new System.EventHandler(this.BtnStaffSubmit_Click);
            // 
            // BtnStaffDelete
            // 
            this.BtnStaffDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnStaffDelete.Location = new System.Drawing.Point(4, 4);
            this.BtnStaffDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStaffDelete.Name = "BtnStaffDelete";
            this.BtnStaffDelete.Size = new System.Drawing.Size(148, 25);
            this.BtnStaffDelete.TabIndex = 11;
            this.BtnStaffDelete.Text = "删除员工";
            this.BtnStaffDelete.UseVisualStyleBackColor = true;
            this.BtnStaffDelete.Click += new System.EventHandler(this.BtnStaffDelete_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBack.Location = new System.Drawing.Point(785, 4);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(152, 25);
            this.BtnBack.TabIndex = 21;
            this.BtnBack.Text = "退出";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // TlpStaffControllerMenu
            // 
            this.TlpStaffControllerMenu.ColumnCount = 7;
            this.TlpStaffControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TlpStaffControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TlpStaffControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TlpStaffControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TlpStaffControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TlpStaffControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TlpStaffControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TlpStaffControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpStaffControllerMenu.Controls.Add(this.BtnStaffSearch, 6, 0);
            this.TlpStaffControllerMenu.Controls.Add(this.TxtStaffSearch, 5, 0);
            this.TlpStaffControllerMenu.Controls.Add(this.BtnStaffInsert, 0, 0);
            this.TlpStaffControllerMenu.Controls.Add(this.BtnStaffUpdate, 1, 0);
            this.TlpStaffControllerMenu.Controls.Add(this.label1, 2, 0);
            this.TlpStaffControllerMenu.Controls.Add(this.CmbStaffRole, 3, 0);
            this.TlpStaffControllerMenu.Controls.Add(this.label2, 4, 0);
            this.TlpStaffControllerMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpStaffControllerMenu.Location = new System.Drawing.Point(4, 4);
            this.TlpStaffControllerMenu.Margin = new System.Windows.Forms.Padding(4);
            this.TlpStaffControllerMenu.Name = "TlpStaffControllerMenu";
            this.TlpStaffControllerMenu.RowCount = 1;
            this.TlpStaffControllerMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpStaffControllerMenu.Size = new System.Drawing.Size(941, 32);
            this.TlpStaffControllerMenu.TabIndex = 0;
            // 
            // BtnStaffSearch
            // 
            this.BtnStaffSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnStaffSearch.Location = new System.Drawing.Point(808, 4);
            this.BtnStaffSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStaffSearch.Name = "BtnStaffSearch";
            this.BtnStaffSearch.Size = new System.Drawing.Size(129, 24);
            this.BtnStaffSearch.TabIndex = 8;
            this.BtnStaffSearch.Text = "查询";
            this.BtnStaffSearch.UseVisualStyleBackColor = true;
            this.BtnStaffSearch.Click += new System.EventHandler(this.BtnStaffSearch_Click);
            // 
            // TxtStaffSearch
            // 
            this.TxtStaffSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtStaffSearch.Location = new System.Drawing.Point(674, 4);
            this.TxtStaffSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStaffSearch.Name = "TxtStaffSearch";
            this.TxtStaffSearch.Size = new System.Drawing.Size(126, 25);
            this.TxtStaffSearch.TabIndex = 6;
            // 
            // BtnStaffInsert
            // 
            this.BtnStaffInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnStaffInsert.Location = new System.Drawing.Point(4, 4);
            this.BtnStaffInsert.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStaffInsert.Name = "BtnStaffInsert";
            this.BtnStaffInsert.Size = new System.Drawing.Size(126, 24);
            this.BtnStaffInsert.TabIndex = 0;
            this.BtnStaffInsert.Text = "添加员工";
            this.BtnStaffInsert.UseVisualStyleBackColor = true;
            this.BtnStaffInsert.Click += new System.EventHandler(this.BtnStaffInsert_Click);
            // 
            // BtnStaffUpdate
            // 
            this.BtnStaffUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnStaffUpdate.Location = new System.Drawing.Point(138, 4);
            this.BtnStaffUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStaffUpdate.Name = "BtnStaffUpdate";
            this.BtnStaffUpdate.Size = new System.Drawing.Size(126, 24);
            this.BtnStaffUpdate.TabIndex = 1;
            this.BtnStaffUpdate.Text = "信息修改";
            this.BtnStaffUpdate.UseVisualStyleBackColor = true;
            this.BtnStaffUpdate.Click += new System.EventHandler(this.BtnStaffUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(272, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "选择员工职称";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbStaffRole
            // 
            this.CmbStaffRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbStaffRole.FormattingEnabled = true;
            this.CmbStaffRole.Items.AddRange(new object[] {
            "不限",
            "未定义",
            "管理员",
            "销售员",
            "采购员"});
            this.CmbStaffRole.Location = new System.Drawing.Point(406, 4);
            this.CmbStaffRole.Margin = new System.Windows.Forms.Padding(4);
            this.CmbStaffRole.Name = "CmbStaffRole";
            this.CmbStaffRole.Size = new System.Drawing.Size(126, 23);
            this.CmbStaffRole.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(540, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "输入查询的员工编号或姓名：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvStaffData
            // 
            this.DgvStaffData.AllowUserToAddRows = false;
            this.DgvStaffData.AllowUserToDeleteRows = false;
            this.DgvStaffData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStaffData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnStaffID,
            this.ClnStaffName,
            this.ClnStaffPhone,
            this.ClnStaffRole});
            this.DgvStaffData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvStaffData.Location = new System.Drawing.Point(4, 44);
            this.DgvStaffData.Margin = new System.Windows.Forms.Padding(4);
            this.DgvStaffData.MultiSelect = false;
            this.DgvStaffData.Name = "DgvStaffData";
            this.DgvStaffData.ReadOnly = true;
            this.DgvStaffData.RowTemplate.Height = 23;
            this.DgvStaffData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvStaffData.Size = new System.Drawing.Size(941, 312);
            this.DgvStaffData.TabIndex = 1;
            // 
            // ClnStaffID
            // 
            this.ClnStaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnStaffID.HeaderText = "员工编号";
            this.ClnStaffID.MaxInputLength = 0;
            this.ClnStaffID.Name = "ClnStaffID";
            this.ClnStaffID.ReadOnly = true;
            this.ClnStaffID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClnStaffName
            // 
            this.ClnStaffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnStaffName.HeaderText = "员工姓名";
            this.ClnStaffName.Name = "ClnStaffName";
            this.ClnStaffName.ReadOnly = true;
            this.ClnStaffName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClnStaffPhone
            // 
            this.ClnStaffPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnStaffPhone.HeaderText = "联系方式";
            this.ClnStaffPhone.Name = "ClnStaffPhone";
            this.ClnStaffPhone.ReadOnly = true;
            this.ClnStaffPhone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClnStaffRole
            // 
            this.ClnStaffRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnStaffRole.HeaderText = "员工职称";
            this.ClnStaffRole.Name = "ClnStaffRole";
            this.ClnStaffRole.ReadOnly = true;
            this.ClnStaffRole.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 401);
            this.Controls.Add(this.TlpStaffMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmStaff";
            this.TlpStaffMenu.ResumeLayout(false);
            this.TlpStaffSubmitMenu.ResumeLayout(false);
            this.TlpStaffControllerMenu.ResumeLayout(false);
            this.TlpStaffControllerMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStaffData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpStaffMenu;
        private System.Windows.Forms.TableLayoutPanel TlpStaffSubmitMenu;
        private System.Windows.Forms.TableLayoutPanel TlpStaffControllerMenu;
        private System.Windows.Forms.Button BtnStaffInsert;
        private System.Windows.Forms.Button BtnStaffUpdate;
        private System.Windows.Forms.DataGridView DgvStaffData;
        private System.Windows.Forms.Button BtnStaffSearch;
        private System.Windows.Forms.TextBox TxtStaffSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbStaffRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnStaffDelete;
        private System.Windows.Forms.Button BtnStaffCancel;
        private System.Windows.Forms.Button BtnStaffSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnStaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnStaffPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnStaffRole;
        private System.Windows.Forms.Button BtnBack;
    }
}