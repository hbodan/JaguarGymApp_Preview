namespace JaguarGymApp_Preview.Formularios
{
    partial class Todos_Miembros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Todos_Miembros));
            this.lblTodosMiembros = new System.Windows.Forms.Label();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvTodosMiembros = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnMiembrosActivos = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarMiembro = new Guna.UI2.WinForms.Guna2Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosMiembros)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTodosMiembros
            // 
            this.lblTodosMiembros.AutoSize = true;
            this.lblTodosMiembros.Font = new System.Drawing.Font("Verdana", 20F);
            this.lblTodosMiembros.Location = new System.Drawing.Point(55, 84);
            this.lblTodosMiembros.Name = "lblTodosMiembros";
            this.lblTodosMiembros.Size = new System.Drawing.Size(282, 32);
            this.lblTodosMiembros.TabIndex = 0;
            this.lblTodosMiembros.Text = "Todos los miembros";
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoRoundedCorners = true;
            this.txtBuscar.BorderRadius = 18;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Location = new System.Drawing.Point(61, 141);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(315, 38);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoRoundedCorners = true;
            this.btnBuscar.BorderRadius = 18;
            this.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(413, 141);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(180, 38);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            // 
            // dgvTodosMiembros
            // 
            this.dgvTodosMiembros.AllowUserToAddRows = false;
            this.dgvTodosMiembros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            this.dgvTodosMiembros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTodosMiembros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodosMiembros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTodosMiembros.ColumnHeadersHeight = 4;
            this.dgvTodosMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTodosMiembros.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTodosMiembros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTodosMiembros.Location = new System.Drawing.Point(61, 209);
            this.dgvTodosMiembros.MaximumSize = new System.Drawing.Size(1348, 503);
            this.dgvTodosMiembros.MinimumSize = new System.Drawing.Size(1348, 503);
            this.dgvTodosMiembros.Name = "dgvTodosMiembros";
            this.dgvTodosMiembros.ReadOnly = true;
            this.dgvTodosMiembros.RowHeadersVisible = false;
            this.dgvTodosMiembros.RowTemplate.Height = 24;
            this.dgvTodosMiembros.Size = new System.Drawing.Size(1348, 503);
            this.dgvTodosMiembros.TabIndex = 3;
            this.dgvTodosMiembros.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTodosMiembros.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTodosMiembros.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTodosMiembros.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvTodosMiembros.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Teal;
            this.dgvTodosMiembros.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTodosMiembros.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTodosMiembros.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvTodosMiembros.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTodosMiembros.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTodosMiembros.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTodosMiembros.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTodosMiembros.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvTodosMiembros.ThemeStyle.ReadOnly = true;
            this.dgvTodosMiembros.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTodosMiembros.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTodosMiembros.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTodosMiembros.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTodosMiembros.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTodosMiembros.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTodosMiembros.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTodosMiembros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // btnMiembrosActivos
            // 
            this.btnMiembrosActivos.AutoRoundedCorners = true;
            this.btnMiembrosActivos.BorderRadius = 18;
            this.btnMiembrosActivos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMiembrosActivos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMiembrosActivos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMiembrosActivos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMiembrosActivos.FillColor = System.Drawing.Color.Purple;
            this.btnMiembrosActivos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMiembrosActivos.ForeColor = System.Drawing.Color.White;
            this.btnMiembrosActivos.Location = new System.Drawing.Point(291, 733);
            this.btnMiembrosActivos.Name = "btnMiembrosActivos";
            this.btnMiembrosActivos.Size = new System.Drawing.Size(180, 38);
            this.btnMiembrosActivos.TabIndex = 4;
            this.btnMiembrosActivos.Text = "Miembros Activos";
            this.btnMiembrosActivos.Click += new System.EventHandler(this.btnMiembrosActivos_Click);
            // 
            // btnAgregarMiembro
            // 
            this.btnAgregarMiembro.AutoRoundedCorners = true;
            this.btnAgregarMiembro.BorderRadius = 18;
            this.btnAgregarMiembro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarMiembro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarMiembro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarMiembro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarMiembro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAgregarMiembro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarMiembro.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMiembro.Location = new System.Drawing.Point(61, 733);
            this.btnAgregarMiembro.Name = "btnAgregarMiembro";
            this.btnAgregarMiembro.Size = new System.Drawing.Size(180, 38);
            this.btnAgregarMiembro.TabIndex = 5;
            this.btnAgregarMiembro.Text = "Agregar Miembro";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 861);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1434, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Todos_Miembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 886);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAgregarMiembro);
            this.Controls.Add(this.btnMiembrosActivos);
            this.Controls.Add(this.dgvTodosMiembros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblTodosMiembros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 886);
            this.MinimumSize = new System.Drawing.Size(1440, 886);
            this.Name = "Todos_Miembros";
            this.Text = "Todos_Miembros";
            this.Load += new System.EventHandler(this.Todos_Miembros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosMiembros)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTodosMiembros;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTodosMiembros;
        private Guna.UI2.WinForms.Guna2Button btnMiembrosActivos;
        private Guna.UI2.WinForms.Guna2Button btnAgregarMiembro;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}