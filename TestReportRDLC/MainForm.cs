using Microsoft.Reporting.WinForms;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace TestReportRDLC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = this.MainReportViewer.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);

            using (FileStream fs = new FileStream("output.pdf", FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }

        private DataSet LoadData()
        {
            string _connstr = ConfigurationManager.ConnectionStrings[1].ToString();
            string _cmdStr = "select * From sales.orders with(nolock)";
            using (SqlConnection conn = new SqlConnection(_connstr))
            {
                using (SqlCommand comm = new SqlCommand(_cmdStr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        comm.Connection = conn;
                        sda.SelectCommand = comm;
                        if (comm.Connection.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds, "orders");
                            return ds;
                        }
                        if (comm.Connection.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataSet reportDS = LoadData();
            ReportDataSource datasource = new ReportDataSource("ConnectionDataSet", reportDS.Tables[0]);
            this.MainReportViewer.LocalReport.DataSources.Clear();
            this.MainReportViewer.LocalReport.DataSources.Add(datasource);
            this.MainReportViewer.RefreshReport();
        }

        private void BtnFormReport_Click(object sender, EventArgs e)
        {
            DataSet reportDS = LoadData();
            this.MainReportViewer.LocalReport.ReportPath = @"Reports\FormReport.rdlc";
            ReportDataSource datasource = new ReportDataSource("ConnectionDataSet", reportDS.Tables[0]);
            this.MainReportViewer.LocalReport.DataSources.Clear();
            this.MainReportViewer.LocalReport.DataSources.Add(datasource);
            this.MainReportViewer.RefreshReport();
        }

        private void BtnSummaryReport_Click(object sender, EventArgs e)
        {
            DataSet reportDS = LoadData();
            this.MainReportViewer.LocalReport.ReportPath = @"Reports\SummaryReport.rdlc";
            ReportDataSource datasource = new ReportDataSource("ConnectionDataSet", reportDS.Tables[0]);
            this.MainReportViewer.LocalReport.DataSources.Clear();
            this.MainReportViewer.LocalReport.DataSources.Add(datasource);
            this.MainReportViewer.RefreshReport();
        }
    }
}
