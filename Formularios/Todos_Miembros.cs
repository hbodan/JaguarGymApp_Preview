using JaguarGymApp_Preview.Estructuras;
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
using System.IO;
using estadisticasForm;

namespace JaguarGymApp_Preview.Formularios
{
    public partial class Todos_Miembros : MaterialForm
    {
        private List<Usuario> miembrosRecibidos;
        private Miembros formularioAnterior;
        private const string ArchivomiembrosRecibidos = "Miembros.bin";
        public Todos_Miembros()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Principal_Resize);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;

            Actualizardata();
            ConteoMiembros();
        }
        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
        }
        private void Actualizardata()
        {

            dgvTodosMiembros.DataSource = null;
            dgvTodosMiembros.DataSource = ArchivomiembrosRecibidos;
        }
        private void CargarMiembros()
        {
            
        
            if (!File.Exists(ArchivomiembrosRecibidos))
            {
                MessageBox.Show("No hay miembros para mostrar","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            using (BinaryReader reader = new BinaryReader(File.Open(ArchivomiembrosRecibidos, FileMode.Open)))
            {
                
                try
                {
                    while (true)
                    {
                        /*Miembros miembro = new Miembros()
                        {
                            IdMiembro = reader.ReadInt32(),
                            Identificacion = reader.ReadInt32(),
                            Nombres = reader.ReadString(),
                            Apellidos = reader.ReadString(),
                            FechaNac = reader.ReadString(),
                        };*/
                        //Llenar con los datos de Miembros con fecha de expiracion para mostar en formulario de Todos Los miembros @Marie :)
                    }
                }
                catch (EndOfStreamException) { }
            }
        }

        private void ConteoMiembros()
        {
            int TotalMiembros = 0;
            foreach (var miembro in ArchivomiembrosRecibidos)
            {
                TotalMiembros++;
            }

            toolStripStatusLabel1.Text = $"Numero Total de Miembros: {TotalMiembros}";
        }

        private void Todos_Miembros_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMiembrosActivos_Click(object sender, EventArgs e)
        {

        }
    }
}
