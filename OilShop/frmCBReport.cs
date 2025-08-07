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
    public partial class frmCBReport : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBconnection dbcon = new DBconnection();
        SqlDataReader dr;
        frmCashBook fp;
        public frmCBReport(frmCashBook fr)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            fp = fr;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadReportCashBook()
        {
            try
            {
                OilShopDataSet3 ds = new OilShopDataSet3();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlDataAdapter da1 = new SqlDataAdapter();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\CashBookReport.rdlc";

                cn.Open();
                da.SelectCommand = new SqlCommand("select * from tblRecipt where Date = '" + fp.date1.Value + "' order by Date,id", cn);
                da.Fill(ds.Tables["tblRecipt"]);
                cn.Close();

                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables["tblRecipt"]);
                reportViewer1.LocalReport.DataSources.Add(rds);

                cn.Open();
                da1.SelectCommand = new SqlCommand("select * from tblPayment where Date = '" + fp.date1.Value + "' order by Date,id", cn);
                da1.Fill(ds.Tables["tblPayment"]);
                cn.Close();



                ReportDataSource rds1 = new ReportDataSource("DataSet2", ds.Tables["tblPayment"]);
                reportViewer1.LocalReport.DataSources.Add(rds1);

                ReportParameter datefrom = new ReportParameter("datefrom", fp.date1.Value.ToString("dd/MM/yyyy"));
                ReportParameter opnbal = new ReportParameter("opnbal", fp.Balance.Text);
                ReportParameter recovery = new ReportParameter("recovery", fp.recovery.Text);
                ReportParameter netbal = new ReportParameter("netbal", fp.Netbalance.Text);
                ReportParameter recovery1 = new ReportParameter("recovery1", fp.rec1.Text);
                ReportParameter netbal1 = new ReportParameter("netbal1", fp.netbal.Text);
                ReportParameter cih = new ReportParameter("cih", fp.cashinhand.Text);
                this.reportViewer1.LocalReport.SetParameters(datefrom);
                this.reportViewer1.LocalReport.SetParameters(opnbal);
                this.reportViewer1.LocalReport.SetParameters(recovery);
                this.reportViewer1.LocalReport.SetParameters(netbal);
                this.reportViewer1.LocalReport.SetParameters(recovery1);
                this.reportViewer1.LocalReport.SetParameters(netbal1);
                this.reportViewer1.LocalReport.SetParameters(cih);
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
