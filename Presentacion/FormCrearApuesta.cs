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
    public partial class FormCrearApuesta : Form
    {
        UserModel cn = new UserModel();
        public FormCrearApuesta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menuUser = new FormMenuPrincipal();
            menuUser.Show();
            this.Hide();
        }

        private void btnVerPartidos_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = cn.ConsultaDT();
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            string alias = txtAlias.Text;
            UserModel user = new UserModel();
            var validPorra = user.CrearPorraUser(alias, Convert.ToInt32(txtIDpartit.Text), Convert.ToInt32(txtGolLocal.Text), Convert.ToInt32(txtGolVisitant.Text));
            if (validPorra == "1")
            {
                msgError("Usuario inexistente");
            }
            else if (validPorra == "2")
            {
                msgError("idPartido incorrecto");
            }
            else if (validPorra == "3")
            {
                msgError("ERROR: goles negativos");
            }
            else
            {
                msgError("Apuesta creada");
                txtAlias.Clear();
                txtGolLocal.Clear();
                txtGolVisitant.Clear();
                txtIDpartit.Clear();
            }
        }

        private void msgError(string msg)
        {
            lblMsgError.Text = msg;
            lblMsgError.Visible = true;
        }
    }
}
