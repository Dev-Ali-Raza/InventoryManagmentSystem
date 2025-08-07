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
    public partial class frmBillBook : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        Form1 f1;
        public frmBillBook(Form1 ff)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            f1 = ff;
        }

        private void frmBillBook_Load(object sender, EventArgs e)
        {
            getbillnosale();
            getcustomer();
            getproductname();

            date1.Focus();

        }

        /**     private void getproductname()
             {
                 cn.Open();
                 cm = new SqlCommand("SELECT pname from tblProduct", cn);
                 dr = cm.ExecuteReader();
                 AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                 while (dr.Read())
                 {
                     MyCollection.Add(dr.GetString(0));
                 }
                 productname.AutoCompleteCustomSource = MyCollection;
                 dr.Close();
                 cn.Close();
             }**/
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
        public void getbillnosale()
        {
            try
            {

                cn.Open();
                cm = new SqlCommand("Select top 1  Billno  from tblSale order by Billno desc  ", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                if (dt.Rows.Count < 1)
                {
                    Billno.Text = "1";
                   

                }
                else
                {

                    Billno.Text = (long.Parse(dt.Rows[0]["Billno"].ToString()) + 1).ToString();
                    

                }

                
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        public void getbillnopurchase()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("Select top 1  Billno  from tblPurchase order by Billno desc  ", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                if (dt.Rows.Count < 1)
                {
                    Billno.Text = "1";
                }
                else
                {
                    Billno.Text = (long.Parse(dt.Rows[0]["Billno"].ToString()) + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }

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
            if (e.KeyCode == Keys.Enter && cname.Text != string.Empty)
            {
                Billno.Focus();
            }
            
        }

        private void Billno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                despr.Focus();
            }
        }

        private void despr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pcode.Focus();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void productname_KeyDown(object sender, KeyEventArgs e)
        {
            /**
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("SELECT pcode,pname from tblProduct where pname like '" + productname.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {

                        frmprice fp = new frmprice();
                        fp.ShowDialog();
                        frmqty fq = new frmqty();
                        fq.ShowDialog();
                        string code = dr["pcode"].ToString();
                        string name = dr["pname"].ToString();
                        dr.Close();
                        cn.Close();
                        if (sale.Checked == true)
                        {
                            cn.Open();
                            cm = new SqlCommand("insert into tblSale(Date,Billno,cname,pcode,pname,price,qty,type,mode,despr)values(@Date,@Billno,@cname,@pcode,@pname,@price,@qty,@type,@mode,@despr)", cn);
                            cm.Parameters.AddWithValue("@Date", date1.Value.ToShortDateString());
                            cm.Parameters.AddWithValue("@Billno", Billno.Text);
                            cm.Parameters.AddWithValue("@cname", cname.Text);
                            cm.Parameters.AddWithValue("@pcode", code);
                            cm.Parameters.AddWithValue("@pname", name);
                            cm.Parameters.AddWithValue("@price", fp.price1.ToString(("#,#0.00")));
                            cm.Parameters.AddWithValue("@qty", fq.quantity);
                            cm.Parameters.AddWithValue("@type", "0");
                            cm.Parameters.AddWithValue("@mode", "Credit");
                            cm.Parameters.AddWithValue("@despr", despr.Text);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            cn.Open();
                            cm = new SqlCommand("Delete from tblPayment where vno = '"+Billno.Text+ "' and  vtype = '" + "SV" + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            LoadRecordsSale();
                            cn.Open();
                            cm = new SqlCommand("insert into tblPayment(Date,vno,cname,despr,amount,vtype) values (@Date,@vno,@cname,@despr,@amount,@vtype)", cn);
                            cm.Parameters.AddWithValue("@Date", date1.Value.ToShortDateString());
                            cm.Parameters.AddWithValue("@vno", Billno.Text);
                            cm.Parameters.AddWithValue("@cname", cname.Text);
                            cm.Parameters.AddWithValue("@despr", despr.Text);
                            cm.Parameters.AddWithValue("@amount", double.Parse(totalbalance.Text).ToString());
                            cm.Parameters.AddWithValue("@vtype", "SV");
                            cm.ExecuteNonQuery();
                            cn.Close();


                            int rownumber = dataGridView1.Rows.Count - 1;
                            cn.Open();
                            cm = new SqlCommand("Update tblProduct set qty=qty -" + long.Parse(dataGridView1.Rows[rownumber].Cells[5].Value.ToString()) + "   where pcode = '" + dataGridView1.Rows[rownumber].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            cn.Open();
                            cm = new SqlCommand("select sprice from tblProduct", cn);
                            dr = cm.ExecuteReader();
                            dr.Read();
                            if(dr["sprice"].ToString() == "0")
                            {
                                dr.Close();
                                cm = new SqlCommand("Update tblProduct set  sprice = sprice + '" + double.Parse(dataGridView1.Rows[rownumber].Cells[4].Value.ToString()) + "'   where pcode = '" + dataGridView1.Rows[rownumber].Cells[1].Value.ToString() + "'", cn);
                                cm.ExecuteNonQuery();

                            }
                            else
                            {
                                dr.Close();
                                cm = new SqlCommand("Update tblProduct set  sprice = (sprice + '" + double.Parse(dataGridView1.Rows[rownumber].Cells[4].Value.ToString()) + "')/2   where pcode = '" + dataGridView1.Rows[rownumber].Cells[1].Value.ToString() + "'", cn);
                                cm.ExecuteNonQuery();
                            }
                            
                            cn.Close();

                           


                        }
                        else if(purchase.Checked == true)
                        {
                            cn.Open();
                            cm = new SqlCommand("insert into tblPurchase(Date,Billno,cname,pcode,pname,price,qty,type,mode,despr)values(@Date,@Billno,@cname,@pcode,@pname,@price,@qty,@type,@mode,@despr)", cn);
                            cm.Parameters.AddWithValue("@Date", date1.Value.ToShortDateString());
                            cm.Parameters.AddWithValue("@Billno", Billno.Text);
                            cm.Parameters.AddWithValue("@cname", cname.Text);
                            cm.Parameters.AddWithValue("@pcode", code);
                            cm.Parameters.AddWithValue("@pname", name);
                            cm.Parameters.AddWithValue("@price", fp.price1.ToString(("#,#0.00")));
                            cm.Parameters.AddWithValue("@qty", fq.quantity);
                            cm.Parameters.AddWithValue("@type", "0");
                            cm.Parameters.AddWithValue("@mode", "Credit");
                            cm.Parameters.AddWithValue("@despr", despr.Text);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            cn.Open();
                            cm = new SqlCommand("Delete from tblRecipt where vno = '" + Billno.Text + "' and  vtype = '" + "PV" + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            LoadRecordsPurchase();
                            cn.Open();
                            cm = new SqlCommand("insert into tblRecipt(Date,vno,cname,despr,amount,vtype) values (@Date,@vno,@cname,@despr,@amount,@vtype)", cn);
                            cm.Parameters.AddWithValue("@Date", date1.Value.ToShortDateString());
                            cm.Parameters.AddWithValue("@vno", Billno.Text);
                            cm.Parameters.AddWithValue("@cname", cname.Text);
                            cm.Parameters.AddWithValue("@despr", despr.Text);
                            cm.Parameters.AddWithValue("@amount", double.Parse(totalbalance.Text).ToString());
                            cm.Parameters.AddWithValue("@vtype", "PV");
                            cm.ExecuteNonQuery();
                            cn.Close();



                            int rownumber = dataGridView1.Rows.Count - 1;
                            cn.Open();
                            cm = new SqlCommand("Update tblProduct set qty=qty +" + long.Parse(dataGridView1.Rows[rownumber].Cells[5].Value.ToString()) + "   where pcode = '" + dataGridView1.Rows[rownumber].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            cn.Open();
                            cm = new SqlCommand("select cprice from tblProduct", cn);
                            dr = cm.ExecuteReader();
                            dr.Read();
                            if (dr["cprice"].ToString() == "0")
                            {
                                dr.Close();
                                cm = new SqlCommand("Update tblProduct set  cprice = cprice + '" + double.Parse(dataGridView1.Rows[rownumber].Cells[4].Value.ToString()) + "'   where pcode = '" + dataGridView1.Rows[rownumber].Cells[1].Value.ToString() + "'", cn);
                                cm.ExecuteNonQuery();

                            }
                            else
                            {
                                dr.Close();
                                cm = new SqlCommand("Update tblProduct set  cprice = (cprice + '" + double.Parse(dataGridView1.Rows[rownumber].Cells[4].Value.ToString()) + "')/2   where pcode = '" + dataGridView1.Rows[rownumber].Cells[1].Value.ToString() + "'", cn);
                                cm.ExecuteNonQuery();
                            }

                            cn.Close();
                        }
                        productname.Clear();
                        productname.Focus();
                        

                    }
                    else
                    {
                        dr.Close();
                        cn.Close();
                    }
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }**/
        }
        public void LoadRecordsSale()
        {
            try
            {
                ledger.Rows.Clear();
                cname.Text = "";
                despr.Clear();
                cname.Enabled = true;
                int i = 0;
                double total = 0;
                int item = 0;
                cn.Open();
                cm = new SqlCommand("select c.Date,c.cname,c.despr,c.pdes,c.type,c.id,c.pcode,p.pname,c.price,c.qty,c.total from tblSale  as c inner join tblProduct as p on c.pcode = p.pcode where Billno like '" + Billno.Text + "'  order by id" , cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    
                    ledger.Rows.Add(dr["id"].ToString(), dr["pcode"].ToString(), dr["pname"].ToString(), dr["pdes"].ToString(), dr["price"].ToString(), dr["type"].ToString(), dr["qty"].ToString(), dr["total"].ToString());
                    total += double.Parse(dr["total"].ToString());
                    date1.Text = dr["Date"].ToString();
                    cname.Text = dr["cname"].ToString();
                    despr.Text = dr["despr"].ToString();
                    cname.Enabled = false;
                }
                totalbalance.Text = total.ToString("#,#0.00");
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

        public void LoadRecordsPurchase()
        {
            try
            {
                ledger.Rows.Clear();
                cname.Text = "";
                despr.Clear();
                cname.Enabled = true;
                int i = 0;
                double total = 0;
                int item = 0;
                cn.Open();
                cm = new SqlCommand("select c.Date,c.cname,c.despr,c.pdes,c.type,c.id,c.pcode,p.pname,c.price,c.qty,c.total from tblPurchase  as c inner join tblProduct as p on c.pcode = p.pcode where Billno like '" + Billno.Text + "' order by id", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    ledger.Rows.Add(dr["id"].ToString(), dr["pcode"].ToString(), dr["pname"].ToString(), dr["pdes"].ToString(), dr["price"].ToString(), dr["type"].ToString(), dr["qty"].ToString(), dr["total"].ToString());
                    total += double.Parse(dr["total"].ToString());
                    date1.Text = dr["Date"].ToString();
                    cname.Text = dr["cname"].ToString();
                    despr.Text = dr["despr"].ToString();
                    cname.Enabled = false;
                }
                totalbalance.Text = total.ToString("#,#0.00");
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
        public void clear()
        {
            cname.Enabled = true;
            cname.SelectedIndex = -1;
            despr.Clear();
            pcode.Clear();
            this.pname.SelectedIndex = -1;
            pdes.Clear();
            pprice.Clear();
            ptype.Text = "0";
            pqty.Clear();
            date1.Value = DateTime.Now;
            date1.Focus();
            
        }
        private void Billno_TextChanged(object sender, EventArgs e)
        {
            if (sale.Checked == true)
            {
                LoadRecordsSale();
               
            }
            else
            {
                LoadRecordsPurchase();
                
            }
        }

        private void cname_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void purchase_CheckedChanged(object sender, EventArgs e)
        {
            getbillnopurchase();
            clear();
            getcustomer();
            date1.Focus();
        }

        private void sale_CheckedChanged(object sender, EventArgs e)
        {
            getbillnosale();
            clear();
            getcustomer();
            date1.Focus();
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            cname.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.ledger.Rows.Clear();
            if (sale.Checked == true)
            {
                getbillnosale();

            }
            else
            {
                getbillnopurchase();

            }
            date1.Value = DateTime.Now;
            despr.Clear();
            getcustomer();
            date1.Focus();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to DELETE THIS INVOICE?", "DELETE BILL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (sale.Checked == true)
                {
                    cn.Open();
                    cm = new SqlCommand("Select pcode,qty from tblsale where Billno ='"+Billno.Text+"'",cn);
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    cn.Close();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cn.Open();
                        cm = new SqlCommand("Update tblProduct set qty=qty +" + Double.Parse(dt.Rows[i]["qty"].ToString()) + " where pcode = '" + dt.Rows[i]["pcode"].ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                    cn.Open();
                    cm = new SqlCommand("Delete from tblSale where Billno = '" + Billno.Text + "' ", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("Delete from tblPayment where vno = '" + Billno.Text + "' and vtype = '"+"SV"+"' ", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    this.ledger.Rows.Clear();
                    totalbalance.Clear();
                    clear();
                    getbillnosale();

                }
                else
                {
                    cn.Open();
                    cm = new SqlCommand("Select pcode,qty from tblPurchase where Billno ='" + Billno.Text + "'", cn);
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cn.Close();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cn.Open();
                        cm = new SqlCommand("Update tblProduct set qty=qty -" + Double.Parse(dt.Rows[i]["qty"].ToString()) + " where pcode = '" + dt.Rows[i]["pcode"].ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }

                    cn.Open();
                    cm = new SqlCommand("select pcode,qty,cname,pname,price from tblPurchase  where Billno ='" + Billno.Text + "'", cn);
                    SqlDataAdapter da1 = new SqlDataAdapter(cm);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    cn.Close();
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        cn.Open();
                        cm = new SqlCommand("select * from tblSoda  where pname = '" + dt1.Rows[i]["pname"].ToString() + "' and cname = '" + dt1.Rows[i]["cname"].ToString() + "' and price = '" + dt1.Rows[i]["price"].ToString() + "'", cn);
                        SqlDataAdapter da2 = new SqlDataAdapter(cm);
                        DataTable dt2 = new DataTable();
                        da2.Fill(dt2);
                        cn.Close();

                        if (dt2.Rows.Count > 0)
                        {
                            if (dt2.Rows[i]["qty"].ToString() == dt1.Rows[i]["qty"].ToString())
                            {

                            }
                            else
                            {
                                cn.Open();
                                cm = new SqlCommand("Update tblSodaReport set qty=qty +" + double.Parse(dt1.Rows[i]["qty"].ToString()) + " where pname = '" + dt1.Rows[i]["pname"].ToString() + "' and cname = '" + dt1.Rows[i]["cname"].ToString() + "' and price = '" + dt1.Rows[i]["price"].ToString() + "'", cn);
                                cm.ExecuteNonQuery();
                                cn.Close();
                            }
                        }
                    }
                    cn.Open();
                    cm = new SqlCommand("Delete from tblPurchase where Billno = '" + Billno.Text + "' ", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("Delete from tblRecipt where vno = '" + Billno.Text + "' and vtype = '" + "PV" + "' ", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    this.ledger.Rows.Clear();
                    totalbalance.Clear();
                    clear();
                    getbillnopurchase();
                }

                MessageBox.Show("INVOICE has been Successfully DELETED. ");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to UPDATE THIS INVOICE?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (sale.Checked == true)
                {
                    cn.Open();
                    cm = new SqlCommand("Update tblSale set Date=@Date,cname=@cname,despr=@despr where Billno = '" + Billno.Text + "'", cn);
                    cm.Parameters.AddWithValue("@Date", date1.Value.ToShortDateString());
                    cm.Parameters.AddWithValue("@cname", cname.Text);
                    cm.Parameters.AddWithValue("@despr", despr.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("Update tblPayment Set Date=@Date,cname=@cname,despr=@despr  where vno = '" + Billno.Text + "' and vtype = '" + "SV" + "' ", cn);
                    cm.Parameters.AddWithValue("@Date", date1.Value.ToShortDateString());
                    cm.Parameters.AddWithValue("@cname", cname.Text);
                    cm.Parameters.AddWithValue("@despr", despr.Text);   
                    cm.ExecuteNonQuery();
                    cn.Close();

                    clear();
                    getbillnosale();
                    
                }
                else
                {
                    cn.Open();
                    cm = new SqlCommand("Update tblPurchase set Date=@Date,cname=@cname,despr=@despr where Billno = '" + Billno.Text + "'", cn);
                    cm.Parameters.AddWithValue("@Date", date1.Value.ToShortDateString());
                    cm.Parameters.AddWithValue("@cname", cname.Text);
                    cm.Parameters.AddWithValue("@despr", despr.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("Update tblRecipt Set Date=@Date,cname=@cname,despr=@despr  where vno = '" + Billno.Text + "'and vtype = '" + "PV" + "' ", cn);
                    cm.Parameters.AddWithValue("@Date", date1.Value.ToShortDateString());
                    cm.Parameters.AddWithValue("@cname", cname.Text);
                    cm.Parameters.AddWithValue("@despr", despr.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    clear();
                    getbillnopurchase();

                }


                MessageBox.Show("INVOICE has been Successfully Update. ");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (sale.Checked == true)
                {
                    string colName = this.ledger.Columns[e.ColumnIndex].Name;
                    if (colName == "DELETE")
                    {
                        if (MessageBox.Show("Remove this Row?", "Remove?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {


                            cn.Open();
                            if (this.ledger.RowCount == 1)
                            {
                                cm = new SqlCommand("delete from tblPayment where vno = '" + Billno.Text + "' and vtype = 'SV' ", cn);
                                cm.ExecuteNonQuery();
                            }
                            else
                            {
                                cm = new SqlCommand("Update tblPayment set amount = amount - '" + double.Parse(this.ledger.Rows[e.RowIndex].Cells[7].Value.ToString()) + "' where vno = '" + Billno.Text + "' and vtype = 'SV' ", cn);
                                cm.ExecuteNonQuery();
                            }
                            cn.Close();

                            cn.Open();
                            cm = new SqlCommand("delete from tblSale where id = '" + this.ledger.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            LoadRecordsSale();
                            MessageBox.Show("ROW has been Successfully DELETED. ");
                        }
                    }
                }
                else
                {
                    string colName = this.ledger.Columns[e.ColumnIndex].Name;
                    if (colName == "DELETE")
                    {
                        if (MessageBox.Show("Remove this Row?", "Remove?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cn.Open();
                            cm = new SqlCommand("select pcode,qty,cname,pname,price from tblPurchase where id = '" + this.ledger.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                            SqlDataAdapter da = new SqlDataAdapter(cm);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            cn.Close();
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                cn.Open();
                                cm = new SqlCommand("select * from tblSoda  where pname = '" + dt.Rows[i]["pname"].ToString() + "' and cname = '" + dt.Rows[i]["cname"].ToString() + "' and price = '" + dt.Rows[i]["price"].ToString() + "'", cn);
                                SqlDataAdapter da2 = new SqlDataAdapter(cm);
                                DataTable dt2 = new DataTable();
                                da2.Fill(dt2);
                                cn.Close();

                                if (dt2.Rows.Count > 0)
                                {
                                    if (dt2.Rows[i]["qty"].ToString() == dt.Rows[i]["qty"].ToString())
                                    {

                                    }
                                    else
                                    {
                                        cn.Open();
                                        cm = new SqlCommand("Update tblSodaReport set qty=qty +" + double.Parse(dt.Rows[i]["qty"].ToString()) + " where pname = '" + dt.Rows[i]["pname"].ToString() + "' and cname = '" + dt.Rows[i]["cname"].ToString() + "' and price = '" + dt.Rows[i]["price"].ToString() + "'", cn);
                                        cm.ExecuteNonQuery();
                                        cn.Close();
                                    }
                                }
                            }

                            cn.Open();
                            cm = new SqlCommand("select cprice from tblProduct  where pcode = '" + this.ledger.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                            dr = cm.ExecuteReader();
                            dr.Read();
                            double f = double.Parse(this.ledger.Rows[e.RowIndex].Cells[4].Value.ToString()) - double.Parse(dr["cprice"].ToString());
                            if (dr.HasRows)
                            {
                                dr.Close();
                                cm = new SqlCommand("Update tblProduct set  cprice = cprice - '" + f + "'   where pcode = '" + this.ledger.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                                cm.ExecuteNonQuery();
                                
                            }
                            cn.Close();

                            cn.Open();
                            if (this.ledger.RowCount == 1)
                            {
                                cm = new SqlCommand("delete from tblRecipt where vno = '" + Billno.Text + "' and vtype = 'PV' ", cn);
                                cm.ExecuteNonQuery();
                            }
                            else
                            {
                                cm = new SqlCommand("Update tblRecipt set amount = amount - '"+ double.Parse(this.ledger.Rows[e.RowIndex].Cells[7].Value.ToString()) + "' where vno = '" + Billno.Text + "'and vtype = 'PV' ", cn);
                                cm.ExecuteNonQuery();
                            }
                            cn.Close();

                            cn.Open();
                            cm = new SqlCommand("delete from tblPurchase where id = '" + this.ledger.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            LoadRecordsPurchase();
                            MessageBox.Show("ROW has been Successfully DELETED. ");
                        }
                    }
                }


            }
            catch(Exception exx)
            {
                cn.Close();
                MessageBox.Show(exx.Message);
            }
            }

        private void cname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("SELECT pname from tblProduct where pcode = '" + pcode.Text + "'", cn);
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    cn.Close();
                    if (ds.Rows.Count > 0)
                    {
                        pname.Text = ds.Rows[0][0].ToString();
                    }
                    else
                    {
                        pname.Text = "";
                    }
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    pname.Focus();
                }
                catch(Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("SELECT pcode from tblProduct where pname = '" + pname.Text + "'", cn);
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    cn.Close();
                    if (ds.Rows.Count > 0)
                    {
                        pcode.Text = ds.Rows[0][0].ToString();
                    }
                    else
                    {
                        pcode.Text = "";
                    }
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    pdes.Focus();
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                pcode.Focus();
            }
        }
        
        private void pdes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pprice.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                pname.Focus();
            }

        }

        private void pprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pqty.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                pdes.Focus();
            }
        }

        private void pprice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ptype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //pqty.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                //pprice.Focus();
            }
        }

        private void pqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string price = "0";
                if (pprice.Text != string.Empty)
                {
                    if (long.Parse(ptype.Text) == 0)
                    {
                        price = double.Parse(pprice.Text).ToString();
                    }
                    else if (long.Parse(ptype.Text) == 3)
                    {
                        price = (double.Parse(pprice.Text) / 37.324).ToString();

                    }
                    else if (long.Parse(ptype.Text) == 4)
                    {

                        price = (double.Parse(pprice.Text) / 40).ToString();
                    }
                    else if(ptype.Text == string.Empty)
                    {
                        price = double.Parse(pprice.Text).ToString();
                    }
                    else
                    {
                        price = double.Parse(pprice.Text).ToString();
                    }
                }
                if (pqty.Text != string.Empty)
                {
                    ptotal.Text = (Double.Parse(price) * Double.Parse(pqty.Text)).ToString();
                }
                ptotal.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                pprice.Focus();
            }
        }

        private void pqty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void psave_Click(object sender, EventArgs e)
        {
            if (cname.Text != string.Empty && pcode.Text != string.Empty && pname.Text != string.Empty && ptotal.Text != string.Empty)
            {
                try
                {

                    if (sale.Checked == true)
                    {
                        string price = "0";

                        if (long.Parse(ptype.Text) == 0 && pprice.Text != string.Empty)
                        {
                            price = double.Parse(pprice.Text).ToString();
                        }
                        else if (long.Parse(ptype.Text) == 3 && pprice.Text != string.Empty)
                        {
                            price = (double.Parse(pprice.Text) / 37.324).ToString();

                        }
                        else if (long.Parse(ptype.Text) == 4 && pprice.Text != string.Empty)
                        {

                            price = (double.Parse(pprice.Text) / 40).ToString();
                        }
                        else if(pprice.Text != string.Empty)
                        {
                            price = double.Parse(pprice.Text).ToString();
                        }

                        if (pprice.Text != string.Empty && pqty.Text != string.Empty)
                            price = (Double.Parse(price) * Double.Parse(pqty.Text)).ToString();
                        else
                            price = Double.Parse(ptotal.Text).ToString();


                        cn.Open();
                        cm = new SqlCommand("insert into tblSale(Date,Billno,cname,pcode,pname,price,qty,type,mode,despr,pdes,Total)values(@Date,@Billno,@cname,@pcode,@pname,@price,@qty,@type,@mode,@despr,@pdes,@Total)", cn);
                        cm.Parameters.AddWithValue("@Date", date1.Value);
                        cm.Parameters.AddWithValue("@Billno", Billno.Text);
                        cm.Parameters.AddWithValue("@cname", cname.Text);
                        cm.Parameters.AddWithValue("@pcode", pcode.Text);
                        cm.Parameters.AddWithValue("@pname", pname.Text);
                        if (pprice.Text != string.Empty)
                        {
                            cm.Parameters.AddWithValue("@price", double.Parse(pprice.Text));
                        }
                        else
                        {
                            cm.Parameters.AddWithValue("@price", "0");
                        }
                        if (pqty.Text != string.Empty)
                        {
                            cm.Parameters.AddWithValue("@qty", double.Parse(pqty.Text));
                        }
                        else
                        {
                            cm.Parameters.AddWithValue("@qty", "0");
                        }
                        if (ptype.Text != string.Empty)
                        {

                            cm.Parameters.AddWithValue("@type", double.Parse(ptype.Text));
                        }
                        else
                        {
                            cm.Parameters.AddWithValue("@type", "0");
                        }
                      
                        cm.Parameters.AddWithValue("@Total", double.Parse(ptotal.Text));  
                        cm.Parameters.AddWithValue("@mode", "Credit");
                        cm.Parameters.AddWithValue("@despr", despr.Text);
                        cm.Parameters.AddWithValue("@pdes", pdes.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("Delete from tblPayment where vno = '" + Billno.Text + "' and  vtype = '" + "SV" + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        LoadRecordsSale();
                        cn.Open();
                        cm = new SqlCommand("insert into tblPayment(Date,vno,cname,despr,amount,vtype) values (@Date,@vno,@cname,@despr,@amount,@vtype)", cn);
                        cm.Parameters.AddWithValue("@Date", date1.Value);
                        cm.Parameters.AddWithValue("@vno", Billno.Text);
                        cm.Parameters.AddWithValue("@cname", cname.Text);
                        cm.Parameters.AddWithValue("@despr", despr.Text);
                        cm.Parameters.AddWithValue("@amount", double.Parse(totalbalance.Text).ToString());
                        cm.Parameters.AddWithValue("@vtype", "SV");
                        cm.ExecuteNonQuery();
                        cn.Close();


                        int rownumber = this.ledger.Rows.Count - 1;
                        
                        if (pqty.Text != string.Empty)
                        {
                            cn.Open();
                            cm = new SqlCommand("Update tblProduct set qty=qty -" + Double.Parse(pqty.Text) + "   where pcode = '" + pcode.Text + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }

                        if (pprice.Text != string.Empty)
                        {
                            cn.Open();
                            cm = new SqlCommand("select sprice from tblProduct", cn);
                            dr = cm.ExecuteReader();
                            dr.Read();
                            if (dr["sprice"].ToString() == "0")
                            {
                                dr.Close();
                                cm = new SqlCommand("Update tblProduct set  sprice = sprice + '" + double.Parse(pprice.Text) + "'   where pcode = '" + pcode.Text + "'", cn);
                                cm.ExecuteNonQuery();

                            }
                            else
                            {
                                dr.Close();
                                cm = new SqlCommand("Update tblProduct set  sprice = (sprice + '" + double.Parse(pprice.Text) + "')/2   where pcode = '" + pcode.Text + "'", cn);
                                cm.ExecuteNonQuery();
                            }

                            cn.Close();
                        }
                        clear1();


                    }
                    else if (purchase.Checked == true)
                    {
                        string price = "0";


                        if (long.Parse(ptype.Text) == 0 && pprice.Text != string.Empty)
                        {
                            price = double.Parse(pprice.Text).ToString();
                        }
                        else if (long.Parse(ptype.Text) == 3 && pprice.Text != string.Empty)
                        {
                            price = (double.Parse(pprice.Text) / 37.324).ToString();

                        }
                        else if (long.Parse(ptype.Text) == 4 && pprice.Text != string.Empty)
                        {

                            price = (double.Parse(pprice.Text) / 40).ToString();
                        }
                        else if (pprice.Text != string.Empty)
                        {
                            price = double.Parse(pprice.Text).ToString();
                        }

                        if (pprice.Text != string.Empty && pqty.Text != string.Empty)
                            price = (Double.Parse(price) * Double.Parse(pqty.Text)).ToString();
                        else
                            price = Double.Parse(ptotal.Text).ToString();

                        cn.Open();
                        cm = new SqlCommand("insert into tblPurchase(Date,Billno,cname,pcode,pname,price,qty,type,mode,despr,pdes,Total)values(@Date,@Billno,@cname,@pcode,@pname,@price,@qty,@type,@mode,@despr,@pdes,@Total)", cn);
                        cm.Parameters.AddWithValue("@Date", date1.Value);
                        cm.Parameters.AddWithValue("@Billno", Billno.Text);
                        cm.Parameters.AddWithValue("@cname", cname.Text);
                        cm.Parameters.AddWithValue("@pcode", pcode.Text);
                        cm.Parameters.AddWithValue("@pname", pname.Text);
                        if (pprice.Text != string.Empty)
                        {
                            cm.Parameters.AddWithValue("@price", double.Parse(pprice.Text));
                        }
                        else
                        {
                            cm.Parameters.AddWithValue("@price", "0");
                        }
                        if (pqty.Text != string.Empty)
                        {
                            cm.Parameters.AddWithValue("@qty", double.Parse(pqty.Text));
                        }
                        else
                        {
                            cm.Parameters.AddWithValue("@qty", "0");
                        }
                        if (ptype.Text != string.Empty)
                        {

                            cm.Parameters.AddWithValue("@type", double.Parse(ptype.Text));
                        }
                        else
                        {
                            cm.Parameters.AddWithValue("@type", "0");
                        }

                        cm.Parameters.AddWithValue("@Total", double.Parse(ptotal.Text));
                        cm.Parameters.AddWithValue("@mode", "Credit");
                        cm.Parameters.AddWithValue("@despr", despr.Text);
                        cm.Parameters.AddWithValue("@pdes", pdes.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();



                        cn.Open();
                        cm = new SqlCommand("Delete from tblRecipt where vno = '" + Billno.Text + "' and  vtype = '" + "PV" + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        LoadRecordsPurchase();
                        cn.Open();
                        cm = new SqlCommand("insert into tblRecipt(Date,vno,cname,despr,amount,vtype) values (@Date,@vno,@cname,@despr,@amount,@vtype)", cn);
                        cm.Parameters.AddWithValue("@Date", date1.Value);
                        cm.Parameters.AddWithValue("@vno", Billno.Text);
                        cm.Parameters.AddWithValue("@cname", cname.Text);
                        cm.Parameters.AddWithValue("@despr", despr.Text);
                        cm.Parameters.AddWithValue("@amount", double.Parse(totalbalance.Text).ToString());
                        cm.Parameters.AddWithValue("@vtype", "PV");
                        cm.ExecuteNonQuery();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("insert into tblSoda(Date,vno,cname,detail,pname,price,qty)values(@Date,@vno,@cname,@detail,@pname,@price,@qty)", cn);
                        cm.Parameters.AddWithValue("@Date", date1.Value);
                        cm.Parameters.AddWithValue("@vno", "P");
                        cm.Parameters.AddWithValue("@cname", cname.Text);
                        cm.Parameters.AddWithValue("@detail", despr.Text);
                        cm.Parameters.AddWithValue("@pname", pname.Text);
                        cm.Parameters.AddWithValue("@price", pprice.Text);
                        cm.Parameters.AddWithValue("@qty", pqty.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        if (pqty.Text != string.Empty)
                        {
                            cn.Open();
                            cm = new SqlCommand("Update tblSodaReport set qty=qty -" + Double.Parse(pqty.Text) + " , completedate = '"+date1.Value+"'   where pname = '" + pname.Text + "' and cname = '" + cname.Text + "' and price = '" + pprice.Text + "' and status = 'REMAINING' ", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }


                        int rownumber = this.ledger.Rows.Count - 1;
                        if (pqty.Text != string.Empty)
                        {
                            cn.Open();
                            cm = new SqlCommand("Update tblProduct set qty=qty +" + Double.Parse(pqty.Text) + "   where pcode = '" + pcode.Text + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }

                        if (pprice.Text != string.Empty)
                        {
                            cn.Open();
                            cm = new SqlCommand("select sprice from tblProduct", cn);
                            dr = cm.ExecuteReader();
                            dr.Read();
                            if (dr["sprice"].ToString() == "0")
                            {
                                dr.Close();
                                cm = new SqlCommand("Update tblProduct set  cprice = cprice + '" + double.Parse(pprice.Text) + "'   where pcode = '" + pcode.Text + "'", cn);
                                cm.ExecuteNonQuery();

                            }
                            else
                            {
                                dr.Close();
                                cm = new SqlCommand("Update tblProduct set  cprice = (cprice + '" + double.Parse(pprice.Text) + "')/2   where pcode = '" + pcode.Text + "'", cn);
                                cm.ExecuteNonQuery();
                            }

                            cn.Close();
                        }
                        clear1();
                    }



                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("PLEASE FILL ALL THE EMPTY BLANKS");
            }

         
        
    }

        public void clear1()
        {
            pcode.Clear();
            this.pname.SelectedIndex = -1;
            pdes.Clear();
            pprice.Clear();
            ptype.Text = "0";
            pqty.Clear();
            ptotal.Clear();
            pcode.Focus();
        }

        private void pname_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void pname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT pcode from tblProduct where pname = '" + pname.Text + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable ds = new DataTable();
                da.Fill(ds);
                cn.Close();
                if (ds.Rows.Count > 0)
                {
                    pcode.Text = ds.Rows[0][0].ToString();
                }
                else
                {
                    pcode.Text = "";
                }
                cn.Open();
                cm.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (sale.Checked == true)
                {
                    if (this.ledger.RowCount > 0)
                    {
                        cn.Open();
                        cm = new SqlCommand("select pcode,qty from tblSale  where id = '" + this.ledger.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                        SqlDataAdapter da1 = new SqlDataAdapter(cm);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        cn.Close();
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {
                            
                            cn.Open();
                            cm = new SqlCommand("Update tblProduct set qty=qty +" + double.Parse(dt1.Rows[i]["qty"].ToString()) + " where pcode = '" + dt1.Rows[i]["pcode"].ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }

                        string price = "0";
                        string pprice = double.Parse(this.ledger.Rows[e.RowIndex].Cells["price"].Value.ToString()).ToString();
                        string qty = this.ledger.Rows[e.RowIndex].Cells["qty"].Value.ToString().ToString();

                        if (long.Parse(this.ledger.Rows[e.RowIndex].Cells["type"].Value.ToString()) == 0)
                        {
                            price = double.Parse(this.ledger.Rows[e.RowIndex].Cells["price"].Value.ToString()).ToString();
                        }
                        else if (long.Parse(this.ledger.Rows[e.RowIndex].Cells["type"].Value.ToString()) == 3)
                        {
                            price = (double.Parse(this.ledger.Rows[e.RowIndex].Cells["price"].Value.ToString()) / 37.324).ToString();

                        }
                        else if (long.Parse(this.ledger.Rows[e.RowIndex].Cells["type"].Value.ToString()) == 4)
                        {

                            price = (double.Parse(this.ledger.Rows[e.RowIndex].Cells["price"].Value.ToString()) / 40).ToString();
                        }
                        else
                        {
                            price = double.Parse(this.ledger.Rows[e.RowIndex].Cells["price"].Value.ToString()).ToString();
                        }
                        if (pprice != "0" && qty != "0")
                        {
                            price = (double.Parse(price) * double.Parse(qty)).ToString();
                        }
                        else
                        {
                            price = double.Parse(this.ledger.Rows[e.RowIndex].Cells["TOTAL"].Value.ToString()).ToString();
                        }
                        cn.Open();
                        cm = new SqlCommand("Update tblSale set price=@price,type=@type,qty=@qty,pdes=@pdes,Total=@Total where id = '" + this.ledger.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                        cm.Parameters.AddWithValue("@price", pprice);
                        cm.Parameters.AddWithValue("@qty", double.Parse(this.ledger.Rows[e.RowIndex].Cells["qty"].Value.ToString()));
                        cm.Parameters.AddWithValue("@type", this.ledger.Rows[e.RowIndex].Cells["type"].Value);
                        cm.Parameters.AddWithValue("@pdes", this.ledger.Rows[e.RowIndex].Cells["des"].Value);
                        cm.Parameters.AddWithValue("@Total", price);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("select pcode,qty from tblSale  where id = '" + this.ledger.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                        SqlDataAdapter da = new SqlDataAdapter(cm);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cn.Close();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            cn.Open();
                            cm = new SqlCommand("Update tblProduct set qty=qty -" + double.Parse(dt.Rows[i]["qty"].ToString()) + " where pcode = '" + dt.Rows[i]["pcode"].ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }


                        LoadRecordsSale();

                        cn.Open();
                        cm = new SqlCommand("Update tblPayment set amount=@amount where vno = '" + Billno.Text+ "' and vtype = '" + "SV" + "' ", cn);
                        cm.Parameters.AddWithValue("@amount", double.Parse(totalbalance.Text).ToString());
                        cm.ExecuteNonQuery();
                        cn.Close();

                        /**
                        cn.Open();
                        cm = new SqlCommand("Delete from tblPayment where vno = '" + Billno.Text + "' and  vtype = '" + "SV" + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        LoadRecordsSale();
                        cn.Open();
                        cm = new SqlCommand("insert into tblPayment(Date,vno,cname,despr,amount,vtype) values (@Date,@vno,@cname,@despr,@amount,@vtype)", cn);
                        cm.Parameters.AddWithValue("@Date", date1.Value.ToString("dd/MM/yyyy"));
                        cm.Parameters.AddWithValue("@vno", Billno.Text);
                        cm.Parameters.AddWithValue("@cname", cname.Text);
                        cm.Parameters.AddWithValue("@despr", despr.Text);
                        cm.Parameters.AddWithValue("@amount", double.Parse(totalbalance.Text).ToString());
                        cm.Parameters.AddWithValue("@vtype", "SV");
                        cm.ExecuteNonQuery();
                        cn.Close();
                    **/
                    }
                }
                else
                {
                    if (this.ledger.RowCount > 0)
                    {
                        cn.Open();
                        cm = new SqlCommand("select pcode,qty,pname,cname,price from tblPurchase  where id = '" + this.ledger.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                        SqlDataAdapter da = new SqlDataAdapter(cm);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cn.Close();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            cn.Open();
                            cm = new SqlCommand("select * from tblSoda  where pname = '" + dt.Rows[i]["pname"].ToString() + "' and cname = '" + dt.Rows[i]["cname"].ToString() + "' and price = '" + dt.Rows[i]["price"].ToString() + "'", cn);
                            SqlDataAdapter da2 = new SqlDataAdapter(cm);
                            DataTable dt2 = new DataTable();
                            da2.Fill(dt2);
                            cn.Close();

                           if (dt2.Rows.Count > 0)
                        {
                            if (dt2.Rows[i]["qty"].ToString() == dt.Rows[i]["qty"].ToString())
                            {

                            }
                            else
                            {
                                cn.Open();
                                cm = new SqlCommand("Update tblSodaReport set qty=qty +" + double.Parse(dt.Rows[i]["qty"].ToString()) + " where pname = '" + dt.Rows[i]["pname"].ToString() + "' and cname = '" + dt.Rows[i]["cname"].ToString() + "' and price = '" + dt.Rows[i]["price"].ToString() + "'", cn);
                                cm.ExecuteNonQuery();
                                cn.Close();
                            }
                        }
                        }

                        string price = "0";
                        string pprice = double.Parse(this.ledger.Rows[e.RowIndex].Cells["price"].Value.ToString()).ToString();
                        string qty = this.ledger.Rows[e.RowIndex].Cells["qty"].Value.ToString().ToString();

                        if (long.Parse(this.ledger.Rows[e.RowIndex].Cells["type"].Value.ToString()) == 0)
                        {
                            price = double.Parse(this.ledger.Rows[e.RowIndex].Cells["price"].Value.ToString()).ToString();
                        }
                        else if (long.Parse(this.ledger.Rows[e.RowIndex].Cells["type"].Value.ToString()) == 3)
                        {
                            price = (double.Parse(this.ledger.Rows[e.RowIndex].Cells["price"].Value.ToString()) / 37.324).ToString();

                        }
                        else if (long.Parse(this.ledger.Rows[e.RowIndex].Cells["type"].Value.ToString()) == 4)
                        {

                            price = (double.Parse(this.ledger.Rows[e.RowIndex].Cells["price"].Value.ToString()) / 40).ToString();
                        }
                        else
                        {
                            price = double.Parse(this.ledger.Rows[e.RowIndex].Cells["price"].Value.ToString()).ToString();
                        }

                        if (pprice != "0" && qty != "0")
                        {
                            price = (double.Parse(price) * double.Parse(qty)).ToString();
                        }
                        else
                        {
                            price = double.Parse(this.ledger.Rows[e.RowIndex].Cells["TOTAL"].Value.ToString()).ToString();
                        }

                        cn.Open();
                        cm = new SqlCommand("Update tblPurchase set price=@price,type=@type,qty=@qty,pdes=@pdes,Total=@Total where id = '" + this.ledger.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                        cm.Parameters.AddWithValue("@price", pprice);
                        cm.Parameters.AddWithValue("@qty", double.Parse(this.ledger.Rows[e.RowIndex].Cells["qty"].Value.ToString()));
                        cm.Parameters.AddWithValue("@type", this.ledger.Rows[e.RowIndex].Cells["type"].Value);
                        cm.Parameters.AddWithValue("@pdes", this.ledger.Rows[e.RowIndex].Cells["des"].Value);
                        cm.Parameters.AddWithValue("@Total", price);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        
                        
                        cn.Open();
                        cm = new SqlCommand("select pcode,qty,pname,cname,price from tblPurchase  where id = '" + this.ledger.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                        SqlDataAdapter da1 = new SqlDataAdapter(cm);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        cn.Close();
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {
                            cn.Open();
                            cm = new SqlCommand("Update tblSodaReport set qty=qty -" + double.Parse(dt1.Rows[i]["qty"].ToString()) + " where pname = '" + dt1.Rows[i]["pname"].ToString() + "' and cname = '" + dt1.Rows[i]["cname"].ToString() + "' and price = '" + dt1.Rows[i]["price"].ToString() + "' and status = 'REMAINING'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }


                        LoadRecordsPurchase();

                        cn.Open();
                        cm = new SqlCommand("Update tblRecipt set amount=@amount where vno = '" + Billno.Text + "' and vtype = '" + "PV" + "' ", cn);
                        cm.Parameters.AddWithValue("@amount", double.Parse(totalbalance.Text).ToString());
                        cm.ExecuteNonQuery();
                        cn.Close();

                        /** cn.Open();
                         cm = new SqlCommand("Delete from tblRecipt where vno = '" + Billno.Text + "' and  vtype = '" + "PV" + "'", cn);
                         cm.ExecuteNonQuery();
                         cn.Close();

                         LoadRecordsPurchase();
                         cn.Open();
                         cm = new SqlCommand("insert into tblRecipt(Date,vno,cname,despr,amount,vtype) values (@Date,@vno,@cname,@despr,@amount,@vtype)", cn);
                         cm.Parameters.AddWithValue("@Date", date1.Value.ToString("dd/MM/yyyy"));
                         cm.Parameters.AddWithValue("@vno", Billno.Text);
                         cm.Parameters.AddWithValue("@cname", cname.Text);
                         cm.Parameters.AddWithValue("@despr", despr.Text);
                         cm.Parameters.AddWithValue("@amount", double.Parse(totalbalance.Text).ToString());
                         cm.Parameters.AddWithValue("@vtype", "PV");
                         cm.ExecuteNonQuery();
                         cn.Close();**/
                    }
                }

                }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            BillPrintInvoice bp = new BillPrintInvoice(this);
            if (sale.Checked == true)
            {
                bp.loadReportSale();
                bp.ShowDialog();

            }
            else
            {
                bp.loadReportPurchase();
                bp.ShowDialog();
            }
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

        private void le_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLedger fcb = new frmLedger(f1);
            fcb.Hide();
            fcb.TopLevel = false;
            f1.panel2.Controls.Add(fcb);
            fcb.BringToFront();
            fcb.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ptotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                psave.Focus();
            }
            else if(e.KeyCode == Keys.Left)
            {
                pqty.Focus();
            }

        }

        private void printinvoice_Click(object sender, EventArgs e)
        {
            BillPrintInvoice bp = new BillPrintInvoice(this);
            if (sale.Checked == true)
            {
                bp.loadReportSaleDirectO();

                //bp.loadReportSaleDirectD();

            }
            else
            {
                bp.loadReportPurchaseDirectO();

                //bp.loadReportPurchaseDirectD();
            }
        }

        private void ptotal_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (sale.Checked == true)
            {
                LoadRecordsSaleforsearch();
            }
            else
            {
                LoadRecordsPurchaseforsearch();
            }
        }

        public void LoadRecordsSaleforsearch()
        {
            try
            {
                ledger.Rows.Clear();
                cname.Text = "";
                despr.Clear();
                cname.Enabled = true;
                int i = 0;
                double total = 0;
                int item = 0;
                cn.Open();
                cm = new SqlCommand("select c.Date,c.cname,c.despr,c.pdes,c.type,c.id,c.pcode,p.pname,c.price,c.qty,c.total from tblSale  as c inner join tblProduct as p on c.pcode = p.pcode where Billno like '" + Billno.Text + "' and p.pname like '%" + txtSearch.Text + "%' order by id", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    ledger.Rows.Add(dr["id"].ToString(), dr["pcode"].ToString(), dr["pname"].ToString(), dr["pdes"].ToString(), dr["price"].ToString(), dr["type"].ToString(), dr["qty"].ToString(), dr["total"].ToString());
                    total += double.Parse(dr["total"].ToString());
                    date1.Text = dr["Date"].ToString();
                    cname.Text = dr["cname"].ToString();
                    despr.Text = dr["despr"].ToString();
                    cname.Enabled = false;
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }

        public void LoadRecordsPurchaseforsearch()
        {
            try
            {
                ledger.Rows.Clear();
                cname.Text = "";
                despr.Clear();
                cname.Enabled = true;
                int i = 0;
                double total = 0;
                int item = 0;
                cn.Open();
                cm = new SqlCommand("select c.Date,c.cname,c.despr,c.pdes,c.type,c.id,c.pcode,p.pname,c.price,c.qty,c.total from tblPurchase  as c inner join tblProduct as p on c.pcode = p.pcode where Billno like '" + Billno.Text + "' and p.pname like '%" + txtSearch.Text + "%' order by id", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    ledger.Rows.Add(dr["id"].ToString(), dr["pcode"].ToString(), dr["pname"].ToString(), dr["pdes"].ToString(), dr["price"].ToString(), dr["type"].ToString(), dr["qty"].ToString(), dr["total"].ToString());
                    total += double.Parse(dr["total"].ToString());
                    date1.Text = dr["Date"].ToString();
                    cname.Text = dr["cname"].ToString();
                    despr.Text = dr["despr"].ToString();
                    cname.Enabled = false;
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }
    }
}
