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
            this.TlpStaffMenu.Name = "TlpStaffMenu";
            this.TlpStaffMenu.RowCount = 3;
            this.TlpStaffMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpStaffMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TlpStaffMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlpStaffMenu.Size = new System.Drawing.Size(712, 321);
            this.TlpStaffMenu.TabIndex = 1;
            // 
            // TlpStaffSubmitMenu
            // 
            this.TlpStaffSubmitMenu.ColumnCount = 4;
            this.TlpStaffSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpStaffSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TlpStaffSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpStaffSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpStaffSubmitMenu.Controls.Add(this.BtnStaffCancel, 3, 0);
            this.TlpStaffSubmitMenu.Controls.Add(this.BtnStaffSubmit, 2, 0);
            this.TlpStaffSubmitMenu.Controls.Add(this.BtnStaffDelete, 0, 0);
            this.TlpStaffSubmitMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpStaffSubmitMenu.Location = new System.Drawing.Point(3, 291);
            this.TlpStaffSubmitMenu.Name = "TlpStaffSubmitMenu";
            this.TlpStaffSubmitMenu.RowCount = 1;
            this.TlpStaffSubmitMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpStaffSubmitMenu.Size = new System.Drawing.Size(706, 27);
            this.TlpStaffSubmitMenu.TabIndex = 6;
            // 
            // BtnStaffCancel
            // 
            this.BtnStaffCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnStaffCancel.Location = new System.Drawing.Point(567, 3);
            this.BtnStaffCancel.Name = "BtnStaffCancel";
            this.BtnStaffCancel.Size = new System.Drawing.Size(136, 21);
            this.BtnStaffCancel.TabIndex = 20;
            this.BtnStaffCancel.Text = "清空修改";
            this.BtnStaffCancel.UseVisualStyleBackColor = true;
            // 
            // BtnStaffSubmit
            // 
            this.BtnStaffSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnStaffSubmit.Location = new System.Drawing.Point(426, 3);
            this.BtnStaffSubmit.Name = "BtnStaffSubmit";
            this.BtnStaffSubmit.Size = new System.Drawing.Size(135, 21);
            this.BtnStaffSubmit.TabIndex = 18;
            this.BtnStaffSubmit.Text = "提交修改";
            this.BtnStaffSubmit.UseVisualStyleBackColor = true;
            this.BtnStaffSubmit.Click += new System.EventHandler(this.BtnStaffSubmit_Click);
            // 
            // BtnStaffDelete
            // 
            this.BtnStaffDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnStaffDelete.Location = new System.Drawing.Point(3, 3);
            this.BtnStaffDelete.Name = "BtnStaffDelete";
            this.BtnStaffDelete.Size = new System.Drawing.Size(135, 21);
            this.BtnStaffDelete.TabIndex = 11;
            this.BtnStaffDelete.Text = "删除员工";
            this.BtnStaffDelete.UseVisualStyleBackColor = true;
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
            this.TlpStaffControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpStaffControllerMenu.Controls.Add(this.BtnStaffSearch, 6, 0);
            this.TlpStaffControllerMenu.Controls.Add(this.TxtStaffSearch, 5, 0);
            this.TlpStaffControllerMenu.Controls.Add(this.BtnStaffInsert, 0, 0);
            this.TlpStaffControllerMenu.Controls.Add(this.BtnStaffUpdate, 1, 0);
            this.TlpStaffControllerMenu.Controls.Add(this.label1, 2, 0);
            this.TlpStaffControllerMenu.Controls.Add(this.CmbStaffRole, 3, 0);
            this.TlpStaffControllerMenu.Controls.Add(this.label2, 4, 0);
            this.TlpStaffControllerMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpStaffControllerMenu.Location = new System.Drawing.Point(3, 3);
            this.TlpStaffControllerMenu.Name = "TlpStaffControllerMenu";
            this.TlpStaffControllerMenu.RowCount = 1;
            this.TlpStaffControllerMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpStaffControllerMenu.Size = new System.Drawing.Size(706, 26);
            this.TlpStaffControllerMenu.TabIndex = 0;
            // 
            // BtnStaffSearch
            // 
            this.BtnStaffSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnStaffSearch.Location = new System.Drawing.Point(603, 3);
            this.BtnStaffSearch.Name = "BtnStaffSearch";
            this.BtnStaffSearch.Size = new System.Drawing.Size(100, 20);
            this.BtnStaffSearch.TabIndex = 8;
            this.BtnStaffSearch.Text = "查询";
            this.BtnStaffSearch.UseVisualStyleBackColor = true;
            // 
            // TxtStaffSearch
            // 
            this.TxtStaffSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtStaffSearch.Location = new System.Drawing.Point(503, 3);
            this.TxtStaffSearch.Name = "TxtStaffSearch";
            this.TxtStaffSearch.Size = new System.Drawing.Size(94, 21);
            this.TxtStaffSearch.TabIndex = 6;
            // 
            // BtnStaffInsert
            // 
            this.BtnStaffInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnStaffInsert.Location = new System.Drawing.Point(3, 3);
            this.BtnStaffInsert.Name = "BtnStaffInsert";
            this.BtnStaffInsert.Size = new System.Drawing.Size(94, 20);
            this.BtnStaffInsert.TabIndex = 0;
            this.BtnStaffInsert.Text = "添加员工";
            this.BtnStaffInsert.UseVisualStyleBackColor = true;
            this.BtnStaffInsert.Click += new System.EventHandler(this.BtnStaffInsert_Click);
            // 
            // BtnStaffUpdate
            // 
            this.BtnStaffUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnStaffUpdate.Location = new System.Drawing.Point(103, 3);
            this.BtnStaffUpdate.Name = "BtnStaffUpdate";
            this.BtnStaffUpdate.Size = new System.Drawing.Size(94, 20);
            this.BtnStaffUpdate.TabIndex = 1;
            this.BtnStaffUpdate.Text = "信息修改";
            this.BtnStaffUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(203, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "选择员工职称";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbStaffRole
            // 
            this.CmbStaffRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbStaffRole.FormattingEnabled = true;
            this.CmbStaffRole.Items.AddRange(new object[] {
            "--请选择--",
            "管理员",
            "销售员",
            "采购员"});
            this.CmbStaffRole.Location = new System.Drawing.Point(303, 3);
            this.CmbStaffRole.Name = "CmbStaffRole";
            this.CmbStaffRole.Size = new System.Drawing.Size(94, 20);
            this.CmbStaffRole.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(403, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "输入查询的员工编号或名称：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvStaffData
            // 
            this.DgvStaffData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStaffData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnStaffID,
            this.ClnStaffName,
            this.ClnStaffPhone,
            this.ClnStaffRole});
            this.DgvStaffData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvStaffData.Location = new System.Drawing.Point(3, 35);
            this.DgvStaffData.Name = "DgvStaffData";
            this.DgvStaffData.RowTemplate.Height = 23;
            this.DgvStaffData.Size = new System.Drawing.Size(706, 250);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 321);
            this.Controls.Add(this.TlpStaffMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}