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
    public partial class fManageTicket : Form
    {
        private TaiKhoan account;
        public fManageTicket()
        {
            InitializeComponent();
        }
        public fManageTicket(TaiKhoan acc)
        {
            InitializeComponent();
            this.account = acc;
        }
        private void fManageTicket_Load(object sender, EventArgs e)
        {
            ShowVe(); ShowCmbMaXe_Static();
        }
        public void ShowCmbMaXe_Static()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<VeXe> listXe = _contextDB.VeXes.Where(x => x.userName == this.account.userName).ToList();
                cmbMaVe_QL.DataSource = listXe;
                cmbMaVe_QL.DisplayMember = "MaVe";
                cmbMaVe_QL.ValueMember = "MaVe";
            }
        }
        public void ShowVe()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<VeXe> listVX = _contextDB.VeXes.Where((x => x.userName == this.account.userName)).ToList();
                dgvInCome.Rows.Clear();
                foreach (VeXe item in listVX)
                {
                    int index = dgvInCome.Rows.Add();
                    dgvInCome.Rows[index].Cells[0].Value = item.MaVe;
                    dgvInCome.Rows[index].Cells[1].Value = item.MaXe;
                    dgvInCome.Rows[index].Cells[2].Value = (item.ChuyenXe.BenXe.Ten + " - " + item.ChuyenXe.BenXe1.Ten).ToString();
                    dgvInCome.Rows[index].Cells[3].Value = item.TenKhach;
                    dgvInCome.Rows[index].Cells[4].Value = item.sdt;
                    dgvInCome.Rows[index].Cells[5].Value = item.ChuyenXe.GiaVe;
                }

            }

        }
        //Filter Doanh thu mỗi xe
        private void btnViewTickets_Click(object sender, EventArgs e)
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<VeXe> listVX = _contextDB.VeXes.Where(
                    x => x.MaVe == cmbMaVe_QL.SelectedValue.ToString()).ToList();
                dgvInCome.Rows.Clear();
                foreach (VeXe item in listVX)
                {
                    int index = dgvInCome.Rows.Add();
                    dgvInCome.Rows[index].Cells[0].Value = item.MaVe;
                    dgvInCome.Rows[index].Cells[1].Value = item.MaXe;
                    dgvInCome.Rows[index].Cells[2].Value = (item.ChuyenXe.BenXe.Ten + " - " + item.ChuyenXe.BenXe1.Ten).ToString();
                    dgvInCome.Rows[index].Cells[3].Value = item.TenKhach;
                    dgvInCome.Rows[index].Cells[4].Value = item.sdt;
                    dgvInCome.Rows[index].Cells[5].Value = item.ChuyenXe.GiaVe;
                }

            }
        }
    }
}
