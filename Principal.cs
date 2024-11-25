using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using estadisticasForm;
using Guna.UI2.WinForms;
using JaguarGymApp_Preview.Formularios;
using JaguarGymApp_Preview.Servicios;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace JaguarGymApp_Preview
{
    public partial class Principal : MaterialForm
    {
        private MySqlConnection data;

        private int _idUsuario;
        public Principal(int idUsuario)
        {
            ConexionBD conn = new ConexionBD();
            data = new MySqlConnection(conn.GetConnector());
            this.Resize += new System.EventHandler(this.Principal_Resize);
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            _idUsuario = idUsuario;
    }
        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            txtNombre.Text = $"Bienvenido de nuevo, {ObtenerPrimerNombrePorId(_idUsuario)}";
            txtIngreso.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Inicio_Sesion iniciarFormulario = new Inicio_Sesion();
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

        private string ObtenerPrimerNombrePorId(int idUsuario)
        {
            string nombreCompleto = string.Empty;

            // Consulta SQL para obtener el nombre completo según el idMiembro.
            string query = "SELECT nombreUsuario FROM usuario WHERE idUsuario = @idUsuario";

            try
            {
                // Preparar el comando.
                MySqlCommand command = new MySqlCommand(query, data);

                // Pasar el parámetro idMiembro.
                command.Parameters.AddWithValue("@idUsuario", idUsuario);

                // Abrir la conexión.
                data.Open();

                // Ejecutar la consulta.
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    // Convertir el resultado a string.
                    nombreCompleto = result.ToString();

                    // Tomar solo la primera palabra del nombre completo.
                    string primerNombre = nombreCompleto.Split(' ')[0];
                    return primerNombre;
                }
                else
                {
                    MessageBox.Show("No se encontró un usuario con ese ID.");
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores.
                MessageBox.Show("Error al buscar el nombre: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión.
                if (data.State == ConnectionState.Open)
                {
                    data.Close();
                }
            }

            return string.Empty;
        }
    }
}
