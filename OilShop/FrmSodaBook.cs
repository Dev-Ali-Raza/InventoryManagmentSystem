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
using System.Globalization;

namespace OilShop
{
    public partial class FrmSodaBook : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        public FrmSodaBook()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmSodaBook_Load(object sender, EventArgs e)
        {
            
            getproductname();
            getcustomer();
            LoadRecords();
            date1.Focus();
        }

        private void getproductname()
        {
            cn.Open();
            cm = new SqlCommand("SELECT pname from tblProduct order by pname asc", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            pname.ValueMember = "pname";
            pname.DisplayMember = "pname";
            cn.Close();
            pname.DataSource = ds.Tables[0];

            pname.Enabled = true;
            this.pname.SelectedIndex = -1;
            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();
        }
        public void getcustomer()
        {
            cn.Open();
            cm = new SqlCommand("select cname from tblCustomer order by cname", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cname.ValueMember = "cname";
            cname.DisplayMember = "cname";
            cname.DataSource = ds.Tables[0];
            cname.Enabled = true;
            this.cname.SelectedIndex = -1;
            cm.ExecuteNonQuery();
            cn.Close();
        }
       
        private void date1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cname.Focus();
            }
        }

        private void cname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                despr.Focus();
            }
        }

        private void Billno_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void despr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pname.Focus();
            }
        }

        private void pricee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                qtyy.Focus();
            }
        }

        private void qtyy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        public void LoadRecords()
        {
            try
            {
                ledger.Rows.Clear();
                
                int i = 0;
                double total = 0;
                int item = 0;
                cn.Open();
                cm = new SqlCommand("select * from tblSoda where cname like '%"+txtSearch.Text+"%' and vno like '%S' order by id", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    ledger.Rows.Add(dr["id"].ToString(), DateTime.Parse(dr["Date"].ToString()).ToString("dd/MM/yyyy hh:mm:ss"), dr["vno"].ToString(), dr["cname"].ToString(), dr["detail"].ToString(), dr["pname"].ToString(), dr["price"].ToString(),  dr["qty"].ToString());


                }
               
                if (dr.HasRows)
                {
                    ledger.FirstDisplayedScrollingRowIndex = ledger.RowCount - 1;

                };
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void Billno_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                    cn.Open();
                    cm = new SqlCommand("insert into tblSoda(Date,vno,cname,detail,pname,price,qty)values(@Date,@vno,@cname,@detail,@pname,@price,@qty)", cn);
                    cm.Parameters.AddWithValue("@Date", date1.Value);
                    cm.Parameters.AddWithValue("@vno", "S");
                    cm.Parameters.AddWithValue("@cname", cname.Text);
                    cm.Parameters.AddWithValue("@detail", despr.Text);
                    cm.Parameters.AddWithValue("@pname", pname.Text);
                    cm.Parameters.AddWithValue("@price", pricee.Text);
                    cm.Parameters.AddWithValue("@qty", qtyy.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    
                    LoadRecords();

                    cn.Open();
                    cm = new SqlCommand("select top 1 id from tblSoda order by id desc",cn);
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("insert into tblSodaReport(cname,pname,price,qty,sodadate,id,detail)values(@cname,@pname,@price,@qty,@sodadate,@id,@detail)", cn);
                   
                    cm.Parameters.AddWithValue("@cname", cname.Text);
                    cm.Parameters.AddWithValue("@pname", pname.Text);
                    cm.Parameters.AddWithValue("@price", pricee.Text);
                    cm.Parameters.AddWithValue("@qty", qtyy.Text);
                    cm.Parameters.AddWithValue("@sodadate", date1.Value);
                    cm.Parameters.AddWithValue("@id", dt.Rows[0][0].ToString());
                    cm.Parameters.AddWithValue("@detail", despr.Text);


                cm.ExecuteNonQuery();
                    cn.Close();
                  
                    

                clear();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void clear()
        {
            getcustomer();
            getproductname();
            despr.Clear();
            qtyy.Clear();
            pricee.Clear();
            
            date1.Value = DateTime.Now;
            date1.Focus();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
                clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ledger_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = this.ledger.Columns[e.ColumnIndex].Name;
            if (colName == "DELETE")
            {
                if (MessageBox.Show("Remove this Row?", "Remove?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tblSoda where id = '" + this.ledger.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("delete from tblSodaReport where id = '" + this.ledger.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    LoadRecords();
                    MessageBox.Show("ROW has been Successfully DELETED. ");
                    clear();
                }
            }
           /** else
            {
                cname.Enabled = false;
                pname.Enabled = false;

                txtid.Text = ledger.Rows[e.RowIndex].Cells[0].Value.ToString();
                string date = ledger.Rows[e.RowIndex].Cells[1].Value.ToString();
                CultureInfo culture = new CultureInfo("pt-PT");
                date1.Value = DateTime.ParseExact(date, "dd/MM/yyyy hh:mm:ss",
                                        culture, System.Globalization.DateTimeStyles.None);

                cname.Text = ledger.Rows[e.RowIndex].Cells[3].Value.ToString();
                despr.Text = ledger.Rows[e.RowIndex].Cells[4].Value.ToString();
                pname.Text = ledger.Rows[e.RowIndex].Cells[5].Value.ToString();
                pricee.Text = ledger.Rows[e.RowIndex].Cells[6].Value.ToString();
                qtyy.Text = ledger.Rows[e.RowIndex].Cells[7].Value.ToString();
             
                date1.Focus();
            }**/
        }

        private void pname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pricee.Focus();
            }
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ledger_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
            if (this.ledger.RowCount > 0)
            {
                cn.Open();
                cm = new SqlCommand("select * from tblSoda  where id = '" + this.ledger.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cn.Open();
                    cm = new SqlCommand("Update tblSodaReport set qty=qty -" + double.Parse(dt.Rows[i]["qty"].ToString()) + "  where id = '" + this.ledger.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);

                    cm.ExecuteNonQuery();
                    cn.Close();
                }

                    cn.Open();
                    cm = new SqlCommand("Update tblSoda set detail=@detail,price=@price,qty=@qty where id like '" + this.ledger.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                    cm.Parameters.AddWithValue("@detail", this.ledger.Rows[e.RowIndex].Cells["des"].Value.ToString());
                    cm.Parameters.AddWithValue("@price", double.Parse(this.ledger.Rows[e.RowIndex].Cells["price"].Value.ToString()));
                    cm.Parameters.AddWithValue("@qty", double.Parse(this.ledger.Rows[e.RowIndex].Cells["qty"].Value.ToString()));
                    cm.ExecuteNonQuery();
                    cn.Close();




                    cn.Open();
                    cm = new SqlCommand("select price,qty,detail from tblSoda  where id = '" + this.ledger.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                    SqlDataAdapter da1 = new SqlDataAdapter(cm);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    cn.Close();
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        cn.Open();
                        cm = new SqlCommand("Update tblSodaReport set qty=qty +" + double.Parse(dt1.Rows[i]["qty"].ToString()) + " , price=" + double.Parse(dt1.Rows[i]["price"].ToString()) + " , detail = '" + dt1.Rows[i]["detail"].ToString() + "'   where id = '" + this.ledger.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);

                        cm.ExecuteNonQuery();
                        cn.Close();
                    }





                }
        }

    
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
