using Gimnasio_IronStrong_Fitness.Controladores;
using Gimnasio_IronStrong_Fitness.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio_IronStrong_Fitness.Vistas
{
    public partial class frmGestionarUsuario : Form
    {
        public frmGestionarUsuario()
        {
            InitializeComponent();
        }
        UsuarioController _usuarioController=new UsuarioController();
        //Para saber si el usuario es nuevo o estamos modificando al usuario
        bool _isNew = true;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGestionarUsuario_Load(object sender, EventArgs e)
        {
            CbxNombre.Checked= true;
            //Cuando cargue la pantalla muestre en el data gridviewer todos los usuarios de la bd
            usuarioBindingSource.DataSource = _usuarioController.GetAll();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            panelUsuario.Enabled = false;  //desabilita los atributos para agregar datos
            usuarioBindingSource.CancelEdit(); //elimina todo los datos que se ingresaron en los atributos
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public void Guardar()
        {
            var user = (Usuario)usuarioBindingSource.Current;
            if (_isNew == true)
            {
                _usuarioController.Create(user);
            }
            else 
            {
                _usuarioController.Update(user);
            }
            //deshabilitar el panel de atributos
            panelUsuario.Enabled = false;
            //actualizar el datagridviewer
            usuarioBindingSource.DataSource = _usuarioController.GetAll();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            //variable global _isNew es verdadera
            _isNew = true;
            //Habilitar el panel para escribir en los atributos
            panelUsuario.Enabled = true;
            //borrar todo lo que estaba escrito para agregar nuevos datos
            usuarioBindingSource.AddNew();
        }

        private void usuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string par = txtBuscar.Text;
            bool op = true; //de entrada esta seleccionado Nombre
            if (CbxCuenta.Checked == false) // si se selecciona Cuenta
            {
                op = false;
            }
            //que en el datagridviewer muestre todos los usuarios que cumplan con el parametro "par"
            usuarioBindingSource.DataSource = _usuarioController.Search(par,op);
        }

        private void usuarioDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == usuarioDataGridView.Columns["BtnImageeditar"].Index)
            {
                //cambiamos isnew por que no es nuevo sino que estamos editando uno ya existente
                _isNew = false;
                //habilita el panel para agregar los datos
                panelUsuario.Enabled = true;
            }
            if (e.ColumnIndex == usuarioDataGridView.Columns["BtnImageeliminar"].Index)
            {
                //recupera todo lo seleccionado por el usuario en el datagridview
                var user = (Usuario)usuarioBindingSource.Current;
                //mensaje
                DialogResult dlr = MessageBox.Show("¿Esta seguro de eliminar?", "Gimnasio",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                //si se presiona ok
                if (dlr == DialogResult.OK)
                { 
                    _usuarioController.Delete(user);
                }
                //actualice el datagridview
                usuarioBindingSource.DataSource = _usuarioController.GetAll();

            }
        }

        private void cuentaUsuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cuentaUsuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void nombreUsuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreUsuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void CbxNombre_Click(object sender, EventArgs e)
        {
            CbxCuenta.Checked = false;
        }

        private void CbxCuenta_Click(object sender, EventArgs e)
        {
            CbxNombre.Checked = false;
        }

        private void CbxCuenta_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
