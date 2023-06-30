using Gimnasio_IronStrong_Fitness.Context;
using Gimnasio_IronStrong_Fitness.Models;
using Gimnasio_IronStrong_Fitness.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio_IronStrong_Fitness
{
    public partial class frmMenuPrincipal : Form
    {
        String _usuario;
        public frmMenuPrincipal(string usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblNomUsuario.Text = _usuario;
            frmImgMenu frmImgMenu = new frmImgMenu();
            AbrirFormulario(frmImgMenu);
            ModelGimnasio context = new ModelGimnasio();
            Usuario usuarioEncontrado = context.Usuario.FirstOrDefault(u => u.CuentaUsuario == _usuario);
            lblTipoRol.Text = usuarioEncontrado.RolUsuario;
            if (lblTipoRol.Text == "Recepcionista")
            {
                btnusuarios.Enabled = false;
                btnusuarios.Visible = false;
                btngastos.Location = new System.Drawing.Point(5, 370);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ibtnUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void ibtnUsuario_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ibtnInventario_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormulario(Form formulario) //funcion para abrir mas formularios
        {
            formulario.TopLevel = false; // Indicar que el formulario no es de nivel superior
            formulario.FormBorderStyle = FormBorderStyle.None; // Eliminar el borde del formulario
            formulario.Dock = DockStyle.Fill; // Ajustar el formulario al tamaño del contenedor
            panelContenedor.Controls.Clear(); // Limpiar los controles previos en el contenedor
            panelContenedor.Controls.Add(formulario); // Agregar el formulario al contenedor
            formulario.Show(); // Mostrar el formulario
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            frmGestionarUsuario frmGestionarUsuario = new frmGestionarUsuario();
            frmGestionarUsuario.MdiParent = this;
            AbrirFormulario(frmGestionarUsuario);
            lbltitulo.Text = "Usuarios";
        }

        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            foreach (Control control in panelContenedor.Controls)
            {
                if (control is Form formulario)
                {
                    formulario.Close(); // Cerrar la ventana secundaria (Form)
                }
            }
            frmImgMenu frmImgMenu = new frmImgMenu();
            AbrirFormulario(frmImgMenu);
            lbltitulo.Text = "Menu Principal";
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            frmGestionarClientes frmGestionarClientes = new frmGestionarClientes();
            frmGestionarClientes.MdiParent = this;
            AbrirFormulario(frmGestionarClientes);
            lbltitulo.Text = "Clientes";
        }
    }
}
