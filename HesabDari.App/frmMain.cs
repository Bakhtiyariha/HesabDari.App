﻿using HesabDari.App.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HesabDari.Utility.Convertor;
using HesabDari.ViewModel;
using HesabDari.Business;

namespace HesabDari.App
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void btnPersons_Click(object sender, EventArgs e)
        {
            frmPersons persons = new frmPersons();
            persons.ShowDialog();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmTransaction transaction = new frmTransaction();
            transaction.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmCredite credite = new frmCredite();
            int result = 1;
            credite.kindOfTransaction = result;
            credite.ShowDialog();
        }

        private void btnEditDebtor_Click(object sender, EventArgs e)
        {
            frmCredite debt = new frmCredite();
            int result = 2;
            debt.kindOfTransaction = result;
            debt.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                lblDate.Text = DateTime.Now.ToShamsi();
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss"); 
                Report();
            }
            else
            {
                Application.Exit();
            }

        }

        void Report()
        {
            ReportViewModel report = Account.ReportFormMain();
            {
                lblCredite.Text = report.Recive.ToString("#,0");
                lblDebt.Text = report.Pay.ToString("#,0");
                lblBalance.Text = report.AccountBalamce.ToString("#,0");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnManagmentOfUserAndPassword_Click(object sender, EventArgs e)
        {
            frmLogin managmentLogin = new frmLogin();
            managmentLogin.isEdit = true;
            managmentLogin.ShowDialog();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            frmBackUp backUp = new frmBackUp();
            backUp.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Report();
        }

    }
}
