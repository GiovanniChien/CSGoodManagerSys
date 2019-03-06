namespace GoodManagerSys.Frm.Main {
    partial class FrmMainPurchase {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.库存管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.库存管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 库存管理ToolStripMenuItem
            // 
            this.库存管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入库ToolStripMenuItem,
            this.库存查询ToolStripMenuItem});
            this.库存管理ToolStripMenuItem.Name = "库存管理ToolStripMenuItem";
            this.库存管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.库存管理ToolStripMenuItem.Text = "库存管理";
            // 
            // 入库ToolStripMenuItem
            // 
            this.入库ToolStripMenuItem.Name = "入库ToolStripMenuItem";
            this.入库ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.入库ToolStripMenuItem.Text = "入库";
            this.入库ToolStripMenuItem.Click += new System.EventHandler(this.入库ToolStripMenuItem_Click);
            // 
            // 库存查询ToolStripMenuItem
            // 
            this.库存查询ToolStripMenuItem.Name = "库存查询ToolStripMenuItem";
            this.库存查询ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.库存查询ToolStripMenuItem.Text = "库存查询";
            this.库存查询ToolStripMenuItem.Click += new System.EventHandler(this.库存查询ToolStripMenuItem_Click);
            // 
            // FrmMainPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GoodManagerSys.Properties.Resources.Interface;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 321);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMainPurchase";
            this.Text = "FrmMainPurchase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 库存管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存查询ToolStripMenuItem;
    }
}