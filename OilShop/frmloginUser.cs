using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilShop
{
    public partial class frmloginUser : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        public frmloginUser()
        {
            InitializeComponent();

            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this?", "CLOSE APPLICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                System.Environment.Exit(0);
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from tbllogin where status = 'Active' ", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    dr.Close();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("select * from tbllogin where username = @username and password = @password and status = 'Active' ", cn);
                    cm.Parameters.AddWithValue("@username", txtname.Text);
                    cm.Parameters.AddWithValue("@password", txtpassword.Text);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        dr.Close();
                        cn.Close();

                        Form1 f = new Form1();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        dr.Close();
                        cn.Close();

                        MessageBox.Show("INCORRECT USER OR PASS", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtname.Focus();
                    }
                }
                else
                {
                    dr.Close();
                    cn.Close();
                    MessageBox.Show("YOU SOFTWARE LIMIT IS FINISH. PLEASE CONTACT TO DEVELOPER. ALI RAZA 03127358583"); 
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }

        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btnlogin.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;
        }

        private void frmloginUser_Load(object sender, EventArgs e)
        {
            //DateTime dileverydate = DateTime.Now;
            //var todaysDate = new DateTime(2023, 12, 31);
            //int result = DateTime.Compare(dileverydate, todaysDate);

            //if (result == 1)
            //{
            //    MessageBox.Show("YOU SOFTWARE LIMIT IS FINISH. PLEASE CONTACT TO DEVELOPER. ALI RAZA 03127358583");

            //    cn.Open();
            //    cm = new SqlCommand("update tbllogin set status = 'Block' ", cn);
            //    cm.ExecuteNonQuery();
            //    cn.Close();

            //    this.Close();
            //    System.Environment.Exit(0);
            //}
        }
    }
    
}
