namespace WindowsFormsApp1
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
            this.LblPurchaseID = new System.Windows.Forms.Label();
            this.LblProductionID = new System.Windows.Forms.Label();
            this.LblCategoryID = new System.Windows.Forms.Label();
            this.LblGoodID = new System.Windows.Forms.Label();
            this.TxtPurchaseDate = new System.Windows.Forms.TextBox();
            this.TxtProductionDate = new System.Windows.Forms.TextBox();
            this.TxtCategoryID = new System.Windows.Forms.TextBox();
            this.TxtGoodID = new System.Windows.Forms.TextBox();
            this.LblCost = new System.Windows.Forms.Label();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmbIsValid
            // 
            this.CmbIsValid.FormattingEnabled = true;
            this.CmbIsValid.Items.AddRange(new object[] {
            "有效",
            "无效"});
            this.CmbIsValid.Location = new System.Drawing.Point(121, 197);
            this.CmbIsValid.Margin = new System.Windows.Forms.Padding(2);
            this.CmbIsValid.Name = "CmbIsValid";
            this.CmbIsValid.Size = new System.Drawing.Size(110, 20);
            this.CmbIsValid.TabIndex = 24;
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBack.Location = new System.Drawing.Point(154, 234);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(82, 26);
            this.BtnBack.TabIndex = 22;
            this.BtnBack.Text = "返回";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnInsert.Location = new System.Drawing.Point(67, 234);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(83, 26);
            this.BtnInsert.TabIndex = 23;
            this.BtnInsert.Text = "添加";
            this.BtnInsert.UseVisualStyleBackColor = true;
            // 
            // LblIsValid
            // 
            this.LblIsValid.AutoSize = true;
            this.LblIsValid.Location = new System.Drawing.Point(64, 201);
            this.LblIsValid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblIsValid.Name = "LblIsValid";
            this.LblIsValid.Size = new System.Drawing.Size(53, 12);
            this.LblIsValid.TabIndex = 21;
            this.LblIsValid.Text = "有效状态";
            // 
            // LblPurchaseID
            // 
            this.LblPurchaseID.AutoSize = true;
            this.LblPurchaseID.Location = new System.Drawing.Point(64, 123);
            this.LblPurchaseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPurchaseID.Name = "LblPurchaseID";
            this.LblPurchaseID.Size = new System.Drawing.Size(53, 12);
            this.LblPurchaseID.TabIndex = 20;
            this.LblPurchaseID.Text = "采购日期";
            // 
            // LblProductionID
            // 
            this.LblProductionID.AutoSize = true;
            this.LblProductionID.Location = new System.Drawing.Point(64, 97);
            this.LblProductionID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProductionID.Name = "LblProductionID";
            this.LblProductionID.Size = new System.Drawing.Size(53, 12);
            this.LblProductionID.TabIndex = 19;
            this.LblProductionID.Text = "生产日期";
            // 
            // LblCategoryID
            // 
            this.LblCategoryID.AutoSize = true;
            this.LblCategoryID.Location = new System.Drawing.Point(64, 71);
            this.LblCategoryID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCategoryID.Name = "LblCategoryID";
            this.LblCategoryID.Size = new System.Drawing.Size(53, 12);
            this.LblCategoryID.TabIndex = 18;
            this.LblCategoryID.Text = "商品类别";
            // 
            // LblGoodID
            // 
            this.LblGoodID.AutoSize = true;
            this.LblGoodID.Location = new System.Drawing.Point(64, 45);
            this.LblGoodID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblGoodID.Name = "LblGoodID";
            this.LblGoodID.Size = new System.Drawing.Size(53, 12);
            this.LblGoodID.TabIndex = 17;
            this.LblGoodID.Text = "商品编号";
            // 
            // TxtPurchaseDate
            // 
            this.TxtPurchaseDate.Location = new System.Drawing.Point(121, 119);
            this.TxtPurchaseDate.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPurchaseDate.Name = "TxtPurchaseDate";
            this.TxtPurchaseDate.Size = new System.Drawing.Size(110, 21);
            this.TxtPurchaseDate.TabIndex = 16;
            // 
            // TxtProductionDate
            // 
            this.TxtProductionDate.Location = new System.Drawing.Point(121, 93);
            this.TxtProductionDate.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProductionDate.Name = "TxtProductionDate";
            this.TxtProductionDate.Size = new System.Drawing.Size(110, 21);
            this.TxtProductionDate.TabIndex = 15;
            // 
            // TxtCategoryID
            // 
            this.TxtCategoryID.Location = new System.Drawing.Point(121, 67);
            this.TxtCategoryID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCategoryID.Name = "TxtCategoryID";
            this.TxtCategoryID.Size = new System.Drawing.Size(110, 21);
            this.TxtCategoryID.TabIndex = 14;
            // 
            // TxtGoodID
            // 
            this.TxtGoodID.Location = new System.Drawing.Point(121, 41);
            this.TxtGoodID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtGoodID.Name = "TxtGoodID";
            this.TxtGoodID.Size = new System.Drawing.Size(110, 21);
            this.TxtGoodID.TabIndex = 13;
            // 
            // LblCost
            // 
            this.LblCost.AutoSize = true;
            this.LblCost.Location = new System.Drawing.Point(64, 149);
            this.LblCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(53, 12);
            this.LblCost.TabIndex = 26;
            this.LblCost.Text = "采购单价";
            // 
            // TxtCost
            // 
            this.TxtCost.Location = new System.Drawing.Point(121, 145);
            this.TxtCost.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(110, 21);
            this.TxtCost.TabIndex = 25;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(64, 175);
            this.LblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(29, 12);
            this.LblPrice.TabIndex = 28;
            this.LblPrice.Text = "售价";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(121, 171);
            this.TxtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(110, 21);
            this.TxtPrice.TabIndex = 27;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 300);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.LblCost);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.CmbIsValid);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.LblIsValid);
            this.Controls.Add(this.LblPurchaseID);
            this.Controls.Add(this.LblProductionID);
            this.Controls.Add(this.LblCategoryID);
            this.Controls.Add(this.LblGoodID);
            this.Controls.Add(this.TxtPurchaseDate);
            this.Controls.Add(this.TxtProductionDate);
            this.Controls.Add(this.TxtCategoryID);
            this.Controls.Add(this.TxtGoodID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form6";
            this.Text = "商品采购";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox CmbIsValid;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Label LblIsValid;
        private System.Windows.Forms.Label LblPurchaseID;
        private System.Windows.Forms.Label LblProductionID;
        private System.Windows.Forms.Label LblCategoryID;
        private System.Windows.Forms.Label LblGoodID;
        private System.Windows.Forms.TextBox TxtPurchaseDate;
        private System.Windows.Forms.TextBox TxtProductionDate;
        private System.Windows.Forms.TextBox TxtCategoryID;
        private System.Windows.Forms.TextBox TxtGoodID;
        private System.Windows.Forms.Label LblCost;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TxtPrice;
    }
}