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
    public partial class Inicio_Sesion : MaterialForm
    {
        public Inicio_Sesion()
        {
            this.Resize += new System.EventHandler(this.Principal_Resize);
            InitializeComponent();
            guna2HtmlLabel3.BackColor = Color.Transparent;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
        }
        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
        }
        private void Inicio_Sesión_Load(object sender, EventArgs e)
        {
            

        }
        private void cxFlatPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
