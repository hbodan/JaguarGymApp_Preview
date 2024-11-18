namespace JaguarGymApp_Preview.Formularios
{
    partial class Recuperar_Credenciales
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptarRecuperar = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::JaguarGymApp_Preview.Properties.Resources.correo;
            this.pictureBox1.Location = new System.Drawing.Point(317, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(126, 496);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Te enviamos las indicaciones al correo eléctronico!";
            // 
            // btnAceptarRecuperar
            // 
            this.btnAceptarRecuperar.Animated = true;
            this.btnAceptarRecuperar.AutoRoundedCorners = true;
            this.btnAceptarRecuperar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptarRecuperar.BorderRadius = 27;
            this.btnAceptarRecuperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarRecuperar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptarRecuperar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptarRecuperar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAceptarRecuperar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAceptarRecuperar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAceptarRecuperar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.btnAceptarRecuperar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(83)))));
            this.btnAceptarRecuperar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnAceptarRecuperar.ForeColor = System.Drawing.Color.White;
            this.btnAceptarRecuperar.Location = new System.Drawing.Point(432, 581);
            this.btnAceptarRecuperar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptarRecuperar.Name = "btnAceptarRecuperar";
            this.btnAceptarRecuperar.Size = new System.Drawing.Size(198, 56);
            this.btnAceptarRecuperar.TabIndex = 25;
            this.btnAceptarRecuperar.Text = "Aceptar";
            this.btnAceptarRecuperar.Click += new System.EventHandler(this.btnAceptarRecuperar_Click);
            // 
            // Recuperar_Credenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.btnAceptarRecuperar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "Recuperar_Credenciales";
            this.Text = "Recupera tus credenciales";
            this.Load += new System.EventHandler(this.Recuperar_Credenciales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAceptarRecuperar;
    }
}