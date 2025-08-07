using Microsoft.Reporting.WinForms;
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
    public partial class frmReportViewer : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        frmReports fp;
        public frmReportViewer(frmReports fr)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            fp = fr;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        public void loadDailySale()
        {
            try
            {
                OilShopDataSet ds = new OilShopDataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\DailySale.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select c.Date,c.Billno,c.cname,c.pcode,p.pname,c.price,c.qty,c.Total from tblSale as c inner join tblProduct as p on c.pcode = p.pcode where Date between '" + fp.date1.Value + "' and '" + fp.date2.Value + "' order by Date ", cn);
                da.Fill(ds.Tables["tblSale"]);
                
                cn.Close();


                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblSale"]);
                reportViewer1.LocalReport.DataSources.Add(rds);


                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fp.date2.Value.ToString("dd/MM/yyyy"));
                ReportParameter title = new ReportParameter("TITLE", "DAILY SALE REPORT");
                this.reportViewer1.LocalReport.SetParameters(title);
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);

                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);



                /**
              LocalReport report = new LocalReport();
                string path = Application.StartupPath + @"\Reports\Report1.rdlc";
                report.ReportPath = path;
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dtSold"]));
                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", "INVOICE NO : " + fpos.txtInvoiceNo.Text);
                ReportParameter ptotal = new ReportParameter("ptotal", fpos.txttotal.Text);
                ReportParameter pCash = new ReportParameter("pcash", pcash.ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pchange", pchange);
                report.SetParameters(InvoiceNo);
                report.SetParameters(ptotal);
                report.SetParameters(pCash);
                report.SetParameters(pChange);
               // report.font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                PrintToPrinter(report);
                
                //  reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(Token);
    **/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                cn.Close();
            }
        }
        public void loadSaleCustomerWise()
        {
            try
            {
                OilShopDataSet ds = new OilShopDataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\DailySale.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select c.Date,c.Billno,c.cname,c.pcode,p.pname,c.price,c.qty,c.Total from tblSale as c inner join tblProduct as p on c.pcode = p.pcode where cname like '"+fp.customerbox.SelectedValue+"' and Date between '" + fp.date1.Value + "' and '" + fp.date2.Value + "' order by Date ", cn);
                da.Fill(ds.Tables["tblSale"]);

                cn.Close();


                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblSale"]);
                reportViewer1.LocalReport.DataSources.Add(rds);


                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fp.date2.Value.ToString("dd/MM/yyyy"));
                ReportParameter title = new ReportParameter("TITLE", "CUSTOMER WISE REPORT");
                this.reportViewer1.LocalReport.SetParameters(title);
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);

                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);



                /**
              LocalReport report = new LocalReport();
                string path = Application.StartupPath + @"\Reports\Report1.rdlc";
                report.ReportPath = path;
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dtSold"]));
                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", "INVOICE NO : " + fpos.txtInvoiceNo.Text);
                ReportParameter ptotal = new ReportParameter("ptotal", fpos.txttotal.Text);
                ReportParameter pCash = new ReportParameter("pcash", pcash.ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pchange", pchange);
                report.SetParameters(InvoiceNo);
                report.SetParameters(ptotal);
                report.SetParameters(pCash);
                report.SetParameters(pChange);
               // report.font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                PrintToPrinter(report);
                
                //  reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(Token);
    **/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                cn.Close();
            }
        }

        public void loadSaleProductWise()
        {
            try
            {
                OilShopDataSet ds = new OilShopDataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\DailySale.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select c.Date,c.Billno,c.cname,c.pcode,p.pname,c.price,c.qty,c.Total from tblSale as c inner join tblProduct as p on c.pcode = p.pcode where p.pname like '" + fp.productbox.SelectedValue + "' and Date between '" + fp.date1.Value + "' and '" + fp.date2.Value + "' order by Date ", cn);
                da.Fill(ds.Tables["tblSale"]);

                cn.Close();


                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblSale"]);
                reportViewer1.LocalReport.DataSources.Add(rds);


                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fp.date2.Value.ToString("dd/MM/yyyy"));
                ReportParameter title = new ReportParameter("TITLE", "PRODUCT WISE REPORT");
                this.reportViewer1.LocalReport.SetParameters(title);
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);

                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);



                /**
              LocalReport report = new LocalReport();
                string path = Application.StartupPath + @"\Reports\Report1.rdlc";
                report.ReportPath = path;
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dtSold"]));
                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", "INVOICE NO : " + fpos.txtInvoiceNo.Text);
                ReportParameter ptotal = new ReportParameter("ptotal", fpos.txttotal.Text);
                ReportParameter pCash = new ReportParameter("pcash", pcash.ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pchange", pchange);
                report.SetParameters(InvoiceNo);
                report.SetParameters(ptotal);
                report.SetParameters(pCash);
                report.SetParameters(pChange);
               // report.font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                PrintToPrinter(report);
                
                //  reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(Token);
    **/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                cn.Close();
            }
        }

        public void loadDailyPurchase()
        {
            try
            {
                OilShopDataSet1 ds = new OilShopDataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\DailyPurchase.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select c.Date,c.Billno,c.cname,c.pcode,p.pname,c.price,c.qty,c.Total from tblPurchase as c inner join tblProduct as p on c.pcode = p.pcode where Date between '" + fp.date1.Value + "' and '" + fp.date2.Value + "' order by Date ", cn);
                da.Fill(ds.Tables["tblPurchase"]);

                cn.Close();


                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblPurchase"]);
                reportViewer1.LocalReport.DataSources.Add(rds);


                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fp.date2.Value.ToString("dd/MM/yyyy"));
                ReportParameter title = new ReportParameter("TITLE", "DAILY PURCHASE REPORT");
                this.reportViewer1.LocalReport.SetParameters(title);
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);

                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);



                /**
              LocalReport report = new LocalReport();
                string path = Application.StartupPath + @"\Reports\Report1.rdlc";
                report.ReportPath = path;
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dtSold"]));
                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", "INVOICE NO : " + fpos.txtInvoiceNo.Text);
                ReportParameter ptotal = new ReportParameter("ptotal", fpos.txttotal.Text);
                ReportParameter pCash = new ReportParameter("pcash", pcash.ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pchange", pchange);
                report.SetParameters(InvoiceNo);
                report.SetParameters(ptotal);
                report.SetParameters(pCash);
                report.SetParameters(pChange);
               // report.font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                PrintToPrinter(report);
                
                //  reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(Token);
    **/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                cn.Close();
            }
        }
        public void loadPurchaseCustomerWise()
        {
            try
            {
                OilShopDataSet1 ds = new OilShopDataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\DailyPurchase.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select c.Date,c.Billno,c.cname,c.pcode,p.pname,c.price,c.qty,c.Total from tblPurchase as c inner join tblProduct as p on c.pcode = p.pcode where cname like '" + fp.customerbox.SelectedValue + "' and Date between '" + fp.date1.Value + "' and '" + fp.date2.Value + "' order by Date ", cn);
                da.Fill(ds.Tables["tblPurchase"]);

                cn.Close();


                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblPurchase"]);
                reportViewer1.LocalReport.DataSources.Add(rds);


                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fp.date2.Value.ToString("dd/MM/yyyy"));
                ReportParameter title = new ReportParameter("TITLE", "CUSTOMER WISE PURCHASE REPORT");
                this.reportViewer1.LocalReport.SetParameters(title);
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);

                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);



                /**
              LocalReport report = new LocalReport();
                string path = Application.StartupPath + @"\Reports\Report1.rdlc";
                report.ReportPath = path;
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dtSold"]));
                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", "INVOICE NO : " + fpos.txtInvoiceNo.Text);
                ReportParameter ptotal = new ReportParameter("ptotal", fpos.txttotal.Text);
                ReportParameter pCash = new ReportParameter("pcash", pcash.ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pchange", pchange);
                report.SetParameters(InvoiceNo);
                report.SetParameters(ptotal);
                report.SetParameters(pCash);
                report.SetParameters(pChange);
               // report.font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                PrintToPrinter(report);
                
                //  reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(Token);
    **/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                cn.Close();
            }
        }

        public void loadPurchaseProductWise()
        {
            try
            {
                OilShopDataSet1 ds = new OilShopDataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\DailyPurchase.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select c.Date,c.Billno,c.cname,c.pcode,p.pname,c.price,c.qty,c.Total from tblPurchase as c inner join tblProduct as p on c.pcode = p.pcode where p.pname like '" + fp.productbox.SelectedValue + "' and Date between '" + fp.date1.Value + "' and '" + fp.date2.Value + "' order by Date ", cn);
                da.Fill(ds.Tables["tblPurchase"]);

                cn.Close();


                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblPurchase"]);
                reportViewer1.LocalReport.DataSources.Add(rds);


                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fp.date2.Value.ToString("dd/MM/yyyy"));
                ReportParameter title = new ReportParameter("TITLE", "PRODUCT WISE PURCHASE REPORT");
                this.reportViewer1.LocalReport.SetParameters(title);
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);

                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);



                /**
              LocalReport report = new LocalReport();
                string path = Application.StartupPath + @"\Reports\Report1.rdlc";
                report.ReportPath = path;
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dtSold"]));
                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", "INVOICE NO : " + fpos.txtInvoiceNo.Text);
                ReportParameter ptotal = new ReportParameter("ptotal", fpos.txttotal.Text);
                ReportParameter pCash = new ReportParameter("pcash", pcash.ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pchange", pchange);
                report.SetParameters(InvoiceNo);
                report.SetParameters(ptotal);
                report.SetParameters(pCash);
                report.SetParameters(pChange);
               // report.font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                PrintToPrinter(report);
                
                //  reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(Token);
    **/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                cn.Close();
            }
        }
        public void loadstockwithproducts()
        {
            try
            {
                OilShopDataSet3 ds = new OilShopDataSet3();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Stock.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select * from tblProduct where qty != '0' order by pname asc", cn);
                da.Fill(ds.Tables["tblProduct"]);

                cn.Close();


                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblProduct"]);
                reportViewer1.LocalReport.DataSources.Add(rds);


                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fp.date2.Value.ToString("dd/MM/yyyy"));
                ReportParameter title = new ReportParameter("TITLE", "ALL PRODUCTS STOCK");
                this.reportViewer1.LocalReport.SetParameters(title);
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);

                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);



                /**
              LocalReport report = new LocalReport();
                string path = Application.StartupPath + @"\Reports\Report1.rdlc";
                report.ReportPath = path;
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dtSold"]));
                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", "INVOICE NO : " + fpos.txtInvoiceNo.Text);
                ReportParameter ptotal = new ReportParameter("ptotal", fpos.txttotal.Text);
                ReportParameter pCash = new ReportParameter("pcash", pcash.ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pchange", pchange);
                report.SetParameters(InvoiceNo);
                report.SetParameters(ptotal);
                report.SetParameters(pCash);
                report.SetParameters(pChange);
               // report.font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                PrintToPrinter(report);
                
                //  reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(Token);
    **/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                cn.Close();
            }
        }
        public void loadstockwithproductsall()
        {
            try
            {
                OilShopDataSet3 ds = new OilShopDataSet3();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Stock.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select * from tblProduct order by pname asc", cn);
                da.Fill(ds.Tables["tblProduct"]);

                cn.Close();


                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblProduct"]);
                reportViewer1.LocalReport.DataSources.Add(rds);


                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fp.date2.Value.ToString("dd/MM/yyyy"));
                ReportParameter title = new ReportParameter("TITLE", "ALL PRODUCTS STOCK");
                this.reportViewer1.LocalReport.SetParameters(title);
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);

                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);



                /**
              LocalReport report = new LocalReport();
                string path = Application.StartupPath + @"\Reports\Report1.rdlc";
                report.ReportPath = path;
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dtSold"]));
                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", "INVOICE NO : " + fpos.txtInvoiceNo.Text);
                ReportParameter ptotal = new ReportParameter("ptotal", fpos.txttotal.Text);
                ReportParameter pCash = new ReportParameter("pcash", pcash.ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pchange", pchange);
                report.SetParameters(InvoiceNo);
                report.SetParameters(ptotal);
                report.SetParameters(pCash);
                report.SetParameters(pChange);
               // report.font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                PrintToPrinter(report);
                
                //  reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(Token);
    **/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                cn.Close();
            }
        }

        public void loadstockwithproduct()
        {
            try
            {
                OilShopDataSet3 ds = new OilShopDataSet3();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Stock.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select * from tblProduct where pname like '" + fp.productbox.SelectedValue + "' ", cn);
                da.Fill(ds.Tables["tblProduct"]);

                cn.Close();


                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblProduct"]);
                reportViewer1.LocalReport.DataSources.Add(rds);


                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fp.date2.Value.ToString("dd/MM/yyyy"));
                ReportParameter title = new ReportParameter("TITLE", "PRODUCT WISE STOCK");
                this.reportViewer1.LocalReport.SetParameters(title);
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);

                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);



                /**
              LocalReport report = new LocalReport();
                string path = Application.StartupPath + @"\Reports\Report1.rdlc";
                report.ReportPath = path;
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dtSold"]));
                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", "INVOICE NO : " + fpos.txtInvoiceNo.Text);
                ReportParameter ptotal = new ReportParameter("ptotal", fpos.txttotal.Text);
                ReportParameter pCash = new ReportParameter("pcash", pcash.ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pchange", pchange);
                report.SetParameters(InvoiceNo);
                report.SetParameters(ptotal);
                report.SetParameters(pCash);
                report.SetParameters(pChange);
               // report.font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                PrintToPrinter(report);
                
                //  reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(Token);
    **/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                cn.Close();
            }
        }

        public void loadstockwithproducttype()
        {
            try
            {
                OilShopDataSet3 ds = new OilShopDataSet3();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Stock.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select * from tblProduct where ptype like '" + fp.producttype.SelectedValue + "' ", cn);
                da.Fill(ds.Tables["tblProduct"]);

                cn.Close();


                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblProduct"]);
                reportViewer1.LocalReport.DataSources.Add(rds);


                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fp.date2.Value.ToString("dd/MM/yyyy"));
                ReportParameter title = new ReportParameter("TITLE", "PRODUCT TYPE WISE STOCK");
                this.reportViewer1.LocalReport.SetParameters(title);
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);

                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);



                /**
              LocalReport report = new LocalReport();
                string path = Application.StartupPath + @"\Reports\Report1.rdlc";
                report.ReportPath = path;
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dtSold"]));
                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", "INVOICE NO : " + fpos.txtInvoiceNo.Text);
                ReportParameter ptotal = new ReportParameter("ptotal", fpos.txttotal.Text);
                ReportParameter pCash = new ReportParameter("pcash", pcash.ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pchange", pchange);
                report.SetParameters(InvoiceNo);
                report.SetParameters(ptotal);
                report.SetParameters(pCash);
                report.SetParameters(pChange);
               // report.font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                PrintToPrinter(report);
                
                //  reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(Token);
    **/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                cn.Close();
            }
        }

        public void loadProfit()
        {
            try
            {
                OilShopDataSet3 ds = new OilShopDataSet3();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ProfitRatio.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select * from tblProfit order by pname asc ", cn);
                da.Fill(ds.Tables["tblProfit"]);
                cn.Close();

                cn.Open();
            
                ReportDataSource rds2 = new ReportDataSource("DataSet1", ds.Tables["tblProfit"]);
                reportViewer1.LocalReport.DataSources.Add(rds2);


                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fp.date2.Value.ToString("dd/MM/yyyy"));
                ReportParameter title = new ReportParameter("TITLE", "PROFIT RATIO");
                this.reportViewer1.LocalReport.SetParameters(title);
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);

                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);



                /**
              LocalReport report = new LocalReport();
                string path = Application.StartupPath + @"\Reports\Report1.rdlc";
                report.ReportPath = path;
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dtSold"]));
                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", "INVOICE NO : " + fpos.txtInvoiceNo.Text);
                ReportParameter ptotal = new ReportParameter("ptotal", fpos.txttotal.Text);
                ReportParameter pCash = new ReportParameter("pcash", pcash.ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pchange", pchange);
                report.SetParameters(InvoiceNo);
                report.SetParameters(ptotal);
                report.SetParameters(pCash);
                report.SetParameters(pChange);
               // report.font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                PrintToPrinter(report);
                
                //  reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(Token);
    **/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                cn.Close();
            }
        }

        public void loadCompleteSodaReport()
        {
            try
            {
                OilShopDataSet4 ds = new OilShopDataSet4();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\SodaReport.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select * from tblSodaReport where status = 'COMPLETED' order by cname ", cn);
                da.Fill(ds.Tables["tblSodaReport"]);

                cn.Close();


                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblSodaReport"]);
                reportViewer1.LocalReport.DataSources.Add(rds);

                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fp.date2.Value.ToString("dd/MM/yyyy"));
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);


                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);



                /**
              LocalReport report = new LocalReport();
                string path = Application.StartupPath + @"\Reports\Report1.rdlc";
                report.ReportPath = path;
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dtSold"]));
                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", "INVOICE NO : " + fpos.txtInvoiceNo.Text);
                ReportParameter ptotal = new ReportParameter("ptotal", fpos.txttotal.Text);
                ReportParameter pCash = new ReportParameter("pcash", pcash.ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pchange", pchange);
                report.SetParameters(InvoiceNo);
                report.SetParameters(ptotal);
                report.SetParameters(pCash);
                report.SetParameters(pChange);
               // report.font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                PrintToPrinter(report);
                
                //  reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(Token);
    **/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                cn.Close();
            }
        }

        public void loadReamingSodaReport()
        {
            try
            {
                OilShopDataSet4 ds = new OilShopDataSet4();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\SodaReport.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select * from tblSodaReport where status = 'REMAINING' order by cname ", cn);
                da.Fill(ds.Tables["tblSodaReport"]);

                cn.Close();


                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblSodaReport"]);
                reportViewer1.LocalReport.DataSources.Add(rds);

                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fp.date2.Value.ToString("dd/MM/yyyy"));
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);


                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);



                /**
              LocalReport report = new LocalReport();
                string path = Application.StartupPath + @"\Reports\Report1.rdlc";
                report.ReportPath = path;
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dtSold"]));
                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", "INVOICE NO : " + fpos.txtInvoiceNo.Text);
                ReportParameter ptotal = new ReportParameter("ptotal", fpos.txttotal.Text);
                ReportParameter pCash = new ReportParameter("pcash", pcash.ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pchange", pchange);
                report.SetParameters(InvoiceNo);
                report.SetParameters(ptotal);
                report.SetParameters(pCash);
                report.SetParameters(pChange);
               // report.font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                PrintToPrinter(report);
                
                //  reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(Token);
    **/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                cn.Close();
            }
        }

        public void loadPartwiseSodaReport()
        {
            try
            {
                OilShopDataSet4 ds = new OilShopDataSet4();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\SodaReport.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select * from tblSodaReport where cname like '"+ fp.customerbox.SelectedValue + "' and status = 'REMAINING' order by cname ", cn);
                da.Fill(ds.Tables["tblSodaReport"]);

                cn.Close();


                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblSodaReport"]);
                reportViewer1.LocalReport.DataSources.Add(rds);

                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fp.date2.Value.ToString("dd/MM/yyyy"));
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);


                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);



                /**
              LocalReport report = new LocalReport();
                string path = Application.StartupPath + @"\Reports\Report1.rdlc";
                report.ReportPath = path;
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dtSold"]));
                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", "INVOICE NO : " + fpos.txtInvoiceNo.Text);
                ReportParameter ptotal = new ReportParameter("ptotal", fpos.txttotal.Text);
                ReportParameter pCash = new ReportParameter("pcash", pcash.ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pchange", pchange);
                report.SetParameters(InvoiceNo);
                report.SetParameters(ptotal);
                report.SetParameters(pCash);
                report.SetParameters(pChange);
               // report.font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                PrintToPrinter(report);
                
                //  reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(Token);
    **/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                cn.Close();
            }
        }

        public void loadProductWiseSodaReport()
        {
            try
            {
                OilShopDataSet4 ds = new OilShopDataSet4();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\SodaReport.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select * from tblSodaReport where pname like '"+fp.productbox.SelectedValue+ "' and status = 'REMAINING' order by cname ", cn);
                da.Fill(ds.Tables["tblSodaReport"]);

                cn.Close();


                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblSodaReport"]);
                reportViewer1.LocalReport.DataSources.Add(rds);

                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fp.date2.Value.ToString("dd/MM/yyyy"));
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);

                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);



                /**
              LocalReport report = new LocalReport();
                string path = Application.StartupPath + @"\Reports\Report1.rdlc";
                report.ReportPath = path;
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dtSold"]));
                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", "INVOICE NO : " + fpos.txtInvoiceNo.Text);
                ReportParameter ptotal = new ReportParameter("ptotal", fpos.txttotal.Text);
                ReportParameter pCash = new ReportParameter("pcash", pcash.ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pchange", pchange);
                report.SetParameters(InvoiceNo);
                report.SetParameters(ptotal);
                report.SetParameters(pCash);
                report.SetParameters(pChange);
               // report.font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                PrintToPrinter(report);
                
                //  reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(Token);
    **/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                cn.Close();
            }
        }
        public void loadPartwiseSodaReportcomp()
        {
            try
            {
                OilShopDataSet4 ds = new OilShopDataSet4();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\SodaReport.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select * from tblSodaReport where cname like '" + fp.customerbox.SelectedValue + "' and status = 'COMPLETED' order by cname ", cn);
                da.Fill(ds.Tables["tblSodaReport"]);

                cn.Close();


                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblSodaReport"]);
                reportViewer1.LocalReport.DataSources.Add(rds);

                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fp.date2.Value.ToString("dd/MM/yyyy"));
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);


                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);



                /**
              LocalReport report = new LocalReport();
                string path = Application.StartupPath + @"\Reports\Report1.rdlc";
                report.ReportPath = path;
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dtSold"]));
                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", "INVOICE NO : " + fpos.txtInvoiceNo.Text);
                ReportParameter ptotal = new ReportParameter("ptotal", fpos.txttotal.Text);
                ReportParameter pCash = new ReportParameter("pcash", pcash.ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pchange", pchange);
                report.SetParameters(InvoiceNo);
                report.SetParameters(ptotal);
                report.SetParameters(pCash);
                report.SetParameters(pChange);
               // report.font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                PrintToPrinter(report);
                
                //  reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(Token);
    **/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                cn.Close();
            }
        }

        public void loadProductWiseSodaReportcomp()
        {
            try
            {
                OilShopDataSet4 ds = new OilShopDataSet4();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\SodaReport.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select * from tblSodaReport where pname like '" + fp.productbox.SelectedValue + "' and status = 'COMPLETED' order by cname ", cn);
                da.Fill(ds.Tables["tblSodaReport"]);

                cn.Close();


                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblSodaReport"]);
                reportViewer1.LocalReport.DataSources.Add(rds);

                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fp.date2.Value.ToString("dd/MM/yyyy"));
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);

                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);



                /**
              LocalReport report = new LocalReport();
                string path = Application.StartupPath + @"\Reports\Report1.rdlc";
                report.ReportPath = path;
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["dtSold"]));
                ReportParameter InvoiceNo = new ReportParameter("InvoiceNo", "INVOICE NO : " + fpos.txtInvoiceNo.Text);
                ReportParameter ptotal = new ReportParameter("ptotal", fpos.txttotal.Text);
                ReportParameter pCash = new ReportParameter("pcash", pcash.ToString("#,##0.00"));
                ReportParameter pChange = new ReportParameter("pchange", pchange);
                report.SetParameters(InvoiceNo);
                report.SetParameters(ptotal);
                report.SetParameters(pCash);
                report.SetParameters(pChange);
               // report.font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                PrintToPrinter(report);
                
                //  reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(Token);
    **/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                cn.Close();
            }
        }
    }
}
