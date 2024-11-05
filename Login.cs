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

        private void button1_Click(object sender, EventArgs e)
        {
            PaginaPrincipal Dashboard = new PaginaPrincipal();

            Dashboard.usuario = "arianna";
            Dashboard.Show();
            this.Hide();

        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
