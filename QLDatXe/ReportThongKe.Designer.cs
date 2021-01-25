
namespace QLDatXe
{
    partial class ReportThongKe
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
            this.btnPrintTicket = new ePOSOne.btnProduct.Button_WOC();
            this.rpThongKe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnPrintTicket
            // 
            this.btnPrintTicket.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintTicket.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrintTicket.ButtonColor = System.Drawing.Color.CornflowerBlue;
            this.btnPrintTicket.FlatAppearance.BorderSize = 0;
            this.btnPrintTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintTicket.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrintTicket.Location = new System.Drawing.Point(593, 505);
            this.btnPrintTicket.Name = "btnPrintTicket";
            this.btnPrintTicket.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnPrintTicket.OnHoverButtonColor = System.Drawing.Color.LightSkyBlue;
            this.btnPrintTicket.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrintTicket.Size = new System.Drawing.Size(128, 33);
            this.btnPrintTicket.TabIndex = 33;
            this.btnPrintTicket.Text = "In Thống Kê";
            this.btnPrintTicket.TextColor = System.Drawing.Color.Black;
            this.btnPrintTicket.UseVisualStyleBackColor = false;
            // 
            // rpThongKe
            // 
            this.rpThongKe.LocalReport.ReportEmbeddedResource = "QLDatXe.rptThongKe.rdlc";
            this.rpThongKe.Location = new System.Drawing.Point(3, 6);
            this.rpThongKe.Name = "rpThongKe";
            this.rpThongKe.ServerReport.BearerToken = null;
            this.rpThongKe.Size = new System.Drawing.Size(727, 483);
            this.rpThongKe.TabIndex = 32;
            // 
            // ReportThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 544);
            this.Controls.Add(this.btnPrintTicket);
            this.Controls.Add(this.rpThongKe);
            this.Name = "ReportThongKe";
            this.Text = "ReportThongKe";
            this.Load += new System.EventHandler(this.ReportThongKe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC btnPrintTicket;
        private Microsoft.Reporting.WinForms.ReportViewer rpThongKe;
    }
}