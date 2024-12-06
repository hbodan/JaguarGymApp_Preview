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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RevisarMembresia();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inicio_Sesion formularioInicioSesion = new Inicio_Sesion();
            this.Hide();
            formularioInicioSesion.ShowDialog();
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

        private void RevisarMembresia()
        {
            string identificacionIngresada = txtIdentificacion.Text;
            string queryValidacion = "SELECT idMiembro, nombres, fechaExp  FROM Miembro WHERE identificacion = @cedula OR cif = @cifingresada";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(new ConexionBD().GetConnector()))
                {
                    MySqlCommand command = new MySqlCommand(queryValidacion, conexion);
                    command.Parameters.AddWithValue("@cedula", identificacionIngresada);
                    command.Parameters.AddWithValue("@cifingresada", identificacionIngresada);

                    conexion.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Extraer datos del miembro
                            int idMiembro = reader.GetInt32("idMiembro");
                            string nombre = reader.GetString("nombres");
                            DateTime fechaExpiracion = reader.GetDateTime("fechaExp");

                            // Verificar estado de membresía
                            if (fechaExpiracion < DateTime.Now)
                            {
                                // Membresía caducada
                                this.Hide();
                                Usuario_con_membresia_vencida_gerente formularioVencido = new Usuario_con_membresia_vencida_gerente(idMiembro);
                                formularioVencido.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                // Membresía vigente
                                this.Hide();
                                Usuario_autorizado_gerente formularioVigente = new Usuario_autorizado_gerente(idMiembro);
                                formularioVigente.ShowDialog();
                                this.Close();
                            }
                        }
                        else
                        {
                            // No encontrado
                            this.Hide();
                            Usuario_no_registrado_gerente formularioSinregistro = new Usuario_no_registrado_gerente();
                            formularioSinregistro.ShowDialog();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos: " + ex.Message);
            }
        }
    }
}
   


