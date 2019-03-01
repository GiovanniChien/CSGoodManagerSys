namespace GoodManagerSys
{
    partial class FrmCategory
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
            this.DgvCategory = new System.Windows.Forms.DataGridView();
            this.ClnCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnParentCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnParentCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnFirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnMinStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnMaxStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnIsValid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCategory
            // 
            this.DgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnCategoryID,
            this.ClnCategoryName,
            this.ClnParentCategoryID,
            this.ClnParentCategoryName,
            this.ClnUnit,
            this.ClnColor,
            this.ClnFirm,
            this.ClnMinStock,
            this.ClnMaxStock,
            this.ClnExpirationDate,
            this.ClnIsValid});
            this.DgvCategory.Location = new System.Drawing.Point(22, 54);
            this.DgvCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvCategory.Name = "DgvCategory";
            this.DgvCategory.RowTemplate.Height = 27;
            this.DgvCategory.Size = new System.Drawing.Size(557, 253);
            this.DgvCategory.TabIndex = 10;
            // 
            // ClnCategoryID
            // 
            this.ClnCategoryID.HeaderText = "商品类别编号";
            this.ClnCategoryID.Name = "Column1";
            this.ClnCategoryID.ReadOnly = true;
            // 
            // ClnCategoryName
            // 
            this.ClnCategoryName.HeaderText = "商品名称";
            this.ClnCategoryName.Name = "Column2";
            this.ClnCategoryName.ReadOnly = true;
            // 
            // ClnParentCategoryID
            // 
            this.ClnParentCategoryID.HeaderText = "商品大类名";
            this.ClnParentCategoryID.Name = "Column3";
            this.ClnParentCategoryID.ReadOnly = true;
            // 
            // ClnParentCategoryName
            // 
            this.ClnParentCategoryName.HeaderText = "商品大类枚举";
            this.ClnParentCategoryName.Name = "Column4";
            this.ClnParentCategoryName.ReadOnly = true;
            // 
            // ClnUnit
            // 
            this.ClnUnit.HeaderText = "单位";
            this.ClnUnit.Name = "Column5";
            this.ClnUnit.ReadOnly = true;
            // 
            // ClnColor
            // 
            this.ClnColor.HeaderText = "颜色";
            this.ClnColor.Name = "Column6";
            this.ClnColor.ReadOnly = true;
            // 
            // ClnFirm
            // 
            this.ClnFirm.HeaderText = "厂商";
            this.ClnFirm.Name = "Column7";
            this.ClnFirm.ReadOnly = true;
            // 
            // ClnMinStock
            // 
            this.ClnMinStock.HeaderText = "最小库存";
            this.ClnMinStock.Name = "Column8";
            this.ClnMinStock.ReadOnly = true;
            // 
            // ClnMaxStock
            // 
            this.ClnMaxStock.HeaderText = "最大库存";
            this.ClnMaxStock.Name = "Column9";
            this.ClnMaxStock.ReadOnly = true;
            // 
            // ClnExpirationDate
            // 
            this.ClnExpirationDate.HeaderText = "保质期";
            this.ClnExpirationDate.Name = "Column10";
            this.ClnExpirationDate.ReadOnly = true;
            // 
            // ClnIsValid
            // 
            this.ClnIsValid.HeaderText = "有效状态";
            this.ClnIsValid.Name = "Column11";
            this.ClnIsValid.ReadOnly = true;
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.DgvCategory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCategory";
            this.Text = "商品类别";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnParentCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnParentCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnFirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnMinStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnMaxStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnIsValid;
    }
}