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
    public partial class frmProduct : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        string namee;
        public frmProduct()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            pcode.Focus();
            gettypedata();
            LoadRecords();
        }

        public void gettypedata()
        {
            cn.Open();
            cm = new SqlCommand("select * from tblProductType", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ptype.ValueMember = "ptype";
            ptype.DisplayMember = "ptype";
            ptype.DataSource = ds.Tables[0];
            cm.ExecuteNonQuery();
            cn.Close();

        }

        private void s_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("insert into tblProductType (ptype) values (@ptype)", cn);
            cm.Parameters.AddWithValue("@ptype", ptype.Text);
            cm.ExecuteNonQuery();
            cn.Close();
            gettypedata();
        }

        private void d_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("delete from tblProductType where ptype like '" + ptype.Text + "'", cn);
            cm.ExecuteNonQuery();
            cn.Close();
            gettypedata();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pname.Focus();
            }
        }


        private void ptype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (pcode.Text != string.Empty && pname.Text != string.Empty)
                {
                    if (MessageBox.Show("Are you sure you want to add this Product?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tblProduct(pcode,pname,ptype) VALUES (@pcode,@pname,@ptype)", cn);
                        cm.Parameters.AddWithValue("@pcode", pcode.Text);
                        cm.Parameters.AddWithValue("@pname", pname.Text);
                        cm.Parameters.AddWithValue("@ptype", ptype.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Product has been Successfully Saved. ");
                        clear();
                        LoadRecords();

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

        public void clear()
        {
            pcode.Clear();
            pname.Clear();

            pcode.Enabled = true;
            pcode.Focus();
        }

        public void LoadRecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select * from tblProduct where pname like '%" + txtSearch.Text + "%' order by pname asc", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            cn.Close();
        }

        private void pname_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ptype.Focus();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pcode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            pname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            ptype.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            namee = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            pname.Focus();
            pcode.Enabled = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete>", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tblProduct where pcode like '" + pcode.Text + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    clear();
                    LoadRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cn.Open();
                    cm = new SqlCommand("UPDATE tblProduct SET pcode=@pcode,pname=@pname,ptype=@ptype where pcode like @pcode", cn);
                    cm.Parameters.AddWithValue("@pcode", pcode.Text);
                    cm.Parameters.AddWithValue("@pname", pname.Text);
                    cm.Parameters.AddWithValue("@ptype", ptype.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    

                    cn.Open();
                    cm = new SqlCommand("UPDATE tblSale SET pname=@pname where pname like '" + namee + "'", cn);
                    cm.Parameters.AddWithValue("@pname", pname.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();


                    cn.Open();
                    cm = new SqlCommand("UPDATE tblPurchase SET pname=@pname where pname like '" + namee + "'", cn);
                    cm.Parameters.AddWithValue("@pname", pname.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("UPDATE tblSoda SET pname=@pname where pname like '" + namee + "'", cn);
                    cm.Parameters.AddWithValue("@pname", pname.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("UPDATE tblSodaReport SET pname=@pname where pname like '" + namee + "'", cn);
                    cm.Parameters.AddWithValue("@pname", pname.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Product has been Successfully Update. ");
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
