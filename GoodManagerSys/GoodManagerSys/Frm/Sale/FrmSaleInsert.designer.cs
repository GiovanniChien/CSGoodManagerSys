namespace GoodManagerSys
{
    partial class FrmSaleInsert
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblGoodID = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.CmbGoodID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBack.Location = new System.Drawing.Point(113, 123);
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
            this.BtnInsert.Location = new System.Drawing.Point(22, 123);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(83, 26);
            this.BtnInsert.TabIndex = 39;
            this.BtnInsert.Text = "添加";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(22, 78);
            this.LblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(29, 12);
            this.LblPrice.TabIndex = 36;
            this.LblPrice.Text = "售价";
            // 
            // LblGoodID
            // 
            this.LblGoodID.AutoSize = true;
            this.LblGoodID.Location = new System.Drawing.Point(22, 40);
            this.LblGoodID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblGoodID.Name = "LblGoodID";
            this.LblGoodID.Size = new System.Drawing.Size(53, 12);
            this.LblGoodID.TabIndex = 34;
            this.LblGoodID.Text = "商品编号";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(83, 74);
            this.TxtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(121, 21);
            this.TxtPrice.TabIndex = 32;
            // 
            // CmbGoodID
            // 
            this.CmbGoodID.FormattingEnabled = true;
            this.CmbGoodID.Location = new System.Drawing.Point(83, 36);
            this.CmbGoodID.Name = "CmbGoodID";
            this.CmbGoodID.Size = new System.Drawing.Size(121, 20);
            this.CmbGoodID.TabIndex = 40;
            // 
            // FrmSaleInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 186);
            this.Controls.Add(this.CmbGoodID);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblGoodID);
            this.Controls.Add(this.TxtPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSaleInsert";
            this.Text = "销售单添加";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSaleInsert_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblGoodID;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.ComboBox CmbGoodID;
    }
}