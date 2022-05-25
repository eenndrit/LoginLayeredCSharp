using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Domain;

namespace PorraGironaOfficial
{
    public partial class FormEditarEquip : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=porra";
        public FormEditarEquip()
        {
            InitializeComponent();
        }

        //BOTON PARA ACTIVAR TODOS LOS CAMPOS PARA AÑADIR UN EQUIPO
        //YA QUE TODOS ESTOS CAMPOS ESTAN INVISIBLES, HASTA QUE EL ADMIN LO PIDA
        private void btnAñadirEquipo_Click(object sender, EventArgs e)
        {
            lblNomEquipAñadir.Visible = true;
            lblNomEstadi.Visible = true;
            lblMunicipi.Visible = true;
            txtNomEquipAñadir.Visible = true;
            txtNomEstadi.Visible = true;
            txtMunicipi.Visible = true;
            btnEnviarAñadir.Visible = true;
            btnEliminarEquipo.Visible = false;
        }

        //BOTON PARA ACTIVAR LOS CAMPOS PARA ELIMINAR UN EQUIPO
        //YA QUE ESTOS CAMPOS ESTAN OCULTOS
        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            lblNomEquipEliminar.Visible = true;
            txtNomEquipEliminar.Visible = true;
            btnEnviarEliminar.Visible = true;
            btnAñadirEquipo.Visible = false;
        }

        //BOTON PARA CERRAR LA APLICACION
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //BOTON PARA VOLVER ATRAS, AL MENU PRINCIPAL DEL ADMIN  
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menuAdmin = new FormMenuAdmin();
            menuAdmin.Owner = this;
            menuAdmin.Show();
            this.Hide();
        }

        //BOTON PARA AÑADIR EQUIPO
        private void btnEnviarAñadir_Click(object sender, EventArgs e)
        {
            //PRIMERO COMPRUEBO QUE NO HAYA DEJADO NINGUN CAMPO VACIO
            if (txtNomEquipAñadir.Text != "" && txtNomEstadi.Text != "" && txtMunicipi.Text != "")
            {
                string nomEquip1 = txtNomEquipAñadir.Text.ToLower();
                string nomEstadi = txtNomEstadi.Text.ToLower();
                string nomMunicipi = txtMunicipi.Text.ToLower();
                UserModel user = new UserModel();
                var validEquipo = user.AñadirEquipoUser(nomEquip1, nomEstadi, nomMunicipi);
                if(validEquipo == true)
                {
                    msgError("Este equipo ya existe");
                    txtMunicipi.Clear();
                    txtNomEquipAñadir.Clear();
                    txtNomEstadi.Clear();
                    txtNomEquipAñadir.Focus();
                }
                else
                {
                    msgError("Equipo añadido");
                    txtMunicipi.Clear();
                    txtNomEquipAñadir.Clear();
                    txtNomEstadi.Clear();
                }
            }
            else
            {
                //SI NO A RELLENADO TODOS LOS CAMPOS LE MUESTRO ESTE MENSAJE POR UN LABEL
                msgError("Please enter all values");
            }
        }

        //METODO PARA ELIMINAR EQUIPO
        private void btnEnviarEliminar_Click(object sender, EventArgs e)
        {
            //COMPRUEBO QUE NO DEJE EL CAMPO VACIO
            if(txtNomEquipEliminar.Text != "")
            {
                    string nomEquipEliminar = txtNomEquipEliminar.Text.ToLower();
                    UserModel user = new UserModel();
                    var validElimEquipo = user.EliminarEquipoUser(nomEquipEliminar);
                    if(validElimEquipo == true)
                    {
                        msgError2("Equipo eliminado");
                        txtNomEquipEliminar.Clear();
                    }
                    else
                    {
                        msgError2("Equipo inexistente");
                        txtNomEquipEliminar.Clear();
                        txtNomEquipEliminar.Focus();
                    }
            }
            else
            {
                //LABEL QUE MOSTRARIA ESTER MENSAJE
                msgError2("Enter values please");
            }
        }

        //CREO METODO PARA EL LABEL DE ERRORES
        private void msgError(string msg)
        {
            lblMessageError.Text = msg;
            lblMessageError.Visible = true;
        }

        private void msgError2(string msg)
        {
            lblMessageError2.Text = msg;
            lblMessageError2.Visible = true;
        }
    }
}
