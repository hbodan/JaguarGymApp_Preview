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

                    string query = "SELECT * FROM miembro";
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
                    string query = "SELECT COUNT(*) FROM miembro"; // Consulta SQL para contar los registros

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Ejecutar la consulta y obtener el resultado
                        int totalMiembros = Convert.ToInt32(command.ExecuteScalar());

                        // Mostrar el total en el ToolStripStatusLabel
                        toolStripStatusLabel1.Text = $"Número de Miembros activos: {totalMiembros}";
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
            var Buscado = txtBuscar.Text.ToLower();
            var resultados = miembros.Where(u => u.Nombres.ToLower().Contains(Buscado)).ToList();
            dgvMiembros.DataSource = null;
            dgvMiembros.DataSource = resultados;

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
