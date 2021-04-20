namespace Prv.Forms.Reports
{
    partial class FormRepActJournal
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsRep = new Prv.DataSets.DataSetRep();
            this.bsRep = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRep)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bsRep;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Prv.FileReports.ReportRepActJournal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(633, 442);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsRep
            // 
            this.dsRep.DataSetName = "DataSetRep";
            this.dsRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsRep
            // 
            this.bsRep.DataMember = "vPrv_JournalAct";
            this.bsRep.DataSource = this.dsRep;
            // 
            // FormRepActJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 442);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRepActJournal";
            this.Text = "Отчет по журналу актов";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormRepActJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.DataSetRep dsRep;
        private System.Windows.Forms.BindingSource bsRep;
    }
}