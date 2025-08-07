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
    public partial class frmCustomer : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        string namee;
        public frmCustomer()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

        }

        public void getCustomerid()
        {
            try
            {
                string ccode;

                cn.Open();
         
                cm = new SqlCommand("Select top 1  REPLACE(STR(MAX(CAST(Right(ccode, 4) as INT)), 4), SPACE(0), '0') as ccode  from tblCustomer group by ccode order by ccode desc  ", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count < 1)
                {
                        ccode = "1";
                        ctcode.Text = ccode;
                    
                
                }
                else
                {
                        ctcode.Text = (int.Parse(dt.Rows[0]["ccode"].ToString()) + 1).ToString();
                   

                }  
               
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
         
        }

        private void cbtype_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;
        }

        private void cbtype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ctname.Focus();

            }
        }

        private void ctname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ctArea.Focus();

            }
        }

        private void ctArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ctPhone.Focus();
            }
        }

        private void ctPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void ctDebit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ctCredit.Focus();
            }
        }

        private void ctCredit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void ctPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 )
            {
                e.Handled = true;
            }
        }

        private void ctDebit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void ctCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            getCustomerid();
            LoadRecords();
        }

        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCustomerid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ctname.Text != string.Empty)
                {
                    if (MessageBox.Show("Are you sure you want to add this Customer/Company?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("select cname from tblCustomer where cname = '" + ctname.Text + "'", cn);
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cm);
                        da.Fill(dt);
                        cn.Close();
                        if (dt.Rows.Count == 0)
                        {
                            cn.Open();
                            cm = new SqlCommand("INSERT INTO tblCustomer(ctype,ccode,cname,carea,cphone,cdebit,ccredit) VALUES (@ctype,@ccode,@cname,@carea,@cphone,@cdebit,@ccredit)", cn);
                            cm.Parameters.AddWithValue("@ctype", cbtype.Text);
                            cm.Parameters.AddWithValue("@ccode", ctcode.Text);
                            cm.Parameters.AddWithValue("@cname", ctname.Text);
                            cm.Parameters.AddWithValue("@carea", ctArea.Text);
                            cm.Parameters.AddWithValue("@cphone", ctPhone.Text);
                            cm.Parameters.AddWithValue("@cdebit", ctDebit.Text);
                            cm.Parameters.AddWithValue("@ccredit", ctCredit.Text);
                            cm.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Customer has been Successfully Saved. ");
                            clear();
                            LoadRecords();
                        }
                        else
                        {
                            MessageBox.Show("This Name is Already Registered.");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("PLEASE FILL ALL BLANKS");
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadRecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select * from tblCustomer where cname like '%" + txtSearch.Text + "%' order by cname ASC", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            cn.Close();
        }
        public void clear()
        {
            ctname.Clear();
            ctArea.Clear();
            ctPhone.Clear();
            ctDebit.Clear();
            ctCredit.Clear();
            ctCredit.Text = "0";
            ctDebit.Text = "0";
            getCustomerid();
            ctname.Focus();


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            LoadRecords();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbtype.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            ctcode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            ctname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            ctArea.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            ctPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            ctDebit.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            ctCredit.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            namee = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblCustomer SET ctype=@ctype,ccode=@ccode,cname=@cname,carea=@carea,cphone=@cphone,cdebit=@cdebit,ccredit=@ccredit where ccode like @ccode", cn);
                    cm.Parameters.AddWithValue("@ctype", cbtype.Text);
                    cm.Parameters.AddWithValue("@ccode", ctcode.Text);
                    cm.Parameters.AddWithValue("@cname", ctname.Text);
                    cm.Parameters.AddWithValue("@carea", ctArea.Text);
                    cm.Parameters.AddWithValue("@cphone", ctPhone.Text);
                    cm.Parameters.AddWithValue("@cdebit", ctDebit.Text);
                    cm.Parameters.AddWithValue("@ccredit", ctCredit.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("UPDATE tblPayment SET cname=@cname where cname like '"+namee+"'", cn);
                    cm.Parameters.AddWithValue("@cname", ctname.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();


                    cn.Open();
                    cm = new SqlCommand("UPDATE tblRecipt SET cname=@cname where cname like '" + namee + "'", cn);
                    cm.Parameters.AddWithValue("@cname", ctname.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();


                    cn.Open();
                    cm = new SqlCommand("UPDATE tblSale SET cname=@cname where cname like '" + namee + "'", cn);
                    cm.Parameters.AddWithValue("@cname", ctname.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();


                    cn.Open();
                    cm = new SqlCommand("UPDATE tblPurchase SET cname=@cname where cname like '" + namee + "'", cn);
                    cm.Parameters.AddWithValue("@cname", ctname.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("UPDATE tblSoda SET cname=@cname where cname like '" + namee + "'", cn);
                    cm.Parameters.AddWithValue("@cname", ctname.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("UPDATE tblSodaReport SET cname=@cname where cname like '" + namee + "'", cn);
                    cm.Parameters.AddWithValue("@cname", ctname.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Customer has been Successfully Update. ");
                    clear();
                    LoadRecords();

                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete>", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("delete from tblCustomer where ccode like '" + ctcode.Text + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                clear();
                LoadRecords();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ctcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
