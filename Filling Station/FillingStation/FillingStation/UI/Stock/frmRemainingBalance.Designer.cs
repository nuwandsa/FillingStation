namespace FillingStation.UI.Stock
{
    partial class frmRemainingBalance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.btnOBsave = new MetroFramework.Controls.MetroButton();
            this.dgdRBItemSearch = new System.Windows.Forms.DataGridView();
            this.btnPOedit = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtRBQty = new MetroFramework.Controls.MetroTextBox();
            this.txtRBUoM = new MetroFramework.Controls.MetroTextBox();
            this.txtRBItemName = new MetroFramework.Controls.MetroTextBox();
            this.txtRBItemCode = new MetroFramework.Controls.MetroTextBox();
            this.dgdRB = new MetroFramework.Controls.MetroGrid();
            this.colRBItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRBItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRBItemUoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRBQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgdRBItemSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdRB)).BeginInit();
            this.SuspendLayout();
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
            this.metroTextBox3.Location = new System.Drawing.Point(35, 79);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(590, 2);
            this.metroTextBox3.TabIndex = 1171;
            this.metroTextBox3.Text = "metroTextBox3";
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnOBsave
            // 
            this.btnOBsave.Location = new System.Drawing.Point(496, 33);
            this.btnOBsave.Name = "btnOBsave";
            this.btnOBsave.Size = new System.Drawing.Size(50, 40);
            this.btnOBsave.TabIndex = 1169;
            this.btnOBsave.Text = "Save";
            this.btnOBsave.UseSelectable = true;
            // 
            // dgdRBItemSearch
            // 
            this.dgdRBItemSearch.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgdRBItemSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdRBItemSearch.Location = new System.Drawing.Point(30, 137);
            this.dgdRBItemSearch.Name = "dgdRBItemSearch";
            this.dgdRBItemSearch.Size = new System.Drawing.Size(330, 150);
            this.dgdRBItemSearch.TabIndex = 1163;
            this.dgdRBItemSearch.Visible = false;
            this.dgdRBItemSearch.Leave += new System.EventHandler(this.dgdRBItemSearch_Leave);
            this.dgdRBItemSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgdRBItemSearch_MouseDoubleClick);
            // 
            // btnPOedit
            // 
            this.btnPOedit.Location = new System.Drawing.Point(563, 33);
            this.btnPOedit.Name = "btnPOedit";
            this.btnPOedit.Size = new System.Drawing.Size(50, 40);
            this.btnPOedit.TabIndex = 1170;
            this.btnPOedit.Text = "Edit";
            this.btnPOedit.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(453, 89);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(30, 19);
            this.metroLabel4.TabIndex = 1164;
            this.metroLabel4.Text = "Qty";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(366, 89);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 1165;
            this.metroLabel3.Text = "UoM";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(198, 89);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 1166;
            this.metroLabel2.Text = "Item Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 1167;
            this.metroLabel1.Text = "Item ID";
            // 
            // txtRBQty
            // 
            // 
            // 
            // 
            this.txtRBQty.CustomButton.Image = null;
            this.txtRBQty.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtRBQty.CustomButton.Name = "";
            this.txtRBQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRBQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRBQty.CustomButton.TabIndex = 1;
            this.txtRBQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRBQty.CustomButton.UseSelectable = true;
            this.txtRBQty.CustomButton.Visible = false;
            this.txtRBQty.Lines = new string[] {
        "0.000"};
            this.txtRBQty.Location = new System.Drawing.Point(453, 111);
            this.txtRBQty.MaxLength = 32767;
            this.txtRBQty.Name = "txtRBQty";
            this.txtRBQty.PasswordChar = '\0';
            this.txtRBQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRBQty.SelectedText = "";
            this.txtRBQty.SelectionLength = 0;
            this.txtRBQty.SelectionStart = 0;
            this.txtRBQty.ShortcutsEnabled = true;
            this.txtRBQty.Size = new System.Drawing.Size(164, 23);
            this.txtRBQty.TabIndex = 1160;
            this.txtRBQty.Text = "0.000";
            this.txtRBQty.UseSelectable = true;
            this.txtRBQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRBQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRBUoM
            // 
            // 
            // 
            // 
            this.txtRBUoM.CustomButton.Image = null;
            this.txtRBUoM.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.txtRBUoM.CustomButton.Name = "";
            this.txtRBUoM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRBUoM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRBUoM.CustomButton.TabIndex = 1;
            this.txtRBUoM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRBUoM.CustomButton.UseSelectable = true;
            this.txtRBUoM.CustomButton.Visible = false;
            this.txtRBUoM.Lines = new string[0];
            this.txtRBUoM.Location = new System.Drawing.Point(366, 111);
            this.txtRBUoM.MaxLength = 32767;
            this.txtRBUoM.Name = "txtRBUoM";
            this.txtRBUoM.PasswordChar = '\0';
            this.txtRBUoM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRBUoM.SelectedText = "";
            this.txtRBUoM.SelectionLength = 0;
            this.txtRBUoM.SelectionStart = 0;
            this.txtRBUoM.ShortcutsEnabled = true;
            this.txtRBUoM.Size = new System.Drawing.Size(81, 23);
            this.txtRBUoM.TabIndex = 1161;
            this.txtRBUoM.UseSelectable = true;
            this.txtRBUoM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRBUoM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRBItemName
            // 
            // 
            // 
            // 
            this.txtRBItemName.CustomButton.Image = null;
            this.txtRBItemName.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtRBItemName.CustomButton.Name = "";
            this.txtRBItemName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRBItemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRBItemName.CustomButton.TabIndex = 1;
            this.txtRBItemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRBItemName.CustomButton.UseSelectable = true;
            this.txtRBItemName.CustomButton.Visible = false;
            this.txtRBItemName.Lines = new string[0];
            this.txtRBItemName.Location = new System.Drawing.Point(198, 111);
            this.txtRBItemName.MaxLength = 32767;
            this.txtRBItemName.Name = "txtRBItemName";
            this.txtRBItemName.PasswordChar = '\0';
            this.txtRBItemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRBItemName.SelectedText = "";
            this.txtRBItemName.SelectionLength = 0;
            this.txtRBItemName.SelectionStart = 0;
            this.txtRBItemName.ShortcutsEnabled = true;
            this.txtRBItemName.Size = new System.Drawing.Size(162, 23);
            this.txtRBItemName.TabIndex = 1162;
            this.txtRBItemName.UseSelectable = true;
            this.txtRBItemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRBItemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRBItemCode
            // 
            // 
            // 
            // 
            this.txtRBItemCode.CustomButton.Image = null;
            this.txtRBItemCode.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtRBItemCode.CustomButton.Name = "";
            this.txtRBItemCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRBItemCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRBItemCode.CustomButton.TabIndex = 1;
            this.txtRBItemCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRBItemCode.CustomButton.UseSelectable = true;
            this.txtRBItemCode.CustomButton.Visible = false;
            this.txtRBItemCode.Lines = new string[0];
            this.txtRBItemCode.Location = new System.Drawing.Point(30, 111);
            this.txtRBItemCode.MaxLength = 32767;
            this.txtRBItemCode.Name = "txtRBItemCode";
            this.txtRBItemCode.PasswordChar = '\0';
            this.txtRBItemCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRBItemCode.SelectedText = "";
            this.txtRBItemCode.SelectionLength = 0;
            this.txtRBItemCode.SelectionStart = 0;
            this.txtRBItemCode.ShortcutsEnabled = true;
            this.txtRBItemCode.Size = new System.Drawing.Size(162, 23);
            this.txtRBItemCode.TabIndex = 1159;
            this.txtRBItemCode.UseSelectable = true;
            this.txtRBItemCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRBItemCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRBItemCode.TextChanged += new System.EventHandler(this.txtRBItemCode_TextChanged);
            this.txtRBItemCode.Click += new System.EventHandler(this.txtRBItemCode_Click);
            this.txtRBItemCode.Leave += new System.EventHandler(this.txtRBItemCode_Leave);
            // 
            // dgdRB
            // 
            this.dgdRB.AllowUserToResizeRows = false;
            this.dgdRB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgdRB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdRB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgdRB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdRB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgdRB.ColumnHeadersHeight = 20;
            this.dgdRB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgdRB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRBItemCode,
            this.colRBItemName,
            this.colRBItemUoM,
            this.colRBQuantity});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgdRB.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgdRB.EnableHeadersVisualStyles = false;
            this.dgdRB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgdRB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgdRB.Location = new System.Drawing.Point(35, 137);
            this.dgdRB.Name = "dgdRB";
            this.dgdRB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdRB.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgdRB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgdRB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdRB.Size = new System.Drawing.Size(587, 285);
            this.dgdRB.TabIndex = 1168;
            // 
            // colRBItemCode
            // 
            this.colRBItemCode.HeaderText = "Item Code";
            this.colRBItemCode.Name = "colRBItemCode";
            this.colRBItemCode.ToolTipText = "hello";
            this.colRBItemCode.Width = 160;
            // 
            // colRBItemName
            // 
            this.colRBItemName.HeaderText = "Item Name";
            this.colRBItemName.Name = "colRBItemName";
            this.colRBItemName.Width = 170;
            // 
            // colRBItemUoM
            // 
            this.colRBItemUoM.HeaderText = "UoM";
            this.colRBItemUoM.Name = "colRBItemUoM";
            // 
            // colRBQuantity
            // 
            this.colRBQuantity.HeaderText = "Quantity";
            this.colRBQuantity.Name = "colRBQuantity";
            this.colRBQuantity.Width = 120;
            // 
            // frmRemainingBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 455);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.btnOBsave);
            this.Controls.Add(this.dgdRBItemSearch);
            this.Controls.Add(this.btnPOedit);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtRBQty);
            this.Controls.Add(this.txtRBUoM);
            this.Controls.Add(this.txtRBItemName);
            this.Controls.Add(this.txtRBItemCode);
            this.Controls.Add(this.dgdRB);
            this.Name = "frmRemainingBalance";
            this.Text = "frmRemainingBalance";
            this.Load += new System.EventHandler(this.frmRemainingBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdRBItemSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdRB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroButton btnOBsave;
        private System.Windows.Forms.DataGridView dgdRBItemSearch;
        private MetroFramework.Controls.MetroButton btnPOedit;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtRBQty;
        private MetroFramework.Controls.MetroTextBox txtRBUoM;
        private MetroFramework.Controls.MetroTextBox txtRBItemName;
        private MetroFramework.Controls.MetroTextBox txtRBItemCode;
        private MetroFramework.Controls.MetroGrid dgdRB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRBItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRBItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRBItemUoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRBQuantity;
    }
}