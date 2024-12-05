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
            this.lbl_pagos = new System.Windows.Forms.Label();
            this.lbl_miembros = new System.Windows.Forms.Label();
            this.lbl_entradas = new System.Windows.Forms.Label();
            this.chart_porFacultad = new LiveCharts.WinForms.CartesianChart();
            this.chart_flujoPorHora = new LiveCharts.WinForms.CartesianChart();
            this.chart_membresiasActivasExpiradas = new LiveCharts.WinForms.PieChart();
            this.chart_flujoPorDia = new LiveCharts.WinForms.CartesianChart();
            this.chart_internosExternos = new LiveCharts.WinForms.PieChart();
            this.LinkAtras = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_ingresosMensuales = new LiveCharts.WinForms.CartesianChart();
            this.chart_conceptoPagos = new LiveCharts.WinForms.PieChart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pagos
            // 
            this.lbl_pagos.AutoSize = true;
            this.lbl_pagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_pagos.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagos.ForeColor = System.Drawing.Color.Snow;
            this.lbl_pagos.Location = new System.Drawing.Point(143, 102);
            this.lbl_pagos.Name = "lbl_pagos";
            this.lbl_pagos.Size = new System.Drawing.Size(83, 29);
            this.lbl_pagos.TabIndex = 2;
            this.lbl_pagos.Text = "Pagos";
            this.lbl_pagos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_miembros
            // 
            this.lbl_miembros.AutoSize = true;
            this.lbl_miembros.Location = new System.Drawing.Point(624, 163);
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
            this.chart_porFacultad.Location = new System.Drawing.Point(22, 360);
            this.chart_porFacultad.Name = "chart_porFacultad";
            this.chart_porFacultad.Size = new System.Drawing.Size(250, 180);
            this.chart_porFacultad.TabIndex = 5;
            this.chart_porFacultad.Text = "cartesianChart1";
            // 
            // chart_flujoPorHora
            // 
            this.chart_flujoPorHora.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.chart_flujoPorHora.Location = new System.Drawing.Point(18, 360);
            this.chart_flujoPorHora.Name = "chart_flujoPorHora";
            this.chart_flujoPorHora.Size = new System.Drawing.Size(250, 180);
            this.chart_flujoPorHora.TabIndex = 7;
            this.chart_flujoPorHora.Text = "cartesianChart1";
            this.chart_flujoPorHora.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.chart_flujoPorHora_ChildChanged);
            // 
            // chart_membresiasActivasExpiradas
            // 
            this.chart_membresiasActivasExpiradas.Location = new System.Drawing.Point(22, 80);
            this.chart_membresiasActivasExpiradas.Name = "chart_membresiasActivasExpiradas";
            this.chart_membresiasActivasExpiradas.Size = new System.Drawing.Size(250, 180);
            this.chart_membresiasActivasExpiradas.TabIndex = 8;
            this.chart_membresiasActivasExpiradas.Text = "pieChart1";
            // 
            // chart_flujoPorDia
            // 
            this.chart_flujoPorDia.Location = new System.Drawing.Point(15, 80);
            this.chart_flujoPorDia.Name = "chart_flujoPorDia";
            this.chart_flujoPorDia.Size = new System.Drawing.Size(250, 180);
            this.chart_flujoPorDia.TabIndex = 9;
            this.chart_flujoPorDia.Text = "cartesianChart1";
            // 
            // chart_internosExternos
            // 
            this.chart_internosExternos.Location = new System.Drawing.Point(22, 603);
            this.chart_internosExternos.Name = "chart_internosExternos";
            this.chart_internosExternos.Size = new System.Drawing.Size(250, 180);
            this.chart_internosExternos.TabIndex = 10;
            this.chart_internosExternos.Text = "pieChart1";
            // 
            // LinkAtras
            // 
            this.LinkAtras.AutoSize = true;
            this.LinkAtras.LinkColor = System.Drawing.Color.Silver;
            this.LinkAtras.Location = new System.Drawing.Point(30, 693);
            this.LinkAtras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LinkAtras.Name = "LinkAtras";
            this.LinkAtras.Size = new System.Drawing.Size(93, 13);
            this.LinkAtras.TabIndex = 11;
            this.LinkAtras.TabStop = true;
            this.LinkAtras.Text = "Volver hacia Atras";
            this.LinkAtras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkAtras_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialButton2);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(943, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 653);
            this.panel1.TabIndex = 14;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(0, 475);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(134, 178);
            this.materialButton2.TabIndex = 1;
            this.materialButton2.Text = "bajar";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialButton1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(0, 0);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(134, 169);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "subir";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(940, 653);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.chart_ingresosMensuales);
            this.panel3.Controls.Add(this.chart_conceptoPagos);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 850);
            this.panel3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(52, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresos mensuales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(52, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pagos por concepto";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // chart_ingresosMensuales
            // 
            this.chart_ingresosMensuales.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_ingresosMensuales.Location = new System.Drawing.Point(16, 360);
            this.chart_ingresosMensuales.Name = "chart_ingresosMensuales";
            this.chart_ingresosMensuales.Size = new System.Drawing.Size(250, 180);
            this.chart_ingresosMensuales.TabIndex = 0;
            this.chart_ingresosMensuales.Text = "cartesianChart1";
            this.chart_ingresosMensuales.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged);
            // 
            // chart_conceptoPagos
            // 
            this.chart_conceptoPagos.Location = new System.Drawing.Point(16, 80);
            this.chart_conceptoPagos.Name = "chart_conceptoPagos";
            this.chart_conceptoPagos.Size = new System.Drawing.Size(250, 180);
            this.chart_conceptoPagos.TabIndex = 1;
            this.chart_conceptoPagos.Text = "pieChart1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.chart_flujoPorHora);
            this.panel2.Controls.Add(this.chart_flujoPorDia);
            this.panel2.Location = new System.Drawing.Point(309, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 850);
            this.panel2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(68, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Entradas por hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(68, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Entradas por día";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.chart_internosExternos);
            this.panel4.Controls.Add(this.chart_porFacultad);
            this.panel4.Controls.Add(this.chart_membresiasActivasExpiradas);
            this.panel4.Location = new System.Drawing.Point(615, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 850);
            this.panel4.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(58, 582);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Internos y externos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(39, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estudiantes por facultad";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(39, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vigencia de membresías";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::JaguarGymApp_Preview.Properties.Resources.Salida;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1034, 25);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(40, 33);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // Mostrar_Estadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LinkAtras);
            this.Controls.Add(this.lbl_entradas);
            this.Controls.Add(this.lbl_miembros);
            this.Controls.Add(this.lbl_pagos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 718);
            this.Name = "Mostrar_Estadistica";
            this.Text = "Mostrar Estadísticas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_pagos;
        private System.Windows.Forms.Label lbl_miembros;
        private System.Windows.Forms.Label lbl_entradas;
        private LiveCharts.WinForms.CartesianChart chart_porFacultad;
        private LiveCharts.WinForms.CartesianChart chart_flujoPorHora;
        private LiveCharts.WinForms.PieChart chart_membresiasActivasExpiradas;
        private LiveCharts.WinForms.CartesianChart chart_flujoPorDia;
        private LiveCharts.WinForms.PieChart chart_internosExternos;
        private System.Windows.Forms.LinkLabel LinkAtras;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private LiveCharts.WinForms.CartesianChart chart_ingresosMensuales;
        private LiveCharts.WinForms.PieChart chart_conceptoPagos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}