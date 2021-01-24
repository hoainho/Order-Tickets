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
    public partial class ReportVeXe : Form
    {
        private string id;
        public ReportVeXe()
        {
            InitializeComponent();
        }
        public ReportVeXe(string id )
        {
            InitializeComponent();
            this.id = id;
        }
        private void ReportVeXe_Load(object sender, EventArgs e)
        {
            DataAccessLayer _contextDB = new DataAccessLayer();
            List<VeXe> listCX = _contextDB.VeXes.Where(x => x.MaVe == id).ToList();
            List<ExportVeXe> listExport = new List<ExportVeXe>();
            foreach (VeXe item in listCX)
            {
                ExportVeXe temp = new ExportVeXe();
                temp.idVe = item.MaVe;
                temp.idChuyen = item.MaCX;
                temp.ten = item.TenKhach;
                temp.ngaydi = item.ChuyenXe.Ngaydi;
                temp.benden = item.ChuyenXe.BenXe.Ten;
                temp.bendi = item.ChuyenXe.BenXe1.Ten;
                temp.gia = item.ChuyenXe.GiaVe;
                listExport.Add(temp);
            }
            this.reportViewer1.LocalReport.ReportPath = "rptVeXe.rdlc";
            var reportDataSource = new ReportDataSource("DataSet1", listExport);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
