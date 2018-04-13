namespace FillingStation.UI.Stock
{
    partial class frmOpenningBalence
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
            this.dgdOBItemSearch = new System.Windows.Forms.DataGridView();
            this.txtOBItemName = new MetroFramework.Controls.MetroTextBox();
            this.txtOBItemCode = new MetroFramework.Controls.MetroTextBox();
            this.txtOBUoM = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtOBQty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dgdOB = new MetroFramework.Controls.MetroGrid();
            this.colOBItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOBItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOBItemUoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOBQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.btnPOedit = new MetroFramework.Controls.MetroButton();
            this.btnPOsave = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgdOBItemSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdOB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdOBItemSearch
            // 
            this.dgdOBItemSearch.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgdOBItemSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdOBItemSearch.Location = new System.Drawing.Point(20, 128);
            this.dgdOBItemSearch.Name = "dgdOBItemSearch";
            this.dgdOBItemSearch.Size = new System.Drawing.Size(330, 150);
            this.dgdOBItemSearch.TabIndex = 1153;
            this.dgdOBItemSearch.Visible = false;
            this.dgdOBItemSearch.Leave += new System.EventHandler(this.dgdOBItemSearch_Leave);
            this.dgdOBItemSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgdOBItemSearch_MouseDoubleClick);
            // 
            // txtOBItemName
            // 
            // 
            // 
            // 
            this.txtOBItemName.CustomButton.Image = null;
            this.txtOBItemName.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtOBItemName.CustomButton.Name = "";
            this.txtOBItemName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOBItemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOBItemName.CustomButton.TabIndex = 1;
            this.txtOBItemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOBItemName.CustomButton.UseSelectable = true;
            this.txtOBItemName.CustomButton.Visible = false;
            this.txtOBItemName.Lines = new string[0];
            this.txtOBItemName.Location = new System.Drawing.Point(188, 102);
            this.txtOBItemName.MaxLength = 32767;
            this.txtOBItemName.Name = "txtOBItemName";
            this.txtOBItemName.PasswordChar = '\0';
            this.txtOBItemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOBItemName.SelectedText = "";
            this.txtOBItemName.SelectionLength = 0;
            this.txtOBItemName.SelectionStart = 0;
            this.txtOBItemName.ShortcutsEnabled = true;
            this.txtOBItemName.Size = new System.Drawing.Size(162, 23);
            this.txtOBItemName.TabIndex = 1152;
            this.txtOBItemName.UseSelectable = true;
            this.txtOBItemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOBItemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOBItemCode
            // 
            // 
            // 
            // 
            this.txtOBItemCode.CustomButton.Image = null;
            this.txtOBItemCode.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtOBItemCode.CustomButton.Name = "";
            this.txtOBItemCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOBItemCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOBItemCode.CustomButton.TabIndex = 1;
            this.txtOBItemCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOBItemCode.CustomButton.UseSelectable = true;
            this.txtOBItemCode.CustomButton.Visible = false;
            this.txtOBItemCode.Lines = new string[0];
            this.txtOBItemCode.Location = new System.Drawing.Point(20, 102);
            this.txtOBItemCode.MaxLength = 32767;
            this.txtOBItemCode.Name = "txtOBItemCode";
            this.txtOBItemCode.PasswordChar = '\0';
            this.txtOBItemCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOBItemCode.SelectedText = "";
            this.txtOBItemCode.SelectionLength = 0;
            this.txtOBItemCode.SelectionStart = 0;
            this.txtOBItemCode.ShortcutsEnabled = true;
            this.txtOBItemCode.Size = new System.Drawing.Size(162, 23);
            this.txtOBItemCode.TabIndex = 1151;
            this.txtOBItemCode.UseSelectable = true;
            this.txtOBItemCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOBItemCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtOBItemCode.TextChanged += new System.EventHandler(this.txtOBItemCode_TextChanged);
            this.txtOBItemCode.Click += new System.EventHandler(this.txtOBItemCode_Click);
            this.txtOBItemCode.Leave += new System.EventHandler(this.txtOBItemCode_Leave);
            // 
            // txtOBUoM
            // 
            // 
            // 
            // 
            this.txtOBUoM.CustomButton.Image = null;
            this.txtOBUoM.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.txtOBUoM.CustomButton.Name = "";
            this.txtOBUoM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOBUoM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOBUoM.CustomButton.TabIndex = 1;
            this.txtOBUoM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOBUoM.CustomButton.UseSelectable = true;
            this.txtOBUoM.CustomButton.Visible = false;
            this.txtOBUoM.Lines = new string[0];
            this.txtOBUoM.Location = new System.Drawing.Point(356, 102);
            this.txtOBUoM.MaxLength = 32767;
            this.txtOBUoM.Name = "txtOBUoM";
            this.txtOBUoM.PasswordChar = '\0';
            this.txtOBUoM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOBUoM.SelectedText = "";
            this.txtOBUoM.SelectionLength = 0;
            this.txtOBUoM.SelectionStart = 0;
            this.txtOBUoM.ShortcutsEnabled = true;
            this.txtOBUoM.Size = new System.Drawing.Size(81, 23);
            this.txtOBUoM.TabIndex = 1152;
            this.txtOBUoM.UseSelectable = true;
            this.txtOBUoM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOBUoM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 1154;
            this.metroLabel1.Text = "Item ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(188, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 1154;
            this.metroLabel2.Text = "Item Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(356, 80);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 1154;
            this.metroLabel3.Text = "UoM";
            // 
            // txtOBQty
            // 
            // 
            // 
            // 
            this.txtOBQty.CustomButton.Image = null;
            this.txtOBQty.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtOBQty.CustomButton.Name = "";
            this.txtOBQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOBQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOBQty.CustomButton.TabIndex = 1;
            this.txtOBQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOBQty.CustomButton.UseSelectable = true;
            this.txtOBQty.CustomButton.Visible = false;
            this.txtOBQty.Lines = new string[] {
        "0.000"};
            this.txtOBQty.Location = new System.Drawing.Point(443, 102);
            this.txtOBQty.MaxLength = 32767;
            this.txtOBQty.Name = "txtOBQty";
            this.txtOBQty.PasswordChar = '\0';
            this.txtOBQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOBQty.SelectedText = "";
            this.txtOBQty.SelectionLength = 0;
            this.txtOBQty.SelectionStart = 0;
            this.txtOBQty.ShortcutsEnabled = true;
            this.txtOBQty.Size = new System.Drawing.Size(164, 23);
            this.txtOBQty.TabIndex = 1152;
            this.txtOBQty.Text = "0.000";
            this.txtOBQty.UseSelectable = true;
            this.txtOBQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOBQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(443, 80);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(30, 19);
            this.metroLabel4.TabIndex = 1154;
            this.metroLabel4.Text = "Qty";
            // 
            // dgdOB
            // 
            this.dgdOB.AllowUserToResizeRows = false;
            this.dgdOB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgdOB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdOB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgdOB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdOB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgdOB.ColumnHeadersHeight = 20;
            this.dgdOB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgdOB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOBItemCode,
            this.colOBItemName,
            this.colOBItemUoM,
            this.colOBQuantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgdOB.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgdOB.EnableHeadersVisualStyles = false;
            this.dgdOB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgdOB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgdOB.Location = new System.Drawing.Point(25, 128);
            this.dgdOB.Name = "dgdOB";
            this.dgdOB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdOB.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgdOB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgdOB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdOB.Size = new System.Drawing.Size(587, 285);
            this.dgdOB.TabIndex = 1155;
            // 
            // colOBItemCode
            // 
            this.colOBItemCode.HeaderText = "Item Code";
            this.colOBItemCode.Name = "colOBItemCode";
            this.colOBItemCode.ToolTipText = "hello";
            this.colOBItemCode.Width = 160;
            // 
            // colOBItemName
            // 
            this.colOBItemName.HeaderText = "Item Name";
            this.colOBItemName.Name = "colOBItemName";
            this.colOBItemName.Width = 170;
            // 
            // colOBItemUoM
            // 
            this.colOBItemUoM.HeaderText = "UoM";
            this.colOBItemUoM.Name = "colOBItemUoM";
            // 
            // colOBQuantity
            // 
            this.colOBQuantity.HeaderText = "Quantity";
            this.colOBQuantity.Name = "colOBQuantity";
            this.colOBQuantity.Width = 120;
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(587, 2);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(0, 0);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[] {
        "metroTextBox3"};
            this.metroTextBox3.Location = new System.Drawing.Point(25, 70);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(590, 2);
            this.metroTextBox3.TabIndex = 1158;
            this.metroTextBox3.Text = "metroTextBox3";
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnPOedit
            // 
            this.btnPOedit.Location = new System.Drawing.Point(553, 24);
            this.btnPOedit.Name = "btnPOedit";
            this.btnPOedit.Size = new System.Drawing.Size(50, 40);
            this.btnPOedit.TabIndex = 1157;
            this.btnPOedit.Text = "Edit";
            this.btnPOedit.UseSelectable = true;
            // 
            // btnPOsave
            // 
            this.btnPOsave.Location = new System.Drawing.Point(486, 24);
            this.btnPOsave.Name = "btnPOsave";
            this.btnPOsave.Size = new System.Drawing.Size(50, 40);
            this.btnPOsave.TabIndex = 1156;
            this.btnPOsave.Text = "Save";
            this.btnPOsave.UseSelectable = true;
            this.btnPOsave.Click += new System.EventHandler(this.btnPOsave_Click);
            // 
            // frmOpenningBalence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 455);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.btnPOedit);
            this.Controls.Add(this.btnPOsave);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgdOBItemSearch);
            this.Controls.Add(this.txtOBQty);
            this.Controls.Add(this.txtOBUoM);
            this.Controls.Add(this.txtOBItemName);
            this.Controls.Add(this.txtOBItemCode);
            this.Controls.Add(this.dgdOB);
            this.Name = "frmOpenningBalence";
            this.Text = "frmOpenningBalence";
            this.Load += new System.EventHandler(this.frmOpenningBalence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdOBItemSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdOB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdOBItemSearch;
        private MetroFramework.Controls.MetroTextBox txtOBItemName;
        private MetroFramework.Controls.MetroTextBox txtOBItemCode;
        private MetroFramework.Controls.MetroTextBox txtOBUoM;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtOBQty;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroGrid dgdOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOBItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOBItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOBItemUoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOBQuantity;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroButton btnPOedit;
        private MetroFramework.Controls.MetroButton btnPOsave;
    }
}