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

        //BOTON PARA CERRAR LA APLICACION
        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //BOTON PARA MINIMIZAR LA APLICACION
        private void btnMinimizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //BOTON PARA CREAR USUARIO
        private void button1_Click(object sender, EventArgs e)
        {
            //PRIMERO COMPRUEBO QUE NO HAYA DEJADO NINGUN CAMPO VACIO
            if(txtNombre.Text != "" && txtApellidos.Text != "" && txtAlias.Text != "" && txtPassword.Text != "" && txtNifDni.Text != "")
            {
                //GUARDO TODOS LOS VALORES EN VARIABLES, LOS PASO A MINUSCULA PARA GUARDARLOS
                string nombre = txtNombre.Text.ToLower();
                string apellidos = txtApellidos.Text.ToLower();
                string alias = txtAlias.Text.ToLower();
                string password = txtPassword.Text.ToLower();
                string nif = txtNifDni.Text;

                //CREO LA COMANDA PARA INSERIR LOS VALORES
                string cmdText = "INSERT INTO Usuari(nom, cognoms, nif, alias, password, dataAlta) VALUES('" + nombre + "', '" + apellidos + "', '" + nif + "', '" + alias + "', '" + password + "', current_timestamp);";

                try
                {
                    //UTILIZO UN USING, SE CERRARA AUTOMATICO AL FINALIZAR
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        //LE PASO LA COMANDA Y LA EJECUTA
                        MySqlCommand command = new MySqlCommand(cmdText, connection);
                        int files_afectades = command.ExecuteNonQuery();
                        this.Close();
                        //UNA VEZ HACE EL INSERT, ABRE EL MENU LOGIN PARA QUE EL USUARIO PUEDA ACCEDER
                        FormPrincipal FormPrincipal = new FormPrincipal();
                        FormPrincipal.Show();
                    }
                }
                catch (Exception ex)
                {
                    //EN CASO DE ERROR, NOS SALTARA MENSAJE CON EL ERROR
                    MessageBox.Show("Error comanda INSERT: " + ex.Message);
                }
            }
            else
            {
                //CON EL METODO MSGERROR, TENEMOS UN LABEL QUE SE CAMBIARA DEPENDIENDO DE LOS VALORES QUE FALTEN
                //LE MARCARA AL USUARIO QUE FALTAN VALORES POR RELLENAR
                msgError("Please enter all values");
            }
        }

        //METODO PARA EL LABEL, PARA MOSTRAR CAMPOS VACIONS
        private void msgError(string msg)
        {
            msgErrorCrearUser.Text = msg;
            msgErrorCrearUser.Visible = true;
        }

        //BOTON PARA VOLVER AL MENU LOGIN EN CASO DE QUE EL USUARIO QUIERA IR ALLI
        private void button2_Click(object sender, EventArgs e)
        {
            FormPrincipal menuPrincipal = new FormPrincipal();
            menuPrincipal.Owner = this;
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
