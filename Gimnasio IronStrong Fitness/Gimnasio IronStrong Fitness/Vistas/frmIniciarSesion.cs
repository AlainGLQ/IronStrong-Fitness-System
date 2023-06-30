using Gimnasio_IronStrong_Fitness.Context;
using Gimnasio_IronStrong_Fitness.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio_IronStrong_Fitness
{
    public partial class frm_Login : Form
    {

        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            //Sirve para crear las clases a la base de datos
           //ModelGimnasio db = new ModelGimnasio();
           // var usuario = db.Usuario.ToList();
           // var cliente = db.Cliente.ToList();
           // var empleado = db.Empleado.ToList();
           // var suscripcion = db.Suscripcion.ToList();
           // var material = db.Material.ToList();
           // var compra = db.Compra.ToList();
           // var asistencia = db.Asistencia.ToList();
        }

        private void pictBox_loginImage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Pasword_Click(object sender, EventArgs e)
        {

        }

        private void txt_Cuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            UsuarioController usuarioController =new UsuarioController();
            bool isLogin = usuarioController.Login(usuario, password);
            if (isLogin == true)
            {
                //Pantalla Menu Principal
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(usuario);
                frmMenuPrincipal.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Error Usuario o Contraseña incorrectos",
                    "Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void iconButtonMostrar_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void btnvercontra_Click(object sender, EventArgs e)
        {
            btnocultarcontra.BringToFront();
            txtPassword.PasswordChar = '\0';
        }

        private void btnocultarcontra_Click(object sender, EventArgs e)
        {
            btnvercontra.BringToFront();
            txtPassword.PasswordChar = '*';
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
