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
    public partial class frmLogin : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        public frmLogin()
        {
            InitializeComponent();

            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text != string.Empty && txtpassword.Text != string.Empty)
                {
                    cn.Open();
                    cm = new SqlCommand("insert into tbllogin (username,password,status) values(@username,@password,@status)", cn);
                    cm.Parameters.AddWithValue("@username", txtname.Text);
                    cm.Parameters.AddWithValue("@password", txtpassword.Text);
                    cm.Parameters.AddWithValue("@status", "Active");
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("New Account Has Been Saved!");
                    clear();
                    LoadRecord();

                }
                else
                {
                    MessageBox.Show("PLEASE! FILL EMPTY BALANKES");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clear()
        {
            txtname.Clear();
            txtpassword.Clear();
            txtname.Focus();
        }

        public void LoadRecord()
        {
            dataGridView1.Rows.Clear();
            int i = 0;
            cn.Open();
            cm = new SqlCommand("select * from tbllogin", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            cn.Close();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LoadRecord();
            txtname.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this USER?", "Delete USER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cn.Open();
                    cm = new SqlCommand("delete from tbllogin where username like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    LoadRecord();
                }
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
              btnSave.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
    
}
