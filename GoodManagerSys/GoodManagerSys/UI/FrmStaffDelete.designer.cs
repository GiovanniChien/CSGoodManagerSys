namespace GoodManagerSys
{
    partial class FrmStaffDelete
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
            this.TxtStaffID = new System.Windows.Forms.TextBox();
            this.LblStaffID = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtStaffID
            // 
            this.TxtStaffID.Location = new System.Drawing.Point(88, 26);
            this.TxtStaffID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStaffID.Name = "TxtStaffID";
            this.TxtStaffID.Size = new System.Drawing.Size(123, 21);
            this.TxtStaffID.TabIndex = 4;
            // 
            // LblStaffID
            // 
            this.LblStaffID.AutoSize = true;
            this.LblStaffID.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblStaffID.Location = new System.Drawing.Point(20, 29);
            this.LblStaffID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStaffID.Name = "LblStaffID";
            this.LblStaffID.Size = new System.Drawing.Size(67, 15);
            this.LblStaffID.TabIndex = 3;
            this.LblStaffID.Text = "员工编号";
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBack.Location = new System.Drawing.Point(130, 79);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(80, 26);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "返回";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDelete.Location = new System.Drawing.Point(23, 79);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(80, 26);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "删除";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // FrmStaffDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 146);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TxtStaffID);
            this.Controls.Add(this.LblStaffID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmStaffDelete";
            this.Text = "员工删除";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtStaffID;
        private System.Windows.Forms.Label LblStaffID;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnDelete;
    }
}