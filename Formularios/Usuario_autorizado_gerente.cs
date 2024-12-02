using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using JaguarGymApp_Preview.Servicios;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace JaguarGymApp_Preview.Formularios
{

    public partial class Usuario_autorizado_gerente : MaterialForm
    {
        int idMiembro;
        private MySqlConnection dataExtraccion;
        private MySqlConnection dataCarrera;




        public Usuario_autorizado_gerente(int IdMiembro)
        {
            ConexionBD connExtraccion = new ConexionBD();
            dataExtraccion = new MySqlConnection(connExtraccion.GetConnector());
            ConexionBD connCarrera = new ConexionBD();
            dataCarrera = new MySqlConnection(connCarrera.GetConnector());
            this.Resize += new System.EventHandler(this.Principal_Resize);
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            idMiembro = IdMiembro;
            
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
            ConseguirDataUsuario();
        }
        private string ConseguirCarrera (int idCarrera)
        {
            string NombreCarrera = "No se encontro carrera";
            string queryCarrera = "SELECT idCarrera, nombreCarrera FROM Carrera WHERE idCarrera = @Id ";

            try
            {
                MySqlCommand commandCarrera = new MySqlCommand(queryCarrera, dataCarrera);

                // Agregar parámetros
                commandCarrera.Parameters.AddWithValue("@Id", idCarrera);


                dataCarrera.Open();

                // Ejecutar la consulta
                MySqlDataReader readerCarrera = commandCarrera.ExecuteReader();

                if (readerCarrera.Read())
                {
                    // Extraer datos
                    int idCarreraBD = readerCarrera.GetInt32("idCarrera");
                     NombreCarrera = readerCarrera.GetString("nombreCarrera");
                   

                   
                    dataCarrera.Close();

                    return NombreCarrera;
                }
                else
                {
                    MessageBox.Show("No se encontró un miembro con la identificación o CIF ingresado.");
                    dataCarrera.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                dataCarrera.Close();
            }
            finally
            {


                dataCarrera.Close();

            }
            return NombreCarrera;
        }
        private void ConseguirDataUsuario()
        {
            string queryExtraccion = "SELECT idMiembro, nombres, apellidos, IdCarrera, fechaExp FROM Miembro WHERE idMiembro = @Id ";

            try
            {
                MySqlCommand commandExtraccion = new MySqlCommand(queryExtraccion, dataExtraccion);

                // Agregar parámetros
                commandExtraccion.Parameters.AddWithValue("@Id", idMiembro);
             

                dataExtraccion.Open();

                // Ejecutar la consulta
                MySqlDataReader readerExtraccion = commandExtraccion.ExecuteReader();

                if (readerExtraccion.Read())
                {
                    // Extraer datos
                    int idMiembroBD = readerExtraccion.GetInt32("idMiembro");
                    string nombres = readerExtraccion.GetString("nombres");
                    string apellidos = readerExtraccion.GetString("apellidos");
                    int idCarrera = readerExtraccion.GetInt32("idCarrera");
                    DateTime fecha = readerExtraccion.GetDateTime("fechaExp");

                   lbNombreAutorizado.Text = nombres;
                    lbApellidoAutorizado.Text = apellidos;
                   lbCarreraAutorizado.Text = ConseguirCarrera(idCarrera);
                   lbFechaDeVencimiento.Text = fecha.ToString();
                    dataExtraccion.Close();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se encontró un miembro con la identificación o CIF ingresado.");
                    dataExtraccion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                dataExtraccion.Close();
            }
            finally
            {
               
                
                 dataExtraccion.Close();
              
            }
        }

        private void Usuario_autorizado_gerente_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Usuario_autorizado_usuario formularioUsuarioAutorizado = new Usuario_autorizado_usuario();
            formularioUsuarioAutorizado.Show();
            this.Close();
        }

        private void pnSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbNombreAutorizado_Click(object sender, EventArgs e)
        {

        }
    }
}
