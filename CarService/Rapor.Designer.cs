
namespace CarService
{
    partial class Rapor
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
            this.PersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DbOtoBakimServisDataSet2 = new CarService.DbOtoBakimServisDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DbOtoBakimServisDataSet = new CarService.DbOtoBakimServisDataSet();
            this.LoglarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoglarTableAdapter = new CarService.DbOtoBakimServisDataSetTableAdapters.LoglarTableAdapter();
            this.PersonelTableAdapter = new CarService.DbOtoBakimServisDataSet2TableAdapters.PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbOtoBakimServisDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbOtoBakimServisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoglarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonelBindingSource
            // 
            this.PersonelBindingSource.DataMember = "Personel";
            this.PersonelBindingSource.DataSource = this.DbOtoBakimServisDataSet2;
            // 
            // DbOtoBakimServisDataSet2
            // 
            this.DbOtoBakimServisDataSet2.DataSetName = "DbOtoBakimServisDataSet2";
            this.DbOtoBakimServisDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PersonelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CarService.ReportBilgiPersonal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1067, 475);
            this.reportViewer1.TabIndex = 0;
            // 
            // DbOtoBakimServisDataSet
            // 
            this.DbOtoBakimServisDataSet.DataSetName = "DbOtoBakimServisDataSet";
            this.DbOtoBakimServisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LoglarBindingSource
            // 
            this.LoglarBindingSource.DataMember = "Loglar";
            this.LoglarBindingSource.DataSource = this.DbOtoBakimServisDataSet;
            // 
            // LoglarTableAdapter
            // 
            this.LoglarTableAdapter.ClearBeforeFill = true;
            // 
            // PersonelTableAdapter
            // 
            this.PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 475);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbOtoBakimServisDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbOtoBakimServisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoglarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LoglarBindingSource;
        private DbOtoBakimServisDataSet DbOtoBakimServisDataSet;
        private DbOtoBakimServisDataSetTableAdapters.LoglarTableAdapter LoglarTableAdapter;
        private System.Windows.Forms.BindingSource PersonelBindingSource;
        private DbOtoBakimServisDataSet2 DbOtoBakimServisDataSet2;
        private DbOtoBakimServisDataSet2TableAdapters.PersonelTableAdapter PersonelTableAdapter;
    }
}