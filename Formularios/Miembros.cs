using JaguarGymApp_Preview.Estructuras;
using MaterialSkin.Controls;
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

namespace JaguarGymApp_Preview.Formularios
{
    public partial class Miembros : MaterialForm
    {
        List<Usuario> usuarios;
        public Miembros()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Principal_Resize);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;

            Actualizardata();
        }

         private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
        }

        private void Miembros_Load(object sender, EventArgs e)
        {
          
            usuarios = new List<Usuario>
            {
                new Usuario(1, "24010892", "Roberto Carlos","Lopez Ramirez","Ingenieria en Sistemas","FIA",true,false),
                new Usuario(2, "0011010059898J", "Carlos Alberto","Bonilla Mejia","Ingenieria en Sistemas","FIA",true,false),
                new Usuario(3, "0011203041023H", "Mari Auxiliadora","De Santa","Arquitectura","FIA",true,false)
            };
            Actualizardata();
            ConteoMiembros();
        }
        private void Actualizardata()
        {
            
            dgvMiembros.DataSource = null; 
            dgvMiembros.DataSource = usuarios;
        }
        private void ConteoMiembros()
        {
            int TotalMiembros = 0;
            foreach (var miembro in usuarios)
            {
                TotalMiembros++;
            }

            toolStripStatusLabel1.Text = $"Numero de Miembros activos: {TotalMiembros}"; 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar_Miembros formulario2 = new Agregar_Miembros(usuarios,this);
            formulario2.Show();
            this.Hide();
        }
        public void RecibirDatos(List<Usuario> datos)
        {
            usuarios = datos;
            this.Show();
            Actualizardata();
            ConteoMiembros();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var Buscado = txtBuscar.Text.ToLower();
            var resultados = usuarios.Where(u => u.Nombres.ToLower().Contains(Buscado)).ToList();
            dgvMiembros.DataSource = null;
            dgvMiembros.DataSource = resultados;

        }

        private void LinkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Solo pq si
            Principal formularioPrincipal = new Principal();
            formularioPrincipal.Show();
            this.Hide();
        }

        private void dgvMiembros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMiembros.ReadOnly = true;

        }
    }
}
