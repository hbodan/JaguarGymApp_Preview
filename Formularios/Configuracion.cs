﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JaguarGymApp_Preview.Estructuras;
using JaguarGymApp_Preview.Servicios;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace JaguarGymApp_Preview.Formularios
{
    public partial class Configuracion : MaterialForm
    {
        private MySqlConnection data;
        public int _idUsuario;

        public Configuracion(int idUsuario)
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


        private void Configuracion_Load(object sender, EventArgs e)
        {
            LoadData();
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
            Principal formularioPrincipal = new Principal(_idUsuario);
            this.Hide();
            formularioPrincipal.ShowDialog();
            this.Close();
        }

        private void txt_UsuarioConfiguracion_TextChanged(object sender, EventArgs e)
        {

       
        }
        private void LoadData()
        {
            try
            {
                // Establecemos la conexión
                ConexionBD conn = new ConexionBD();
                MySqlConnection data = new MySqlConnection(conn.GetConnector());

                {
                    data.Open();

                    string query = "SELECT * FROM Usuario";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, data))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count == 0)
                        {
                            MessageBox.Show("No se encontraron datos.");
                        }
                        else
                        {
                            dgv_ListaUsuarios.DataSource = table;
                            EnmascararPassword();
                         
                        }
                    }
                    data.Close();
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show($"Error de MySQL: {sqlEx.Message}\nCódigo de Error: {sqlEx.Number}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
        private void AgregarUsuario()
        {
            // Obtener valores de los campos
            string nombreUsuario = txt_UsuarioConfiguracion.Text.Trim();
            string correo = txt_EmailConfiguracion.Text.Trim();
            string clave = txt_PasswordConfiguracion.Text.Trim();

            // Validar campos requeridos
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de registrar al usuario.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Consulta SQL con parámetros
            string query = "INSERT INTO Usuario (nombreUsuario, correoElectronico, clave) VALUES (@nombre, @correo, @clave)";

            try
            {
                // Usar `using` para manejar la conexión automáticamente
                using (MySqlConnection data = new MySqlConnection(new ConexionBD().GetConnector()))
                {
                    data.Open();

                    using (MySqlCommand command = new MySqlCommand(query, data))
                    {
                        command.Parameters.AddWithValue("@nombre", nombreUsuario);
                        command.Parameters.AddWithValue("@correo", correo);
                        command.Parameters.AddWithValue("@clave", clave);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario registrado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Actualizar DataGridView con los nuevos datos
                        }
                        else
                        {
                            MessageBox.Show("Hubo un problema al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    data.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_AgregarConfiguracion_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            errorProvider1.Clear();

            List<string> errores = new List<string>();

            // Validación del campo Usuario
            if (string.IsNullOrWhiteSpace(txt_UsuarioConfiguracion.Text))
            {
                errores.Add("El campo de nombre no puede estar vacío.");
                errorProvider1.SetError(txt_UsuarioConfiguracion, "El campo de nombre no puede estar vacío.");
            }

            // Validación del campo Email
            if (string.IsNullOrWhiteSpace(txt_EmailConfiguracion.Text))
            {
                errores.Add("El campo de Email no puede estar vacío.");
                errorProvider1.SetError(txt_EmailConfiguracion, "El campo de Email no puede estar vacío.");
            }
            else if (!EsCorreoValido(txt_EmailConfiguracion.Text)) // Validar formato del correo específico
            {
                errores.Add("El correo electrónico debe tener el formato @uamv.edu.ni");
                errorProvider1.SetError(txt_EmailConfiguracion, "El correo electrónico debe tener el formato @uamv.edu.ni");
            }

            // Validación del campo Contraseña
            if (string.IsNullOrWhiteSpace(txt_PasswordConfiguracion.Text))
            {
                errores.Add("El campo de contraseña no puede estar vacío.");
                errorProvider1.SetError(txt_PasswordConfiguracion, "El campo de contraseña no puede estar vacío.");
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
        private void editarUsuario ()
        {
            if (dgv_ListaUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un registro para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idUsuario = dgv_ListaUsuarios.SelectedRows[0].Cells["idUsuario"].Value.ToString();
            string query = "UPDATE Usuario SET nombreUsuario = @nombre, correoElectronico = @correo, clave = @clave WHERE idUsuario = @id";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(new ConexionBD().GetConnector()))
                {
                    conn.Open();

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@nombre", txt_UsuarioConfiguracion.Text);
                        command.Parameters.AddWithValue("@correo", txt_EmailConfiguracion.Text);
                        command.Parameters.AddWithValue("@clave", txt_PasswordConfiguracion.Text);
                        command.Parameters.AddWithValue("@id", idUsuario);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Recargar datos en el DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dgv_ListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgv_ListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de fila seleccionado sea válido
            if (e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow selectedRow = dgv_ListaUsuarios.Rows[e.RowIndex];

                // Llena los campos con los valores de las celdas
                txt_UsuarioConfiguracion.Text = selectedRow.Cells["nombreUsuario"].Value?.ToString(); // Nombre del usuario
                txt_EmailConfiguracion.Text = selectedRow.Cells["correoElectronico"].Value?.ToString(); // Correo electrónico

                // Muestra el valor real de la contraseña desde el Tag
                if (selectedRow.Cells["clave"].Tag != null)
                {
                    txt_PasswordConfiguracion.Text = selectedRow.Cells["clave"].Tag.ToString();
                }
            }
        }

        private void btn_EditarConfiguracion_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            List<string> errores = new List<string>();

            // Validación del campo Usuario
            if (string.IsNullOrWhiteSpace(txt_UsuarioConfiguracion.Text))
            {
                errores.Add("El campo de nombre no puede estar vacío.");
                errorProvider1.SetError(txt_UsuarioConfiguracion, "El campo de nombre no puede estar vacío.");
            }

            // Validación del campo Email
            if (string.IsNullOrWhiteSpace(txt_EmailConfiguracion.Text))
            {
                errores.Add("El campo de Email no puede estar vacío.");
                errorProvider1.SetError(txt_EmailConfiguracion, "El campo de Email no puede estar vacío.");
            }
            else if (!EsCorreoValido(txt_EmailConfiguracion.Text)) // Validar formato del correo específico
            {
                errores.Add("El correo electrónico debe tener el formato @uamv.edu.ni");
                errorProvider1.SetError(txt_EmailConfiguracion, "El correo electrónico debe tener el formato @uamv.edu.ni");
            }

            // Validación del campo Contraseña
            if (string.IsNullOrWhiteSpace(txt_PasswordConfiguracion.Text))
            {
                errores.Add("El campo de contraseña no puede estar vacío.");
                errorProvider1.SetError(txt_PasswordConfiguracion, "El campo de contraseña no puede estar vacío.");
            }

            // Verificar si hay errores
            if (errores.Count > 0)
            {
                // Mostrar los errores en una nueva pestaña o control
                MostrarErrores(errores);
            }
            else
            {
                editarUsuario();
            }

        }
        private void EliminarRegistro(int id)
        {
            if (dgv_ListaUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idUsuario = dgv_ListaUsuarios.SelectedRows[0].Cells["idUsuario"].Value.ToString();
            string query = "DELETE FROM Usuario WHERE idUsuario = @id";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(new ConexionBD().GetConnector()))
                {
                    conn.Open();

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", idUsuario);

                        // Confirmación antes de eliminar
                        DialogResult confirmacion = MessageBox.Show(
                            "¿Estás seguro de que deseas eliminar este registro?",
                            "Confirmación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (confirmacion == DialogResult.Yes)
                        {
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Registro eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData(); // Recargar datos en el DataGridView
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_EliminarConfiguracion_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (dgv_ListaUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el ID o clave primaria de la fila seleccionada
                int id = Convert.ToInt32(dgv_ListaUsuarios.SelectedRows[0].Cells["idUsuario"].Value);

                // Confirmación antes de eliminar
                var confirm = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                               "Confirmar Eliminación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Llama al método para eliminar el registro
                    EliminarRegistro(id);

                    // Actualiza el DataGridView
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.",
                                "Eliminar Registro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
        private void EnmascararPassword()
        {
            // Verifica que la columna "clave" exista
            if (dgv_ListaUsuarios.Columns["clave"] != null)
            {
                foreach (DataGridViewRow row in dgv_ListaUsuarios.Rows)
                {
                    if (row.Cells["clave"].Value != null)
                    {
                        // Guarda el valor original en el Tag de la celda
                        row.Cells["clave"].Tag = row.Cells["clave"].Value.ToString();

                        // Enmascara el valor con asteriscos
                        row.Cells["clave"].Value = new string('*', 6); // Puedes ajustar el número de asteriscos
                    }
                }
            }
        }
        private bool EsCorreoValido(string correo)
        {
            // Expresión regular para correos que terminan en @uamv.edu.ni
            string patron = @"^[^@\s]+@uamv\.edu\.ni";
            return System.Text.RegularExpressions.Regex.IsMatch(correo, patron);
        }

    }
}
