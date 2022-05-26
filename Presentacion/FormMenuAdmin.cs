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
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        // TODO ESTO SON BOTONES PARA ACCEDER A DIFERENTES FORMS DEL ADMIN
        //
        //----------------------------

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormPrincipal menuPrincipal = new FormPrincipal();
            menuPrincipal.Owner = this;
            menuPrincipal.Show();
            this.Hide();
        }

        private void btnAdminEquipos_Click(object sender, EventArgs e)
        {
            FormEditarEquip editarEquip = new FormEditarEquip();
            editarEquip.Owner = this;
            editarEquip.Show();
            this.Hide();
        }

        private void btnAdminPartidos_Click(object sender, EventArgs e)
        {
            FormEditarPartit editarPartit = new FormEditarPartit();
            editarPartit.Owner = this;
            editarPartit.Show();
            this.Hide();
        }

        private void btnAdminUsuarios_Click(object sender, EventArgs e)
        {
            FormEditarUsuari editarUser = new FormEditarUsuari();
            editarUser.Owner = this;
            editarUser.Show();
            this.Hide();
        }
    }
}
