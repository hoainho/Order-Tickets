
namespace QLDatXe
{
    partial class ReportVeXe
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnPrintTicket = new ePOSOne.btnProduct.Button_WOC();
            this.ExportVeXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ExportVeXeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ExportVeXeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLDatXe.rptVeXe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(727, 483);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnPrintTicket
            // 
            this.btnPrintTicket.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintTicket.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrintTicket.ButtonColor = System.Drawing.Color.CornflowerBlue;
            this.btnPrintTicket.FlatAppearance.BorderSize = 0;
            this.btnPrintTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintTicket.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrintTicket.Location = new System.Drawing.Point(592, 499);
            this.btnPrintTicket.Name = "btnPrintTicket";
            this.btnPrintTicket.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnPrintTicket.OnHoverButtonColor = System.Drawing.Color.LightSkyBlue;
            this.btnPrintTicket.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrintTicket.Size = new System.Drawing.Size(128, 33);
            this.btnPrintTicket.TabIndex = 31;
            this.btnPrintTicket.Text = "In Vé";
            this.btnPrintTicket.TextColor = System.Drawing.Color.Black;
            this.btnPrintTicket.UseVisualStyleBackColor = false;
            // 
            // ExportVeXeBindingSource
            // 
            this.ExportVeXeBindingSource.DataSource = typeof(QLDatXe.ExportVeXe);
            // 
            // ReportVeXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 544);
            this.Controls.Add(this.btnPrintTicket);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportVeXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportVeXe";
            this.Load += new System.EventHandler(this.ReportVeXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExportVeXeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ExportVeXeBindingSource;
        private ePOSOne.btnProduct.Button_WOC btnPrintTicket;
    }
}