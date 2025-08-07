namespace OilShop
{
    partial class frmBillBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sale = new System.Windows.Forms.RadioButton();
            this.purchase = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Billno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.despr = new System.Windows.Forms.TextBox();
            this.ledger = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.totalbalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productname = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pdes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pprice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pqty = new System.Windows.Forms.TextBox();
            this.pname = new System.Windows.Forms.ComboBox();
            this.psave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.ptype = new System.Windows.Forms.TextBox();
            this.cashbook = new System.Windows.Forms.Button();
            this.printinvoice = new System.Windows.Forms.Button();
            this.le = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.ptotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledger)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1358, 30);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "BILL BOOK";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1326, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // sale
            // 
            this.sale.AutoSize = true;
            this.sale.Checked = true;
            this.sale.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.sale.Location = new System.Drawing.Point(10, 4);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(55, 21);
            this.sale.TabIndex = 8;
            this.sale.TabStop = true;
            this.sale.Text = "SALE";
            this.sale.UseVisualStyleBackColor = true;
            this.sale.CheckedChanged += new System.EventHandler(this.sale_CheckedChanged);
            // 
            // purchase
            // 
            this.purchase.AutoSize = true;
            this.purchase.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.purchase.Location = new System.Drawing.Point(90, 4);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(92, 21);
            this.purchase.TabIndex = 9;
            this.purchase.Text = "PURCHASE";
            this.purchase.UseVisualStyleBackColor = true;
            this.purchase.CheckedChanged += new System.EventHandler(this.purchase_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "NAME";
            // 
            // cname
            // 
            this.cname.FormattingEnabled = true;
            this.cname.Location = new System.Drawing.Point(83, 96);
            this.cname.MaxDropDownItems = 3;
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(199, 25);
            this.cname.TabIndex = 34;
            this.cname.SelectedIndexChanged += new System.EventHandler(this.cname_SelectedIndexChanged);
            this.cname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cname_KeyDown);
            this.cname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cname_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "BILL NO";
            // 
            // Billno
            // 
            this.Billno.Location = new System.Drawing.Point(83, 128);
            this.Billno.Name = "Billno";
            this.Billno.Size = new System.Drawing.Size(199, 25);
            this.Billno.TabIndex = 39;
            this.Billno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Billno.TextChanged += new System.EventHandler(this.Billno_TextChanged);
            this.Billno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Billno_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "DATE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "DETAIL";
            // 
            // despr
            // 
            this.despr.Location = new System.Drawing.Point(83, 160);
            this.despr.Name = "despr";
            this.despr.Size = new System.Drawing.Size(199, 25);
            this.despr.TabIndex = 43;
            this.despr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.despr_KeyDown);
            // 
            // ledger
            // 
            this.ledger.AllowUserToAddRows = false;
            this.ledger.AllowUserToDeleteRows = false;
            this.ledger.BackgroundColor = System.Drawing.Color.White;
            this.ledger.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ledger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ledger.ColumnHeadersHeight = 30;
            this.ledger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ledger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.des,
            this.price,
            this.type,
            this.qty,
            this.TOTAL,
            this.DELETE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ledger.DefaultCellStyle = dataGridViewCellStyle2;
            this.ledger.EnableHeadersVisualStyles = false;
            this.ledger.Location = new System.Drawing.Point(313, 160);
            this.ledger.Name = "ledger";
            this.ledger.RowHeadersVisible = false;
            this.ledger.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ledger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ledger.Size = new System.Drawing.Size(1021, 492);
            this.ledger.TabIndex = 44;
            this.ledger.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.ledger.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "ID";
            this.Column7.Name = "Column7";
            this.Column7.Width = 43;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "PCODE";
            this.Column1.Name = "Column1";
            this.Column1.Width = 72;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "PRODUCT NAME";
            this.Column2.Name = "Column2";
            // 
            // des
            // 
            this.des.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.des.HeaderText = "DESCRIPTION";
            this.des.Name = "des";
            this.des.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price.HeaderText = "PRICE";
            this.price.Name = "price";
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.price.Width = 64;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.type.HeaderText = "TYPE";
            this.type.Name = "type";
            this.type.Visible = false;
            this.type.Width = 61;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.HeaderText = "K.G";
            this.qty.Name = "qty";
            this.qty.Width = 51;
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Width = 66;
            // 
            // DELETE
            // 
            this.DELETE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DELETE.HeaderText = "";
            this.DELETE.Image = ((System.Drawing.Image)(resources.GetObject("DELETE.Image")));
            this.DELETE.Name = "DELETE";
            this.DELETE.Width = 5;
            // 
            // btnUnlock
            // 
            this.btnUnlock.BackColor = System.Drawing.Color.DarkRed;
            this.btnUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnlock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlock.ForeColor = System.Drawing.Color.White;
            this.btnUnlock.Location = new System.Drawing.Point(16, 191);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(266, 29);
            this.btnUnlock.TabIndex = 46;
            this.btnUnlock.Text = "UNLOCK";
            this.btnUnlock.UseVisualStyleBackColor = false;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkRed;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(16, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(266, 30);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "NEW INVOICE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkRed;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(16, 284);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(266, 30);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "UPDATE INVOICE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(16, 320);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(266, 30);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "DELETE INVOICE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkRed;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(16, 386);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(266, 30);
            this.btnPrint.TabIndex = 50;
            this.btnPrint.Text = "VIEW INVOICE";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(103, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 21);
            this.radioButton2.TabIndex = 52;
            this.radioButton2.Text = "CREDIT";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButton3.Location = new System.Drawing.Point(23, 8);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 21);
            this.radioButton3.TabIndex = 51;
            this.radioButton3.Text = "CASH";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // totalbalance
            // 
            this.totalbalance.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalbalance.ForeColor = System.Drawing.Color.Red;
            this.totalbalance.Location = new System.Drawing.Point(16, 609);
            this.totalbalance.Name = "totalbalance";
            this.totalbalance.Size = new System.Drawing.Size(266, 43);
            this.totalbalance.TabIndex = 54;
            this.totalbalance.Text = "0";
            this.totalbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 589);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "TOTAL BALANCE";
            // 
            // productname
            // 
            this.productname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.productname.CustomButton.Image = null;
            this.productname.CustomButton.Location = new System.Drawing.Point(13, 1);
            this.productname.CustomButton.Name = "";
            this.productname.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.productname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.productname.CustomButton.TabIndex = 1;
            this.productname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.productname.CustomButton.UseSelectable = true;
            this.productname.CustomButton.Visible = false;
            this.productname.DisplayIcon = true;
            this.productname.Icon = ((System.Drawing.Image)(resources.GetObject("productname.Icon")));
            this.productname.Lines = new string[0];
            this.productname.Location = new System.Drawing.Point(255, 313);
            this.productname.MaxLength = 32767;
            this.productname.Name = "productname";
            this.productname.PasswordChar = '\0';
            this.productname.PromptText = "SEARCH PRODUCT HERE";
            this.productname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.productname.SelectedText = "";
            this.productname.SelectionLength = 0;
            this.productname.SelectionStart = 0;
            this.productname.ShortcutsEnabled = true;
            this.productname.Size = new System.Drawing.Size(39, 27);
            this.productname.TabIndex = 55;
            this.productname.UseSelectable = true;
            this.productname.Visible = false;
            this.productname.WaterMark = "SEARCH PRODUCT HERE";
            this.productname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.productname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.productname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productname_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.purchase);
            this.panel2.Controls.Add(this.sale);
            this.panel2.Location = new System.Drawing.Point(15, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 29);
            this.panel2.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Location = new System.Drawing.Point(12, 548);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 38);
            this.panel3.TabIndex = 57;
            this.panel3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(393, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "P CODE";
            // 
            // pcode
            // 
            this.pcode.Location = new System.Drawing.Point(329, 59);
            this.pcode.Name = "pcode";
            this.pcode.Size = new System.Drawing.Size(196, 25);
            this.pcode.TabIndex = 58;
            this.pcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pcode_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(623, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "PRODUCT NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(894, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 63;
            this.label6.Text = "DESCRIPTION";
            // 
            // pdes
            // 
            this.pdes.Location = new System.Drawing.Point(829, 59);
            this.pdes.Name = "pdes";
            this.pdes.Size = new System.Drawing.Size(224, 25);
            this.pdes.TabIndex = 62;
            this.pdes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pdes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pdes_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(404, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 65;
            this.label10.Text = "PRICE";
            // 
            // pprice
            // 
            this.pprice.Location = new System.Drawing.Point(329, 116);
            this.pprice.Name = "pprice";
            this.pprice.Size = new System.Drawing.Size(196, 25);
            this.pprice.TabIndex = 64;
            this.pprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pprice_KeyDown);
            this.pprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pprice_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(632, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 67;
            this.label11.Text = "QUANTITY";
            // 
            // pqty
            // 
            this.pqty.Location = new System.Drawing.Point(559, 116);
            this.pqty.Name = "pqty";
            this.pqty.Size = new System.Drawing.Size(232, 25);
            this.pqty.TabIndex = 66;
            this.pqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pqty_KeyDown);
            this.pqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pqty_KeyPress);
            // 
            // pname
            // 
            this.pname.FormattingEnabled = true;
            this.pname.Location = new System.Drawing.Point(559, 59);
            this.pname.MaxDropDownItems = 3;
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(232, 25);
            this.pname.TabIndex = 68;
            this.pname.SelectedIndexChanged += new System.EventHandler(this.pname_SelectedIndexChanged);
            this.pname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pname_KeyDown);
            this.pname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pname_KeyPress);
            // 
            // psave
            // 
            this.psave.BackColor = System.Drawing.Color.DarkRed;
            this.psave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.psave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psave.ForeColor = System.Drawing.Color.White;
            this.psave.Location = new System.Drawing.Point(955, 105);
            this.psave.Name = "psave";
            this.psave.Size = new System.Drawing.Size(98, 36);
            this.psave.TabIndex = 69;
            this.psave.Text = "Save";
            this.psave.UseVisualStyleBackColor = false;
            this.psave.Click += new System.EventHandler(this.psave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(459, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 17);
            this.label12.TabIndex = 71;
            this.label12.Text = "TYPE";
            this.label12.Visible = false;
            // 
            // ptype
            // 
            this.ptype.Location = new System.Drawing.Point(396, 238);
            this.ptype.Name = "ptype";
            this.ptype.Size = new System.Drawing.Size(162, 25);
            this.ptype.TabIndex = 70;
            this.ptype.Text = "0";
            this.ptype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ptype.Visible = false;
            this.ptype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ptype_KeyDown);
            // 
            // cashbook
            // 
            this.cashbook.BackColor = System.Drawing.Color.DarkRed;
            this.cashbook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cashbook.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashbook.ForeColor = System.Drawing.Color.White;
            this.cashbook.Location = new System.Drawing.Point(15, 457);
            this.cashbook.Name = "cashbook";
            this.cashbook.Size = new System.Drawing.Size(266, 30);
            this.cashbook.TabIndex = 73;
            this.cashbook.Text = "CASH BOOK";
            this.cashbook.UseVisualStyleBackColor = false;
            this.cashbook.Click += new System.EventHandler(this.cashbook_Click);
            // 
            // printinvoice
            // 
            this.printinvoice.BackColor = System.Drawing.Color.DarkRed;
            this.printinvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printinvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printinvoice.ForeColor = System.Drawing.Color.White;
            this.printinvoice.Location = new System.Drawing.Point(15, 421);
            this.printinvoice.Name = "printinvoice";
            this.printinvoice.Size = new System.Drawing.Size(266, 30);
            this.printinvoice.TabIndex = 72;
            this.printinvoice.Text = "PRINT INVOICE";
            this.printinvoice.UseVisualStyleBackColor = false;
            this.printinvoice.Click += new System.EventHandler(this.printinvoice_Click);
            // 
            // le
            // 
            this.le.BackColor = System.Drawing.Color.DarkRed;
            this.le.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.le.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.le.ForeColor = System.Drawing.Color.White;
            this.le.Location = new System.Drawing.Point(16, 493);
            this.le.Name = "le";
            this.le.Size = new System.Drawing.Size(266, 30);
            this.le.TabIndex = 74;
            this.le.Text = "LEDGER";
            this.le.UseVisualStyleBackColor = false;
            this.le.Click += new System.EventHandler(this.le_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkRed;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(15, 353);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(266, 30);
            this.exit.TabIndex = 75;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(849, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 77;
            this.label13.Text = "TOTAL";
            // 
            // ptotal
            // 
            this.ptotal.Location = new System.Drawing.Point(803, 116);
            this.ptotal.Name = "ptotal";
            this.ptotal.Size = new System.Drawing.Size(139, 25);
            this.ptotal.TabIndex = 76;
            this.ptotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ptotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ptotal_KeyDown);
            this.ptotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ptotal_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(1078, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(256, 37);
            this.label14.TabIndex = 78;
            this.label14.Text = "Faisal Javed Traders";
            // 
            // date1
            // 
            this.date1.Checked = false;
            this.date1.CustomFormat = " dd/MM/yyyy";
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(83, 63);
            this.date1.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(199, 25);
            this.date1.TabIndex = 37;
            this.date1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date1_KeyDown);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(209, 1);
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
            this.txtSearch.Location = new System.Drawing.Point(1099, 131);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search Here";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(235, 27);
            this.txtSearch.TabIndex = 79;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search Here";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmBillBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1358, 664);
            this.ControlBox = false;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ptotal);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.le);
            this.Controls.Add(this.cashbook);
            this.Controls.Add(this.printinvoice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ptype);
            this.Controls.Add(this.psave);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pqty);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pprice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pdes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pcode);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.totalbalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.ledger);
            this.Controls.Add(this.despr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Billno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBillBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBillBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledger)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton sale;
        private System.Windows.Forms.RadioButton purchase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox despr;
        private System.Windows.Forms.DataGridView ledger;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox totalbalance;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox productname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pdes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pprice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pqty;
        private System.Windows.Forms.ComboBox pname;
        private System.Windows.Forms.Button psave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ptype;
        public System.Windows.Forms.TextBox Billno;
        public System.Windows.Forms.ComboBox cname;
        private System.Windows.Forms.Button cashbook;
        private System.Windows.Forms.Button printinvoice;
        private System.Windows.Forms.Button le;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ptotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker date1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn des;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewImageColumn DELETE;
    }
}