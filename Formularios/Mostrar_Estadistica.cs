﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static estadisticasForm.LogicaEstadistica;
using MaterialSkin;
using MaterialSkin.Controls;
using JaguarGymApp_Preview;



namespace estadisticasForm
{
    public partial class Mostrar_Estadistica : MaterialForm
    {

        private LogicaEstadistica logicaEstadistica;
        int _idUsuario;

        public Mostrar_Estadistica(int idUsuario)
        {
            InitializeComponent();
            logicaEstadistica = new LogicaEstadistica(); // Instanciamos la clase LogicaEstadistica
            CargarDatos();
            this.Resize += new System.EventHandler(this.Principal_Resize);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            _idUsuario = idUsuario;
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo

        }

        private void CargarDatos()
        {
            // Obtener los gráficos de la lógica
            var ingresosMensuales = logicaEstadistica.ObtenerIngresosPorMes();
            var conceptoPagos = logicaEstadistica.ObtenerDistribucionPorConcepto();
            var membresiasActivasExpiradas = logicaEstadistica.ObtenerMembresiasActivasVencidas();
            var internosExternos = logicaEstadistica.ObtenerMiembrosInternosExternos();
            //var miembrosPorFacultad = logicaEstadistica.ObtenerMiembrosPorFacultad();
            var flujoPorHora = logicaEstadistica.ObtenerEntradasPorHora();
            var flujoPorDia = logicaEstadistica.ObtenerEntradasPorDia();

            // Asignar los gráficos a los controles correspondientes en el formulario
            chart_ingresosMensuales.Series = ingresosMensuales;
            chart_conceptoPagos.Series = conceptoPagos;
            chart_membresiasActivasExpiradas.Series = membresiasActivasExpiradas;
            chart_internosExternos.Series = internosExternos;
            //chart_porFacultad.Series = miembrosPorFacultad;
            chart_flujoPorHora.Series = flujoPorHora;
            chart_flujoPorDia.Series = flujoPorDia;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart_flujoPorHora_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void LinkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Principal formularioPrincipal = new Principal(_idUsuario);
            this.Hide();
            formularioPrincipal.ShowDialog();
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            int cambio = flowLayoutPanel1.VerticalScroll.Value - flowLayoutPanel1.VerticalScroll.SmallChange * 10;
            flowLayoutPanel1.AutoScrollPosition = new Point(0, cambio);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            int cambio = flowLayoutPanel1.VerticalScroll.Value + flowLayoutPanel1.VerticalScroll.SmallChange * 10;
            flowLayoutPanel1.AutoScrollPosition = new Point(0, cambio);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Principal formularioPrincipal = new Principal(_idUsuario);
            this.Hide();
            formularioPrincipal.ShowDialog();
            this.Close();
        }
    }
}

