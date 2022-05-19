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
        //Strink con la base de datos
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=porra";
        public FormCrearUsuari()
        {
            InitializeComponent();
            
        }
        //botones para cerrar y guardar la pestaña-------------------
        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            Application.Exit();//cerrar
        }

        private void btnMinimizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//guardar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (txtNombre.Text != "")
            //{
            //    if (txtApellidos.Text != "")
            //    {
            //        if (txtAlias.Text != "")
            //        {
            //            if (txtPassword.Text != "")
            //            {
            //                if (txtNifDni.Text != "")
            //                {

            //                }
            //                else msgError("Please enter Nif or Dni");
            //            }
            //            else msgError("Please enter password");
            //        }
            //        else msgError("Please enter alias");
            //    }
            //    else msgError("Please enter last name");
            //}
            //else msgError("please enter name");

            //---------------------------------------------CREAR USUARIO------------------------------------
            //si los campos no estan vacios entramos por la condicion
            if(txtNombre.Text != "" && txtApellidos.Text != "" && txtAlias.Text != "" && txtPassword.Text != "" && txtNifDni.Text != "")
            {
                
                string nombre = txtNombre.Text.ToLower();
                string apellidos = txtApellidos.Text.ToLower();
                string alias = txtAlias.Text.ToLower();// pienso que este lo tendriamos que dejar tal cual
                string password = txtPassword.Text.ToLower();
                string nif = txtNifDni.Text;
                string cmdText = "INSERT INTO Usuari(nom, cognoms, nif, alias, password, dataAlta) VALUES('" + nombre + "', '" + apellidos + "', '" + nif + "', '" + alias + "', '" + password + "', current_timestamp);";
                //hacemos un insert de los valores , estamos crando el usuario
                try
                {
                    //Nos conectamos a la base de datos
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(cmdText, connection);
                        int files_afectades = command.ExecuteNonQuery();//Ejecutamos el strinc de insert
                        this.Hide();//cerramos la vista en la que estamos
                        FormPrincipal FormPrincipal = new FormPrincipal();//habrimos la vista principal
                        FormPrincipal.Show();//la mostramos
                    }
                }
                catch (Exception ex)//En caso de error con el insert nos salta un error
                {
                    MessageBox.Show("Error comanda INSERT: " + ex.Message);
                }
            }
            else//En el caso de que no te hayan entrado todos los valores te entra
            {
                msgError("Please enter all values");//metodo de error
            }
        }
        //metodos
        private void msgError(string msg)
        {
            msgErrorCrearUser.Text = msg;
            msgErrorCrearUser.Visible = true;
        }
    }
}
