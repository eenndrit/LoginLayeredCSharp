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
using System.Threading;

namespace PorraGironaOfficial
{
    public partial class FormEditarPartit : Form
    {
        UserModel cn = new UserModel();
        public FormEditarPartit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAfegirPartit_Click(object sender, EventArgs e)
        {
            if(btnEditarPartido.Visible == true || btnEliminarPartido.Visible == true)
            {
                btnEditarPartido.Visible = false;
                btnEliminarPartido.Visible = false;
            }
            //Aqui lo que hago es que si clica el boton para añadir partidos le muestro estos campos
            lblEquipVisitantAñadir.Visible = true;
            lblEstatPartitAñadir.Visible = true;
            lblGolLocalAñadir.Visible = true;
            lblJornadaAñadir.Visible = true;
            lblGolVisitantAñadir.Visible = true;
            labelEquipLocalAñadir.Visible = true;
            lblTemporadaAñadir.Visible = true;
            lblDataAñadir.Visible = true;
            //
            txtEquipLocalAñadir.Visible = true;
            txtEquipVisitantAñadir.Visible = true;
            txtEstatPartitAñadir.Visible = true;
            txtGoLocalAñadir.Visible = true;
            txtGolVisitantAñadir.Visible = true;
            txtJornadaAñadir.Visible = true;
            txtTemporadaAñadir.Visible = true;
            dateTimePickerAñadir.Visible = true;
            //
            btnEnviarAñadir.Visible = true;
            //
            //el focus este lo que hace es centrarse en este txt
            txtEquipLocalAñadir.Focus();
            //
            btnBack.Visible = true;
        }

        private void btnEditarPartido_Click(object sender, EventArgs e)
        {
            if(btnAfegirPartit.Visible == true || btnEliminarPartido.Visible == true)
            {
                btnAfegirPartit.Visible = false;
                btnEliminarPartido.Visible = false;
            }
            //Aqui lo que hago es que si clica el boton para editar partidos le muestro estos campos
            lblEquipLocalEditar.Visible = true;
            lblEquipVisitantEditar.Visible = true;
            lblTemporadaEditar.Visible = true;
            lblESconfirmar.Visible = true;
            lblGLconfirmar.Visible = true;
            lblGVconfirmar.Visible = true;
            //
            txtEquipVisitantEditar.Visible = true;
            txtEquipLocalEditar.Visible = true;
            txtTemporadaEditar.Visible = true;
            txtESconfirmar.Visible = true;
            txtGLconfirmar.Visible = true;
            txtGVconfirmar.Visible = true;
            //
            btnEnviarEditar.Visible = true;
            //
            //el focus este lo que hace es centrarse en este txt
            txtEquipLocalEditar.Focus();
            //
            btnBack.Visible = true;
        }

        private void btnEliminarPartido_Click(object sender, EventArgs e)
        {
            if(btnAfegirPartit.Visible == true || btnEditarPartido.Visible == true)
            {
                btnAfegirPartit.Visible = false;
                btnEditarPartido.Visible = false;
            }
            //Aqui lo que hago es que si clica el boton para eliminar partidos le muestro estos campos
            lblEquipLocalEliminar.Visible = true;
            lblEquipVisitantEliminar.Visible = true;
            lblTemporadaEliminar.Visible = true;
            //
            txtEquipLocalEliminar.Visible = true;
            txtEquipVisitantEliminar.Visible = true;
            txtTemporadaEliminar.Visible = true;
            //
            btnEnviarEliminar.Visible = true;
            //
            //el focus este lo que hace es centrarse en este txt
            txtEquipLocalEliminar.Focus();
            //
            btnBack.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEditarPartit menuPartitAdmin = new FormEditarPartit();
            menuPartitAdmin.Show();
        }

        private void btnVolverMenuAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdmin menuAdmin = new FormMenuAdmin();
            menuAdmin.Show();
        }

