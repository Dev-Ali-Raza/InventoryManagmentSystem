namespace OilShop
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerbox = new System.Windows.Forms.ListBox();
            this.productbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.purchasecustomer = new System.Windows.Forms.Button();
            this.purchaseproduct = new System.Windows.Forms.Button();
            this.dailypurchase = new System.Windows.Forms.Button();
            this.productwisestock = new System.Windows.Forms.Button();
            this.productswise = new System.Windows.Forms.Button();
            this.profitratoio = new System.Windows.Forms.Button();
            this.btnprofit = new System.Windows.Forms.Button();
            this.txtCustomer = new MetroFramework.Controls.MetroTextBox();
            this.txtProduct = new MetroFramework.Controls.MetroTextBox();
            this.allproductsstock = new System.Windows.Forms.Button();
            this.producttype = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btntypestock = new System.Windows.Forms.Button();
            this.btnprofitdate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 39);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "REPORTS";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1321, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "CUSTOMER / COMPANY";
            // 
            // customerbox
            // 
            this.customerbox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerbox.FormattingEnabled = true;
            this.customerbox.ItemHeight = 20;
            this.customerbox.Location = new System.Drawing.Point(13, 195);
            this.customerbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerbox.Name = "customerbox";
            this.customerbox.Size = new System.Drawing.Size(179, 204);
            this.customerbox.TabIndex = 71;
            // 
            // productbox
            // 
            this.productbox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productbox.FormattingEnabled = true;
            this.productbox.ItemHeight = 20;
            this.productbox.Location = new System.Drawing.Point(227, 195);
            this.productbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productbox.Name = "productbox";
            this.productbox.Size = new System.Drawing.Size(182, 204);
            this.productbox.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(284, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "PRODUCTS";
            // 
            // date2
            // 
            this.date2.Checked = false;
            this.date2.CustomFormat = " dd/MM/yyyy";
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2.Location = new System.Drawing.Point(380, 63);
            this.date2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date2.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(152, 25);
            this.date2.TabIndex = 75;
            // 
            // date1
            // 
            this.date1.Checked = false;
            this.date1.CustomFormat = " dd/MM/yyyy";
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(101, 63);
            this.date1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date1.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(143, 25);
            this.date1.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "DATE TO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(268, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 77;
            this.label5.Text = "DATE FROM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(523, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 78;
            this.label6.Text = "SALE SIDE REPORTS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(801, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 17);
            this.label7.TabIndex = 79;
            this.label7.Text = "PURCHASE SIDE REPORTS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1129, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 17);
            this.label8.TabIndex = 80;
            this.label8.Text = "STOCK / OTHER REPORTS";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkRed;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(466, 178);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(272, 39);
            this.btnSave.TabIndex = 81;
            this.btnSave.Text = "DAILY SALE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(466, 238);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 39);
            this.button1.TabIndex = 82;
            this.button1.Text = "PRODUCT WISE SALE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(466, 299);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 39);
            this.button2.TabIndex = 83;
            this.button2.Text = "PARTY WISE SALE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // purchasecustomer
            // 
            this.purchasecustomer.BackColor = System.Drawing.Color.DarkRed;
            this.purchasecustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.purchasecustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasecustomer.ForeColor = System.Drawing.Color.White;
            this.purchasecustomer.Location = new System.Drawing.Point(761, 299);
            this.purchasecustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purchasecustomer.Name = "purchasecustomer";
            this.purchasecustomer.Size = new System.Drawing.Size(272, 39);
            this.purchasecustomer.TabIndex = 86;
            this.purchasecustomer.Text = "PARTY WISE PURCHASE";
            this.purchasecustomer.UseVisualStyleBackColor = false;
            this.purchasecustomer.Click += new System.EventHandler(this.purchasecustomer_Click);
            // 
            // purchaseproduct
            // 
            this.purchaseproduct.BackColor = System.Drawing.Color.DarkRed;
            this.purchaseproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.purchaseproduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseproduct.ForeColor = System.Drawing.Color.White;
            this.purchaseproduct.Location = new System.Drawing.Point(761, 238);
            this.purchaseproduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purchaseproduct.Name = "purchaseproduct";
            this.purchaseproduct.Size = new System.Drawing.Size(272, 39);
            this.purchaseproduct.TabIndex = 85;
            this.purchaseproduct.Text = "PRODUCT WISE PURCHASE";
            this.purchaseproduct.UseVisualStyleBackColor = false;
            this.purchaseproduct.Click += new System.EventHandler(this.purchaseproduct_Click);
            // 
            // dailypurchase
            // 
            this.dailypurchase.BackColor = System.Drawing.Color.DarkRed;
            this.dailypurchase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dailypurchase.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailypurchase.ForeColor = System.Drawing.Color.White;
            this.dailypurchase.Location = new System.Drawing.Point(761, 178);
            this.dailypurchase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dailypurchase.Name = "dailypurchase";
            this.dailypurchase.Size = new System.Drawing.Size(272, 39);
            this.dailypurchase.TabIndex = 84;
            this.dailypurchase.Text = "DAILY PURCHASE";
            this.dailypurchase.UseVisualStyleBackColor = false;
            this.dailypurchase.Click += new System.EventHandler(this.dailypurchase_Click);
            // 
            // productwisestock
            // 
            this.productwisestock.BackColor = System.Drawing.Color.DarkRed;
            this.productwisestock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.productwisestock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productwisestock.ForeColor = System.Drawing.Color.White;
            this.productwisestock.Location = new System.Drawing.Point(1064, 178);
            this.productwisestock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productwisestock.Name = "productwisestock";
            this.productwisestock.Size = new System.Drawing.Size(272, 39);
            this.productwisestock.TabIndex = 87;
            this.productwisestock.Text = "PRODUCT WISE STOCK";
            this.productwisestock.UseVisualStyleBackColor = false;
            this.productwisestock.Click += new System.EventHandler(this.productwisestock_Click);
            // 
            // productswise
            // 
            this.productswise.BackColor = System.Drawing.Color.DarkRed;
            this.productswise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.productswise.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productswise.ForeColor = System.Drawing.Color.White;
            this.productswise.Location = new System.Drawing.Point(1064, 238);
            this.productswise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productswise.Name = "productswise";
            this.productswise.Size = new System.Drawing.Size(272, 39);
            this.productswise.TabIndex = 88;
            this.productswise.Text = "PRODUCTS WISE STOCK";
            this.productswise.UseVisualStyleBackColor = false;
            this.productswise.Click += new System.EventHandler(this.productswise_Click);
            // 
            // profitratoio
            // 
            this.profitratoio.BackColor = System.Drawing.Color.DarkRed;
            this.profitratoio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.profitratoio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitratoio.ForeColor = System.Drawing.Color.White;
            this.profitratoio.Location = new System.Drawing.Point(1064, 415);
            this.profitratoio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.profitratoio.Name = "profitratoio";
            this.profitratoio.Size = new System.Drawing.Size(272, 39);
            this.profitratoio.TabIndex = 89;
            this.profitratoio.Text = "PROFIT RATIO ALL PRODUCT";
            this.profitratoio.UseVisualStyleBackColor = false;
            this.profitratoio.Click += new System.EventHandler(this.profitratoio_Click);
            // 
            // btnprofit
            // 
            this.btnprofit.BackColor = System.Drawing.Color.DarkRed;
            this.btnprofit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprofit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofit.ForeColor = System.Drawing.Color.White;
            this.btnprofit.Location = new System.Drawing.Point(1064, 472);
            this.btnprofit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnprofit.Name = "btnprofit";
            this.btnprofit.Size = new System.Drawing.Size(272, 39);
            this.btnprofit.TabIndex = 90;
            this.btnprofit.Text = "PROFIT RATIO PRODUCT WJSE";
            this.btnprofit.UseVisualStyleBackColor = false;
            this.btnprofit.Click += new System.EventHandler(this.btnprofit_Click);
            // 
            // txtCustomer
            // 
            // 
            // 
            // 
            this.txtCustomer.CustomButton.Image = null;
            this.txtCustomer.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.txtCustomer.CustomButton.Name = "";
            this.txtCustomer.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomer.CustomButton.TabIndex = 1;
            this.txtCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomer.CustomButton.UseSelectable = true;
            this.txtCustomer.CustomButton.Visible = false;
            this.txtCustomer.DisplayIcon = true;
            this.txtCustomer.Icon = ((System.Drawing.Image)(resources.GetObject("txtCustomer.Icon")));
            this.txtCustomer.Lines = new string[0];
            this.txtCustomer.Location = new System.Drawing.Point(12, 128);
            this.txtCustomer.MaxLength = 32767;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.PasswordChar = '\0';
            this.txtCustomer.PromptText = "Search Customer";
            this.txtCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomer.SelectedText = "";
            this.txtCustomer.SelectionLength = 0;
            this.txtCustomer.SelectionStart = 0;
            this.txtCustomer.ShortcutsEnabled = true;
            this.txtCustomer.Size = new System.Drawing.Size(180, 27);
            this.txtCustomer.TabIndex = 91;
            this.txtCustomer.UseSelectable = true;
            this.txtCustomer.WaterMark = "Search Customer";
            this.txtCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomer.TextChanged += new System.EventHandler(this.txtCustomer_TextChanged);
            // 
            // txtProduct
            // 
            // 
            // 
            // 
            this.txtProduct.CustomButton.Image = null;
            this.txtProduct.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.txtProduct.CustomButton.Name = "";
            this.txtProduct.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProduct.CustomButton.TabIndex = 1;
            this.txtProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProduct.CustomButton.UseSelectable = true;
            this.txtProduct.CustomButton.Visible = false;
            this.txtProduct.DisplayIcon = true;
            this.txtProduct.Icon = ((System.Drawing.Image)(resources.GetObject("txtProduct.Icon")));
            this.txtProduct.Lines = new string[0];
            this.txtProduct.Location = new System.Drawing.Point(227, 128);
            this.txtProduct.MaxLength = 32767;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.PasswordChar = '\0';
            this.txtProduct.PromptText = "Search Product";
            this.txtProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProduct.SelectedText = "";
            this.txtProduct.SelectionLength = 0;
            this.txtProduct.SelectionStart = 0;
            this.txtProduct.ShortcutsEnabled = true;
            this.txtProduct.Size = new System.Drawing.Size(182, 27);
            this.txtProduct.TabIndex = 92;
            this.txtProduct.UseSelectable = true;
            this.txtProduct.WaterMark = "Search Product";
            this.txtProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            // 
            // allproductsstock
            // 
            this.allproductsstock.BackColor = System.Drawing.Color.DarkRed;
            this.allproductsstock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.allproductsstock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allproductsstock.ForeColor = System.Drawing.Color.White;
            this.allproductsstock.Location = new System.Drawing.Point(1064, 299);
            this.allproductsstock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allproductsstock.Name = "allproductsstock";
            this.allproductsstock.Size = new System.Drawing.Size(272, 39);
            this.allproductsstock.TabIndex = 93;
            this.allproductsstock.Text = "ALL PRODUCTS WISE STOCK";
            this.allproductsstock.UseVisualStyleBackColor = false;
            this.allproductsstock.Click += new System.EventHandler(this.allproductsstock_Click);
            // 
            // producttype
            // 
            this.producttype.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producttype.FormattingEnabled = true;
            this.producttype.ItemHeight = 20;
            this.producttype.Location = new System.Drawing.Point(13, 437);
            this.producttype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.producttype.Name = "producttype";
            this.producttype.Size = new System.Drawing.Size(179, 204);
            this.producttype.TabIndex = 94;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(48, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 95;
            this.label9.Text = "PRODUCT TYPE";
            // 
            // btntypestock
            // 
            this.btntypestock.BackColor = System.Drawing.Color.DarkRed;
            this.btntypestock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntypestock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntypestock.ForeColor = System.Drawing.Color.White;
            this.btntypestock.Location = new System.Drawing.Point(1064, 360);
            this.btntypestock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btntypestock.Name = "btntypestock";
            this.btntypestock.Size = new System.Drawing.Size(272, 39);
            this.btntypestock.TabIndex = 96;
            this.btntypestock.Text = "PRODUCT TYPE WISE STOCK";
            this.btntypestock.UseVisualStyleBackColor = false;
            this.btntypestock.Click += new System.EventHandler(this.btntypestock_Click);
            // 
            // btnprofitdate
            // 
            this.btnprofitdate.BackColor = System.Drawing.Color.DarkRed;
            this.btnprofitdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprofitdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofitdate.ForeColor = System.Drawing.Color.White;
            this.btnprofitdate.Location = new System.Drawing.Point(1064, 529);
            this.btnprofitdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnprofitdate.Name = "btnprofitdate";
            this.btnprofitdate.Size = new System.Drawing.Size(272, 39);
            this.btnprofitdate.TabIndex = 97;
            this.btnprofitdate.Text = "PROFIT RATIO DATE WISE";
            this.btnprofitdate.UseVisualStyleBackColor = false;
            this.btnprofitdate.Click += new System.EventHandler(this.btnprofitdate_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(466, 613);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(272, 39);
            this.button3.TabIndex = 101;
            this.button3.Text = "PARTY WISE SODA REMAINING";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(466, 552);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(272, 39);
            this.button4.TabIndex = 100;
            this.button4.Text = "PRODUCT WISE SODA REMAINING";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkRed;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(466, 492);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(272, 39);
            this.button5.TabIndex = 99;
            this.button5.Text = "REMAING SODE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(532, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 17);
            this.label10.TabIndex = 98;
            this.label10.Text = "SODA SIDE REPORTS";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkRed;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(466, 428);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(272, 39);
            this.button6.TabIndex = 102;
            this.button6.Text = "COMPLETE SODE";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkRed;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(761, 613);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(272, 39);
            this.button7.TabIndex = 104;
            this.button7.Text = "PARTY WISE SODA COMPLETED";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkRed;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(761, 552);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(272, 39);
            this.button8.TabIndex = 103;
            this.button8.Text = "PRODUCT WISE SODA COMPLETED";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1358, 664);
            this.ControlBox = false;
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnprofitdate);
            this.Controls.Add(this.btntypestock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.producttype);
            this.Controls.Add(this.allproductsstock);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.btnprofit);
            this.Controls.Add(this.profitratoio);
            this.Controls.Add(this.productswise);
            this.Controls.Add(this.productwisestock);
            this.Controls.Add(this.purchasecustomer);
            this.Controls.Add(this.purchaseproduct);
            this.Controls.Add(this.dailypurchase);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.productbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker date2;
        public System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button purchasecustomer;
        private System.Windows.Forms.Button purchaseproduct;
        private System.Windows.Forms.Button dailypurchase;
        private System.Windows.Forms.Button productwisestock;
        private System.Windows.Forms.Button productswise;
        private System.Windows.Forms.Button profitratoio;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox customerbox;
        public System.Windows.Forms.ListBox productbox;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnprofit;
        private MetroFramework.Controls.MetroTextBox txtCustomer;
        private MetroFramework.Controls.MetroTextBox txtProduct;
        private System.Windows.Forms.Button allproductsstock;
        public System.Windows.Forms.ListBox producttype;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btntypestock;
        private System.Windows.Forms.Button btnprofitdate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}