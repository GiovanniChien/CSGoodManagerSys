namespace GoodManagerSys.Frm.Warehouse {
    partial class FrmGoodInsert {
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
            this.CmbIsValid = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.LblIsValid = new System.Windows.Forms.Label();
            this.LblProductionID = new System.Windows.Forms.Label();
            this.LblCategoryID = new System.Windows.Forms.Label();
            this.LblCost = new System.Windows.Forms.Label();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.DtpProductionID = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCount = new System.Windows.Forms.TextBox();
            this.CmbCategoryID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CmbIsValid
            // 
            this.CmbIsValid.FormattingEnabled = true;
            this.CmbIsValid.Items.AddRange(new object[] {
            "未上架",
            "未出售"});
            this.CmbIsValid.Location = new System.Drawing.Point(120, 189);
            this.CmbIsValid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbIsValid.Name = "CmbIsValid";
            this.CmbIsValid.Size = new System.Drawing.Size(145, 23);
            this.CmbIsValid.TabIndex = 24;
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBack.Location = new System.Drawing.Point(163, 245);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(109, 32);
            this.BtnBack.TabIndex = 22;
            this.BtnBack.Text = "返回";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnInsert.Location = new System.Drawing.Point(47, 245);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(111, 32);
            this.BtnInsert.TabIndex = 23;
            this.BtnInsert.Text = "添加";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // LblIsValid
            // 
            this.LblIsValid.AutoSize = true;
            this.LblIsValid.Location = new System.Drawing.Point(44, 194);
            this.LblIsValid.Name = "LblIsValid";
            this.LblIsValid.Size = new System.Drawing.Size(67, 15);
            this.LblIsValid.TabIndex = 21;
            this.LblIsValid.Text = "有效状态";
            // 
            // LblProductionID
            // 
            this.LblProductionID.AutoSize = true;
            this.LblProductionID.Location = new System.Drawing.Point(44, 59);
            this.LblProductionID.Name = "LblProductionID";
            this.LblProductionID.Size = new System.Drawing.Size(67, 15);
            this.LblProductionID.TabIndex = 19;
            this.LblProductionID.Text = "生产日期";
            // 
            // LblCategoryID
            // 
            this.LblCategoryID.AutoSize = true;
            this.LblCategoryID.Location = new System.Drawing.Point(44, 25);
            this.LblCategoryID.Name = "LblCategoryID";
            this.LblCategoryID.Size = new System.Drawing.Size(67, 15);
            this.LblCategoryID.TabIndex = 18;
            this.LblCategoryID.Text = "商品类别";
            // 
            // LblCost
            // 
            this.LblCost.AutoSize = true;
            this.LblCost.Location = new System.Drawing.Point(44, 92);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(67, 15);
            this.LblCost.TabIndex = 26;
            this.LblCost.Text = "采购单价";
            // 
            // TxtCost
            // 
            this.TxtCost.Location = new System.Drawing.Point(120, 88);
            this.TxtCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(145, 25);
            this.TxtCost.TabIndex = 25;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(44, 126);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(37, 15);
            this.LblPrice.TabIndex = 28;
            this.LblPrice.Text = "售价";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(120, 121);
            this.TxtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(145, 25);
            this.TxtPrice.TabIndex = 27;
            // 
            // DtpProductionID
            // 
            this.DtpProductionID.CustomFormat = "yyyy-MM-dd";
            this.DtpProductionID.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpProductionID.Location = new System.Drawing.Point(120, 54);
            this.DtpProductionID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpProductionID.Name = "DtpProductionID";
            this.DtpProductionID.Size = new System.Drawing.Size(145, 25);
            this.DtpProductionID.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "数量";
            // 
            // TxtCount
            // 
            this.TxtCount.Location = new System.Drawing.Point(120, 155);
            this.TxtCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCount.Name = "TxtCount";
            this.TxtCount.Size = new System.Drawing.Size(145, 25);
            this.TxtCount.TabIndex = 30;
            // 
            // CmbCategoryID
            // 
            this.CmbCategoryID.FormattingEnabled = true;
            this.CmbCategoryID.Location = new System.Drawing.Point(120, 21);
            this.CmbCategoryID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbCategoryID.Name = "CmbCategoryID";
            this.CmbCategoryID.Size = new System.Drawing.Size(145, 23);
            this.CmbCategoryID.TabIndex = 32;
            // 
            // FrmGoodInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 306);
            this.Controls.Add(this.CmbCategoryID);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.Label LblCost;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.DateTimePicker DtpProductionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCount;
        private System.Windows.Forms.ComboBox CmbCategoryID;
    }
}