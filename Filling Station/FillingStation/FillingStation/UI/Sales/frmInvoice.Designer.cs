namespace FillingStation.UI.Sales
{
    partial class frmInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.btnInvoedit = new MetroFramework.Controls.MetroButton();
            this.btnInvoview = new MetroFramework.Controls.MetroButton();
            this.btnInvoDelete = new MetroFramework.Controls.MetroButton();
            this.btnInvoNew = new MetroFramework.Controls.MetroButton();
            this.btnnew = new MetroFramework.Controls.MetroButton();
            this.btnInvocancel = new MetroFramework.Controls.MetroButton();
            this.btnInvosave = new MetroFramework.Controls.MetroButton();
            this.txtInvoicesearch = new MetroFramework.Controls.MetroTextBox();
            this.dgdInvoice = new MetroFramework.Controls.MetroGrid();
            this.colInvoiceItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceItemUoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtInvoDiscRate = new MetroFramework.Controls.MetroTextBox();
            this.cboInvoicePaymentMethod = new MetroFramework.Controls.MetroComboBox();
            this.lblPOSInvoicePaymentMethod = new System.Windows.Forms.Label();
            this.txtInvoicePaidAmount = new System.Windows.Forms.TextBox();
            this.lblPOSInvoicePaidAmount = new System.Windows.Forms.Label();
            this.txtInvoiceBalance = new System.Windows.Forms.TextBox();
            this.lblPOSInvoiceBalance = new System.Windows.Forms.Label();
            this.txtInvoiceTotal = new System.Windows.Forms.TextBox();
            this.lblPOSInvoiceDiscount = new System.Windows.Forms.Label();
            this.lblPOSInvoiceTotal = new System.Windows.Forms.Label();
            this.btnInvoicePrint = new System.Windows.Forms.Button();
            this.btnInvoiceClear = new System.Windows.Forms.Button();
            this.txtInvoiceTotalDue = new System.Windows.Forms.TextBox();
            this.txtInvoiceDiscount = new System.Windows.Forms.TextBox();
            this.lblPOSInvoiceTotalDue = new System.Windows.Forms.Label();
            this.txtItemCode = new MetroFramework.Controls.MetroTextBox();
            this.txtItemName = new MetroFramework.Controls.MetroTextBox();
            this.txtItemQuantity = new MetroFramework.Controls.MetroTextBox();
            this.txtItmUnitPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtSubTotal = new MetroFramework.Controls.MetroTextBox();
            this.txtUoM = new MetroFramework.Controls.MetroTextBox();
            this.dgdInvoItemSearch = new System.Windows.Forms.DataGridView();
            this.txtInvoiceID = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomer = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPayingAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdInvoItemSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(847, 2);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(0, 0);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[] {
        "metroTextBox3"};
            this.metroTextBox3.Location = new System.Drawing.Point(36, 67);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(850, 2);
            this.metroTextBox3.TabIndex = 17;
            this.metroTextBox3.Text = "metroTextBox3";
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnInvoedit
            // 
            this.btnInvoedit.Location = new System.Drawing.Point(589, 21);
            this.btnInvoedit.Name = "btnInvoedit";
            this.btnInvoedit.Size = new System.Drawing.Size(50, 40);
            this.btnInvoedit.TabIndex = 16;
            this.btnInvoedit.Text = "Edit";
            this.btnInvoedit.UseSelectable = true;
            // 
            // btnInvoview
            // 
            this.btnInvoview.Location = new System.Drawing.Point(532, 21);
            this.btnInvoview.Name = "btnInvoview";
            this.btnInvoview.Size = new System.Drawing.Size(50, 40);
            this.btnInvoview.TabIndex = 15;
            this.btnInvoview.Text = "View";
            this.btnInvoview.UseSelectable = true;
            // 
            // btnInvoDelete
            // 
            this.btnInvoDelete.Location = new System.Drawing.Point(475, 21);
            this.btnInvoDelete.Name = "btnInvoDelete";
            this.btnInvoDelete.Size = new System.Drawing.Size(50, 40);
            this.btnInvoDelete.TabIndex = 12;
            this.btnInvoDelete.Text = "Delete";
            this.btnInvoDelete.UseSelectable = true;
            // 
            // btnInvoNew
            // 
            this.btnInvoNew.Location = new System.Drawing.Point(418, 21);
            this.btnInvoNew.Name = "btnInvoNew";
            this.btnInvoNew.Size = new System.Drawing.Size(50, 40);
            this.btnInvoNew.TabIndex = 13;
            this.btnInvoNew.Text = "New";
            this.btnInvoNew.UseSelectable = true;
            this.btnInvoNew.Click += new System.EventHandler(this.btnInvoNew_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(418, 21);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(50, 40);
            this.btnnew.TabIndex = 14;
            this.btnnew.Text = "New";
            this.btnnew.UseSelectable = true;
            // 
            // btnInvocancel
            // 
            this.btnInvocancel.Location = new System.Drawing.Point(239, 21);
            this.btnInvocancel.Name = "btnInvocancel";
            this.btnInvocancel.Size = new System.Drawing.Size(50, 40);
            this.btnInvocancel.TabIndex = 11;
            this.btnInvocancel.Text = "Cancel";
            this.btnInvocancel.UseSelectable = true;
            // 
            // btnInvosave
            // 
            this.btnInvosave.Location = new System.Drawing.Point(183, 21);
            this.btnInvosave.Name = "btnInvosave";
            this.btnInvosave.Size = new System.Drawing.Size(50, 40);
            this.btnInvosave.TabIndex = 10;
            this.btnInvosave.Text = "Save";
            this.btnInvosave.UseSelectable = true;
            // 
            // txtInvoicesearch
            // 
            // 
            // 
            // 
            this.txtInvoicesearch.CustomButton.Image = null;
            this.txtInvoicesearch.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtInvoicesearch.CustomButton.Name = "";
            this.txtInvoicesearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInvoicesearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoicesearch.CustomButton.TabIndex = 1;
            this.txtInvoicesearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoicesearch.CustomButton.UseSelectable = true;
            this.txtInvoicesearch.CustomButton.Visible = false;
            this.txtInvoicesearch.Lines = new string[0];
            this.txtInvoicesearch.Location = new System.Drawing.Point(665, 38);
            this.txtInvoicesearch.MaxLength = 32767;
            this.txtInvoicesearch.Name = "txtInvoicesearch";
            this.txtInvoicesearch.PasswordChar = '\0';
            this.txtInvoicesearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoicesearch.SelectedText = "";
            this.txtInvoicesearch.SelectionLength = 0;
            this.txtInvoicesearch.SelectionStart = 0;
            this.txtInvoicesearch.ShortcutsEnabled = true;
            this.txtInvoicesearch.Size = new System.Drawing.Size(213, 23);
            this.txtInvoicesearch.TabIndex = 9;
            this.txtInvoicesearch.UseSelectable = true;
            this.txtInvoicesearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoicesearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgdInvoice
            // 
            this.dgdInvoice.AllowUserToResizeRows = false;
            this.dgdInvoice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgdInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdInvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgdInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgdInvoice.ColumnHeadersHeight = 20;
            this.dgdInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgdInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceItemCode,
            this.colInvoiceItemName,
            this.colInvoiceQuantity,
            this.colInvoiceItemUoM,
            this.colInvoiceUnitPrice,
            this.colInvoiceSubTotal});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgdInvoice.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgdInvoice.EnableHeadersVisualStyles = false;
            this.dgdInvoice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgdInvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgdInvoice.Location = new System.Drawing.Point(36, 179);
            this.dgdInvoice.Name = "dgdInvoice";
            this.dgdInvoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgdInvoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgdInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdInvoice.Size = new System.Drawing.Size(633, 328);
            this.dgdInvoice.TabIndex = 1119;
            this.dgdInvoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdInvoice_CellEndEdit);
            // 
            // colInvoiceItemCode
            // 
            this.colInvoiceItemCode.HeaderText = "Item Code";
            this.colInvoiceItemCode.Name = "colInvoiceItemCode";
            this.colInvoiceItemCode.ToolTipText = "hello";
            // 
            // colInvoiceItemName
            // 
            this.colInvoiceItemName.HeaderText = "Item Name";
            this.colInvoiceItemName.Name = "colInvoiceItemName";
            this.colInvoiceItemName.Width = 120;
            // 
            // colInvoiceQuantity
            // 
            this.colInvoiceQuantity.HeaderText = "Quantity";
            this.colInvoiceQuantity.Name = "colInvoiceQuantity";
            // 
            // colInvoiceItemUoM
            // 
            this.colInvoiceItemUoM.HeaderText = "UoM";
            this.colInvoiceItemUoM.Name = "colInvoiceItemUoM";
            this.colInvoiceItemUoM.Width = 70;
            // 
            // colInvoiceUnitPrice
            // 
            this.colInvoiceUnitPrice.HeaderText = "Unit Price";
            this.colInvoiceUnitPrice.Name = "colInvoiceUnitPrice";
            // 
            // colInvoiceSubTotal
            // 
            this.colInvoiceSubTotal.HeaderText = "Sub Total";
            this.colInvoiceSubTotal.Name = "colInvoiceSubTotal";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(754, 250);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(26, 25);
            this.metroLabel1.TabIndex = 1140;
            this.metroLabel1.Text = "%";
            // 
            // txtInvoDiscRate
            // 
            this.txtInvoDiscRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtInvoDiscRate.CustomButton.Image = null;
            this.txtInvoDiscRate.CustomButton.Location = new System.Drawing.Point(27, 1);
            this.txtInvoDiscRate.CustomButton.Name = "";
            this.txtInvoDiscRate.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtInvoDiscRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoDiscRate.CustomButton.TabIndex = 1;
            this.txtInvoDiscRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoDiscRate.CustomButton.UseSelectable = true;
            this.txtInvoDiscRate.CustomButton.Visible = false;
            this.txtInvoDiscRate.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtInvoDiscRate.Lines = new string[] {
        "0.00"};
            this.txtInvoDiscRate.Location = new System.Drawing.Point(683, 242);
            this.txtInvoDiscRate.MaxLength = 32767;
            this.txtInvoDiscRate.Name = "txtInvoDiscRate";
            this.txtInvoDiscRate.PasswordChar = '\0';
            this.txtInvoDiscRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInvoDiscRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoDiscRate.SelectedText = "";
            this.txtInvoDiscRate.SelectionLength = 0;
            this.txtInvoDiscRate.SelectionStart = 0;
            this.txtInvoDiscRate.ShortcutsEnabled = true;
            this.txtInvoDiscRate.Size = new System.Drawing.Size(59, 33);
            this.txtInvoDiscRate.TabIndex = 1139;
            this.txtInvoDiscRate.Text = "0.00";
            this.txtInvoDiscRate.UseSelectable = true;
            this.txtInvoDiscRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoDiscRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInvoDiscRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInvoDiscRate_KeyDown);
            this.txtInvoDiscRate.Leave += new System.EventHandler(this.txtInvoDiscRate_Leave);
            // 
            // cboInvoicePaymentMethod
            // 
            this.cboInvoicePaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboInvoicePaymentMethod.FormattingEnabled = true;
            this.cboInvoicePaymentMethod.ItemHeight = 23;
            this.cboInvoicePaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.cboInvoicePaymentMethod.Location = new System.Drawing.Point(683, 380);
            this.cboInvoicePaymentMethod.Name = "cboInvoicePaymentMethod";
            this.cboInvoicePaymentMethod.Size = new System.Drawing.Size(203, 29);
            this.cboInvoicePaymentMethod.TabIndex = 1138;
            this.cboInvoicePaymentMethod.UseSelectable = true;
            // 
            // lblPOSInvoicePaymentMethod
            // 
            this.lblPOSInvoicePaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPOSInvoicePaymentMethod.AutoSize = true;
            this.lblPOSInvoicePaymentMethod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOSInvoicePaymentMethod.Location = new System.Drawing.Point(679, 356);
            this.lblPOSInvoicePaymentMethod.Name = "lblPOSInvoicePaymentMethod";
            this.lblPOSInvoicePaymentMethod.Size = new System.Drawing.Size(129, 21);
            this.lblPOSInvoicePaymentMethod.TabIndex = 1137;
            this.lblPOSInvoicePaymentMethod.Text = "Payment Method";
            // 
            // txtInvoicePaidAmount
            // 
            this.txtInvoicePaidAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInvoicePaidAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoicePaidAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoicePaidAmount.Location = new System.Drawing.Point(683, 442);
            this.txtInvoicePaidAmount.MinimumSize = new System.Drawing.Size(86, 33);
            this.txtInvoicePaidAmount.Name = "txtInvoicePaidAmount";
            this.txtInvoicePaidAmount.ReadOnly = true;
            this.txtInvoicePaidAmount.Size = new System.Drawing.Size(203, 33);
            this.txtInvoicePaidAmount.TabIndex = 1135;
            this.txtInvoicePaidAmount.Text = "0.00";
            this.txtInvoicePaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPOSInvoicePaidAmount
            // 
            this.lblPOSInvoicePaidAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPOSInvoicePaidAmount.AutoSize = true;
            this.lblPOSInvoicePaidAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOSInvoicePaidAmount.Location = new System.Drawing.Point(679, 418);
            this.lblPOSInvoicePaidAmount.Name = "lblPOSInvoicePaidAmount";
            this.lblPOSInvoicePaidAmount.Size = new System.Drawing.Size(100, 21);
            this.lblPOSInvoicePaidAmount.TabIndex = 1133;
            this.lblPOSInvoicePaidAmount.Text = "Paid Amount";
            // 
            // txtInvoiceBalance
            // 
            this.txtInvoiceBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInvoiceBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceBalance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceBalance.Location = new System.Drawing.Point(683, 573);
            this.txtInvoiceBalance.MinimumSize = new System.Drawing.Size(86, 33);
            this.txtInvoiceBalance.Name = "txtInvoiceBalance";
            this.txtInvoiceBalance.Size = new System.Drawing.Size(203, 33);
            this.txtInvoiceBalance.TabIndex = 1132;
            this.txtInvoiceBalance.Text = "0.00";
            this.txtInvoiceBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPOSInvoiceBalance
            // 
            this.lblPOSInvoiceBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPOSInvoiceBalance.AutoSize = true;
            this.lblPOSInvoiceBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOSInvoiceBalance.Location = new System.Drawing.Point(679, 549);
            this.lblPOSInvoiceBalance.Name = "lblPOSInvoiceBalance";
            this.lblPOSInvoiceBalance.Size = new System.Drawing.Size(63, 21);
            this.lblPOSInvoiceBalance.TabIndex = 1131;
            this.lblPOSInvoiceBalance.Text = "Balance";
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInvoiceTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceTotal.Location = new System.Drawing.Point(683, 173);
            this.txtInvoiceTotal.MinimumSize = new System.Drawing.Size(86, 33);
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.Size = new System.Drawing.Size(203, 33);
            this.txtInvoiceTotal.TabIndex = 1129;
            this.txtInvoiceTotal.Text = "0.00";
            this.txtInvoiceTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInvoiceTotal.TextChanged += new System.EventHandler(this.txtInvoiceTotal_TextChanged);
            // 
            // lblPOSInvoiceDiscount
            // 
            this.lblPOSInvoiceDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPOSInvoiceDiscount.AutoSize = true;
            this.lblPOSInvoiceDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOSInvoiceDiscount.Location = new System.Drawing.Point(683, 218);
            this.lblPOSInvoiceDiscount.Name = "lblPOSInvoiceDiscount";
            this.lblPOSInvoiceDiscount.Size = new System.Drawing.Size(115, 21);
            this.lblPOSInvoiceDiscount.TabIndex = 1123;
            this.lblPOSInvoiceDiscount.Text = "Other Discount";
            // 
            // lblPOSInvoiceTotal
            // 
            this.lblPOSInvoiceTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPOSInvoiceTotal.AutoSize = true;
            this.lblPOSInvoiceTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOSInvoiceTotal.Location = new System.Drawing.Point(683, 148);
            this.lblPOSInvoiceTotal.Name = "lblPOSInvoiceTotal";
            this.lblPOSInvoiceTotal.Size = new System.Drawing.Size(44, 21);
            this.lblPOSInvoiceTotal.TabIndex = 1127;
            this.lblPOSInvoiceTotal.Text = "Total";
            // 
            // btnInvoicePrint
            // 
            this.btnInvoicePrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInvoicePrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInvoicePrint.BackColor = System.Drawing.Color.Gray;
            this.btnInvoicePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoicePrint.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoicePrint.ForeColor = System.Drawing.Color.White;
            this.btnInvoicePrint.Location = new System.Drawing.Point(683, 109);
            this.btnInvoicePrint.Name = "btnInvoicePrint";
            this.btnInvoicePrint.Size = new System.Drawing.Size(100, 36);
            this.btnInvoicePrint.TabIndex = 1126;
            this.btnInvoicePrint.Text = "Print";
            this.btnInvoicePrint.UseVisualStyleBackColor = false;
            // 
            // btnInvoiceClear
            // 
            this.btnInvoiceClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInvoiceClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInvoiceClear.BackColor = System.Drawing.Color.Gray;
            this.btnInvoiceClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceClear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceClear.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceClear.Location = new System.Drawing.Point(786, 109);
            this.btnInvoiceClear.Name = "btnInvoiceClear";
            this.btnInvoiceClear.Size = new System.Drawing.Size(100, 36);
            this.btnInvoiceClear.TabIndex = 1125;
            this.btnInvoiceClear.Text = "Clear";
            this.btnInvoiceClear.UseVisualStyleBackColor = false;
            // 
            // txtInvoiceTotalDue
            // 
            this.txtInvoiceTotalDue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInvoiceTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceTotalDue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceTotalDue.Location = new System.Drawing.Point(683, 303);
            this.txtInvoiceTotalDue.Name = "txtInvoiceTotalDue";
            this.txtInvoiceTotalDue.Size = new System.Drawing.Size(203, 43);
            this.txtInvoiceTotalDue.TabIndex = 1122;
            this.txtInvoiceTotalDue.Text = "0.00";
            this.txtInvoiceTotalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInvoiceDiscount
            // 
            this.txtInvoiceDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInvoiceDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceDiscount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceDiscount.Location = new System.Drawing.Point(786, 242);
            this.txtInvoiceDiscount.MinimumSize = new System.Drawing.Size(86, 33);
            this.txtInvoiceDiscount.Name = "txtInvoiceDiscount";
            this.txtInvoiceDiscount.Size = new System.Drawing.Size(100, 33);
            this.txtInvoiceDiscount.TabIndex = 1121;
            this.txtInvoiceDiscount.Text = "0.00";
            this.txtInvoiceDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInvoiceDiscount.TextChanged += new System.EventHandler(this.txtInvoiceDiscount_TextChanged);
            // 
            // lblPOSInvoiceTotalDue
            // 
            this.lblPOSInvoiceTotalDue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPOSInvoiceTotalDue.AutoSize = true;
            this.lblPOSInvoiceTotalDue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOSInvoiceTotalDue.Location = new System.Drawing.Point(679, 279);
            this.lblPOSInvoiceTotalDue.Name = "lblPOSInvoiceTotalDue";
            this.lblPOSInvoiceTotalDue.Size = new System.Drawing.Size(83, 21);
            this.lblPOSInvoiceTotalDue.TabIndex = 1124;
            this.lblPOSInvoiceTotalDue.Text = "Total Due";
            // 
            // txtItemCode
            // 
            // 
            // 
            // 
            this.txtItemCode.CustomButton.Image = null;
            this.txtItemCode.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtItemCode.CustomButton.Name = "";
            this.txtItemCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemCode.CustomButton.TabIndex = 1;
            this.txtItemCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemCode.CustomButton.UseSelectable = true;
            this.txtItemCode.CustomButton.Visible = false;
            this.txtItemCode.Lines = new string[0];
            this.txtItemCode.Location = new System.Drawing.Point(81, 139);
            this.txtItemCode.MaxLength = 32767;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.PasswordChar = '\0';
            this.txtItemCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemCode.SelectedText = "";
            this.txtItemCode.SelectionLength = 0;
            this.txtItemCode.SelectionStart = 0;
            this.txtItemCode.ShortcutsEnabled = true;
            this.txtItemCode.Size = new System.Drawing.Size(96, 23);
            this.txtItemCode.TabIndex = 0;
            this.txtItemCode.UseSelectable = true;
            this.txtItemCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtItemCode.TextChanged += new System.EventHandler(this.txtItemCode_TextChanged);
            this.txtItemCode.Click += new System.EventHandler(this.txtItemCode_Click);
            this.txtItemCode.Leave += new System.EventHandler(this.txtItemCode_Leave);
            // 
            // txtItemName
            // 
            // 
            // 
            // 
            this.txtItemName.CustomButton.Image = null;
            this.txtItemName.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.txtItemName.CustomButton.Name = "";
            this.txtItemName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemName.CustomButton.TabIndex = 1;
            this.txtItemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemName.CustomButton.UseSelectable = true;
            this.txtItemName.CustomButton.Visible = false;
            this.txtItemName.Lines = new string[0];
            this.txtItemName.Location = new System.Drawing.Point(183, 139);
            this.txtItemName.MaxLength = 32767;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemName.SelectedText = "";
            this.txtItemName.SelectionLength = 0;
            this.txtItemName.SelectionStart = 0;
            this.txtItemName.ShortcutsEnabled = true;
            this.txtItemName.Size = new System.Drawing.Size(113, 23);
            this.txtItemName.TabIndex = 1141;
            this.txtItemName.UseSelectable = true;
            this.txtItemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtItemQuantity
            // 
            // 
            // 
            // 
            this.txtItemQuantity.CustomButton.Image = null;
            this.txtItemQuantity.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtItemQuantity.CustomButton.Name = "";
            this.txtItemQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemQuantity.CustomButton.TabIndex = 1;
            this.txtItemQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemQuantity.CustomButton.UseSelectable = true;
            this.txtItemQuantity.CustomButton.Visible = false;
            this.txtItemQuantity.Lines = new string[0];
            this.txtItemQuantity.Location = new System.Drawing.Point(302, 139);
            this.txtItemQuantity.MaxLength = 32767;
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.PasswordChar = '\0';
            this.txtItemQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemQuantity.SelectedText = "";
            this.txtItemQuantity.SelectionLength = 0;
            this.txtItemQuantity.SelectionStart = 0;
            this.txtItemQuantity.ShortcutsEnabled = true;
            this.txtItemQuantity.Size = new System.Drawing.Size(93, 23);
            this.txtItemQuantity.TabIndex = 1;
            this.txtItemQuantity.UseSelectable = true;
            this.txtItemQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtItemQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemQuantity_KeyDown);
            this.txtItemQuantity.Leave += new System.EventHandler(this.txtItemQuantity_Leave);
            // 
            // txtItmUnitPrice
            // 
            // 
            // 
            // 
            this.txtItmUnitPrice.CustomButton.Image = null;
            this.txtItmUnitPrice.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtItmUnitPrice.CustomButton.Name = "";
            this.txtItmUnitPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItmUnitPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItmUnitPrice.CustomButton.TabIndex = 1;
            this.txtItmUnitPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItmUnitPrice.CustomButton.UseSelectable = true;
            this.txtItmUnitPrice.CustomButton.Visible = false;
            this.txtItmUnitPrice.Lines = new string[0];
            this.txtItmUnitPrice.Location = new System.Drawing.Point(468, 139);
            this.txtItmUnitPrice.MaxLength = 32767;
            this.txtItmUnitPrice.Name = "txtItmUnitPrice";
            this.txtItmUnitPrice.PasswordChar = '\0';
            this.txtItmUnitPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItmUnitPrice.SelectedText = "";
            this.txtItmUnitPrice.SelectionLength = 0;
            this.txtItmUnitPrice.SelectionStart = 0;
            this.txtItmUnitPrice.ShortcutsEnabled = true;
            this.txtItmUnitPrice.Size = new System.Drawing.Size(93, 23);
            this.txtItmUnitPrice.TabIndex = 1141;
            this.txtItmUnitPrice.UseSelectable = true;
            this.txtItmUnitPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItmUnitPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSubTotal
            // 
            // 
            // 
            // 
            this.txtSubTotal.CustomButton.Image = null;
            this.txtSubTotal.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtSubTotal.CustomButton.Name = "";
            this.txtSubTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubTotal.CustomButton.TabIndex = 1;
            this.txtSubTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubTotal.CustomButton.UseSelectable = true;
            this.txtSubTotal.CustomButton.Visible = false;
            this.txtSubTotal.Lines = new string[0];
            this.txtSubTotal.Location = new System.Drawing.Point(567, 139);
            this.txtSubTotal.MaxLength = 32767;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.PasswordChar = '\0';
            this.txtSubTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubTotal.SelectedText = "";
            this.txtSubTotal.SelectionLength = 0;
            this.txtSubTotal.SelectionStart = 0;
            this.txtSubTotal.ShortcutsEnabled = true;
            this.txtSubTotal.Size = new System.Drawing.Size(102, 23);
            this.txtSubTotal.TabIndex = 1141;
            this.txtSubTotal.UseSelectable = true;
            this.txtSubTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUoM
            // 
            // 
            // 
            // 
            this.txtUoM.CustomButton.Image = null;
            this.txtUoM.CustomButton.Location = new System.Drawing.Point(39, 1);
            this.txtUoM.CustomButton.Name = "";
            this.txtUoM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUoM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUoM.CustomButton.TabIndex = 1;
            this.txtUoM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUoM.CustomButton.UseSelectable = true;
            this.txtUoM.CustomButton.Visible = false;
            this.txtUoM.Lines = new string[0];
            this.txtUoM.Location = new System.Drawing.Point(401, 139);
            this.txtUoM.MaxLength = 32767;
            this.txtUoM.Name = "txtUoM";
            this.txtUoM.PasswordChar = '\0';
            this.txtUoM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUoM.SelectedText = "";
            this.txtUoM.SelectionLength = 0;
            this.txtUoM.SelectionStart = 0;
            this.txtUoM.ShortcutsEnabled = true;
            this.txtUoM.Size = new System.Drawing.Size(61, 23);
            this.txtUoM.TabIndex = 1141;
            this.txtUoM.UseSelectable = true;
            this.txtUoM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUoM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgdInvoItemSearch
            // 
            this.dgdInvoItemSearch.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgdInvoItemSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdInvoItemSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdInvoItemSearch.Location = new System.Drawing.Point(81, 168);
            this.dgdInvoItemSearch.Name = "dgdInvoItemSearch";
            this.dgdInvoItemSearch.Size = new System.Drawing.Size(215, 150);
            this.dgdInvoItemSearch.TabIndex = 1142;
            this.dgdInvoItemSearch.Visible = false;
            this.dgdInvoItemSearch.Leave += new System.EventHandler(this.dgdInvoItemSearch_Leave);
            this.dgdInvoItemSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgdInvoItemSearch_MouseDoubleClick);
            // 
            // txtInvoiceID
            // 
            // 
            // 
            // 
            this.txtInvoiceID.CustomButton.Image = null;
            this.txtInvoiceID.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtInvoiceID.CustomButton.Name = "";
            this.txtInvoiceID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInvoiceID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoiceID.CustomButton.TabIndex = 1;
            this.txtInvoiceID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceID.CustomButton.UseSelectable = true;
            this.txtInvoiceID.CustomButton.Visible = false;
            this.txtInvoiceID.Lines = new string[0];
            this.txtInvoiceID.Location = new System.Drawing.Point(127, 110);
            this.txtInvoiceID.MaxLength = 32767;
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.PasswordChar = '\0';
            this.txtInvoiceID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceID.SelectedText = "";
            this.txtInvoiceID.SelectionLength = 0;
            this.txtInvoiceID.SelectionStart = 0;
            this.txtInvoiceID.ShortcutsEnabled = true;
            this.txtInvoiceID.Size = new System.Drawing.Size(212, 23);
            this.txtInvoiceID.TabIndex = 1141;
            this.txtInvoiceID.UseSelectable = true;
            this.txtInvoiceID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoiceID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInvoiceID.TextChanged += new System.EventHandler(this.txtItemCode_TextChanged);
            this.txtInvoiceID.Click += new System.EventHandler(this.txtItemCode_Click);
            this.txtInvoiceID.Leave += new System.EventHandler(this.txtItemCode_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 1127;
            this.label1.Text = "Invoice No";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 1127;
            this.label2.Text = "Customer";
            // 
            // txtCustomer
            // 
            // 
            // 
            // 
            this.txtCustomer.CustomButton.Image = null;
            this.txtCustomer.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtCustomer.CustomButton.Name = "";
            this.txtCustomer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomer.CustomButton.TabIndex = 1;
            this.txtCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomer.CustomButton.UseSelectable = true;
            this.txtCustomer.CustomButton.Visible = false;
            this.txtCustomer.Lines = new string[0];
            this.txtCustomer.Location = new System.Drawing.Point(457, 110);
            this.txtCustomer.MaxLength = 32767;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.PasswordChar = '\0';
            this.txtCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomer.SelectedText = "";
            this.txtCustomer.SelectionLength = 0;
            this.txtCustomer.SelectionStart = 0;
            this.txtCustomer.ShortcutsEnabled = true;
            this.txtCustomer.Size = new System.Drawing.Size(212, 23);
            this.txtCustomer.TabIndex = 1141;
            this.txtCustomer.UseSelectable = true;
            this.txtCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomer.TextChanged += new System.EventHandler(this.txtItemCode_TextChanged);
            this.txtCustomer.Click += new System.EventHandler(this.txtItemCode_Click);
            this.txtCustomer.Leave += new System.EventHandler(this.txtItemCode_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(679, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 1131;
            this.label3.Text = "Paying Amount";
            // 
            // txtPayingAmount
            // 
            this.txtPayingAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPayingAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPayingAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayingAmount.Location = new System.Drawing.Point(683, 513);
            this.txtPayingAmount.MinimumSize = new System.Drawing.Size(86, 33);
            this.txtPayingAmount.Name = "txtPayingAmount";
            this.txtPayingAmount.Size = new System.Drawing.Size(203, 33);
            this.txtPayingAmount.TabIndex = 1132;
            this.txtPayingAmount.Text = "0.00";
            this.txtPayingAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPayingAmount.TextChanged += new System.EventHandler(this.txtPayingAmount_TextChanged);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 678);
            this.Controls.Add(this.dgdInvoItemSearch);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtItmUnitPrice);
            this.Controls.Add(this.txtUoM);
            this.Controls.Add(this.txtItemQuantity);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtInvoiceID);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtInvoDiscRate);
            this.Controls.Add(this.cboInvoicePaymentMethod);
            this.Controls.Add(this.lblPOSInvoicePaymentMethod);
            this.Controls.Add(this.txtInvoicePaidAmount);
            this.Controls.Add(this.lblPOSInvoicePaidAmount);
            this.Controls.Add(this.txtPayingAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInvoiceBalance);
            this.Controls.Add(this.lblPOSInvoiceBalance);
            this.Controls.Add(this.txtInvoiceTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPOSInvoiceDiscount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPOSInvoiceTotal);
            this.Controls.Add(this.btnInvoicePrint);
            this.Controls.Add(this.btnInvoiceClear);
            this.Controls.Add(this.txtInvoiceTotalDue);
            this.Controls.Add(this.txtInvoiceDiscount);
            this.Controls.Add(this.lblPOSInvoiceTotalDue);
            this.Controls.Add(this.dgdInvoice);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.btnInvoedit);
            this.Controls.Add(this.btnInvoview);
            this.Controls.Add(this.btnInvoDelete);
            this.Controls.Add(this.btnInvoNew);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnInvocancel);
            this.Controls.Add(this.btnInvosave);
            this.Controls.Add(this.txtInvoicesearch);
            this.Name = "frmInvoice";
            this.Text = "frmInvoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdInvoItemSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroButton btnInvoedit;
        private MetroFramework.Controls.MetroButton btnInvoview;
        private MetroFramework.Controls.MetroButton btnInvoDelete;
        private MetroFramework.Controls.MetroButton btnInvoNew;
        private MetroFramework.Controls.MetroButton btnnew;
        private MetroFramework.Controls.MetroButton btnInvocancel;
        private MetroFramework.Controls.MetroButton btnInvosave;
        private MetroFramework.Controls.MetroTextBox txtInvoicesearch;
        private MetroFramework.Controls.MetroGrid dgdInvoice;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtInvoDiscRate;
        private MetroFramework.Controls.MetroComboBox cboInvoicePaymentMethod;
        private System.Windows.Forms.Label lblPOSInvoicePaymentMethod;
        private System.Windows.Forms.TextBox txtInvoicePaidAmount;
        private System.Windows.Forms.Label lblPOSInvoicePaidAmount;
        private System.Windows.Forms.TextBox txtInvoiceBalance;
        private System.Windows.Forms.Label lblPOSInvoiceBalance;
        private System.Windows.Forms.TextBox txtInvoiceTotal;
        private System.Windows.Forms.Label lblPOSInvoiceDiscount;
        private System.Windows.Forms.Label lblPOSInvoiceTotal;
        private System.Windows.Forms.Button btnInvoicePrint;
        private System.Windows.Forms.Button btnInvoiceClear;
        private System.Windows.Forms.TextBox txtInvoiceTotalDue;
        private System.Windows.Forms.TextBox txtInvoiceDiscount;
        private System.Windows.Forms.Label lblPOSInvoiceTotalDue;
        private MetroFramework.Controls.MetroTextBox txtItemCode;
        private MetroFramework.Controls.MetroTextBox txtItemName;
        private MetroFramework.Controls.MetroTextBox txtItemQuantity;
        private MetroFramework.Controls.MetroTextBox txtItmUnitPrice;
        private MetroFramework.Controls.MetroTextBox txtSubTotal;
        private MetroFramework.Controls.MetroTextBox txtUoM;
        private System.Windows.Forms.DataGridView dgdInvoItemSearch;
        private MetroFramework.Controls.MetroTextBox txtInvoiceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceItemUoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceSubTotal;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPayingAmount;
    }
}