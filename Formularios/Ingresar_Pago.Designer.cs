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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblMiembroSeleccionado = new System.Windows.Forms.Label();
            this.txtMiembroSeleccionado = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvMiembros = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembros)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkAtras
            // 
            this.LinkAtras.AutoSize = true;
            this.LinkAtras.LinkColor = System.Drawing.Color.Silver;
            this.LinkAtras.Location = new System.Drawing.Point(945, 682);
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
            this.btnAgregar.Animated = true;
            this.btnAgregar.AutoRoundedCorners = true;
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BorderRadius = 17;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(924, 634);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 37);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblFechaRealizacion
            // 
            this.lblFechaRealizacion.AutoSize = true;
            this.lblFechaRealizacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRealizacion.ForeColor = System.Drawing.Color.Black;
            this.lblFechaRealizacion.Location = new System.Drawing.Point(275, 294);
            this.lblFechaRealizacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaRealizacion.Name = "lblFechaRealizacion";
            this.lblFechaRealizacion.Size = new System.Drawing.Size(158, 18);
            this.lblFechaRealizacion.TabIndex = 17;
            this.lblFechaRealizacion.Text = "Fecha Realizacion:";
            // 
            // lblIdTransaccion
            // 
            this.lblIdTransaccion.AutoSize = true;
            this.lblIdTransaccion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTransaccion.ForeColor = System.Drawing.Color.Black;
            this.lblIdTransaccion.Location = new System.Drawing.Point(275, 147);
            this.lblIdTransaccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdTransaccion.Name = "lblIdTransaccion";
            this.lblIdTransaccion.Size = new System.Drawing.Size(133, 18);
            this.lblIdTransaccion.TabIndex = 15;
            this.lblIdTransaccion.Text = "Id Transaccion:";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.ForeColor = System.Drawing.Color.Black;
            this.lblPago.Location = new System.Drawing.Point(476, 85);
            this.lblPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(312, 28);
            this.lblPago.TabIndex = 12;
            this.lblPago.Text = "Agregar un nuevo Pago";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(662, 294);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(106, 18);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.ForeColor = System.Drawing.Color.Black;
            this.lblObservacion.Location = new System.Drawing.Point(662, 185);
            this.lblObservacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(115, 18);
            this.lblObservacion.TabIndex = 24;
            this.lblObservacion.Text = "Observacion:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.Black;
            this.lblMonto.Location = new System.Drawing.Point(275, 217);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(65, 18);
            this.lblMonto.TabIndex = 26;
            this.lblMonto.Text = "Monto:";
            // 
            // lblMiembro
            // 
            this.lblMiembro.AutoSize = true;
            this.lblMiembro.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiembro.ForeColor = System.Drawing.Color.Black;
            this.lblMiembro.Location = new System.Drawing.Point(275, 359);
            this.lblMiembro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiembro.Name = "lblMiembro";
            this.lblMiembro.Size = new System.Drawing.Size(85, 18);
            this.lblMiembro.TabIndex = 28;
            this.lblMiembro.Text = "Miembro:";
            // 
            // txtMonto
            // 
            this.txtMonto.AutoRoundedCorners = true;
            this.txtMonto.BorderRadius = 13;
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonto.DefaultText = "";
            this.txtMonto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMonto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMonto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMonto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonto.Location = new System.Drawing.Point(438, 217);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.PlaceholderText = "";
            this.txtMonto.SelectedText = "";
            this.txtMonto.Size = new System.Drawing.Size(200, 28);
            this.txtMonto.TabIndex = 30;
            // 
            // txtIdTransaccion
            // 
            this.txtIdTransaccion.AutoRoundedCorners = true;
            this.txtIdTransaccion.BorderRadius = 13;
            this.txtIdTransaccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdTransaccion.DefaultText = "";
            this.txtIdTransaccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdTransaccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdTransaccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdTransaccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdTransaccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdTransaccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdTransaccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdTransaccion.Location = new System.Drawing.Point(438, 147);
            this.txtIdTransaccion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtIdTransaccion.Name = "txtIdTransaccion";
            this.txtIdTransaccion.PasswordChar = '\0';
            this.txtIdTransaccion.PlaceholderText = "";
            this.txtIdTransaccion.SelectedText = "";
            this.txtIdTransaccion.Size = new System.Drawing.Size(198, 28);
            this.txtIdTransaccion.TabIndex = 36;
            // 
            // dtPickerFecha
            // 
            this.dtPickerFecha.BackColor = System.Drawing.SystemColors.Control;
            this.dtPickerFecha.Checked = true;
            this.dtPickerFecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(134)))));
            this.dtPickerFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPickerFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtPickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtPickerFecha.Location = new System.Drawing.Point(438, 285);
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
            this.lblMesesPagados.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesesPagados.ForeColor = System.Drawing.Color.Black;
            this.lblMesesPagados.Location = new System.Drawing.Point(902, 296);
            this.lblMesesPagados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMesesPagados.Name = "lblMesesPagados";
            this.lblMesesPagados.Size = new System.Drawing.Size(157, 16);
            this.lblMesesPagados.TabIndex = 41;
            this.lblMesesPagados.Text = "Mes/Meses Pagados";
            // 
            // nudMesesPagados
            // 
            this.nudMesesPagados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMesesPagados.BackColor = System.Drawing.Color.Teal;
            this.nudMesesPagados.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMesesPagados.Location = new System.Drawing.Point(772, 289);
            this.nudMesesPagados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.nudMesesPagados.MaxNum = 12F;
            this.nudMesesPagados.MinNum = 1F;
            this.nudMesesPagados.Name = "nudMesesPagados";
            this.nudMesesPagados.Precision = 0;
            this.nudMesesPagados.Size = new System.Drawing.Size(120, 32);
            this.nudMesesPagados.Step = 1F;
            this.nudMesesPagados.Style = CxFlatUI.CxFlatNumericUpDown.NumericStyle.LeftRight;
            this.nudMesesPagados.TabIndex = 42;
            this.nudMesesPagados.Text = "nudMesPagados";
            this.nudMesesPagados.ValueNumber = 1F;
            // 
            // txtObservacion
            // 
            this.txtObservacion.AutoRoundedCorners = true;
            this.txtObservacion.BorderRadius = 48;
            this.txtObservacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservacion.DefaultText = "";
            this.txtObservacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtObservacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtObservacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtObservacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtObservacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtObservacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtObservacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtObservacion.Location = new System.Drawing.Point(784, 147);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasswordChar = '\0';
            this.txtObservacion.PlaceholderText = "";
            this.txtObservacion.SelectedText = "";
            this.txtObservacion.Size = new System.Drawing.Size(275, 98);
            this.txtObservacion.TabIndex = 32;
            // 
            // txtBuscarMiembro
            // 
            this.txtBuscarMiembro.AutoRoundedCorners = true;
            this.txtBuscarMiembro.BorderRadius = 13;
            this.txtBuscarMiembro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarMiembro.DefaultText = "";
            this.txtBuscarMiembro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarMiembro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarMiembro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarMiembro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarMiembro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarMiembro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarMiembro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarMiembro.Location = new System.Drawing.Point(367, 354);
            this.txtBuscarMiembro.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBuscarMiembro.Name = "txtBuscarMiembro";
            this.txtBuscarMiembro.PasswordChar = '\0';
            this.txtBuscarMiembro.PlaceholderText = "Buscar miembro por ID o CIF";
            this.txtBuscarMiembro.SelectedText = "";
            this.txtBuscarMiembro.Size = new System.Drawing.Size(200, 28);
            this.txtBuscarMiembro.TabIndex = 43;
            // 
            // lblMiembroSeleccionado
            // 
            this.lblMiembroSeleccionado.AutoSize = true;
            this.lblMiembroSeleccionado.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiembroSeleccionado.ForeColor = System.Drawing.Color.Black;
            this.lblMiembroSeleccionado.Location = new System.Drawing.Point(282, 620);
            this.lblMiembroSeleccionado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiembroSeleccionado.Name = "lblMiembroSeleccionado";
            this.lblMiembroSeleccionado.Size = new System.Drawing.Size(158, 14);
            this.lblMiembroSeleccionado.TabIndex = 46;
            this.lblMiembroSeleccionado.Text = "Miembro seleccionado:";
            // 
            // txtMiembroSeleccionado
            // 
            this.txtMiembroSeleccionado.AutoRoundedCorners = true;
            this.txtMiembroSeleccionado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMiembroSeleccionado.BorderRadius = 18;
            this.txtMiembroSeleccionado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMiembroSeleccionado.DefaultText = "";
            this.txtMiembroSeleccionado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMiembroSeleccionado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMiembroSeleccionado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiembroSeleccionado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiembroSeleccionado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiembroSeleccionado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMiembroSeleccionado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiembroSeleccionado.Location = new System.Drawing.Point(447, 606);
            this.txtMiembroSeleccionado.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMiembroSeleccionado.Name = "txtMiembroSeleccionado";
            this.txtMiembroSeleccionado.PasswordChar = '\0';
            this.txtMiembroSeleccionado.PlaceholderText = "";
            this.txtMiembroSeleccionado.ReadOnly = true;
            this.txtMiembroSeleccionado.SelectedText = "";
            this.txtMiembroSeleccionado.Size = new System.Drawing.Size(421, 38);
            this.txtMiembroSeleccionado.TabIndex = 47;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox2);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(136)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(121)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-35, 59);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(290, 675);
            this.guna2GradientPanel1.TabIndex = 48;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::JaguarGymApp_Preview.Properties.Resources.Jaguares_UAM_redondo;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(90, 39);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(137, 137);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::JaguarGymApp_Preview.Properties.Resources.gym_7;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(41, 331);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(249, 319);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Animated = true;
            this.btnBuscar.AutoRoundedCorners = true;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BorderRadius = 17;
            this.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::JaguarGymApp_Preview.Properties.Resources.buscarPNG;
            this.btnBuscar.Location = new System.Drawing.Point(581, 350);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 36);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvMiembros
            // 
            this.dgvMiembros.AllowUserToAddRows = false;
            this.dgvMiembros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvMiembros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvMiembros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMiembros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMiembros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvMiembros.ColumnHeadersHeight = 35;
            this.dgvMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMiembros.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvMiembros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMiembros.Location = new System.Drawing.Point(285, 390);
            this.dgvMiembros.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMiembros.Name = "dgvMiembros";
            this.dgvMiembros.ReadOnly = true;
            this.dgvMiembros.RowHeadersVisible = false;
            this.dgvMiembros.RowHeadersWidth = 65;
            this.dgvMiembros.RowTemplate.Height = 24;
            this.dgvMiembros.Size = new System.Drawing.Size(774, 191);
            this.dgvMiembros.TabIndex = 49;
            this.dgvMiembros.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMiembros.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMiembros.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMiembros.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMiembros.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMiembros.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMiembros.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMiembros.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(134)))));
            this.dgvMiembros.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvMiembros.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMiembros.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMiembros.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMiembros.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvMiembros.ThemeStyle.ReadOnly = true;
            this.dgvMiembros.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMiembros.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMiembros.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMiembros.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMiembros.ThemeStyle.RowsStyle.Height = 24;
            this.dgvMiembros.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMiembros.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMiembros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMiembros_CellContentClick);
            // 
            // Ingresar_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.dgvMiembros);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.txtMiembroSeleccionado);
            this.Controls.Add(this.lblMiembroSeleccionado);
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
            this.Controls.Add(this.LinkAtras);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblFechaRealizacion);
            this.Controls.Add(this.lblIdTransaccion);
            this.Controls.Add(this.lblPago);
            this.MaximizeBox = false;
            this.Name = "Ingresar_Pago";
            this.Text = "Ingresar Pago";
            this.Load += new System.EventHandler(this.Ingresar_Pago_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label lblMiembroSeleccionado;
        private Guna.UI2.WinForms.Guna2TextBox txtMiembroSeleccionado;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMiembros;
    }
}