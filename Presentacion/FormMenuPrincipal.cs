using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;

namespace PorraGironaOfficial
{
    public partial class FormMenuPrincipal : Form
    {
        UserModel cn = new UserModel();
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        //BOTON PARA CERRAR SESION
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormPrincipal menuPrincipal = new FormPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        //BOTON PARA IR A HACER UNA APUESTA, AL FORM DE APUESTAS
        private void button1_Click(object sender, EventArgs e)
        {
            FormCrearApuesta menuCrearApuesta = new FormCrearApuesta();
            menuCrearApuesta.Show();
            this.Hide();
        }

        //BOTON PARA VER TODAS LAS PORRAS QUE SE HAN HECHO, EN UN DATAGRIDVIEW
        private void button3_Click(object sender, EventArgs e)
        {
            btnBack.Visible = true;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = cn.ConsultaDT2();
            dataGridView1.Location = new Point(338, 147);
        }

        //BOTON PARA VOLVER AL MENU PRINCIPAL DEL USUARIO
        private void button4_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
