namespace FillingStation.UI.master
{
    partial class frmItem
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
            this.txtItemID = new MetroFramework.Controls.MetroTextBox();
            this.txtsearch = new MetroFramework.Controls.MetroTextBox();
            this.btnsave = new MetroFramework.Controls.MetroButton();
            this.btncancel = new MetroFramework.Controls.MetroButton();
            this.btnnew = new MetroFramework.Controls.MetroButton();
            this.btnview = new MetroFramework.Controls.MetroButton();
            this.btnedit = new MetroFramework.Controls.MetroButton();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtItemName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtother = new MetroFramework.Controls.MetroRadioButton();
            this.rbtlubricant = new MetroFramework.Controls.MetroRadioButton();
            this.txtReOrderLevel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtcurrrentStock = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cmbItemUoM = new MetroFramework.Controls.MetroComboBox();
            this.txtItmCostPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtItemSellingPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtItemDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.dgdItemSearch = new System.Windows.Forms.DataGridView();
            this.btn = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdItemSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemID
            // 
            // 
            // 
            // 
            this.txtItemID.CustomButton.Image = null;
            this.txtItemID.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.txtItemID.CustomButton.Name = "";
            this.txtItemID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemID.CustomButton.TabIndex = 1;
            this.txtItemID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemID.CustomButton.UseSelectable = true;
            this.txtItemID.CustomButton.Visible = false;
            this.txtItemID.Lines = new string[0];
            this.txtItemID.Location = new System.Drawing.Point(161, 117);
            this.txtItemID.MaxLength = 32767;
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.PasswordChar = '\0';
            this.txtItemID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemID.SelectedText = "";
            this.txtItemID.SelectionLength = 0;
            this.txtItemID.SelectionStart = 0;
            this.txtItemID.ShortcutsEnabled = true;
            this.txtItemID.Size = new System.Drawing.Size(151, 23);
            this.txtItemID.TabIndex = 0;
            this.txtItemID.UseSelectable = true;
            this.txtItemID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtsearch
            // 
            // 
            // 
            // 
            this.txtsearch.CustomButton.Image = null;
            this.txtsearch.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtsearch.CustomButton.Name = "";
            this.txtsearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsearch.CustomButton.TabIndex = 1;
            this.txtsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsearch.CustomButton.UseSelectable = true;
            this.txtsearch.CustomButton.Visible = false;
            this.txtsearch.Lines = new string[0];
            this.txtsearch.Location = new System.Drawing.Point(610, 80);
            this.txtsearch.MaxLength = 32767;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsearch.SelectedText = "";
            this.txtsearch.SelectionLength = 0;
            this.txtsearch.SelectionStart = 0;
            this.txtsearch.ShortcutsEnabled = true;
            this.txtsearch.Size = new System.Drawing.Size(213, 23);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.UseSelectable = true;
            this.txtsearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.Click += new System.EventHandler(this.txtsearch_Click);
            this.txtsearch.Leave += new System.EventHandler(this.txtsearch_Leave);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(128, 63);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(50, 40);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseSelectable = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(184, 63);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(50, 40);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseSelectable = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(363, 63);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(50, 40);
            this.btnnew.TabIndex = 5;
            this.btnnew.Text = "New";
            this.btnnew.UseSelectable = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(477, 63);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(50, 40);
            this.btnview.TabIndex = 6;
            this.btnview.Text = "View";
            this.btnview.UseSelectable = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(534, 63);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(50, 40);
            this.btnedit.TabIndex = 7;
            this.btnedit.Text = "Edit";
            this.btnedit.UseSelectable = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(797, 2);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(0, 0);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[] {
        "metroTextBox3"};
            this.metroTextBox3.Location = new System.Drawing.Point(23, 109);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(800, 2);
            this.metroTextBox3.TabIndex = 8;
            this.metroTextBox3.Text = "metroTextBox3";
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox3.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(-15, -15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(40, 121);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Item ID";
            // 
            // txtItemName
            // 
            // 
            // 
            // 
            this.txtItemName.CustomButton.Image = null;
            this.txtItemName.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.txtItemName.CustomButton.Name = "";
            this.txtItemName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemName.CustomButton.TabIndex = 1;
            this.txtItemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemName.CustomButton.UseSelectable = true;
            this.txtItemName.CustomButton.Visible = false;
            this.txtItemName.Lines = new string[0];
            this.txtItemName.Location = new System.Drawing.Point(161, 146);
            this.txtItemName.MaxLength = 32767;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemName.SelectedText = "";
            this.txtItemName.SelectionLength = 0;
            this.txtItemName.SelectionStart = 0;
            this.txtItemName.ShortcutsEnabled = true;
            this.txtItemName.Size = new System.Drawing.Size(151, 23);
            this.txtItemName.TabIndex = 0;
            this.txtItemName.UseSelectable = true;
            this.txtItemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(40, 150);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Item Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtother);
            this.groupBox1.Controls.Add(this.rbtlubricant);
            this.groupBox1.Location = new System.Drawing.Point(40, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 48);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // rbtother
            // 
            this.rbtother.AutoSize = true;
            this.rbtother.Location = new System.Drawing.Point(140, 19);
            this.rbtother.Name = "rbtother";
            this.rbtother.Size = new System.Drawing.Size(53, 15);
            this.rbtother.TabIndex = 57;
            this.rbtother.Text = "Other";
            this.rbtother.UseSelectable = true;
            // 
            // rbtlubricant
            // 
            this.rbtlubricant.AutoSize = true;
            this.rbtlubricant.Location = new System.Drawing.Point(6, 19);
            this.rbtlubricant.Name = "rbtlubricant";
            this.rbtlubricant.Size = new System.Drawing.Size(73, 15);
            this.rbtlubricant.TabIndex = 58;
            this.rbtlubricant.Text = "Lubricant";
            this.rbtlubricant.UseSelectable = true;
            // 
            // txtReOrderLevel
            // 
            // 
            // 
            // 
            this.txtReOrderLevel.CustomButton.Image = null;
            this.txtReOrderLevel.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtReOrderLevel.CustomButton.Name = "";
            this.txtReOrderLevel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReOrderLevel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReOrderLevel.CustomButton.TabIndex = 1;
            this.txtReOrderLevel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReOrderLevel.CustomButton.UseSelectable = true;
            this.txtReOrderLevel.CustomButton.Visible = false;
            this.txtReOrderLevel.Lines = new string[0];
            this.txtReOrderLevel.Location = new System.Drawing.Point(143, 310);
            this.txtReOrderLevel.MaxLength = 32767;
            this.txtReOrderLevel.Name = "txtReOrderLevel";
            this.txtReOrderLevel.PasswordChar = '\0';
            this.txtReOrderLevel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReOrderLevel.SelectedText = "";
            this.txtReOrderLevel.SelectionLength = 0;
            this.txtReOrderLevel.SelectionStart = 0;
            this.txtReOrderLevel.ShortcutsEnabled = true;
            this.txtReOrderLevel.Size = new System.Drawing.Size(120, 23);
            this.txtReOrderLevel.TabIndex = 0;
            this.txtReOrderLevel.UseSelectable = true;
            this.txtReOrderLevel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReOrderLevel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(40, 312);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Re Order Level";
            // 
            // txtcurrrentStock
            // 
            // 
            // 
            // 
            this.txtcurrrentStock.CustomButton.Image = null;
            this.txtcurrrentStock.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtcurrrentStock.CustomButton.Name = "";
            this.txtcurrrentStock.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtcurrrentStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcurrrentStock.CustomButton.TabIndex = 1;
            this.txtcurrrentStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcurrrentStock.CustomButton.UseSelectable = true;
            this.txtcurrrentStock.CustomButton.Visible = false;
            this.txtcurrrentStock.Lines = new string[0];
            this.txtcurrrentStock.Location = new System.Drawing.Point(412, 310);
            this.txtcurrrentStock.MaxLength = 32767;
            this.txtcurrrentStock.Name = "txtcurrrentStock";
            this.txtcurrrentStock.PasswordChar = '\0';
            this.txtcurrrentStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcurrrentStock.SelectedText = "";
            this.txtcurrrentStock.SelectionLength = 0;
            this.txtcurrrentStock.SelectionStart = 0;
            this.txtcurrrentStock.ShortcutsEnabled = true;
            this.txtcurrrentStock.Size = new System.Drawing.Size(120, 23);
            this.txtcurrrentStock.TabIndex = 0;
            this.txtcurrrentStock.UseSelectable = true;
            this.txtcurrrentStock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcurrrentStock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(323, 312);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Current Stock";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(602, 312);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(38, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "UoM";
            // 
            // cmbItemUoM
            // 
            this.cmbItemUoM.FormattingEnabled = true;
            this.cmbItemUoM.ItemHeight = 23;
            this.cmbItemUoM.Items.AddRange(new object[] {
            "g",
            "kg",
            "Nos",
            "hr",
            "l"});
            this.cmbItemUoM.Location = new System.Drawing.Point(671, 307);
            this.cmbItemUoM.Name = "cmbItemUoM";
            this.cmbItemUoM.Size = new System.Drawing.Size(120, 29);
            this.cmbItemUoM.TabIndex = 60;
            this.cmbItemUoM.UseSelectable = true;
            // 
            // txtItmCostPrice
            // 
            // 
            // 
            // 
            this.txtItmCostPrice.CustomButton.Image = null;
            this.txtItmCostPrice.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtItmCostPrice.CustomButton.Name = "";
            this.txtItmCostPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItmCostPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItmCostPrice.CustomButton.TabIndex = 1;
            this.txtItmCostPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItmCostPrice.CustomButton.UseSelectable = true;
            this.txtItmCostPrice.CustomButton.Visible = false;
            this.txtItmCostPrice.Lines = new string[0];
            this.txtItmCostPrice.Location = new System.Drawing.Point(143, 354);
            this.txtItmCostPrice.MaxLength = 32767;
            this.txtItmCostPrice.Name = "txtItmCostPrice";
            this.txtItmCostPrice.PasswordChar = '\0';
            this.txtItmCostPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItmCostPrice.SelectedText = "";
            this.txtItmCostPrice.SelectionLength = 0;
            this.txtItmCostPrice.SelectionStart = 0;
            this.txtItmCostPrice.ShortcutsEnabled = true;
            this.txtItmCostPrice.Size = new System.Drawing.Size(120, 23);
            this.txtItmCostPrice.TabIndex = 0;
            this.txtItmCostPrice.UseSelectable = true;
            this.txtItmCostPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItmCostPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(40, 356);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(98, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Item Cost Price";
            // 
            // txtItemSellingPrice
            // 
            // 
            // 
            // 
            this.txtItemSellingPrice.CustomButton.Image = null;
            this.txtItemSellingPrice.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtItemSellingPrice.CustomButton.Name = "";
            this.txtItemSellingPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemSellingPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemSellingPrice.CustomButton.TabIndex = 1;
            this.txtItemSellingPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemSellingPrice.CustomButton.UseSelectable = true;
            this.txtItemSellingPrice.CustomButton.Visible = false;
            this.txtItemSellingPrice.Lines = new string[0];
            this.txtItemSellingPrice.Location = new System.Drawing.Point(436, 354);
            this.txtItemSellingPrice.MaxLength = 32767;
            this.txtItemSellingPrice.Name = "txtItemSellingPrice";
            this.txtItemSellingPrice.PasswordChar = '\0';
            this.txtItemSellingPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemSellingPrice.SelectedText = "";
            this.txtItemSellingPrice.SelectionLength = 0;
            this.txtItemSellingPrice.SelectionStart = 0;
            this.txtItemSellingPrice.ShortcutsEnabled = true;
            this.txtItemSellingPrice.Size = new System.Drawing.Size(120, 23);
            this.txtItemSellingPrice.TabIndex = 0;
            this.txtItemSellingPrice.UseSelectable = true;
            this.txtItemSellingPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemSellingPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(320, 356);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(110, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Item Selling Price";
            // 
            // txtItemDesc
            // 
            // 
            // 
            // 
            this.txtItemDesc.CustomButton.Image = null;
            this.txtItemDesc.CustomButton.Location = new System.Drawing.Point(576, 2);
            this.txtItemDesc.CustomButton.Name = "";
            this.txtItemDesc.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.txtItemDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemDesc.CustomButton.TabIndex = 1;
            this.txtItemDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemDesc.CustomButton.UseSelectable = true;
            this.txtItemDesc.CustomButton.Visible = false;
            this.txtItemDesc.Lines = new string[0];
            this.txtItemDesc.Location = new System.Drawing.Point(161, 185);
            this.txtItemDesc.MaxLength = 32767;
            this.txtItemDesc.Multiline = true;
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.PasswordChar = '\0';
            this.txtItemDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemDesc.SelectedText = "";
            this.txtItemDesc.SelectionLength = 0;
            this.txtItemDesc.SelectionStart = 0;
            this.txtItemDesc.ShortcutsEnabled = true;
            this.txtItemDesc.Size = new System.Drawing.Size(630, 56);
            this.txtItemDesc.TabIndex = 0;
            this.txtItemDesc.UseSelectable = true;
            this.txtItemDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(40, 189);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(104, 19);
            this.metroLabel9.TabIndex = 10;
            this.metroLabel9.Text = "Item Description";
            // 
            // dgdItemSearch
            // 
            this.dgdItemSearch.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgdItemSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdItemSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdItemSearch.Location = new System.Drawing.Point(610, 109);
            this.dgdItemSearch.Name = "dgdItemSearch";
            this.dgdItemSearch.Size = new System.Drawing.Size(240, 150);
            this.dgdItemSearch.TabIndex = 61;
            this.dgdItemSearch.Visible = false;
            this.dgdItemSearch.Leave += new System.EventHandler(this.dgdItemSearch_Leave);
            this.dgdItemSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgdItemSearch_MouseDoubleClick);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(363, 63);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(50, 40);
            this.btn.TabIndex = 5;
            this.btn.Text = "New";
            this.btn.UseSelectable = true;
            this.btn.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(420, 63);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 408);
            this.Controls.Add(this.dgdItemSearch);
            this.Controls.Add(this.cmbItemUoM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txtcurrrentStock);
            this.Controls.Add(this.txtItemSellingPrice);
            this.Controls.Add(this.txtItmCostPrice);
            this.Controls.Add(this.txtReOrderLevel);
            this.Controls.Add(this.txtItemDesc);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemID);
            this.MaximizeBox = false;
            this.Name = "frmItem";
            this.Text = "frmItem";
            this.Load += new System.EventHandler(this.frmItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdItemSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtItemID;
        private MetroFramework.Controls.MetroTextBox txtsearch;
        private MetroFramework.Controls.MetroButton btnsave;
        private MetroFramework.Controls.MetroButton btncancel;
        private MetroFramework.Controls.MetroButton btnnew;
        private MetroFramework.Controls.MetroButton btnview;
        private MetroFramework.Controls.MetroButton btnedit;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtItemName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rbtother;
        private MetroFramework.Controls.MetroRadioButton rbtlubricant;
        private MetroFramework.Controls.MetroTextBox txtReOrderLevel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtcurrrentStock;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cmbItemUoM;
        private MetroFramework.Controls.MetroTextBox txtItmCostPrice;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtItemSellingPrice;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtItemDesc;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DataGridView dgdItemSearch;
        private MetroFramework.Controls.MetroButton btn;
        private MetroFramework.Controls.MetroButton btnDelete;
    }
}