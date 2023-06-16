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
            string cuenta = txtCuenta.Text;
            string password = txtPassword.Text;

            if (cuenta == "admin" && password == "12345")
            {
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(); 
                frmMenuPrincipal.ShowDialog();
                
            }
            else
                MessageBox.Show("Error! Cuenta o Password INCORRESTOS");
        }
    }
}
