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
using MaterialSkin;
using MaterialSkin.Controls;
using estadisticasForm;
using MySql.Data.MySqlClient;
using JaguarGymApp_Preview.Servicios;
using System.Windows.Markup;
using Guna.UI2.WinForms.Suite;


namespace JaguarGymApp_Preview.Formularios
{
    public partial class Ingresar_Pago : MaterialForm
    {
        private MySqlConnection dataPagos;
        public int _idUsuario;

        public Ingresar_Pago(int idUsuario)
        {
            ConexionBD connPagos = new ConexionBD();
            dataPagos = new MySqlConnection(connPagos.GetConnector());
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Principal_Resize);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            _idUsuario = idUsuario;
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
        }

        private void Ingresar_Pago_Load(object sender, EventArgs e)
        {
            ActualizarData();
            dtPickerFecha.Value = DateTime.Now;
        }

        public void ToDataBase(Pago pagoNuevo)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(new ConexionBD().GetConnector()))
                {
                    conn.Open();


                    string query = @"INSERT INTO Pago (IdTransaccion, FechaRealizacion, Descripcion, Monto, Observacion, IdUsuario, IdMiembro)
                                     VALUES (@IdTransaccion, @FechaRealizacion, @Descripcion, @Monto, @Observacion, @IdUsuario, @IdMiembro)";

                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@IdTransaccion", pagoNuevo.IdTransaccion);
                    command.Parameters.AddWithValue("@FechaRealizacion", pagoNuevo.FechaRealizacion);
                    command.Parameters.AddWithValue("@Descripcion", pagoNuevo.Descripcion);
                    command.Parameters.AddWithValue("@Monto", pagoNuevo.Monto);
                    command.Parameters.AddWithValue("@Observacion", pagoNuevo.Observacion);
                    command.Parameters.AddWithValue("@IdUsuario",   _idUsuario);
                    command.Parameters.AddWithValue("@IdMiembro", pagoNuevo.IdMiembro);

                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en la base de datos: " + ex.Message);
            }
        }

        private Pago CrearPago()
        {

            string idTransaccion = txtIdTransaccion.Text; 
            DateTime fechaRealizacion = dtPickerFecha.Value;


            string descripcion = $"{nudMesesPagados.ValueNumber} Mes/Meses Pagados";
            decimal monto = decimal.Parse(txtMonto.Text);
            string observacion = string.IsNullOrWhiteSpace(txtObservacion.Text) ? null : txtObservacion.Text;
            int idUsuario = 1; 
            int idMiembro = int.Parse(txtMiembroSeleccionado.Tag.ToString()); 


            return new Pago(
                idPago: 0,
                idTransaccion: idTransaccion,
                fechaRealizacion: fechaRealizacion,
                descripcion: descripcion,
                monto: monto,
                observacion: observacion,
                idUsuario: _idUsuario,
                idMiembro: idMiembro
            );
        }

        public bool ValidacionLlenado()
        {
         

            string idTransaccion = txtIdTransaccion.Text.Trim();
            if (string.IsNullOrEmpty(idTransaccion))
            {
                MessageBox.Show("El ID de transacción no puede estar vacío.");
                return false;
            }

            if (!DateTime.TryParse(dtPickerFecha.Text, out DateTime fechaRealizacion))
            {
                MessageBox.Show("Por favor, selecciona una fecha válida.");
                return false;
            }

            int mesesPagados = (int)nudMesesPagados.ValueNumber; // Obtenemos el valor del NumericUpDown
            if (mesesPagados < 1 || mesesPagados > 12)
            {
                MessageBox.Show("El número de meses pagados debe estar entre 1 y 12.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMonto.Text) || !decimal.TryParse(txtMonto.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Por favor, ingresa un monto válido mayor a 0.");
                return false;
            }

            string observacion = txtObservacion.Text.Trim();
            if (observacion.Length > 500)
            {
                MessageBox.Show("La observación no puede exceder los 500 caracteres.");
                return false;
            }

            return true;

        }

        private void AgregarPago()
        {
            if (ValidacionLlenado())
            {
                try
                {
                    Pago nuevoPago = CrearPago();
                    ToDataBase(nuevoPago);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LinkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gestion_Pagos formGestionPago = new Gestion_Pagos(_idUsuario);
            this.Hide();
            formGestionPago.ShowDialog();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (ValidacionLlenado())
            {
                 AgregarPago();
                Gestion_Pagos formGestionPago = new Gestion_Pagos(_idUsuario);
                this.Hide();
                formGestionPago.ShowDialog();
                this.Close();

            }
        }

        public void ActualizarData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(new ConexionBD().GetConnector()))
                {
                    conn.Open();

                    string query = "SELECT " +
                                   "m.idMiembro AS 'ID', " +
                                   "m.cif AS 'CIF', " +
                                   "m.identificacion AS 'Identificación', " +
                                   "CONCAT(m.nombres, ' ', m.apellidos) AS 'Nombre' " +  
                                   "FROM Miembro m;";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvMiembros.DataSource = table;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string criterioBusqueda = txtBuscarMiembro.Text.Trim();

            if (string.IsNullOrEmpty(criterioBusqueda))
            {
                ActualizarData();
                return;
            }


            string query = "SELECT " +
                           "m.idMiembro AS 'ID', " +
                           "m.cif AS 'CIF', " +
                           "m.identificacion AS 'Identificación', " +
                           "CONCAT(m.nombres, ' ', m.apellidos) AS 'Nombre' " + 
                           "FROM Miembro m " +
                           "WHERE m.identificacion LIKE @criterio OR m.cif LIKE @criterio;";

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

                    dgvMiembros.DataSource = resultados;

                    if (resultados.Rows.Count == 0)
                    {
                        MessageBox.Show("No se ha encontrado ningún registro que cumpla el criterio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void dgvMiembros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string nombreCompleto = dgvMiembros.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                txtMiembroSeleccionado.Text = nombreCompleto;

                string idMiembro = dgvMiembros.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtMiembroSeleccionado.Tag = idMiembro;
            }
        }
    }
}
