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

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            lblNomEquipEliminar.Visible = true;
            txtNomEquipEliminar.Visible = true;
            btnEnviarEliminar.Visible = true;
            btnAñadirEquipo.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMenuAdmin menuAdmin = new FormMenuAdmin();
            menuAdmin.Owner = this;
            menuAdmin.Show();
            this.Hide();
        }

        private void btnEnviarAñadir_Click(object sender, EventArgs e)
        {
            if (txtNomEquipAñadir.Text != "" && txtNomEstadi.Text != "" && txtMunicipi.Text != "")
            {
                string nomEquip = txtNomEquipAñadir.Text.ToLower();
                string nomEstadi = txtNomEstadi.Text.ToLower();
                string nomMunicipi = txtMunicipi.Text.ToLower();
                string cmdText = "INSERT INTO Equip(nomEquip, nomCamp, municipi) VALUES('" + nomEquip + "', '" + nomEstadi + "', '" + nomMunicipi + "');";
                string cmdText2 = $"Select count(*) from Equip where nomEquip='{nomEquip}';";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        //MySqlCommand command2 = new MySqlCommand(cmdText2, connection);
                        //int files_afectades2 = command2.ExecuteNonQuery();
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
                msgError("Please enter all values");
            }
        }
        private void msgError(string msg)
        {
            lblMessageError.Text = msg;
            lblMessageError.Visible = true;
        }

        private void btnEnviarEliminar_Click(object sender, EventArgs e)
        {
            if(txtNomEquipEliminar.Text != "")
            {
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
                    MessageBox.Show("Error comanda INSERT: " + ex.Message);
                }
            }
            else
            {
                msgError("Equipo inexistente");
            }
        }
    }
}
