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
    public partial class Usuario_autorizado_usuario : MaterialForm
    {
        public Usuario_autorizado_usuario()
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

        private void Usuario_autorizado_usuario_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Usuario_con_membresia_vencida_gerente formularioUsuarioMembresiaVencidaGerente = new Usuario_con_membresia_vencida_gerente();
            formularioUsuarioMembresiaVencidaGerente.Show();
            this.Close();
        }
    }
}
