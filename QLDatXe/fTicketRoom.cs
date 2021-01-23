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
using System.Data.SqlClient;
using System.Data.Entity.SqlServer;

namespace QLDatXe
{
    public partial class fTicketRoom : Form
    {
        private TaiKhoan account;
        private string idChuyen;
        private int idBX;
        private int idXe;
        private string idChuyen_Lich;
        private string idVeXe;

        public int MaCX_DatXe { get; private set; }

        public fTicketRoom()
        {
            InitializeComponent();
        }
        public fTicketRoom(TaiKhoan acc)
        {
            InitializeComponent();
            this.account = acc;
        }
        //Load thông tin 
        private void fTicketRoom_Load(object sender, EventArgs e)
        {
            //init Database
            ShowCmbChuyenXe_DatVe();
            txtTenKhach.Text = this.account.displayName;
            txtSDT.Text = this.account.numberPhone.ToString();
            //ForMat DateTime
            //Show ComboBox
            ShowCmbLoaiXe();
            ShowCmbMaXe();
            ShowCmbChuyenDi();
            ShowCmbChuyenDen();
            ShowCmbMaXe_Chuyen();
            ShowCmbMaChuyen();
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
                cmbLoaiXe.ValueMember = "MaLoai";
            }
        }
        public void ShowCmbMaXe()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<Xe> listXe = _contextDB.Xes.ToList();
                cmbMaXe.DataSource = listXe;
                cmbMaXe.DisplayMember = "MaXe";
                cmbMaXe.ValueMember = "MaXe";
            }
        }
        public void ShowCmbMaXe_Chuyen()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<Xe> listXe = _contextDB.Xes.ToList();
                cmbMaXe_Chuyen.DataSource = listXe;
                cmbMaXe_Chuyen.DisplayMember = "MaXe";
                cmbMaXe_Chuyen.ValueMember = "MaXe";
            }
        }
        
        public void ShowCmbChuyenDi()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<BenXe> listXe = _contextDB.BenXes.ToList();
                cmbBXDi.DataSource = listXe;
                cmbBXDi.DisplayMember = "Ten";
                cmbBXDi.ValueMember = "MaBX";
            }
        }
        public void ShowCmbMaChuyen()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<ChuyenXe> listXe = _contextDB.ChuyenXes.ToList();
                cmbMaChuyen.DataSource = listXe;
                cmbMaChuyen.DisplayMember = "MaCX";
                cmbMaChuyen.ValueMember = "MaCX";
            }
        }
        public void ShowCmbChuyenDen()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<BenXe> listXe = _contextDB.BenXes.ToList();
                cmbBXDen.DataSource = listXe;
                cmbBXDen.DisplayMember = "Ten";
                cmbBXDen.ValueMember = "MaBX";
            }
        }
        public void ShowCmbChuyenXe_DatVe()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<ChuyenXe> listXe = _contextDB.ChuyenXes.ToList();
                cmbTemp.DataSource = listXe;
                cmbTemp.DisplayMember = "MaCX";
                cmbTemp.ValueMember = "MaCX";
            }
        }
        private void cmbChuyenXe_DatVe_TextChanged(object sender, EventArgs e)
        {
           
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
                    dgvLichChay.Rows[index].Cells[0].Value = (item.BenXe.Ten + " - " + item.BenXe1.Ten).ToString();
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
                    dgvLichTong.Rows[index].Cells[0].Value = item.MaCX;
                    dgvLichTong.Rows[index].Cells[2].Value = item.Ngaydi;
                    dgvLichTong.Rows[index].Cells[1].Value = item.Xe.LoaiXe.TenLoai;
                    dgvLichTong.Rows[index].Cells[3].Value = item.BenXe.Ten;
                    dgvLichTong.Rows[index].Cells[4].Value = item.BenXe1.Ten;
                    dgvLichTong.Rows[index].Cells[5].Value = item.GiaVe;
                }
            }

        }
        public void ShowVe()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<VeXe> listVeXe = _contextDB.VeXes.ToList();
                VeXe vexe = new VeXe();
                dgvVeXe.Rows.Clear();
                foreach (VeXe item in listVeXe)
                {
                    int index = dgvVeXe.Rows.Add();
                    dgvVeXe.Rows[index].Cells[0].Value = item.MaVe;
                    dgvVeXe.Rows[index].Cells[1].Value = (item.ChuyenXe.BenXe.Ten + " - " + item.ChuyenXe.BenXe1.Ten).ToString();
                    dgvVeXe.Rows[index].Cells[2].Value = item.TenKhach;
                    dgvVeXe.Rows[index].Cells[3].Value = item.sdt;
                    dgvVeXe.Rows[index].Cells[4].Value = item.ChuyenXe.GiaVe;
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
                this.idBX = int.Parse(dgvBenXe.Rows[index].Cells[0].Value.ToString());
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
                cmbMaXe.Text = dgvXe.Rows[index].Cells[0].Value.ToString();
                cmbLoaiXe.Text = dgvXe.Rows[index].Cells[1].Value.ToString();
                txtSoGhe.Text = dgvXe.Rows[index].Cells[2].Value.ToString();
            }
            else
            {
                return;
            }
        }
        private void dgvChuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                this.idChuyen = dgvLichTong.Rows[index].Cells[0].Value.ToString();
                cmbMaChuyen.Text = dgvLichTong.Rows[index].Cells[0].Value.ToString();
                cmbMaXe_Chuyen.Text = dgvLichTong.Rows[index].Cells[1].Value.ToString();
                dtpChuyenXe.Text = dgvLichTong.Rows[index].Cells[2].Value.ToString();
                cmbBXDi.Text = dgvLichTong.Rows[index].Cells[3].Value.ToString();
                cmbBXDen.Text = dgvLichTong.Rows[index].Cells[4].Value.ToString();
                txtGiaVe.Text = dgvLichTong.Rows[index].Cells[5].Value.ToString();
            }
            else
            {
                return;
            }
        }
        private void dgvLichChayXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                this.idChuyen_Lich = dgvLichChay.Rows[index].Cells[0].RowIndex.ToString();
                lblMaChuyenXe.Text = dgvLichChay.Rows[index].Cells[0].Value.ToString();
                lblThoiGian.Text = dgvLichChay.Rows[index].Cells[1].Value.ToString();
                lblLoaiXe.Text = dgvLichChay.Rows[index].Cells[2].Value.ToString();
                lblTenBenXeDi.Text = dgvLichChay.Rows[index].Cells[3].Value.ToString();
                lblTenBenXeDen.Text = dgvLichChay.Rows[index].Cells[4].Value.ToString();
                using (var _contextDB = new DataAccessLayer())
                {
                    List<ChuyenXe> listChuyenXe = _contextDB.ChuyenXes.Where(x => x.MaCX == this.idChuyen_Lich).ToList();
                    foreach (ChuyenXe item in listChuyenXe)
                    {
                        lblMaChuyenXe.Text =(item.BenXe.Ten + " - " + item.BenXe1.Ten).ToString(); ;
                        lblThoiGian.Text = item.Ngaydi.ToString();
                        lblMaXe.Text = item.MaXe.ToString();
                        lblLoaiXe.Text = item.Xe.LoaiXe.TenLoai;
                        lblSoGhe.Text = item.Xe.SoGhe.ToString();
                        lblMaBenXeDi.Text = item.BenXe.MaBX.ToString();
                        lblTenBenXeDi.Text = item.BenXe.Ten.ToString();
                        lblDiaChiBXDi.Text = item.BenXe.DiaChi.ToString();
                        lblMaBenXeDen.Text = item.BenXe1.MaBX.ToString();
                        lblTenBenXeDen.Text = item.BenXe1.Ten.ToString();
                        lblDiaChiBXDen.Text = item.BenXe1.DiaChi.ToString();
                        int SoGhe = (item.Xe.SoGhe - item.VeXes.Count());
                        if (SoGhe < 0)
                        {
                            lblSoGheCon.Text = "0";
                            lblTinhTrang.Text = "Hết Chỗ";
                        }
                        lblSoGheCon.Text = (item.Xe.SoGhe - item.VeXes.Count()).ToString();
                        lblTinhTrang.Text = "Còn Chỗ";

                    }
                }
            }
            else
            {
                return;
            }
        }
        private void dgvVeXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                this.idVeXe = dgvVeXe.Rows[index].Cells[0].Value.ToString();
                txtMaVe.Text = dgvVeXe.Rows[index].Cells[0].Value.ToString();
                cmbMaChuyen.Text = dgvVeXe.Rows[index].Cells[1].Value.ToString();
                txtTenKhach.Text = dgvVeXe.Rows[index].Cells[2].Value.ToString();
                txtSDT.Text = dgvVeXe.Rows[index].Cells[3].Value.ToString();
                txtGiaVe.Text = dgvVeXe.Rows[index].Cells[4].Value.ToString();
            }
            else
            {
                return;
            }
        }

        // Thêm thông tin vào database và show ra dgv
        private void btnAddChuyen_Click(object sender, EventArgs e)
        {
            if (cmbBXDi.Text == "" || cmbBXDen.Text == "" || dtpChuyenXe.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var _dbContext = new DataAccessLayer())
                {

                    ChuyenXe chuyenXe = new ChuyenXe();
                    if (cmbBXDi.SelectedValue.ToString() == cmbBXDen.SelectedValue.ToString())
                    {
                        MessageBox.Show("Bến Xe Đi không được trùng với Bến Xe Đến !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    chuyenXe.MaCX =cmbMaChuyen.Text;
                    chuyenXe.MaBXDi = int.Parse(cmbBXDi.SelectedValue.ToString());
                    chuyenXe.MaBXDen = int.Parse(cmbBXDen.SelectedValue.ToString());
                    chuyenXe.Ngaydi = DateTime.Parse(dtpChuyenXe.Text);
                    chuyenXe.MaXe = int.Parse(cmbMaXe_Chuyen.SelectedValue.ToString());
                    chuyenXe.GiaVe = int.Parse(txtGiaVe.Text);
                    _dbContext.ChuyenXes.Add(chuyenXe);
                    _dbContext.SaveChanges();
                }
                ShowTongChuyenXe();
                MessageBox.Show("Thêm Chuyến Mới Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaChuyen.Text = "";
                cmbBXDi.SelectedIndex = 0;
                cmbBXDen.SelectedIndex = 0;
                dtpChuyenXe.Text = DateTime.Now.ToString();
                cmbMaXe.SelectedIndex = 0;
            }
        }
        private void btnThemXe_Click(object sender, EventArgs e)
        {
            if (cmbLoaiXe.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (var _dbContext = new DataAccessLayer())
                {
                    Xe xe = new Xe();
                    xe.Loai = int.Parse(cmbLoaiXe.SelectedValue.ToString());
                    xe.SoGhe = int.Parse(txtSoGhe.Text);
                    _dbContext.Xes.Add(xe);
                    _dbContext.SaveChanges();
                }
                ShowXe();
                MessageBox.Show("Thêm Xe Mới Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaXe.SelectedValue = 0;
                cmbLoaiXe.SelectedIndex =0;
            }
        }
        private void btnAddBX_Click(object sender, EventArgs e)
        {
            if (txtTenBX.Text == "" || txtDiaChiBX.Text == "")
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
        private void btnAddVeXe_Click(object sender, EventArgs e)
        {
            if (txtTenKhach.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var _dbContext = new DataAccessLayer())
                {
                    VeXe vexe = new VeXe();
                    vexe.MaCX = cmbTemp.SelectedValue.ToString();
                    vexe.TenKhach = txtTenKhach.Text;
                    vexe.sdt = int.Parse(txtSDT.Text);
                    _dbContext.VeXes.Add(vexe);
                    _dbContext.SaveChanges();
                }
                MessageBox.Show("Mua Vé Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowVe();
                txtTenKhach.Text = "";
                txtSDT.Text = "";
            }
        }

        // Sửa Thông tin trong database và show ra dgv
        private void btnSuaBX_Click(object sender, EventArgs e)
        {
            using (var _contextDB = new DataAccessLayer())
            {
                BenXe dbBenXe = _contextDB.BenXes.FirstOrDefault(x => x.MaBX == this.idBX);
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
                    if (int.Parse(txtSoGhe.Text) >= 20)
                    {
                        dbXe.SoGhe = int.Parse(txtSoGhe.Text);
                    }
                    else
                    {
                        MessageBox.Show("Số ghế Sai,Số ghế luôn lớn hơn 20 chỗ !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                _contextDB.SaveChanges();
                ShowXe();
                MessageBox.Show("Sửa Xe" + dbXe.LoaiXe.TenLoai + " Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaXe.SelectedIndex = 0;
                cmbLoaiXe.SelectedIndex = 0;
            }
        }

        private void btnSuaChuyen_Click(object sender, EventArgs e)
        {
            using (var _contextDB = new DataAccessLayer())
            {
                ChuyenXe dbChuyenXe = _contextDB.ChuyenXes.FirstOrDefault(x => x.MaCX == this.idChuyen);
                if (dbChuyenXe != null)
                {
                    dbChuyenXe.MaBXDi = int.Parse(cmbBXDi.SelectedValue.ToString());
                    dbChuyenXe.MaBXDen = int.Parse(cmbBXDen.SelectedValue.ToString());
                    dbChuyenXe.Ngaydi = DateTime.Parse(dtpChuyenXe.Text);
                    dbChuyenXe.MaXe = int.Parse(cmbMaXe_Chuyen.SelectedValue.ToString());
                    dbChuyenXe.GiaVe = double.Parse(txtGiaVe.Text);
                    _contextDB.SaveChanges();
                    ShowTongChuyenXe();
                    MessageBox.Show("Sửa Bến Xe" + dbChuyenXe.MaCX + " Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("Sửa Bến Xe Thất Bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                cmbBXDi.SelectedIndex = 0;
                cmbBXDen.SelectedIndex = 0;
                dtpChuyenXe.Text = DateTime.Now.ToString();
                cmbMaXe_Chuyen.SelectedIndex = 0;
                txtGiaVe.Text = "";

            }
        }


        // Xóa Thông tin trong database và show ra dgv
        private void btnXoaBX_Click(object sender, EventArgs e)
        {
            using (var _contextDB = new DataAccessLayer())
            {
                BenXe dbFood = _contextDB.BenXes.FirstOrDefault(x => x.MaBX == this.idBX);
                if (dbFood != null)
                {
                    _contextDB.BenXes.Remove(dbFood);
                }
                _contextDB.SaveChanges();
                ShowBenXe();
            }
        }
        private void btnXoaXe_Click(object sender, EventArgs e)
        {
            using (var _contextDB = new DataAccessLayer())
            {
                Xe dbXe = _contextDB.Xes.FirstOrDefault(x => x.MaXe == this.idXe);
                if (dbXe != null)
                {
                    _contextDB.Xes.Remove(dbXe);
                }
                _contextDB.SaveChanges();
                ShowXe();
            }
        }
        private void btnXoaChuyenXe_Click(object sender, EventArgs e)
        {
            using (var _contextDB = new DataAccessLayer())
            {
                ChuyenXe dbChuyenXe = _contextDB.ChuyenXes.FirstOrDefault(x => x.MaCX == this.idChuyen);
                if (dbChuyenXe != null)
                {
                    _contextDB.ChuyenXes.Remove(dbChuyenXe);
                    _contextDB.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
                ShowTongChuyenXe();
            }
        }

        private void cmbTemp_SelectedValueChanged(object sender, EventArgs e)
        {
            using (var _contextDB = new DataAccessLayer())
            {
                ChuyenXe dbchuyenxe = _contextDB.ChuyenXes.FirstOrDefault(
                    x => x.MaCX == cmbTemp.Text);
                if (dbchuyenxe != null)
                {
                    lblBXDi_DatXe.Text = dbchuyenxe.BenXe.Ten;
                    lblBXDen_DatXe.Text = dbchuyenxe.BenXe1.Ten;
                    txtGiaVe_DatVe.Text = dbchuyenxe.GiaVe.ToString();
                }

            }

        }
        private void cmbMaChuyen_SelectedValueChanged(object sender, EventArgs e)
        {
            using (var _contextDB = new DataAccessLayer())
            {
                ChuyenXe dbchuyenxe = _contextDB.ChuyenXes.FirstOrDefault(
                    x => x.MaCX == cmbMaChuyen.Text);
                if (dbchuyenxe != null)
                {
                    txtGiaVe.Text =dbchuyenxe.GiaVe.ToString();
                }

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

        private void tpXe_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC9_Click(object sender, EventArgs e)
        {
            using (var _contextDB = new DataAccessLayer())
            {
                VeXe dbVeXe = _contextDB.VeXes.FirstOrDefault(x => x.MaVe == this.idVeXe);
                if (dbVeXe != null)
                {
                    _contextDB.VeXes.Remove(dbVeXe);
                    _contextDB.SaveChanges();
                    MessageBox.Show("Hủy Thành Công !");
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
                ShowVe();
            }
        }

    }
}
