using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using estadisticasForm;
using Guna.UI2.WinForms;
using JaguarGymApp_Preview.Formularios;
using MaterialSkin;
using MaterialSkin.Controls;

namespace JaguarGymApp_Preview
{
    public partial class Principal : MaterialForm
    {
        public Principal()
        {
            this.Resize += new System.EventHandler(this.Principal_Resize);
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Configuracion iniciarFormulario = new Configuracion();
            iniciarFormulario.Show();
            this.Hide();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void imgBtn_Pagos_Click(object sender, EventArgs e)
        {
            Gestion_Pagos formularioPagos = new Gestion_Pagos();
            formularioPagos.Show();
            this.Hide();
        }

        private void imgBtn_Miembros_Click(object sender, EventArgs e)
        {
            Miembros formularioMiembros = new Miembros(); // Cambia a tu formulario
            this.Hide();
            formularioMiembros.Show();
        }
        private void btn_Miembros_Click(object sender, EventArgs e)
        {
            Miembros formularioMiembros = new Miembros(); // Cambia a tu formulario
            this.Hide();
            formularioMiembros.Show();
        }
        private void imgBtn_Estadistica_Click(object sender, EventArgs e)
        {
            Mostrar_Estadistica formularioEstadistica = new Mostrar_Estadistica();
            formularioEstadistica.Show();
            this.Close();
        }
        private void btn_Estadistica_Click(object sender, EventArgs e)
        {
            Mostrar_Estadistica formularioEstadistica = new Mostrar_Estadistica();
            formularioEstadistica.Show();
            this.Close();
        }
        private void imgBtn_Escanear_Click(object sender, EventArgs e)
        {
            Escanea_tu_cedula_o_CIF nuevoFormulario = new Escanea_tu_cedula_o_CIF(); // Cambia a tu formulario
            this.Hide();
            nuevoFormulario.Show();
        }
        private void btn_Pagos_Click(object sender, EventArgs e)
        {
            Gestion_Pagos formularioPagos = new Gestion_Pagos();
            formularioPagos.Show();
            this.Hide();
        }
    }
}
