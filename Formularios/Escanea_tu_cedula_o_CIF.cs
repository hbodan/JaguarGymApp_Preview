using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JaguarGymApp_Preview.Servicios;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace JaguarGymApp_Preview.Formularios
{
    public partial class Escanea_tu_cedula_o_CIF : MaterialForm

    {

        private MySqlConnection dataidentificacion;


        public Escanea_tu_cedula_o_CIF()
        {

            ConexionBD conn1 = new ConexionBD();
            dataidentificacion = new MySqlConnection(conn1.GetConnector());


            this.Resize += new System.EventHandler(this.Principal_Resize);
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
        }

        private void guna2Button1_Click(object sender, EventArgs e) => RevisarIdentificacion();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inicio_Sesion formularioInicioSesion = new Inicio_Sesion();
            formularioInicioSesion.Show();
            this.Close();
        }

        private void Escanea_tu_cedula_o_CIF_Load(object sender, EventArgs e)
        {

        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void RevisarIdentificacion()
        {
            string identificacionIngresada = txtIdentificacion.Text;

            // Query actualizada para buscar por identificación o CIF
            string queryIdentificacion = "SELECT idMiembro FROM Miembro WHERE identificacion = @cedula OR cif = @cifingresada LIMIT 1";

            try
            {
                MySqlCommand commandIdentificacion = new MySqlCommand(queryIdentificacion, dataidentificacion);

                // Agregar parámetros para prevenir SQL Injection
                commandIdentificacion.Parameters.AddWithValue("@cedula", identificacionIngresada);
                commandIdentificacion.Parameters.AddWithValue("@cifingresada", identificacionIngresada);

                dataidentificacion.Open();

                // Ejecutar la consulta
                object resultadoIdentificacion = commandIdentificacion.ExecuteScalar();

                if (resultadoIdentificacion != null)
                {
                    // Si se encuentra un miembro, redirigir al formulario Usuario_autorizado_gerente
                    int idMiembro = Convert.ToInt32(resultadoIdentificacion);
                    dataidentificacion.Close();
                    Usuario_autorizado_gerente nuevoFormulario = new Usuario_autorizado_gerente(idMiembro);
                    nuevoFormulario.Show();

                    this.Hide();

                }
                else
                {
                    dataidentificacion.Close();
                    MessageBox.Show("No se encontró un miembro con la identificación o CIF ingresado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                dataidentificacion.Close();
            }
            finally
            {
               
                    dataidentificacion.Close();
   
            }
        }

    }

}


