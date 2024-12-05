namespace JaguarGymApp_Preview.Formularios
{
    partial class Esperando_por_escaneo
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
            this.pnpanelsuperior = new Guna.UI2.WinForms.Guna2Panel();
            this.PnEsperandoescaner = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEsperealusuario = new System.Windows.Forms.Label();
            this.lblEsperandoescaneo = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbLogouam = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnpanelsuperior.SuspendLayout();
            this.PnEsperandoescaner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogouam)).BeginInit();
            this.SuspendLayout();
            // 
            // pnpanelsuperior
            // 
            this.pnpanelsuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(154)))), ((int)(((byte)(165)))));
            this.pnpanelsuperior.Controls.Add(this.pbLogouam);
            this.pnpanelsuperior.Location = new System.Drawing.Point(-6, 55);
            this.pnpanelsuperior.Name = "pnpanelsuperior";
            this.pnpanelsuperior.Size = new System.Drawing.Size(1114, 138);
            this.pnpanelsuperior.TabIndex = 1;
            // 
            // PnEsperandoescaner
            // 
            this.PnEsperandoescaner.BackColor = System.Drawing.Color.White;
            this.PnEsperandoescaner.Controls.Add(this.lblEsperealusuario);
            this.PnEsperandoescaner.Controls.Add(this.lblEsperandoescaneo);
            this.PnEsperandoescaner.Controls.Add(this.guna2PictureBox1);
            this.PnEsperandoescaner.Location = new System.Drawing.Point(108, 211);
            this.PnEsperandoescaner.Name = "PnEsperandoescaner";
            this.PnEsperandoescaner.Size = new System.Drawing.Size(904, 503);
            this.PnEsperandoescaner.TabIndex = 2;
            this.PnEsperandoescaner.UseWaitCursor = true;
            // 
            // lblEsperealusuario
            // 
            this.lblEsperealusuario.AutoSize = true;
            this.lblEsperealusuario.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsperealusuario.Location = new System.Drawing.Point(215, 85);
            this.lblEsperealusuario.Name = "lblEsperealusuario";
            this.lblEsperealusuario.Size = new System.Drawing.Size(491, 18);
            this.lblEsperealusuario.TabIndex = 1;
            this.lblEsperealusuario.Text = "Por favor, escanee la cédula del usuario para continuar";
            this.lblEsperealusuario.UseWaitCursor = true;
            // 
            // lblEsperandoescaneo
            // 
            this.lblEsperandoescaneo.AutoSize = true;
            this.lblEsperandoescaneo.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsperandoescaneo.Location = new System.Drawing.Point(135, 13);
            this.lblEsperandoescaneo.Name = "lblEsperandoescaneo";
            this.lblEsperandoescaneo.Size = new System.Drawing.Size(651, 59);
            this.lblEsperandoescaneo.TabIndex = 0;
            this.lblEsperandoescaneo.Text = "Esperando por escaneo";
            this.lblEsperandoescaneo.UseWaitCursor = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::JaguarGymApp_Preview.Properties.Resources.Animacion_Reloj;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(218, 52);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(418, 448);
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.UseWaitCursor = true;
            // 
            // pbLogouam
            // 
            this.pbLogouam.Image = global::JaguarGymApp_Preview.Properties.Resources.Jaguares_UAM_redondo;
            this.pbLogouam.ImageRotate = 0F;
            this.pbLogouam.Location = new System.Drawing.Point(50, 0);
            this.pbLogouam.Name = "pbLogouam";
            this.pbLogouam.Size = new System.Drawing.Size(147, 150);
            this.pbLogouam.TabIndex = 0;
            this.pbLogouam.TabStop = false;
            // 
            // Esperando_por_escaneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 720);
            this.Controls.Add(this.PnEsperandoescaner);
            this.Controls.Add(this.pnpanelsuperior);
            this.Name = "Esperando_por_escaneo";
            this.Text = "Escaner de Cedula o CIF";
            this.Load += new System.EventHandler(this.Esperando_por_escaneo_Load);
            this.pnpanelsuperior.ResumeLayout(false);
            this.PnEsperandoescaner.ResumeLayout(false);
            this.PnEsperandoescaner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogouam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnpanelsuperior;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogouam;
        private Guna.UI2.WinForms.Guna2Panel PnEsperandoescaner;
        private System.Windows.Forms.Label lblEsperandoescaneo;
        private System.Windows.Forms.Label lblEsperealusuario;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}