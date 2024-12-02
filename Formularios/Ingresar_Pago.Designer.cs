namespace JaguarGymApp_Preview.Formularios
{
    partial class Ingresar_Pago
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
            this.LinkAtras = new System.Windows.Forms.LinkLabel();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.lblFechaRealizacion = new System.Windows.Forms.Label();
            this.lblIdTransaccion = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblMiembro = new System.Windows.Forms.Label();
            this.txtMonto = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdTransaccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtPickerFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblMesesPagados = new System.Windows.Forms.Label();
            this.nudMesesPagados = new CxFlatUI.CxFlatNumericUpDown();
            this.txtObservacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBuscarMiembro = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvMiembros = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblMiembroSeleccionado = new System.Windows.Forms.Label();
            this.txtMiembroSeleccionado = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkAtras
            // 
            this.LinkAtras.AutoSize = true;
            this.LinkAtras.LinkColor = System.Drawing.Color.Silver;
            this.LinkAtras.Location = new System.Drawing.Point(485, 577);
            this.LinkAtras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LinkAtras.Name = "LinkAtras";
            this.LinkAtras.Size = new System.Drawing.Size(93, 13);
            this.LinkAtras.TabIndex = 19;
            this.LinkAtras.TabStop = true;
            this.LinkAtras.Text = "Volver hacia Atras";
            this.LinkAtras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkAtras_LinkClicked);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoRoundedCorners = true;
            this.btnAgregar.BorderRadius = 17;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(478, 522);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 37);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblFechaRealizacion
            // 
            this.lblFechaRealizacion.AutoSize = true;
            this.lblFechaRealizacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic);
            this.lblFechaRealizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblFechaRealizacion.Location = new System.Drawing.Point(349, 197);
            this.lblFechaRealizacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaRealizacion.Name = "lblFechaRealizacion";
            this.lblFechaRealizacion.Size = new System.Drawing.Size(162, 18);
            this.lblFechaRealizacion.TabIndex = 17;
            this.lblFechaRealizacion.Text = "Fecha Realizacion:";
            this.lblFechaRealizacion.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblIdTransaccion
            // 
            this.lblIdTransaccion.AutoSize = true;
            this.lblIdTransaccion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic);
            this.lblIdTransaccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblIdTransaccion.Location = new System.Drawing.Point(373, 141);
            this.lblIdTransaccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdTransaccion.Name = "lblIdTransaccion";
            this.lblIdTransaccion.Size = new System.Drawing.Size(138, 18);
            this.lblIdTransaccion.TabIndex = 15;
            this.lblIdTransaccion.Text = "Id Transaccion:";
            this.lblIdTransaccion.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblPago.Location = new System.Drawing.Point(439, 76);
            this.lblPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(271, 26);
            this.lblPago.TabIndex = 12;
            this.lblPago.Text = "Agregar un nuevo Pago";
            this.lblPago.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblDescripcion.Location = new System.Drawing.Point(401, 249);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(110, 18);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic);
            this.lblObservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblObservacion.Location = new System.Drawing.Point(391, 340);
            this.lblObservacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(116, 18);
            this.lblObservacion.TabIndex = 24;
            this.lblObservacion.Text = "Observacion:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic);
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblMonto.Location = new System.Drawing.Point(439, 292);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(65, 18);
            this.lblMonto.TabIndex = 26;
            this.lblMonto.Text = "Monto:";
            // 
            // lblMiembro
            // 
            this.lblMiembro.AutoSize = true;
            this.lblMiembro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic);
            this.lblMiembro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblMiembro.Location = new System.Drawing.Point(414, 387);
            this.lblMiembro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiembro.Name = "lblMiembro";
            this.lblMiembro.Size = new System.Drawing.Size(84, 18);
            this.lblMiembro.TabIndex = 28;
            this.lblMiembro.Text = "Miembro:";
            this.lblMiembro.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.AutoRoundedCorners = true;
            this.txtMonto.BorderRadius = 17;
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonto.DefaultText = "";
            this.txtMonto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMonto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMonto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMonto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonto.Location = new System.Drawing.Point(549, 275);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.PlaceholderText = "";
            this.txtMonto.SelectedText = "";
            this.txtMonto.Size = new System.Drawing.Size(200, 36);
            this.txtMonto.TabIndex = 30;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // txtIdTransaccion
            // 
            this.txtIdTransaccion.AutoRoundedCorners = true;
            this.txtIdTransaccion.BorderRadius = 17;
            this.txtIdTransaccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdTransaccion.DefaultText = "";
            this.txtIdTransaccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdTransaccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdTransaccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdTransaccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdTransaccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdTransaccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdTransaccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdTransaccion.Location = new System.Drawing.Point(549, 124);
            this.txtIdTransaccion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtIdTransaccion.Name = "txtIdTransaccion";
            this.txtIdTransaccion.PasswordChar = '\0';
            this.txtIdTransaccion.PlaceholderText = "";
            this.txtIdTransaccion.SelectedText = "";
            this.txtIdTransaccion.Size = new System.Drawing.Size(200, 36);
            this.txtIdTransaccion.TabIndex = 36;
            this.txtIdTransaccion.TextChanged += new System.EventHandler(this.txtIdTransaccion_TextChanged);
            // 
            // dtPickerFecha
            // 
            this.dtPickerFecha.Checked = true;
            this.dtPickerFecha.FillColor = System.Drawing.Color.White;
            this.dtPickerFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtPickerFecha.Location = new System.Drawing.Point(549, 179);
            this.dtPickerFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPickerFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPickerFecha.Name = "dtPickerFecha";
            this.dtPickerFecha.Size = new System.Drawing.Size(200, 36);
            this.dtPickerFecha.TabIndex = 37;
            this.dtPickerFecha.Value = new System.DateTime(2024, 11, 22, 7, 19, 31, 585);
            // 
            // lblMesesPagados
            // 
            this.lblMesesPagados.AutoSize = true;
            this.lblMesesPagados.Font = new System.Drawing.Font("Verdana", 11.14286F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesesPagados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblMesesPagados.Location = new System.Drawing.Point(692, 249);
            this.lblMesesPagados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMesesPagados.Name = "lblMesesPagados";
            this.lblMesesPagados.Size = new System.Drawing.Size(159, 18);
            this.lblMesesPagados.TabIndex = 41;
            this.lblMesesPagados.Text = "Mes/Meses Pagados";
            // 
            // nudMesesPagados
            // 
            this.nudMesesPagados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMesesPagados.BackColor = System.Drawing.Color.Teal;
            this.nudMesesPagados.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nudMesesPagados.Location = new System.Drawing.Point(550, 235);
            this.nudMesesPagados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudMesesPagados.MaxNum = 12F;
            this.nudMesesPagados.MinNum = 1F;
            this.nudMesesPagados.Name = "nudMesesPagados";
            this.nudMesesPagados.Precision = 0;
            this.nudMesesPagados.Size = new System.Drawing.Size(120, 32);
            this.nudMesesPagados.Step = 1F;
            this.nudMesesPagados.Style = CxFlatUI.CxFlatNumericUpDown.NumericStyle.LeftRight;
            this.nudMesesPagados.TabIndex = 42;
            this.nudMesesPagados.Text = "nudMesPagados";
            this.nudMesesPagados.ValueNumber = 0F;
            this.nudMesesPagados.Click += new System.EventHandler(this.nudMesesPagados_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.AutoRoundedCorners = true;
            this.txtObservacion.BorderRadius = 17;
            this.txtObservacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservacion.DefaultText = "";
            this.txtObservacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtObservacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtObservacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtObservacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtObservacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtObservacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtObservacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtObservacion.Location = new System.Drawing.Point(549, 322);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasswordChar = '\0';
            this.txtObservacion.PlaceholderText = "";
            this.txtObservacion.SelectedText = "";
            this.txtObservacion.Size = new System.Drawing.Size(200, 36);
            this.txtObservacion.TabIndex = 32;
            this.txtObservacion.TextChanged += new System.EventHandler(this.txtObservacion_TextChanged);
            // 
            // txtBuscarMiembro
            // 
            this.txtBuscarMiembro.AutoRoundedCorners = true;
            this.txtBuscarMiembro.BorderRadius = 17;
            this.txtBuscarMiembro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarMiembro.DefaultText = "";
            this.txtBuscarMiembro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarMiembro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarMiembro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarMiembro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarMiembro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarMiembro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarMiembro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarMiembro.Location = new System.Drawing.Point(548, 370);
            this.txtBuscarMiembro.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBuscarMiembro.Name = "txtBuscarMiembro";
            this.txtBuscarMiembro.PasswordChar = '\0';
            this.txtBuscarMiembro.PlaceholderText = "Buscar miembro por ID o CIF";
            this.txtBuscarMiembro.SelectedText = "";
            this.txtBuscarMiembro.Size = new System.Drawing.Size(200, 36);
            this.txtBuscarMiembro.TabIndex = 43;
            this.txtBuscarMiembro.TextChanged += new System.EventHandler(this.txtBuscarMiembro_TextChanged);
            // 
            // dgvMiembros
            // 
            this.dgvMiembros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiembros.Location = new System.Drawing.Point(549, 413);
            this.dgvMiembros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMiembros.Name = "dgvMiembros";
            this.dgvMiembros.ReadOnly = true;
            this.dgvMiembros.RowHeadersWidth = 72;
            this.dgvMiembros.RowTemplate.Height = 31;
            this.dgvMiembros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMiembros.Size = new System.Drawing.Size(263, 79);
            this.dgvMiembros.TabIndex = 45;
            this.dgvMiembros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMiembros_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoRoundedCorners = true;
            this.btnBuscar.BorderRadius = 17;
            this.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::JaguarGymApp_Preview.Properties.Resources.buscarPNG;
            this.btnBuscar.Location = new System.Drawing.Point(755, 370);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 36);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::JaguarGymApp_Preview.Properties.Resources.Logo_redondo;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(5, 78);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(137, 137);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2CirclePictureBox1.TabIndex = 20;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblMiembroSeleccionado
            // 
            this.lblMiembroSeleccionado.AutoSize = true;
            this.lblMiembroSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiembroSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblMiembroSeleccionado.Location = new System.Drawing.Point(547, 499);
            this.lblMiembroSeleccionado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiembroSeleccionado.Name = "lblMiembroSeleccionado";
            this.lblMiembroSeleccionado.Size = new System.Drawing.Size(137, 13);
            this.lblMiembroSeleccionado.TabIndex = 46;
            this.lblMiembroSeleccionado.Text = "Miembro seleccionado:";
            this.lblMiembroSeleccionado.Click += new System.EventHandler(this.lblMiembroSeleccionado_Click);
            // 
            // txtMiembroSeleccionado
            // 
            this.txtMiembroSeleccionado.AutoRoundedCorners = true;
            this.txtMiembroSeleccionado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMiembroSeleccionado.BorderRadius = 11;
            this.txtMiembroSeleccionado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMiembroSeleccionado.DefaultText = "";
            this.txtMiembroSeleccionado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMiembroSeleccionado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMiembroSeleccionado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiembroSeleccionado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiembroSeleccionado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiembroSeleccionado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMiembroSeleccionado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiembroSeleccionado.Location = new System.Drawing.Point(681, 499);
            this.txtMiembroSeleccionado.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMiembroSeleccionado.Name = "txtMiembroSeleccionado";
            this.txtMiembroSeleccionado.PasswordChar = '\0';
            this.txtMiembroSeleccionado.PlaceholderText = "";
            this.txtMiembroSeleccionado.ReadOnly = true;
            this.txtMiembroSeleccionado.SelectedText = "";
            this.txtMiembroSeleccionado.Size = new System.Drawing.Size(131, 24);
            this.txtMiembroSeleccionado.TabIndex = 47;
            // 
            // Ingresar_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 568);
            this.Controls.Add(this.txtMiembroSeleccionado);
            this.Controls.Add(this.lblMiembroSeleccionado);
            this.Controls.Add(this.dgvMiembros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarMiembro);
            this.Controls.Add(this.nudMesesPagados);
            this.Controls.Add(this.lblMesesPagados);
            this.Controls.Add(this.dtPickerFecha);
            this.Controls.Add(this.txtIdTransaccion);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMiembro);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.LinkAtras);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblFechaRealizacion);
            this.Controls.Add(this.lblIdTransaccion);
            this.Controls.Add(this.lblPago);
            this.MaximizeBox = false;
            this.Name = "Ingresar_Pago";
            this.Text = "Ingresar_Pago";
            this.Load += new System.EventHandler(this.Ingresar_Pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.LinkLabel LinkAtras;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private System.Windows.Forms.Label lblFechaRealizacion;
        private System.Windows.Forms.Label lblIdTransaccion;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblMiembro;
        private Guna.UI2.WinForms.Guna2TextBox txtMonto;
        private Guna.UI2.WinForms.Guna2TextBox txtIdTransaccion;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtPickerFecha;
        private System.Windows.Forms.Label lblMesesPagados;
        private CxFlatUI.CxFlatNumericUpDown nudMesesPagados;
        private Guna.UI2.WinForms.Guna2TextBox txtObservacion;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarMiembro;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvMiembros;
        private System.Windows.Forms.Label lblMiembroSeleccionado;
        private Guna.UI2.WinForms.Guna2TextBox txtMiembroSeleccionado;
    }
}