using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDatXe.Models;
namespace QLDatXe
{
    public partial class fStatic : Form
    {
        private TaiKhoan account;
        public fStatic()
        {
            InitializeComponent();
        }
        public fStatic(TaiKhoan acc)
        {
            InitializeComponent();
            this.account = acc;

        }

        private void fStatic_Load(object sender, EventArgs e)
        {
            ShowVe();
            ShowCmbMaXe_Static();
        }
        public void ShowCmbMaXe_Static()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<Xe> listXe = _contextDB.Xes.ToList();
                cmbMaXe_Static.DataSource = listXe;
                cmbMaXe_Static.DisplayMember = "MaXe";
                cmbMaXe_Static.ValueMember = "MaXe";
            }
        }
        public void ShowVe()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<ChuyenXe> listChuyenXe = _contextDB.ChuyenXes.ToList();
                dgvInCome.Rows.Clear();
                foreach (ChuyenXe item in listChuyenXe)
                {
                    //ChuyenXe maXe = _contextDB.ChuyenXes.FirstOrDefault(x => x.MaXe == item.MaXe);
                    //if(maXe != null)
                    //{
                        int index = dgvInCome.Rows.Add();
                        dgvInCome.Rows[index].Cells[0].Value = item.MaXe;
                        dgvInCome.Rows[index].Cells[1].Value = (item.BenXe.Ten + " - " + item.BenXe1.Ten).ToString();
                        dgvInCome.Rows[index].Cells[2].Value = item.Ngaydi;
                        dgvInCome.Rows[index].Cells[3].Value = item.VeXes.Count();
                        dgvInCome.Rows[index].Cells[4].Value = item.GiaVe;
                        dgvInCome.Rows[index].Cells[5].Value = (item.GiaVe * item.VeXes.Count());
                    //}
                }

            }

        }
        //Filter Doanh thu mỗi xe
        private void btnView_Click(object sender, EventArgs e)
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<ChuyenXe> listChuyenXe = _contextDB.ChuyenXes.Where(
                    x => x.MaXe == cmbMaXe_Static.SelectedValue.ToString()).ToList();
                dgvInCome.Rows.Clear();
                foreach (ChuyenXe item in listChuyenXe)
                {
                    //ChuyenXe maXe = _contextDB.ChuyenXes.FirstOrDefault(x => x.MaXe == item.MaXe);
                    //if(maXe != null)
                    //{
                    int index = dgvInCome.Rows.Add();
                    dgvInCome.Rows[index].Cells[0].Value = item.MaXe;
                    dgvInCome.Rows[index].Cells[1].Value = (item.BenXe.Ten + " - " + item.BenXe1.Ten).ToString();
                    dgvInCome.Rows[index].Cells[2].Value = item.Ngaydi;
                    dgvInCome.Rows[index].Cells[3].Value = item.VeXes.Count();
                    dgvInCome.Rows[index].Cells[4].Value = item.GiaVe;
                    dgvInCome.Rows[index].Cells[5].Value = (item.GiaVe * item.VeXes.Count());
                    //}
                }

            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            ReportThongKe f = new ReportThongKe();
            f.ShowDialog();
        }
    }
}