        private void btnEnviarAñadir_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            var validPartit = user.AñadirPartidoUser(txtEquipLocalAñadir.Text, txtEquipVisitantAñadir.Text, txtEstatPartitAñadir.Text, Convert.ToInt32(txtGoLocalAñadir.Text), Convert.ToInt32(txtGolVisitantAñadir.Text), txtJornadaAñadir.Text, txtTemporadaAñadir.Text, dateTimePickerAñadir.Value);
            if (validPartit == true)
            {
                msgError("Este partido ya existe");
                txtEquipLocalAñadir.Clear();
                txtEquipVisitantAñadir.Clear();
                txtEstatPartitAñadir.Clear();
                txtGoLocalAñadir.Clear();
                txtGolVisitantAñadir.Clear();
                txtJornadaAñadir.Clear();
                txtTemporadaAñadir.Clear();
                txtEquipLocalAñadir.Focus();
            }
            else
            {
                msgError("Partido añadido");
                txtEquipLocalAñadir.Clear();
                txtEquipVisitantAñadir.Clear();
                txtEstatPartitAñadir.Clear();
                txtGoLocalAñadir.Clear();
                txtGolVisitantAñadir.Clear();
                txtJornadaAñadir.Clear();
                txtTemporadaAñadir.Clear();
            }
        }

        private void btnEnviarEliminar_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            var validPartit = user.EliminarPartidoUser(txtEquipLocalEliminar.Text, txtEquipVisitantEliminar.Text, txtTemporadaEliminar.Text);
            if(validPartit == true)
            {
                msgError2("Partido eliminado");
                txtEquipLocalEliminar.Clear();
                txtEquipVisitantEliminar.Clear();
                txtTemporadaEliminar.Clear();
            }
            else
            {
                msgError2("Partido inexistente");
                txtEquipLocalEliminar.Clear();
                txtEquipVisitantEliminar.Clear();
                txtTemporadaEliminar.Clear();
                txtEquipLocalEliminar.Focus();
            }
        }

        private void btnEnviarEditar_Click(object sender, EventArgs e)
        {
            string equipLocal = txtEquipLocalEditar.Text;
            string equipVisitant = txtEquipVisitantEditar.Text;
            string temporada = txtTemporadaEditar.Text;
            string estat = txtESconfirmar.Text;
            //int golLocal = Convert.ToInt32(txtGLconfirmar.Text);
            //int golVisitant = Convert.ToInt32(txtGVconfirmar.Text);

            UserModel user = new UserModel();
            var validEditarPartit = user.EditarPartidoCreadoUser(equipLocal, equipVisitant, temporada, Convert.ToInt32(txtGLconfirmar.Text), Convert.ToInt32(txtGVconfirmar.Text), estat);
            if(validEditarPartit == false)
            {
                msgError3("Partido inexistente");
                txtEquipLocalEditar.Clear();
                txtEquipVisitantEditar.Clear();
                txtTemporadaEditar.Clear();
                txtGLconfirmar.Clear();
                txtGVconfirmar.Clear();
                txtESconfirmar.Clear();
                txtEquipLocalEditar.Focus();
            }
            else
            {
                msgError3("Partido modificado");
            }
        }

        private void msgError(string msg)
        {
            lblMssgErrorAñadir.Text = msg;
            lblMssgErrorAñadir.Visible = true;
        }
        private void msgError2(string msg)
        {
            lblMssgErrorEliminar.Text = msg;
            lblMssgErrorEliminar.Visible = true;
        }
        private void msgError3(string msg)
        {
            lblMsgErrorEditar.Text = msg;
            lblMsgErrorEditar.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            var validEditarPartit = user.EditarPartidoCreadoUser(txtEquipLocalEditar.Text, txtEquipVisitantEditar.Text, txtTemporadaEditar.Text, Convert.ToInt32(txtGLconfirmar.Text), Convert.ToInt32(txtGVconfirmar.Text), txtESconfirmar.Text);
        }

        private void btnVerPartidos_Click(object sender, EventArgs e)
        {
            btnBack.Visible = true;
            dataGridView1.Visible = true;
            dataGridView1.Location = new Point(13, 112);
            dataGridView1.DataSource = cn.ConsultaDT();
        }
    }
}
