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
    public partial class frmLedger : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        Form1 f1;

        public frmLedger(Form1 ff)
        {
            InitializeComponent();

            cn = new SqlConnection(dbcon.MyConnection());
            f1 = ff;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void date1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                date2.Focus();
            }

        }

        private void date2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                cname.Focus();
            }
        }

        public void getcustomer()
        {
            cn.Open();
            cm = new SqlCommand("select cname from tblCustomer order by cname", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cm.ExecuteNonQuery();
            cn.Close();
            cname.ValueMember = "cname";
            cname.DisplayMember = "cname";
            cname.DataSource = ds.Tables[0];
            cname.SelectedIndex = -1;      
        }
        public void loadreportallledger()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("Delete from tblLedger", cn);
                cm.ExecuteNonQuery();
                cn.Close();

                for(int j = 0; j < cname.Items.Count; j++)
                { 
                cn.Open();
                cm = new SqlCommand("Select sum(amount) from tblPayment where cname = '" + cname.GetItemText(cname.Items[j]) + "' ", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();

                cn.Open();
                    cm = new SqlCommand("Select sum(amount) from tblRecipt where cname = '" + cname.GetItemText(cname.Items[j]) + "' ", cn);
                SqlDataAdapter da1 = new SqlDataAdapter(cm);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                cn.Close();

                    Double t;
                    Double d,c;
                    if (dt.Rows[0][0] != DBNull.Value)
                    {
                        d = Double.Parse(dt.Rows[0][0].ToString());
                    }
                    else
                    {
                        d = 0;
                    }
                    if (dt1.Rows[0][0] != DBNull.Value)
                    {
                        c = Double.Parse(dt1.Rows[0][0].ToString());
                    }
                    else
                    {
                        c = 0;
                    }
                    t = d - c;

                    if (t != 0)
                    {
                        cn.Open();
                        cm = new SqlCommand("insert into tblLedger(cname,credit,debit)values(@cname,@credit,@debit)", cn);

                        cm.Parameters.AddWithValue("@cname", cname.GetItemText(cname.Items[j]));
                        if (t > 0)
                        {
                            cm.Parameters.AddWithValue("@credit", "0");
                            cm.Parameters.AddWithValue("@debit", t);
                        }
                        else
                        {
                            cm.Parameters.AddWithValue("@credit", t);
                            cm.Parameters.AddWithValue("@debit", "0");
                        }
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
        public void loadreportcredit()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("Delete from tblLedger", cn);
                cm.ExecuteNonQuery();
                cn.Close();

                for (int j = 0; j < cname.Items.Count; j++)
                {
                    cn.Open();
                    cm = new SqlCommand("Select sum(amount) from tblPayment where cname = '" + cname.GetItemText(cname.Items[j]) + "' ", cn);
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("Select sum(amount) from tblRecipt where cname = '" + cname.GetItemText(cname.Items[j]) + "' ", cn);
                    SqlDataAdapter da1 = new SqlDataAdapter(cm);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    cn.Close();

                    Double t;
                    Double d, c;
                    if (dt.Rows[0][0] != DBNull.Value)
                    {
                        d = Double.Parse(dt.Rows[0][0].ToString());
                    }
                    else
                    {
                        d = 0;
                    }
                    if (dt1.Rows[0][0] != DBNull.Value)
                    {
                        c = Double.Parse(dt1.Rows[0][0].ToString());
                    }
                    else
                    {
                        c = 0;
                    }
                    t = d - c;

                    if (t != 0)
                    {
                        cn.Open();
                        cm = new SqlCommand("insert into tblLedger(cname,credit)values(@cname,@credit)", cn);

                        cm.Parameters.AddWithValue("@cname", cname.GetItemText(cname.Items[j]));
                        if (t < 0)
                        {
                            cm.Parameters.AddWithValue("@credit", t);
                        }
                        else
                        {
                            cm.Parameters.AddWithValue("@credit", "0");
                        }
                     
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
        public void loadreportdebit()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("Delete from tblLedger", cn);
                cm.ExecuteNonQuery();
                cn.Close();

                for (int j = 0; j < cname.Items.Count; j++)
                {
                    cn.Open();
                    cm = new SqlCommand("Select sum(amount) from tblPayment where cname = '" + cname.GetItemText(cname.Items[j]) + "' ", cn);
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("Select sum(amount) from tblRecipt where cname = '" + cname.GetItemText(cname.Items[j]) + "' ", cn);
                    SqlDataAdapter da1 = new SqlDataAdapter(cm);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    cn.Close();

                    Double t;
                    Double d, c;
                    if (dt.Rows[0][0] != DBNull.Value)
                    {
                        d = Double.Parse(dt.Rows[0][0].ToString());
                    }
                    else
                    {
                        d = 0;
                    }
                    if (dt1.Rows[0][0] != DBNull.Value)
                    {
                        c = Double.Parse(dt1.Rows[0][0].ToString());
                    }
                    else
                    {
                        c = 0;
                    }
                    t = d - c;

                    if (t != 0)
                    {
                        cn.Open();
                        cm = new SqlCommand("insert into tblLedger(cname,debit)values(@cname,@debit)", cn);

                        cm.Parameters.AddWithValue("@cname", cname.GetItemText(cname.Items[j]));
                        if (t > 0)
                        {                    
                            cm.Parameters.AddWithValue("@debit", t);
                        }
                        else
                        {
                            cm.Parameters.AddWithValue("@debit", "0");
                        }
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
        private void frmLedger_Load(object sender, EventArgs e)
        {
            date1.Focus();
            getcustomer();
        }

        public void displayLedger()
        {
            try
            {
                if (!string.IsNullOrEmpty(cname.Text))
                {

                    cn.Open();
                    cm = new SqlCommand("Delete from tblLedger", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("Select * from tblPayment where cname = '" + cname.Text + "' order by vno ", cn);
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cn.Close();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cn.Open();
                        cm = new SqlCommand("insert into tblLedger(Date,cname,vno,debit,balance,despr)values(@Date,@cname,@vno,@debit,@balance,@despr)", cn);
                        cm.Parameters.AddWithValue("@Date", dt.Rows[i]["Date"].ToString());
                        cm.Parameters.AddWithValue("@cname", dt.Rows[i]["cname"].ToString());
                        cm.Parameters.AddWithValue("@vno", dt.Rows[i]["vno"].ToString() + "-" + dt.Rows[i]["vtype"].ToString());
                        cm.Parameters.AddWithValue("@debit", dt.Rows[i]["amount"].ToString());
                        cm.Parameters.AddWithValue("@balance", dt.Rows[i]["amount"].ToString());
                        cm.Parameters.AddWithValue("@despr", dt.Rows[i]["despr"].ToString());
                        cm.ExecuteNonQuery();
                        cn.Close();

                    }

                    cn.Open();
                    cm = new SqlCommand("Select * from tblRecipt where cname = '" + cname.Text + "' order by vno ", cn);
                    SqlDataAdapter da1 = new SqlDataAdapter(cm);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    cn.Close();

                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        cn.Open();
                        cm = new SqlCommand("insert into tblLedger(Date,cname,vno,credit,balance,despr)values(@Date,@cname,@vno,@credit,@balance,@despr)", cn);
                        cm.Parameters.AddWithValue("@Date", dt1.Rows[i]["Date"].ToString());
                        cm.Parameters.AddWithValue("@cname", dt1.Rows[i]["cname"].ToString());
                        cm.Parameters.AddWithValue("@vno", dt1.Rows[i]["vno"].ToString() + "-" + dt1.Rows[i]["vtype"].ToString());
                        cm.Parameters.AddWithValue("@credit", dt1.Rows[i]["amount"].ToString());
                        cm.Parameters.AddWithValue("@balance", "-" + (dt1.Rows[i]["amount"].ToString()));
                        cm.Parameters.AddWithValue("@despr", dt1.Rows[i]["despr"].ToString());
                        cm.ExecuteNonQuery();
                        cn.Close();

                    }
                }

            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void cname_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayLedger();
            showledger();
        }

        public void showledger()
        {
            try
            {
                dataGridView1.Rows.Clear();
                drt.Text = "0";
                crt.Text = "0";
                opnbal.Text = "0";
                netbal.Text = "0";

                if (!string.IsNullOrEmpty(cname.Text))
                {
                    cn.Open();
                    cm = new SqlCommand("Select id,debit,credit,balance from tblLedger order by Date,id", cn);
                    SqlDataAdapter da2 = new SqlDataAdapter(cm);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    cn.Close();
                    for (int j = 1; j < dt2.Rows.Count; j++)
                    {
                        cn.Open();
                        Double t = 0;
                        if (dt2.Rows[j]["credit"].ToString() != "0")
                        {
                            Double c = Double.Parse(dt2.Rows[j - 1]["balance"].ToString());
                            Double d = Double.Parse(dt2.Rows[j]["credit"].ToString());
                            t = c - d;
                        }
                        else if (dt2.Rows[j]["credit"].ToString() == "0")
                        {
                            Double c = Double.Parse(dt2.Rows[j - 1]["balance"].ToString());
                            Double d = Double.Parse(dt2.Rows[j]["debit"].ToString());
                            t = c + d;
                        }
                        cm = new SqlCommand("Update tblLedger set balance = '" + t + "' where id = '" + dt2.Rows[j]["id"] + "' ", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        dt2.Rows.Clear();
                        da2.Fill(dt2);
                    }

                    int i = 0;
                    cn.Open();
                    cm = new SqlCommand("select Date,vno,despr,debit,credit,balance from tblLedger where cname = '" + cname.Text + "' and Date between '" + date1.Value.ToShortDateString() + "' and '" + date2.Value.ToShortDateString() + "'  ORDER BY Date,id", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        i++;
                        dataGridView1.Rows.Add(i, DateTime.Parse(dr[0].ToString()).ToString("dd/MM/yyyy"), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                    }
                    dr.Close();
                    cn.Close();

                    cn.Open();
                    if (dataGridView1.Rows.Count > 0)
                    {
                        cm = new SqlCommand("select sum(debit) as dr ,sum(credit) as cr from tblLedger where Date between '" + date1.Value.ToShortDateString() + "' and '" + date2.Value.ToShortDateString() + "' ", cn);
                        SqlDataAdapter da1 = new SqlDataAdapter(cm);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        drt.Text = dt1.Rows[0]["dr"].ToString();
                        crt.Text = dt1.Rows[0]["cr"].ToString();
                    }
                    cn.Close();

                    if (dataGridView1.Rows.Count > 0)
                    {
                        if (int.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString()) != 0)
                        {
                            Double ff = Double.Parse(dataGridView1.Rows[0].Cells[6].Value.ToString()) - Double.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString());
                            opnbal.Text = ff.ToString();
                        }
                        else
                        {
                            Double ff = Double.Parse(dataGridView1.Rows[0].Cells[6].Value.ToString()) + Double.Parse(dataGridView1.Rows[0].Cells[5].Value.ToString());
                            opnbal.Text = ff.ToString();
                        }
                    }
                    for (int ig = 0; ig < dataGridView1.RowCount; ig++)
                    {
                        netbal.Text = dataGridView1.Rows[ig].Cells[6].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
           

        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {
            displayLedger();
            showledger();
        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {
            displayLedger();
            showledger();
        }

        private void cname_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            LedgerReport bp = new LedgerReport(this);
            bp.loadReportLedger();
            bp.ShowDialog();
        }

        private void cashbook_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCashBook fcb = new frmCashBook(f1);
            fcb.Hide();
            fcb.TopLevel = false;
            f1.panel2.Controls.Add(fcb);
            fcb.BringToFront();
            fcb.Show();
        }

        private void billbook_Click(object sender, EventArgs e)
        {

            this.Close();
            frmBillBook fcb = new frmBillBook(f1);
            fcb.Hide();
            fcb.TopLevel = false;
            f1.panel2.Controls.Add(fcb);
            fcb.BringToFront();
            fcb.Show();
        }

        private void FullList_Click(object sender, EventArgs e)
        {
            loadreportallledger();
            LedgerReport bp = new LedgerReport(this);
            bp.loadReportLedgerall();
            bp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btndebit_Click(object sender, EventArgs e)
        {
            loadreportdebit();
            LedgerReport bp = new LedgerReport(this);
            bp.loadReportLedgerDEBIT();
            bp.ShowDialog();
        }

        private void btncredit_Click(object sender, EventArgs e)
        {
            loadreportcredit();
            LedgerReport bp = new LedgerReport(this);
            bp.loadReportLedgerCredit();
            bp.ShowDialog();
        }
    }
}
