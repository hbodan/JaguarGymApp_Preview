namespace JaguarGymApp_Preview.FormulariosReportes
{
    partial class FrmReporteEntrada
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
            this.dsPagos = new JaguarGymApp_Preview.DataSet.dsPagos();
            this.dsPagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPagosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dsPagosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JaguarGymApp_Preview.Reportes.rptPagos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1074, 653);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsPagos
            // 
            this.dsPagos.DataSetName = "dsPagos";
            this.dsPagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsPagosBindingSource
            // 
            this.dsPagosBindingSource.DataSource = this.dsPagos;
            this.dsPagosBindingSource.Position = 0;
            // 
            // FrmReporteEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1080, 718);
            this.Name = "FrmReporteEntrada";
            this.Load += new System.EventHandler(this.FrmReporteEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPagosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsPagosBindingSource;
        private DataSet.dsPagos dsPagos;
    }
}