using QLDatXe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDatXe
{
    public partial class fTicketRoom : Form
    {
        private int idXe;
        private int idChuyen;

        public fTicketRoom()
        {
            InitializeComponent();
        }
        //Load thông tin 
        private void fTicketRoom_Load(object sender, EventArgs e)
        {
            //Show ComboBox
            ShowCmbLoaiXe();
            //Show datagridview
            ShowChuyenXe();
            ShowTongChuyenXe();
            ShowVe();
            ShowXe();
            ShowBenXe();
        }
        // Load data cho các combobox 
        public void ShowCmbLoaiXe()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<LoaiXe> listLoaiXe = _contextDB.LoaiXes.ToList();
                cmbLoaiXe.DataSource = listLoaiXe;
                cmbLoaiXe.DisplayMember = "TenLoai";
                cmbLoaiXe.ValueMember = "Loai";
            }
        }

        // Show Thông tin ra datagridview
        public void ShowChuyenXe()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<ChuyenXe> listChuyenXe = _contextDB.ChuyenXes.ToList();
                dgvLichChay.Rows.Clear();
                foreach (ChuyenXe item in listChuyenXe)
                {
                    int index = dgvLichChay.Rows.Add();
                    dgvLichChay.Rows[index].Cells[0].Value = (item.BenXe.Ten+" - "+item.BenXe1.Ten).ToString();
                    dgvLichChay.Rows[index].Cells[1].Value = item.Ngaydi;
                    dgvLichChay.Rows[index].Cells[2].Value = item.Xe.LoaiXe.TenLoai;
                    dgvLichChay.Rows[index].Cells[3].Value = item.BenXe.DiaChi;
                    dgvLichChay.Rows[index].Cells[4].Value = item.BenXe1.DiaChi;
                }
            }

        }
        public void ShowTongChuyenXe()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<ChuyenXe> listTongChuyenXe = _contextDB.ChuyenXes.ToList();
                dgvLichTong.Rows.Clear();
                foreach (ChuyenXe item in listTongChuyenXe)
                {
                    int index = dgvLichTong.Rows.Add();
                    dgvLichTong.Rows[index].Cells[0].Value = (item.BenXe.Ten + " - " + item.BenXe1.Ten).ToString();
                    dgvLichTong.Rows[index].Cells[1].Value = item.Ngaydi;
                    dgvLichTong.Rows[index].Cells[2].Value = item.BenXe.DiaChi;
                    dgvLichTong.Rows[index].Cells[3].Value = item.BenXe1.DiaChi;
                    dgvLichTong.Rows[index].Cells[4].Value = item.Xe.SoGhe;
                }
            }

        }
        public void ShowVe()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<HoaDon> listVeXe = _contextDB.HoaDons.ToList();
                dgvVeXe.Rows.Clear();
                foreach (HoaDon item in listVeXe)
                {
                    int index = dgvVeXe.Rows.Add();
                    dgvVeXe.Rows[index].Cells[0].Value = item.VeXe.MaVe;
                    dgvVeXe.Rows[index].Cells[1].Value = item.VeXe.MaCX;
                    dgvVeXe.Rows[index].Cells[2].Value = item.TaiKhoan.displayName;
                    dgvVeXe.Rows[index].Cells[3].Value = item.TaiKhoan.numberPhone;
                    dgvVeXe.Rows[index].Cells[4].Value = item.VeXe.GiaVe;
                }
            }

        }
        public void ShowXe()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<Xe> listXe = _contextDB.Xes.ToList();
                dgvXe.Rows.Clear();
                foreach (Xe item in listXe)
                {
                    int index = dgvXe.Rows.Add();
                    dgvXe.Rows[index].Cells[0].Value = item.MaXe;
                    dgvXe.Rows[index].Cells[1].Value = item.LoaiXe.TenLoai;
                    dgvXe.Rows[index].Cells[2].Value = item.SoGhe;
                }
            }
        }
        public void ShowBenXe()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<BenXe> listBenXe = _contextDB.BenXes.ToList();
                dgvBenXe.Rows.Clear();
                foreach (BenXe item in listBenXe)
                {
                    int index = dgvBenXe.Rows.Add();
                    dgvBenXe.Rows[index].Cells[0].Value = item.MaBX;
                    dgvBenXe.Rows[index].Cells[1].Value = item.Ten;
                    dgvBenXe.Rows[index].Cells[2].Value = item.DiaChi;
                }
            }

        }
        // Nhắc nhở khi nhập thông tin
        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (temp.Text == "")
            {
                NotificationError.SetError(temp, "Vui lòng không để trống !");
            }
            else
            {
                NotificationError.SetError(temp, "");

            }
        }

        // CellClick dgv
        private void dgvBenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                this.idXe = int.Parse(dgvBenXe.Rows[index].Cells[0].Value.ToString());
                txtTenBX.Text = dgvBenXe.Rows[index].Cells[1].Value.ToString();
                txtDiaChiBX.Text = dgvBenXe.Rows[index].Cells[2].Value.ToString();
            }
            else
            {
                return;
            }
        }
        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                this.idXe = int.Parse(dgvXe.Rows[index].Cells[0].Value.ToString());
                cmbLoaiXe.Text = dgvXe.Rows[index].Cells[1].Value.ToString();
                txtSoGhe.Text = dgvXe.Rows[index].Cells[2].Value.ToString();
            }
            else
            {
                return;
            }
        }
        private void dgvLichTong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                this.idChuyen = int.Parse(dgvLichTong.Rows[index].Cells[0].Value.ToString());
                cmbLoaiXe.Text = dgvXe.Rows[index].Cells[1].Value.ToString();
                txtSoGhe.Text = dgvXe.Rows[index].Cells[2].Value.ToString();
            }
            else
            {
                return;
            }
        }

        // Thêm thông tin vào database và show ra dgv
        private void btnAddChuyen_Click(object sender, EventArgs e)
        {
            if (txtMaChuyen.Text == "" || txtBenXeDi.Text == "" || txtBenXeDen.Text == "" || txtSoGhe.Text == "" || txtThoiGian.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var _dbContext = new DataAccessLayer())
                {
                    ChuyenXe chuyenXe = new ChuyenXe();
                    chuyenXe.MaCX = int.Parse(txtMaChuyen.Text);
                    chuyenXe.MaBXDi = int.Parse(txtBenXeDi.Text);
                    chuyenXe.MaBXDen = int.Parse(txtBenXeDen.Text);
                    chuyenXe.Ngaydi = DateTime.Parse(txtThoiGian.Text);
                    _dbContext.ChuyenXes.Add(chuyenXe);
                    _dbContext.SaveChanges();
                }
                MessageBox.Show("Thêm Chuyến Mới Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChuyen.Text = "";
                txtBenXeDi.Text = "";
                txtBenXeDen.Text = "";
                txtThoiGian.Text = "";
            }
        }
        private void btnThemXe_Click(object sender, EventArgs e)
        {
            if (txtMaXe.Text == "" || txtLoaiXe.Text == "" || txtSoGhe.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var _dbContext = new DataAccessLayer())
                {
                    Xe xe = new Xe();
                    xe.MaXe = int.Parse(txtMaXe.Text);
                    xe.Loai = int.Parse(txtLoaiXe.Text);
                    xe.SoGhe = int.Parse(txtSoGhe.Text);
                    _dbContext.Xes.Add(xe);
                    _dbContext.SaveChanges();
                }
                MessageBox.Show("Thêm Xe Mới Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaXe.Text = "";
                txtLoaiXe.Text = "";
                txtSoGhe.Text = "";
            }
        }
        private void btnAddBX_Click(object sender, EventArgs e)
        {
            if (lblTenBX.Text == "" || lblDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var _dbContext = new DataAccessLayer())
                {
                    BenXe benXe = new BenXe();
                    benXe.Ten = txtTenBX.Text;
                    benXe.DiaChi = txtDiaChiBX.Text;
                    _dbContext.BenXes.Add(benXe);
                    _dbContext.SaveChanges();
                }
                ShowBenXe();
                MessageBox.Show("Thêm Bến Xe Mới Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenBX.Text = "";
                txtDiaChiBX.Text = "";
            }
        }

        // Sửa Thông tin trong database và show ra dgv
        private void btnSuaBX_Click(object sender, EventArgs e)
        {
            using (var _contextDB = new DataAccessLayer())
            {
                BenXe dbBenXe = _contextDB.BenXes.FirstOrDefault(x => x.MaBX == this.idXe);
                if (dbBenXe != null)
                {
                    dbBenXe.Ten = txtTenBX.Text;
                    dbBenXe.DiaChi = txtDiaChiBX.Text;
                }
                _contextDB.SaveChanges();
                ShowBenXe();
                MessageBox.Show("Sửa Bến Xe" + dbBenXe.Ten + " Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenBX.Text = "";
                txtDiaChiBX.Text = "";
            }
        }

        private void btnSuaXe_Click(object sender, EventArgs e)
        {
            using (var _contextDB = new DataAccessLayer())
            {
                Xe dbXe = _contextDB.Xes.FirstOrDefault(x => x.MaXe == this.idXe);
                if (dbXe != null)
                {
                    dbXe.Loai = int.Parse(cmbLoaiXe.SelectedValue.ToString());
                    dbXe.Ghe. = txtDiaChiBX.Text;
                }
                _contextDB.SaveChanges();
                ShowBenXe();
                MessageBox.Show("Sửa Bến Xe" + dbBenXe.Ten + " Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenBX.Text = "";
                txtDiaChiBX.Text = "";
            }
        }

        private void btnSuaBX_Click(object sender, EventArgs e)
        {
            using (var _contextDB = new DataAccessLayer())
            {
                BenXe dbBenXe = _contextDB.BenXes.FirstOrDefault(x => x.MaBX == this.idXe);
                if (dbBenXe != null)
                {
                    dbBenXe.Ten = txtTenBX.Text;
                    dbBenXe.DiaChi = txtDiaChiBX.Text;
                }
                _contextDB.SaveChanges();
                ShowBenXe();
                MessageBox.Show("Sửa Bến Xe" + dbBenXe.Ten + " Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenBX.Text = "";
                txtDiaChiBX.Text = "";
            }
        }


        // Xóa Thông tin trong database và show ra dgv
        private void btnXoaBX_Click(object sender, EventArgs e)
        {
            using (var _contextDB = new DataAccessLayer())
            {
                BenXe dbFood = _contextDB.BenXes.FirstOrDefault(x => x.MaBX == this.idXe);
                if (dbFood != null)
                {
                    _contextDB.BenXes.Remove(dbFood);
                }
                _contextDB.SaveChanges();
                ShowBenXe();
            }
        }
       



        // Switch TabPage : Chuyển tab bằng button 
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            tabpageVeXe.SelectTab(0);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            tabpageVeXe.SelectTab(1);
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            tabpageVeXe.SelectTab(2);
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            tabpageVeXe.SelectTab(3);
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            tabpageVeXe.SelectTab(4);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            tabpageVeXe.SelectTab(5);
        }

       
    }
}
