namespace GoodManagerSys
{
    partial class FrmMsInsert
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
            this.CmbIsValid = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.LblIsValid = new System.Windows.Forms.Label();
            this.LblMsPoint = new System.Windows.Forms.Label();
            this.LblMsPhone = new System.Windows.Forms.Label();
            this.LblMsName = new System.Windows.Forms.Label();
            this.TxtMsPoint = new System.Windows.Forms.TextBox();
            this.TxtMsPhone = new System.Windows.Forms.TextBox();
            this.TxtMsName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmbIsValid
            // 
            this.CmbIsValid.FormattingEnabled = true;
            this.CmbIsValid.Items.AddRange(new object[] {
            "有效",
            "已删除"});
            this.CmbIsValid.Location = new System.Drawing.Point(79, 104);
            this.CmbIsValid.Margin = new System.Windows.Forms.Padding(2);
            this.CmbIsValid.Name = "CmbIsValid";
            this.CmbIsValid.Size = new System.Drawing.Size(110, 20);
            this.CmbIsValid.TabIndex = 40;
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBack.Location = new System.Drawing.Point(112, 153);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(82, 26);
            this.BtnBack.TabIndex = 38;
            this.BtnBack.Text = "返回";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnInsert.Location = new System.Drawing.Point(25, 153);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(83, 26);
            this.BtnInsert.TabIndex = 39;
            this.BtnInsert.Text = "添加";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // LblIsValid
            // 
            this.LblIsValid.AutoSize = true;
            this.LblIsValid.Location = new System.Drawing.Point(24, 108);
            this.LblIsValid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblIsValid.Name = "LblIsValid";
            this.LblIsValid.Size = new System.Drawing.Size(53, 12);
            this.LblIsValid.TabIndex = 37;
            this.LblIsValid.Text = "有效状态";
            // 
            // LblMsPoint
            // 
            this.LblMsPoint.AutoSize = true;
            this.LblMsPoint.Location = new System.Drawing.Point(22, 83);
            this.LblMsPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMsPoint.Name = "LblMsPoint";
            this.LblMsPoint.Size = new System.Drawing.Size(29, 12);
            this.LblMsPoint.TabIndex = 36;
            this.LblMsPoint.Text = "积分";
            // 
            // LblMsPhone
            // 
            this.LblMsPhone.AutoSize = true;
            this.LblMsPhone.Location = new System.Drawing.Point(22, 58);
            this.LblMsPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMsPhone.Name = "LblMsPhone";
            this.LblMsPhone.Size = new System.Drawing.Size(41, 12);
            this.LblMsPhone.TabIndex = 35;
            this.LblMsPhone.Text = "手机号";
            // 
            // LblMsName
            // 
            this.LblMsName.AutoSize = true;
            this.LblMsName.Location = new System.Drawing.Point(22, 33);
            this.LblMsName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMsName.Name = "LblMsName";
            this.LblMsName.Size = new System.Drawing.Size(53, 12);
            this.LblMsName.TabIndex = 34;
            this.LblMsName.Text = "会员姓名";
            // 
            // TxtMsPoint
            // 
            this.TxtMsPoint.Location = new System.Drawing.Point(79, 79);
            this.TxtMsPoint.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMsPoint.Name = "TxtMsPoint";
            this.TxtMsPoint.Size = new System.Drawing.Size(110, 21);
            this.TxtMsPoint.TabIndex = 32;
            this.TxtMsPoint.Text = "0";
            // 
            // TxtMsPhone
            // 
            this.TxtMsPhone.Location = new System.Drawing.Point(79, 54);
            this.TxtMsPhone.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMsPhone.Name = "TxtMsPhone";
            this.TxtMsPhone.Size = new System.Drawing.Size(110, 21);
            this.TxtMsPhone.TabIndex = 31;
            // 
            // TxtMsName
            // 
            this.TxtMsName.Location = new System.Drawing.Point(79, 29);
            this.TxtMsName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMsName.Name = "TxtMsName";
            this.TxtMsName.Size = new System.Drawing.Size(110, 21);
            this.TxtMsName.TabIndex = 30;
            // 
            // FrmMsInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 204);
            this.Controls.Add(this.CmbIsValid);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.LblIsValid);
            this.Controls.Add(this.LblMsPoint);
            this.Controls.Add(this.LblMsPhone);
            this.Controls.Add(this.LblMsName);
            this.Controls.Add(this.TxtMsPoint);
            this.Controls.Add(this.TxtMsPhone);
            this.Controls.Add(this.TxtMsName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMsInsert";
            this.Text = "会员添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbIsValid;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Label LblIsValid;
        private System.Windows.Forms.Label LblMsPoint;
        private System.Windows.Forms.Label LblMsPhone;
        private System.Windows.Forms.Label LblMsName;
        private System.Windows.Forms.TextBox TxtMsPoint;
        private System.Windows.Forms.TextBox TxtMsPhone;
        private System.Windows.Forms.TextBox TxtMsName;
    }
}