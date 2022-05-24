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
    public partial class FormEditarPartit : Form
    {
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
            //
            txtEquipVisitantEditar.Visible = true;
            txtEquipLocalEditar.Visible = true;
            txtTemporadaEditar.Visible = true;
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
            //DateTime fecha = new DateTime();
            //fecha = Convert.ToDateTime(dateTimePickerAñadir.Value.ToString());
            user.AñadirPartidoUser(txtEquipLocalAñadir.Text, txtEquipVisitantAñadir.Text, txtEstatPartitAñadir.Text, Convert.ToInt32(txtGoLocalAñadir.Text), Convert.ToInt32(txtGolVisitantAñadir.Text), txtJornadaAñadir.Text, txtTemporadaAñadir.Text, dateTimePickerAñadir.Value);
        }

        private void msgError(string msg)
        {
            lblMssgErrorAñadir.Text = msg;
            lblMssgErrorAñadir.Visible = true;
        }

        private void btnEnviarEliminar_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            user.EliminarPartidoUser(txtEquipLocalEliminar.Text, txtEquipVisitantEliminar.Text, txtTemporadaEliminar.Text);
        }
    }
}
