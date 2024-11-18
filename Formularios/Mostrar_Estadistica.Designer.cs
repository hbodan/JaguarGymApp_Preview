namespace estadisticasForm
{
    partial class Mostrar_Estadistica
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.chart_ingresosMensuales = new LiveCharts.WinForms.CartesianChart();
            this.chart_conceptoPagos = new LiveCharts.WinForms.PieChart();
            this.lbl_pagos = new System.Windows.Forms.Label();
            this.lbl_miembros = new System.Windows.Forms.Label();
            this.lbl_entradas = new System.Windows.Forms.Label();
            this.chart_porFacultad = new LiveCharts.WinForms.CartesianChart();
            this.chart_flujoPorHora = new LiveCharts.WinForms.CartesianChart();
            this.chart_membresiasActivasExpiradas = new LiveCharts.WinForms.PieChart();
            this.chart_flujoPorDia = new LiveCharts.WinForms.CartesianChart();
            this.chart_internosExternos = new LiveCharts.WinForms.PieChart();
            this.SuspendLayout();
            // 
            // chart_ingresosMensuales
            // 
            this.chart_ingresosMensuales.Location = new System.Drawing.Point(84, 127);
            this.chart_ingresosMensuales.Name = "chart_ingresosMensuales";
            this.chart_ingresosMensuales.Size = new System.Drawing.Size(282, 173);
            this.chart_ingresosMensuales.TabIndex = 0;
            this.chart_ingresosMensuales.Text = "cartesianChart1";
            this.chart_ingresosMensuales.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged);
            // 
            // chart_conceptoPagos
            // 
            this.chart_conceptoPagos.Location = new System.Drawing.Point(136, 339);
            this.chart_conceptoPagos.Name = "chart_conceptoPagos";
            this.chart_conceptoPagos.Size = new System.Drawing.Size(200, 100);
            this.chart_conceptoPagos.TabIndex = 1;
            this.chart_conceptoPagos.Text = "pieChart1";
            // 
            // lbl_pagos
            // 
            this.lbl_pagos.AutoSize = true;
            this.lbl_pagos.Location = new System.Drawing.Point(206, 102);
            this.lbl_pagos.Name = "lbl_pagos";
            this.lbl_pagos.Size = new System.Drawing.Size(37, 13);
            this.lbl_pagos.TabIndex = 2;
            this.lbl_pagos.Text = "Pagos";
            this.lbl_pagos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_miembros
            // 
            this.lbl_miembros.AutoSize = true;
            this.lbl_miembros.Location = new System.Drawing.Point(519, 102);
            this.lbl_miembros.Name = "lbl_miembros";
            this.lbl_miembros.Size = new System.Drawing.Size(52, 13);
            this.lbl_miembros.TabIndex = 3;
            this.lbl_miembros.Text = "Miembros";
            // 
            // lbl_entradas
            // 
            this.lbl_entradas.AutoSize = true;
            this.lbl_entradas.Location = new System.Drawing.Point(839, 102);
            this.lbl_entradas.Name = "lbl_entradas";
            this.lbl_entradas.Size = new System.Drawing.Size(49, 13);
            this.lbl_entradas.TabIndex = 4;
            this.lbl_entradas.Text = "Entradas";
            // 
            // chart_porFacultad
            // 
            this.chart_porFacultad.Location = new System.Drawing.Point(400, 508);
            this.chart_porFacultad.Name = "chart_porFacultad";
            this.chart_porFacultad.Size = new System.Drawing.Size(282, 173);
            this.chart_porFacultad.TabIndex = 5;
            this.chart_porFacultad.Text = "cartesianChart1";
            // 
            // chart_flujoPorHora
            // 
            this.chart_flujoPorHora.Location = new System.Drawing.Point(717, 127);
            this.chart_flujoPorHora.Name = "chart_flujoPorHora";
            this.chart_flujoPorHora.Size = new System.Drawing.Size(282, 173);
            this.chart_flujoPorHora.TabIndex = 7;
            this.chart_flujoPorHora.Text = "cartesianChart1";
            this.chart_flujoPorHora.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.chart_flujoPorHora_ChildChanged);
            // 
            // chart_membresiasActivasExpiradas
            // 
            this.chart_membresiasActivasExpiradas.Location = new System.Drawing.Point(442, 152);
            this.chart_membresiasActivasExpiradas.Name = "chart_membresiasActivasExpiradas";
            this.chart_membresiasActivasExpiradas.Size = new System.Drawing.Size(200, 100);
            this.chart_membresiasActivasExpiradas.TabIndex = 8;
            this.chart_membresiasActivasExpiradas.Text = "pieChart1";
            // 
            // chart_flujoPorDia
            // 
            this.chart_flujoPorDia.Location = new System.Drawing.Point(717, 309);
            this.chart_flujoPorDia.Name = "chart_flujoPorDia";
            this.chart_flujoPorDia.Size = new System.Drawing.Size(282, 173);
            this.chart_flujoPorDia.TabIndex = 9;
            this.chart_flujoPorDia.Text = "cartesianChart1";
            // 
            // chart_internosExternos
            // 
            this.chart_internosExternos.Location = new System.Drawing.Point(442, 339);
            this.chart_internosExternos.Name = "chart_internosExternos";
            this.chart_internosExternos.Size = new System.Drawing.Size(200, 100);
            this.chart_internosExternos.TabIndex = 10;
            this.chart_internosExternos.Text = "pieChart1";
            // 
            // Mostrar_Estadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.chart_internosExternos);
            this.Controls.Add(this.chart_flujoPorDia);
            this.Controls.Add(this.chart_membresiasActivasExpiradas);
            this.Controls.Add(this.chart_flujoPorHora);
            this.Controls.Add(this.chart_porFacultad);
            this.Controls.Add(this.lbl_entradas);
            this.Controls.Add(this.lbl_miembros);
            this.Controls.Add(this.lbl_pagos);
            this.Controls.Add(this.chart_conceptoPagos);
            this.Controls.Add(this.chart_ingresosMensuales);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "Mostrar_Estadistica";
            this.Text = "Mostrar Estadísticas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chart_ingresosMensuales;
        private LiveCharts.WinForms.PieChart chart_conceptoPagos;
        private System.Windows.Forms.Label lbl_pagos;
        private System.Windows.Forms.Label lbl_miembros;
        private System.Windows.Forms.Label lbl_entradas;
        private LiveCharts.WinForms.CartesianChart chart_porFacultad;
        private LiveCharts.WinForms.CartesianChart chart_flujoPorHora;
        private LiveCharts.WinForms.PieChart chart_membresiasActivasExpiradas;
        private LiveCharts.WinForms.CartesianChart chart_flujoPorDia;
        private LiveCharts.WinForms.PieChart chart_internosExternos;
    }
}