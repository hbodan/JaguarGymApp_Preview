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

namespace JaguarGymApp_Preview.Formularios
{
    public partial class Editar_Miembros : MaterialForm
    {
        private MySqlConnection data;
        public Miembro miembrito;
        
        List<Miembro> miembrosRecibidos;
        private Miembros_Activos formularioAnterior;
        private Miembro miembroActual;
        public Editar_Miembros(Miembro miembro, Miembros_Activos formulario)
        {
            ConexionBD conn = new ConexionBD();
            data = new MySqlConnection(conn.GetConnector());
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Principal_Resize);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.formularioAnterior = formulario;
            miembrito = new Miembro(miembro.IdMiembro, miembro.Identificacion, miembro.CIF, miembro.Nombres, miembro.Apellidos, miembro.FechaNac, miembro.FechaExp, miembro.Carrera, miembro.Facultad, miembro.Genero, miembro.Interno, miembro.Colaborador, miembro.Cargo);
        }
        public DataTable ObtenerFacultades()
        {
            ConexionBD connectionString = new ConexionBD();
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
                    connection.Close();
                    return facultades;
                    
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    throw new Exception($"Error al obtener facultades: {ex.Message}");
                }
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


        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
        }

        private void Editar_Miembros_Load(object sender, EventArgs e)
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

            string valores = $@"
                idMiembro: {miembrito.IdMiembro}
                identificacion: {txtidentificacion.Text}
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

            ObtenerCarrerasPorFacultad(miembrito.Facultad);
            CargarDatosMiembro(miembrito.Identificacion, miembrito.CIF, miembrito.Nombres, miembrito.Apellidos, miembrito.FechaNac, miembrito.FechaExp, miembrito.Carrera, miembrito.Facultad, miembrito.Genero, miembrito.Interno, miembrito.Colaborador, miembrito.Cargo);
        }
       

        public void CargarDatosMiembro(string identificacion,string cif,string nombres,string apellidos,DateTime fechaNacimiento,DateTime fechaExp,int carrera,int facultad,bool genero,bool interno,bool colaborador,string cargo)
        {
            txtidentificacion.Text = identificacion;
            txtCIF.Text = cif;
            txtNombre.Text = nombres;
            txtApellidos.Text = apellidos;
            dateNacimiento.Value = fechaNacimiento;
            dateExpiracion.Value = fechaExp;
            cmbCarrera.SelectedValue = carrera;
            cmbFacultad.SelectedValue = facultad;
            chkMasculino.Checked = genero;
            chkEstudiante.Checked = interno && !colaborador;
            chkColaborador.Checked = colaborador;
            txtCargo.Text = cargo;

            // Ajustar visibilidad según el rol
            lblFacultad.Visible = chkEstudiante.Checked;
            cmbFacultad.Visible = chkEstudiante.Checked;
            lblCarrera.Visible = chkEstudiante.Checked;
            cmbCarrera.Visible = chkEstudiante.Checked;
            lblCargo.Visible = chkColaborador.Checked;
            txtCargo.Visible = chkColaborador.Checked;
        }


        public void EditarMiembro()
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
            idcarrera = @carrera,
            idfacultad = @facultad,
            genero = @genero,
            interno = @interno,
            colaborador = @colaborador,
            cargo = @cargo
        WHERE idMiembro = @idMiembroo";

            try
            {
                ConexionBD conn = new ConexionBD();

                                string valores = $@"
                idMiembro: {miembrito.IdMiembro}
                identificacion: {txtidentificacion.Text}
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

                // Imprimir en consola
                Console.WriteLine(valores);

                using (MySqlConnection connection = new MySqlConnection(conn.GetConnector()))
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idMiembroo", miembrito.IdMiembro);
                    command.Parameters.AddWithValue("@identificacion", txtidentificacion.Text);
                    command.Parameters.AddWithValue("@cif", txtCIF.Text);
                    command.Parameters.AddWithValue("@nombres", txtNombre.Text);
                    command.Parameters.AddWithValue("@apellidos", txtApellidos.Text);
                    command.Parameters.AddWithValue("@fechaNacimiento", dateNacimiento.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@fechaExp", dateExpiracion.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@carrera", int.Parse(cmbCarrera.ValueMember));
                    command.Parameters.AddWithValue("@facultad", int.Parse(cmbFacultad.ValueMember));
                    command.Parameters.AddWithValue("@genero", chkMasculino.Checked ? true : false);
                    command.Parameters.AddWithValue("@interno", chkEstudiante.Checked ? true : false);
                    command.Parameters.AddWithValue("@colaborador", chkColaborador.Checked ? true : false);
                    command.Parameters.AddWithValue("@cargo", txtCargo.Text);

                    connection.Open();

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

            // Mostrar/ocultar controles relacionados con "Colaborador"
            lblCargo.Visible = seleccionado;
            txtCargo.Visible = seleccionado;

            // Limpiar y ocultar Facultad y Carrera si se selecciona "Colaborador"
            if (seleccionado)
            {
                cmbFacultad.SelectedIndex = -1; // Limpiar selección de Facultad
                cmbCarrera.DataSource = null;  // Limpiar las carreras cargadas
                chkEstudiante.Checked = false;
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

            Console.WriteLine($"idFacultad seleccionada: {cmbFacultad.SelectedValue}");
            
            
        }

        private void LinkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formularioAnterior.RecibirDatos(miembrosRecibidos);
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidacionLlenado())
            {
                EditarMiembro();
                formularioAnterior.RecibirDatos(miembrosRecibidos);
                this.Close();
            }
        }
    }
}
