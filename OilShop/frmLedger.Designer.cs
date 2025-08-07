namespace OilShop
{
    partial class frmLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLedger));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.opnbal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.crt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.netbal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.billbook = new System.Windows.Forms.Button();
            this.cashbook = new System.Windows.Forms.Button();
            this.FullList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btndebit = new System.Windows.Forms.Button();
            this.btncredit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "LEDGER";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1358, 414);
            this.dataGridView1.TabIndex = 45;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 39;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "DATE";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 61;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "V NO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "DESCRIPTION";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "DEBIT";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 64;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "CREDIT";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 73;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "BALANCE";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 85;
            // 
            // date1
            // 
            this.date1.Checked = false;
            this.date1.CustomFormat = " dd/MM/yyyy";
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(1109, 449);
            this.date1.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(228, 25);
            this.date1.TabIndex = 46;
            this.date1.ValueChanged += new System.EventHandler(this.date1_ValueChanged);
            this.date1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date1_KeyDown);
            // 
            // date2
            // 
            this.date2.Checked = false;
            this.date2.CustomFormat = " dd/MM/yyyy";
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2.Location = new System.Drawing.Point(1109, 480);
            this.date2.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(228, 25);
            this.date2.TabIndex = 47;
            this.date2.ValueChanged += new System.EventHandler(this.date2_ValueChanged);
            this.date2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date2_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "OPENING BALANCE";
            // 
            // opnbal
            // 
            this.opnbal.Location = new System.Drawing.Point(16, 469);
            this.opnbal.Name = "opnbal";
            this.opnbal.Size = new System.Drawing.Size(239, 25);
            this.opnbal.TabIndex = 63;
            this.opnbal.Text = "0";
            this.opnbal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(363, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "DEBIT TOTAL";
            // 
            // drt
            // 
            this.drt.Location = new System.Drawing.Point(289, 469);
            this.drt.Name = "drt";
            this.drt.Size = new System.Drawing.Size(240, 25);
            this.drt.TabIndex = 65;
            this.drt.Text = "0";
            this.drt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(640, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 68;
            this.label4.Text = "CREDIT TOTAL";
            // 
            // crt
            // 
            this.crt.Location = new System.Drawing.Point(579, 469);
            this.crt.Name = "crt";
            this.crt.Size = new System.Drawing.Size(215, 25);
            this.crt.TabIndex = 67;
            this.crt.Text = "0";
            this.crt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(915, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "NET BALANCE";
            // 
            // netbal
            // 
            this.netbal.Location = new System.Drawing.Point(852, 469);
            this.netbal.Name = "netbal";
            this.netbal.Size = new System.Drawing.Size(219, 25);
            this.netbal.TabIndex = 69;
            this.netbal.Text = "0";
            this.netbal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(23, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 72;
            this.label7.Text = "CUSTOMER NAME";
            // 
            // cname
            // 
            this.cname.FormattingEnabled = true;
            this.cname.Location = new System.Drawing.Point(163, 523);
            this.cname.MaxDropDownItems = 3;
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(908, 25);
            this.cname.TabIndex = 71;
            this.cname.SelectedIndexChanged += new System.EventHandler(this.cname_SelectedIndexChanged);
            this.cname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cname_KeyPress);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkRed;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1109, 523);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(228, 30);
            this.btnPrint.TabIndex = 73;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // billbook
            // 
            this.billbook.BackColor = System.Drawing.Color.DarkRed;
            this.billbook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.billbook.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billbook.ForeColor = System.Drawing.Color.White;
            this.billbook.Location = new System.Drawing.Point(866, 624);
            this.billbook.Name = "billbook";
            this.billbook.Size = new System.Drawing.Size(194, 30);
            this.billbook.TabIndex = 76;
            this.billbook.Text = "BILL BOOK";
            this.billbook.UseVisualStyleBackColor = false;
            this.billbook.Click += new System.EventHandler(this.billbook_Click);
            // 
            // cashbook
            // 
            this.cashbook.BackColor = System.Drawing.Color.DarkRed;
            this.cashbook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cashbook.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashbook.ForeColor = System.Drawing.Color.White;
            this.cashbook.Location = new System.Drawing.Point(866, 574);
            this.cashbook.Name = "cashbook";
            this.cashbook.Size = new System.Drawing.Size(194, 30);
            this.cashbook.TabIndex = 75;
            this.cashbook.Text = "CASH BOOK";
            this.cashbook.UseVisualStyleBackColor = false;
            this.cashbook.Click += new System.EventHandler(this.cashbook_Click);
            // 
            // FullList
            // 
            this.FullList.BackColor = System.Drawing.Color.DarkRed;
            this.FullList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FullList.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.FullList.ForeColor = System.Drawing.Color.White;
            this.FullList.Location = new System.Drawing.Point(1109, 574);
            this.FullList.Name = "FullList";
            this.FullList.Size = new System.Drawing.Size(228, 30);
            this.FullList.TabIndex = 77;
            this.FullList.Text = "ALL RECIVEABLE AND PAYABLE";
            this.FullList.UseVisualStyleBackColor = false;
            this.FullList.Click += new System.EventHandler(this.FullList_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1109, 622);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 30);
            this.button1.TabIndex = 78;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndebit
            // 
            this.btndebit.BackColor = System.Drawing.Color.DarkRed;
            this.btndebit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndebit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndebit.ForeColor = System.Drawing.Color.White;
            this.btndebit.Location = new System.Drawing.Point(600, 574);
            this.btndebit.Name = "btndebit";
            this.btndebit.Size = new System.Drawing.Size(194, 30);
            this.btndebit.TabIndex = 79;
            this.btndebit.Text = "Debit Party";
            this.btndebit.UseVisualStyleBackColor = false;
            this.btndebit.Click += new System.EventHandler(this.btndebit_Click);
            // 
            // btncredit
            // 
            this.btncredit.BackColor = System.Drawing.Color.DarkRed;
            this.btncredit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncredit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncredit.ForeColor = System.Drawing.Color.White;
            this.btncredit.Location = new System.Drawing.Point(600, 624);
            this.btncredit.Name = "btncredit";
            this.btncredit.Size = new System.Drawing.Size(194, 30);
            this.btncredit.TabIndex = 80;
            this.btncredit.Text = "Credit Party";
            this.btncredit.UseVisualStyleBackColor = false;
            this.btncredit.Click += new System.EventHandler(this.btncredit_Click);
            // 
            // frmLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1358, 664);
            this.ControlBox = false;
            this.Controls.Add(this.btncredit);
            this.Controls.Add(this.btndebit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FullList);
            this.Controls.Add(this.billbook);
            this.Controls.Add(this.cashbook);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.netbal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.crt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opnbal);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLedger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLedger_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox drt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox crt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox netbal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        public System.Windows.Forms.ComboBox cname;
        public System.Windows.Forms.DateTimePicker date1;
        public System.Windows.Forms.DateTimePicker date2;
        public System.Windows.Forms.TextBox opnbal;
        private System.Windows.Forms.Button billbook;
        private System.Windows.Forms.Button cashbook;
        private System.Windows.Forms.Button FullList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btndebit;
        private System.Windows.Forms.Button btncredit;
    }
}