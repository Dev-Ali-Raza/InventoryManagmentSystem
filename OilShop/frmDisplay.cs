using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilShop
{
    public partial class frmDisplay : Form
    {
        Form1 f1;
        public frmDisplay(Form1 ff)
        {
            InitializeComponent();
            f1 = ff;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
             frmCustomer fc = new frmCustomer();
             fc.ShowDialog();

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProduct fp = new frmProduct();
            fp.ShowDialog();
        }

        private void frmDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                btnCustomer.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.P)
            {
                btnProduct.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.V)
            {
                btnCashbook.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.B)
            {
                btnBillBook.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.L)
            {
                btnledger.PerformClick();
            }

        }

        private void btnCashbook_Click(object sender, EventArgs e)
        {
            frmCashBook fcb = new frmCashBook(f1);
            fcb.Hide();
            fcb.TopLevel = false;
            f1.panel2.Controls.Add(fcb);
            fcb.BringToFront();
            fcb.Show();

        }

        private void btnBillBook_Click(object sender, EventArgs e)
        {
            frmBillBook fcb = new frmBillBook(f1);
            fcb.Hide();
            fcb.TopLevel = false;
            f1.panel2.Controls.Add(fcb);
            fcb.BringToFront();
            fcb.Show();
        }

        private void btnledger_Click(object sender, EventArgs e)
        {
            frmLedger fcb = new frmLedger(f1);
            fcb.Hide();
            fcb.TopLevel = false;
            f1.panel2.Controls.Add(fcb);
            fcb.BringToFront();
            fcb.Show();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReports fcb = new frmReports();
            fcb.Hide();
            fcb.TopLevel = false;
            f1.panel2.Controls.Add(fcb);
            fcb.BringToFront();
            fcb.Show();
        }

        private void frmDisplay_Load(object sender, EventArgs e)
        {

        }

        private void btnsodabook_Click(object sender, EventArgs e)
        {
            FrmSodaBook fcb = new FrmSodaBook();
            fcb.Hide();
            fcb.TopLevel = false;
            f1.panel2.Controls.Add(fcb);
            fcb.BringToFront();
            fcb.Show();
        }
    }
}
