using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JaguarGymApp_Preview.Estructuras;
using JaguarGymApp_Preview.Formularios;
using JaguarGymApp_Preview.FormulariosReportes;
using JaguarGymApp_Preview.Servicios;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;

namespace JaguarGymApp_Preview.Formularios
{
    public partial class Gestion_Pagos : MaterialForm
    {

        public int _idUsuario;

        public Gestion_Pagos(int IdUsuario)
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Principal_Resize);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            _idUsuario = IdUsuario;
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720);
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            ActualizarData();
            ConteoPagos();
        }

        private void ActualizarData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(new ConexionBD().GetConnector()))
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                        p.idPago AS 'ID de Pago',
                        p.idTransaccion AS 'ID de Transacción',
                        p.fechaRealizacion AS 'Fecha de Realización',
                        p.descripcion AS 'Descripción',
                        p.monto AS 'Monto',
                        p.observacion AS 'Observación',
                        u.nombreUsuario AS 'Usuario',
                        CONCAT(m.nombres, ' ', m.apellidos) AS 'Miembro'
                    FROM 
                        Pago p
                    LEFT JOIN Usuario u ON p.idUsuario = u.idUsuario
                    LEFT JOIN Miembro m ON p.idMiembro = m.idMiembro;
                    ";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvPagos.DataSource = table;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void ConteoPagos()
        {
            try
            {

                ConexionBD conn = new ConexionBD();
                using (MySqlConnection connection = new MySqlConnection(conn.GetConnector()))
                {
                    connection.Open(); 
                    string query = "SELECT COUNT(*) FROM Pago"; 

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        int totalMiembros = Convert.ToInt32(command.ExecuteScalar());


                        toolStripStatusLabel1.Text = $"Total de Pagos: {totalMiembros}";
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al contar los pagos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterioBusqueda = txtBuscar.Text.Trim();  

            if (string.IsNullOrEmpty(criterioBusqueda))
            {
                ActualizarData();  
                return;
            }

            string query = "SELECT * FROM Pago WHERE idTransaccion LIKE @criterio";

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


                    dgvPagos.DataSource = resultados;

                    if (resultados.Rows.Count == 0)
                    {
                        MessageBox.Show("No se ha encontrado ningún registro que cumpla el criterio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ingresar_Pago nuevoFormulario = new Ingresar_Pago(_idUsuario);
            this.Hide();
            nuevoFormulario.ShowDialog();
            this.Close();
        }

        private void LinkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Principal formularioPrincipal = new Principal(_idUsuario);
            this.Hide();
            formularioPrincipal.ShowDialog();
            this.Close();
        }


        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show($"Elemento seleccionado: {e.ClickedItem.Text}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es el monto total de todos los pagos registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerPagos_Click(object sender, EventArgs e)
        {
            List<PagoReporte> lista = new List<PagoReporte>();

            string query = @"
     SELECT 
            p.idPago AS 'ID Pago',
            p.idTransaccion AS 'ID Transacción',
            p.fechaRealizacion AS 'Fecha Realización',
            p.descripcion AS 'Descripción',
            p.monto AS 'Monto',
            p.observacion AS 'Observación',
            u.nombreUsuario AS 'Nombre Usuario',
            CONCAT(m.nombres, ' ', m.apellidos) AS 'Nombre Miembro'
        FROM 
            Pago p
        INNER JOIN 
            Usuario u ON p.idUsuario = u.idUsuario
        INNER JOIN
            Miembro m ON p.idMiembro = m.idMiembro;
    ";

            ConexionBD conn = new ConexionBD();
            using (MySqlConnection connection = new MySqlConnection(conn.GetConnector()))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        PagoReporte pago = new PagoReporte
                        {
                            idPago = reader.GetInt32(reader.GetOrdinal("ID Pago")),
                            idTransaccion = reader.GetString(reader.GetOrdinal("ID Transacción")),
                            fechaRealizacion = reader.GetDateTime(reader.GetOrdinal("Fecha Realización")),
                            descripcion = reader.GetString(reader.GetOrdinal("Descripción")),
                            monto = reader.GetDecimal(reader.GetOrdinal("Monto")),
                            observacion = reader.IsDBNull(reader.GetOrdinal("Observación")) ? "" : reader.GetString(reader.GetOrdinal("Observación")),
                            nombreUsuario = reader.GetString(reader.GetOrdinal("Nombre Usuario")),
                            nombreMiembro = reader.GetString(reader.GetOrdinal("Nombre Miembro"))
                        };
                        lista.Add(pago);
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            foreach (var pago in lista)
            {
                Console.WriteLine("ID Pago: " + pago.idPago);
                Console.WriteLine("ID Transacción: " + pago.idTransaccion);
                Console.WriteLine("Fecha Realización: " + pago.fechaRealizacion.ToString("yyyy-MM-dd HH:mm:ss"));
                Console.WriteLine("Descripción: " + pago.descripcion);
                Console.WriteLine("Monto: " + pago.monto.ToString("C"));
                Console.WriteLine("Observación: " + pago.observacion);
                Console.WriteLine("Usuario: " + pago.nombreUsuario);
                Console.WriteLine("Nombre Miembro: " + pago.nombreMiembro);
                Console.WriteLine("=====================================");
            }

            ReportDataSource dataSource = new ReportDataSource("dsPagos", lista);
            FrmReportePagos reportePago = new FrmReportePagos();
            reportePago.reportViewer1.LocalReport.DataSources.Clear();
            reportePago.reportViewer1.LocalReport.DataSources.Add(dataSource);
            reportePago.reportViewer1.LocalReport.ReportEmbeddedResource = "JaguarGymApp_Preview.Reportes.rptPagos.rdlc";
            reportePago.reportViewer1.RefreshReport();
            reportePago.ShowDialog();
        }
    }
}
