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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackUser_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menuAdmin = new FormMenuAdmin();
            menuAdmin.Owner = this;
            menuAdmin.Show();
            this.Hide();
        }

        private void btnEnviarEliminarUser_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            var validUserDelete = user.EliminarUsuarioUser(txtAliasEliminar.Text);
            if (validUserDelete == "2")
            {
                msgError("Usuario eliminado");
                txtAliasEliminar.Clear();
            }
            else if (validUserDelete == "0")
            {
                msgError("No puedes eliminar ADMIN");
                txtAliasEliminar.Clear();
                txtAliasEliminar.Focus();
            }
            else
            {
                msgError("Usuario inexistente");
                txtAliasEliminar.Clear();
                txtAliasEliminar.Focus();
            }
        }

        private void msgError(string msg)
        {
            lblMsgUser.Text = msg;
            lblMsgUser.Visible = true;
        }
    }
}
