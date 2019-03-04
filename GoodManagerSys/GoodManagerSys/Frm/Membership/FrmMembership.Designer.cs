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
            this.TlpMsControllerMenu = new System.Windows.Forms.TableLayoutPanel();
            this.BtnMsInsert = new System.Windows.Forms.Button();
            this.BtnMsUpdate = new System.Windows.Forms.Button();
            this.BtnMsPoint = new System.Windows.Forms.Button();
            this.TlpMsMenu = new System.Windows.Forms.TableLayoutPanel();
            this.TlpMsSubmitMenu = new System.Windows.Forms.TableLayoutPanel();
            this.BtnMsDelete = new System.Windows.Forms.Button();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMembership)).BeginInit();
            this.TlpMsControllerMenu.SuspendLayout();
            this.TlpMsMenu.SuspendLayout();
            this.TlpMsSubmitMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvMembership
            // 
            this.DgvMembership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMembership.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMembership.Location = new System.Drawing.Point(3, 45);
            this.DgvMembership.Name = "DgvMembership";
            this.DgvMembership.RowTemplate.Height = 23;
            this.DgvMembership.Size = new System.Drawing.Size(420, 234);
            this.DgvMembership.TabIndex = 1;
            // 
            // TlpMsControllerMenu
            // 
            this.TlpMsControllerMenu.ColumnCount = 3;
            this.TlpMsControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpMsControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpMsControllerMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpMsControllerMenu.Controls.Add(this.BtnMsPoint, 2, 0);
            this.TlpMsControllerMenu.Controls.Add(this.BtnMsUpdate, 1, 0);
            this.TlpMsControllerMenu.Controls.Add(this.BtnMsInsert, 0, 0);
            this.TlpMsControllerMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMsControllerMenu.Location = new System.Drawing.Point(3, 3);
            this.TlpMsControllerMenu.Name = "TlpMsControllerMenu";
            this.TlpMsControllerMenu.RowCount = 1;
            this.TlpMsControllerMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpMsControllerMenu.Size = new System.Drawing.Size(420, 36);
            this.TlpMsControllerMenu.TabIndex = 0;
            // 
            // BtnMsInsert
            // 
            this.BtnMsInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMsInsert.Location = new System.Drawing.Point(3, 3);
            this.BtnMsInsert.Name = "BtnMsInsert";
            this.BtnMsInsert.Size = new System.Drawing.Size(134, 30);
            this.BtnMsInsert.TabIndex = 1;
            this.BtnMsInsert.Text = "会员注册";
            this.BtnMsInsert.UseVisualStyleBackColor = true;
            this.BtnMsInsert.Click += new System.EventHandler(this.BtnMsInsert_Click);
            // 
            // BtnMsUpdate
            // 
            this.BtnMsUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMsUpdate.Location = new System.Drawing.Point(143, 3);
            this.BtnMsUpdate.Name = "BtnMsUpdate";
            this.BtnMsUpdate.Size = new System.Drawing.Size(134, 30);
            this.BtnMsUpdate.TabIndex = 2;
            this.BtnMsUpdate.Text = "信息修改";
            this.BtnMsUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnMsPoint
            // 
            this.BtnMsPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMsPoint.Location = new System.Drawing.Point(283, 3);
            this.BtnMsPoint.Name = "BtnMsPoint";
            this.BtnMsPoint.Size = new System.Drawing.Size(134, 30);
            this.BtnMsPoint.TabIndex = 3;
            this.BtnMsPoint.Text = "积分查询";
            this.BtnMsPoint.UseVisualStyleBackColor = true;
            // 
            // TlpMsMenu
            // 
            this.TlpMsMenu.ColumnCount = 1;
            this.TlpMsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpMsMenu.Controls.Add(this.TlpMsControllerMenu, 0, 0);
            this.TlpMsMenu.Controls.Add(this.DgvMembership, 0, 1);
            this.TlpMsMenu.Controls.Add(this.TlpMsSubmitMenu, 0, 2);
            this.TlpMsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMsMenu.Location = new System.Drawing.Point(0, 0);
            this.TlpMsMenu.Name = "TlpMsMenu";
            this.TlpMsMenu.RowCount = 3;
            this.TlpMsMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpMsMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.TlpMsMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.TlpMsMenu.Size = new System.Drawing.Size(426, 327);
            this.TlpMsMenu.TabIndex = 6;
            this.TlpMsMenu.Visible = false;
            // 
            // TlpMsSubmitMenu
            // 
            this.TlpMsSubmitMenu.ColumnCount = 4;
            this.TlpMsSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMsSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TlpMsSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMsSubmitMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMsSubmitMenu.Controls.Add(this.BtnMsDelete, 0, 0);
            this.TlpMsSubmitMenu.Controls.Add(this.BtnSubmit, 2, 0);
            this.TlpMsSubmitMenu.Controls.Add(this.BtnCancel, 3, 0);
            this.TlpMsSubmitMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMsSubmitMenu.Location = new System.Drawing.Point(3, 285);
            this.TlpMsSubmitMenu.Name = "TlpMsSubmitMenu";
            this.TlpMsSubmitMenu.RowCount = 1;
            this.TlpMsSubmitMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpMsSubmitMenu.Size = new System.Drawing.Size(420, 39);
            this.TlpMsSubmitMenu.TabIndex = 2;
            // 
            // BtnMsDelete
            // 
            this.BtnMsDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMsDelete.Location = new System.Drawing.Point(3, 3);
            this.BtnMsDelete.Name = "BtnMsDelete";
            this.BtnMsDelete.Size = new System.Drawing.Size(78, 33);
            this.BtnMsDelete.TabIndex = 6;
            this.BtnMsDelete.Text = "销户";
            this.BtnMsDelete.UseVisualStyleBackColor = true;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSubmit.Location = new System.Drawing.Point(255, 3);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(78, 33);
            this.BtnSubmit.TabIndex = 7;
            this.BtnSubmit.Text = "提交修改";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.Location = new System.Drawing.Point(339, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(78, 33);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "清空修改";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 327);
            this.Controls.Add(this.TlpMsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMembership";
            this.Text = "FrmMembership";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMembership)).EndInit();
            this.TlpMsControllerMenu.ResumeLayout(false);
            this.TlpMsMenu.ResumeLayout(false);
            this.TlpMsSubmitMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMembership;
        private System.Windows.Forms.TableLayoutPanel TlpMsControllerMenu;
        private System.Windows.Forms.Button BtnMsPoint;
        private System.Windows.Forms.Button BtnMsUpdate;
        private System.Windows.Forms.Button BtnMsInsert;
        private System.Windows.Forms.TableLayoutPanel TlpMsMenu;
        private System.Windows.Forms.TableLayoutPanel TlpMsSubmitMenu;
        private System.Windows.Forms.Button BtnMsDelete;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnCancel;
    }
}