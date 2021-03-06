﻿using System;
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
        public TaiKhoan account;
        public fHome()
        {
            InitializeComponent();
        }
        private void fHome_Load(object sender, EventArgs e)
        {
            toolVisible(false);
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
            OpenRoom();
            toolVisible(false);
            MessageBox.Show("Xin Chào " + account.displayName);
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
                if (this.account.type.Trim() == "user")
                {
                    mnsHome.Visible = !status;
                    mnsHelp.Visible = !status;
                    mnsAccount.Visible = !status;
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
        
        public void OpenRoom()
        {
            Form frmChild = this.MdiChildren.OfType<fTicketRoom>().FirstOrDefault();

            if (frmChild == null)
            {
                fTicketRoom frm = new fTicketRoom(account);
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                return;
            }
            frmChild.Activate();
        }
        public void OpenStatic()
        {
            Form frmChild = this.MdiChildren.OfType<fStatic>().FirstOrDefault();

            if (frmChild == null)
            {
                fStatic frm = new fStatic(account);
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

        private void mnsManageTickets_Click(object sender, EventArgs e)
        {
            Form frmChild = this.MdiChildren.OfType<fManageTicket>().FirstOrDefault();

            if (frmChild == null)
            {
                fManageTicket frm = new fManageTicket(account);
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                return;
            }
            frmChild.Activate();
        }

        private void mnsStatis_Click(object sender, EventArgs e)
        {
            OpenStatic();
        }
    }
}
