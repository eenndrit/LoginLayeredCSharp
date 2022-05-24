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
                //PASO TODOS LOS VALORES A UNAS VARIABLES Y CREO LA COMANDA
                string nomEquip1 = txtNomEquipAñadir.Text.ToLower();
                string nomEstadi = txtNomEstadi.Text.ToLower();
                string nomMunicipi = txtMunicipi.Text.ToLower();
                string cmdText = "INSERT INTO Equip(nomEquip, nomCamp, municipi) VALUES('" + nomEquip1 + "', '" + nomEstadi + "', '" + nomMunicipi + "');";
                string cmdText2 = $"Select count(nomEquip) from Equip;";

                //CON UN TRY, EJECUTO LA COMANDA Y EN CASO DE ERROR ME SALTA ABAJO Y ME MUESTRA EL MENSAJE DE ERROR
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        MySqlCommand command2 = new MySqlCommand(cmdText2, connection);
                        int files_afectades2 = command2.ExecuteNonQuery();
                        //if (files_afectades2 != 0)
                        //{

                        //    msgError("Este equipo ya existe");
                        //    txtNomEquipAñadir.Clear();
                        //    txtNomEstadi.Clear();
                        //    txtMunicipi.Clear();
                        //    txtNomEquipAñadir.Focus();
                        //}
                        //else
                        //{
                            MySqlCommand command = new MySqlCommand(cmdText, connection);
                            int files_afectades = command.ExecuteNonQuery();
                            this.Close();
                            FormMenuAdmin menuAdmin = new FormMenuAdmin();
                            menuAdmin.Show();
                        //}
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error comanda INSERT: " + ex.Message);
                }
            }
            else
            {
                //SI NO A RELLENADO TODOS LOS CAMPOS LE MUESTRO ESTE MENSAJE POR UN LABEL
                msgError("Please enter all values");
            }
        }

        //CREO METODO PARA EL LABEL DE ERRORES
        private void msgError(string msg)
        {
            lblMessageError.Text = msg;
            lblMessageError.Visible = true;
        }

        //METODO PARA ELIMINAR EQUIPO
        private void btnEnviarEliminar_Click(object sender, EventArgs e)
        {
            //COMPRUEBO QUE NO DEJE EL CAMPO VACIO
            if(txtNomEquipEliminar.Text != "")
            {
                //CON UN TRY EJECUTO LA COMANDA
                try
                {
                    // ME FALTA MIRAR SI EL EQUIPO QUE QUIERO BORRAR EXISTE, EN ESE CASO MOSTRALA MENSAJE EN EL LABEL!!!!!!!!!!!!!!!!!!!!!!!!

                    string nomEquipEliminar = txtNomEquipEliminar.Text.ToLower();
                    string cmdText = $"Delete from Equip where nomEquip = '{nomEquipEliminar}';";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(cmdText, connection);
                        int files_afectades = command.ExecuteNonQuery();
                        msgError("Equipo borrado correctamente");
                        this.Close();
                        FormMenuAdmin menuAdmin = new FormMenuAdmin();
                        menuAdmin.Show();
                    }
                }
                catch (Exception ex)
                {
                    //EN CASO DE ERROR SALTA EL MENSAJE
                    MessageBox.Show("Error comanda INSERT: " + ex.Message);
                }
            }
            else
            {
                //LABEL QUE MOSTRARIA ESTER MENSAJE
                msgError("Equipo inexistente");
            }
        }
    }
}
