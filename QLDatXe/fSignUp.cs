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
    public partial class fSignUp : Form
    {
        public fSignUp()
        {
            InitializeComponent();
        }
        private void txtDisplayName_Validating(object sender, CancelEventArgs e)
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



        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplayName.Text == "" || txtUserName.Text == "" || txtAddress.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var _dbContext = new DataAccessLayer())
                {
                    TaiKhoan acc = new TaiKhoan();
                    acc.displayName = txtDisplayName.Text;
                    acc.userName = txtUserName.Text;
                    acc.numberPhone = int.Parse(txtPassword.Text);
                    acc.type = txtAccountType.Text;
                    acc.address = txtAddress.Text;
                    _dbContext.TaiKhoans.Add(acc);
                    _dbContext.SaveChanges();
                }
                this.Close();
                MessageBox.Show("Chúc Mừng Bạn Gia Nhập 707 Team !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDisplayName.Text = "";
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtAddress.Text = "";
            }
            Application.Restart();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
