namespace GoodManagerSys
{
    partial class FrmStaffUpdate
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
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.CmbStaffRole = new System.Windows.Forms.ComboBox();
            this.LblStaffRole = new System.Windows.Forms.Label();
            this.LblStaffPhone = new System.Windows.Forms.Label();
            this.LblStaffPwd = new System.Windows.Forms.Label();
            this.LblStaffName = new System.Windows.Forms.Label();
            this.LblStaffID = new System.Windows.Forms.Label();
            this.TxtStaffPhone = new System.Windows.Forms.TextBox();
            this.TxtStaffPwd = new System.Windows.Forms.TextBox();
            this.TxtStaffName = new System.Windows.Forms.TextBox();
            this.TxtStaffID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSubmit.Location = new System.Drawing.Point(62, 209);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(80, 26);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "提交修改";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBack.Location = new System.Drawing.Point(169, 209);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(80, 26);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "返回";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // CmbStaffRole
            // 
            this.CmbStaffRole.FormattingEnabled = true;
            this.CmbStaffRole.Items.AddRange(new object[] {
            "收银员",
            "采购员",
            "管理员"});
            this.CmbStaffRole.Location = new System.Drawing.Point(132, 155);
            this.CmbStaffRole.Margin = new System.Windows.Forms.Padding(2);
            this.CmbStaffRole.Name = "CmbStaffRole";
            this.CmbStaffRole.Size = new System.Drawing.Size(110, 20);
            this.CmbStaffRole.TabIndex = 42;
            // 
            // LblStaffRole
            // 
            this.LblStaffRole.AutoSize = true;
            this.LblStaffRole.Location = new System.Drawing.Point(75, 159);
            this.LblStaffRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStaffRole.Name = "LblStaffRole";
            this.LblStaffRole.Size = new System.Drawing.Size(53, 12);
            this.LblStaffRole.TabIndex = 41;
            this.LblStaffRole.Text = "员工权限";
            // 
            // LblStaffPhone
            // 
            this.LblStaffPhone.AutoSize = true;
            this.LblStaffPhone.Location = new System.Drawing.Point(75, 132);
            this.LblStaffPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStaffPhone.Name = "LblStaffPhone";
            this.LblStaffPhone.Size = new System.Drawing.Size(41, 12);
            this.LblStaffPhone.TabIndex = 40;
            this.LblStaffPhone.Text = "手机号";
            // 
            // LblStaffPwd
            // 
            this.LblStaffPwd.AutoSize = true;
            this.LblStaffPwd.Location = new System.Drawing.Point(75, 107);
            this.LblStaffPwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStaffPwd.Name = "LblStaffPwd";
            this.LblStaffPwd.Size = new System.Drawing.Size(29, 12);
            this.LblStaffPwd.TabIndex = 39;
            this.LblStaffPwd.Text = "密码";
            // 
            // LblStaffName
            // 
            this.LblStaffName.AutoSize = true;
            this.LblStaffName.Location = new System.Drawing.Point(75, 82);
            this.LblStaffName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStaffName.Name = "LblStaffName";
            this.LblStaffName.Size = new System.Drawing.Size(41, 12);
            this.LblStaffName.TabIndex = 38;
            this.LblStaffName.Text = "员工名";
            // 
            // LblStaffID
            // 
            this.LblStaffID.AutoSize = true;
            this.LblStaffID.Location = new System.Drawing.Point(75, 57);
            this.LblStaffID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStaffID.Name = "LblStaffID";
            this.LblStaffID.Size = new System.Drawing.Size(53, 12);
            this.LblStaffID.TabIndex = 37;
            this.LblStaffID.Text = "员工编号";
            // 
            // TxtStaffPhone
            // 
            this.TxtStaffPhone.Location = new System.Drawing.Point(132, 128);
            this.TxtStaffPhone.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStaffPhone.Name = "TxtStaffPhone";
            this.TxtStaffPhone.Size = new System.Drawing.Size(110, 21);
            this.TxtStaffPhone.TabIndex = 36;
            // 
            // TxtStaffPwd
            // 
            this.TxtStaffPwd.Location = new System.Drawing.Point(132, 103);
            this.TxtStaffPwd.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStaffPwd.Name = "TxtStaffPwd";
            this.TxtStaffPwd.Size = new System.Drawing.Size(110, 21);
            this.TxtStaffPwd.TabIndex = 35;
            // 
            // TxtStaffName
            // 
            this.TxtStaffName.Location = new System.Drawing.Point(132, 78);
            this.TxtStaffName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStaffName.Name = "TxtStaffName";
            this.TxtStaffName.Size = new System.Drawing.Size(110, 21);
            this.TxtStaffName.TabIndex = 34;
            // 
            // TxtStaffID
            // 
            this.TxtStaffID.Location = new System.Drawing.Point(132, 53);
            this.TxtStaffID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStaffID.Name = "TxtStaffID";
            this.TxtStaffID.Size = new System.Drawing.Size(110, 21);
            this.TxtStaffID.TabIndex = 33;
            // 
            // FrmStaffUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 302);
            this.Controls.Add(this.CmbStaffRole);
            this.Controls.Add(this.LblStaffRole);
            this.Controls.Add(this.LblStaffPhone);
            this.Controls.Add(this.LblStaffPwd);
            this.Controls.Add(this.LblStaffName);
            this.Controls.Add(this.LblStaffID);
            this.Controls.Add(this.TxtStaffPhone);
            this.Controls.Add(this.TxtStaffPwd);
            this.Controls.Add(this.TxtStaffName);
            this.Controls.Add(this.TxtStaffID);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSubmit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmStaffUpdate";
            this.Text = "员工信息修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox CmbStaffRole;
        private System.Windows.Forms.Label LblStaffRole;
        private System.Windows.Forms.Label LblStaffPhone;
        private System.Windows.Forms.Label LblStaffPwd;
        private System.Windows.Forms.Label LblStaffName;
        private System.Windows.Forms.Label LblStaffID;
        private System.Windows.Forms.TextBox TxtStaffPhone;
        private System.Windows.Forms.TextBox TxtStaffPwd;
        private System.Windows.Forms.TextBox TxtStaffName;
        private System.Windows.Forms.TextBox TxtStaffID;
    }
}