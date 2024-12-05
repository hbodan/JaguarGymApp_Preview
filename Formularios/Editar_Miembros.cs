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
        public int _idUsuario;

        public Editar_Miembros(Miembro miembro, int idUsuario)
        {
            ConexionBD conn = new ConexionBD();
            data = new MySqlConnection(conn.GetConnector());
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Principal_Resize);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            miembrito = new Miembro(miembro.IdMiembro, miembro.Identificacion, miembro.CIF, miembro.Nombres, miembro.Apellidos, miembro.FechaNac, miembro.FechaExp, miembro.Carrera, miembro.Facultad, miembro.Genero, miembro.Interno, miembro.Colaborador, miembro.Cargo);
            _idUsuario = idUsuario;
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); 
        }

        private void Editar_Miembros_Load(object sender, EventArgs e)
        {
          
            LlenarFacultades();

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

            ObtenerCarrerasPorFacultad(miembrito.Facultad ?? 0);

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
                    connectionFacultades.Close();
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

            lblFacultad.Visible = chkEstudiante.Checked;
            cmbFacultad.Visible = chkEstudiante.Checked;
            lblCarrera.Visible = chkEstudiante.Checked;
            cmbCarrera.Visible = chkEstudiante.Checked;
            lblCargo.Visible = chkColaborador.Checked;
            txtCargo.Visible = chkColaborador.Checked;

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
            int? carrera = null;
            int? facultad = null;
            string cargo = null;

            if (chkEstudiante.Checked)
            {
                carrera = string.IsNullOrWhiteSpace(cmbCarrera.SelectedValue?.ToString()) ? (int?)null : (int?)cmbCarrera.SelectedValue;
                facultad = string.IsNullOrWhiteSpace(cmbFacultad.SelectedValue?.ToString()) ? (int?)null : (int?)cmbFacultad.SelectedValue;
            }
            else if (chkColaborador.Checked)
            {
                cargo = string.IsNullOrWhiteSpace(txtCargo.Text) ? null : txtCargo.Text;
            }

            return new Miembro(
                idMiembro: 0,
                identificacion: string.IsNullOrWhiteSpace(txtIdentificacion.Text) ? null : txtIdentificacion.Text,
                cif: string.IsNullOrWhiteSpace(txtCIF.Text) ? null : txtCIF.Text,
                nombres: string.IsNullOrWhiteSpace(txtNombre.Text) ? null : txtNombre.Text,
                apellidos: string.IsNullOrWhiteSpace(txtApellidos.Text) ? null : txtApellidos.Text,
                fechaNac: dateNacimiento.Value,
                fechaExp: DateTime.Now,
                carrera: carrera,
                facultad: facultad,
                genero: chkMasculino.Checked,
                interno: chkEstudiante.Checked,
                colaborador: chkColaborador.Checked,
                cargo: cargo
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

                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("@idMiembroo", miembrito.IdMiembro);
                    command.Parameters.AddWithValue("@identificacion", string.IsNullOrWhiteSpace(miembroNuevo.Identificacion) ? (object)DBNull.Value : miembroNuevo.Identificacion);
                    command.Parameters.AddWithValue("@cif", string.IsNullOrWhiteSpace(miembroNuevo.CIF) ? (object)DBNull.Value : miembroNuevo.CIF);
                    command.Parameters.AddWithValue("@nombres", miembroNuevo.Nombres ?? string.Empty);
                    command.Parameters.AddWithValue("@apellidos", miembroNuevo.Apellidos ?? string.Empty);
                    command.Parameters.AddWithValue("@fechaNacimiento", miembroNuevo.FechaNac);
                    command.Parameters.AddWithValue("@fechaExp", miembroNuevo.FechaExp);
                    command.Parameters.AddWithValue("@carrera", miembroNuevo.Carrera ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@facultad", miembroNuevo.Facultad ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@genero", miembroNuevo.Genero);
                    command.Parameters.AddWithValue("@interno", miembroNuevo.Interno ? 1 : 0);
                    command.Parameters.AddWithValue("@colaborador", miembroNuevo.Colaborador ? 1 : 0);
                    command.Parameters.AddWithValue("@cargo", miembroNuevo.Colaborador ? (miembroNuevo.Cargo ?? string.Empty) : (object)DBNull.Value);

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Miembro actualizado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el miembro.");
                    }
                    connection.Close();
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

            bloqueandoEventos = true;

            lblCargo.Visible = false;
            txtCargo.Visible = false;
            lblFacultad.Visible = true;
            cmbFacultad.Visible = true;
            lblCarrera.Visible = true;
            cmbCarrera.Visible = true;

            chkColaborador.Checked = false;
            chkExterno.Checked = false;
            txtCargo.Text = "Estudiante";

            bloqueandoEventos = false;
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
            Miembros_Activos mimebrosForm  = new Miembros_Activos(_idUsuario);
            this.Hide();
            mimebrosForm.ShowDialog();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidacionLlenado())
            {
                try
                {
                    Miembro nuevoMiembro = CrearMiembro();
                    EditarMiembro(nuevoMiembro);

                    Miembros_Activos nuevoForm = new Miembros_Activos(_idUsuario);
                    this.Hide();
                    nuevoForm.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
