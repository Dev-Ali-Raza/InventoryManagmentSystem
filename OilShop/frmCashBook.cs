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
using System.Collections;

namespace OilShop
{
    public partial class frmCashBook : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        Form1 f1;
        public frmCashBook(Form1 ff)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f1 = ff;
          
        }

        private void frmCashBook_Load(object sender, EventArgs e)
        {
            cname.Focus();
            getcustomer();
            getcustomer1();
            getdespr();
            getRVno();
            getPVno();
            LoadRecords();
            LoadRecords1();
           
        }

        public void getcustomer()
        {
            cn.Open();
            cm = new SqlCommand("select cname from tblCustomer order by cname", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cnamelist.ValueMember = "cname";
            cnamelist.DisplayMember = "cname";
            cnamelist.DataSource = ds.Tables[0];
            cnamelist.SelectedIndex = -1;
            //cnamelist1.ValueMember = "cname";
            //cnamelist1.DisplayMember = "cname";
            //cnamelist1.DataSource = ds.Tables[0];
            //cnamelist1.SelectedIndex = 0;
            cname.ValueMember = "cname";
            cname.DisplayMember = "cname";
            cname.DataSource = ds.Tables[0];
            cname.SelectedIndex = -1;
            //cname1.ValueMember = "cname";
            //cname1.DisplayMember = "cname";
            //cname1.DataSource = ds.Tables[0];
            //cname1.SelectedIndex = -1;
            cm.ExecuteNonQuery();
            cn.Close();
        }

        public void getcustomer1()
        {
            cn.Open();
            cm = new SqlCommand("select cname from tblCustomer order by cname", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cnamelist1.ValueMember = "cname";
            cnamelist1.DisplayMember = "cname";
            cnamelist1.DataSource = ds.Tables[0];
            cnamelist1.SelectedIndex = -1;
            //cnamelist1.ValueMember = "cname";
            //cnamelist1.DisplayMember = "cname";
            //cnamelist1.DataSource = ds.Tables[0];
            //cnamelist1.SelectedIndex = 0;
            cname1.ValueMember = "cname";
            cname1.DisplayMember = "cname";
            cname1.DataSource = ds.Tables[0];
            cname1.SelectedIndex = -1;
            //cname1.ValueMember = "cname";
            //cname1.DisplayMember = "cname";
            //cname1.DataSource = ds.Tables[0];
            //cname1.SelectedIndex = -1;
            cm.ExecuteNonQuery();
            cn.Close();
        }

        public void getdespr()
        {
            cn.Open();
            cm = new SqlCommand("select despr from tbldes order by despr", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            despc.ValueMember = "despr";
            despc.DisplayMember = "despr";
            despc.DataSource = ds.Tables[0];
            despc.SelectedIndex = -1;
            despc1.ValueMember = "despr";
            despc1.DisplayMember = "despr";
            despc1.DataSource = ds.Tables[0];
            despc1.SelectedIndex = -1;
            cm.ExecuteNonQuery();
            cn.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void getRVno()
        {
            try
            {

                cn.Open();
                cm = new SqlCommand("Select top 1  vno  from tblRecipt where vtype = '" + "CV" + "' order by vno desc  ", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count < 1)
                {
                    rvno.Text = "1";

                }
                else
                {
                    
                        rvno.Text = (int.Parse(dt.Rows[0]["vno"].ToString()) + 1).ToString();
                    
                }

                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        public void getPVno()
        {
            try
            {

                cn.Open();
                cm = new SqlCommand("Select top 1  vno  from tblPayment where vtype = '" + "CV" + "' order by vno desc  ", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count < 1)
                {
                    pvno.Text = "1";

                }
                else
                {

                    pvno.Text = (int.Parse(dt.Rows[0]["vno"].ToString()) + 1).ToString();

                }

                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void s_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("insert into tbldes (despr) values (@despr)", cn);
            cm.Parameters.AddWithValue("@despr", despc.Text);
            cm.ExecuteNonQuery();
            cn.Close();
            getdespr();
        }

        private void d_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("delete from tbldes where despr like '" + despc.Text + "'", cn);
            cm.ExecuteNonQuery();
            cn.Close();
            despc.Text = "";
            getdespr();
        }

        private void cname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                despc.Focus();
            }
        }

        private void despc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                amount.Focus();
            }
        }

        private void amount_KeyDown(object sender, KeyEventArgs e)
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
                if (cnamelist.Text != string.Empty && amount.Text != string.Empty)
                {


                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblRecipt(Date,vno,cname,despr,amount,vtype) VALUES (@Date,@vno,@cname,@despr,@amount,@vtype)", cn);
                    cm.Parameters.AddWithValue("@date", date1.Value);
                    cm.Parameters.AddWithValue("@vno", rvno.Text);
                    cm.Parameters.AddWithValue("@cname", cnamelist.Text);
                    cm.Parameters.AddWithValue("@despr", despc.Text);
                    cm.Parameters.AddWithValue("@amount", amount.Text);
                    cm.Parameters.AddWithValue("@vtype", "CV");
                    cm.ExecuteNonQuery();
                    cn.Close();
                    clear();
                    LoadRecords();
                    

                }
                else
                {
                    MessageBox.Show("PLEASE FILL ALL BLANKS");
                    cname.Focus();
                }
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
                cname.Focus();
            }
            }
        public void clear()
        {
            cname.Text = "";
            despc.Text = "";
            amount.Clear();
            getRVno();

            cname.Focus();
        }

        public void LoadRecords()
        {
            try
            {
                dataGridView1.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("select * from tblRecipt where Date = '" + date1.Value.ToShortDateString() + "' and vtype = '" + "CV" + "'", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), DateTime.Parse(dr[1].ToString()).ToString("dd/MM/yyyy"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
                if (dr.HasRows)
                {
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                };
                cn.Close();
                Cash();
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {
            date2.Value = date1.Value;
            LoadRecords();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnamelist.Text != string.Empty && amount.Text != string.Empty)
                {


                    cn.Open();
                    cm = new SqlCommand("UPDATE tblRecipt Set Date=@Date,vno=@vno,cname=@cname,despr=@despr,amount=@amount,vtype=@vtype where id like @id ", cn);
                    cm.Parameters.AddWithValue("@date", date1.Value);
                    cm.Parameters.AddWithValue("@id", idrep.Text);
                    cm.Parameters.AddWithValue("@vno", rvno.Text);
                    cm.Parameters.AddWithValue("@cname", cnamelist.Text);
                    cm.Parameters.AddWithValue("@despr", despc.Text);
                    cm.Parameters.AddWithValue("@amount", amount.Text);
                    cm.Parameters.AddWithValue("@vtype", "CV");
                    cm.ExecuteNonQuery();
                    cn.Close();
                    clear();
                    LoadRecords();
                    MessageBox.Show("succesfully Updated!");

                }
                else
                {
                    MessageBox.Show("PLEASE FILL ALL BLANKS");
                    cname.Focus();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "DELETE")
            {
                if (MessageBox.Show("Remove this Row?", "Remove?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tblRecipt where id = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Records has been Successfully Removed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                    clear();

                }

            }
         else
            {
                idrep.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                rvno.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                despc.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                amount.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                cname.Focus();

            }

        
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void Cash()
        {
            long amountrec = 0;
            cn.Open();
            cm = new SqlCommand("select sum(amount) as sa from tblRecipt where Date < '" + date1.Value.ToShortDateString() + "' and  vtype = '" + "CV" + "' ", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            if (dt.Rows[0]["sa"] != DBNull.Value)
            {
              
                amountrec = amountrec + long.Parse(dt.Rows[0]["sa"].ToString());
            }   
            long amountpay = 0;
            cn.Open();
            cm = new SqlCommand("select sum(amount) as sa from tblPayment where Date < '" + date2.Value.ToShortDateString() + "' and  vtype = '" + "CV" + "' ", cn);
            SqlDataAdapter da1 = new SqlDataAdapter(cm);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cn.Close();
            if (dt1.Rows[0]["sa"] != DBNull.Value)
                {
                amountpay = amountpay + long.Parse(dt1.Rows[0]["sa"].ToString());
                }
            long openbalance = amountrec - amountpay;
            Balance.Text = openbalance.ToString();

            long amounttotal = 0;
            cn.Open();
            cm = new SqlCommand("select sum(amount) as sa from tblRecipt where Date = '" + date1.Value.ToShortDateString() + "' and  vtype = '" + "CV" + "' ", cn);
            SqlDataAdapter da2 = new SqlDataAdapter(cm);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cn.Close();
            if (dt2.Rows[0]["sa"] != DBNull.Value)
            {

                amounttotal = amounttotal + long.Parse(dt2.Rows[0]["sa"].ToString());
            }

            long amountpay1 = 0;
            cn.Open();
            cm = new SqlCommand("select sum(amount) as sa from tblPayment where Date = '" + date2.Value.ToShortDateString() + "' and  vtype = '" + "CV" + "' ", cn);
            SqlDataAdapter da3 = new SqlDataAdapter(cm);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            cn.Close();
            if (dt3.Rows[0]["sa"] != DBNull.Value)
            {
                amountpay1 = amountpay1 + long.Parse(dt3.Rows[0]["sa"].ToString());
            }

            long Balance1 = openbalance + amounttotal;
            long cashhand = Balance1 - amountpay1;
            long balance2 = cashhand + amountpay1;

            recovery.Text = amounttotal.ToString() ;
            Netbalance.Text = Balance1.ToString() ;
            rec1.Text = amountpay1.ToString();
            cashinhand.Text = cashhand.ToString() ;
            netbal.Text = balance2.ToString();



        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {
            date1.Value = date2.Value;
            LoadRecords1();
        }

        private void cname1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                despc1.Focus();
            }
        }

        private void despc1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                amount1.Focus();
            }
        }

        private void amount1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnsavep.Focus();
            }
        }

        private void btnsavep_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnamelist1.Text != string.Empty && amount1.Text != string.Empty)
                {


                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblPayment(Date,vno,cname,despr,amount,vtype) VALUES (@Date,@vno,@cname,@despr,@amount,@vtype)", cn);
                    cm.Parameters.AddWithValue("@date", date2.Value);
                    cm.Parameters.AddWithValue("@vno", pvno.Text);
                    cm.Parameters.AddWithValue("@cname", cnamelist1.Text);
                    cm.Parameters.AddWithValue("@despr", despc1.Text);
                    cm.Parameters.AddWithValue("@amount", amount1.Text);
                    cm.Parameters.AddWithValue("@vtype", "CV");
                    cm.ExecuteNonQuery();
                    cn.Close();
                    clear1();
                    LoadRecords1();


                }
                else
                {
                    MessageBox.Show("PLEASE FILL ALL BLANKS");
                    cname1.Focus();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
                cname1.Focus();
            }

        }

        public void clear1()
        {
            cname1.Text = "";
            despc1.Text = "";
            amount1.Clear();
            getPVno();

            cname1.Focus();
        }

        public void LoadRecords1()
        {
            try
            {
                dataGridView2.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("select * from tblPayment where Date = '" + date2.Value.ToShortDateString() + "' and  vtype = '" + "CV" + "' ", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    dataGridView2.Rows.Add(dr[0].ToString(), DateTime.Parse(dr[1].ToString()).ToString("dd/MM/yyyy"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());

                }
                if (dr.HasRows)
                {
                    dataGridView2.FirstDisplayedScrollingRowIndex = dataGridView2.RowCount - 1;
                };
                cn.Close();

                Cash();
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdatep_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnamelist1.Text != string.Empty && amount1.Text != string.Empty)
                {


                    cn.Open();
                    cm = new SqlCommand("UPDATE tblPayment Set Date=@Date,vno=@vno,cname=@cname,despr=@despr,amount=@amount,vtype=@vtype where id like @id ", cn);
                    cm.Parameters.AddWithValue("@date", date2.Value);
                    cm.Parameters.AddWithValue("@id", idpay.Text);
                    cm.Parameters.AddWithValue("@vno", pvno.Text);
                    cm.Parameters.AddWithValue("@cname", cnamelist1.Text);
                    cm.Parameters.AddWithValue("@despr", despc1.Text);
                    cm.Parameters.AddWithValue("@amount", amount1.Text);
                    cm.Parameters.AddWithValue("@vtype", "CV");
                    cm.ExecuteNonQuery();
                    cn.Close();
                    clear1();
                    LoadRecords1();
                    MessageBox.Show("succesfully Updated!");

                }
                else
                {
                    MessageBox.Show("PLEASE FILL ALL BLANKS");
                    cname1.Focus();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = dataGridView2.Columns[e.ColumnIndex].Name;
            if (colName == "DELETE1")
            {
                if (MessageBox.Show("Remove this Row?", "Remove?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tblPayment where id = '" + dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Records has been Successfully Removed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords1();
                    clear1();

                }

            }
            else
            {
                idpay.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                pvno.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                cname1.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                despc1.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                amount1.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
                cname1.Focus();

            }

        }

        private void btnclearp_Click(object sender, EventArgs e)
        {
            clear1();
        }

        private void cname_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnamelist.Text = cname.Text;
           
        }

        private void cname1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnamelist1.Text = cname1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBillBook fcb = new frmBillBook(f1);
            fcb.Hide();
            fcb.TopLevel = false;
            f1.panel2.Controls.Add(fcb);
            fcb.BringToFront();
            fcb.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLedger fcb = new frmLedger(f1);
            fcb.Hide();
            fcb.TopLevel = false;
            f1.panel2.Controls.Add(fcb);
            fcb.BringToFront();
            fcb.Show();



        }

        private void date1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cname.Focus();
            }
        }

        private void date2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cname1.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCBReport cb = new frmCBReport(this);
            cb.loadReportCashBook();
            cb.ShowDialog();
        }
    }
}
