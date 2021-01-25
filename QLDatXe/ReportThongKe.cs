using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QLDatXe.Models;
namespace QLDatXe
{
    public partial class ReportThongKe : Form
    {
        public ReportThongKe()
        {
            InitializeComponent();
        }

        private void ReportThongKe_Load(object sender, EventArgs e)
        {
            DataAccessLayer _contextDB = new DataAccessLayer();
            List<ChuyenXe> listCX = _contextDB.ChuyenXes.ToList();
            List<ExportThongKe> listExport = new List<ExportThongKe>();
            foreach (ChuyenXe item in listCX)
            {
                ExportThongKe temp = new ExportThongKe();
                temp.idXe = item.MaXe;
                temp.idTuyen = item.MaCX;
                temp.timeout = item.Ngaydi;
                temp.SoVe =item.VeXes.Count();
                temp.GiaVX = item.GiaVe;
                temp.TongTien = (item.GiaVe * item.VeXes.Count());
                listExport.Add(temp);
            }
            this.rpThongKe.LocalReport.ReportPath = "rptThongKe.rdlc";
            var reportDataSource = new ReportDataSource("DataSet1", listExport);
            this.rpThongKe.LocalReport.DataSources.Clear();
            this.rpThongKe.LocalReport.DataSources.Add(reportDataSource);

            this.rpThongKe.RefreshReport();
        }
    }
}
