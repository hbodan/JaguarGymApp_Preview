using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace JaguarGymApp_Preview.Formularios
{
    public partial class Configuracion : MaterialForm
    {
        public Configuracion()
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


        private void Configuracion_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_MostrarPasswordConfiguracion_Click(object sender, EventArgs e)
        {

        }

        private void txt_PasswordConfiguracion_TextChanged(object sender, EventArgs e)
        {

        }
        private void MostrarPasswordConfiguracion_MouseDown(object sender, MouseEventArgs e)
        {
            // Mostrar la contraseña
            txt_PasswordConfiguracion.PasswordChar = '\0';
        }

        private void MostrarPasswordConfiguracion_MouseUp(object sender, MouseEventArgs e)
        {
            // Ocultar la contraseña nuevamente
            txt_PasswordConfiguracion.PasswordChar = '*';
        }

        private void regreso_Principal_Click(object sender, EventArgs e)
        {
            Principal nuevoFormulario = new Principal(0);
            this.Hide();
            nuevoFormulario.Show();
        }
    }
}
