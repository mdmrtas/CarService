
namespace CarService
{
    partial class RaporlamaEkranPersonal
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
            this.DbOtoBakimServisDataSet3 = new CarService.DbOtoBakimServisDataSet3();
            this.AracBakımKaydıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AracBakımKaydıTableAdapter = new CarService.DbOtoBakimServisDataSet3TableAdapters.AracBakımKaydıTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DbOtoBakimServisDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AracBakımKaydıBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AracBakımKaydıBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CarService.ReportEkranPersonal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(878, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DbOtoBakimServisDataSet3
            // 
            this.DbOtoBakimServisDataSet3.DataSetName = "DbOtoBakimServisDataSet3";
            this.DbOtoBakimServisDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AracBakımKaydıBindingSource
            // 
            this.AracBakımKaydıBindingSource.DataMember = "AracBakımKaydı";
            this.AracBakımKaydıBindingSource.DataSource = this.DbOtoBakimServisDataSet3;
            // 
            // AracBakımKaydıTableAdapter
            // 
            this.AracBakımKaydıTableAdapter.ClearBeforeFill = true;
            // 
            // RaporlamaEkranPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RaporlamaEkranPersonal";
            this.Text = "RaporlamaEkranPersonal";
            this.Load += new System.EventHandler(this.RaporlamaEkranPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DbOtoBakimServisDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AracBakımKaydıBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AracBakımKaydıBindingSource;
        private DbOtoBakimServisDataSet3 DbOtoBakimServisDataSet3;
        private DbOtoBakimServisDataSet3TableAdapters.AracBakımKaydıTableAdapter AracBakımKaydıTableAdapter;
    }
}