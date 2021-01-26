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
        Random _randomCode = new Random();
        private TaiKhoan account;
        private string idChuyen;
        private int idBX;
        private string idXe;
        private string idChuyen_Lich;
        private string idVeXe;
        private string idsend;
        private string idSave_DatVe;
        public int MaCX_DatXe { get; private set; }

        public fTicketRoom()
        {
            InitializeComponent();
        }
        
        //MDI
        public fTicketRoom(TaiKhoan acc)
        {
            InitializeComponent();
            this.account = acc;
        }
        //Load thông tin 
        private void fTicketRoom_Load(object sender, EventArgs e)
        {
            //init Database

            controlVisible();
            txtTenKhach.Text = this.account.displayName;
            txtSDT.Text = this.account.numberPhone.ToString();
            //ForMat DateTime
            //Show ComboBox
            ShowCmbLoaiXe();
            ShowCmbMaXe();
            ShowCmbMaXe_DatVe();
            ShowCmbChuyenDi();
            ShowCmbChuyenDen();
            ShowCmbMaXe_Chuyen();
            ShowCmbMaChuyen();
            ShowCmbChuyenXe_DatVe();
            //Show datagridview
            ShowChuyenXe();
            ShowTongChuyenXe();
            ShowVe();
            ShowXe();
            ShowBenXe();
        }
        //Visible Features
        public void controlVisible()
        {
            if (this.account.type.Trim() == "user")
            {
                tpgManageBus.TabPages.Remove(tpQLLich);
                tpgManageBus.TabPages.Remove(tpXe);
                tpgManageBus.TabPages.Remove(tpBenXe);
                tpgManageBus.TabPages.Remove(tpNhanVien);
                pnlManager.Visible = false;
            }

        }
        //Refresh Database

        public void RefreshDB()
        {
            ShowCmbLoaiXe();
            ShowCmbMaXe();
            ShowCmbMaXe_DatVe();
            ShowCmbChuyenDi();
            ShowCmbChuyenDen();
            ShowCmbMaXe_Chuyen();
            ShowCmbMaChuyen();
            ShowCmbChuyenXe_DatVe();
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
        public void ShowCmbMaXe_DatVe()
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<ChuyenXe> listXe = _contextDB.ChuyenXes.ToList();
                cmbMaXe_DatVe.DataSource = listXe;
                cmbMaXe_DatVe.DisplayMember = "MaXe";
                cmbMaXe_DatVe.ValueMember = "MaXe";
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
        public void ShowCmbLoaiXe_DatXe(List<Xe> listLX)
        {
            cmbLoaiXe_DatVe.DataSource = listLX;
            cmbLoaiXe_DatVe.DisplayMember = "Loai";
            cmbLoaiXe_DatVe.ValueMember = "MaXe";
        }
        public void ShowCmbTenLoaiXe_DatXe(List<LoaiXe> listTLX)
        {
            cmbTenLoaiXe_DatVe.DataSource = listTLX;
            cmbTenLoaiXe_DatVe.DisplayMember = "TenLoai";
            cmbTenLoaiXe_DatVe.ValueMember = "MaLoai";
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
                if (this.account.type.Trim() == "user")
                {
                    List<VeXe> listVeXe = _contextDB.VeXes.Where(x => x.userName.Trim() == this.account.userName.Trim()).ToList();
                    dgvVeXe.Rows.Clear();
                    foreach (VeXe item in listVeXe)
                    {
                        int index = dgvVeXe.Rows.Add();
                        dgvVeXe.Rows[index].Cells[0].Value = item.MaVe;
                        dgvVeXe.Rows[index].Cells[1].Value = (item.ChuyenXe.BenXe.Ten + " - " + item.ChuyenXe.BenXe1.Ten).ToString();
                        dgvVeXe.Rows[index].Cells[2].Value = item.MaXe;
                        dgvVeXe.Rows[index].Cells[3].Value = item.TenKhach;
                        dgvVeXe.Rows[index].Cells[4].Value = item.sdt;
                        dgvVeXe.Rows[index].Cells[5].Value = item.ChuyenXe.GiaVe;
                    }
                }
                else
                {
                    List<VeXe> listVeXe = _contextDB.VeXes.ToList();
                    dgvVeXe.Rows.Clear();
                    foreach (VeXe item in listVeXe)
                    {
                        int index = dgvVeXe.Rows.Add();
                        dgvVeXe.Rows[index].Cells[0].Value = item.MaVe;
                        dgvVeXe.Rows[index].Cells[1].Value = (item.ChuyenXe.BenXe.Ten + " - " + item.ChuyenXe.BenXe1.Ten).ToString();
                        dgvVeXe.Rows[index].Cells[2].Value = item.MaXe;
                        dgvVeXe.Rows[index].Cells[3].Value = item.TenKhach;
                        dgvVeXe.Rows[index].Cells[4].Value = item.sdt;
                        dgvVeXe.Rows[index].Cells[5].Value = item.ChuyenXe.GiaVe;
                    }
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
        private void dtpChuyenXe_ValueChanged(object sender, EventArgs e)
        {
            if (dtpChuyenXe.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Thời gian đi không được nhỏ hơn ngày hiện tại", "Nhắc Nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpChuyenXe.Value = DateTime.Now;
                return;
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
                this.idXe = dgvXe.Rows[index].Cells[0].Value.ToString();
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
                this.idChuyen_Lich = dgvLichChay.Rows[index].Cells[0].Value.ToString();
                lblMaChuyenXe.Text = dgvLichChay.Rows[index].Cells[0].Value.ToString();
                lblThoiGian.Text = dgvLichChay.Rows[index].Cells[1].Value.ToString();
                lblLoaiXe.Text = dgvLichChay.Rows[index].Cells[2].Value.ToString();
                lblTenBenXeDi.Text = dgvLichChay.Rows[index].Cells[3].Value.ToString();
                lblTenBenXeDen.Text = dgvLichChay.Rows[index].Cells[4].Value.ToString();
                using (var _contextDB = new DataAccessLayer())
                {
                    List<ChuyenXe> listChuyenXe = _contextDB.ChuyenXes.Where(x => (x.BenXe.Ten + " - " + x.BenXe1.Ten) == this.idChuyen_Lich).ToList();
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
                        if (int.Parse((item.Xe.SoGhe - item.VeXes.Count()).ToString()) <= 0)
                        {
                            lblSoGheCon.Text = "0";
                            lblTinhTrang.Text = "Hết Chỗ";
                        }
                        else
                        {
                            lblSoGheCon.Text = (item.Xe.SoGhe - item.VeXes.Count()).ToString();
                            lblTinhTrang.Text = "Còn Chỗ";
                        }
                        

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
                idSave_DatVe = dgvVeXe.Rows[index].Cells[0].Value.ToString();
                cmbMaChuyen.Text = dgvVeXe.Rows[index].Cells[1].Value.ToString();
                cmbMaXe_DatVe.Text = dgvVeXe.Rows[index].Cells[2].Value.ToString();
                txtTenKhach.Text = dgvVeXe.Rows[index].Cells[3].Value.ToString();
                txtSDT.Text = dgvVeXe.Rows[index].Cells[4].Value.ToString();
                txtGiaVe.Text = dgvVeXe.Rows[index].Cells[5].Value.ToString();
            }
            else
            {
                return;
            }
        }

        // Thêm thông tin vào database và show ra dgv
        private void btnAddChuyen_Click(object sender, EventArgs e)
        {
            if (cmbMaChuyen.Text == "" || txtGiaVe.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var _dbContext = new DataAccessLayer())
            {
                List<ChuyenXe> listCX = _dbContext.ChuyenXes.ToList();
                foreach (ChuyenXe item in listCX)
                {
                    if (item.MaCX == cmbMaChuyen.Text)
                    {
                        MessageBox.Show("Mã Chuyến " + item.MaCX + " Đã Tồn Tại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (item.MaXe == cmbMaXe_Chuyen.Text)
                    {
                        MessageBox.Show("Xe này đang chạy, vui lòng chọn xe khác", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                }
                ChuyenXe chuyenXe = new ChuyenXe();
                chuyenXe.MaCX = cmbMaChuyen.Text.Trim();
                chuyenXe.MaBXDi = int.Parse(cmbBXDi.SelectedValue.ToString());
                chuyenXe.MaBXDen = int.Parse(cmbBXDen.SelectedValue.ToString());
                chuyenXe.Ngaydi = DateTime.Parse(dtpChuyenXe.Text);
                chuyenXe.MaXe = cmbMaXe_Chuyen.SelectedValue.ToString();
                chuyenXe.GiaVe = int.Parse(txtGiaVe.Text);
                if (cmbBXDi.Text == cmbBXDen.Text)
                {
                    MessageBox.Show("Bến Xe đi không được trùng với Bến Xe đến", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _dbContext.ChuyenXes.Add(chuyenXe);
                MessageBox.Show("Thêm Chuyến " + chuyenXe.MaCX + " Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                _dbContext.SaveChanges();
                ShowTongChuyenXe();

                cmbMaChuyen.Text = "";
                cmbBXDi.SelectedIndex = 0;
                cmbBXDen.SelectedIndex = 0;
                //dtpChuyenXe.Text = DateTime.Now.ToString();
                cmbMaXe_Chuyen.Text = "";

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
                    xe.MaXe = _randomCode.Next().ToString();
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
                return;
            }
            
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
        private void btnAddVeXe_Click(object sender, EventArgs e)
        {
            if (txtTenKhach.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                using (var _dbContext = new DataAccessLayer())
                {
                    List<VeXe> listVe = _dbContext.VeXes.ToList();
                    Xe temp = _dbContext.Xes.FirstOrDefault(x => x.MaXe == cmbMaXe_DatVe.Text);
                    int dem = 0;
                    foreach (VeXe item in listVe)
                    {
                        if(item.MaXe == cmbMaXe_DatVe.Text)
                        {
                            dem++;
                        }
                    }
                    if(dem > temp.SoGhe)
                    {
                        MessageBox.Show("Xe này đã hết vé, vui lòng chọn sẽ khác !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        VeXe vexe = new VeXe();
                        vexe.MaVe = _randomCode.Next().ToString();
                        vexe.MaCX = cmbTemp.SelectedValue.ToString();
                        vexe.MaXe = cmbMaXe_DatVe.SelectedValue.ToString();
                        vexe.TenKhach = txtTenKhach.Text;
                        vexe.sdt = int.Parse(txtSDT.Text);
                        vexe.userName = this.account.userName;
                        _dbContext.VeXes.Add(vexe);
                        _dbContext.SaveChanges();

                        MessageBox.Show("Mã Vé Xe của bạn là :" + vexe.MaVe + " \n\tHãy Lưu lại nhé!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowVe();
                    }
                    int soGhe_ThemVe = int.Parse(lblSoGheCon.Text.ToString()) - 1;
                    if (soGhe_ThemVe == 0)
                    {
                        lblTinhTrang.Text = "Hết Chỗ";
                    }
                    lblSoGheCon.Text = soGhe_ThemVe.ToString();
                    txtTenKhach.Text = "";
                    txtSDT.Text = "";
                }
                
            
            
        }
        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            if (lblMaXe .Text == "")
            {
                MessageBox.Show("Vui lòng chọn chuyến xe muốn đi bên dưới bảng chọn !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (lblTinhTrang.Text == "Hết Chỗ")
                {
                MessageBox.Show("Xe này hiện tại đang hết chỗ, vui lòng chọn xe khác !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
                else
                {
                using (var _contextDB = new DataAccessLayer())
                {
                    List<ChuyenXe> listChuyenXe = _contextDB.ChuyenXes.Where(x => (x.BenXe.Ten + " - " + x.BenXe1.Ten) == this.idChuyen_Lich).ToList();
                    foreach (ChuyenXe item in listChuyenXe)
                    {
                        VeXe vexe = new VeXe();
                        vexe.MaVe = _randomCode.Next().ToString();
                        idsend = vexe.MaVe;
                        vexe.MaCX = item.MaCX;
                        vexe.MaXe = lblMaXe.Text;
                        vexe.TenKhach = this.account.displayName;
                        vexe.userName = this.account.userName;
                        vexe.sdt = this.account.numberPhone;
                            _contextDB.VeXes.Add(vexe);
                    }
                    int temp = int.Parse(lblSoGheCon.Text.ToString()) - 1;
                        if (temp == 0)
                        {
                            lblTinhTrang.Text = "Hết Chỗ";
                        }
                    lblSoGheCon.Text = temp.ToString();
                        _contextDB.SaveChanges();
                    MessageBox.Show("Mua Vé Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ShowVe();
                ShowChuyenXe();
                if(MessageBox.Show("Bạn có muốn lấy vé luôn không ?","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        ReportVeXe reportVe = new ReportVeXe(idsend);
                        reportVe.ShowDialog();
                    }
                }
            }      
                
        }

        // Sửa Thông tin trong database và show ra dgv
        private void btnSuaBX_Click(object sender, EventArgs e)
        {
            if (txtTenBX.Text == "" || txtDiaChiBX.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (cmbLoaiXe.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            if (cmbMaChuyen.Text == "" || txtGiaVe.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var _contextDB = new DataAccessLayer())
            {
                List<ChuyenXe> listCX = _contextDB.ChuyenXes.ToList();
                foreach (ChuyenXe item in listCX)
                {
                    if (item.MaXe == cmbMaXe_Chuyen.Text)
                    {
                        MessageBox.Show("Xe này đang chạy, vui lòng chọn xe khác", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                ChuyenXe dbChuyenXe = _contextDB.ChuyenXes.FirstOrDefault(x => x.MaCX == this.idChuyen);
                if (dbChuyenXe != null)
                {
                    dbChuyenXe.MaBXDi = int.Parse(cmbBXDi.SelectedValue.ToString());
                    dbChuyenXe.MaBXDen = int.Parse(cmbBXDen.SelectedValue.ToString());
                    dbChuyenXe.Ngaydi = DateTime.Parse(dtpChuyenXe.Text);
                    dbChuyenXe.MaXe = cmbMaXe_Chuyen.SelectedValue.ToString();
                    dbChuyenXe.GiaVe = double.Parse(txtGiaVe.Text);
                    _contextDB.SaveChanges();
                    ShowTongChuyenXe();
                    MessageBox.Show("Sửa Chuyến Xe " + dbChuyenXe.MaCX + " Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
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

        private void btnSuaVeXe_Click(object sender, EventArgs e)
        {
            if (txtTenKhach.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var _contextDB = new DataAccessLayer())
            {
                VeXe dbVeXe = _contextDB.VeXes.FirstOrDefault(x => x.MaVe == this.idVeXe);
                if (dbVeXe != null)
                {
                    if (MessageBox.Show("Bạn chỉ có thể sửa tên và số điện thoại \n(Trường hợp nhượng vé xe )\n !", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        dbVeXe.TenKhach = txtTenKhach.Text;
                        dbVeXe.sdt = int.Parse(txtSDT.Text);
                        _contextDB.SaveChanges();ShowVe();
                        MessageBox.Show("Sửa Vé Xe Số " + txtMaVe.Text + " Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return;
                    }
                }
                
                cmbMaXe.SelectedIndex = 0;
                cmbLoaiXe.SelectedIndex = 0;
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
                    MessageBox.Show("Không Tìm Thấy Mã Vé !");
                }
                ShowVe();
            }
        }
        //Report
        private void btnGetTickets_Click(object sender, EventArgs e)
        {
            if (idSave_DatVe != null)
            {
                ReportVeXe temp = new ReportVeXe(idSave_DatVe);
                temp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vé muốn in !","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        // Các sự kiện thay đổi data children khi data parent thay đổi 
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
        private void cmbMaXe_DatVe_TextChanged(object sender, EventArgs e)
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<Xe> listLX = _contextDB.Xes.Where(p => p.MaXe == cmbMaXe_DatVe.Text).ToList();
                ShowCmbLoaiXe_DatXe(listLX);
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
        private void cmbMaXe_DatVe_Validating(object sender, CancelEventArgs e)
        {
            using (var _dbContext = new DataAccessLayer())
            {
                List<VeXe> listVe = _dbContext.VeXes.ToList();
                Xe temp = _dbContext.Xes.FirstOrDefault(x => x.MaXe == cmbMaXe_DatVe.Text);
                int dem = 0;
                foreach (VeXe item in listVe)
                {
                    if (item.MaXe == cmbMaXe_DatVe.Text)
                    {
                        dem++;
                    }
                }
                if (dem > temp.SoGhe)
                {
                    NotificationError.SetError(cmbMaXe_DatVe, " Hết Vé !");
                }
                else
                {
                    NotificationError.SetError(cmbMaXe_DatVe, "");

                }
            }
        }
        //private void cmbBXDi_TextChanged(object sender, EventArgs e)
        //{
        //    if (cmbBXDi.Text == cmbBXDen.Text)
        //    {
        //        MessageBox.Show("Bến Xe đi không được trùng với Bến Xe đến", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //}
        private void cmbMaXe_Chuyen_TextChanged(object sender, EventArgs e)
        {
            using (var _contextBD = new DataAccessLayer())
            {
                List<ChuyenXe> listCX = _contextBD.ChuyenXes.ToList();
                foreach (ChuyenXe item in listCX)
                {
                    if (item.MaXe == cmbMaXe_Chuyen.Text)
                    {
                        MessageBox.Show("Xe này đang chạy, vui lòng chọn xe khác","Nhắc nhở",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }

        private void cmbLoaiXe_DatVe_TextChanged(object sender, EventArgs e)
        {

            using (var _contextDB = new DataAccessLayer())
            {
                List<LoaiXe> listLX = _contextDB.LoaiXes.AsEnumerable().Where(p => p.MaLoai == int.Parse(cmbLoaiXe_DatVe.Text)).ToList();
                ShowCmbTenLoaiXe_DatXe(listLX);
            }
            
        }
        //Clear textbox 
        private void btnResetVe_Click(object sender, EventArgs e)
        {
            txtTenKhach.Text = "";
            txtSDT.Text = "";
        }

        //Tìm Kiếm 
        private void btnTimKiemVe_Click(object sender, EventArgs e)
        {
            using (var _contextDB = new DataAccessLayer())
            {
                if (txtMaVe.Text == "")
                {
                    List<VeXe> listSearch = _contextDB.VeXes.ToList();
                    ShowVe();
                }
                else
                {
                    List<VeXe> listSearch = _contextDB.VeXes.Where(x => x.MaVe == txtMaVe.Text).ToList();
                    dgvVeXe.Rows.Clear();
                    if (listSearch != null)
                    {
                        foreach (VeXe item in listSearch)
                        {
                            int index = dgvVeXe.Rows.Add();
                            dgvVeXe.Rows[index].Cells[0].Value = item.MaVe;
                            dgvVeXe.Rows[index].Cells[1].Value = (item.ChuyenXe.BenXe.Ten + " - " + item.ChuyenXe.BenXe1.Ten).ToString();
                            dgvVeXe.Rows[index].Cells[2].Value = item.MaXe;
                            dgvVeXe.Rows[index].Cells[3].Value = item.TenKhach;
                            dgvVeXe.Rows[index].Cells[4].Value = item.sdt;
                            dgvVeXe.Rows[index].Cells[5].Value = item.ChuyenXe.GiaVe;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Mã Vé Xe này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
               
            }
        }
        private void btnTimKiemChuyen_Click(object sender, EventArgs e)
        {
            using (var _contextDB = new DataAccessLayer())
            {
                List<ChuyenXe> listSearch = _contextDB.ChuyenXes.Where(x => x.MaCX == cmbMaChuyen.Text).ToList();
                dgvLichTong.Rows.Clear();
                if (listSearch != null)
                {
                    foreach (ChuyenXe item in listSearch)
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
                else
                {
                    MessageBox.Show("Không tìm thấy Mã Vé Xe này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        // Switch TabPage : Chuyển tab bằng button 
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            tpgManageBus.SelectTab(0);
            RefreshDB();
            cmbMaXe_Chuyen.Text = "";
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            tpgManageBus.SelectTab(1);
            RefreshDB();
            cmbMaXe_Chuyen.Text = "";
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            tpgManageBus.SelectTab(2);
            RefreshDB();
            cmbMaXe_Chuyen.Text = "";
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            tpgManageBus.SelectTab(3);
            RefreshDB();
            cmbMaXe_Chuyen.Text = "";
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            tpgManageBus.SelectTab(4);
            RefreshDB();
            cmbMaXe_Chuyen.Text = "";
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            tpgManageBus.SelectTab(5);
            RefreshDB();
            cmbMaXe_Chuyen.Text = "";
        }

        private void button_WOC7_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void dgvVeXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
