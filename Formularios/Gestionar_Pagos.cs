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
using JaguarGymApp_Preview.Formularios;
using MaterialSkin;
using MaterialSkin.Controls;

namespace JaguarGymApp_Preview.Formularios
{
    public partial class Gestion_Pagos : MaterialForm
    {
        List<Pago> pagos;
        public Gestion_Pagos()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Principal_Resize);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;


            ActualizarData();
          
        }
        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
        }


        private void ActualizarData()
        {
            dgvPagos.DataSource = null;
            dgvPagos.DataSource = pagos;
        }

        private void ConteoPagos()
        {
            int TotalPagos = 0;
            foreach (var paguito in pagos)
            {
                TotalPagos++;
            }

            toolStripStatusLabel1.Text = $"Numero de Miembros activos: {TotalPagos}";
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int buscado = int.Parse(txtBuscar.Text);
            var resultados = pagos.Where(u => u.IdPago == buscado).ToList();

            dgvPagos.DataSource = null;
            dgvPagos.DataSource = resultados;

        }

        private void dgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ingresar_Pago nuevoFormulario = new Ingresar_Pago(pagos, this);
            nuevoFormulario.Show();
            this.Hide();

        }

        public void RecibirDatos(List<Pago> datosActualizados)
        {
            pagos = datosActualizados;
            this.Show();
            ActualizarData();
            ConteoPagos();
        }
        private void btnVerPagos_Click(object sender, EventArgs e)
        {

        }

        private void lblPagos_Click(object sender, EventArgs e)
        {

        }

        private void Pagos_Load(object sender, EventArgs e)
        {
             pagos = new List<Pago>
            {
                new Pago(1, "T12345", DateTime.Now, "Pago mensual de membresía", 100.00m, "Pago realizado en línea", 1),
                new Pago(2, "T12346", DateTime.Now, "Pago de sesión extra", 20.00m, "Pago realizado en gimnasio", 2),
                new Pago(3, "T12347", DateTime.Now, "Pago por clases grupales", 50.00m, "Pago realizado en efectivo", 3)
            };
            ActualizarData();
            ConteoPagos();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show($"Elemento seleccionado: {e.ClickedItem.Text}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es el monto total de todos los pagos registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LinkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Principal formularioPrincipal = new Principal();
            formularioPrincipal.Show();
            this.Hide();
        }
    }
}
