using JaguarGymApp_Preview.Estructuras;
using MaterialSkin.Controls;
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
using JaguarGymApp_Preview.Servicios;
using MySql.Data.MySqlClient;

namespace JaguarGymApp_Preview.Formularios
{
    public partial class Miembros_Activos : MaterialForm
    {
        List<Miembro> miembros;
        public Miembros_Activos()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Principal_Resize);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;

            Actualizardata();
        }

         private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
        }

        private void Miembros_Load(object sender, EventArgs e)
        {
            Actualizardata();
            ConteoMiembros();
        }
        private void Actualizardata()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(new ConexionBD().GetConnector()))
                {
                    conn.Open();

                    string query = "SELECT \r\n m.idMiembro AS 'ID',\r\n m.cif AS 'CIF', m.identificacion AS 'Identificación',\r\n    m.nombres AS 'Nombres',\r\n    m.apellidos AS 'Apellidos',\r\n m.fechaNacimiento AS 'Fecha de Nacimiento'\r\n ,   f.nombreFacultad AS 'Facultad',\r\n    c.nombreCarrera AS 'Carrera',\r\n    m.genero AS 'Género',\r\n m.fechaExp AS 'Membresia Expira', \r\n    CASE \r\n        WHEN m.interno = 1 THEN 'Sí' \r\n        ELSE 'No' \r\n    END AS 'Interno',\r\n    CASE \r\n        WHEN m.colaborador = 1 THEN 'Sí' \r\n        ELSE 'No' \r\n    END AS 'Colaborador',\r\n    m.cargo AS 'Cargo'\r\nFROM \r\n    Miembro m\r\nLEFT JOIN Facultad f ON m.idfacultad = f.idFacultad\r\nLEFT JOIN Carrera c ON m.idcarrera = c.idCarrera;";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvMiembros.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
        private void ConteoMiembros()
        {
            try
            {
                // Crear una conexión con la base de datos
                ConexionBD conn = new ConexionBD();
                using (MySqlConnection connection = new MySqlConnection(conn.GetConnector()))
                {
                    connection.Open(); // Abrir la conexión
                    string query = "SELECT COUNT(*) FROM Miembro"; // Consulta SQL para contar los registros

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Ejecutar la consulta y obtener el resultado
                        int totalMiembros = Convert.ToInt32(command.ExecuteScalar());

                        // Mostrar el total en el ToolStripStatusLabel
                        toolStripStatusLabel1.Text = $"Total de Miembros activos: {totalMiembros}";
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Error al contar los miembros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar_Miembros formulario2 = new Agregar_Miembros(miembros,this);
            formulario2.Show();
            this.Hide();
        }
        public void RecibirDatos(List<Miembro> datos)
        {
            miembros = datos;
            this.Show();
            Actualizardata();
            ConteoMiembros();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtroSeleccionado = cmbFiltro.SelectedItem.ToString(); // Obtener el criterio seleccionado
            string criterioBusqueda = txtBuscar.Text.Trim();     // Obtener el texto a buscar

            if (string.IsNullOrEmpty(criterioBusqueda))
            {
                Actualizardata();
                return;
            }
            
            string query = "";

            // Construir la consulta SQL según el filtro seleccionado
            switch (filtroSeleccionado)
            {
                case "Identificacion":
                    query = "SELECT * FROM Miembro WHERE identificacion LIKE @criterio";
                    break;

                case "Nombre":
                    query = "SELECT * FROM Miembro WHERE nombres LIKE @criterio";
                    break;

                case "Apellido":
                    query = "SELECT * FROM Miembro WHERE apellidos LIKE @criterio";
                    break;

                case "Facultad":
                    query = @"SELECT m.* FROM Miembro m 
                      JOIN Facultad f ON m.idfacultad = f.idFacultad 
                      WHERE f.nombreFacultad LIKE @criterio";
                    break;

                case "Carrera":
                    query = @"SELECT m.* FROM Miembro m 
                      JOIN Carrera c ON m.idcarrera = c.idCarrera 
                      WHERE c.nombreCarrera LIKE @criterio";
                    break;

                case "Género":
                    query = "SELECT * FROM Miembro WHERE genero LIKE @criterio";
                    break;

                default:
                    MessageBox.Show("Filtro no válido seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Ejecutar la consulta
            try
            {
                ConexionBD conn = new ConexionBD();
                using (MySqlConnection connection = new MySqlConnection(conn.GetConnector()))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@criterio", "%" + criterioBusqueda + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable resultados = new DataTable();
                    adapter.Fill(resultados);

                    // Asumiendo que tienes un DataGridView para mostrar resultados
                    dgvMiembros.DataSource = resultados;

                    if (resultados.Rows.Count == 0)
                    {
                        MessageBox.Show("No se ha encontrado ningún registro que cumpla el criterio","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void LinkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Principal formularioPrincipal = new Principal(0);
            formularioPrincipal.Show();
            this.Hide();
        }

        private void dgvMiembros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMiembros.ReadOnly = true;

        }
    }
}
