
namespace ShopProject
{
    partial class frmMain
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
            this.ثبتاطلاعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتکاربرجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتمشتریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتکالاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتاطلاعاتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ثبتاطلاعاتToolStripMenuItem
            // 
            this.ثبتاطلاعاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتکاربرجدیدToolStripMenuItem,
            this.ثبتمشتریToolStripMenuItem,
            this.ثبتکالاToolStripMenuItem});
            this.ثبتاطلاعاتToolStripMenuItem.Name = "ثبتاطلاعاتToolStripMenuItem";
            this.ثبتاطلاعاتToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.ثبتاطلاعاتToolStripMenuItem.Text = "ثبت اطلاعات";
            this.ثبتاطلاعاتToolStripMenuItem.Click += new System.EventHandler(this.ثبتاطلاعاتToolStripMenuItem_Click);
            // 
            // ثبتکاربرجدیدToolStripMenuItem
            // 
            this.ثبتکاربرجدیدToolStripMenuItem.Name = "ثبتکاربرجدیدToolStripMenuItem";
            this.ثبتکاربرجدیدToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.ثبتکاربرجدیدToolStripMenuItem.Text = "ثبت کاربر جدید";
            this.ثبتکاربرجدیدToolStripMenuItem.Click += new System.EventHandler(this.ثبتکاربرجدیدToolStripMenuItem_Click);
            // 
            // ثبتمشتریToolStripMenuItem
            // 
            this.ثبتمشتریToolStripMenuItem.Name = "ثبتمشتریToolStripMenuItem";
            this.ثبتمشتریToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.ثبتمشتریToolStripMenuItem.Text = "ثبت مشتری";
            this.ثبتمشتریToolStripMenuItem.Click += new System.EventHandler(this.ثبتمشتریToolStripMenuItem_Click);
            // 
            // ثبتکالاToolStripMenuItem
            // 
            this.ثبتکالاToolStripMenuItem.Name = "ثبتکالاToolStripMenuItem";
            this.ثبتکالاToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.ثبتکالاToolStripMenuItem.Text = "ثبت کالا";
            this.ثبتکالاToolStripMenuItem.Click += new System.EventHandler(this.ثبتکالاToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShopProject.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(895, 491);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم اصلی";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ثبتاطلاعاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتکاربرجدیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتمشتریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتکالاToolStripMenuItem;
    }
}

