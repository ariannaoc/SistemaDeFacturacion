using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_SistemaDeFacturacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IniciarSesionBtn_Click(object sender, EventArgs e)
        {
            PaginaPrincipal Dashboard = new PaginaPrincipal();

            Dashboard.usuario = "arianna";
            Dashboard.Show();
            //this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRedondo1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxRedondo1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBoxRedondo2_Load(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            PasswordTxt.CustomPasswordChar = '*';
            PasswordTxt.Multiline = false;
        }
    }
}
