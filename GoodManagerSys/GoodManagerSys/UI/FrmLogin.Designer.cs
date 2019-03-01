namespace WindowsFormsApp1
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.TxtAccount = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblAccount = new System.Windows.Forms.Label();
            this.PicLoginBackground = new System.Windows.Forms.PictureBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicLoginBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtAccount
            // 
            this.TxtAccount.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtAccount.Location = new System.Drawing.Point(196, 157);
            this.TxtAccount.Name = "TxtAccount";
            this.TxtAccount.Size = new System.Drawing.Size(220, 24);
            this.TxtAccount.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPassword.Location = new System.Drawing.Point(196, 217);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(220, 24);
            this.TxtPassword.TabIndex = 2;
            // 
            // LblAccount
            // 
            this.LblAccount.AutoSize = true;
            this.LblAccount.BackColor = System.Drawing.Color.Transparent;
            this.LblAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblAccount.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblAccount.ForeColor = System.Drawing.Color.Purple;
            this.LblAccount.Location = new System.Drawing.Point(132, 161);
            this.LblAccount.Name = "LblAccount";
            this.LblAccount.Size = new System.Drawing.Size(49, 19);
            this.LblAccount.TabIndex = 3;
            this.LblAccount.Text = "账号";
            // 
            // PicLoginBackground
            // 
            this.PicLoginBackground.BackColor = System.Drawing.Color.Transparent;
            this.PicLoginBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicLoginBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicLoginBackground.Image = ((System.Drawing.Image)(resources.GetObject("PicLoginBackground.Image")));
            this.PicLoginBackground.Location = new System.Drawing.Point(0, 0);
            this.PicLoginBackground.Name = "PicLoginBackground";
            this.PicLoginBackground.Size = new System.Drawing.Size(600, 377);
            this.PicLoginBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLoginBackground.TabIndex = 7;
            this.PicLoginBackground.TabStop = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.BackgroundImage")));
            this.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLogin.Location = new System.Drawing.Point(233, 261);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(140, 52);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblPassword.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblPassword.ForeColor = System.Drawing.Color.Purple;
            this.LblPassword.Location = new System.Drawing.Point(132, 221);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(49, 19);
            this.LblPassword.TabIndex = 4;
            this.LblPassword.Text = "密码";
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 377);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblAccount);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtAccount);
            this.Controls.Add(this.PicLoginBackground);
            this.Name = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicLoginBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAccount;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblAccount;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.PictureBox PicLoginBackground;
    }
}

