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
using JaguarGymApp_Preview.Servicios;
using MySql.Data.MySqlClient;

namespace JaguarGymApp_Preview.Formularios

{
    public partial class Inicio_Sesion : MaterialForm
    {
        private MySqlConnection data;

        public Inicio_Sesion()
        {
            ConexionBD conn = new ConexionBD();
            data = new MySqlConnection(conn.GetConnector());
            this.Resize += new System.EventHandler(this.Principal_Resize);
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720);
        }
        private void Inicio_Sesión_Load(object sender, EventArgs e)
        {


        }

        private void RevisarCredenciales()
        {
            string correoIngresado = txtbox_IngresarUsuario.Text;
            string claveIngresada = txtBox_IngresarPassword.Text;

            string query = "SELECT idUsuario FROM Usuario WHERE correoElectronico = @usuario AND clave = @contrasena LIMIT 1";

            try
            {
                MySqlCommand command = new MySqlCommand(query, data);

                command.Parameters.AddWithValue("@usuario", correoIngresado);
                command.Parameters.AddWithValue("@contrasena", claveIngresada);

                data.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    int idMiembro = Convert.ToInt32(result);

                    Principal nuevoFormulario = new Principal(idMiembro);
                    nuevoFormulario.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
            finally
            {
                if (data.State == ConnectionState.Open)
                {
                    data.Close();
                }
            }
        }

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            RevisarCredenciales();
        }

        private void linkLb_CrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Crear_Cuenta nuevoFormulario = new Crear_Cuenta(); // Cambia a tu formulario
            this.Hide();
            nuevoFormulario.Show();
        }
        private void linkLb_RecuperarCredenciales_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperar_Credenciales formularioRecuperar = new Recuperar_Credenciales();
            this.Hide();
            formularioRecuperar.Show();
        }

        private void imgbtn_Escaner_Click(object sender, EventArgs e)
        {
            Escanea_tu_cedula_o_CIF nuevoFormulario = new Escanea_tu_cedula_o_CIF(); // Cambia a tu formulario
            this.Hide();
            nuevoFormulario.Show();
        }

        private void btn_MostrarPassword_MouseDown(object sender, MouseEventArgs e)
        {
            // Mostrar la contraseña
            txtBox_IngresarPassword.PasswordChar = '\0';
        }

        private void btn_MostrarPassword_MouseUp(object sender, MouseEventArgs e)
        {
            // Ocultar la contraseña nuevamente
            txtBox_IngresarPassword.PasswordChar = '*';
        }

        private void txtbox_IngresarUsuario_TextChanged(object sender, EventArgs e)
        {
            string usuario = txtbox_IngresarUsuario.Text ;
        }
        private void txtbox_IngresarUsuario_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtbox_IngresarUsuario.Text))
            {
                errorProvider1.SetError(txtbox_IngresarUsuario, "El campo de usuario no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(txtbox_IngresarUsuario, string.Empty); // Limpia el error.
            }
        }


        private void txtBox_IngresarPassword_TextChanged(object sender, EventArgs e)
        {
            string contraseña = txtBox_IngresarPassword.Text;
        }
        private void txtBox_IngresarPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_IngresarPassword.Text))
            {
                errorProvider1.SetError(txtBox_IngresarPassword, "El campo de contraseña no puede estar vacío.");
                
            }
            else
            {
                errorProvider1.SetError(txtBox_IngresarPassword, string.Empty); // Limpia el error.
            }
        }
    }
}