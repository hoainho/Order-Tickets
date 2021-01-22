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
    
    public partial class fHome : Form
    {
        private TaiKhoan account;
        public fHome()
        {
            InitializeComponent();
        }
        private void fHome_Load(object sender, EventArgs e)
        {
            toolVisible(false);
            OpenRoom();
            OpenLoginForm();

        }

        public void OpenLoginForm()
        {
            Form frmChild = this.MdiChildren.OfType<fLogin>().FirstOrDefault();
            if (frmChild == null)
            {
                fLogin frm = new fLogin();
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.accountAccuracy += Frm_accountAccuracy;

                frm.Show();
                return;
            }
            frmChild.Activate();

        }

        private void Frm_accountAccuracy(TaiKhoan acc)
        {
            this.account = acc;
            mnsAccount.Text = string.Format(acc.displayName);
            MessageBox.Show("Xin Chào "+ account.displayName );
            toolVisible(false);
        }

        private void toolVisible(bool status)
        {
            if (account == null)
            {
                mnsHome.Visible = status;
                mnsSetting.Visible = status;
                mnsStatis.Visible = status;
                mnsManageTickets.Visible = status;
                mnsHelp.Visible = status;
                mnsTour.Visible = status;
                mnsAccount.Visible = status;
            }
            else
            {
                if (this.account.type == "User")
                {
                    mnsHome.Visible = !status;
                    mnsHelp.Visible = !status;
                    mnsTour.Visible = !status;
                }
                else
                {
                    mnsHome.Visible = !status;
                    mnsSetting.Visible = !status;
                    mnsStatis.Visible = !status;
                    mnsManageTickets.Visible = !status;
                    mnsHelp.Visible = !status;
                    mnsTour.Visible = !status;
                    mnsAccount.Visible = !status;
                }
            }

        }
        //public void showRoom()
        //{
        //    if (this.account != null)
        //    {
        //        OpenRoom();
        //    }
        //}
        public void OpenRoom()
        {
            Form frmChild = this.MdiChildren.OfType<fTicketRoom>().FirstOrDefault();

            if (frmChild == null)
            {
                fTicketRoom frm = new fTicketRoom();
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                return;
            }
            frmChild.Activate();
        }

        private void mnsHome_Click(object sender, EventArgs e)
        {
            OpenRoom();
        }
    }
}
