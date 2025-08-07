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
    public partial class LedgerReport : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        frmLedger fl;
        public LedgerReport(frmLedger flp)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());

            fl = flp;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LedgerReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

       


        public void loadReportLedger()
        {
            try
            {
                OilShopDataSet2 ds = new OilShopDataSet2();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ledgerReport.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select * from tblLedger where cname like '" + fl.cname.Text + "' and Date between '" + fl.date1.Value + "' and '" + fl.date2.Value + "' order by Date,id", cn);
                da.Fill(ds.Tables["tblLedger"]);


                cn.Close();




                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblLedger"]);
                reportViewer1.LocalReport.DataSources.Add(rds);
                ReportParameter datefrom = new ReportParameter("datefrom", fl.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fl.date2.Value.ToString("dd/MM/yyyy"));
                ReportParameter opnbal = new ReportParameter("opnbal", fl.opnbal.Text);
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(dateto);
                this.reportViewer1.LocalReport.SetParameters(opnbal);
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
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }

        public void loadReportLedgerall()
        {
            try
            {
                OilShopDataSet2 ds = new OilShopDataSet2();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report2.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select * from tblLedger", cn);
                da.Fill(ds.Tables["tblLedger"]);


                cn.Close();




                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblLedger"]);
                reportViewer1.LocalReport.DataSources.Add(rds);
                 ReportParameter datefrom = new ReportParameter("datefrom", fl.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fl.date2.Value.ToString("dd/MM/yyyy"));
                
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
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }
        public void loadReportLedgerCredit()
        {
            try
            {
                OilShopDataSet2 ds = new OilShopDataSet2();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report2.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select * from tblLedger where credit != 0", cn);
                da.Fill(ds.Tables["tblLedger"]);


                cn.Close();




                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblLedger"]);
                reportViewer1.LocalReport.DataSources.Add(rds);
                ReportParameter datefrom = new ReportParameter("datefrom", fl.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fl.date2.Value.ToString("dd/MM/yyyy"));
 
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
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }
        public void loadReportLedgerDEBIT()
        {
            try
            {
                OilShopDataSet2 ds = new OilShopDataSet2();
                SqlDataAdapter da = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Report2.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select * from tblLedger where debit != 0", cn);
                da.Fill(ds.Tables["tblLedger"]);


                cn.Close();




                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblLedger"]);
                reportViewer1.LocalReport.DataSources.Add(rds);
                ReportParameter datefrom = new ReportParameter("datefrom", fl.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter dateto = new ReportParameter("dateto", fl.date2.Value.ToString("dd/MM/yyyy"));
                
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
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
