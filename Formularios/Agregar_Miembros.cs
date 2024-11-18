using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using JaguarGymApp_Preview.Estructuras;
using Guna.UI2.WinForms.Enums;
using JaguarGymApp_Preview.Formularios;
using System.Web;

namespace JaguarGymApp_Preview.Formularios
{
    public partial class Agregar_Miembros : MaterialForm
    {
        List<Usuario> miembrosRecibidos;
        private Miembros formularioAnterior;
        
        public Agregar_Miembros(List<Usuario> lista,Miembros formulario)
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Principal_Resize);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.miembrosRecibidos = lista;
            this.formularioAnterior = formulario;
        }
        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
        }

        private void Agregar_Miembros_Load(object sender, EventArgs e)
        {

        }
        private void AgregarMiembro()
        {
            int NuevoId = int.Parse(txtId.Text);
            string NuevoNombre = txtNombre.Text;
            string NuevaCarrera = txtCarrera.Text;
            miembrosRecibidos.Add(new Usuario(NuevoId, NuevoNombre, NuevaCarrera));
        }

        private void LinkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formularioAnterior.RecibirDatos(miembrosRecibidos);
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarMiembro();
            formularioAnterior.RecibirDatos(miembrosRecibidos);
            this.Close();
        }
    }
}
