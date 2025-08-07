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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            frmDisplay frm = new frmDisplay(this);
             frm.TopLevel = false;
             panel2.Controls.Add(frm);
             frm.BringToFront();
             frm.Show();
         
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this?", "CLOSE APPLICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                System.Environment.Exit(0);
            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this?", "CLOSE APPLICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                System.Environment.Exit(0);
            }
        }

        private void uSERREGISTRATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void uSERREGISTRATIONToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void eXITToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this?", "CLOSE APPLICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                System.Environment.Exit(0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
                this.WindowState = FormWindowState.Minimized;
    
        }
    }
}
