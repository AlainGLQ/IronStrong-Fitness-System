namespace Gimnasio_IronStrong_Fitness
{
    partial class frm_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.linkLbltmpower = new System.Windows.Forms.LinkLabel();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblPasword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnvercontra = new System.Windows.Forms.Button();
            this.pictBoxloginImage = new System.Windows.Forms.PictureBox();
            this.btnocultarcontra = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxloginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Agdasima", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblIniciarSesion.Location = new System.Drawing.Point(315, 95);
            this.lblIniciarSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(179, 36);
            this.lblIniciarSesion.TabIndex = 1;
            this.lblIniciarSesion.Text = "INICIAR SESION";
            // 
            // linkLbltmpower
            // 
            this.linkLbltmpower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLbltmpower.AutoSize = true;
            this.linkLbltmpower.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLbltmpower.Location = new System.Drawing.Point(398, 350);
            this.linkLbltmpower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLbltmpower.Name = "linkLbltmpower";
            this.linkLbltmpower.Size = new System.Drawing.Size(108, 13);
            this.linkLbltmpower.TabIndex = 3;
            this.linkLbltmpower.TabStop = true;
            this.linkLbltmpower.Text = "Acerca de TM Power";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCuenta.Location = new System.Drawing.Point(318, 144);
            this.lblCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(58, 18);
            this.lblCuenta.TabIndex = 4;
            this.lblCuenta.Text = "Usuario:";
            this.lblCuenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPasword
            // 
            this.lblPasword.AutoSize = true;
            this.lblPasword.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPasword.Location = new System.Drawing.Point(318, 197);
            this.lblPasword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasword.Name = "lblPasword";
            this.lblPasword.Size = new System.Drawing.Size(80, 18);
            this.lblPasword.TabIndex = 5;
            this.lblPasword.Text = "Contraseña:";
            this.lblPasword.Click += new System.EventHandler(this.lbl_Pasword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Agdasima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(321, 217);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(179, 24);
            this.txtPassword.TabIndex = 7;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresar.BackColor = System.Drawing.Color.SlateGray;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Agdasima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnIngresar.Location = new System.Drawing.Point(411, 262);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(89, 29);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Agdasima", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(321, 165);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(179, 24);
            this.txtUsuario.TabIndex = 9;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Controls.Add(this.btncerrar);
            this.BarraTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(517, 26);
            this.BarraTitulo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agdasima", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(207, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Bienvenido";
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.Color.SlateGray;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncerrar.Location = new System.Drawing.Point(492, 1);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(25, 25);
            this.btncerrar.TabIndex = 0;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnvercontra
            // 
            this.btnvercontra.BackColor = System.Drawing.Color.White;
            this.btnvercontra.FlatAppearance.BorderSize = 0;
            this.btnvercontra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvercontra.Image = ((System.Drawing.Image)(resources.GetObject("btnvercontra.Image")));
            this.btnvercontra.Location = new System.Drawing.Point(473, 217);
            this.btnvercontra.Name = "btnvercontra";
            this.btnvercontra.Size = new System.Drawing.Size(24, 24);
            this.btnvercontra.TabIndex = 12;
            this.btnvercontra.UseVisualStyleBackColor = false;
            this.btnvercontra.Click += new System.EventHandler(this.btnvercontra_Click);
            // 
            // pictBoxloginImage
            // 
            this.pictBoxloginImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictBoxloginImage.BackColor = System.Drawing.SystemColors.Control;
            this.pictBoxloginImage.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxloginImage.Image")));
            this.pictBoxloginImage.Location = new System.Drawing.Point(-1, 26);
            this.pictBoxloginImage.Margin = new System.Windows.Forms.Padding(2);
            this.pictBoxloginImage.Name = "pictBoxloginImage";
            this.pictBoxloginImage.Size = new System.Drawing.Size(301, 347);
            this.pictBoxloginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxloginImage.TabIndex = 0;
            this.pictBoxloginImage.TabStop = false;
            this.pictBoxloginImage.Click += new System.EventHandler(this.pictBox_loginImage_Click);
            // 
            // btnocultarcontra
            // 
            this.btnocultarcontra.BackColor = System.Drawing.Color.White;
            this.btnocultarcontra.FlatAppearance.BorderSize = 0;
            this.btnocultarcontra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnocultarcontra.Image = ((System.Drawing.Image)(resources.GetObject("btnocultarcontra.Image")));
            this.btnocultarcontra.Location = new System.Drawing.Point(473, 217);
            this.btnocultarcontra.Name = "btnocultarcontra";
            this.btnocultarcontra.Size = new System.Drawing.Size(24, 24);
            this.btnocultarcontra.TabIndex = 13;
            this.btnocultarcontra.UseVisualStyleBackColor = false;
            this.btnocultarcontra.Click += new System.EventHandler(this.btnocultarcontra_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(79)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(517, 372);
            this.Controls.Add(this.btnvercontra);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPasword);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.linkLbltmpower);
            this.Controls.Add(this.lblIniciarSesion);
            this.Controls.Add(this.pictBoxloginImage);
            this.Controls.Add(this.btnocultarcontra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxloginImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxloginImage;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.LinkLabel linkLbltmpower;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblPasword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnvercontra;
        private System.Windows.Forms.Button btnocultarcontra;
    }
}

