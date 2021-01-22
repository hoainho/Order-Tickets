
namespace QLDatXe
{
    partial class fHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTour = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsManageTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsStatis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsHome,
            this.mnsSetting,
            this.mnsTour,
            this.mnsManageTickets,
            this.mnsStatis,
            this.mnsHelp,
            this.mnsAccount});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsHome
            // 
            this.mnsHome.Image = ((System.Drawing.Image)(resources.GetObject("mnsHome.Image")));
            this.mnsHome.Name = "mnsHome";
            this.mnsHome.Size = new System.Drawing.Size(113, 24);
            this.mnsHome.Text = "Trang Chủ ";
            this.mnsHome.Click += new System.EventHandler(this.mnsHome_Click);
            // 
            // mnsSetting
            // 
            this.mnsSetting.Image = ((System.Drawing.Image)(resources.GetObject("mnsSetting.Image")));
            this.mnsSetting.Name = "mnsSetting";
            this.mnsSetting.Size = new System.Drawing.Size(108, 24);
            this.mnsSetting.Text = "Hệ Thống";
            // 
            // mnsTour
            // 
            this.mnsTour.Image = ((System.Drawing.Image)(resources.GetObject("mnsTour.Image")));
            this.mnsTour.Name = "mnsTour";
            this.mnsTour.Size = new System.Drawing.Size(112, 24);
            this.mnsTour.Text = "Chuyến Xe";
            // 
            // mnsManageTickets
            // 
            this.mnsManageTickets.Image = ((System.Drawing.Image)(resources.GetObject("mnsManageTickets.Image")));
            this.mnsManageTickets.Name = "mnsManageTickets";
            this.mnsManageTickets.Size = new System.Drawing.Size(113, 24);
            this.mnsManageTickets.Text = "Quản Lí Vé";
            // 
            // mnsStatis
            // 
            this.mnsStatis.Image = ((System.Drawing.Image)(resources.GetObject("mnsStatis.Image")));
            this.mnsStatis.Name = "mnsStatis";
            this.mnsStatis.Size = new System.Drawing.Size(106, 24);
            this.mnsStatis.Text = "Thống Kê";
            // 
            // mnsHelp
            // 
            this.mnsHelp.Image = ((System.Drawing.Image)(resources.GetObject("mnsHelp.Image")));
            this.mnsHelp.Name = "mnsHelp";
            this.mnsHelp.Size = new System.Drawing.Size(88, 24);
            this.mnsHelp.Text = "Hỗ Trợ";
            // 
            // mnsAccount
            // 
            this.mnsAccount.Image = ((System.Drawing.Image)(resources.GetObject("mnsAccount.Image")));
            this.mnsAccount.Name = "mnsAccount";
            this.mnsAccount.Size = new System.Drawing.Size(107, 24);
            this.mnsAccount.Text = "Tài Khoản";
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1238, 724);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà Xe  7 0 7";
            this.Load += new System.EventHandler(this.fHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsSetting;
        private System.Windows.Forms.ToolStripMenuItem mnsTour;
        private System.Windows.Forms.ToolStripMenuItem mnsManageTickets;
        private System.Windows.Forms.ToolStripMenuItem mnsStatis;
        private System.Windows.Forms.ToolStripMenuItem mnsHelp;
        private System.Windows.Forms.ToolStripMenuItem mnsHome;
        private System.Windows.Forms.ToolStripMenuItem mnsAccount;
    }
}