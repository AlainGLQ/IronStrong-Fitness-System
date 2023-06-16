namespace Gimnasio_IronStrong_Fitness
{
    partial class frmMenuPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblTipoRol = new System.Windows.Forms.Label();
            this.ibtnClientes = new FontAwesome.Sharp.IconButton();
            this.ibtnEmpleados = new FontAwesome.Sharp.IconButton();
            this.ibtnSuscripciones = new FontAwesome.Sharp.IconButton();
            this.ibtnInventario = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.ibtnUsuario = new FontAwesome.Sharp.IconButton();
            this.ibtGastos = new FontAwesome.Sharp.IconButton();
            this.ibtnSalir = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.ibtnSalir);
            this.panel1.Controls.Add(this.ibtGastos);
            this.panel1.Controls.Add(this.ibtnUsuario);
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.ibtnInventario);
            this.panel1.Controls.Add(this.ibtnSuscripciones);
            this.panel1.Controls.Add(this.ibtnEmpleados);
            this.panel1.Controls.Add(this.ibtnClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 649);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.lblTipoRol);
            this.panel2.Controls.Add(this.lblRol);
            this.panel2.Controls.Add(this.lblNomUsuario);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(168, 615);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 34);
            this.panel2.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(40, 7);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 16);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Location = new System.Drawing.Point(103, 9);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(55, 16);
            this.lblNomUsuario.TabIndex = 1;
            this.lblNomUsuario.Text = "XXXXXX";
            this.lblNomUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(705, 7);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(31, 16);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Rol:";
            // 
            // lblTipoRol
            // 
            this.lblTipoRol.AutoSize = true;
            this.lblTipoRol.Location = new System.Drawing.Point(742, 9);
            this.lblTipoRol.Name = "lblTipoRol";
            this.lblTipoRol.Size = new System.Drawing.Size(55, 16);
            this.lblTipoRol.TabIndex = 3;
            this.lblTipoRol.Text = "XXXXXX";
            // 
            // ibtnClientes
            // 
            this.ibtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnClientes.FlatAppearance.BorderSize = 0;
            this.ibtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnClientes.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.ibtnClientes.IconColor = System.Drawing.Color.Black;
            this.ibtnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnClientes.Location = new System.Drawing.Point(0, 0);
            this.ibtnClientes.Name = "ibtnClientes";
            this.ibtnClientes.Size = new System.Drawing.Size(168, 75);
            this.ibtnClientes.TabIndex = 9;
            this.ibtnClientes.Text = "CLIENTES";
            this.ibtnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnClientes.UseVisualStyleBackColor = true;
            // 
            // ibtnEmpleados
            // 
            this.ibtnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnEmpleados.FlatAppearance.BorderSize = 0;
            this.ibtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEmpleados.IconChar = FontAwesome.Sharp.IconChar.BuildingUser;
            this.ibtnEmpleados.IconColor = System.Drawing.Color.Black;
            this.ibtnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEmpleados.Location = new System.Drawing.Point(0, 75);
            this.ibtnEmpleados.Name = "ibtnEmpleados";
            this.ibtnEmpleados.Size = new System.Drawing.Size(168, 75);
            this.ibtnEmpleados.TabIndex = 10;
            this.ibtnEmpleados.Text = "EMPLEADOS";
            this.ibtnEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnEmpleados.UseVisualStyleBackColor = true;
            // 
            // ibtnSuscripciones
            // 
            this.ibtnSuscripciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnSuscripciones.FlatAppearance.BorderSize = 0;
            this.ibtnSuscripciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSuscripciones.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.ibtnSuscripciones.IconColor = System.Drawing.Color.Black;
            this.ibtnSuscripciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSuscripciones.Location = new System.Drawing.Point(0, 150);
            this.ibtnSuscripciones.Name = "ibtnSuscripciones";
            this.ibtnSuscripciones.Size = new System.Drawing.Size(168, 75);
            this.ibtnSuscripciones.TabIndex = 11;
            this.ibtnSuscripciones.Text = "SUSCRIPCIONES";
            this.ibtnSuscripciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnSuscripciones.UseVisualStyleBackColor = true;
            // 
            // ibtnInventario
            // 
            this.ibtnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnInventario.FlatAppearance.BorderSize = 0;
            this.ibtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnInventario.IconChar = FontAwesome.Sharp.IconChar.PeopleCarryBox;
            this.ibtnInventario.IconColor = System.Drawing.Color.Black;
            this.ibtnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnInventario.Location = new System.Drawing.Point(0, 225);
            this.ibtnInventario.Name = "ibtnInventario";
            this.ibtnInventario.Size = new System.Drawing.Size(168, 75);
            this.ibtnInventario.TabIndex = 12;
            this.ibtnInventario.Text = "INVENTARIO";
            this.ibtnInventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnInventario.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(0, 300);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(168, 75);
            this.iconButton4.TabIndex = 13;
            this.iconButton4.Text = "REPORTES";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // ibtnUsuario
            // 
            this.ibtnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnUsuario.FlatAppearance.BorderSize = 0;
            this.ibtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnUsuario.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ibtnUsuario.IconColor = System.Drawing.Color.Black;
            this.ibtnUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnUsuario.Location = new System.Drawing.Point(0, 375);
            this.ibtnUsuario.Name = "ibtnUsuario";
            this.ibtnUsuario.Size = new System.Drawing.Size(168, 75);
            this.ibtnUsuario.TabIndex = 14;
            this.ibtnUsuario.Text = "USUARIO";
            this.ibtnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtnUsuario.UseVisualStyleBackColor = true;
            // 
            // ibtGastos
            // 
            this.ibtGastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtGastos.FlatAppearance.BorderSize = 0;
            this.ibtGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtGastos.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.ibtGastos.IconColor = System.Drawing.Color.Black;
            this.ibtGastos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtGastos.Location = new System.Drawing.Point(0, 450);
            this.ibtGastos.Name = "ibtGastos";
            this.ibtGastos.Size = new System.Drawing.Size(168, 75);
            this.ibtGastos.TabIndex = 15;
            this.ibtGastos.Text = "GASTOS";
            this.ibtGastos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ibtGastos.UseVisualStyleBackColor = true;
            // 
            // ibtnSalir
            // 
            this.ibtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ibtnSalir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ibtnSalir.IconChar = FontAwesome.Sharp.IconChar.PersonWalking;
            this.ibtnSalir.IconColor = System.Drawing.Color.Black;
            this.ibtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSalir.IconSize = 30;
            this.ibtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSalir.Location = new System.Drawing.Point(45, 560);
            this.ibtnSalir.Name = "ibtnSalir";
            this.ibtnSalir.Size = new System.Drawing.Size(81, 53);
            this.ibtnSalir.TabIndex = 16;
            this.ibtnSalir.Text = "Salir";
            this.ibtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSalir.UseVisualStyleBackColor = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(948, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.ShowInTaskbar = false;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTipoRol;
        private System.Windows.Forms.Label lblRol;
        private FontAwesome.Sharp.IconButton ibtnSalir;
        private FontAwesome.Sharp.IconButton ibtGastos;
        private FontAwesome.Sharp.IconButton ibtnUsuario;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton ibtnInventario;
        private FontAwesome.Sharp.IconButton ibtnSuscripciones;
        private FontAwesome.Sharp.IconButton ibtnEmpleados;
        private FontAwesome.Sharp.IconButton ibtnClientes;
    }
}