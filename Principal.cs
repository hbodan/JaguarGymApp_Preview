using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private MySqlConnection dataMembresia;
        private MySqlConnection dataTop;
        private int _idUsuario;

        public Principal(int idUsuario)
        {
            ConexionBD conn = new ConexionBD();
            data = new MySqlConnection(conn.GetConnector());
            ConexionBD connMembresia = new ConexionBD();
            dataMembresia = new MySqlConnection(connMembresia.GetConnector());
            ConexionBD connTop = new ConexionBD();
            dataTop = new MySqlConnection(connTop.GetConnector());
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
            LoadMembresiasProximasAVencer();
            LoadMiembrosMasActivos();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Configuracion iniciarFormulario = new Configuracion();
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
            Miembros_Activos formularioMiembros = new Miembros_Activos(); // Cambia a tu formulario
            this.Hide();
            formularioMiembros.Show();
        }
        private void btn_Miembros_Click(object sender, EventArgs e)
        {
            Miembros_Activos formularioMiembros = new Miembros_Activos(); // Cambia a tu formulario
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
            string query = "SELECT nombreUsuario FROM Usuario WHERE idUsuario = @idUsuario";

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
                    data.Close();
                }
                else
                {
                    MessageBox.Show("No se encontró un usuario con ese ID.");
                    data.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores.
                MessageBox.Show("Error al buscar el nombre: " + ex.Message);
                data.Close();
            }
            finally
            {
                data.Close();
            }

            return string.Empty;
        }
        private void LoadMembresiasProximasAVencer()
        {
            try
            {
                string queryMembresia = "SELECT nombres, identificacion, fechaExp FROM Miembro WHERE fechaExp BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 7 DAY)";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(queryMembresia, dataMembresia))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count == 0)
                    {
                        panelOverlay.Visible = true; // Muestra el panel superpuesto
                        dgv_ListaMembresiasAVencer.Visible = false; // Oculta el DataGridView
                    }
                    else
                    {
                        panelOverlay.Visible = false; // Oculta el panel superpuesto
                        dgv_ListaMembresiasAVencer.Visible = true;

                        dgv_ListaMembresiasAVencer.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las membresías: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadMiembrosMasActivos()
        {
            try
            {

                // Consulta SQL para obtener los 10 miembros más activos
                string queryTop = @"
                SELECT 
                    m.nombres, 
                    m.identificacion, 
                    COUNT(e.idEntrada) AS TotalEntradas
                FROM 
                    Miembro m
                JOIN 
                    Entrada e ON m.idMiembro = e.idMiembro
                GROUP BY 
                    m.idMiembro, m.nombres, m.identificacion
                ORDER BY 
                    TotalEntradas DESC
                LIMIT 10;";

                // Abre una conexión y úsala para ejecutar la consulta
                using (dataTop)
                {
                    dataTop.Open();

                    using (MySqlCommand commandTop = new MySqlCommand(queryTop, dataTop))
                    using (MySqlDataAdapter adapterTop = new MySqlDataAdapter(commandTop)) // Asociar el comando al adaptador
                    {
                        DataTable table = new DataTable();
                        adapterTop.Fill(table);

                        // Asigna los datos al DataGridView
                        dgv_MiembroMasTiempo.DataSource = table;

                        // Configura los encabezados de las columnas
                        dgv_MiembroMasTiempo.Columns["nombres"].HeaderText = "Nombres";
                        dgv_MiembroMasTiempo.Columns["identificacion"].HeaderText = "Identificación";
                        dgv_MiembroMasTiempo.Columns["TotalEntradas"].HeaderText = "Total Entradas";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los miembros más activos: " + ex.Message);
            }
            finally
            {
                // Asegúrate de cerrar la conexión en el bloque finally
                if (dataTop != null && dataTop.State == ConnectionState.Open)
                {
                    dataTop.Close(); // Cierra la conexión
                }
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
