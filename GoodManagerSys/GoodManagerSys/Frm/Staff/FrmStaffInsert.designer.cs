namespace GoodManagerSys {
    partial class FrmStaffInsert {
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
            this.TxtStaffName = new System.Windows.Forms.TextBox();
            this.TxtStaffPwd = new System.Windows.Forms.TextBox();
            this.TxtStaffPhone = new System.Windows.Forms.TextBox();
            this.LblStaffName = new System.Windows.Forms.Label();
            this.LblStaffPwd = new System.Windows.Forms.Label();
            this.LblStaffPhone = new System.Windows.Forms.Label();
            this.LblStaffRole = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.CmbStaffRole = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtStaffName
            // 
            this.TxtStaffName.Location = new System.Drawing.Point(82, 21);
            this.TxtStaffName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStaffName.Name = "TxtStaffName";
            this.TxtStaffName.Size = new System.Drawing.Size(110, 21);
            this.TxtStaffName.TabIndex = 1;
            // 
            // TxtStaffPwd
            // 
            this.TxtStaffPwd.Location = new System.Drawing.Point(82, 46);
            this.TxtStaffPwd.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStaffPwd.Name = "TxtStaffPwd";
            this.TxtStaffPwd.Size = new System.Drawing.Size(110, 21);
            this.TxtStaffPwd.TabIndex = 2;
            // 
            // TxtStaffPhone
            // 
            this.TxtStaffPhone.Location = new System.Drawing.Point(82, 71);
            this.TxtStaffPhone.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStaffPhone.Name = "TxtStaffPhone";
            this.TxtStaffPhone.Size = new System.Drawing.Size(110, 21);
            this.TxtStaffPhone.TabIndex = 3;
            // 
            // LblStaffName
            // 
            this.LblStaffName.AutoSize = true;
            this.LblStaffName.Location = new System.Drawing.Point(25, 23);
            this.LblStaffName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStaffName.Name = "LblStaffName";
            this.LblStaffName.Size = new System.Drawing.Size(41, 12);
            this.LblStaffName.TabIndex = 6;
            this.LblStaffName.Text = "员工名";
            // 
            // LblStaffPwd
            // 
            this.LblStaffPwd.AutoSize = true;
            this.LblStaffPwd.Location = new System.Drawing.Point(25, 48);
            this.LblStaffPwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStaffPwd.Name = "LblStaffPwd";
            this.LblStaffPwd.Size = new System.Drawing.Size(29, 12);
            this.LblStaffPwd.TabIndex = 7;
            this.LblStaffPwd.Text = "密码";
            // 
            // LblStaffPhone
            // 
            this.LblStaffPhone.AutoSize = true;
            this.LblStaffPhone.Location = new System.Drawing.Point(25, 73);
            this.LblStaffPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStaffPhone.Name = "LblStaffPhone";
            this.LblStaffPhone.Size = new System.Drawing.Size(41, 12);
            this.LblStaffPhone.TabIndex = 8;
            this.LblStaffPhone.Text = "手机号";
            // 
            // LblStaffRole
            // 
            this.LblStaffRole.AutoSize = true;
            this.LblStaffRole.Location = new System.Drawing.Point(25, 98);
            this.LblStaffRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStaffRole.Name = "LblStaffRole";
            this.LblStaffRole.Size = new System.Drawing.Size(53, 12);
            this.LblStaffRole.TabIndex = 9;
            this.LblStaffRole.Text = "员工权限";
            // 
            // BtnInsert
            // 
            this.BtnInsert.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnInsert.Location = new System.Drawing.Point(28, 135);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(83, 26);
            this.BtnInsert.TabIndex = 10;
            this.BtnInsert.Text = "添加";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // CmbStaffRole
            // 
            this.CmbStaffRole.FormattingEnabled = true;
            this.CmbStaffRole.Items.AddRange(new object[] {
            "未定义",
            "管理员",
            "销售员",
            "采购员"});
            this.CmbStaffRole.Location = new System.Drawing.Point(82, 98);
            this.CmbStaffRole.Margin = new System.Windows.Forms.Padding(2);
            this.CmbStaffRole.Name = "CmbStaffRole";
            this.CmbStaffRole.Size = new System.Drawing.Size(110, 20);
            this.CmbStaffRole.TabIndex = 12;
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBack.Location = new System.Drawing.Point(115, 135);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(82, 26);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.Text = "返回";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmStaffInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 191);
            this.Controls.Add(this.CmbStaffRole);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.LblStaffRole);
            this.Controls.Add(this.LblStaffPhone);
            this.Controls.Add(this.LblStaffPwd);
            this.Controls.Add(this.LblStaffName);
            this.Controls.Add(this.TxtStaffPhone);
            this.Controls.Add(this.TxtStaffPwd);
            this.Controls.Add(this.TxtStaffName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStaffInsert";
            this.Text = "添加员工";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStaffInsert_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtStaffName;
        private System.Windows.Forms.TextBox TxtStaffPwd;
        private System.Windows.Forms.TextBox TxtStaffPhone;
        private System.Windows.Forms.Label LblStaffName;
        private System.Windows.Forms.Label LblStaffPwd;
        private System.Windows.Forms.Label LblStaffPhone;
        private System.Windows.Forms.Label LblStaffRole;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.ComboBox CmbStaffRole;
        private System.Windows.Forms.Button BtnBack;
    }
}