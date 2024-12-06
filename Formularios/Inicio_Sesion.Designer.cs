using System;
using System.Windows.Forms;

namespace JaguarGymApp_Preview.Formularios
{
    partial class Inicio_Sesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_IniciarSesion = new Guna.UI2.WinForms.Guna2GradientButton();
            this.linkLb_RecuperarCredenciales = new System.Windows.Forms.LinkLabel();
            this.txtbox_IngresarUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBox_IngresarPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.linkLb_CrearCuenta = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_MostrarPassword = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgbtn_Escaner = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-188, 80);
            this.materialDrawer1.Margin = new System.Windows.Forms.Padding(2);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(188, 98);
            this.materialDrawer1.TabIndex = 1;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(622, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Bienvenido de vuelta!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(603, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ingrese su usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(599, 423);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ingrese su contraseña";
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.Animated = true;
            this.btn_IniciarSesion.AutoRoundedCorners = true;
            this.btn_IniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btn_IniciarSesion.BorderRadius = 27;
            this.btn_IniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IniciarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_IniciarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_IniciarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_IniciarSesion.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_IniciarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_IniciarSesion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.btn_IniciarSesion.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(83)))));
            this.btn_IniciarSesion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btn_IniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btn_IniciarSesion.Location = new System.Drawing.Point(700, 545);
            this.btn_IniciarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.Size = new System.Drawing.Size(198, 56);
            this.btn_IniciarSesion.TabIndex = 24;
            this.btn_IniciarSesion.Text = "Iniciar Sesión";
            this.btn_IniciarSesion.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // linkLb_RecuperarCredenciales
            // 
            this.linkLb_RecuperarCredenciales.AutoSize = true;
            this.linkLb_RecuperarCredenciales.BackColor = System.Drawing.Color.Transparent;
            this.linkLb_RecuperarCredenciales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLb_RecuperarCredenciales.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLb_RecuperarCredenciales.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(83)))));
            this.linkLb_RecuperarCredenciales.Location = new System.Drawing.Point(604, 493);
            this.linkLb_RecuperarCredenciales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLb_RecuperarCredenciales.Name = "linkLb_RecuperarCredenciales";
            this.linkLb_RecuperarCredenciales.Size = new System.Drawing.Size(228, 17);
            this.linkLb_RecuperarCredenciales.TabIndex = 25;
            this.linkLb_RecuperarCredenciales.TabStop = true;
            this.linkLb_RecuperarCredenciales.Text = "Has olvidado tu contraseña?";
            this.linkLb_RecuperarCredenciales.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLb_RecuperarCredenciales_LinkClicked);
            // 
            // txtbox_IngresarUsuario
            // 
            this.txtbox_IngresarUsuario.AutoRoundedCorners = true;
            this.txtbox_IngresarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtbox_IngresarUsuario.BorderColor = System.Drawing.Color.DarkGray;
            this.txtbox_IngresarUsuario.BorderRadius = 19;
            this.txtbox_IngresarUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_IngresarUsuario.DefaultText = "";
            this.txtbox_IngresarUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_IngresarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_IngresarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_IngresarUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_IngresarUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_IngresarUsuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtbox_IngresarUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_IngresarUsuario.Location = new System.Drawing.Point(602, 366);
            this.txtbox_IngresarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_IngresarUsuario.Name = "txtbox_IngresarUsuario";
            this.txtbox_IngresarUsuario.PasswordChar = '\0';
            this.txtbox_IngresarUsuario.PlaceholderText = "Usuario";
            this.txtbox_IngresarUsuario.SelectedText = "";
            this.txtbox_IngresarUsuario.Size = new System.Drawing.Size(380, 40);
            this.txtbox_IngresarUsuario.TabIndex = 28;
            this.txtbox_IngresarUsuario.TextChanged += new System.EventHandler(this.txtbox_IngresarUsuario_TextChanged);
            this.txtbox_IngresarUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtbox_IngresarUsuario_Validating);
            // 
            // txtBox_IngresarPassword
            // 
            this.txtBox_IngresarPassword.AutoRoundedCorners = true;
            this.txtBox_IngresarPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtBox_IngresarPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBox_IngresarPassword.BorderRadius = 19;
            this.txtBox_IngresarPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_IngresarPassword.DefaultText = "";
            this.txtBox_IngresarPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBox_IngresarPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBox_IngresarPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_IngresarPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_IngresarPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_IngresarPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic);
            this.txtBox_IngresarPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_IngresarPassword.Location = new System.Drawing.Point(602, 444);
            this.txtBox_IngresarPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBox_IngresarPassword.Name = "txtBox_IngresarPassword";
            this.txtBox_IngresarPassword.PasswordChar = '*';
            this.txtBox_IngresarPassword.PlaceholderText = "Contraseña";
            this.txtBox_IngresarPassword.SelectedText = "";
            this.txtBox_IngresarPassword.Size = new System.Drawing.Size(380, 40);
            this.txtBox_IngresarPassword.TabIndex = 29;
            this.txtBox_IngresarPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_IngresarPassword_Validating);
            // 
            // linkLb_CrearCuenta
            // 
            this.linkLb_CrearCuenta.AutoSize = true;
            this.linkLb_CrearCuenta.BackColor = System.Drawing.Color.Transparent;
            this.linkLb_CrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLb_CrearCuenta.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLb_CrearCuenta.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(83)))));
            this.linkLb_CrearCuenta.Location = new System.Drawing.Point(715, 617);
            this.linkLb_CrearCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLb_CrearCuenta.Name = "linkLb_CrearCuenta";
            this.linkLb_CrearCuenta.Size = new System.Drawing.Size(180, 17);
            this.linkLb_CrearCuenta.TabIndex = 31;
            this.linkLb_CrearCuenta.TabStop = true;
            this.linkLb_CrearCuenta.Text = "No tienes una cuenta?";
            this.linkLb_CrearCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLb_CrearCuenta_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(817, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Sistema de entrada";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator1.Location = new System.Drawing.Point(488, 67);
            this.guna2VSeparator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(67, 648);
            this.guna2VSeparator1.TabIndex = 26;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(136)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(121)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-1, 64);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(524, 657);
            this.guna2GradientPanel1.TabIndex = 34;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2PictureBox1.Image = global::JaguarGymApp_Preview.Properties.Resources.Iniciar_Sesion;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(76, 64);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(382, 464);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 27;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btn_MostrarPassword
            // 
            this.btn_MostrarPassword.BackColor = System.Drawing.Color.Transparent;
            this.btn_MostrarPassword.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_MostrarPassword.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_MostrarPassword.Image = global::JaguarGymApp_Preview.Properties.Resources.ojo;
            this.btn_MostrarPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_MostrarPassword.ImageRotate = 0F;
            this.btn_MostrarPassword.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_MostrarPassword.Location = new System.Drawing.Point(937, 450);
            this.btn_MostrarPassword.Name = "btn_MostrarPassword";
            this.btn_MostrarPassword.PressedState.Image = global::JaguarGymApp_Preview.Properties.Resources.ojo_cruzado;
            this.btn_MostrarPassword.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_MostrarPassword.Size = new System.Drawing.Size(34, 29);
            this.btn_MostrarPassword.TabIndex = 36;
            this.btn_MostrarPassword.UseTransparentBackground = true;
            this.btn_MostrarPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MostrarPassword_MouseDown);
            this.btn_MostrarPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MostrarPassword_MouseUp);
            // 
            // imgbtn_Escaner
            // 
            this.imgbtn_Escaner.BackColor = System.Drawing.Color.Transparent;
            this.imgbtn_Escaner.CausesValidation = false;
            this.imgbtn_Escaner.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn_Escaner.HoverState.Image = global::JaguarGymApp_Preview.Properties.Resources.pistola_de_escaner_hover;
            this.imgbtn_Escaner.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgbtn_Escaner.Image = global::JaguarGymApp_Preview.Properties.Resources.pistola_de_escaner;
            this.imgbtn_Escaner.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgbtn_Escaner.ImageRotate = 0F;
            this.imgbtn_Escaner.ImageSize = new System.Drawing.Size(30, 30);
            this.imgbtn_Escaner.Location = new System.Drawing.Point(1006, 28);
            this.imgbtn_Escaner.Margin = new System.Windows.Forms.Padding(2);
            this.imgbtn_Escaner.Name = "imgbtn_Escaner";
            this.imgbtn_Escaner.PressedState.Image = global::JaguarGymApp_Preview.Properties.Resources.pistola_de_escaner;
            this.imgbtn_Escaner.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgbtn_Escaner.Size = new System.Drawing.Size(38, 33);
            this.imgbtn_Escaner.TabIndex = 35;
            this.imgbtn_Escaner.UseTransparentBackground = true;
            this.imgbtn_Escaner.Click += new System.EventHandler(this.imgbtn_Escaner_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2PictureBox2.Image = global::JaguarGymApp_Preview.Properties.Resources.Logo_deportes;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(603, 144);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(379, 89);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 12;
            this.guna2PictureBox2.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Inicio_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1080, 718);
            this.Controls.Add(this.btn_MostrarPassword);
            this.Controls.Add(this.imgbtn_Escaner);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLb_CrearCuenta);
            this.Controls.Add(this.txtBox_IngresarPassword);
            this.Controls.Add(this.txtbox_IngresarUsuario);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.linkLb_RecuperarCredenciales);
            this.Controls.Add(this.btn_IniciarSesion);
            this.Controls.Add(this.materialDrawer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 661);
            this.Name = "Inicio_Sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.Inicio_Sesión_Load);
            this.Enter += new System.EventHandler(this.btn_IniciarSesion_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Inicio_Sesion_KeyDown);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton btn_IniciarSesion;
        private System.Windows.Forms.LinkLabel linkLb_RecuperarCredenciales;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_IngresarUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtBox_IngresarPassword;
        private System.Windows.Forms.LinkLabel linkLb_CrearCuenta;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton imgbtn_Escaner;
        private Guna.UI2.WinForms.Guna2ImageButton btn_MostrarPassword;
        private ErrorProvider errorProvider1;
    }
}