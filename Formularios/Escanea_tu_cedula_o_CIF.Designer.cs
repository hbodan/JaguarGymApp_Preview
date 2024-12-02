namespace JaguarGymApp_Preview.Formularios
{
    partial class Escanea_tu_cedula_o_CIF
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
            this.lblEscaneacedulaCIF = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.txtIdentificacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnIngresarEntrada = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEscaneacedulaCIF
            // 
            this.lblEscaneacedulaCIF.AutoSize = true;
            this.lblEscaneacedulaCIF.BackColor = System.Drawing.Color.Transparent;
            this.lblEscaneacedulaCIF.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscaneacedulaCIF.Location = new System.Drawing.Point(163, 216);
            this.lblEscaneacedulaCIF.Name = "lblEscaneacedulaCIF";
            this.lblEscaneacedulaCIF.Size = new System.Drawing.Size(737, 59);
            this.lblEscaneacedulaCIF.TabIndex = 0;
            this.lblEscaneacedulaCIF.Text = "Escanea tu cedula o tu CIF";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentificacion.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(451, 487);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(194, 32);
            this.lblIdentificacion.TabIndex = 1;
            this.lblIdentificacion.Text = "Identificacion";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.AutoRoundedCorners = true;
            this.txtIdentificacion.BackColor = System.Drawing.Color.Transparent;
            this.txtIdentificacion.BorderRadius = 17;
            this.txtIdentificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentificacion.DefaultText = "";
            this.txtIdentificacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdentificacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdentificacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdentificacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdentificacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdentificacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdentificacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdentificacion.Location = new System.Drawing.Point(376, 534);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.PasswordChar = '\0';
            this.txtIdentificacion.PlaceholderText = "Ingrese su numero de cedula";
            this.txtIdentificacion.SelectedText = "";
            this.txtIdentificacion.Size = new System.Drawing.Size(338, 36);
            this.txtIdentificacion.TabIndex = 4;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.txtIdentificacion_TextChanged);
            // 
            // btnIngresarEntrada
            // 
            this.btnIngresarEntrada.AutoRoundedCorners = true;
            this.btnIngresarEntrada.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresarEntrada.BorderRadius = 15;
            this.btnIngresarEntrada.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresarEntrada.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresarEntrada.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIngresarEntrada.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIngresarEntrada.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnIngresarEntrada.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarEntrada.ForeColor = System.Drawing.Color.White;
            this.btnIngresarEntrada.Location = new System.Drawing.Point(478, 590);
            this.btnIngresarEntrada.Name = "btnIngresarEntrada";
            this.btnIngresarEntrada.PressedColor = System.Drawing.Color.Bisque;
            this.btnIngresarEntrada.Size = new System.Drawing.Size(149, 32);
            this.btnIngresarEntrada.TabIndex = 5;
            this.btnIngresarEntrada.Text = "Ingresar";
            this.btnIngresarEntrada.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(154)))), ((int)(((byte)(165)))));
            this.guna2Panel1.Location = new System.Drawing.Point(-4, 57);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1189, 110);
            this.guna2Panel1.TabIndex = 6;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::JaguarGymApp_Preview.Properties.Resources.Codigo_de_barras_Horizontal;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(90, 360);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(892, 88);
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(862, 663);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(196, 18);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Volver a iniciar sesión";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Escanea_tu_cedula_o_CIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnIngresarEntrada);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lblEscaneacedulaCIF);
            this.MaximizeBox = false;
            this.Name = "Escanea_tu_cedula_o_CIF";
            this.Text = "Registro de entrada";
            this.Load += new System.EventHandler(this.Escanea_tu_cedula_o_CIF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEscaneacedulaCIF;
        private System.Windows.Forms.Label lblIdentificacion;
        private Guna.UI2.WinForms.Guna2TextBox txtIdentificacion;
        private Guna.UI2.WinForms.Guna2Button btnIngresarEntrada;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}