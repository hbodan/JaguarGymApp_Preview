using JaguarGymApp_Preview.Estructuras;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using JaguarGymApp_Preview.Servicios;
using System.Windows.Media.Media3D;

namespace JaguarGymApp_Preview.Formularios
{
    public partial class Editar_Miembros : MaterialForm
    {
        private MySqlConnection data;
        public Miembro miembrito;
        private bool bloqueandoEventos = false;

        public Editar_Miembros(Miembro miembro)
        {
            ConexionBD conn = new ConexionBD();
            data = new MySqlConnection(conn.GetConnector());
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Principal_Resize);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            miembrito = new Miembro(miembro.IdMiembro, miembro.Identificacion, miembro.CIF, miembro.Nombres, miembro.Apellidos, miembro.FechaNac, miembro.FechaExp, miembro.Carrera, miembro.Facultad, miembro.Genero, miembro.Interno, miembro.Colaborador, miembro.Cargo);
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
        }

        private void Editar_Miembros_Load(object sender, EventArgs e)
        {
            // Llenar las facultades cuando se cargue el formulario.
            LlenarFacultades();

            // Mostrar los valores en consola (solo para pruebas).
            string valores = $@"
            idMiembro: {miembrito.IdMiembro}
            identificacion: {txtIdentificacion.Text}
            cif: {txtCIF.Text}
            nombres: {txtNombre.Text}
            apellidos: {txtApellidos.Text}
            fechaNacimiento: {dateNacimiento.Value.ToString("yyyy-MM-dd")}
            fechaExp: {dateExpiracion.Value.ToString("yyyy-MM-dd")}
            carrera: {cmbCarrera.ValueMember}
            facultad: {cmbFacultad.ValueMember}
            genero: {(chkMasculino.Checked ? "Masculino" : "Femenino")}
            interno: {(chkEstudiante.Checked ? "Sí" : "No")}
            colaborador: {(chkColaborador.Checked ? "Sí" : "No")}
            cargo: {txtCargo.Text}";

            Console.WriteLine(valores);

            // Obtener y cargar las carreras de la facultad seleccionada
            ObtenerCarrerasPorFacultad(miembrito.Facultad ?? 0);

            // Llamar a CargarDatosMiembro para rellenar los datos en los controles
            CargarDatosMiembro(
                miembrito.Identificacion,
                miembrito.CIF,
                miembrito.Nombres,
                miembrito.Apellidos,
                miembrito.FechaNac,
                miembrito.FechaExp,
                miembrito.Carrera ?? 0,
                miembrito.Facultad ?? 0,
                miembrito.Genero,
                miembrito.Interno,
                miembrito.Colaborador,
                miembrito.Cargo
            );
        }

