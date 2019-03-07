namespace GoodManagerSys.Frm.Category
{
    partial class FrmCategoryUpdate
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
            this.BtnCommit = new System.Windows.Forms.Button();
            this.TxtMaxStock = new System.Windows.Forms.TextBox();
            this.TxtMinStock = new System.Windows.Forms.TextBox();
            this.TxtExpirationDate = new System.Windows.Forms.TextBox();
            this.TxtColor = new System.Windows.Forms.TextBox();
            this.TxtUnit = new System.Windows.Forms.TextBox();
            this.TxtFirm = new System.Windows.Forms.TextBox();
            this.CmbParentCategoryName = new System.Windows.Forms.ComboBox();
            this.TxtCategoryName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbIsValid = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBack.Location = new System.Drawing.Point(197, 378);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(109, 32);
            this.BtnBack.TabIndex = 60;
            this.BtnBack.Text = "取消";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnCommit
            // 
            this.BtnCommit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCommit.Location = new System.Drawing.Point(59, 378);
            this.BtnCommit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCommit.Name = "BtnCommit";
            this.BtnCommit.Size = new System.Drawing.Size(111, 32);
            this.BtnCommit.TabIndex = 61;
            this.BtnCommit.Text = "提交修改";
            this.BtnCommit.UseVisualStyleBackColor = true;
            this.BtnCommit.Click += new System.EventHandler(this.BtnCommit_Click);
            // 
            // TxtMaxStock
            // 
            this.TxtMaxStock.Location = new System.Drawing.Point(166, 289);
            this.TxtMaxStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMaxStock.Name = "TxtMaxStock";
            this.TxtMaxStock.Size = new System.Drawing.Size(149, 25);
            this.TxtMaxStock.TabIndex = 58;
            // 
            // TxtMinStock
            // 
            this.TxtMinStock.Location = new System.Drawing.Point(166, 251);
            this.TxtMinStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMinStock.Name = "TxtMinStock";
            this.TxtMinStock.Size = new System.Drawing.Size(149, 25);
            this.TxtMinStock.TabIndex = 57;
            // 
            // TxtExpirationDate
            // 
            this.TxtExpirationDate.Location = new System.Drawing.Point(166, 214);
            this.TxtExpirationDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtExpirationDate.Name = "TxtExpirationDate";
            this.TxtExpirationDate.Size = new System.Drawing.Size(149, 25);
            this.TxtExpirationDate.TabIndex = 56;
            // 
            // TxtColor
            // 
            this.TxtColor.Location = new System.Drawing.Point(166, 174);
            this.TxtColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtColor.Name = "TxtColor";
            this.TxtColor.Size = new System.Drawing.Size(149, 25);
            this.TxtColor.TabIndex = 55;
            // 
            // TxtUnit
            // 
            this.TxtUnit.Location = new System.Drawing.Point(166, 139);
            this.TxtUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtUnit.Name = "TxtUnit";
            this.TxtUnit.Size = new System.Drawing.Size(149, 25);
            this.TxtUnit.TabIndex = 54;
            // 
            // TxtFirm
            // 
            this.TxtFirm.Location = new System.Drawing.Point(166, 102);
            this.TxtFirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFirm.Name = "TxtFirm";
            this.TxtFirm.Size = new System.Drawing.Size(149, 25);
            this.TxtFirm.TabIndex = 53;
            // 
            // CmbParentCategoryName
            // 
            this.CmbParentCategoryName.FormattingEnabled = true;
            this.CmbParentCategoryName.Items.AddRange(new object[] {
            "未定义",
            "饮料",
            "酒",
            "香烟",
            "糕饼",
            "糖果",
            "奶制品",
            "休闲食品"});
            this.CmbParentCategoryName.Location = new System.Drawing.Point(166, 68);
            this.CmbParentCategoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbParentCategoryName.Name = "CmbParentCategoryName";
            this.CmbParentCategoryName.Size = new System.Drawing.Size(149, 23);
            this.CmbParentCategoryName.TabIndex = 52;
            // 
            // TxtCategoryName
            // 
            this.TxtCategoryName.Location = new System.Drawing.Point(166, 30);
            this.TxtCategoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCategoryName.Name = "TxtCategoryName";
            this.TxtCategoryName.Size = new System.Drawing.Size(149, 25);
            this.TxtCategoryName.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(56, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 49;
            this.label8.Text = "保质期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(56, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 48;
            this.label7.Text = "最大库存";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(56, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "最小库存";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(56, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "厂商";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(56, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "颜色";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(56, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "单位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(56, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "商品类别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(56, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "商品名称";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 62;
            this.label9.Text = "有效状态";
            // 
            // CmbIsValid
            // 
            this.CmbIsValid.FormattingEnabled = true;
            this.CmbIsValid.Items.AddRange(new object[] {
            "有效",
            "已删除"});
            this.CmbIsValid.Location = new System.Drawing.Point(166, 328);
            this.CmbIsValid.Name = "CmbIsValid";
            this.CmbIsValid.Size = new System.Drawing.Size(149, 23);
            this.CmbIsValid.TabIndex = 63;
            // 
            // FrmCategoryUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 442);
            this.Controls.Add(this.CmbIsValid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnCommit);
            this.Controls.Add(this.TxtMaxStock);
            this.Controls.Add(this.TxtMinStock);
            this.Controls.Add(this.TxtExpirationDate);
            this.Controls.Add(this.TxtColor);
            this.Controls.Add(this.TxtUnit);
            this.Controls.Add(this.TxtFirm);
            this.Controls.Add(this.CmbParentCategoryName);
            this.Controls.Add(this.TxtCategoryName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCategoryUpdate";
            this.Text = "FrmCategoryUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnCommit;
        private System.Windows.Forms.TextBox TxtMaxStock;
        private System.Windows.Forms.TextBox TxtMinStock;
        private System.Windows.Forms.TextBox TxtExpirationDate;
        private System.Windows.Forms.TextBox TxtColor;
        private System.Windows.Forms.TextBox TxtUnit;
        private System.Windows.Forms.TextBox TxtFirm;
        private System.Windows.Forms.ComboBox CmbParentCategoryName;
        private System.Windows.Forms.TextBox TxtCategoryName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbIsValid;
    }
}