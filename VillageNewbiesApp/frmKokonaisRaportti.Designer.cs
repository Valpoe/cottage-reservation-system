namespace VillageNewbiesApp
{
    partial class frmKokonaisRaportti
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.alueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new VillageNewbiesApp.DataSet1();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laskuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alueTableAdapter1 = new VillageNewbiesApp.DataSet1TableAdapters.alueTableAdapter();
            this.mokkiTableAdapter1 = new VillageNewbiesApp.DataSet1TableAdapters.mokkiTableAdapter();
            this.palveluTableAdapter1 = new VillageNewbiesApp.DataSet1TableAdapters.palveluTableAdapter();
            this.varausTableAdapter1 = new VillageNewbiesApp.DataSet1TableAdapters.varausTableAdapter();
            this.laskuTableAdapter1 = new VillageNewbiesApp.DataSet1TableAdapters.laskuTableAdapter();
            this.asiakasTableAdapter1 = new VillageNewbiesApp.DataSet1TableAdapters.asiakasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.alueBindingSource;
            reportDataSource2.Name = "mokit";
            reportDataSource2.Value = this.mokkiBindingSource;
            reportDataSource3.Name = "palvelut";
            reportDataSource3.Value = this.palveluBindingSource;
            reportDataSource4.Name = "varaukset";
            reportDataSource4.Value = this.varausBindingSource;
            reportDataSource5.Name = "laskut";
            reportDataSource5.Value = this.laskuBindingSource;
            reportDataSource6.Name = "asiakkaat";
            reportDataSource6.Value = this.asiakasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VillageNewbiesApp.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(661, 609);
            this.reportViewer1.TabIndex = 2;
            // 
            // alueBindingSource
            // 
            this.alueBindingSource.DataMember = "alue";
            this.alueBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.dataSet1;
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataMember = "palvelu";
            this.palveluBindingSource.DataSource = this.dataSet1;
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.dataSet1;
            // 
            // laskuBindingSource
            // 
            this.laskuBindingSource.DataMember = "lasku";
            this.laskuBindingSource.DataSource = this.dataSet1;
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.dataSet1;
            // 
            // alueTableAdapter1
            // 
            this.alueTableAdapter1.ClearBeforeFill = true;
            // 
            // mokkiTableAdapter1
            // 
            this.mokkiTableAdapter1.ClearBeforeFill = true;
            // 
            // palveluTableAdapter1
            // 
            this.palveluTableAdapter1.ClearBeforeFill = true;
            // 
            // varausTableAdapter1
            // 
            this.varausTableAdapter1.ClearBeforeFill = true;
            // 
            // laskuTableAdapter1
            // 
            this.laskuTableAdapter1.ClearBeforeFill = true;
            // 
            // asiakasTableAdapter1
            // 
            this.asiakasTableAdapter1.ClearBeforeFill = true;
            // 
            // frmKokonaisRaportti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 609);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmKokonaisRaportti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKokonaisRaportti";
            this.Load += new System.EventHandler(this.frmKokonaisRaportti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource alueBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private System.Windows.Forms.BindingSource laskuBindingSource;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private DataSet1TableAdapters.alueTableAdapter alueTableAdapter1;
        private DataSet1TableAdapters.mokkiTableAdapter mokkiTableAdapter1;
        private DataSet1TableAdapters.palveluTableAdapter palveluTableAdapter1;
        private DataSet1TableAdapters.varausTableAdapter varausTableAdapter1;
        private DataSet1TableAdapters.laskuTableAdapter laskuTableAdapter1;
        private DataSet1TableAdapters.asiakasTableAdapter asiakasTableAdapter1;
    }
}