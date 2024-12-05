namespace JaguarGymApp_Preview.Formularios
{
    partial class Usuario_con_membresia_vencida_gerente
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
            this.pnSuperior = new Guna.UI2.WinForms.Guna2Panel();
            this.pbLogoUam = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnMembresiavencidagerente = new Guna.UI2.WinForms.Guna2Panel();
            this.lbRecordatorio = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbfechadevencimientocaducado = new System.Windows.Forms.Label();
            this.lbFechavencimiento = new System.Windows.Forms.Label();
            this.lbcarreraCaducado = new System.Windows.Forms.Label();
            this.lbCarrera = new System.Windows.Forms.Label();
            this.lbapellidoCaducado = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbnombreCaducado = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbMembresiavencidausuario = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUam)).BeginInit();
            this.pnMembresiavencidagerente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(154)))), ((int)(((byte)(165)))));
            this.pnSuperior.Controls.Add(this.pbLogoUam);
            this.pnSuperior.Location = new System.Drawing.Point(-7, 58);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(1079, 151);
            this.pnSuperior.TabIndex = 0;
            // 
            // pbLogoUam
            // 
            this.pbLogoUam.Image = global::JaguarGymApp_Preview.Properties.Resources.Jaguares_UAM_redondo;
            this.pbLogoUam.ImageRotate = 0F;
            this.pbLogoUam.Location = new System.Drawing.Point(61, 9);
            this.pbLogoUam.Name = "pbLogoUam";
            this.pbLogoUam.Size = new System.Drawing.Size(137, 137);
            this.pbLogoUam.TabIndex = 0;
            this.pbLogoUam.TabStop = false;
            // 
            // pnMembresiavencidagerente
            // 
            this.pnMembresiavencidagerente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnMembresiavencidagerente.Controls.Add(this.lbRecordatorio);
            this.pnMembresiavencidagerente.Controls.Add(this.guna2PictureBox2);
            this.pnMembresiavencidagerente.Controls.Add(this.lbfechadevencimientocaducado);
            this.pnMembresiavencidagerente.Controls.Add(this.lbFechavencimiento);
            this.pnMembresiavencidagerente.Controls.Add(this.lbcarreraCaducado);
            this.pnMembresiavencidagerente.Controls.Add(this.lbCarrera);
            this.pnMembresiavencidagerente.Controls.Add(this.lbapellidoCaducado);
            this.pnMembresiavencidagerente.Controls.Add(this.lbApellido);
            this.pnMembresiavencidagerente.Controls.Add(this.lbnombreCaducado);
            this.pnMembresiavencidagerente.Controls.Add(this.lbNombre);
            this.pnMembresiavencidagerente.Controls.Add(this.guna2PictureBox1);
            this.pnMembresiavencidagerente.Controls.Add(this.lbMembresiavencidausuario);
            this.pnMembresiavencidagerente.Location = new System.Drawing.Point(96, 247);
            this.pnMembresiavencidagerente.Name = "pnMembresiavencidagerente";
            this.pnMembresiavencidagerente.Size = new System.Drawing.Size(876, 386);
            this.pnMembresiavencidagerente.TabIndex = 1;
            this.pnMembresiavencidagerente.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMembresiavencidagerente_Paint);
            // 
            // lbRecordatorio
            // 
            this.lbRecordatorio.AutoSize = true;
            this.lbRecordatorio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbRecordatorio.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordatorio.ForeColor = System.Drawing.Color.Red;
            this.lbRecordatorio.Location = new System.Drawing.Point(230, 356);
            this.lbRecordatorio.Name = "lbRecordatorio";
            this.lbRecordatorio.Size = new System.Drawing.Size(411, 18);
            this.lbRecordatorio.TabIndex = 11;
            this.lbRecordatorio.Text = "Recomendar al usuario renovar su membresia";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::JaguarGymApp_Preview.Properties.Resources.User_icon;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(637, 95);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(172, 172);
            this.guna2PictureBox2.TabIndex = 10;
            this.guna2PictureBox2.TabStop = false;
            // 
            // lbfechadevencimientocaducado
            // 
            this.lbfechadevencimientocaducado.AutoSize = true;
            this.lbfechadevencimientocaducado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfechadevencimientocaducado.Location = new System.Drawing.Point(332, 229);
            this.lbfechadevencimientocaducado.Name = "lbfechadevencimientocaducado";
            this.lbfechadevencimientocaducado.Size = new System.Drawing.Size(210, 18);
            this.lbfechadevencimientocaducado.TabIndex = 9;
            this.lbfechadevencimientocaducado.Text = "Viernes 1 de Marzo 2024";
            // 
            // lbFechavencimiento
            // 
            this.lbFechavencimiento.AutoSize = true;
            this.lbFechavencimiento.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechavencimiento.Location = new System.Drawing.Point(123, 229);
            this.lbFechavencimiento.Name = "lbFechavencimiento";
            this.lbFechavencimiento.Size = new System.Drawing.Size(203, 18);
            this.lbFechavencimiento.TabIndex = 8;
            this.lbFechavencimiento.Text = "Fecha de vencimiento:";
            // 
            // lbcarreraCaducado
            // 
            this.lbcarreraCaducado.AutoSize = true;
            this.lbcarreraCaducado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcarreraCaducado.Location = new System.Drawing.Point(213, 195);
            this.lbcarreraCaducado.Name = "lbcarreraCaducado";
            this.lbcarreraCaducado.Size = new System.Drawing.Size(87, 18);
            this.lbcarreraCaducado.TabIndex = 7;
            this.lbcarreraCaducado.Text = "Marketing";
            // 
            // lbCarrera
            // 
            this.lbCarrera.AutoSize = true;
            this.lbCarrera.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarrera.Location = new System.Drawing.Point(123, 195);
            this.lbCarrera.Name = "lbCarrera";
            this.lbCarrera.Size = new System.Drawing.Size(83, 18);
            this.lbCarrera.TabIndex = 6;
            this.lbCarrera.Text = "Carrera:";
            // 
            // lbapellidoCaducado
            // 
            this.lbapellidoCaducado.AutoSize = true;
            this.lbapellidoCaducado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbapellidoCaducado.Location = new System.Drawing.Point(213, 160);
            this.lbapellidoCaducado.Name = "lbapellidoCaducado";
            this.lbapellidoCaducado.Size = new System.Drawing.Size(59, 18);
            this.lbapellidoCaducado.TabIndex = 5;
            this.lbapellidoCaducado.Text = "Bodan";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(123, 160);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(82, 18);
            this.lbApellido.TabIndex = 4;
            this.lbApellido.Text = "Apellido:";
            // 
            // lbnombreCaducado
            // 
            this.lbnombreCaducado.AutoSize = true;
            this.lbnombreCaducado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombreCaducado.Location = new System.Drawing.Point(213, 126);
            this.lbnombreCaducado.Name = "lbnombreCaducado";
            this.lbnombreCaducado.Size = new System.Drawing.Size(51, 18);
            this.lbnombreCaducado.TabIndex = 3;
            this.lbnombreCaducado.Text = "Harry";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(123, 126);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(84, 18);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre:";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::JaguarGymApp_Preview.Properties.Resources.Vencimiento_icon;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(718, 14);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(60, 60);
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lbMembresiavencidausuario
            // 
            this.lbMembresiavencidausuario.AutoSize = true;
            this.lbMembresiavencidausuario.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMembresiavencidausuario.Location = new System.Drawing.Point(123, 25);
            this.lbMembresiavencidausuario.Name = "lbMembresiavencidausuario";
            this.lbMembresiavencidausuario.Size = new System.Drawing.Size(589, 38);
            this.lbMembresiavencidausuario.TabIndex = 0;
            this.lbMembresiavencidausuario.Text = "Usuario con membresia vencida";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 7000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Usuario_con_membresia_vencida_gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pnMembresiavencidagerente);
            this.Controls.Add(this.pnSuperior);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usuario_con_membresia_vencida_gerente";
            this.Text = "Usuario con membresia vencida (Vista gerente)";
            this.Load += new System.EventHandler(this.Usuario_con_membresia_vencida_gerente_Load);
            this.pnSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUam)).EndInit();
            this.pnMembresiavencidagerente.ResumeLayout(false);
            this.pnMembresiavencidagerente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnSuperior;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogoUam;
        private Guna.UI2.WinForms.Guna2Panel pnMembresiavencidagerente;
        private System.Windows.Forms.Label lbMembresiavencidausuario;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lbapellidoCaducado;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbnombreCaducado;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbfechadevencimientocaducado;
        private System.Windows.Forms.Label lbFechavencimiento;
        private System.Windows.Forms.Label lbcarreraCaducado;
        private System.Windows.Forms.Label lbCarrera;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label lbRecordatorio;
        private System.Windows.Forms.Timer timer1;
    }
}