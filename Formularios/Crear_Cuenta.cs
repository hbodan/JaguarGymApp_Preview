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
using JaguarGymApp_Preview.Servicios;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace JaguarGymApp_Preview.Formularios
{
    public partial class Crear_Cuenta : MaterialForm
    {
        private MySqlConnection data;
        public Crear_Cuenta()
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
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
        }

        private void Crear_Cuenta_Load(object sender, EventArgs e)
        {

        }

        private void AgregarUsuario()
        {
            string nombreUsuario = txtRegistroNombreCompleto.Text;
            string correo = txtRegistroEmail.Text;  // Campo de Correo
            string clave = txtPassword2.Text;  // Campo de Contraseña

            string query = "INSERT INTO usuario (nombreUsuario, correoElectronico, clave) VALUES (@nombre, @correo, @clave)";

            try
            {
                // Establecemos la conexión
                ConexionBD conn = new ConexionBD();
                MySqlConnection data = new MySqlConnection(conn.GetConnector());

                // Creamos la consulta con parámetros
                MySqlCommand command = new MySqlCommand(query, data);
                command.Parameters.AddWithValue("@nombre", nombreUsuario);
                command.Parameters.AddWithValue("@correo", correo);
                command.Parameters.AddWithValue("@clave", clave);

                // Abrimos la conexión
                data.Open();

                // Ejecutamos la consulta de inserción
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Inicio_Sesion formularioInicioSesion = new Inicio_Sesion();
                    formularioInicioSesion.Show();
                    this.Dispose();
                    MessageBox.Show("Usuario registrado exitosamente!");

                }
                else
                {
                    MessageBox.Show("Hubo un problema al registrar el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();

            // Limpiar errores anteriores
            errorProvider1.Clear();

            // Lista para almacenar los errores de validación
            List<string> errores = new List<string>();

            // Validación del campo Usuario
            if (string.IsNullOrWhiteSpace(txtRegistroNombreCompleto.Text))
            {
                errores.Add("El campo de nombre no puede estar vacío.");
                errorProvider1.SetError(txtRegistroNombreCompleto, "El campo de nombre no puede estar vacío.");
            }

            // Validación del campo Apellidos
            if (string.IsNullOrWhiteSpace(txtRegistroEmail.Text))
            {
                errores.Add("El campo de Email no puede estar vacío.");
                errorProvider1.SetError(txtRegistroEmail, "El campo de Email no puede estar vacío.");
            }

            // Validación del campo Contraseña
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errores.Add("El campo de contraseña no puede estar vacío.");
                errorProvider1.SetError(txtPassword, "El campo de contraseña no puede estar vacío.");
            }

            // Validación de la confirmación de la Contraseña (Repetir contraseña)
            if (string.IsNullOrWhiteSpace(txtPassword2.Text))
            {
                errores.Add("Debe confirmar la contraseña.");
                errorProvider1.SetError(txtPassword2, "Debe confirmar la contraseña.");
            }
            else if (txtPassword.Text != txtPassword2.Text)
            {
                errores.Add("Las contraseñas no coinciden.");
                errorProvider1.SetError(txtPassword, "Las contraseñas no coinciden.");
            }

            // Verificar si hay errores
            if (errores.Count > 0)
            {
                // Mostrar los errores en una nueva pestaña o control
                MostrarErrores(errores);
            }
            else
            {
                AgregarUsuario();
            }

        }

        // Método para mostrar los errores en una pestaña o lista
        private void MostrarErrores(List<string> errores)
        {
            // Unir todos los errores en una sola cadena separada por saltos de línea
            string mensajeErrores = string.Join(Environment.NewLine, errores);

            // Mostrar el mensaje de errores en un cuadro emergente (MessageBox)
            MessageBox.Show(mensajeErrores, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lkbVolverIniciar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inicio_Sesion formularioInicioSesion = new Inicio_Sesion();
            formularioInicioSesion.Show();
            this.Close();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MostrarPasswordA_MouseDown(object sender, MouseEventArgs e)
        {
            // Mostrar la contraseña
            txtPassword.PasswordChar = '\0';
        }

        private void MostrarPasswordA_MouseUp(object sender, MouseEventArgs e)
        {
            // Ocultar la contraseña nuevamente
            txtPassword.PasswordChar = '*';
        }

        private void MostrarPasswordB_MouseDown(object sender, MouseEventArgs e)
        {
            // Mostrar la contraseña
            txtPassword2.PasswordChar = '\0';
        }

        private void MostrarPasswordB_MouseUp(object sender, MouseEventArgs e)
        {
            // Ocultar la contraseña nuevamente
            txtPassword2.PasswordChar = '*';
        }
    }
}
