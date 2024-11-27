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

namespace JaguarGymApp_Preview.Formularios
{
    public partial class Agregar_Miembros : MaterialForm
    {
        List<Usuario> miembrosRecibidos;
        private Miembros formularioAnterior;
        
        public Agregar_Miembros(List<Usuario> lista,Miembros formulario)
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Principal_Resize);


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal300, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.miembrosRecibidos = lista;
            this.formularioAnterior = formulario;

        }
        Dictionary<string, List<string>> facultades = new Dictionary<string, List<string>>()
        {
            { "Ciencias Administrativas y Económicas", new List<string>{"Administración de Empresas","Negocios Internacioles","Economía Empresarial","Contabilidad y Finanzas" } },
            { "Ciencias Jurídicas, Humanidades y Relaciones Internacionales", new List<string>{"Derecho","Diplomacia y Relaciones Internacionales" } },
            { "Ciencias Médicas", new List<string>{"Medicina","Psicología" } },
            { "Ingeniería y Arquitectura", new List<string>{"Ingeniería en Sistemas de Información","Ingeniería Indsutrial","Ingeniería Civil","Arquitectura" } },
            { "Marketing, Diseño y Ciencias de la Comunicación", new List<string>{"Marketing y Publicidad","Diseño y Comunicación Visual","Comunicación y Realaciones Públicas" } },
            { "Odontología", new List<string>{"Odontología" } }

        };
        
        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1080, 720); // Mantener el tamaño de la ventana fijo
        }

        private void Agregar_Miembros_Load(object sender, EventArgs e)
        {
            CrearID();
            cmbFacultad.Items.AddRange(facultades.Keys.ToArray());
        }

        private void CrearID() //Crea una id consecutiva por cada usuario registrado
        {
            int IdCreada = miembrosRecibidos.Count + 1;
            txtId.Text = IdCreada.ToString();
        }
        private Usuario CrearUsuario()
        {
            return new Usuario(
                int.Parse(txtId.Text),
                txtidentificacion.Text,
                txtNombre.Text,
                txtApellidos.Text,
                cmbCarrera.Text,
                cmbFacultad.Text,
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
                    Usuario nuevoMiembro = CrearUsuario();
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
        }

        private void chkColaborador_CheckedChanged(object sender, EventArgs e) //Hacerque se muestre el campo "Cargo" si Colaborador es seleccionado
        { 
            bool Seleccionado = chkColaborador.Checked;

            lblCargo.Visible = Seleccionado;
            txtCargo.Visible = Seleccionado;
        }

        private void cmbFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCarrera.Items.Clear();
            string facultad = cmbFacultad.SelectedItem as string;

            if (facultades.ContainsKey(facultad))
            {
                cmbCarrera.Items.AddRange(facultades[facultad].ToArray());
            }
        }
    }
}
