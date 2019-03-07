namespace GoodManagerSys.Frm.Membership {
    partial class FrmMsUpdate {
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMsName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMsPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMsPoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbIsValid = new System.Windows.Forms.ComboBox();
            this.BtnMsUpdate = new System.Windows.Forms.Button();
            this.BtnMsCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员姓名";
            // 
            // TxtMsName
            // 
            this.TxtMsName.Location = new System.Drawing.Point(105, 20);
            this.TxtMsName.Name = "TxtMsName";
            this.TxtMsName.Size = new System.Drawing.Size(121, 21);
            this.TxtMsName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "联系方式";
            // 
            // TxtMsPhone
            // 
            this.TxtMsPhone.Location = new System.Drawing.Point(105, 63);
            this.TxtMsPhone.Name = "TxtMsPhone";
            this.TxtMsPhone.Size = new System.Drawing.Size(121, 21);
            this.TxtMsPhone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "会员积分";
            // 
            // TxtMsPoint
            // 
            this.TxtMsPoint.Location = new System.Drawing.Point(105, 106);
            this.TxtMsPoint.Name = "TxtMsPoint";
            this.TxtMsPoint.Size = new System.Drawing.Size(121, 21);
            this.TxtMsPoint.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "有效状态";
            // 
            // CmbIsValid
            // 
            this.CmbIsValid.FormattingEnabled = true;
            this.CmbIsValid.Items.AddRange(new object[] {
            "有效",
            "已删除"});
            this.CmbIsValid.Location = new System.Drawing.Point(105, 149);
            this.CmbIsValid.Name = "CmbIsValid";
            this.CmbIsValid.Size = new System.Drawing.Size(121, 20);
            this.CmbIsValid.TabIndex = 7;
            // 
            // BtnMsUpdate
            // 
            this.BtnMsUpdate.Location = new System.Drawing.Point(57, 191);
            this.BtnMsUpdate.Name = "BtnMsUpdate";
            this.BtnMsUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnMsUpdate.TabIndex = 8;
            this.BtnMsUpdate.Text = "提交修改";
            this.BtnMsUpdate.UseVisualStyleBackColor = true;
            this.BtnMsUpdate.Click += new System.EventHandler(this.BtnMsUpdate_Click);
            // 
            // BtnMsCancel
            // 
            this.BtnMsCancel.Location = new System.Drawing.Point(138, 191);
            this.BtnMsCancel.Name = "BtnMsCancel";
            this.BtnMsCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnMsCancel.TabIndex = 9;
            this.BtnMsCancel.Text = "取消";
            this.BtnMsCancel.UseVisualStyleBackColor = true;
            this.BtnMsCancel.Click += new System.EventHandler(this.BtnMsCancel_Click);
            // 
            // FrmMsUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 239);
            this.Controls.Add(this.BtnMsCancel);
            this.Controls.Add(this.BtnMsUpdate);
            this.Controls.Add(this.CmbIsValid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMsPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtMsPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMsName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMsUpdate";
            this.Text = "FrmMsUpdate";
//            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMsUpdate_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMsName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMsPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMsPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbIsValid;
        private System.Windows.Forms.Button BtnMsUpdate;
        private System.Windows.Forms.Button BtnMsCancel;
    }
}