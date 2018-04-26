namespace FillingStation
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.pnlStart = new MetroFramework.Controls.MetroPanel();
            this.lblob = new MetroFramework.Controls.MetroLabel();
            this.lblPO = new System.Windows.Forms.Label();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblRB = new MetroFramework.Controls.MetroLabel();
            this.pnlStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(5, 312);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlStart
            // 
            this.pnlStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlStart.Controls.Add(this.lblRB);
            this.pnlStart.Controls.Add(this.lblob);
            this.pnlStart.Controls.Add(this.lblPO);
            this.pnlStart.Controls.Add(this.lblInvoice);
            this.pnlStart.Controls.Add(this.lblItem);
            this.pnlStart.HorizontalScrollbarBarColor = true;
            this.pnlStart.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlStart.HorizontalScrollbarSize = 10;
            this.pnlStart.Location = new System.Drawing.Point(5, 64);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(51, 242);
            this.pnlStart.TabIndex = 1;
            this.pnlStart.VerticalScrollbarBarColor = true;
            this.pnlStart.VerticalScrollbarHighlightOnWheel = false;
            this.pnlStart.VerticalScrollbarSize = 10;
            this.pnlStart.Visible = false;
            // 
            // lblob
            // 
            this.lblob.AutoSize = true;
            this.lblob.Location = new System.Drawing.Point(6, 166);
            this.lblob.Name = "lblob";
            this.lblob.Size = new System.Drawing.Size(25, 19);
            this.lblob.TabIndex = 3;
            this.lblob.Text = "ob";
            this.lblob.Click += new System.EventHandler(this.lblob_Click);
            // 
            // lblPO
            // 
            this.lblPO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPO.AutoSize = true;
            this.lblPO.Location = new System.Drawing.Point(7, 187);
            this.lblPO.Name = "lblPO";
            this.lblPO.Size = new System.Drawing.Size(22, 13);
            this.lblPO.TabIndex = 2;
            this.lblPO.Text = "PO";
            this.lblPO.Click += new System.EventHandler(this.lblPO_Click);
            // 
            // lblInvoice
            // 
            this.lblInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Location = new System.Drawing.Point(7, 200);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(42, 13);
            this.lblInvoice.TabIndex = 2;
            this.lblInvoice.Text = "Invoice";
            this.lblInvoice.Click += new System.EventHandler(this.lblInvoice_Click);
            // 
            // lblItem
            // 
            this.lblItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(7, 217);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "Item";
            this.lblItem.Click += new System.EventHandler(this.lblItem_Click);
            // 
            // lblRB
            // 
            this.lblRB.AutoSize = true;
            this.lblRB.Location = new System.Drawing.Point(6, 147);
            this.lblRB.Name = "lblRB";
            this.lblRB.Size = new System.Drawing.Size(22, 19);
            this.lblRB.TabIndex = 3;
            this.lblRB.Text = "rb";
            this.lblRB.Click += new System.EventHandler(this.lblRB_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 339);
            this.Controls.Add(this.pnlStart);
            this.Controls.Add(this.btnStart);
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroPanel pnlStart;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Label lblPO;
        private MetroFramework.Controls.MetroLabel lblob;
        private MetroFramework.Controls.MetroLabel lblRB;
    }
}