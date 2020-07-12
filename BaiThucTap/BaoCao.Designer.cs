namespace BaiThucTap
{
    partial class BaoCao
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thốngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêDoanhThuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(180, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêDoanhThuToolStripMenuItem
            // 
            this.thốngKêDoanhThuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theoNgàyToolStripMenuItem,
            this.theoThángToolStripMenuItem});
            this.thốngKêDoanhThuToolStripMenuItem.Name = "thốngKêDoanhThuToolStripMenuItem";
            this.thốngKêDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.thốngKêDoanhThuToolStripMenuItem.Text = "Thống Kê Doanh Thu";
            // 
            // theoNgàyToolStripMenuItem
            // 
            this.theoNgàyToolStripMenuItem.Name = "theoNgàyToolStripMenuItem";
            this.theoNgàyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.theoNgàyToolStripMenuItem.Text = "Theo Ngày";
            this.theoNgàyToolStripMenuItem.Click += new System.EventHandler(this.theoNgàyToolStripMenuItem_Click);
            // 
            // theoThángToolStripMenuItem
            // 
            this.theoThángToolStripMenuItem.Name = "theoThángToolStripMenuItem";
            this.theoThángToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.theoThángToolStripMenuItem.Text = "Theo Tháng";
            this.theoThángToolStripMenuItem.Click += new System.EventHandler(this.theoThángToolStripMenuItem_Click);
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 149);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoThángToolStripMenuItem;
    }
}