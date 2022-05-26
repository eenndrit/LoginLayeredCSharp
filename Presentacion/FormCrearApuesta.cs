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

        //BOTON PARA CERRAR LA APLICACIOM
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //BOTON PARA CAMBIAR AL MENU DEL USUARIO
        private void button3_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menuUser = new FormMenuPrincipal();
            menuUser.Show();
            this.Hide();
        }

        //BOTON PARA VER LOS PARTIDOS DISPONIBLES EN UN DATAGREEDVIEW
        private void btnVerPartidos_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = cn.ConsultaDT();
        }

        //BOTON PARA HACER LA APUESTA
        private void btnApostar_Click(object sender, EventArgs e)
        {
            string alias = txtAlias.Text;
            UserModel user = new UserModel();
            //HACEMOS UNA COMPROBACION, PARA VER SI FALLA O ES CORRECTA LA PORRA
            var validPorra = user.CrearPorraUser(alias, Convert.ToInt32(txtIDpartit.Text), Convert.ToInt32(txtGolLocal.Text), Convert.ToInt32(txtGolVisitant.Text));
            //SI ENTRA POR AQUI ES QUE EL USUARIO NO EXISTE
            if (validPorra == "1")
            {
                msgError("Usuario inexistente");
            }
            //SI ENTRA POR AQUI ES QUE EL PARTIDO NO EXISTE
            else if (validPorra == "2")
            {
                msgError("idPartido incorrecto");
            }
            //SI ENTRA POR AQUI, LOS GOLES SON INCORRECTOS(NEGATIVOS)
            else if (validPorra == "3")
            {
                msgError("ERROR: goles negativos");
            }
            //SINO, SE CREA LA APUESTA
            else
            {
                msgError("Apuesta creada");
                txtAlias.Clear();
                txtGolLocal.Clear();
                txtGolVisitant.Clear();
                txtIDpartit.Clear();
            }
        }

        //METODO PARA MOSTRAR MENSAJE EN EL LABEL
        private void msgError(string msg)
        {
            lblMsgError.Text = msg;
            lblMsgError.Visible = true;
        }
    }
}
