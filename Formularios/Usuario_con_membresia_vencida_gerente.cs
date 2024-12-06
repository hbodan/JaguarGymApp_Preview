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
using JaguarGymApp_Preview.Servicios;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace JaguarGymApp_Preview.Formularios
{
    public partial class Usuario_con_membresia_vencida_gerente : MaterialForm
    {

        int idMiembroo;
        private MySqlConnection dataExtraccionVencida;
        private MySqlConnection dataCarreraVencida;
        public Usuario_con_membresia_vencida_gerente(int IdMiembro)
        {
            ConexionBD connExtraccionVencida = new ConexionBD();
            dataExtraccionVencida = new MySqlConnection(connExtraccionVencida.GetConnector());
            ConexionBD connCarreraVencida = new ConexionBD();
            dataCarreraVencida = new MySqlConnection(connCarreraVencida.GetConnector());
            this.Resize += new System.EventHandler(this.Principal_Resize);
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            idMiembroo = IdMiembro;
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
            ConseguirDataUsuarioVencida();

        }
        private string ConseguirCarrera(int idCarrera)
        {
            string NombreCarrera = "No se encontro carrera";
            string queryCarreraVencida = "SELECT idCarrera, nombreCarrera FROM Carrera WHERE idCarrera = @Id ";

            try
            {
                MySqlCommand commandCarrera = new MySqlCommand(queryCarreraVencida, dataCarreraVencida);

                // Agregar parámetros
                commandCarrera.Parameters.AddWithValue("@Id", idCarrera);


                dataCarreraVencida.Open();

                // Ejecutar la consulta
                MySqlDataReader readerCarrera = commandCarrera.ExecuteReader();

                if (readerCarrera.Read())
                {
                    // Extraer datos
                    int idCarreraBD = readerCarrera.GetInt32("idCarrera");
                    NombreCarrera = readerCarrera.GetString("nombreCarrera");



                    dataCarreraVencida.Close();

                    return NombreCarrera;
                }
                else
                {
                    MessageBox.Show("No se encontró una carrera.");
                    dataCarreraVencida.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                dataCarreraVencida.Close();
            }
            finally
            {


                dataCarreraVencida.Close();

            }
            return NombreCarrera;
        }
        private void ConseguirDataUsuarioVencida()
        {
            string queryExtraccion = "SELECT idMiembro, nombres, apellidos, IdCarrera, fechaExp FROM Miembro WHERE idMiembro = @Id LIMIT 1";

            try
            {
                MySqlCommand commandExtraccion = new MySqlCommand(queryExtraccion, dataExtraccionVencida);

                // Agregar parámetros
                commandExtraccion.Parameters.AddWithValue("@Id", idMiembroo);


                dataExtraccionVencida.Open();

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

                    lbnombreCaducado.Text = nombres;
                    lbapellidoCaducado.Text = apellidos;
                    lbcarreraCaducado.Text = ConseguirCarrera(idCarrera);
                    lbfechadevencimientocaducado.Text = fecha.ToString();
                    dataExtraccionVencida.Close();


                }
                else
                {

                    dataExtraccionVencida.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                dataExtraccionVencida.Close();
            }
            finally
            {


                dataExtraccionVencida.Close();

            }
        }


        private void Usuario_con_membresia_vencida_gerente_Load(object sender, EventArgs e)
        {
            ConseguirDataUsuarioVencida();
            timer1.Start();
        }

        private void pnMembresiavencidagerente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); // Detenemos el timer después de que se dispara
            Escanea_tu_cedula_o_CIF pantallaDestino = new Escanea_tu_cedula_o_CIF(); // Reemplaza FormDestino con el nombre del formulario al que quieres redirigir
            this.Hide();
            pantallaDestino.ShowDialog();
            this.Close(); // Cierra la pantalla actual
        }

        private void pnSuperior_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
