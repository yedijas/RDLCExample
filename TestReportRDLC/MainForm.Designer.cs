namespace TestReportRDLC
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGeneratePDF = new System.Windows.Forms.Button();
            this.DataSetMain = new TestReportRDLC.DataSet1();
            this.MainReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BtnFormReport = new System.Windows.Forms.Button();
            this.BtnSummaryReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.Location = new System.Drawing.Point(13, 13);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(75, 23);
            this.btnGeneratePDF.TabIndex = 0;
            this.btnGeneratePDF.Text = "Generate PDF";
            this.btnGeneratePDF.UseVisualStyleBackColor = true;
            this.btnGeneratePDF.Click += new System.EventHandler(this.btnGeneratePDF_Click);
            // 
            // DataSetMain
            // 
            this.DataSetMain.DataSetName = "DataSetMain";
            this.DataSetMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainReportViewer
            // 
            this.MainReportViewer.AutoSize = true;
            this.MainReportViewer.LocalReport.ReportEmbeddedResource = "TestReportRDLC.Reports.FormReport.rdlc";
            this.MainReportViewer.Location = new System.Drawing.Point(13, 43);
            this.MainReportViewer.Name = "MainReportViewer";
            this.MainReportViewer.ServerReport.BearerToken = null;
            this.MainReportViewer.Size = new System.Drawing.Size(1227, 773);
            this.MainReportViewer.TabIndex = 1;
            // 
            // BtnFormReport
            // 
            this.BtnFormReport.Location = new System.Drawing.Point(95, 13);
            this.BtnFormReport.Name = "BtnFormReport";
            this.BtnFormReport.Size = new System.Drawing.Size(75, 23);
            this.BtnFormReport.TabIndex = 2;
            this.BtnFormReport.Text = "Form Report";
            this.BtnFormReport.UseVisualStyleBackColor = true;
            this.BtnFormReport.Click += new System.EventHandler(this.BtnFormReport_Click);
            // 
            // BtnSummaryReport
            // 
            this.BtnSummaryReport.Location = new System.Drawing.Point(176, 13);
            this.BtnSummaryReport.Name = "BtnSummaryReport";
            this.BtnSummaryReport.Size = new System.Drawing.Size(113, 23);
            this.BtnSummaryReport.TabIndex = 3;
            this.BtnSummaryReport.Text = "Summary Report";
            this.BtnSummaryReport.UseVisualStyleBackColor = true;
            this.BtnSummaryReport.Click += new System.EventHandler(this.BtnSummaryReport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 828);
            this.Controls.Add(this.BtnSummaryReport);
            this.Controls.Add(this.BtnFormReport);
            this.Controls.Add(this.MainReportViewer);
            this.Controls.Add(this.btnGeneratePDF);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneratePDF;
        private DataSet1 DataSetMain;
        private Microsoft.Reporting.WinForms.ReportViewer MainReportViewer;
        private System.Windows.Forms.Button BtnFormReport;
        private System.Windows.Forms.Button BtnSummaryReport;
    }
}

