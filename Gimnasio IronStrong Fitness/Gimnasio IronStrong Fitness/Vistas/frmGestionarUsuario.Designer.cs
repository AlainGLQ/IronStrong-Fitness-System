namespace Gimnasio_IronStrong_Fitness.Vistas
{
    partial class frmGestionarUsuario
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
            System.Windows.Forms.Label cuentaUsuarioLabel;
            System.Windows.Forms.Label nombreUsuarioLabel;
            System.Windows.Forms.Label passwordUsuarioLabel;
            System.Windows.Forms.Label rolUsuarioLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarUsuario));
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnImageeditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnImageEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.CbxCuenta = new System.Windows.Forms.CheckBox();
            this.CbxNombre = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.rolUsuarioComboBox = new System.Windows.Forms.ComboBox();
            this.passwordUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.nombreUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.cuentaUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            cuentaUsuarioLabel = new System.Windows.Forms.Label();
            nombreUsuarioLabel = new System.Windows.Forms.Label();
            passwordUsuarioLabel = new System.Windows.Forms.Label();
            rolUsuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.panelUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuentaUsuarioLabel
            // 
            cuentaUsuarioLabel.AutoSize = true;
            cuentaUsuarioLabel.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cuentaUsuarioLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            cuentaUsuarioLabel.Location = new System.Drawing.Point(34, 37);
            cuentaUsuarioLabel.Name = "cuentaUsuarioLabel";
            cuentaUsuarioLabel.Size = new System.Drawing.Size(53, 18);
            cuentaUsuarioLabel.TabIndex = 21;
            cuentaUsuarioLabel.Text = "Cuenta:";
            // 
            // nombreUsuarioLabel
            // 
            nombreUsuarioLabel.AutoSize = true;
            nombreUsuarioLabel.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreUsuarioLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            nombreUsuarioLabel.Location = new System.Drawing.Point(6, 109);
            nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            nombreUsuarioLabel.Size = new System.Drawing.Size(107, 18);
            nombreUsuarioLabel.TabIndex = 22;
            nombreUsuarioLabel.Text = "Nombre Usuario:";
            nombreUsuarioLabel.Click += new System.EventHandler(this.nombreUsuarioLabel_Click);
            // 
            // passwordUsuarioLabel
            // 
            passwordUsuarioLabel.AutoSize = true;
            passwordUsuarioLabel.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordUsuarioLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            passwordUsuarioLabel.Location = new System.Drawing.Point(7, 68);
            passwordUsuarioLabel.Name = "passwordUsuarioLabel";
            passwordUsuarioLabel.Size = new System.Drawing.Size(80, 18);
            passwordUsuarioLabel.TabIndex = 23;
            passwordUsuarioLabel.Text = "Contraseña:";
            // 
            // rolUsuarioLabel
            // 
            rolUsuarioLabel.AutoSize = true;
            rolUsuarioLabel.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rolUsuarioLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            rolUsuarioLabel.Location = new System.Drawing.Point(12, 248);
            rolUsuarioLabel.Name = "rolUsuarioLabel";
            rolUsuarioLabel.Size = new System.Drawing.Size(31, 18);
            rolUsuarioLabel.TabIndex = 24;
            rolUsuarioLabel.Text = "Rol:";
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usuarioDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.usuarioDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuarioDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usuarioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usuarioDataGridView.ColumnHeadersHeight = 26;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.BtnImageeditar,
            this.BtnImageEliminar});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Agdasima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usuarioDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.usuarioDataGridView.EnableHeadersVisualStyles = false;
            this.usuarioDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(108)))), ((int)(((byte)(139)))));
            this.usuarioDataGridView.Location = new System.Drawing.Point(12, 55);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuarioDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Agdasima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(135)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.usuarioDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.usuarioDataGridView.Size = new System.Drawing.Size(654, 470);
            this.usuarioDataGridView.TabIndex = 4;
            this.usuarioDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuarioDataGridView_CellClick);
            this.usuarioDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuarioDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CuentaUsuario";
            this.dataGridViewTextBoxColumn1.FillWeight = 90.668F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Cuenta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreUsuario";
            this.dataGridViewTextBoxColumn2.FillWeight = 90.668F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Completo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PasswordUsuario";
            this.dataGridViewTextBoxColumn3.FillWeight = 90.668F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Contraseña";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RolUsuario";
            this.dataGridViewTextBoxColumn4.FillWeight = 90.668F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Cargo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // BtnImageeditar
            // 
            this.BtnImageeditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BtnImageeditar.FillWeight = 115.5006F;
            this.BtnImageeditar.HeaderText = "";
            this.BtnImageeditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnImageeditar.Image")));
            this.BtnImageeditar.Name = "BtnImageeditar";
            this.BtnImageeditar.ReadOnly = true;
            this.BtnImageeditar.ToolTipText = "Editar";
            this.BtnImageeditar.Width = 40;
            // 
            // BtnImageEliminar
            // 
            this.BtnImageEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BtnImageEliminar.FillWeight = 121.8274F;
            this.BtnImageEliminar.HeaderText = "";
            this.BtnImageEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnImageEliminar.Image")));
            this.BtnImageEliminar.Name = "BtnImageEliminar";
            this.BtnImageEliminar.ReadOnly = true;
            this.BtnImageEliminar.ToolTipText = "Eliminar";
            this.BtnImageEliminar.Width = 40;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Gimnasio_IronStrong_Fitness.Models.Usuario);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnbuscar.Location = new System.Drawing.Point(355, 27);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnnuevo.FlatAppearance.BorderSize = 0;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnnuevo.Location = new System.Drawing.Point(436, 27);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 6;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Agdasima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(12, 26);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(337, 25);
            this.txtBuscar.TabIndex = 7;
            // 
            // CbxCuenta
            // 
            this.CbxCuenta.AutoSize = true;
            this.CbxCuenta.BackColor = System.Drawing.Color.Transparent;
            this.CbxCuenta.Font = new System.Drawing.Font("Agdasima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCuenta.ForeColor = System.Drawing.Color.Black;
            this.CbxCuenta.Location = new System.Drawing.Point(151, 5);
            this.CbxCuenta.Name = "CbxCuenta";
            this.CbxCuenta.Size = new System.Drawing.Size(61, 21);
            this.CbxCuenta.TabIndex = 8;
            this.CbxCuenta.Text = "Cuenta";
            this.CbxCuenta.UseVisualStyleBackColor = false;
            this.CbxCuenta.CheckedChanged += new System.EventHandler(this.CbxCuenta_CheckedChanged);
            this.CbxCuenta.Click += new System.EventHandler(this.CbxCuenta_Click);
            // 
            // CbxNombre
            // 
            this.CbxNombre.AutoSize = true;
            this.CbxNombre.BackColor = System.Drawing.Color.Transparent;
            this.CbxNombre.Font = new System.Drawing.Font("Agdasima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxNombre.ForeColor = System.Drawing.Color.Black;
            this.CbxNombre.Location = new System.Drawing.Point(80, 5);
            this.CbxNombre.Name = "CbxNombre";
            this.CbxNombre.Size = new System.Drawing.Size(66, 21);
            this.CbxNombre.TabIndex = 9;
            this.CbxNombre.Text = "Nombre";
            this.CbxNombre.UseVisualStyleBackColor = false;
            this.CbxNombre.Click += new System.EventHandler(this.CbxNombre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agdasima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(7, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Usuarios";
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnguardar.Location = new System.Drawing.Point(17, 472);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 34);
            this.btnguardar.TabIndex = 20;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncancelar.Location = new System.Drawing.Point(98, 472);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 34);
            this.btncancelar.TabIndex = 21;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.panelUsuario.Controls.Add(rolUsuarioLabel);
            this.panelUsuario.Controls.Add(this.rolUsuarioComboBox);
            this.panelUsuario.Controls.Add(passwordUsuarioLabel);
            this.panelUsuario.Controls.Add(this.passwordUsuarioTextBox);
            this.panelUsuario.Controls.Add(nombreUsuarioLabel);
            this.panelUsuario.Controls.Add(this.nombreUsuarioTextBox);
            this.panelUsuario.Controls.Add(cuentaUsuarioLabel);
            this.panelUsuario.Controls.Add(this.cuentaUsuarioTextBox);
            this.panelUsuario.Controls.Add(this.btncancelar);
            this.panelUsuario.Controls.Add(this.btnguardar);
            this.panelUsuario.Controls.Add(this.label2);
            this.panelUsuario.Enabled = false;
            this.panelUsuario.Location = new System.Drawing.Point(674, 7);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(185, 518);
            this.panelUsuario.TabIndex = 11;
            // 
            // rolUsuarioComboBox
            // 
            this.rolUsuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "RolUsuario", true));
            this.rolUsuarioComboBox.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolUsuarioComboBox.FormattingEnabled = true;
            this.rolUsuarioComboBox.Items.AddRange(new object[] {
            "Recepcionista",
            "Gerente"});
            this.rolUsuarioComboBox.Location = new System.Drawing.Point(46, 244);
            this.rolUsuarioComboBox.Name = "rolUsuarioComboBox";
            this.rolUsuarioComboBox.Size = new System.Drawing.Size(129, 26);
            this.rolUsuarioComboBox.TabIndex = 25;
            // 
            // passwordUsuarioTextBox
            // 
            this.passwordUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "PasswordUsuario", true));
            this.passwordUsuarioTextBox.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordUsuarioTextBox.Location = new System.Drawing.Point(86, 65);
            this.passwordUsuarioTextBox.Name = "passwordUsuarioTextBox";
            this.passwordUsuarioTextBox.Size = new System.Drawing.Size(91, 26);
            this.passwordUsuarioTextBox.TabIndex = 24;
            // 
            // nombreUsuarioTextBox
            // 
            this.nombreUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NombreUsuario", true));
            this.nombreUsuarioTextBox.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuarioTextBox.Location = new System.Drawing.Point(10, 131);
            this.nombreUsuarioTextBox.Multiline = true;
            this.nombreUsuarioTextBox.Name = "nombreUsuarioTextBox";
            this.nombreUsuarioTextBox.Size = new System.Drawing.Size(167, 99);
            this.nombreUsuarioTextBox.TabIndex = 23;
            this.nombreUsuarioTextBox.TextChanged += new System.EventHandler(this.nombreUsuarioTextBox_TextChanged);
            // 
            // cuentaUsuarioTextBox
            // 
            this.cuentaUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CuentaUsuario", true));
            this.cuentaUsuarioTextBox.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuentaUsuarioTextBox.Location = new System.Drawing.Point(86, 35);
            this.cuentaUsuarioTextBox.Name = "cuentaUsuarioTextBox";
            this.cuentaUsuarioTextBox.Size = new System.Drawing.Size(91, 26);
            this.cuentaUsuarioTextBox.TabIndex = 22;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 115.5006F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.ToolTipText = "Editar";
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 121.8274F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.ToolTipText = "Eliminar";
            this.dataGridViewImageColumn2.Width = 40;
            // 
            // frmGestionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(866, 537);
            this.ControlBox = false;
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxNombre);
            this.Controls.Add(this.CbxCuenta);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.usuarioDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestionarUsuario";
            this.Load += new System.EventHandler(this.frmGestionarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.CheckBox CbxCuenta;
        private System.Windows.Forms.CheckBox CbxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.TextBox passwordUsuarioTextBox;
        private System.Windows.Forms.TextBox nombreUsuarioTextBox;
        private System.Windows.Forms.TextBox cuentaUsuarioTextBox;
        private System.Windows.Forms.ComboBox rolUsuarioComboBox;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn BtnImageeditar;
        private System.Windows.Forms.DataGridViewImageColumn BtnImageEliminar;
    }
}