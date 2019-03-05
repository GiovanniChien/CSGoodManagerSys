namespace GoodManagerSys
{
    partial class FrmGoodInsert
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
            this.LblProductionID = new System.Windows.Forms.Label();
            this.LblCategoryID = new System.Windows.Forms.Label();
            this.TxtCategoryID = new System.Windows.Forms.TextBox();
            this.LblCost = new System.Windows.Forms.Label();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.DtpProductionID = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmbIsValid
            // 
            this.CmbIsValid.FormattingEnabled = true;
            this.CmbIsValid.Items.AddRange(new object[] {
            "未上架",
            "未出售"});
            this.CmbIsValid.Location = new System.Drawing.Point(90, 152);
            this.CmbIsValid.Margin = new System.Windows.Forms.Padding(2);
            this.CmbIsValid.Name = "CmbIsValid";
            this.CmbIsValid.Size = new System.Drawing.Size(110, 20);
            this.CmbIsValid.TabIndex = 24;
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBack.Location = new System.Drawing.Point(122, 196);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(82, 26);
            this.BtnBack.TabIndex = 22;
            this.BtnBack.Text = "返回";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnInsert.Location = new System.Drawing.Point(35, 196);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(83, 26);
            this.BtnInsert.TabIndex = 23;
            this.BtnInsert.Text = "添加";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // LblIsValid
            // 
            this.LblIsValid.AutoSize = true;
            this.LblIsValid.Location = new System.Drawing.Point(33, 156);
            this.LblIsValid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblIsValid.Name = "LblIsValid";
            this.LblIsValid.Size = new System.Drawing.Size(53, 12);
            this.LblIsValid.TabIndex = 21;
            this.LblIsValid.Text = "有效状态";
            // 
            // LblProductionID
            // 
            this.LblProductionID.AutoSize = true;
            this.LblProductionID.Location = new System.Drawing.Point(33, 46);
            this.LblProductionID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProductionID.Name = "LblProductionID";
            this.LblProductionID.Size = new System.Drawing.Size(53, 12);
            this.LblProductionID.TabIndex = 19;
            this.LblProductionID.Text = "生产日期";
            // 
            // LblCategoryID
            // 
            this.LblCategoryID.AutoSize = true;
            this.LblCategoryID.Location = new System.Drawing.Point(33, 20);
            this.LblCategoryID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCategoryID.Name = "LblCategoryID";
            this.LblCategoryID.Size = new System.Drawing.Size(53, 12);
            this.LblCategoryID.TabIndex = 18;
            this.LblCategoryID.Text = "商品类别";
            // 
            // TxtCategoryID
            // 
            this.TxtCategoryID.Location = new System.Drawing.Point(90, 16);
            this.TxtCategoryID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCategoryID.Name = "TxtCategoryID";
            this.TxtCategoryID.Size = new System.Drawing.Size(110, 21);
            this.TxtCategoryID.TabIndex = 14;
            // 
            // LblCost
            // 
            this.LblCost.AutoSize = true;
            this.LblCost.Location = new System.Drawing.Point(33, 74);
            this.LblCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(53, 12);
            this.LblCost.TabIndex = 26;
            this.LblCost.Text = "采购单价";
            // 
            // TxtCost
            // 
            this.TxtCost.Location = new System.Drawing.Point(90, 70);
            this.TxtCost.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(110, 21);
            this.TxtCost.TabIndex = 25;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(33, 100);
            this.LblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(29, 12);
            this.LblPrice.TabIndex = 28;
            this.LblPrice.Text = "售价";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(90, 96);
            this.TxtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(110, 21);
            this.TxtPrice.TabIndex = 27;
            // 
            // DtpProductionID
            // 
            this.DtpProductionID.CustomFormat = "yyyy-MM-dd";
            this.DtpProductionID.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpProductionID.Location = new System.Drawing.Point(90, 42);
            this.DtpProductionID.Margin = new System.Windows.Forms.Padding(2);
            this.DtpProductionID.Name = "DtpProductionID";
            this.DtpProductionID.Size = new System.Drawing.Size(110, 21);
            this.DtpProductionID.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 31;
            this.label1.Text = "数量";
            // 
            // TxtCount
            // 
            this.TxtCount.Location = new System.Drawing.Point(90, 124);
            this.TxtCount.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCount.Name = "TxtCount";
            this.TxtCount.Size = new System.Drawing.Size(110, 21);
            this.TxtCount.TabIndex = 30;
            // 
            // FrmGoodInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 245);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCount);
            this.Controls.Add(this.DtpProductionID);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.LblCost);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.CmbIsValid);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.LblIsValid);
            this.Controls.Add(this.LblProductionID);
            this.Controls.Add(this.LblCategoryID);
            this.Controls.Add(this.TxtCategoryID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmGoodInsert";
            this.Text = "商品采购";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbIsValid;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Label LblIsValid;
        private System.Windows.Forms.Label LblProductionID;
        private System.Windows.Forms.Label LblCategoryID;
        private System.Windows.Forms.TextBox TxtCategoryID;
        private System.Windows.Forms.Label LblCost;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.DateTimePicker DtpProductionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCount;
    }
}