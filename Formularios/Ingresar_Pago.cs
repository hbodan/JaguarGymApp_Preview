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


namespace JaguarGymApp_Preview.Formularios
{
    public partial class Ingresar_Pago : MaterialForm
    {
        private MySqlConnection dataPagos;
        private List<Pago> pagosRecibidos;
        private Gestion_Pagos formularioAnterior;

        public Ingresar_Pago(List<Pago> lista, Gestion_Pagos formulario)
        {
            ConexionBD connPagos = new ConexionBD();
            dataPagos = new MySqlConnection(connPagos.GetConnector());
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Principal_Resize);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.pagosRecibidos = lista;
            this.formularioAnterior = formulario;

        }

        private void ToDataBase(Miembro miembro)
        {
            string queryPagos = @"INSERT INTO Pago 
         (idTransaccion, fechaRealizacion, descripcion, monto, observacion, idUsuario, idMiembro) 
         VALUES 
         (@idTransaccion, @fechaRealizacion, @descripcion, @monto, @observacion, @idUsuario, @idMiembro)";

            try
            {
                using (dataPagos)
                {
                   
                    MySqlCommand commandPagos = new MySqlCommand(queryPagos, dataPagos);

                    // Validar datos antes de asignar
                    commandPagos.Parameters.AddWithValue("@idTransaccion", txtIdTransaccion.Text ?? string.Empty);
                    commandPagos.Parameters.AddWithValue("@fechaRealizacion", dtPickerFecha);
                    commandPagos.Parameters.AddWithValue("@descripcion", nudMesesPagados.ValueNumber.ToString() ?? string.Empty);
                    commandPagos.Parameters.AddWithValue("@monto", decimal.Parse(txtMonto.Text));
                    commandPagos.Parameters.AddWithValue("@observacion", txtObservacion.Text ?? string.Empty);
                    commandPagos.Parameters.AddWithValue("@idUsuario", 1);
                    commandPagos.Parameters.AddWithValue("@idMiembro", 2);

                    dataPagos.Open();
                    int rowsAffected = commandPagos.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pago registrado correctamente.");
                        dataPagos.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el pago.");
                        dataPagos.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el pago en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataPagos.Close();
            }
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
        }

        private void Ingresar_Pago_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarPago()
        {
         

            string idTransaccion = txtIdTransaccion.Text.Trim();
            if (string.IsNullOrEmpty(idTransaccion))
            {
                MessageBox.Show("El ID de transacción no puede estar vacío.");
                return;
            }

            if (!DateTime.TryParse(dtPickerFecha.Text, out DateTime fechaRealizacion))
            {
                MessageBox.Show("Por favor, selecciona una fecha válida.");
                return;
            }

            int mesesPagados = (int)nudMesesPagados.ValueNumber; // Obtenemos el valor del NumericUpDown
            if (mesesPagados < 1 || mesesPagados > 12)
            {
                MessageBox.Show("El número de meses pagados debe estar entre 1 y 12.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMonto.Text) || !decimal.TryParse(txtMonto.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Por favor, ingresa un monto válido mayor a 0.");
                return;
            }

            string observacion = txtObservacion.Text.Trim();
            if (observacion.Length > 500)
            {
                MessageBox.Show("La observación no puede exceder los 500 caracteres.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBuscarMiembro.Text) || !int.TryParse(txtBuscarMiembro.Text, out int idMiembro))
            {
                MessageBox.Show("Por favor, ingresa un ID de miembro válido.");
                return;
            }


            // Agregar el pago a la lista
            pagosRecibidos.Add(new Pago(1, idTransaccion, fechaRealizacion, "probando", monto, observacion, idMiembro, 1));

            MessageBox.Show("Pago registrado correctamente.");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPago();
            LimpiarCampos();
            formularioAnterior.RecibirDatos(pagosRecibidos);
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtIdTransaccion.Text = "";
            nudMesesPagados.ValueNumber = 1;
            txtMonto.Text = "";
            txtObservacion.Text = "";
            txtBuscarMiembro.Text = "";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCarrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LinkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formularioAnterior.RecibirDatos(pagosRecibidos);
            this.Close();
        }

        private void txtIdPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdTransaccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaRealizacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdMiembro_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudMesesPagados_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarMiembro_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvMiembros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se haya seleccionado una fila válida
            if (e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                var miembroSeleccionado = (Miembro)dgvMiembros.Rows[e.RowIndex].DataBoundItem;

                // Actualizar el TextBox con el nombre completo del miembro seleccionado
                txtMiembroSeleccionado.Text = $"Miembro: {miembroSeleccionado.Nombres} {miembroSeleccionado.Apellidos}";

                // Actualizar el campo ID miembro
                txtBuscarMiembro.Text = miembroSeleccionado.Identificacion;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
              // Obtener el texto de búsqueda
            string criterio = txtBuscarMiembro.Text.Trim().ToLower();

            // Simular la búsqueda en una lista de miembros (reemplazar por datos reales)
            List<Miembro> listaMiembros = ObtenerMiembros(); // Implementar método para obtener miembros

            // Filtrar los resultados por ID o CIF
            var resultados = listaMiembros.Where(m =>
                m.Identificacion.ToLower().Contains(criterio) ||
                m.CIF.ToLower().Contains(criterio)).ToList();

            // Mostrar los resultados en el DataGridView
            dgvMiembros.DataSource = resultados;

            if (resultados.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias.");
            }
        }

        // Método para obtener miembros (puedes reemplazarlo con una consulta real a la base de datos)
        private List<Miembro> ObtenerMiembros()
        {
            return new List<Miembro>
            {
                new Miembro(1, "12345678", "CIF001", "Juan", "Pérez", DateTime.Now.AddYears(-25), DateTime.Now.AddYears(-5),
                "Ingeniería", "Facultad de Tecnología", true, true, false, "Estudiante"),
                new Miembro(2, "87654321", "CIF002", "María", "López", DateTime.Now.AddYears(-22), DateTime.Now.AddYears(-4),
                "Medicina", "Facultad de Ciencias", false, false, true, "Colaboradora")
            };
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblMiembroSeleccionado_Click(object sender, EventArgs e)
        {

        }

        private void lblMesesPagados_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
