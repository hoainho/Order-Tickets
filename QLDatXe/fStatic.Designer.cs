
namespace QLDatXe
{
    partial class fStatic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStatic));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvInCome = new System.Windows.Forms.DataGridView();
            this.colTableIdIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbMaXe_Static = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInCome)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(29, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 418);
            this.panel2.TabIndex = 4;
            // 
            // dgvInCome
            // 
            this.dgvInCome.AllowUserToAddRows = false;
            this.dgvInCome.AllowUserToDeleteRows = false;
            this.dgvInCome.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvInCome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInCome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTableIdIncome,
            this.colCheckIn,
            this.colCheckOut,
            this.colStatus,
            this.colDiscount,
            this.colTotalPrice});
            this.dgvInCome.Location = new System.Drawing.Point(32, 123);
            this.dgvInCome.Name = "dgvInCome";
            this.dgvInCome.ReadOnly = true;
            this.dgvInCome.RowHeadersWidth = 51;
            this.dgvInCome.RowTemplate.Height = 24;
            this.dgvInCome.Size = new System.Drawing.Size(1131, 582);
            this.dgvInCome.TabIndex = 0;
            // 
            // colTableIdIncome
            // 
            this.colTableIdIncome.HeaderText = "Mã Xe";
            this.colTableIdIncome.MinimumWidth = 6;
            this.colTableIdIncome.Name = "colTableIdIncome";
            this.colTableIdIncome.ReadOnly = true;
            this.colTableIdIncome.Width = 125;
            // 
            // colCheckIn
            // 
            this.colCheckIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCheckIn.HeaderText = "Tuyến Đi";
            this.colCheckIn.MinimumWidth = 6;
            this.colCheckIn.Name = "colCheckIn";
            this.colCheckIn.ReadOnly = true;
            // 
            // colCheckOut
            // 
            this.colCheckOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCheckOut.HeaderText = "Ngày Đi";
            this.colCheckOut.MinimumWidth = 6;
            this.colCheckOut.Name = "colCheckOut";
            this.colCheckOut.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Số Vé";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 125;
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "Giá 1 Vé";
            this.colDiscount.MinimumWidth = 6;
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            this.colDiscount.Width = 125;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.HeaderText = "Tổng Cộng";
            this.colTotalPrice.MinimumWidth = 6;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.ReadOnly = true;
            this.colTotalPrice.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.cmbMaXe_Static);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnOutput);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(35, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 67);
            this.panel1.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(501, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(177, 58);
            this.panel8.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(307, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(46, 61);
            this.panel3.TabIndex = 4;
            this.panel3.Click += new System.EventHandler(this.btnView_Click);
            // 
            // cmbMaXe_Static
            // 
            this.cmbMaXe_Static.FormattingEnabled = true;
            this.cmbMaXe_Static.Location = new System.Drawing.Point(83, 23);
            this.cmbMaXe_Static.Name = "cmbMaXe_Static";
            this.cmbMaXe_Static.Size = new System.Drawing.Size(218, 24);
            this.cmbMaXe_Static.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Xe";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPrint.Location = new System.Drawing.Point(974, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(135, 61);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Xuất Excel";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnOutput
            // 
            this.btnOutput.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOutput.Location = new System.Drawing.Point(809, 3);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(135, 61);
            this.btnOutput.TabIndex = 1;
            this.btnOutput.Text = "In Thống Kê";
            this.btnOutput.UseVisualStyleBackColor = false;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(-252, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(24, 737);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(1169, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(24, 737);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(26, 711);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1143, 28);
            this.panel6.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(25, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1144, 28);
            this.panel7.TabIndex = 6;
            // 
            // fStatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 756);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvInCome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fStatic";
            this.Text = "fStatic";
            this.Load += new System.EventHandler(this.fStatic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInCome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvInCome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableIdIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPrice;
        private System.Windows.Forms.ComboBox cmbMaXe_Static;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}