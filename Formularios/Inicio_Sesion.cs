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
using System.Drawing.Drawing2D;
namespace JaguarGymApp_Preview.Formularios
{
    public partial class Inicio_Sesion : MaterialForm
    {
        public Inicio_Sesion()
        {
            this.Resize += new System.EventHandler(this.Principal_Resize);
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            guna2GradientButton1.BorderRadius = 20;
            guna2GradientButton1.BorderRadius = 20;
            
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

        private void cxFlatGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cxFlatGroupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void cxFlatTextBox1_Click(object sender, EventArgs e)
        {

        }
        private void MakeButtonRounded(Button button)
        {
            int cornerRadius = 20; // Radio de las esquinas redondeadas
            GraphicsPath path = new GraphicsPath();

            // Crear un rectángulo redondeado
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Esquina superior izquierda
            path.AddArc(button.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Esquina superior derecha
            path.AddArc(button.Width - cornerRadius, button.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Esquina inferior derecha
            path.AddArc(0, button.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            // Asignar la región redondeada al botón
            button.Region = new Region(path);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        private void linkLb_CrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Crear_Cuenta nuevoFormulario = new Crear_Cuenta(); // Cambia a tu formulario
            this.Hide();
            nuevoFormulario.Show();
        }
    }
}
