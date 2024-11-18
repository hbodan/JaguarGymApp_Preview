namespace JaguarGymApp_Preview.Formularios
{
    partial class Usuario_no_Registrado_usuario
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
            this.pnSuperior = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbUstednoestaregistrado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbLogouam = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnSuperior.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogouam)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(154)))), ((int)(((byte)(165)))));
            this.pnSuperior.Controls.Add(this.pbLogouam);
            this.pnSuperior.Location = new System.Drawing.Point(-14, 57);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(1110, 147);
            this.pnSuperior.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.lbUstednoestaregistrado);
            this.guna2Panel1.Location = new System.Drawing.Point(67, 219);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(934, 412);
            this.guna2Panel1.TabIndex = 1;
            // 
            // lbUstednoestaregistrado
            // 
            this.lbUstednoestaregistrado.AutoSize = true;
            this.lbUstednoestaregistrado.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUstednoestaregistrado.Location = new System.Drawing.Point(195, 73);
            this.lbUstednoestaregistrado.Name = "lbUstednoestaregistrado";
            this.lbUstednoestaregistrado.Size = new System.Drawing.Size(534, 45);
            this.lbUstednoestaregistrado.TabIndex = 0;
            this.lbUstednoestaregistrado.Text = "Usted no esta registrado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(41, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(855, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usted no está registrado en el sistema. Por favor, contacte con Vida Estudiantil " +
    "para más información";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::JaguarGymApp_Preview.Properties.Resources.Precaucion_icono_Amarillo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(130, 60);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(59, 58);
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pbLogouam
            // 
            this.pbLogouam.Image = global::JaguarGymApp_Preview.Properties.Resources.Jaguares_UAM_redondo;
            this.pbLogouam.ImageRotate = 0F;
            this.pbLogouam.Location = new System.Drawing.Point(67, 3);
            this.pbLogouam.Name = "pbLogouam";
            this.pbLogouam.Size = new System.Drawing.Size(137, 137);
            this.pbLogouam.TabIndex = 0;
            this.pbLogouam.TabStop = false;
            // 
            // Usuario_no_Registrado_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnSuperior);
            this.Name = "Usuario_no_Registrado_usuario";
            this.Text = "Usuario no registrado";
            this.Load += new System.EventHandler(this.Usuario_no_Registrado_usuario_Load);
            this.pnSuperior.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogouam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnSuperior;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogouam;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUstednoestaregistrado;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}