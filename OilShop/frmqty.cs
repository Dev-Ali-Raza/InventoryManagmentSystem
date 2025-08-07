using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OilShop
{
    public partial class frmqty : Form
    {
        public float quantity = 0;
        public frmqty()
        {
            InitializeComponent();
        }

     

        private void qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
            {

            }
            else if (e.KeyChar == 8)
            {

            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                e.Handled = true;
                
                
            }
        }

        private void qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                quantity = float.Parse(qty.Text);
                this.Dispose();
            }
        }
    }
}
