
namespace QLDatXe
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblForgotPass = new System.Windows.Forms.LinkLabel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.btnOrderNow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(522, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 176);
            this.panel1.TabIndex = 16;
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForgotPass.AutoSize = true;
            this.lblForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblForgotPass.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.lblForgotPass.Location = new System.Drawing.Point(536, 415);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(119, 17);
            this.lblForgotPass.TabIndex = 12;
            this.lblForgotPass.TabStop = true;
            this.lblForgotPass.Text = "Quên Mật Khẩu ?";
            this.lblForgotPass.VisitedLinkColor = System.Drawing.Color.PowderBlue;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignIn.Location = new System.Drawing.Point(532, 461);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(108, 53);
            this.btnSignIn.TabIndex = 11;
            this.btnSignIn.Text = "Đăng Nhập";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignUp.Location = new System.Drawing.Point(388, 461);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(108, 53);
            this.btnSignUp.TabIndex = 14;
            this.btnSignUp.Text = "Đăng KÝ";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(503, 375);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(246, 22);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.Location = new System.Drawing.Point(503, 329);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(246, 22);
            this.txtUserName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(397, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mật Khẩu :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(352, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên Đăng Nhập :";
            // 
            // lblLog
            // 
            this.lblLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLog.AutoSize = true;
            this.lblLog.BackColor = System.Drawing.Color.Transparent;
            this.lblLog.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLog.Location = new System.Drawing.Point(468, 245);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(262, 45);
            this.lblLog.TabIndex = 9;
            this.lblLog.Text = "ĐĂNG NHẬP";
            // 
            // btnOrderNow
            // 
            this.btnOrderNow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrderNow.Location = new System.Drawing.Point(671, 461);
            this.btnOrderNow.Name = "btnOrderNow";
            this.btnOrderNow.Size = new System.Drawing.Size(108, 53);
            this.btnOrderNow.TabIndex = 14;
            this.btnOrderNow.Text = "Đặt Vé Ngay";
            this.btnOrderNow.UseVisualStyleBackColor = true;
            this.btnOrderNow.Click += new System.EventHandler(this.btnOrderNow_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1165, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblForgotPass);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnOrderNow);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLog);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblForgotPass;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Button btnOrderNow;
    }
}