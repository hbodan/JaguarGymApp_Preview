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
using estadisticasForm;


namespace JaguarGymApp_Preview.Formularios
{
    public partial class Ingresar_Pago : MaterialForm
    {
        // Lista para almacenar los pagos ingresados
        private List<Pago> pagosRecibidos;
        private Gestion_Pagos formularioAnterior;

        public Ingresar_Pago(List<Pago> lista, Gestion_Pagos formulario)
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Principal_Resize);
         
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.pagosRecibidos = lista;
            this.formularioAnterior = formulario;

        }
        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
        }

        private void Ingresar_Pago_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarPago()
        { 
            int idPago = int.Parse(txtIdPago.Text);
            string idTransaccion = txtIdTransaccion.Text;
            DateTime fechaRealizacion = DateTime.Parse(txtFechaRealizacion.Text);
            string descripcion = txtDescripcion.Text;
            decimal monto = decimal.Parse(txtMonto.Text);
            string observacion = txtObservacion.Text;
            int idMiembro = int.Parse(txtIdMiembro.Text);


            pagosRecibidos.Add(new Pago(idPago, idTransaccion, fechaRealizacion, descripcion, monto, observacion, idMiembro));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPago();
            LimpiarCampos();
            formularioAnterior.RecibirDatos(pagosRecibidos);
            this.Close();
        }
        private void LimpiarCampos()
        {
            txtIdPago.Text = "";
            txtIdTransaccion.Text = "";
            txtFechaRealizacion.Text = "";
            txtDescripcion.Text = "";
            txtMonto.Text = "";
            txtObservacion.Text = "";
            txtIdMiembro.Text = "";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCarrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LinkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formularioAnterior.RecibirDatos(pagosRecibidos);
            this.Close();
        }

        private void txtIdPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdTransaccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaRealizacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdMiembro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
