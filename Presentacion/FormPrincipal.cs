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
using MySql.Data.MySqlClient;
using Domain;

namespace PorraGironaOfficial
{
    public partial class FormPrincipal : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=porra";

        public FormPrincipal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wpara, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                if (txtContraseña.Text != "")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUser.Text, txtContraseña.Text);
                    if (validLogin == true)
                    {
                        string GuardarUser = txtUser.Text;
                        if(txtUser.Text == "Admin" && txtContraseña.Text == "Admin" || txtUser.Text == "admin" && txtContraseña.Text == "admin"
                            || txtUser.Text == "Admin" && txtContraseña.Text == "admin" || txtUser.Text == "admin" && txtContraseña.Text == "Admin")
                        {
                            FormMenuAdmin menuAdmin = new FormMenuAdmin();
                            menuAdmin.Owner = this;
                            menuAdmin.Show();
                            this.Hide();
                        }
                        else
                        {
                            //meto el formulario principal
                            FormMenuPrincipal mainMenu = new FormMenuPrincipal();
                            mainMenu.Owner = this;
                            mainMenu.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        msgError("Incorrect username or password entered.");
                        txtUser.Clear();
                        txtContraseña.Clear();
                        txtUser.Focus();
                    }
                }
                else msgError("Please enter password");
            }
            else msgError("Please enter username");
        }
        private void msgError(string msg)
        {           
            labelErrorMessage2.Text = msg;
            labelErrorMessage2.Visible = true;
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCrearUsuari mainMenu = new FormCrearUsuari();
            mainMenu.Show();
        }

    }
}
