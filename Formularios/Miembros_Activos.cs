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
    public partial class Miembros_Activos : MaterialForm
    {
        public int _idUsuario;

        public Miembros_Activos(int idUsuario)
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Principal_Resize);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            _idUsuario = idUsuario;
        }

        public void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720);
        }

        public void Miembros_Load(object sender, EventArgs e)
        {
            Actualizardata();
            ConteoMiembros();
        }

        public void Actualizardata()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(new ConexionBD().GetConnector()))
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                        m.idMiembro AS 'ID',
                        m.cif AS 'CIF', 
                        m.identificacion AS 'Identificación',
                        m.nombres AS 'Nombres',
                        m.apellidos AS 'Apellidos',
                        CASE 
                            WHEN m.genero = 1 THEN 'Masculino' 
                            ELSE 'Femenino' 
                        END AS 'Genero', 
                        m.fechaNacimiento AS 'Fecha de Nacimiento',
                        f.nombreFacultad AS 'Facultad',
                        c.nombreCarrera AS 'Carrera', 
                        m.fechaExp AS 'Membresia Expira', 
                        CASE 
                            WHEN m.interno = 1 THEN 'Sí' 
                            ELSE 'No' 
                        END AS 'Interno',
                        CASE 
                            WHEN m.colaborador = 1 THEN 'Sí' 
                            ELSE 'No' 
                        END AS 'Colaborador',
                        m.cargo AS 'Cargo'
                    FROM 
                        Miembro m
                    LEFT JOIN Facultad f ON m.idfacultad = f.idFacultad
                    LEFT JOIN Carrera c ON m.idcarrera = c.idCarrera;
                    ";
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

        public void ConteoMiembros()
        {
            try
            {
                ConexionBD conn = new ConexionBD();
                using (MySqlConnection connection = new MySqlConnection(conn.GetConnector()))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Miembro"; 

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        int totalMiembros = Convert.ToInt32(command.ExecuteScalar());
                        toolStripStatusLabel1.Text = $"Total de Miembros activos: {totalMiembros}";
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al contar los miembros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtroSeleccionado = cmbFiltro.SelectedItem.ToString();
            string criterioBusqueda = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(criterioBusqueda))
            {
                Actualizardata();
                return;
            }

            string query = "";

            switch (filtroSeleccionado)
            {
                case "Identificacion":
                    query = @"
                    SELECT 
                        m.idMiembro AS 'ID',
                        m.cif AS 'CIF', 
                        m.identificacion AS 'Identificación',
                        m.nombres AS 'Nombres',
                        m.apellidos AS 'Apellidos',
                        CASE 
                            WHEN m.genero = 1 THEN 'Masculino' 
                            ELSE 'Femenino' 
                        END AS 'Genero', 
                        m.fechaNacimiento AS 'Fecha de Nacimiento',
                        f.nombreFacultad AS 'Facultad',
                        c.nombreCarrera AS 'Carrera', 
                        m.fechaExp AS 'Membresia Expira', 
                        CASE 
                            WHEN m.interno = 1 THEN 'Sí' 
                            ELSE 'No' 
                        END AS 'Interno',
                        CASE 
                            WHEN m.colaborador = 1 THEN 'Sí' 
                            ELSE 'No' 
                        END AS 'Colaborador',
                        m.cargo AS 'Cargo'
                    FROM 
                        Miembro m
                    LEFT JOIN Facultad f ON m.idfacultad = f.idFacultad
                    LEFT JOIN Carrera c ON m.idcarrera = c.idCarrera
                    WHERE 
                        m.identificacion LIKE '%' + @criterio + '%';
                    ";
                    break;

                case "Nombre":
                    query = @"
                    SELECT 
                        m.idMiembro AS 'ID',
                        m.cif AS 'CIF', 
                        m.identificacion AS 'Identificación',
                        m.nombres AS 'Nombres',
                        m.apellidos AS 'Apellidos',
                        CASE 
                            WHEN m.genero = 1 THEN 'Masculino' 
                            ELSE 'Femenino' 
                        END AS 'Genero', 
                        m.fechaNacimiento AS 'Fecha de Nacimiento',
                        f.nombreFacultad AS 'Facultad',
                        c.nombreCarrera AS 'Carrera', 
                        m.fechaExp AS 'Membresia Expira', 
                        CASE 
                            WHEN m.interno = 1 THEN 'Sí' 
                            ELSE 'No' 
                        END AS 'Interno',
                        CASE 
                            WHEN m.colaborador = 1 THEN 'Sí' 
                            ELSE 'No' 
                        END AS 'Colaborador',
                        m.cargo AS 'Cargo'
                    FROM 
                        Miembro m
                    LEFT JOIN Facultad f ON m.idfacultad = f.idFacultad
                    LEFT JOIN Carrera c ON m.idcarrera = c.idCarrera
                    WHERE 
                        m.nombres LIKE '%' + @criterio + '%';
                    ";
                    break;

                case "Apellido":
                    query = @"
                    SELECT 
                        m.idMiembro AS 'ID',
                        m.cif AS 'CIF', 
                        m.identificacion AS 'Identificación',
                        m.nombres AS 'Nombres',
                        m.apellidos AS 'Apellidos',
                        CASE 
                            WHEN m.genero = 1 THEN 'Masculino' 
                            ELSE 'Femenino' 
                        END AS 'Genero', 
                        m.fechaNacimiento AS 'Fecha de Nacimiento',
                        f.nombreFacultad AS 'Facultad',
                        c.nombreCarrera AS 'Carrera', 
                        m.fechaExp AS 'Membresia Expira', 
                        CASE 
                            WHEN m.interno = 1 THEN 'Sí' 
                            ELSE 'No' 
                        END AS 'Interno',
                        CASE 
                            WHEN m.colaborador = 1 THEN 'Sí' 
                            ELSE 'No' 
                        END AS 'Colaborador',
                        m.cargo AS 'Cargo'
                    FROM 
                        Miembro m
                    LEFT JOIN Facultad f ON m.idfacultad = f.idFacultad
                    LEFT JOIN Carrera c ON m.idcarrera = c.idCarrera
                    WHERE 
                        m.apellidos LIKE '%' + @criterio + '%';
                    ";
                    break;

                case "Facultad":
                    query = @"
                    SELECT 
                        m.idMiembro AS 'ID',
                        m.cif AS 'CIF', 
                        m.identificacion AS 'Identificación',
                        m.nombres AS 'Nombres',
                        m.apellidos AS 'Apellidos',
                        CASE 
                            WHEN m.genero = 1 THEN 'Masculino' 
                            ELSE 'Femenino' 
                        END AS 'Genero', 
                        m.fechaNacimiento AS 'Fecha de Nacimiento',
                        f.nombreFacultad AS 'Facultad',
                        c.nombreCarrera AS 'Carrera', 
                        m.fechaExp AS 'Membresia Expira', 
                        CASE 
                            WHEN m.interno = 1 THEN 'Sí' 
                            ELSE 'No' 
                        END AS 'Interno',
                        CASE 
                            WHEN m.colaborador = 1 THEN 'Sí' 
                            ELSE 'No' 
                        END AS 'Colaborador',
                        m.cargo AS 'Cargo'
                    FROM 
                        Miembro m
                    LEFT JOIN Facultad f ON m.idfacultad = f.idFacultad
                    LEFT JOIN Carrera c ON m.idcarrera = c.idCarrera
                    WHERE 
                        f.nombreFacultad LIKE '%' + @criterio + '%';
                    ";
                    break;

                case "Carrera":
                    query = @"
                    SELECT 
                        m.idMiembro AS 'ID',
                        m.cif AS 'CIF', 
                        m.identificacion AS 'Identificación',
                        m.nombres AS 'Nombres',
                        m.apellidos AS 'Apellidos',
                        CASE 
                            WHEN m.genero = 1 THEN 'Masculino' 
                            ELSE 'Femenino' 
                        END AS 'Genero', 
                        m.fechaNacimiento AS 'Fecha de Nacimiento',
                        f.nombreFacultad AS 'Facultad',
                        c.nombreCarrera AS 'Carrera', 
                        m.fechaExp AS 'Membresia Expira', 
                        CASE 
                            WHEN m.interno = 1 THEN 'Sí' 
                            ELSE 'No' 
                        END AS 'Interno',
                        CASE 
                            WHEN m.colaborador = 1 THEN 'Sí' 
                            ELSE 'No' 
                        END AS 'Colaborador',
                        m.cargo AS 'Cargo'
                    FROM 
                        Miembro m
                    LEFT JOIN Facultad f ON m.idfacultad = f.idFacultad
                    LEFT JOIN Carrera c ON m.idcarrera = c.idCarrera
                    WHERE 
                        c.nombreCarrera LIKE '%' + @criterio + '%';
                    ";
                    break;

                case "Género":
                    query = @"
                    SELECT 
                        m.idMiembro AS 'ID',
                        m.cif AS 'CIF', 
                        m.identificacion AS 'Identificación',
                        m.nombres AS 'Nombres',
                        m.apellidos AS 'Apellidos',
                        CASE 
                            WHEN m.genero = 1 THEN 'Masculino' 
                            ELSE 'Femenino' 
                        END AS 'Genero', 
                        m.fechaNacimiento AS 'Fecha de Nacimiento',
                        f.nombreFacultad AS 'Facultad',
                        c.nombreCarrera AS 'Carrera', 
                        m.fechaExp AS 'Membresia Expira', 
                        CASE 
                            WHEN m.interno = 1 THEN 'Sí' 
                            ELSE 'No' 
                        END AS 'Interno',
                        CASE 
                            WHEN m.colaborador = 1 THEN 'Sí' 
                            ELSE 'No' 
                        END AS 'Colaborador',
                        m.cargo AS 'Cargo'
                    FROM 
                        Miembro m
                    LEFT JOIN Facultad f ON m.idfacultad = f.idFacultad
                    LEFT JOIN Carrera c ON m.idcarrera = c.idCarrera
                    WHERE 
                        m.genero LIKE '%' + @criterio + '%';
                    ";
                    break;

                default:
                    MessageBox.Show("Filtro no válido seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

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

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar_Miembros formulario2 = new Agregar_Miembros(_idUsuario);
            this.Hide();
            formulario2.ShowDialog();
            this.Close();
        }

        public void LinkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Principal formularioPrincipal = new Principal(_idUsuario);
            this.Hide();
            formularioPrincipal.ShowDialog();
            this.Close();
        }


        private Miembro ObtenerDatosMiembroPorId(int idMiembroo)
        {
            Miembro miembro = null;
            string query = @"
            SELECT * 
            FROM Miembro 
            WHERE idMiembro = @idMiembro;";

            try
            {
                ConexionBD conn = new ConexionBD();
                using (MySqlConnection connection = new MySqlConnection(conn.GetConnector()))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idMiembro", idMiembroo);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            miembro = new Miembro
                            {
                                IdMiembro = reader["idMiembro"] != DBNull.Value ? Convert.ToInt32(reader["idMiembro"]) : 0,
                                Identificacion = reader["identificacion"] != DBNull.Value ? reader["identificacion"].ToString() : string.Empty,
                                CIF = reader["cif"] != DBNull.Value ? reader["cif"].ToString() : string.Empty,
                                Nombres = reader["nombres"] != DBNull.Value ? reader["nombres"].ToString() : string.Empty,
                                Apellidos = reader["apellidos"] != DBNull.Value ? reader["apellidos"].ToString() : string.Empty,
                                FechaNac = reader["fechaNacimiento"] != DBNull.Value ? Convert.ToDateTime(reader["fechaNacimiento"]) : DateTime.MinValue,
                                FechaExp = reader["fechaExp"] != DBNull.Value ? Convert.ToDateTime(reader["fechaExp"]) : DateTime.MinValue,
                                Carrera = reader["idCarrera"] != DBNull.Value ? Convert.ToInt32(reader["idCarrera"]) : 0,
                                Facultad = reader["idFacultad"] != DBNull.Value ? Convert.ToInt32(reader["idFacultad"]) : 0,
                                Genero = reader["genero"] != DBNull.Value ? Convert.ToBoolean(reader["genero"]) : false,
                                Interno = reader["interno"] != DBNull.Value ? Convert.ToBoolean(reader["interno"]) : false,
                                Colaborador = reader["colaborador"] != DBNull.Value ? Convert.ToBoolean(reader["colaborador"]) : false,
                                Cargo = reader["cargo"] != DBNull.Value ? reader["cargo"].ToString() : string.Empty
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos del miembro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return miembro;
        }


        public void dgvMiembros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
      
                int idMiembro = Convert.ToInt32(dgvMiembros.Rows[e.RowIndex].Cells["ID"].Value);
                DataGridViewRow filaSeleccionada = dgvMiembros.Rows[e.RowIndex];
                Miembro miembroSeleccionado = ObtenerDatosMiembroPorId(idMiembro);

                if (miembroSeleccionado != null)
                {

                    Editar_Miembros editarMiembrosForm = new Editar_Miembros(miembroSeleccionado, _idUsuario);
                    this.Hide();
                    editarMiembrosForm.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
