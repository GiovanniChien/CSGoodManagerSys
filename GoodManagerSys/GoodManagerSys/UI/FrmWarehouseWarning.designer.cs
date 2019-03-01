namespace GoodManagerSys
{
    partial class FrmWarehouseWarning
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
            this.DgvWarehouseWarning = new System.Windows.Forms.DataGridView();
            this.ClnCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvWarehouseWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvWarehouseWarning
            // 
            this.DgvWarehouseWarning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvWarehouseWarning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnCategoryID,
            this.ClnCount});
            this.DgvWarehouseWarning.Location = new System.Drawing.Point(60, 62);
            this.DgvWarehouseWarning.Margin = new System.Windows.Forms.Padding(2);
            this.DgvWarehouseWarning.Name = "DgvWarehouseWarning";
            this.DgvWarehouseWarning.RowTemplate.Height = 27;
            this.DgvWarehouseWarning.Size = new System.Drawing.Size(451, 120);
            this.DgvWarehouseWarning.TabIndex = 0;
            // 
            // ClnCategoryID
            // 
            this.ClnCategoryID.HeaderText = "商品编号";
            this.ClnCategoryID.Name = "ClnCategoryID";
            this.ClnCategoryID.ReadOnly = true;
            // 
            // ClnCount
            // 
            this.ClnCount.HeaderText = "缺货数量";
            this.ClnCount.Name = "ClnCount";
            this.ClnCount.ReadOnly = true;
            // 
            // FrmWarehouseWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 257);
            this.Controls.Add(this.DgvWarehouseWarning);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmWarehouseWarning";
            this.Text = "库存预警";
            ((System.ComponentModel.ISupportInitialize)(this.DgvWarehouseWarning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvWarehouseWarning;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCount;
    }
}