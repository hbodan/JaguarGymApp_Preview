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
using MaterialSkin.Controls;
using JaguarGymApp_Preview.Estructuras;
using Guna.UI2.WinForms.Enums;
using JaguarGymApp_Preview.Formularios;
using System.Web;
using System.Xml.Serialization;
using MySql.Data.MySqlClient;
using JaguarGymApp_Preview.Servicios;
using System.Data.SqlClient;
using static JaguarGymApp_Preview.Formularios.Agregar_Miembros;

namespace JaguarGymApp_Preview.Formularios
{
    
    public partial class Agregar_Miembros : MaterialForm
    {
        private MySqlConnection data;
        List<Miembro> miembrosRecibidos;
        private Miembros_Activos formularioAnterior;
        
        public Agregar_Miembros(List<Miembro> lista,Miembros_Activos formulario)
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
        public class ConexionBD
        {
            string server = "localhost";
            string database = "jaguarGym";
            string username = "root";
            string password = "";

            public ConexionBD()
            {
            }

            public string GetConnector()
            {
                string connectionString = $"Server={this.server}; database={this.database}; UID={this.username}; password={this.password};";

                return connectionString;
            }
        }
        

        public DataTable ObtenerCarrerasPorFacultad(int idFacultad)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idCarrera, nombreCarrera FROM Carrera WHERE idFacultad = @idFacultad";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idFacultad", idFacultad);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable carreras = new DataTable();
                adapter.Fill(carreras);
                return carreras;
            }
        }
}


        private void ToDataBase(Miembro miembro)
        {
            string query = @"INSERT INTO Miembros 
                     (identificacion, cif, nombres, apellidos, fechaNacimiento, fechaExp, idcarrera, idfacultad, genero, interno, colaborador, cargo) 
                     VALUES 
                     (@identificacion, @cif, @nombres, @apellidos, @fechaNacimiento, @fechaExp, @idcarrera, @idfacultad, @genero, @interno, @colaborador, @cargo)";

            try
            {
                ConexionBD conn = new ConexionBD();
                using (SqlConnection connection = new SqlConnection(conn.GetConnector()))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@identificacion", miembro.Identificacion);
                    command.Parameters.AddWithValue("@cif", miembro.CIF);
                    command.Parameters.AddWithValue("@nombre", miembro.Nombres);
                    command.Parameters.AddWithValue("@apellidos", miembro.Apellidos);
                    command.Parameters.AddWithValue("@fechaNacimiento", miembro.FechaNac);
                    command.Parameters.AddWithValue("@fechaExp", miembro.FechaExp);
                    command.Parameters.AddWithValue("@idcarrera", miembro.Carrera);
                    command.Parameters.AddWithValue("@idfacultad", miembro.Facultad);
                    command.Parameters.AddWithValue("@genero", miembro.Genero);
                    command.Parameters.AddWithValue("@interno", miembro.Interno);
                    command.Parameters.AddWithValue("@colaborador", miembro.Colaborador);
                    command.Parameters.AddWithValue("@cargo", miembro.Cargo);

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
        private DataHelper dataHelper = new DataHelper();

        private void Agregar_Miembros_Load(object sender, EventArgs e)
        {
            DataTable facultades = dataHelper.ObtenerFacultades();

            cmbFacultad.DataSource = facultades;
            cmbFacultad.DisplayMember = "nombreFacultad";
            cmbFacultad.ValueMember = "idFacultad";

        }
        private Miembro CrearMiembro()
        {
            return new Miembro(
                0,
                txtidentificacion.Text,
                txtCIF.Text,
                txtNombre.Text,
                txtApellidos.Text,
                dateNacimiento.Value,
                dateExpiracion.Value,
                cmbCarrera.Text,
                cmbFacultad.Text,
                chkMasculino.Checked,
                chkEstudiante.Checked,
                chkColaborador.Checked,
                txtCargo.Text
                
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
                    miembrosRecibidos.Add(nuevoMiembro);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidacionLlenado())
            {
                AgregarMiembro();
                formularioAnterior.RecibirDatos(miembrosRecibidos);
                this.Close();
            }
        }

        private void linkSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        private bool ValidacionLlenado()
        {
            if (string.IsNullOrEmpty(txtidentificacion.Text))
            {
                MessageBox.Show("El campo Identificación no puede estar vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtCIF.Text))
            {
                MessageBox.Show("El campo CIF no puede estar vacío", "Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            // Validar campo de Cargo si es colaborador
            if (chkColaborador.Checked && string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                MessageBox.Show("Debe ingresar un Cargo si selecciona Colaborador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void chkEstudiante_CheckedChanged(object sender, EventArgs e) //Hacer que se muestren los comboBox si estudiante es seleccionado
        {
            bool Seleccionado = chkEstudiante.Checked;

            lblFacultad.Visible = Seleccionado;
            cmbFacultad.Visible = Seleccionado;
            lblCarrera.Visible = Seleccionado;
            cmbCarrera.Visible = Seleccionado;
            chkColaborador.Checked = false;
        }

        private void chkColaborador_CheckedChanged(object sender, EventArgs e) //Hacerque se muestre el campo "Cargo" si Colaborador es seleccionado
        { 
            bool Seleccionado = chkColaborador.Checked;

            lblCargo.Visible = Seleccionado;
            txtCargo.Visible = Seleccionado;
            chkEstudiante.Checked = false;
        }

        private void cmbFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFacultad.SelectedValue != null)
            {
                int idFacultadSeleccionada = Convert.ToInt32(cmbFacultad.SelectedValue);

                DataTable carreras = dataHelper.ObtenerCarrerasPorFacultad(idFacultadSeleccionada);

                cmbFacultad.DataSource = carreras;
                cmbCarrera.DisplayMember = "nombreCarrera";
                cmbCarrera.ValueMember = "idCarrera";
            }
        }

        private void dateNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
