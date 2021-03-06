﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillingStation
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = true;
        }

        private void lblItem_Click(object sender, EventArgs e)
        {
            new UI.master.frmItem().Show();
            pnlStart.Visible = false;
            new UI.master.frmItem().TopMost=true;
            //this.Visible=false;
        }

        private void lblInvoice_Click(object sender, EventArgs e)
        {
            new UI.Sales.frmInvoice().Show();
            pnlStart.Visible = false;
            new UI.Sales.frmInvoice().TopMost = true;
        }

        private void lblPO_Click(object sender, EventArgs e)
        {
            new UI.Purchasing.frmPO().Show();
            pnlStart.Visible = false;
            new UI.Purchasing.frmPO() .TopMost = true;
        }

        private void lblob_Click(object sender, EventArgs e)
        {
            new UI.Stock.frmOpenningBalence().Show();
            pnlStart.Visible = false;
            new UI.Stock.frmOpenningBalence().TopMost = true;
        }

        private void lblRB_Click(object sender, EventArgs e)
        {
            new UI.Stock.frmRemainingBalance().Show();
            pnlStart.Visible = false;
            new UI.Stock.frmRemainingBalance().TopMost = true;
        }
    }
}
