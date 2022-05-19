using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PorraGironaOfficial
{
    public partial class FormCrearUsuari : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=porra";
        public FormCrearUsuari()
        {
            InitializeComponent();
            
        }

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(txtNombre.Text != "" && txtApellidos.Text != "" && txtAlias.Text != "" && txtPassword.Text != "" && txtNifDni.Text != "")
            {
                string nombre = txtNombre.Text.ToLower();
                string apellidos = txtApellidos.Text.ToLower();
                string alias = txtAlias.Text.ToLower();
                string password = txtPassword.Text.ToLower();
                string nif = txtNifDni.Text;
                string cmdText = "INSERT INTO Usuari(nom, cognoms, nif, alias, password, dataAlta) VALUES('" + nombre + "', '" + apellidos + "', '" + nif + "', '" + alias + "', '" + password + "', current_timestamp);";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(cmdText, connection);
                        int files_afectades = command.ExecuteNonQuery();
                        this.Close();
                        FormPrincipal FormPrincipal = new FormPrincipal();
                        FormPrincipal.Show();
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
            msgErrorCrearUser.Text = msg;
            msgErrorCrearUser.Visible = true;
        }
    }
}
