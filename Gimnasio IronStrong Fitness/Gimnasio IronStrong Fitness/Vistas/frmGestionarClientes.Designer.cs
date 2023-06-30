namespace Gimnasio_IronStrong_Fitness.Vistas
{
    partial class frmGestionarClientes
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
            System.Windows.Forms.Label nombreClienteLabel;
            System.Windows.Forms.Label telClienteLabel;
            System.Windows.Forms.Label ciClienteLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.PlanCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnImageeditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnImageasistencia = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnImageborrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxCI = new System.Windows.Forms.CheckBox();
            this.checkBoxNombre = new System.Windows.Forms.CheckBox();
            this.checkBoxTelefono = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idClienteLabel1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.ciClienteTextBox = new System.Windows.Forms.TextBox();
            this.telClienteTextBox = new System.Windows.Forms.TextBox();
            this.nombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.ibtnRegAsis = new FontAwesome.Sharp.IconButton();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreClienteLabel = new System.Windows.Forms.Label();
            telClienteLabel = new System.Windows.Forms.Label();
            ciClienteLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreClienteLabel
            // 
            nombreClienteLabel.AutoSize = true;
            nombreClienteLabel.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Bold);
            nombreClienteLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            nombreClienteLabel.Location = new System.Drawing.Point(7, 39);
            nombreClienteLabel.Name = "nombreClienteLabel";
            nombreClienteLabel.Size = new System.Drawing.Size(115, 18);
            nombreClienteLabel.TabIndex = 0;
            nombreClienteLabel.Text = "Nombre completo:";
            // 
            // telClienteLabel
            // 
            telClienteLabel.AutoSize = true;
            telClienteLabel.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Bold);
            telClienteLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            telClienteLabel.Location = new System.Drawing.Point(7, 149);
            telClienteLabel.Name = "telClienteLabel";
            telClienteLabel.Size = new System.Drawing.Size(62, 18);
            telClienteLabel.TabIndex = 2;
            telClienteLabel.Text = "Teléfono:";
            // 
            // ciClienteLabel
            // 
            ciClienteLabel.AutoSize = true;
            ciClienteLabel.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Bold);
            ciClienteLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            ciClienteLabel.Location = new System.Drawing.Point(7, 203);
            ciClienteLabel.Name = "ciClienteLabel";
            ciClienteLabel.Size = new System.Drawing.Size(24, 18);
            ciClienteLabel.TabIndex = 4;
            ciClienteLabel.Text = "CI:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Bold);
            idClienteLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            idClienteLabel.Location = new System.Drawing.Point(99, 11);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(24, 18);
            idClienteLabel.TabIndex = 24;
            idClienteLabel.Text = "ID:";
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clienteDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.clienteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clienteDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clienteDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clienteDataGridView.ColumnHeadersHeight = 26;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.PlanCliente,
            this.BtnImageeditar,
            this.BtnImageasistencia,
            this.BtnImageborrar});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.EnableHeadersVisualStyles = false;
            this.clienteDataGridView.Location = new System.Drawing.Point(12, 56);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clienteDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Agdasima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(135)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.clienteDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.clienteDataGridView.Size = new System.Drawing.Size(651, 477);
            this.clienteDataGridView.TabIndex = 1;
            // 
            // PlanCliente
            // 
            this.PlanCliente.FillWeight = 98.90017F;
            this.PlanCliente.HeaderText = "Plan";
            this.PlanCliente.Name = "PlanCliente";
            this.PlanCliente.ReadOnly = true;
            // 
            // BtnImageeditar
            // 
            this.BtnImageeditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BtnImageeditar.FillWeight = 106.599F;
            this.BtnImageeditar.HeaderText = "";
            this.BtnImageeditar.Name = "BtnImageeditar";
            this.BtnImageeditar.ReadOnly = true;
            this.BtnImageeditar.Width = 40;
            // 
            // BtnImageasistencia
            // 
            this.BtnImageasistencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BtnImageasistencia.FillWeight = 98.90017F;
            this.BtnImageasistencia.HeaderText = "";
            this.BtnImageasistencia.Name = "BtnImageasistencia";
            this.BtnImageasistencia.ReadOnly = true;
            this.BtnImageasistencia.Width = 40;
            // 
            // BtnImageborrar
            // 
            this.BtnImageborrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BtnImageborrar.FillWeight = 98.90017F;
            this.BtnImageborrar.HeaderText = "";
            this.BtnImageborrar.Name = "BtnImageborrar";
            this.BtnImageborrar.ReadOnly = true;
            this.BtnImageborrar.Width = 40;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Agdasima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(355, 28);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnnuevo.FlatAppearance.BorderSize = 0;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Agdasima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(436, 28);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 3;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Agdasima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 25);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agdasima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar por:";
            // 
            // checkBoxCI
            // 
            this.checkBoxCI.AutoSize = true;
            this.checkBoxCI.Font = new System.Drawing.Font("Agdasima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCI.Location = new System.Drawing.Point(145, 6);
            this.checkBoxCI.Name = "checkBoxCI";
            this.checkBoxCI.Size = new System.Drawing.Size(36, 21);
            this.checkBoxCI.TabIndex = 6;
            this.checkBoxCI.Text = "CI";
            this.checkBoxCI.UseVisualStyleBackColor = true;
            // 
            // checkBoxNombre
            // 
            this.checkBoxNombre.AutoSize = true;
            this.checkBoxNombre.Font = new System.Drawing.Font("Agdasima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNombre.Location = new System.Drawing.Point(76, 6);
            this.checkBoxNombre.Name = "checkBoxNombre";
            this.checkBoxNombre.Size = new System.Drawing.Size(66, 21);
            this.checkBoxNombre.TabIndex = 7;
            this.checkBoxNombre.Text = "Nombre";
            this.checkBoxNombre.UseVisualStyleBackColor = true;
            // 
            // checkBoxTelefono
            // 
            this.checkBoxTelefono.AutoSize = true;
            this.checkBoxTelefono.Font = new System.Drawing.Font("Agdasima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTelefono.Location = new System.Drawing.Point(187, 6);
            this.checkBoxTelefono.Name = "checkBoxTelefono";
            this.checkBoxTelefono.Size = new System.Drawing.Size(69, 21);
            this.checkBoxTelefono.TabIndex = 8;
            this.checkBoxTelefono.Text = "Teléfono";
            this.checkBoxTelefono.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(idClienteLabel);
            this.panel1.Controls.Add(this.idClienteLabel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btncancelar);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(ciClienteLabel);
            this.panel1.Controls.Add(this.ciClienteTextBox);
            this.panel1.Controls.Add(telClienteLabel);
            this.panel1.Controls.Add(this.telClienteTextBox);
            this.panel1.Controls.Add(nombreClienteLabel);
            this.panel1.Controls.Add(this.nombreClienteTextBox);
            this.panel1.Location = new System.Drawing.Point(671, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 479);
            this.panel1.TabIndex = 9;
            // 
            // idClienteLabel1
            // 
            this.idClienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "IdCliente", true));
            this.idClienteLabel1.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Bold);
            this.idClienteLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.idClienteLabel1.Location = new System.Drawing.Point(121, 12);
            this.idClienteLabel1.Name = "idClienteLabel1";
            this.idClienteLabel1.Size = new System.Drawing.Size(59, 18);
            this.idClienteLabel1.TabIndex = 25;
            this.idClienteLabel1.Text = "XXXXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cliente";
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Agdasima", 12F);
            this.btncancelar.Location = new System.Drawing.Point(96, 433);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 34);
            this.btncancelar.TabIndex = 23;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Agdasima", 12F);
            this.btnguardar.Location = new System.Drawing.Point(15, 433);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 34);
            this.btnguardar.TabIndex = 22;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            // 
            // ciClienteTextBox
            // 
            this.ciClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CiCliente", true));
            this.ciClienteTextBox.Font = new System.Drawing.Font("Agdasima", 12F);
            this.ciClienteTextBox.Location = new System.Drawing.Point(10, 224);
            this.ciClienteTextBox.Name = "ciClienteTextBox";
            this.ciClienteTextBox.Size = new System.Drawing.Size(160, 26);
            this.ciClienteTextBox.TabIndex = 5;
            // 
            // telClienteTextBox
            // 
            this.telClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "TelCliente", true));
            this.telClienteTextBox.Font = new System.Drawing.Font("Agdasima", 12F);
            this.telClienteTextBox.Location = new System.Drawing.Point(10, 170);
            this.telClienteTextBox.Name = "telClienteTextBox";
            this.telClienteTextBox.Size = new System.Drawing.Size(160, 26);
            this.telClienteTextBox.TabIndex = 3;
            // 
            // nombreClienteTextBox
            // 
            this.nombreClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "NombreCliente", true));
            this.nombreClienteTextBox.Font = new System.Drawing.Font("Agdasima", 12F);
            this.nombreClienteTextBox.Location = new System.Drawing.Point(10, 60);
            this.nombreClienteTextBox.Multiline = true;
            this.nombreClienteTextBox.Name = "nombreClienteTextBox";
            this.nombreClienteTextBox.Size = new System.Drawing.Size(160, 72);
            this.nombreClienteTextBox.TabIndex = 1;
            // 
            // ibtnRegAsis
            // 
            this.ibtnRegAsis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnRegAsis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.ibtnRegAsis.FlatAppearance.BorderSize = 0;
            this.ibtnRegAsis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRegAsis.Font = new System.Drawing.Font("Agdasima", 12F);
            this.ibtnRegAsis.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.ibtnRegAsis.IconColor = System.Drawing.Color.DimGray;
            this.ibtnRegAsis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRegAsis.IconSize = 30;
            this.ibtnRegAsis.Location = new System.Drawing.Point(681, 493);
            this.ibtnRegAsis.Name = "ibtnRegAsis";
            this.ibtnRegAsis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ibtnRegAsis.Size = new System.Drawing.Size(162, 40);
            this.ibtnRegAsis.TabIndex = 11;
            this.ibtnRegAsis.Text = "Registrar Asistencia";
            this.ibtnRegAsis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnRegAsis.UseVisualStyleBackColor = false;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Gimnasio_IronStrong_Fitness.Models.Cliente);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NombreCliente";
            this.dataGridViewTextBoxColumn3.FillWeight = 98.90017F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre completo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CiCliente";
            this.dataGridViewTextBoxColumn2.FillWeight = 98.90017F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Ci";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TelCliente";
            this.dataGridViewTextBoxColumn4.FillWeight = 98.90017F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // frmGestionarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(863, 545);
            this.Controls.Add(this.ibtnRegAsis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxTelefono);
            this.Controls.Add(this.checkBoxNombre);
            this.Controls.Add(this.checkBoxCI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.clienteDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionarClientes";
            this.Text = "frmGestionarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxCI;
        private System.Windows.Forms.CheckBox checkBoxNombre;
        private System.Windows.Forms.CheckBox checkBoxTelefono;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ciClienteTextBox;
        private System.Windows.Forms.TextBox telClienteTextBox;
        private System.Windows.Forms.TextBox nombreClienteTextBox;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label idClienteLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanCliente;
        private System.Windows.Forms.DataGridViewImageColumn BtnImageeditar;
        private System.Windows.Forms.DataGridViewImageColumn BtnImageasistencia;
        private System.Windows.Forms.DataGridViewImageColumn BtnImageborrar;
        private FontAwesome.Sharp.IconButton ibtnRegAsis;
    }
}