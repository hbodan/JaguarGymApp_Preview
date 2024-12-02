namespace JaguarGymApp_Preview.Formularios
{
    partial class Agregar_Miembros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Miembros));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFemenino = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkMasculino = new MaterialSkin.Controls.MaterialCheckbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkColaborador = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkEstudiante = new MaterialSkin.Controls.MaterialCheckbox();
            this.dateExpiracion = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateNacimiento = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCargo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cmbFacultad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbCarrera = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFacultad = new System.Windows.Forms.Label();
            this.txtApellidos = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtidentificacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblidentificacion = new System.Windows.Forms.Label();
            this.LinkAtras = new System.Windows.Forms.LinkLabel();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCIF = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(503, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar un nuevo miembro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkFemenino);
            this.groupBox2.Controls.Add(this.chkMasculino);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(92, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 89);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Género";
            // 
            // chkFemenino
            // 
            this.chkFemenino.AutoSize = true;
            this.chkFemenino.Depth = 0;
            this.chkFemenino.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFemenino.Location = new System.Drawing.Point(306, 29);
            this.chkFemenino.Margin = new System.Windows.Forms.Padding(0);
            this.chkFemenino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkFemenino.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkFemenino.Name = "chkFemenino";
            this.chkFemenino.ReadOnly = false;
            this.chkFemenino.Ripple = true;
            this.chkFemenino.Size = new System.Drawing.Size(105, 37);
            this.chkFemenino.TabIndex = 44;
            this.chkFemenino.Text = "Femenino";
            this.chkFemenino.UseVisualStyleBackColor = true;
            this.chkFemenino.CheckedChanged += new System.EventHandler(this.chkFemenino_CheckedChanged);
            // 
            // chkMasculino
            // 
            this.chkMasculino.AutoSize = true;
            this.chkMasculino.Depth = 0;
            this.chkMasculino.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMasculino.Location = new System.Drawing.Point(32, 29);
            this.chkMasculino.Margin = new System.Windows.Forms.Padding(0);
            this.chkMasculino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkMasculino.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkMasculino.Name = "chkMasculino";
            this.chkMasculino.ReadOnly = false;
            this.chkMasculino.Ripple = true;
            this.chkMasculino.Size = new System.Drawing.Size(109, 37);
            this.chkMasculino.TabIndex = 43;
            this.chkMasculino.Text = "Masculino";
            this.chkMasculino.UseVisualStyleBackColor = true;
            this.chkMasculino.CheckedChanged += new System.EventHandler(this.chkMasculino_CheckedChanged);
            this.chkMasculino.Click += new System.EventHandler(this.chkMasculino_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkColaborador);
            this.groupBox1.Controls.Add(this.chkEstudiante);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(92, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 89);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rol";
            // 
            // chkColaborador
            // 
            this.chkColaborador.AutoSize = true;
            this.chkColaborador.Depth = 0;
            this.chkColaborador.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkColaborador.Location = new System.Drawing.Point(306, 29);
            this.chkColaborador.Margin = new System.Windows.Forms.Padding(0);
            this.chkColaborador.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkColaborador.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkColaborador.Name = "chkColaborador";
            this.chkColaborador.ReadOnly = false;
            this.chkColaborador.Ripple = true;
            this.chkColaborador.Size = new System.Drawing.Size(122, 37);
            this.chkColaborador.TabIndex = 44;
            this.chkColaborador.Text = "Colaborador";
            this.chkColaborador.UseVisualStyleBackColor = true;
            this.chkColaborador.CheckedChanged += new System.EventHandler(this.chkColaborador_CheckedChanged);
            // 
            // chkEstudiante
            // 
            this.chkEstudiante.AutoSize = true;
            this.chkEstudiante.Depth = 0;
            this.chkEstudiante.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstudiante.Location = new System.Drawing.Point(32, 29);
            this.chkEstudiante.Margin = new System.Windows.Forms.Padding(0);
            this.chkEstudiante.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkEstudiante.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkEstudiante.Name = "chkEstudiante";
            this.chkEstudiante.ReadOnly = false;
            this.chkEstudiante.Ripple = true;
            this.chkEstudiante.Size = new System.Drawing.Size(110, 37);
            this.chkEstudiante.TabIndex = 43;
            this.chkEstudiante.Text = "Estudiante";
            this.chkEstudiante.UseVisualStyleBackColor = true;
            this.chkEstudiante.CheckedChanged += new System.EventHandler(this.chkEstudiante_CheckedChanged);
            // 
            // dateExpiracion
            // 
            this.dateExpiracion.Checked = true;
            this.dateExpiracion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(134)))));
            this.dateExpiracion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateExpiracion.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateExpiracion.Location = new System.Drawing.Point(927, 414);
            this.dateExpiracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateExpiracion.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateExpiracion.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateExpiracion.Name = "dateExpiracion";
            this.dateExpiracion.Size = new System.Drawing.Size(370, 36);
            this.dateExpiracion.TabIndex = 76;
            this.dateExpiracion.Value = new System.DateTime(2024, 11, 26, 21, 42, 45, 670);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(653, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 25);
            this.label5.TabIndex = 75;
            this.label5.Text = "Membresia Expira:";
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Checked = true;
            this.dateNacimiento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(134)))));
            this.dateNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateNacimiento.Location = new System.Drawing.Point(927, 328);
            this.dateNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNacimiento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNacimiento.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(370, 36);
            this.dateNacimiento.TabIndex = 74;
            this.dateNacimiento.Value = new System.DateTime(2024, 11, 26, 21, 42, 45, 670);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(653, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // txtCargo
            // 
            this.txtCargo.AutoRoundedCorners = true;
            this.txtCargo.BorderRadius = 18;
            this.txtCargo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCargo.DefaultText = "";
            this.txtCargo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCargo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCargo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCargo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCargo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCargo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCargo.Location = new System.Drawing.Point(258, 523);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.PasswordChar = '\0';
            this.txtCargo.PlaceholderText = "";
            this.txtCargo.SelectedText = "";
            this.txtCargo.Size = new System.Drawing.Size(333, 39);
            this.txtCargo.TabIndex = 72;
            this.txtCargo.Visible = false;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.Black;
            this.lblCargo.Location = new System.Drawing.Point(87, 528);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(85, 25);
            this.lblCargo.TabIndex = 71;
            this.lblCargo.Text = "Cargo:";
            this.lblCargo.Visible = false;
            // 
            // cmbFacultad
            // 
            this.cmbFacultad.AutoRoundedCorners = true;
            this.cmbFacultad.BackColor = System.Drawing.Color.Transparent;
            this.cmbFacultad.BorderRadius = 17;
            this.cmbFacultad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFacultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacultad.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFacultad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFacultad.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFacultad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFacultad.ItemHeight = 30;
            this.cmbFacultad.Location = new System.Drawing.Point(927, 528);
            this.cmbFacultad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFacultad.Name = "cmbFacultad";
            this.cmbFacultad.Size = new System.Drawing.Size(370, 36);
            this.cmbFacultad.TabIndex = 70;
            this.cmbFacultad.Visible = false;
            this.cmbFacultad.SelectedIndexChanged += new System.EventHandler(this.cmbFacultad_SelectedIndexChanged);
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.AutoRoundedCorners = true;
            this.cmbCarrera.BackColor = System.Drawing.Color.Transparent;
            this.cmbCarrera.BorderRadius = 17;
            this.cmbCarrera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarrera.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCarrera.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCarrera.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarrera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCarrera.ItemHeight = 30;
            this.cmbCarrera.Location = new System.Drawing.Point(927, 598);
            this.cmbCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(370, 36);
            this.cmbCarrera.TabIndex = 69;
            this.cmbCarrera.Visible = false;
            // 
            // lblFacultad
            // 
            this.lblFacultad.AutoSize = true;
            this.lblFacultad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultad.ForeColor = System.Drawing.Color.Black;
            this.lblFacultad.Location = new System.Drawing.Point(653, 528);
            this.lblFacultad.Name = "lblFacultad";
            this.lblFacultad.Size = new System.Drawing.Size(115, 25);
            this.lblFacultad.TabIndex = 68;
            this.lblFacultad.Text = "Facultad:";
            this.lblFacultad.Visible = false;
            // 
            // txtApellidos
            // 
            this.txtApellidos.AutoRoundedCorners = true;
            this.txtApellidos.BorderRadius = 18;
            this.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.DefaultText = "";
            this.txtApellidos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidos.Location = new System.Drawing.Point(927, 258);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.PlaceholderText = "";
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.Size = new System.Drawing.Size(370, 39);
            this.txtApellidos.TabIndex = 67;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.Black;
            this.lblApellidos.Location = new System.Drawing.Point(653, 258);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(124, 25);
            this.lblApellidos.TabIndex = 66;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtidentificacion
            // 
            this.txtidentificacion.AutoRoundedCorners = true;
            this.txtidentificacion.BorderRadius = 17;
            this.txtidentificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidentificacion.DefaultText = "";
            this.txtidentificacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtidentificacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtidentificacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidentificacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidentificacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidentificacion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidentificacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidentificacion.Location = new System.Drawing.Point(258, 177);
            this.txtidentificacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtidentificacion.Name = "txtidentificacion";
            this.txtidentificacion.PasswordChar = '\0';
            this.txtidentificacion.PlaceholderText = "";
            this.txtidentificacion.SelectedText = "";
            this.txtidentificacion.Size = new System.Drawing.Size(333, 36);
            this.txtidentificacion.TabIndex = 65;
            // 
            // lblidentificacion
            // 
            this.lblidentificacion.AutoSize = true;
            this.lblidentificacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidentificacion.ForeColor = System.Drawing.Color.Black;
            this.lblidentificacion.Location = new System.Drawing.Point(87, 177);
            this.lblidentificacion.Name = "lblidentificacion";
            this.lblidentificacion.Size = new System.Drawing.Size(175, 25);
            this.lblidentificacion.TabIndex = 64;
            this.lblidentificacion.Text = "Identificacion:";
            // 
            // LinkAtras
            // 
            this.LinkAtras.AutoSize = true;
            this.LinkAtras.LinkColor = System.Drawing.Color.Silver;
            this.LinkAtras.Location = new System.Drawing.Point(629, 799);
            this.LinkAtras.Name = "LinkAtras";
            this.LinkAtras.Size = new System.Drawing.Size(166, 16);
            this.LinkAtras.TabIndex = 63;
            this.LinkAtras.TabStop = true;
            this.LinkAtras.Text = "Volver a lista de miembros";
            this.LinkAtras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkAtras_LinkClicked);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoRoundedCorners = true;
            this.btnAgregar.BorderRadius = 22;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(632, 734);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 46);
            this.btnAgregar.TabIndex = 62;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.ForeColor = System.Drawing.Color.Black;
            this.lblCarrera.Location = new System.Drawing.Point(655, 604);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(103, 25);
            this.lblCarrera.TabIndex = 61;
            this.lblCarrera.Text = "Carrera:";
            this.lblCarrera.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(87, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 60;
            this.label3.Text = "Nombres:";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoRoundedCorners = true;
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BorderRadius = 18;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Location = new System.Drawing.Point(258, 240);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(333, 39);
            this.txtNombre.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(655, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "CIF:";
            // 
            // txtCIF
            // 
            this.txtCIF.AutoRoundedCorners = true;
            this.txtCIF.BorderRadius = 17;
            this.txtCIF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCIF.DefaultText = "";
            this.txtCIF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCIF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCIF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCIF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCIF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCIF.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtCIF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCIF.Location = new System.Drawing.Point(927, 177);
            this.txtCIF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCIF.Name = "txtCIF";
            this.txtCIF.PasswordChar = '\0';
            this.txtCIF.PlaceholderText = "";
            this.txtCIF.SelectedText = "";
            this.txtCIF.Size = new System.Drawing.Size(370, 36);
            this.txtCIF.TabIndex = 57;
            // 
            // Agregar_Miembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 886);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateExpiracion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.cmbFacultad);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.lblFacultad);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtidentificacion);
            this.Controls.Add(this.lblidentificacion);
            this.Controls.Add(this.LinkAtras);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCIF);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 886);
            this.MinimumSize = new System.Drawing.Size(1440, 886);
            this.Name = "Agregar_Miembros";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.Text = "Agregar Miembros";
            this.Load += new System.EventHandler(this.Agregar_Miembros_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialCheckbox chkFemenino;
        private MaterialSkin.Controls.MaterialCheckbox chkMasculino;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialCheckbox chkColaborador;
        private MaterialSkin.Controls.MaterialCheckbox chkEstudiante;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateExpiracion;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateNacimiento;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtCargo;
        private System.Windows.Forms.Label lblCargo;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFacultad;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCarrera;
        private System.Windows.Forms.Label lblFacultad;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private Guna.UI2.WinForms.Guna2TextBox txtidentificacion;
        private System.Windows.Forms.Label lblidentificacion;
        private System.Windows.Forms.LinkLabel LinkAtras;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtCIF;

    }
}