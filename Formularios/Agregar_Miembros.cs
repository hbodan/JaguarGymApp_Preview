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
        List<Miembro> miembrosRecibidos;
        private Miembros_Activos formularioAnterior;

        public Agregar_Miembros(List<Miembro> lista, Miembros_Activos formulario)
        {
            ConexionBD conn = new ConexionBD();
            data = new MySqlConnection(conn.GetConnector());
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Principal_Resize);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.miembrosRecibidos = lista;
            this.formularioAnterior = formulario;

        }
        public class DataHelper
        {
            ConexionBD connectionString = new ConexionBD();

            public DataTable ObtenerFacultades()
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString.GetConnector()))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT idFacultad, nombreFacultad FROM Facultad";

                        // Crear el comando
                        MySqlCommand command = new MySqlCommand(query, connection);

                        // Usar MySqlDataAdapter para llenar el DataTable
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable facultades = new DataTable();
                        adapter.Fill(facultades);

                        return facultades;
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        throw new Exception($"Error al obtener facultades: {ex.Message}");
                    }
                }
            }
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

                    // Validar datos antes de asignar
                    command.Parameters.AddWithValue("@identificacion", miembro.Identificacion ?? string.Empty);
                    command.Parameters.AddWithValue("@cif", miembro.CIF ?? string.Empty);
                    command.Parameters.AddWithValue("@nombres", miembro.Nombres ?? string.Empty);
                    command.Parameters.AddWithValue("@apellidos", miembro.Apellidos ?? string.Empty);
                    command.Parameters.AddWithValue("@fechaNacimiento", miembro.FechaNac);
                    command.Parameters.AddWithValue("@fechaExp", miembro.FechaExp);
                    command.Parameters.AddWithValue("@idcarrera", miembro.Carrera);
                    command.Parameters.AddWithValue("@idfacultad", miembro.Facultad);
                    command.Parameters.AddWithValue("@genero", miembro.Genero);
                    command.Parameters.AddWithValue("@interno", miembro.Interno ? 1 : 0);
                    command.Parameters.AddWithValue("@colaborador", miembro.Colaborador ? 1 : 0);
                    command.Parameters.AddWithValue("@cargo", miembro.Cargo ?? string.Empty);

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


        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
        }


        private void Agregar_Miembros_Load(object sender, EventArgs e)
        {
            ConexionBD conn = new ConexionBD();

            string query = "SELECT idFacultad, nombreFacultad FROM Facultad";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(conn.GetConnector()))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                    DataTable facultades = new DataTable();
                    adapter.Fill(facultades);

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

        private Miembro CrearMiembro()
        {
            return new Miembro(
                idMiembro: 0, // Valor autogenerado
                identificacion: string.IsNullOrWhiteSpace(txtidentificacion.Text) ? null : txtidentificacion.Text,
                cif: string.IsNullOrWhiteSpace(txtCIF.Text) ? null : txtCIF.Text,
                nombres: string.IsNullOrWhiteSpace(txtNombre.Text) ? null : txtNombre.Text,
                apellidos: string.IsNullOrWhiteSpace(txtApellidos.Text) ? null : txtApellidos.Text,
                fechaNac: dateNacimiento.Value,
                fechaExp: DateTime.Now,
                carrera: int.Parse(cmbCarrera.SelectedValue.ToString()),
                facultad: int.Parse(cmbFacultad.SelectedValue.ToString()),
                genero: chkMasculino.Checked,
                interno: chkEstudiante.Checked,
                colaborador: chkColaborador.Checked,
                cargo: string.IsNullOrWhiteSpace(txtCargo.Text) ? null : txtCargo.Text  
            );
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
            formularioAnterior.RecibirDatos(miembrosRecibidos);
            this.Close();
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidacionLlenado())
            {
                AgregarMiembro(); // Método existente para agregar un nuevo miembro
                formularioAnterior.RecargarMiembros(); // Método en el formulario padre para recargar los datos
                this.Close();
            }
        }


        private void linkSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        public bool ValidacionLlenado()
        {
            if (string.IsNullOrEmpty(txtidentificacion.Text))
            {
                MessageBox.Show("El campo Identificación no puede estar vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtCIF.Text))
            {
                MessageBox.Show("El campo CIF no puede estar vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            if (!chkEstudiante.Checked && !chkColaborador.Checked)
            {
                MessageBox.Show("Debe seleccionar si el miembro es estudiante o colaborador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            bool seleccionado = chkEstudiante.Checked;

            // Mostrar/ocultar controles relacionados con "Estudiante"
            lblFacultad.Visible = seleccionado;
            cmbFacultad.Visible = seleccionado;
            lblCarrera.Visible = seleccionado;
            cmbCarrera.Visible = seleccionado;

            // Limpiar los campos de "Colaborador" y llenar el cargo como "Estudiante"
            if (seleccionado)
            {
                chkColaborador.Checked = false;
                txtCargo.Text = "Estudiante"; // Asignar "Estudiante" como cargo
            }
        }


        private void chkColaborador_CheckedChanged(object sender, EventArgs e)
        {
            bool seleccionado = chkColaborador.Checked;


            lblCargo.Visible = seleccionado;
            txtCargo.Visible = seleccionado;


            if (seleccionado)
            {
                chkEstudiante.Checked = false;
                txtCargo.Text = "";
            }
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

        private void LinkAtras_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formularioAnterior.RecibirDatos(miembrosRecibidos);
            this.Close();
        }

        private void lblApellidos_Click(object sender, EventArgs e)
        {

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
            Console.WriteLine($"SelectedValue: {cmbFacultad.SelectedValue}");
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"idCarrera seleccionada: {cmbCarrera.SelectedValue}");
        }
    }
}
