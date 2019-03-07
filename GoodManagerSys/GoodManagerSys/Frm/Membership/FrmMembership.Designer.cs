namespace GoodManagerSys.Frm.Membership {
    partial class FrmMembership {
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
            this.DgvMembership = new System.Windows.Forms.DataGridView();
            this.ClnMsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnMsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnMsPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnMsPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnMsIsValid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TlpMsControllerMenu = new System.Windows.Forms.TableLayoutPanel();
            this.BtnMsUpdate = new System.Windows.Forms.Button();
            this.BtnMsInsert = new System.Windows.Forms.Button();
            this.TlpMembership = new System.Windows.Forms.TableLayoutPanel();
            this.TlpMsSubmitMenu = new System.Windows.Forms.TableLayoutPanel();
            this.BtnMsDelete = new System.Windows.Forms.Button();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMembership)).BeginInit();
            this.TlpMsControllerMenu.SuspendLayout();
            this.TlpMembership.SuspendLayout();
            this.TlpMsSubmitMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvMembership
            // 
            this.DgvMembership.AllowUserToAddRows = false;
            this.DgvMembership.AllowUserToDeleteRows = false;
            this.DgvMembership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMembership.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnMsID,
            this.ClnMsName,
            this.ClnMsPhone,
            this.ClnMsPoint,
            this.ClnMsIsValid});
            this.DgvMembership.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMembership.Location = new System.Drawing.Point(3, 45);
            this.DgvMembership.MultiSelect = false;
            this.DgvMembership.Name = "DgvMembership";
            this.DgvMembership.RowTemplate.Height = 23;
            this.DgvMembership.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMembership.Size = new System.Drawing.Size(510, 234);
            this.DgvMembership.TabIndex = 1;
            // 
            // ClnMsID
            // 
            this.ClnMsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnMsID.HeaderText = "会员编号";
            this.ClnMsID.Name = "ClnMsID";
            this.ClnMsID.ReadOnly = true;
            this.ClnMsID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClnMsName
            // 
            this.ClnMsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnMsName.HeaderText = "会员姓名";
            this.ClnMsName.Name = "ClnMsName";
            this.ClnMsName.ReadOnly = true;
            this.ClnMsName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClnMsPhone
            // 
            this.ClnMsPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnMsPhone.HeaderText = "联系方式";
            this.ClnMsPhone.Name = "ClnMsPhone";
            this.ClnMsPhone.ReadOnly = true;
            this.ClnMsPhone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClnMsPoint
            // 
            this.ClnMsPoint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnMsPoint.HeaderText = "会员积分";
            this.ClnMsPoint.Name = "ClnMsPoint";
            this.ClnMsPoint.ReadOnly = true;
            this.ClnMsPoint.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClnMsIsValid
            // 
            this.ClnMsIsValid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnMsIsValid.HeaderText = "会员状态";
            this.ClnMsIsValid.Name = "ClnMsIsValid";
            this.ClnMsIsValid.ReadOnly = true;
            this.ClnMsIsValid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TlpMsControllerMenu
            // 
            this.TlpMsControllerMenu.ColumnCount = 2;
            this.TlpMsControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpMsControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpMsControllerMenu.Controls.Add(this.BtnMsUpdate, 1, 0);
            this.TlpMsControllerMenu.Controls.Add(this.BtnMsInsert, 0, 0);
            this.TlpMsControllerMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMsControllerMenu.Location = new System.Drawing.Point(3, 3);
            this.TlpMsControllerMenu.Name = "TlpMsControllerMenu";
            this.TlpMsControllerMenu.RowCount = 1;
            this.TlpMsControllerMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpMsControllerMenu.Size = new System.Drawing.Size(510, 36);
            this.TlpMsControllerMenu.TabIndex = 0;
            // 
            // BtnMsUpdate
            // 
            this.BtnMsUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMsUpdate.Location = new System.Drawing.Point(258, 3);
            this.BtnMsUpdate.Name = "BtnMsUpdate";
            this.BtnMsUpdate.Size = new System.Drawing.Size(249, 30);
            this.BtnMsUpdate.TabIndex = 2;
            this.BtnMsUpdate.Text = "信息修改";
            this.BtnMsUpdate.UseVisualStyleBackColor = true;
            this.BtnMsUpdate.Click += new System.EventHandler(this.BtnMsUpdate_Click);
            // 
            // BtnMsInsert
            // 
            this.BtnMsInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMsInsert.Location = new System.Drawing.Point(3, 3);
            this.BtnMsInsert.Name = "BtnMsInsert";
            this.BtnMsInsert.Size = new System.Drawing.Size(249, 30);
            this.BtnMsInsert.TabIndex = 1;
            this.BtnMsInsert.Text = "会员注册";
            this.BtnMsInsert.UseVisualStyleBackColor = true;
            this.BtnMsInsert.Click += new System.EventHandler(this.BtnMsInsert_Click);
            // 
            // TlpMembership
            // 
            this.TlpMembership.ColumnCount = 1;
            this.TlpMembership.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpMembership.Controls.Add(this.TlpMsControllerMenu, 0, 0);
            this.TlpMembership.Controls.Add(this.DgvMembership, 0, 1);
            this.TlpMembership.Controls.Add(this.TlpMsSubmitMenu, 0, 2);
            this.TlpMembership.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMembership.Location = new System.Drawing.Point(0, 0);
            this.TlpMembership.Name = "TlpMembership";
            this.TlpMembership.RowCount = 3;
            this.TlpMembership.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpMembership.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.TlpMembership.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.TlpMembership.Size = new System.Drawing.Size(516, 327);
            this.TlpMembership.TabIndex = 6;
            // 
            // TlpMsSubmitMenu
            // 
            this.TlpMsSubmitMenu.ColumnCount = 5;
            this.TlpMsSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpMsSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpMsSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpMsSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpMsSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TlpMsSubmitMenu.Controls.Add(this.BtnMsDelete, 0, 0);
            this.TlpMsSubmitMenu.Controls.Add(this.BtnSubmit, 2, 0);
            this.TlpMsSubmitMenu.Controls.Add(this.BtnCancel, 3, 0);
            this.TlpMsSubmitMenu.Controls.Add(this.BtnBack, 4, 0);
            this.TlpMsSubmitMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMsSubmitMenu.Location = new System.Drawing.Point(3, 285);
            this.TlpMsSubmitMenu.Name = "TlpMsSubmitMenu";
            this.TlpMsSubmitMenu.RowCount = 1;
            this.TlpMsSubmitMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpMsSubmitMenu.Size = new System.Drawing.Size(510, 39);
            this.TlpMsSubmitMenu.TabIndex = 2;
            // 
            // BtnMsDelete
            // 
            this.BtnMsDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMsDelete.Location = new System.Drawing.Point(3, 3);
            this.BtnMsDelete.Name = "BtnMsDelete";
            this.BtnMsDelete.Size = new System.Drawing.Size(79, 33);
            this.BtnMsDelete.TabIndex = 6;
            this.BtnMsDelete.Text = "销户";
            this.BtnMsDelete.UseVisualStyleBackColor = true;
            this.BtnMsDelete.Click += new System.EventHandler(this.BtnMsDelete_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSubmit.Location = new System.Drawing.Point(257, 3);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(79, 33);
            this.BtnSubmit.TabIndex = 7;
            this.BtnSubmit.Text = "提交修改";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.Location = new System.Drawing.Point(342, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(79, 33);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "清空修改";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBack.Location = new System.Drawing.Point(427, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(80, 33);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "退出";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 327);
            this.Controls.Add(this.TlpMembership);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMembership";
            this.Text = "FrmMembership";
//            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMembership_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMembership)).EndInit();
            this.TlpMsControllerMenu.ResumeLayout(false);
            this.TlpMembership.ResumeLayout(false);
            this.TlpMsSubmitMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMembership;
        private System.Windows.Forms.TableLayoutPanel TlpMsControllerMenu;
        private System.Windows.Forms.Button BtnMsUpdate;
        private System.Windows.Forms.Button BtnMsInsert;
        private System.Windows.Forms.TableLayoutPanel TlpMembership;
        private System.Windows.Forms.TableLayoutPanel TlpMsSubmitMenu;
        private System.Windows.Forms.Button BtnMsDelete;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnMsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnMsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnMsPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnMsPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnMsIsValid;
        private System.Windows.Forms.Button BtnBack;
    }
}