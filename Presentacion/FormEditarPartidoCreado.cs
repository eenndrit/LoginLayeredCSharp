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
    public partial class FormEditarPartidoCreado : Form
    {
        public FormEditarPartidoCreado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormEditarPartit menuEditarPartit = new FormEditarPartit();
            menuEditarPartit.Owner = this;
            menuEditarPartit.Show();
            this.Hide();
        }
    }
}
