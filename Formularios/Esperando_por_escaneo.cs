using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaguarGymApp_Preview.Formularios
{
    public partial class Esperando_por_escaneo : MaterialForm
    {
        public Esperando_por_escaneo()


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
        private void Esperando_por_escaneo_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}
