namespace GoodManagerSys {
    partial class FrmStaffUpdate {
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
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.CmbStaffRole = new System.Windows.Forms.ComboBox();
            this.LblStaffRole = new System.Windows.Forms.Label();
            this.LblStaffPhone = new System.Windows.Forms.Label();
            this.LblStaffName = new System.Windows.Forms.Label();
            this.TxtStaffPhone = new System.Windows.Forms.TextBox();
            this.TxtStaffName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSubmit.Location = new System.Drawing.Point(28, 138);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(80, 26);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "提交修改";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBack.Location = new System.Drawing.Point(113, 138);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(80, 26);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "返回";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // CmbStaffRole
            // 
            this.CmbStaffRole.FormattingEnabled = true;
            this.CmbStaffRole.Items.AddRange(new object[] {
            "未定义",
            "收银员",
            "采购员",
            "管理员"});
            this.CmbStaffRole.Location = new System.Drawing.Point(83, 97);
            this.CmbStaffRole.Margin = new System.Windows.Forms.Padding(2);
            this.CmbStaffRole.Name = "CmbStaffRole";
            this.CmbStaffRole.Size = new System.Drawing.Size(110, 20);
            this.CmbStaffRole.TabIndex = 42;
            // 
            // LblStaffRole
            // 
            this.LblStaffRole.AutoSize = true;
            this.LblStaffRole.Location = new System.Drawing.Point(26, 101);
            this.LblStaffRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStaffRole.Name = "LblStaffRole";
            this.LblStaffRole.Size = new System.Drawing.Size(53, 12);
            this.LblStaffRole.TabIndex = 41;
            this.LblStaffRole.Text = "员工权限";
            // 
            // LblStaffPhone
            // 
            this.LblStaffPhone.AutoSize = true;
            this.LblStaffPhone.Location = new System.Drawing.Point(26, 63);
            this.LblStaffPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStaffPhone.Name = "LblStaffPhone";
            this.LblStaffPhone.Size = new System.Drawing.Size(41, 12);
            this.LblStaffPhone.TabIndex = 40;
            this.LblStaffPhone.Text = "手机号";
            // 
            // LblStaffName
            // 
            this.LblStaffName.AutoSize = true;
            this.LblStaffName.Location = new System.Drawing.Point(26, 25);
            this.LblStaffName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStaffName.Name = "LblStaffName";
            this.LblStaffName.Size = new System.Drawing.Size(41, 12);
            this.LblStaffName.TabIndex = 38;
            this.LblStaffName.Text = "员工名";
            // 
            // TxtStaffPhone
            // 
            this.TxtStaffPhone.Location = new System.Drawing.Point(83, 59);
            this.TxtStaffPhone.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStaffPhone.Name = "TxtStaffPhone";
            this.TxtStaffPhone.Size = new System.Drawing.Size(110, 21);
            this.TxtStaffPhone.TabIndex = 36;
            // 
            // TxtStaffName
            // 
            this.TxtStaffName.Location = new System.Drawing.Point(83, 21);
            this.TxtStaffName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStaffName.Name = "TxtStaffName";
            this.TxtStaffName.Size = new System.Drawing.Size(110, 21);
            this.TxtStaffName.TabIndex = 34;
            // 
            // FrmStaffUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 182);
            this.Controls.Add(this.CmbStaffRole);
            this.Controls.Add(this.LblStaffRole);
            this.Controls.Add(this.LblStaffPhone);
            this.Controls.Add(this.LblStaffName);
            this.Controls.Add(this.TxtStaffPhone);
            this.Controls.Add(this.TxtStaffName);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStaffUpdate";
            this.Text = "员工信息修改";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStaffUpdate_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox CmbStaffRole;
        private System.Windows.Forms.Label LblStaffRole;
        private System.Windows.Forms.Label LblStaffPhone;
        private System.Windows.Forms.Label LblStaffName;
        private System.Windows.Forms.TextBox TxtStaffPhone;
        private System.Windows.Forms.TextBox TxtStaffName;
    }
}