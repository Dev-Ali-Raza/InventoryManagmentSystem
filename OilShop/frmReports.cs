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
    public partial class frmReports : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        public frmReports()
        {
            InitializeComponent();

            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            getcustomer();
            getproductname();
            gettypedata();
        }

        public void gettypedata()
        {
            cn.Open();
            cm = new SqlCommand("select * from tblProductType", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            producttype.ValueMember = "ptype";
            producttype.DisplayMember = "ptype";
            producttype.DataSource = ds.Tables[0];
            producttype.Enabled = true;
            this.producttype.SelectedIndex = -1;
            cm.ExecuteNonQuery();
            cn.Close();

        }

        public void getcustomer()
        {
            cn.Open();
            cm = new SqlCommand("select cname from tblCustomer where cname like '%" + txtCustomer.Text + "%'  order by cname", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            customerbox.ValueMember = "cname";
            customerbox.DisplayMember = "cname";
            customerbox.DataSource = ds.Tables[0];
            customerbox.Enabled = true;
            this.customerbox.SelectedIndex = -1;
            cm.ExecuteNonQuery();
            cn.Close();
        }
        private void getproductname()
        {
            cn.Open();
            cm = new SqlCommand("SELECT pname from tblProduct where pname like '%"+txtProduct.Text+"%' order by pname asc ", cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            productbox.ValueMember = "pname";
            productbox.DisplayMember = "pname";
            cn.Close();
            productbox.DataSource = ds.Tables[0];

            productbox.Enabled = true;
            this.productbox.SelectedIndex = -1;
            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            frmReportViewer bp = new frmReportViewer(this);
            bp.loadDailySale();
            bp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (productbox.SelectedValue != null)
            {
                frmReportViewer bp = new frmReportViewer(this);
                bp.loadSaleProductWise();
                bp.ShowDialog();
            }
            else
            {
                MessageBox.Show("PLEASE SELECT ANY PRODUCT");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (customerbox.SelectedItem != null)
            { 

                frmReportViewer bp = new frmReportViewer(this);
                bp.loadSaleCustomerWise();
                bp.ShowDialog();
            }
            else
            {
                MessageBox.Show("PLEASE SELECT ANY CUSTOMER");
            }
}

        private void dailypurchase_Click(object sender, EventArgs e)
        {
            
                frmReportViewer bp = new frmReportViewer(this);
                bp.loadDailyPurchase();
                bp.ShowDialog();
           
        }

        private void purchaseproduct_Click(object sender, EventArgs e)
        {
            if (productbox.SelectedValue != null)
            {
                frmReportViewer bp = new frmReportViewer(this);
                bp.loadPurchaseProductWise();
                bp.ShowDialog();
            }
            else
            {
                MessageBox.Show("PLEASE SELECT ANY PRODUCT");
            }
        }

        private void purchasecustomer_Click(object sender, EventArgs e)
        {
            if (customerbox.SelectedValue != null)
            {
                frmReportViewer bp = new frmReportViewer(this);
                bp.loadPurchaseCustomerWise();
                bp.ShowDialog();
            }
            else
            {
                MessageBox.Show("PLEASE SELECT ANY CUSTOMER");
            }
        }

        private void productwisestock_Click(object sender, EventArgs e)
        {
            if (productbox.SelectedValue != null)
            {
                frmReportViewer bp = new frmReportViewer(this);
                Stocking();
                bp.loadstockwithproduct();
                bp.ShowDialog();
            }
            else
            {
                MessageBox.Show("PLEASE SELECT ANY PRODUCT");
            }
        }

        private void productswise_Click(object sender, EventArgs e)
        {
                frmReportViewer bp = new frmReportViewer(this);
                Stocking();
                bp.loadstockwithproducts();
                bp.ShowDialog();
          

        }

        public void Stocking()
        {
            try
            {
              

                for (int j = 0; j < productbox.Items.Count; j++)
                {
                    cn.Open();
                    cm = new SqlCommand("Select sum(qty) from tblSale where pname = '" + productbox.GetItemText(productbox.Items[j]) + "' ", cn);
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("Select sum(qty) from tblPurchase where pname = '" + productbox.GetItemText(productbox.Items[j]) + "' ", cn);
                    SqlDataAdapter da1 = new SqlDataAdapter(cm);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    cn.Close();

                    Double t;
                    Double p, s;
                    if (dt.Rows[0][0] != DBNull.Value)
                    {
                        s = Double.Parse(dt.Rows[0][0].ToString());
                    }
                    else
                    {
                        s = 0;
                    }
                    if (dt1.Rows[0][0] != DBNull.Value)
                    {
                        p = Double.Parse(dt1.Rows[0][0].ToString());
                    }
                    else
                    {
                        p = 0;
                    }
                    t = p - s ;

                   
                        cn.Open();
                        cm = new SqlCommand("Update tblProduct set qty = @qty  where pname = '" + productbox.GetItemText(productbox.Items[j]) + "'", cn);
                        cm.Parameters.AddWithValue("@qty", t);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void profitratoio_Click(object sender, EventArgs e)
        {
            profit();
            frmReportViewer bp = new frmReportViewer(this);
            bp.loadProfit();
            bp.ShowDialog();
        }

        public void profit()
        {
            cn.Open();
            cm = new SqlCommand("delete from tblProfit", cn);
            cm.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cm = new SqlCommand("select pname from tblProduct order by pname asc", cn);
            SqlDataAdapter da1 = new SqlDataAdapter(cm);
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            da1.Fill(dt1);
            cn.Close();


            for (int j = 0; j < dt1.Rows.Count; j++)
            {

                cn.Open();
                cm = new SqlCommand("select Sum(c.Total) from tblSale as c inner join tblProduct as p on c.pcode = p.pcode where p.pname like '" + dt1.Rows[j][0] + "'", cn);
                SqlDataAdapter da2 = new SqlDataAdapter(cm);

                da2.Fill(dt2);
                if (dt2.Rows.Count <= j)
                {
                    dt2.Rows.Add("0");
                }
                cn.Close();
            }

            for (int j = 0; j < dt1.Rows.Count; j++)
            {

                cn.Open();
                cm = new SqlCommand("select Sum(c.Total) from tblPurchase as c inner join tblProduct as p on c.pcode = p.pcode where p.pname like '" + dt1.Rows[j][0] + "'", cn);
                SqlDataAdapter da3 = new SqlDataAdapter(cm);
                
                da3.Fill(dt3);
                if (dt3.Rows.Count <= j)
                {
                    dt3.Rows.Add("0");
                }
                cn.Close();
            }

            for(int k = 0; k < dt1.Rows.Count; k++)
            {
                cn.Open();
                cm = new SqlCommand("insert into tblProfit (pname,purchase,sale,profit) values (@pname,@purchase,@sale,@profit)", cn);
                cm.Parameters.AddWithValue("@pname", dt1.Rows[k][0]);
                cm.Parameters.AddWithValue("@purchase", dt3.Rows[k][0]);
                cm.Parameters.AddWithValue("@sale", dt2.Rows[k][0]);
                if (dt2.Rows[k][0] != DBNull.Value && dt3.Rows[k][0] != DBNull.Value)
                {
                    cm.Parameters.AddWithValue("@profit", float.Parse(dt2.Rows[k][0].ToString()) - float.Parse(dt3.Rows[k][0].ToString()));
                }
                else if (dt2.Rows[k][0] != DBNull.Value)
                {
                    cm.Parameters.AddWithValue("@profit", "-" +  dt2.Rows[k][0].ToString());
                }
                else if (dt3.Rows[k][0] != DBNull.Value)
                {
                    cm.Parameters.AddWithValue("@profit", dt3.Rows[k][0]);
                }
                else 
                {
                    cm.Parameters.AddWithValue("@profit", "0");
                }
                cm.ExecuteNonQuery();
                cn.Close();
            }

        }

        public void profitMonthly()
        {
            cn.Open();
            cm = new SqlCommand("delete from tblProfit", cn);
            cm.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cm = new SqlCommand("select pname from tblProduct order by pname asc", cn);
            SqlDataAdapter da1 = new SqlDataAdapter(cm);
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            da1.Fill(dt1);
            cn.Close();


                cn.Open();
                cm = new SqlCommand("select Sum(Total) from tblSale where  Date between '" + date1.Value + "' and '" + date2.Value + "'", cn);
                SqlDataAdapter da2 = new SqlDataAdapter(cm);

                da2.Fill(dt2);
        
                cn.Close();
            

         

                cn.Open();
                cm = new SqlCommand("select Sum(Total) from tblPurchase  where  Date between '" + date1.Value + "' and '" + date2.Value + "'", cn);
                SqlDataAdapter da3 = new SqlDataAdapter(cm);

                da3.Fill(dt3);
               
                cn.Close();

            cn.Open();
            cm = new SqlCommand("insert into tblProfit (pname,purchase,sale,profit) values (@pname,@purchase,@sale,@profit)", cn);
            cm.Parameters.AddWithValue("@pname", "ALL PRODUCT");
            cm.Parameters.AddWithValue("@purchase", dt3.Rows[0][0]);
            cm.Parameters.AddWithValue("@sale", dt2.Rows[0][0]);
            if (dt2.Rows[0][0] != DBNull.Value && dt3.Rows[0][0] != DBNull.Value)
            {
                cm.Parameters.AddWithValue("@profit", float.Parse(dt2.Rows[0][0].ToString()) - float.Parse(dt3.Rows[0][0].ToString()));
            }
            else if (dt2.Rows[0][0] != DBNull.Value)
            {
                cm.Parameters.AddWithValue("@profit", "-" + dt2.Rows[0][0].ToString());
            }
            else if (dt3.Rows[0][0] != DBNull.Value)
            {
                cm.Parameters.AddWithValue("@profit", dt3.Rows[0][0]);
            }
            else
            {
                cm.Parameters.AddWithValue("@profit", "0");
            }
            cm.ExecuteNonQuery();
            cn.Close();


        }
        public void profitproductwise()
        {
            if (productbox.SelectedValue != null)
            {
                cn.Open();
                cm = new SqlCommand("delete from tblProfit", cn);
                cm.ExecuteNonQuery();
                cn.Close();

                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();


                cn.Open();
                cm = new SqlCommand("select Sum(c.Total) from tblSale as c inner join tblProduct as p on c.pcode = p.pcode where p.pname like '" + productbox.SelectedValue + "'", cn);
                SqlDataAdapter da2 = new SqlDataAdapter(cm);
                da2.Fill(dt2);
                cn.Close();



                cn.Open();
                cm = new SqlCommand("select Sum(c.Total) from tblPurchase as c inner join tblProduct as p on c.pcode = p.pcode where p.pname like '" + productbox.SelectedValue + "'", cn);
                SqlDataAdapter da3 = new SqlDataAdapter(cm);
                da3.Fill(dt3);
                cn.Close();

                cn.Open();
                cm = new SqlCommand("insert into tblProfit (pname,purchase,sale,profit) values (@pname,@purchase,@sale,@profit)", cn);
                cm.Parameters.AddWithValue("@pname", productbox.SelectedValue);
                cm.Parameters.AddWithValue("@purchase", dt3.Rows[0][0]);
                cm.Parameters.AddWithValue("@sale", dt2.Rows[0][0]);
                if (dt2.Rows[0][0] != DBNull.Value && dt3.Rows[0][0] != DBNull.Value)
                {
                    cm.Parameters.AddWithValue("@profit", float.Parse(dt2.Rows[0][0].ToString()) - float.Parse(dt3.Rows[0][0].ToString()));
                }
                else if (dt2.Rows[0][0] != DBNull.Value)
                {
                    cm.Parameters.AddWithValue("@profit", "-" + dt2.Rows[0][0].ToString());
                }
                else if (dt3.Rows[0][0] != DBNull.Value)
                {
                    cm.Parameters.AddWithValue("@profit", dt3.Rows[0][0]);
                }
                else
                {
                    cm.Parameters.AddWithValue("@profit", "0");
                }
                cm.ExecuteNonQuery();
                cn.Close();
            }
            else
            {
                MessageBox.Show("PLEASE SELECT ANY PRODUCT");
            }
            }

        


        private void btnprofit_Click(object sender, EventArgs e)
        {
            profitproductwise();
            frmReportViewer bp = new frmReportViewer(this);
            bp.loadProfit();
            bp.ShowDialog();
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            getproductname();
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            getcustomer();
        }

        private void allproductsstock_Click(object sender, EventArgs e)
        {

            frmReportViewer bp = new frmReportViewer(this);
            Stocking();
            bp.loadstockwithproductsall();
            bp.ShowDialog();
        }

        private void btntypestock_Click(object sender, EventArgs e)
        {
            if (producttype.SelectedValue != null)
            {
                frmReportViewer bp = new frmReportViewer(this);
                Stocking();
                bp.loadstockwithproducttype();
                bp.ShowDialog();
            }
            else
            {
                MessageBox.Show("PLEASE SELECT ANY PRODUCT TYPE");
            }
        }

        private void btnprofitdate_Click(object sender, EventArgs e)
        {
            profitMonthly();
            frmReportViewer bp = new frmReportViewer(this);
            bp.loadProfit();
            bp.ShowDialog();
        }

        public void compsode()
        {
            cn.Open();
            cm = new SqlCommand("update tblSodaReport set status = 'COMPLETED' where qty = '0' ",cn);
            cm.ExecuteNonQuery();
            cn.Close();


            cn.Open();
            cm = new SqlCommand("update tblSodaReport set status = 'REMAINING' where qty != '0' ", cn);
            cm.ExecuteNonQuery();
            cn.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            compsode();
            frmReportViewer bp = new frmReportViewer(this);
            bp.loadCompleteSodaReport();
            bp.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            compsode();
            frmReportViewer bp = new frmReportViewer(this);
            bp.loadReamingSodaReport();
            bp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            compsode();
            frmReportViewer bp = new frmReportViewer(this);
            bp.loadProductWiseSodaReport();
            bp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            compsode();
            frmReportViewer bp = new frmReportViewer(this);
            bp.loadPartwiseSodaReport();
            bp.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            compsode();
            frmReportViewer bp = new frmReportViewer(this);
            bp.loadProductWiseSodaReportcomp();
            bp.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            compsode();
            frmReportViewer bp = new frmReportViewer(this);
            bp.loadPartwiseSodaReportcomp();
            bp.ShowDialog();
        }
    }
}
