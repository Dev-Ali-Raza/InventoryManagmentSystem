namespace OilShop
{
    partial class FrmSodaBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSodaBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.despr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.ComboBox();
            this.qtyy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pricee = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ledger = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledger)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 30);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "SODA BOOK";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1328, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // despr
            // 
            this.despr.Location = new System.Drawing.Point(119, 123);
            this.despr.Name = "despr";
            this.despr.Size = new System.Drawing.Size(199, 25);
            this.despr.TabIndex = 51;
            this.despr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.despr_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "DETAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "DATE";
            // 
            // date1
            // 
            this.date1.Checked = false;
            this.date1.CustomFormat = " dd/MM/yyyy   hh:mm:ss";
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(119, 56);
            this.date1.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(199, 25);
            this.date1.TabIndex = 46;
            this.date1.ValueChanged += new System.EventHandler(this.date1_ValueChanged);
            this.date1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date1_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "NAME";
            // 
            // cname
            // 
            this.cname.FormattingEnabled = true;
            this.cname.Location = new System.Drawing.Point(119, 89);
            this.cname.MaxDropDownItems = 3;
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(199, 25);
            this.cname.TabIndex = 44;
            this.cname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cname_KeyDown);
            // 
            // qtyy
            // 
            this.qtyy.Location = new System.Drawing.Point(119, 224);
            this.qtyy.Name = "qtyy";
            this.qtyy.Size = new System.Drawing.Size(199, 25);
            this.qtyy.TabIndex = 55;
            this.qtyy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.qtyy_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "WEIGHT (KG)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "PRICE";
            // 
            // pricee
            // 
            this.pricee.Location = new System.Drawing.Point(119, 192);
            this.pricee.Name = "pricee";
            this.pricee.Size = new System.Drawing.Size(199, 25);
            this.pricee.TabIndex = 52;
            this.pricee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pricee_KeyDown);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkRed;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(15, 361);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(302, 30);
            this.exit.TabIndex = 79;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkRed;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(16, 325);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(302, 30);
            this.btnUpdate.TabIndex = 77;
            this.btnUpdate.Text = "CLEAR";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkRed;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(16, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(302, 30);
            this.btnSave.TabIndex = 76;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ledger
            // 
            this.ledger.AllowUserToAddRows = false;
            this.ledger.AllowUserToDeleteRows = false;
            this.ledger.BackgroundColor = System.Drawing.Color.White;
            this.ledger.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ledger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ledger.ColumnHeadersHeight = 30;
            this.ledger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ledger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column3,
            this.Column1,
            this.Column2,
            this.des,
            this.Column4,
            this.price,
            this.qty,
            this.DELETE});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ledger.DefaultCellStyle = dataGridViewCellStyle3;
            this.ledger.EnableHeadersVisualStyles = false;
            this.ledger.Location = new System.Drawing.Point(363, 72);
            this.ledger.Name = "ledger";
            this.ledger.RowHeadersVisible = false;
            this.ledger.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ledger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ledger.Size = new System.Drawing.Size(970, 319);
            this.ledger.TabIndex = 80;
            this.ledger.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ledger_CellContentClick);
            this.ledger.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ledger_CellValueChanged);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "ID";
            this.Column7.Name = "Column7";
            this.Column7.Width = 44;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Format = "f";
            dataGridViewCellStyle2.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "DATE";
            this.Column3.Name = "Column3";
            this.Column3.Width = 62;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "VOUCHER NO";
            this.Column1.Name = "Column1";
            this.Column1.Width = 115;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "PARTY NAME";
            this.Column2.Name = "Column2";
            // 
            // des
            // 
            this.des.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.des.HeaderText = "DESCRIPTION";
            this.des.Name = "des";
            this.des.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.des.Width = 113;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "PRODUCT NAME";
            this.Column4.Name = "Column4";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price.HeaderText = "PRICE";
            this.price.Name = "price";
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.price.Width = 66;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.HeaderText = "K.G";
            this.qty.Name = "qty";
            this.qty.Width = 51;
            // 
            // DELETE
            // 
            this.DELETE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DELETE.HeaderText = "";
            this.DELETE.Image = ((System.Drawing.Image)(resources.GetObject("DELETE.Image")));
            this.DELETE.Name = "DELETE";
            this.DELETE.Width = 5;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(1048, 39);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search Here";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(285, 27);
            this.txtSearch.TabIndex = 81;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search Here";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 83;
            this.label5.Text = "PRODUCT NAME";
            // 
            // pname
            // 
            this.pname.FormattingEnabled = true;
            this.pname.Location = new System.Drawing.Point(118, 158);
            this.pname.MaxDropDownItems = 3;
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(200, 25);
            this.pname.TabIndex = 84;
            this.pname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pname_KeyDown);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(119, 258);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(199, 25);
            this.txtid.TabIndex = 85;
            this.txtid.Visible = false;
            // 
            // FrmSodaBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 666);
            this.ControlBox = false;
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ledger);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.qtyy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pricee);
            this.Controls.Add(this.despr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSodaBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSodaBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox despr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cname;
        private System.Windows.Forms.TextBox qtyy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox pricee;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView ledger;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox pname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn des;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewImageColumn DELETE;
    }
}