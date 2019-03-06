namespace GoodManagerSys.Frm.Main {
    partial class FrmMainSale {
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
            this.销售管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售单查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.销售管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 销售管理ToolStripMenuItem
            // 
            this.销售管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.销售商品ToolStripMenuItem,
            this.销售单查询ToolStripMenuItem});
            this.销售管理ToolStripMenuItem.Name = "销售管理ToolStripMenuItem";
            this.销售管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.销售管理ToolStripMenuItem.Text = "销售管理";
            // 
            // 销售商品ToolStripMenuItem
            // 
            this.销售商品ToolStripMenuItem.Name = "销售商品ToolStripMenuItem";
            this.销售商品ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.销售商品ToolStripMenuItem.Text = "销售商品";
            this.销售商品ToolStripMenuItem.Click += new System.EventHandler(this.销售商品ToolStripMenuItem_Click);
            // 
            // 销售单查询ToolStripMenuItem
            // 
            this.销售单查询ToolStripMenuItem.Name = "销售单查询ToolStripMenuItem";
            this.销售单查询ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.销售单查询ToolStripMenuItem.Text = "销售单查询";
            this.销售单查询ToolStripMenuItem.Click += new System.EventHandler(this.销售单查询ToolStripMenuItem_Click);
            // 
            // FrmMainSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GoodManagerSys.Properties.Resources.Interface;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 326);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMainSale";
            this.Text = "FrmMainSale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 销售管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售商品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售单查询ToolStripMenuItem;
    }
}