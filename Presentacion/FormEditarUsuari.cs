using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace PorraGironaOfficial
{
    public partial class FormEditarUsuari : Form
    {
        public FormEditarUsuari()
        {
            InitializeComponent();
        }

        //BOTON CERRAR APP
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //BOTON VOLVER MENU ADMIN
        private void btnBackUser_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menuAdmin = new FormMenuAdmin();
            menuAdmin.Owner = this;
            menuAdmin.Show();
            this.Hide();
        }

        //BOTON PARA ELIMINAR USER
        private void btnEnviarEliminarUser_Click(object sender, EventArgs e)
        {
            //HACEMOS UNA COMPROBACION LLAMANDO AL METODO
            UserModel user = new UserModel();
            var validUserDelete = user.EliminarUsuarioUser(txtAliasEliminar.Text);
            //SI NOS DEVUELVE 2, ELIMINA EL USER YA QUE SI QUE EXISTE
            if (validUserDelete == "2")
            {
                msgError("Usuario eliminado");
                txtAliasEliminar.Clear();
            }
            //SI NOS DEVUELVE 0, ES QUE QUIERE ELIMINAR ADMIN, PERO NO SE PUEDE, ERROR
            else if (validUserDelete == "0")
            {
                msgError("No puedes eliminar ADMIN");
                txtAliasEliminar.Clear();
                txtAliasEliminar.Focus();
            }
            //SI NO, USUARIO INEXISTENTE, NO SE PUEDE ELIMINAR
            else
            {
                msgError("Usuario inexistente");
                txtAliasEliminar.Clear();
                txtAliasEliminar.Focus();
            }
        }

        //METODO PARA MOSTRAR MENSAJE EN LABEL
        private void msgError(string msg)
        {
            lblMsgUser.Text = msg;
            lblMsgUser.Visible = true;
        }
    }
}