        private void LlenarFacultades()
        {
            ConexionBD connFacultades = new ConexionBD();
            string queryFacultades = "SELECT idFacultad, nombreFacultad FROM Facultad";

            try
            {
                using (MySqlConnection connectionFacultades = new MySqlConnection(connFacultades.GetConnector()))
                {
                    connectionFacultades.Open();
                    MySqlCommand commandFacultades = new MySqlCommand(queryFacultades, connectionFacultades);
                    MySqlDataAdapter adapterFacultades = new MySqlDataAdapter(commandFacultades);

                    DataTable facultades = new DataTable();
                    adapterFacultades.Fill(facultades);

                    cmbFacultad.DataSource = facultades;
                    cmbFacultad.DisplayMember = "nombreFacultad";
                    cmbFacultad.ValueMember = "idFacultad";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar facultades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ObtenerCarrerasPorFacultad(int idFacultad)
        {
            string query = "SELECT idCarrera, nombreCarrera FROM Carrera WHERE idFacultad = @idFacultad";

            try
            {
                ConexionBD connect = new ConexionBD();
                using (MySqlConnection connectionA = new MySqlConnection(connect.GetConnector()))
                {
                    connectionA.Open();
                    MySqlCommand command = new MySqlCommand(query, connectionA);
                    command.Parameters.AddWithValue("@idFacultad", idFacultad);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable carreras = new DataTable();
                    adapter.Fill(carreras);
                    connectionA.Close();
                    return carreras;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener carreras: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void CargarDatosMiembro(string identificacion, string cif, string nombres, string apellidos, DateTime fechaNacimiento, DateTime fechaExp, int carrera, int facultad, bool genero, bool interno, bool colaborador, string cargo)
        {
            string valores = $@"
            idMiembro: {miembrito.IdMiembro}
            identificacion: {identificacion}
            cif: {cif}
            nombres: {nombres}
            apellidos: {apellidos}
            fechaNacimiento: {fechaNacimiento.ToString("yyyy-MM-dd")}
            fechaExp: {fechaExp.ToString("yyyy-MM-dd")}
            carrera: {carrera}
            facultad: {facultad}
            genero: {genero}
            interno: {interno}
            colaborador: {colaborador}
            cargo: {cargo}";

            // Imprimir en consola
            Console.WriteLine(valores);

            // Asignar valores a los controles
            txtIdentificacion.Text = identificacion;
            txtCIF.Text = cif;
            txtNombre.Text = nombres;
            txtApellidos.Text = apellidos;
            dateNacimiento.Value = fechaNacimiento;
            dateExpiracion.Value = fechaExp;
            cmbFacultad.SelectedValue = facultad;
            cmbFacultad_SelectedIndexChanged(cmbFacultad, EventArgs.Empty);
            cmbCarrera.SelectedValue = carrera;
            chkMasculino.Checked = genero; 
            chkFemenino.Checked = !genero;
            chkEstudiante.Checked = interno;
            chkColaborador.Checked = colaborador;
            chkExterno.Checked = !interno && !colaborador;
            txtCargo.Text = cargo;

            // Ajustar visibilidad según el rol
            lblFacultad.Visible = chkEstudiante.Checked;
            cmbFacultad.Visible = chkEstudiante.Checked;
            lblCarrera.Visible = chkEstudiante.Checked;
            cmbCarrera.Visible = chkEstudiante.Checked;
            lblCargo.Visible = chkColaborador.Checked;
            txtCargo.Visible = chkColaborador.Checked;

            // Si el miembro no es colaborador ni estudiante, ocultar estos controles
            if (!chkEstudiante.Checked && !chkColaborador.Checked)
            {
                lblFacultad.Visible = false;
                cmbFacultad.Visible = false;
                lblCarrera.Visible = false;
                cmbCarrera.Visible = false;
                lblCargo.Visible = false;
                txtCargo.Visible = false;
            }
        }

        private Miembro CrearMiembro()
        {
            // Inicializa los valores como nulos
            int? carrera = null;
            int? facultad = null;
            string cargo = null;

            // Verifica si es estudiante y asigna los valores correspondientes
            if (chkEstudiante.Checked)
            {
                // Verifica si el valor de carrera o facultad es válido (no nulo y no vacío)
                carrera = string.IsNullOrWhiteSpace(cmbCarrera.SelectedValue?.ToString()) ? (int?)null : (int?)cmbCarrera.SelectedValue;
                facultad = string.IsNullOrWhiteSpace(cmbFacultad.SelectedValue?.ToString()) ? (int?)null : (int?)cmbFacultad.SelectedValue;
            }
            // Verifica si es colaborador y asigna el cargo si existe
            else if (chkColaborador.Checked)
            {
                cargo = string.IsNullOrWhiteSpace(txtCargo.Text) ? null : txtCargo.Text;
            }

            // Retorna el nuevo objeto Miembro con los valores proporcionados
            return new Miembro(
                idMiembro: 0, // Puede ser asignado más tarde si es necesario
                identificacion: string.IsNullOrWhiteSpace(txtIdentificacion.Text) ? null : txtIdentificacion.Text,
                cif: string.IsNullOrWhiteSpace(txtCIF.Text) ? null : txtCIF.Text,
                nombres: string.IsNullOrWhiteSpace(txtNombre.Text) ? null : txtNombre.Text,
                apellidos: string.IsNullOrWhiteSpace(txtApellidos.Text) ? null : txtApellidos.Text,
                fechaNac: dateNacimiento.Value,
                fechaExp: DateTime.Now, // Asumiendo que la fecha de expedición es la fecha actual
                carrera: carrera,
                facultad: facultad,
                genero: chkMasculino.Checked, // Si el checkbox de masculino está marcado
                interno: chkEstudiante.Checked, // Si está marcado como estudiante
                colaborador: chkColaborador.Checked, // Si está marcado como colaborador
                cargo: cargo // Asignará null si no es colaborador
            );
        }


        public void EditarMiembro(Miembro miembroNuevo)
        {
            string query = @"
    UPDATE Miembro
    SET 
        identificacion = @identificacion,
        cif = @cif,
        nombres = @nombres,
        apellidos = @apellidos,
        fechaNacimiento = @fechaNacimiento,
        fechaExp = @fechaExp,
        idCarrera = @carrera,
        idFacultad = @facultad,
        genero = @genero,
        interno = @interno,
        colaborador = @colaborador,
        cargo = @cargo
    WHERE idMiembro = @idMiembroo";

            try
            {
                ConexionBD conn = new ConexionBD();

                using (MySqlConnection connection = new MySqlConnection(conn.GetConnector()))
                {
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Limpia parámetros para evitar duplicados
                    command.Parameters.Clear();

                    // Asigna valores desde miembrito
                    command.Parameters.AddWithValue("@idMiembroo", miembrito.IdMiembro);
                    command.Parameters.AddWithValue("@identificacion", string.IsNullOrWhiteSpace(miembroNuevo.Identificacion) ? (object)DBNull.Value : miembroNuevo.Identificacion);
                    command.Parameters.AddWithValue("@cif", string.IsNullOrWhiteSpace(miembroNuevo.CIF) ? (object)DBNull.Value : miembroNuevo.CIF);
                    command.Parameters.AddWithValue("@nombres", miembroNuevo.Nombres ?? string.Empty);
                    command.Parameters.AddWithValue("@apellidos", miembroNuevo.Apellidos ?? string.Empty);
                    command.Parameters.AddWithValue("@fechaNacimiento", miembroNuevo.FechaNac);
                    command.Parameters.AddWithValue("@fechaExp", miembroNuevo.FechaExp);

                    // Condicionalmente asigna valores nulos para carrera y facultad
                    command.Parameters.AddWithValue("@carrera", miembroNuevo.Carrera ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@facultad", miembroNuevo.Facultad ?? (object)DBNull.Value);



                    command.Parameters.AddWithValue("@genero", miembroNuevo.Genero);
                    command.Parameters.AddWithValue("@interno", miembroNuevo.Interno ? 1 : 0);
                    command.Parameters.AddWithValue("@colaborador", miembroNuevo.Colaborador ? 1 : 0);

                    // Manejo condicional para `@cargo`
                    // Si no es colaborador, asignamos null a cargo
                    command.Parameters.AddWithValue("@cargo", miembroNuevo.Colaborador ? (miembroNuevo.Cargo ?? string.Empty) : (object)DBNull.Value);

                    connection.Open();

                    // Imprime los parámetros para depuración
                    foreach (MySqlParameter param in command.Parameters)
                    {
                        Console.WriteLine($"{param.ParameterName}: {param.Value}");
                    }

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Miembro actualizado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el miembro.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el miembro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidacionLlenado()
        {

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombres no puede estar vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                MessageBox.Show("El campo Apellidos no puede estar vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbFacultad.Visible && string.IsNullOrWhiteSpace(cmbFacultad.Text))
            {
                MessageBox.Show("Debe seleccionar una Facultad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbCarrera.Visible && string.IsNullOrWhiteSpace(cmbCarrera.Text))
            {
                MessageBox.Show("Debe seleccionar una Carrera.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar CheckBox (al menos uno seleccionado)
            if (!chkEstudiante.Checked && !chkColaborador.Checked && !chkExterno.Checked)
            {
                MessageBox.Show("Debe seleccionar si el miembro es estudiante, colaborador o externo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!chkMasculino.Checked && !chkFemenino.Checked)
            {
                MessageBox.Show("Debe seleccionar si el miembro es Masculino o Femenino.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar campo de Cargo si es colaborador
            if (chkColaborador.Checked && string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                MessageBox.Show("Debe ingresar un Cargo si selecciona Colaborador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void chkEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (bloqueandoEventos) return;

            bloqueandoEventos = true; // Bloquea otros eventos

            lblCargo.Visible = false;
            txtCargo.Visible = false;
            lblFacultad.Visible = true;
            cmbFacultad.Visible = true;
            lblCarrera.Visible = true;
            cmbCarrera.Visible = true;

            chkColaborador.Checked = false;
            chkExterno.Checked = false;
            txtCargo.Text = "Estudiante";

            bloqueandoEventos = false; // Desbloquea eventos
        }

        private void chkExterno_CheckedChanged(object sender, EventArgs e)
        {
            if (bloqueandoEventos) return;

            bloqueandoEventos = true;

            lblFacultad.Visible = false;
            cmbFacultad.Visible = false;
            lblCarrera.Visible = false;
            cmbCarrera.Visible = false;
            lblCargo.Visible = false;
            txtCargo.Visible = false;

            chkEstudiante.Checked = false;
            chkColaborador.Checked = false;
            txtCargo.Text = "Externo";

            bloqueandoEventos = false;
        }

        private void chkColaborador_CheckedChanged(object sender, EventArgs e)
        {
            if (bloqueandoEventos) return;

            bloqueandoEventos = true;

            lblFacultad.Visible = false;
            cmbFacultad.Visible = false;
            lblCarrera.Visible = false;
            cmbCarrera.Visible = false;
            lblCargo.Visible = true;
            txtCargo.Visible = true;

            chkEstudiante.Checked = false;
            chkExterno.Checked = false;
            txtCargo.Text = "";

            bloqueandoEventos = false;
        }
        private void chkMasculino_CheckedChanged(object sender, EventArgs e)
        {
            bool seleccionado = chkMasculino.Checked;

            if (seleccionado)
                chkFemenino.Checked = false;
        }

        private void chkFemenino_CheckedChanged(object sender, EventArgs e)
        {
            bool seleccionado = chkFemenino.Checked;

            if (seleccionado)
                chkMasculino.Checked = false;
        }

        private void cmbFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFacultad.SelectedValue != null && cmbFacultad.SelectedValue is int idFacultadSeleccionada)
                {
                    // Obtener las carreras según la facultad seleccionada
                    DataTable carreras = ObtenerCarrerasPorFacultad(idFacultadSeleccionada);
                    cmbCarrera.DataSource = carreras;
                    cmbCarrera.DisplayMember = "nombreCarrera";
                    cmbCarrera.ValueMember = "idCarrera";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las carreras: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void LinkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Miembros_Activos mimebrosForm  = new Miembros_Activos();
            this.Hide();
            mimebrosForm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidacionLlenado())
            {
                try
                {
                    Miembro nuevoMiembro = CrearMiembro();
                    EditarMiembro(nuevoMiembro);

                    Miembros_Activos nuevoForm = new Miembros_Activos();
                    this.Hide();
                    nuevoForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblidentificacion_Click(object sender, EventArgs e)
        {

        }


    }
}
