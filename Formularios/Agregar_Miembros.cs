using JaguarGymApp_Preview.Estructuras;
using JaguarGymApp_Preview.Servicios;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace JaguarGymApp_Preview.Formularios
{

    public partial class Agregar_Miembros : MaterialForm
    {
        private MySqlConnection data;
        private bool bloqueandoEventos = false;
        public int _idUsuario;

        public Agregar_Miembros(int idUsuario)
        {
            ConexionBD conn = new ConexionBD();
            data = new MySqlConnection(conn.GetConnector());
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Principal_Resize);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            _idUsuario = idUsuario;
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); 
        }

        private void Agregar_Miembros_Load(object sender, EventArgs e)
        {
            LlenarFacultades();
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

            dateExpiracion.Value = DateTime.Now;
        }

        public DataTable ObtenerCarrerasPorFacultad(int idFacultad)
        {
            string query = "SELECT idCarrera, nombreCarrera FROM Carrera WHERE idFacultad = @idFacultad";

            try
            {
                ConexionBD conn = new ConexionBD();
                using (MySqlConnection connection = new MySqlConnection(conn.GetConnector()))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idFacultad", idFacultad);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable carreras = new DataTable();
                    adapter.Fill(carreras);
                    connection.Close();
                    return carreras;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener carreras: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void ToDataBase(Miembro miembro)
        {
            string query = @"INSERT INTO Miembro 
             (identificacion, cif, nombres, apellidos, fechaNacimiento, fechaExp, idcarrera, idfacultad, genero, interno, colaborador, cargo) 
             VALUES 
             (@identificacion, @cif, @nombres, @apellidos, @fechaNacimiento, @fechaExp, @idcarrera, @idfacultad, @genero, @interno, @colaborador, @cargo)";

            try
            {
                ConexionBD conn = new ConexionBD();
                using (MySqlConnection connection = new MySqlConnection(conn.GetConnector()))
                {
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@identificacion", string.IsNullOrWhiteSpace(miembro.Identificacion) ? (object)DBNull.Value : miembro.Identificacion);
                    command.Parameters.AddWithValue("@cif", string.IsNullOrWhiteSpace(miembro.CIF) ? (object)DBNull.Value : miembro.CIF);
                    command.Parameters.AddWithValue("@nombres", miembro.Nombres ?? string.Empty);
                    command.Parameters.AddWithValue("@apellidos", miembro.Apellidos ?? string.Empty);
                    command.Parameters.AddWithValue("@fechaNacimiento", miembro.FechaNac);
                    command.Parameters.AddWithValue("@fechaExp", miembro.FechaExp);
                    command.Parameters.AddWithValue("@idcarrera", miembro.Carrera);
                    command.Parameters.AddWithValue("@idfacultad", miembro.Facultad);
                    command.Parameters.AddWithValue("@genero", miembro.Genero);
                    command.Parameters.AddWithValue("@interno", miembro.Interno ? 1 : 0);
                    command.Parameters.AddWithValue("@colaborador", miembro.Colaborador ? 1 : 0);
                    command.Parameters.AddWithValue("@cargo", miembro.Colaborador ? miembro.Cargo ?? string.Empty : (object)DBNull.Value);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Miembro agregado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el miembro.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Miembro CrearMiembro()
        {
            int? carrera = null;
            int? facultad = null;
            string cargo = null;

            if (chkEstudiante.Checked)
            {
                carrera = int.Parse(cmbCarrera.SelectedValue.ToString());
                facultad = int.Parse(cmbFacultad.SelectedValue.ToString());
            }
            else if (chkColaborador.Checked)
            {
                cargo = string.IsNullOrWhiteSpace(txtCargo.Text) ? null : txtCargo.Text;
            }

            return new Miembro(
                idMiembro: 0,
                identificacion: string.IsNullOrWhiteSpace(txtidentificacion.Text) ? null : txtidentificacion.Text,
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

        private void AgregarMiembro()
        {
            if (ValidacionLlenado())
            {
                try
                {
                    Miembro nuevoMiembro = CrearMiembro();
                    ToDataBase(nuevoMiembro);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LinkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Miembros_Activos miembrosForm = new Miembros_Activos(_idUsuario);
            this.Hide();
            miembrosForm.ShowDialog();
            this.Close();
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidacionLlenado())
            {
                AgregarMiembro();
                Miembros_Activos miembrosForm = new Miembros_Activos(_idUsuario);
                this.Hide();
                miembrosForm.ShowDialog();
                this.Close();
            }
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
                    Console.WriteLine($"idFacultad seleccionada: {cmbFacultad.SelectedValue}");

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
            Console.WriteLine($"SelectedValue: {cmbFacultad.SelectedValue}");
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"idCarrera seleccionada: {cmbCarrera.SelectedValue}");
        }

    }
}
