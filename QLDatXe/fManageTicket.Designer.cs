
namespace QLDatXe
{
    partial class fManageTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManageTicket));
            this.dgvInCome = new System.Windows.Forms.DataGridView();
            this.colTableIdIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbMaVe_QL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInCome)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvInCome.Location = new System.Drawing.Point(35, 147);
            this.dgvInCome.Name = "dgvInCome";
            this.dgvInCome.ReadOnly = true;
            this.dgvInCome.RowHeadersWidth = 51;
            this.dgvInCome.RowTemplate.Height = 24;
            this.dgvInCome.Size = new System.Drawing.Size(1131, 561);
            this.dgvInCome.TabIndex = 8;
            // 
            // colTableIdIncome
            // 
            this.colTableIdIncome.HeaderText = "Mã Vé";
            this.colTableIdIncome.MinimumWidth = 6;
            this.colTableIdIncome.Name = "colTableIdIncome";
            this.colTableIdIncome.ReadOnly = true;
            this.colTableIdIncome.Width = 125;
            // 
            // colCheckIn
            // 
            this.colCheckIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCheckIn.HeaderText = "Mã Xe";
            this.colCheckIn.MinimumWidth = 6;
            this.colCheckIn.Name = "colCheckIn";
            this.colCheckIn.ReadOnly = true;
            // 
            // colCheckOut
            // 
            this.colCheckOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCheckOut.HeaderText = "Mã Chuyến Xe";
            this.colCheckOut.MinimumWidth = 6;
            this.colCheckOut.Name = "colCheckOut";
            this.colCheckOut.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Tên Trên Vé";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 125;
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "SĐT";
            this.colDiscount.MinimumWidth = 6;
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            this.colDiscount.Width = 125;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.HeaderText = "Giá";
            this.colTotalPrice.MinimumWidth = 6;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.ReadOnly = true;
            this.colTotalPrice.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(32, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 569);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.cmbMaVe_QL);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.btnOutput);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Location = new System.Drawing.Point(38, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1131, 67);
            this.panel3.TabIndex = 9;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(307, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(46, 61);
            this.panel4.TabIndex = 4;
            this.panel4.Click += new System.EventHandler(this.btnViewTickets_Click);
            // 
            // cmbMaVe_QL
            // 
            this.cmbMaVe_QL.FormattingEnabled = true;
            this.cmbMaVe_QL.Location = new System.Drawing.Point(83, 23);
            this.cmbMaVe_QL.Name = "cmbMaVe_QL";
            this.cmbMaVe_QL.Size = new System.Drawing.Size(218, 24);
            this.cmbMaVe_QL.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Vé :";
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
            this.btnOutput.Text = "In Hóa Đơn Đỏ";
            this.btnOutput.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(-252, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(35, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 30);
            this.panel1.TabIndex = 11;
            // 
            // fManageTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvInCome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "fManageTicket";
            this.Text = "fManageTicket";
            this.Load += new System.EventHandler(this.fManageTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInCome)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInCome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableIdIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbMaVe_QL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
    }
}