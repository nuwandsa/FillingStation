namespace FillingStation.UI.Purchasing
{
    partial class frmPO
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.btnPOedit = new MetroFramework.Controls.MetroButton();
            this.btnPOview = new MetroFramework.Controls.MetroButton();
            this.btnPODelete = new MetroFramework.Controls.MetroButton();
            this.btnPONew = new MetroFramework.Controls.MetroButton();
            this.btnnew = new MetroFramework.Controls.MetroButton();
            this.btnPOcancel = new MetroFramework.Controls.MetroButton();
            this.btnPOsave = new MetroFramework.Controls.MetroButton();
            this.txtPOsearch = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtPONO = new MetroFramework.Controls.MetroTextBox();
            this.lblPONo = new MetroFramework.Controls.MetroLabel();
            this.lblPOShipToAddress = new MetroFramework.Controls.MetroLabel();
            this.txtPODliverToAddress = new MetroFramework.Controls.MetroTextBox();
            this.lblPOSuplierName = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtPOSuplierName = new MetroFramework.Controls.MetroTextBox();
            this.txtPOSubTotal = new MetroFramework.Controls.MetroTextBox();
            this.txtPOItmUnitPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtPOUoM = new MetroFramework.Controls.MetroTextBox();
            this.txtPOItemQuantity = new MetroFramework.Controls.MetroTextBox();
            this.txtPOItemName = new MetroFramework.Controls.MetroTextBox();
            this.txtPOItemCode = new MetroFramework.Controls.MetroTextBox();
            this.dgdPO = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtPODate = new MetroFramework.Controls.MetroTextBox();
            this.dgdPOItemSearch = new System.Windows.Forms.DataGridView();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.colPOItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPOItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPOQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPOItemUoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPOUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPOSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdPOItemSearch)).BeginInit();
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
            this.metroTextBox3.Location = new System.Drawing.Point(20, 68);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(850, 2);
            this.metroTextBox3.TabIndex = 26;
            this.metroTextBox3.Text = "metroTextBox3";
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnPOedit
            // 
            this.btnPOedit.Location = new System.Drawing.Point(573, 22);
            this.btnPOedit.Name = "btnPOedit";
            this.btnPOedit.Size = new System.Drawing.Size(50, 40);
            this.btnPOedit.TabIndex = 25;
            this.btnPOedit.Text = "Edit";
            this.btnPOedit.UseSelectable = true;
            // 
            // btnPOview
            // 
            this.btnPOview.Location = new System.Drawing.Point(516, 22);
            this.btnPOview.Name = "btnPOview";
            this.btnPOview.Size = new System.Drawing.Size(50, 40);
            this.btnPOview.TabIndex = 24;
            this.btnPOview.Text = "View";
            this.btnPOview.UseSelectable = true;
            // 
            // btnPODelete
            // 
            this.btnPODelete.Location = new System.Drawing.Point(459, 22);
            this.btnPODelete.Name = "btnPODelete";
            this.btnPODelete.Size = new System.Drawing.Size(50, 40);
            this.btnPODelete.TabIndex = 21;
            this.btnPODelete.Text = "Delete";
            this.btnPODelete.UseSelectable = true;
            // 
            // btnPONew
            // 
            this.btnPONew.Location = new System.Drawing.Point(402, 22);
            this.btnPONew.Name = "btnPONew";
            this.btnPONew.Size = new System.Drawing.Size(50, 40);
            this.btnPONew.TabIndex = 22;
            this.btnPONew.Text = "New";
            this.btnPONew.UseSelectable = true;
            this.btnPONew.Click += new System.EventHandler(this.btnPONew_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(402, 22);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(50, 40);
            this.btnnew.TabIndex = 23;
            this.btnnew.Text = "New";
            this.btnnew.UseSelectable = true;
            // 
            // btnPOcancel
            // 
            this.btnPOcancel.Location = new System.Drawing.Point(223, 22);
            this.btnPOcancel.Name = "btnPOcancel";
            this.btnPOcancel.Size = new System.Drawing.Size(50, 40);
            this.btnPOcancel.TabIndex = 20;
            this.btnPOcancel.Text = "Cancel";
            this.btnPOcancel.UseSelectable = true;
            // 
            // btnPOsave
            // 
            this.btnPOsave.Location = new System.Drawing.Point(167, 22);
            this.btnPOsave.Name = "btnPOsave";
            this.btnPOsave.Size = new System.Drawing.Size(50, 40);
            this.btnPOsave.TabIndex = 19;
            this.btnPOsave.Text = "Save";
            this.btnPOsave.UseSelectable = true;
            this.btnPOsave.Click += new System.EventHandler(this.btnPOsave_Click);
            // 
            // txtPOsearch
            // 
            // 
            // 
            // 
            this.txtPOsearch.CustomButton.Image = null;
            this.txtPOsearch.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtPOsearch.CustomButton.Name = "";
            this.txtPOsearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPOsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPOsearch.CustomButton.TabIndex = 1;
            this.txtPOsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPOsearch.CustomButton.UseSelectable = true;
            this.txtPOsearch.CustomButton.Visible = false;
            this.txtPOsearch.Lines = new string[0];
            this.txtPOsearch.Location = new System.Drawing.Point(649, 39);
            this.txtPOsearch.MaxLength = 32767;
            this.txtPOsearch.Name = "txtPOsearch";
            this.txtPOsearch.PasswordChar = '\0';
            this.txtPOsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPOsearch.SelectedText = "";
            this.txtPOsearch.SelectionLength = 0;
            this.txtPOsearch.SelectionStart = 0;
            this.txtPOsearch.ShortcutsEnabled = true;
            this.txtPOsearch.Size = new System.Drawing.Size(213, 23);
            this.txtPOsearch.TabIndex = 18;
            this.txtPOsearch.UseSelectable = true;
            this.txtPOsearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPOsearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.txtPONO);
            this.metroPanel1.Controls.Add(this.lblPONo);
            this.metroPanel1.Controls.Add(this.lblPOShipToAddress);
            this.metroPanel1.Controls.Add(this.txtPODliverToAddress);
            this.metroPanel1.Controls.Add(this.lblPOSuplierName);
            this.metroPanel1.Controls.Add(this.txtPOSuplierName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 123);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 192);
            this.metroPanel1.TabIndex = 56;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtPONO
            // 
            // 
            // 
            // 
            this.txtPONO.CustomButton.Image = null;
            this.txtPONO.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txtPONO.CustomButton.Name = "";
            this.txtPONO.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPONO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPONO.CustomButton.TabIndex = 1;
            this.txtPONO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPONO.CustomButton.UseSelectable = true;
            this.txtPONO.CustomButton.Visible = false;
            this.txtPONO.Lines = new string[0];
            this.txtPONO.Location = new System.Drawing.Point(98, 12);
            this.txtPONO.MaxLength = 32767;
            this.txtPONO.Name = "txtPONO";
            this.txtPONO.PasswordChar = '\0';
            this.txtPONO.ReadOnly = true;
            this.txtPONO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPONO.SelectedText = "";
            this.txtPONO.SelectionLength = 0;
            this.txtPONO.SelectionStart = 0;
            this.txtPONO.ShortcutsEnabled = true;
            this.txtPONO.Size = new System.Drawing.Size(97, 23);
            this.txtPONO.TabIndex = 28;
            this.txtPONO.UseSelectable = true;
            this.txtPONO.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPONO.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPONo
            // 
            this.lblPONo.AutoSize = true;
            this.lblPONo.Location = new System.Drawing.Point(3, 14);
            this.lblPONo.Name = "lblPONo";
            this.lblPONo.Size = new System.Drawing.Size(53, 19);
            this.lblPONo.TabIndex = 29;
            this.lblPONo.Text = "PO NO";
            // 
            // lblPOShipToAddress
            // 
            this.lblPOShipToAddress.AutoSize = true;
            this.lblPOShipToAddress.Location = new System.Drawing.Point(26, 70);
            this.lblPOShipToAddress.Name = "lblPOShipToAddress";
            this.lblPOShipToAddress.Size = new System.Drawing.Size(102, 19);
            this.lblPOShipToAddress.TabIndex = 7;
            this.lblPOShipToAddress.Text = "Ship To Address";
            // 
            // txtPODliverToAddress
            // 
            // 
            // 
            // 
            this.txtPODliverToAddress.CustomButton.Image = null;
            this.txtPODliverToAddress.CustomButton.Location = new System.Drawing.Point(88, 2);
            this.txtPODliverToAddress.CustomButton.Name = "";
            this.txtPODliverToAddress.CustomButton.Size = new System.Drawing.Size(87, 87);
            this.txtPODliverToAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPODliverToAddress.CustomButton.TabIndex = 1;
            this.txtPODliverToAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPODliverToAddress.CustomButton.UseSelectable = true;
            this.txtPODliverToAddress.CustomButton.Visible = false;
            this.txtPODliverToAddress.Lines = new string[0];
            this.txtPODliverToAddress.Location = new System.Drawing.Point(11, 84);
            this.txtPODliverToAddress.MaxLength = 32767;
            this.txtPODliverToAddress.Multiline = true;
            this.txtPODliverToAddress.Name = "txtPODliverToAddress";
            this.txtPODliverToAddress.PasswordChar = '\0';
            this.txtPODliverToAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPODliverToAddress.SelectedText = "";
            this.txtPODliverToAddress.SelectionLength = 0;
            this.txtPODliverToAddress.SelectionStart = 0;
            this.txtPODliverToAddress.ShortcutsEnabled = true;
            this.txtPODliverToAddress.Size = new System.Drawing.Size(178, 92);
            this.txtPODliverToAddress.TabIndex = 6;
            this.txtPODliverToAddress.UseSelectable = true;
            this.txtPODliverToAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPODliverToAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPOSuplierName
            // 
            this.lblPOSuplierName.AutoScroll = true;
            this.lblPOSuplierName.AutoScrollMinSize = new System.Drawing.Size(83, 23);
            this.lblPOSuplierName.AutoSize = false;
            this.lblPOSuplierName.BackColor = System.Drawing.SystemColors.Window;
            this.lblPOSuplierName.Location = new System.Drawing.Point(6, 42);
            this.lblPOSuplierName.Name = "lblPOSuplierName";
            this.lblPOSuplierName.Size = new System.Drawing.Size(92, 23);
            this.lblPOSuplierName.TabIndex = 4;
            this.lblPOSuplierName.Text = "Supplier Name";
            // 
            // txtPOSuplierName
            // 
            // 
            // 
            // 
            this.txtPOSuplierName.CustomButton.Image = null;
            this.txtPOSuplierName.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtPOSuplierName.CustomButton.Name = "";
            this.txtPOSuplierName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPOSuplierName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPOSuplierName.CustomButton.TabIndex = 1;
            this.txtPOSuplierName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPOSuplierName.CustomButton.UseSelectable = true;
            this.txtPOSuplierName.CustomButton.Visible = false;
            this.txtPOSuplierName.Lines = new string[0];
            this.txtPOSuplierName.Location = new System.Drawing.Point(98, 44);
            this.txtPOSuplierName.MaxLength = 32767;
            this.txtPOSuplierName.Name = "txtPOSuplierName";
            this.txtPOSuplierName.PasswordChar = '\0';
            this.txtPOSuplierName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPOSuplierName.SelectedText = "";
            this.txtPOSuplierName.SelectionLength = 0;
            this.txtPOSuplierName.SelectionStart = 0;
            this.txtPOSuplierName.ShortcutsEnabled = true;
            this.txtPOSuplierName.Size = new System.Drawing.Size(94, 23);
            this.txtPOSuplierName.TabIndex = 3;
            this.txtPOSuplierName.UseSelectable = true;
            this.txtPOSuplierName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPOSuplierName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPOSubTotal
            // 
            // 
            // 
            // 
            this.txtPOSubTotal.CustomButton.Image = null;
            this.txtPOSubTotal.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtPOSubTotal.CustomButton.Name = "";
            this.txtPOSubTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPOSubTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPOSubTotal.CustomButton.TabIndex = 1;
            this.txtPOSubTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPOSubTotal.CustomButton.UseSelectable = true;
            this.txtPOSubTotal.CustomButton.Visible = false;
            this.txtPOSubTotal.Lines = new string[] {
        "0.00"};
            this.txtPOSubTotal.Location = new System.Drawing.Point(768, 83);
            this.txtPOSubTotal.MaxLength = 32767;
            this.txtPOSubTotal.Name = "txtPOSubTotal";
            this.txtPOSubTotal.PasswordChar = '\0';
            this.txtPOSubTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPOSubTotal.SelectedText = "";
            this.txtPOSubTotal.SelectionLength = 0;
            this.txtPOSubTotal.SelectionStart = 0;
            this.txtPOSubTotal.ShortcutsEnabled = true;
            this.txtPOSubTotal.Size = new System.Drawing.Size(102, 23);
            this.txtPOSubTotal.TabIndex = 1145;
            this.txtPOSubTotal.Text = "0.00";
            this.txtPOSubTotal.UseSelectable = true;
            this.txtPOSubTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPOSubTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPOItmUnitPrice
            // 
            // 
            // 
            // 
            this.txtPOItmUnitPrice.CustomButton.Image = null;
            this.txtPOItmUnitPrice.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtPOItmUnitPrice.CustomButton.Name = "";
            this.txtPOItmUnitPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPOItmUnitPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPOItmUnitPrice.CustomButton.TabIndex = 1;
            this.txtPOItmUnitPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPOItmUnitPrice.CustomButton.UseSelectable = true;
            this.txtPOItmUnitPrice.CustomButton.Visible = false;
            this.txtPOItmUnitPrice.Lines = new string[] {
        "0.00"};
            this.txtPOItmUnitPrice.Location = new System.Drawing.Point(669, 83);
            this.txtPOItmUnitPrice.MaxLength = 32767;
            this.txtPOItmUnitPrice.Name = "txtPOItmUnitPrice";
            this.txtPOItmUnitPrice.PasswordChar = '\0';
            this.txtPOItmUnitPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPOItmUnitPrice.SelectedText = "";
            this.txtPOItmUnitPrice.SelectionLength = 0;
            this.txtPOItmUnitPrice.SelectionStart = 0;
            this.txtPOItmUnitPrice.ShortcutsEnabled = true;
            this.txtPOItmUnitPrice.Size = new System.Drawing.Size(93, 23);
            this.txtPOItmUnitPrice.TabIndex = 1146;
            this.txtPOItmUnitPrice.Text = "0.00";
            this.txtPOItmUnitPrice.UseSelectable = true;
            this.txtPOItmUnitPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPOItmUnitPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPOUoM
            // 
            // 
            // 
            // 
            this.txtPOUoM.CustomButton.Image = null;
            this.txtPOUoM.CustomButton.Location = new System.Drawing.Point(39, 1);
            this.txtPOUoM.CustomButton.Name = "";
            this.txtPOUoM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPOUoM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPOUoM.CustomButton.TabIndex = 1;
            this.txtPOUoM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPOUoM.CustomButton.UseSelectable = true;
            this.txtPOUoM.CustomButton.Visible = false;
            this.txtPOUoM.Lines = new string[0];
            this.txtPOUoM.Location = new System.Drawing.Point(602, 83);
            this.txtPOUoM.MaxLength = 32767;
            this.txtPOUoM.Name = "txtPOUoM";
            this.txtPOUoM.PasswordChar = '\0';
            this.txtPOUoM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPOUoM.SelectedText = "";
            this.txtPOUoM.SelectionLength = 0;
            this.txtPOUoM.SelectionStart = 0;
            this.txtPOUoM.ShortcutsEnabled = true;
            this.txtPOUoM.Size = new System.Drawing.Size(61, 23);
            this.txtPOUoM.TabIndex = 1147;
            this.txtPOUoM.UseSelectable = true;
            this.txtPOUoM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPOUoM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPOItemQuantity
            // 
            // 
            // 
            // 
            this.txtPOItemQuantity.CustomButton.Image = null;
            this.txtPOItemQuantity.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtPOItemQuantity.CustomButton.Name = "";
            this.txtPOItemQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPOItemQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPOItemQuantity.CustomButton.TabIndex = 1;
            this.txtPOItemQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPOItemQuantity.CustomButton.UseSelectable = true;
            this.txtPOItemQuantity.CustomButton.Visible = false;
            this.txtPOItemQuantity.Lines = new string[] {
        "0.00"};
            this.txtPOItemQuantity.Location = new System.Drawing.Point(503, 83);
            this.txtPOItemQuantity.MaxLength = 32767;
            this.txtPOItemQuantity.Name = "txtPOItemQuantity";
            this.txtPOItemQuantity.PasswordChar = '\0';
            this.txtPOItemQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPOItemQuantity.SelectedText = "";
            this.txtPOItemQuantity.SelectionLength = 0;
            this.txtPOItemQuantity.SelectionStart = 0;
            this.txtPOItemQuantity.ShortcutsEnabled = true;
            this.txtPOItemQuantity.Size = new System.Drawing.Size(93, 23);
            this.txtPOItemQuantity.TabIndex = 1143;
            this.txtPOItemQuantity.Text = "0.00";
            this.txtPOItemQuantity.UseSelectable = true;
            this.txtPOItemQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPOItemQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPOItemQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPOItemQuantity_KeyDown);
            // 
            // txtPOItemName
            // 
            // 
            // 
            // 
            this.txtPOItemName.CustomButton.Image = null;
            this.txtPOItemName.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.txtPOItemName.CustomButton.Name = "";
            this.txtPOItemName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPOItemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPOItemName.CustomButton.TabIndex = 1;
            this.txtPOItemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPOItemName.CustomButton.UseSelectable = true;
            this.txtPOItemName.CustomButton.Visible = false;
            this.txtPOItemName.Lines = new string[0];
            this.txtPOItemName.Location = new System.Drawing.Point(384, 83);
            this.txtPOItemName.MaxLength = 32767;
            this.txtPOItemName.Name = "txtPOItemName";
            this.txtPOItemName.PasswordChar = '\0';
            this.txtPOItemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPOItemName.SelectedText = "";
            this.txtPOItemName.SelectionLength = 0;
            this.txtPOItemName.SelectionStart = 0;
            this.txtPOItemName.ShortcutsEnabled = true;
            this.txtPOItemName.Size = new System.Drawing.Size(113, 23);
            this.txtPOItemName.TabIndex = 1148;
            this.txtPOItemName.UseSelectable = true;
            this.txtPOItemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPOItemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPOItemCode
            // 
            // 
            // 
            // 
            this.txtPOItemCode.CustomButton.Image = null;
            this.txtPOItemCode.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtPOItemCode.CustomButton.Name = "";
            this.txtPOItemCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPOItemCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPOItemCode.CustomButton.TabIndex = 1;
            this.txtPOItemCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPOItemCode.CustomButton.UseSelectable = true;
            this.txtPOItemCode.CustomButton.Visible = false;
            this.txtPOItemCode.Lines = new string[0];
            this.txtPOItemCode.Location = new System.Drawing.Point(282, 83);
            this.txtPOItemCode.MaxLength = 32767;
            this.txtPOItemCode.Name = "txtPOItemCode";
            this.txtPOItemCode.PasswordChar = '\0';
            this.txtPOItemCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPOItemCode.SelectedText = "";
            this.txtPOItemCode.SelectionLength = 0;
            this.txtPOItemCode.SelectionStart = 0;
            this.txtPOItemCode.ShortcutsEnabled = true;
            this.txtPOItemCode.Size = new System.Drawing.Size(96, 23);
            this.txtPOItemCode.TabIndex = 1142;
            this.txtPOItemCode.UseSelectable = true;
            this.txtPOItemCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPOItemCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPOItemCode.TextChanged += new System.EventHandler(this.txtPOItemCode_TextChanged);
            this.txtPOItemCode.Click += new System.EventHandler(this.txtPOItemCode_Click);
            this.txtPOItemCode.Leave += new System.EventHandler(this.txtPOItemCode_Leave);
            // 
            // dgdPO
            // 
            this.dgdPO.AllowUserToResizeRows = false;
            this.dgdPO.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgdPO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdPO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgdPO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdPO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgdPO.ColumnHeadersHeight = 20;
            this.dgdPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgdPO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPOItemCode,
            this.colPOItemName,
            this.colPOQuantity,
            this.colPOItemUoM,
            this.colPOUnitPrice,
            this.colPOSubTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgdPO.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgdPO.EnableHeadersVisualStyles = false;
            this.dgdPO.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgdPO.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgdPO.Location = new System.Drawing.Point(237, 123);
            this.dgdPO.Name = "dgdPO";
            this.dgdPO.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdPO.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgdPO.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgdPO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdPO.Size = new System.Drawing.Size(633, 285);
            this.dgdPO.TabIndex = 1144;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 334);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 1149;
            this.metroLabel1.Text = "Date";
            // 
            // txtPODate
            // 
            // 
            // 
            // 
            this.txtPODate.CustomButton.Image = null;
            this.txtPODate.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtPODate.CustomButton.Name = "";
            this.txtPODate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPODate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPODate.CustomButton.TabIndex = 1;
            this.txtPODate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPODate.CustomButton.UseSelectable = true;
            this.txtPODate.CustomButton.Visible = false;
            this.txtPODate.Lines = new string[0];
            this.txtPODate.Location = new System.Drawing.Point(77, 332);
            this.txtPODate.MaxLength = 32767;
            this.txtPODate.Name = "txtPODate";
            this.txtPODate.PasswordChar = '\0';
            this.txtPODate.ReadOnly = true;
            this.txtPODate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPODate.SelectedText = "";
            this.txtPODate.SelectionLength = 0;
            this.txtPODate.SelectionStart = 0;
            this.txtPODate.ShortcutsEnabled = true;
            this.txtPODate.Size = new System.Drawing.Size(146, 23);
            this.txtPODate.TabIndex = 28;
            this.txtPODate.UseSelectable = true;
            this.txtPODate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPODate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgdPOItemSearch
            // 
            this.dgdPOItemSearch.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgdPOItemSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdPOItemSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdPOItemSearch.Location = new System.Drawing.Point(282, 109);
            this.dgdPOItemSearch.Name = "dgdPOItemSearch";
            this.dgdPOItemSearch.Size = new System.Drawing.Size(215, 150);
            this.dgdPOItemSearch.TabIndex = 1150;
            this.dgdPOItemSearch.Visible = false;
            this.dgdPOItemSearch.Leave += new System.EventHandler(this.dgdPOItemSearch_Leave);
            this.dgdPOItemSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgdPOItemSearch_MouseDoubleClick);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(35, 385);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ReadOnly = true;
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(188, 23);
            this.metroTextBox1.TabIndex = 28;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 363);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 1149;
            this.metroLabel2.Text = "ReceivedDate";
            // 
            // colPOItemCode
            // 
            this.colPOItemCode.HeaderText = "Item Code";
            this.colPOItemCode.Name = "colPOItemCode";
            this.colPOItemCode.ToolTipText = "hello";
            // 
            // colPOItemName
            // 
            this.colPOItemName.HeaderText = "Item Name";
            this.colPOItemName.Name = "colPOItemName";
            this.colPOItemName.Width = 120;
            // 
            // colPOQuantity
            // 
            this.colPOQuantity.HeaderText = "Quantity";
            this.colPOQuantity.Name = "colPOQuantity";
            // 
            // colPOItemUoM
            // 
            this.colPOItemUoM.HeaderText = "UoM";
            this.colPOItemUoM.Name = "colPOItemUoM";
            this.colPOItemUoM.Width = 70;
            // 
            // colPOUnitPrice
            // 
            this.colPOUnitPrice.HeaderText = "Unit Price";
            this.colPOUnitPrice.Name = "colPOUnitPrice";
            // 
            // colPOSubTotal
            // 
            this.colPOSubTotal.HeaderText = "Sub Total";
            this.colPOSubTotal.Name = "colPOSubTotal";
            // 
            // frmPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 678);
            this.Controls.Add(this.dgdPOItemSearch);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtPOSubTotal);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.txtPODate);
            this.Controls.Add(this.txtPOItmUnitPrice);
            this.Controls.Add(this.txtPOUoM);
            this.Controls.Add(this.txtPOItemQuantity);
            this.Controls.Add(this.txtPOItemName);
            this.Controls.Add(this.txtPOItemCode);
            this.Controls.Add(this.dgdPO);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.btnPOedit);
            this.Controls.Add(this.btnPOview);
            this.Controls.Add(this.btnPODelete);
            this.Controls.Add(this.btnPONew);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnPOcancel);
            this.Controls.Add(this.btnPOsave);
            this.Controls.Add(this.txtPOsearch);
            this.Name = "frmPO";
            this.Text = "frmPO";
            this.Load += new System.EventHandler(this.frmPO_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdPOItemSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroButton btnPOedit;
        private MetroFramework.Controls.MetroButton btnPOview;
        private MetroFramework.Controls.MetroButton btnPODelete;
        private MetroFramework.Controls.MetroButton btnPONew;
        private MetroFramework.Controls.MetroButton btnnew;
        private MetroFramework.Controls.MetroButton btnPOcancel;
        private MetroFramework.Controls.MetroButton btnPOsave;
        private MetroFramework.Controls.MetroTextBox txtPOsearch;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtPONO;
        private MetroFramework.Controls.MetroLabel lblPONo;
        private MetroFramework.Controls.MetroLabel lblPOShipToAddress;
        private MetroFramework.Controls.MetroTextBox txtPODliverToAddress;
        private MetroFramework.Drawing.Html.HtmlLabel lblPOSuplierName;
        private MetroFramework.Controls.MetroTextBox txtPOSuplierName;
        private MetroFramework.Controls.MetroTextBox txtPOSubTotal;
        private MetroFramework.Controls.MetroTextBox txtPOItmUnitPrice;
        private MetroFramework.Controls.MetroTextBox txtPOUoM;
        private MetroFramework.Controls.MetroTextBox txtPOItemQuantity;
        private MetroFramework.Controls.MetroTextBox txtPOItemName;
        private MetroFramework.Controls.MetroTextBox txtPOItemCode;
        private MetroFramework.Controls.MetroGrid dgdPO;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPODate;
        private System.Windows.Forms.DataGridView dgdPOItemSearch;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOItemUoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOSubTotal;
    }
}