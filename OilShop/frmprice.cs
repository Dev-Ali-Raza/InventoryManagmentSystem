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
    public partial class frmprice : Form
    {
        public float price1 = 0;
        public frmprice()
        {
            InitializeComponent();
        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
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

        private void price_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                price1 = float.Parse(price.Text);
                this.Dispose();
            }
        }
    }
}
