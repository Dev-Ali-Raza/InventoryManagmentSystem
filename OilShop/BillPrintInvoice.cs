using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilShop
{
    public partial class BillPrintInvoice : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        frmBillBook fps;

        public static int a;
        private static List<Stream> m_streams;
        private static int m_currentPageIndex = 0;

        public BillPrintInvoice(frmBillBook fp)
        {
            InitializeComponent();

            cn = new SqlConnection(dbcon.MyConnection());
            fps = fp;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BillPrintInvoice_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void loadReportSale()
        {
            try
            {
                OilShopDataSet ds = new OilShopDataSet();
                OilShopDataSet1 ds1 = new OilShopDataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report1.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select c.id,c.pdes,c.type,c.Date,c.Billno,c.cname,c.pcode,p.pname,c.price,c.qty,c.Total from tblSale as c inner join tblProduct as p on c.pcode = p.pcode where Billno like '" + fps.Billno.Text + "' order by id", cn);
                da.Fill(ds.Tables["tblSale"]);

                da.SelectCommand = new SqlCommand("select * from tblCustomer where cname like '" + fps.cname.Text + "'", cn);
                da.Fill(ds1.Tables["tblCustomer"]);

                cn.Close();




                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblSale"]);
                reportViewer1.LocalReport.DataSources.Add(rds);

                ReportDataSource rds1 = new ReportDataSource("DataSet2", ds1.Tables["tblCustomer"]);
                reportViewer1.LocalReport.DataSources.Add(rds1);
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
            public void loadReportSaleDirectO()
        { 
            try
            {
                OilShopDataSet ds = new OilShopDataSet();
                OilShopDataSet1 ds1 = new OilShopDataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataAdapter da1 = new SqlDataAdapter();
                LocalReport report = new LocalReport();
                report.DataSources.Clear();
                report.ReportPath = Application.StartupPath + @"\Reports\Report1.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select c.id,c.pdes,c.type,c.Date,c.Billno,c.cname,c.pcode,p.pname,c.price,c.qty,c.Total from tblSale as c inner join tblProduct as p on c.pcode = p.pcode where Billno like '" + fps.Billno.Text + "' order by id", cn);
                da.Fill(ds.Tables["tblSale"]);

                da1.SelectCommand = new SqlCommand("select * from tblCustomer where cname like '" + fps.cname.Text + "'", cn);
                da1.Fill(ds1.Tables["tblCustomer"]);
                cn.Close();



                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblSale"]);
                report.DataSources.Add(rds);


                ReportDataSource rds1 = new ReportDataSource("DataSet2", ds1.Tables["tblCustomer"]);
                report.DataSources.Add(rds1);

                ReportParameter type = new ReportParameter("type", "ORIGINAL");
                report.SetParameters(type);


                PrintToPrinter(report);

            

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
        public void loadReportSaleDirectD()
        {
            try
            {
                OilShopDataSet ds = new OilShopDataSet();
                OilShopDataSet1 ds1 = new OilShopDataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataAdapter da1 = new SqlDataAdapter();
                LocalReport report = new LocalReport();
                report.DataSources.Clear();
                report.ReportPath = Application.StartupPath + @"\Reports\Report1.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select c.id,c.pdes,c.type,c.Date,c.Billno,c.cname,c.pcode,p.pname,c.price,c.qty,c.Total from tblSale as c inner join tblProduct as p on c.pcode = p.pcode where Billno like '" + fps.Billno.Text + "' order by id", cn);
                da.Fill(ds.Tables["tblSale"]);

                da1.SelectCommand = new SqlCommand("select * from tblCustomer where cname like '" + fps.cname.Text + "'", cn);
                da1.Fill(ds1.Tables["tblCustomer"]);
                cn.Close();



                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblSale"]);
                report.DataSources.Add(rds);


                ReportDataSource rds1 = new ReportDataSource("DataSet2", ds1.Tables["tblCustomer"]);
                report.DataSources.Add(rds1);

                ReportParameter type = new ReportParameter("type", "DUPLICATE");
                report.SetParameters(type);


                PrintToPrinter(report);



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

        public void loadReportPurchase()
        {
            try
            {
                OilShopDataSet1 ds = new OilShopDataSet1();

                OilShopDataSet1 ds1 = new OilShopDataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataAdapter da1 = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\SaleInvoice.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select c.id,c.pdes,c.type,c.Date,c.Billno,c.cname,c.pcode,p.pname,c.price,c.qty,c.Total from tblPurchase as c inner join tblProduct as p on c.pcode = p.pcode where Billno like '" + fps.Billno.Text + "' order by id", cn);
                da.Fill(ds.Tables["tblPurchase"]);

                da1.SelectCommand = new SqlCommand("select * from tblCustomer where cname like '" + fps.cname.Text + "'", cn);
                da1.Fill(ds1.Tables["tblCustomer"]);
                cn.Close();



                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblPurchase"]);
                reportViewer1.LocalReport.DataSources.Add(rds);


                ReportDataSource rds1 = new ReportDataSource("DataSet2", ds1.Tables["tblCustomer"]);
                reportViewer1.LocalReport.DataSources.Add(rds1);

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
                cn.Close();
                MessageBox.Show(ex.Message);

            }
        }

        public void loadReportPurchaseDirectO()
        {
            try
            {
                OilShopDataSet1 ds = new OilShopDataSet1();

                OilShopDataSet1 ds1 = new OilShopDataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataAdapter da1 = new SqlDataAdapter();

                LocalReport report = new LocalReport();
                report.DataSources.Clear();
                report.ReportPath = Application.StartupPath + @"\Reports\SaleInvoice.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select c.id,c.pdes,c.type,c.Date,c.Billno,c.cname,c.pcode,p.pname,c.price,c.qty,c.Total from tblPurchase as c inner join tblProduct as p on c.pcode = p.pcode where Billno like '" + fps.Billno.Text + "' order by id", cn);
                da.Fill(ds.Tables["tblPurchase"]);

                da1.SelectCommand = new SqlCommand("select * from tblCustomer where cname like '" + fps.cname.Text + "'", cn);
                da1.Fill(ds1.Tables["tblCustomer"]);
                cn.Close();



                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblPurchase"]);
                report.DataSources.Add(rds);


                ReportDataSource rds1 = new ReportDataSource("DataSet2", ds1.Tables["tblCustomer"]);
                report.DataSources.Add(rds1);

                ReportParameter typee = new ReportParameter("typee", "ORIGINAL");
                report.SetParameters(typee);


                PrintToPrinter(report);

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
                cn.Close();
                MessageBox.Show(ex.Message);

            }
        }
        public void loadReportPurchaseDirectD()
        {
            try
            {
                OilShopDataSet1 ds = new OilShopDataSet1();

                OilShopDataSet1 ds1 = new OilShopDataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataAdapter da1 = new SqlDataAdapter();

                LocalReport report = new LocalReport();
                report.DataSources.Clear();
                report.ReportPath = Application.StartupPath + @"\Reports\SaleInvoice.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select c.id,c.pdes,c.type,c.Date,c.Billno,c.cname,c.pcode,p.pname,c.price,c.qty,c.Total from tblPurchase as c inner join tblProduct as p on c.pcode = p.pcode where Billno like '" + fps.Billno.Text + "' order by id", cn);
                da.Fill(ds.Tables["tblPurchase"]);

                da1.SelectCommand = new SqlCommand("select * from tblCustomer where cname like '" + fps.cname.Text + "'", cn);
                da1.Fill(ds1.Tables["tblCustomer"]);
                cn.Close();



                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblPurchase"]);
                report.DataSources.Add(rds);


                ReportDataSource rds1 = new ReportDataSource("DataSet2", ds1.Tables["tblCustomer"]);
                report.DataSources.Add(rds1);

                ReportParameter typee = new ReportParameter("typee", "DUPLICATE");
                report.SetParameters(typee);


                PrintToPrinter(report);

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
                cn.Close();
                MessageBox.Show(ex.Message);

            }
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        public static void PrintToPrinter(LocalReport report)
        {
            Export(report);

        }

        public static void Export(LocalReport report, bool print = true)
        {



            string deviceInfo =
                $@"<DeviceInfo>
                    <OutputFormat>EMF</OutputFormat>
                   <PageWidth>8.5in</PageWidth>
                <PageHeight>11in</PageHeight>
                  <MarginTop>0.2in</MarginTop>
                <MarginLeft>0.2in</MarginLeft>
                <MarginRight>0in</MarginRight>
                <MarginBottom>0.2in</MarginBottom>
                </DeviceInfo>";



            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream, out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;

            if (print)
            {
                Print();
            }
        }


        public static void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }

        public static Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public static void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        public static void DisposePrint()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }

    }
}
