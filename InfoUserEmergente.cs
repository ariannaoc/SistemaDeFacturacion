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
    public partial class InfoUserEmergente : UserControl
    {
        private static InfoUserEmergente _instance;

        public InfoUserEmergente()
        {
            InitializeComponent();
        }
        public static InfoUserEmergente Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InfoUserEmergente();
                }
                return _instance;
            }
        }


        private void CerrarSesionBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void InfoUserEmergente_Load(object sender, EventArgs e)
        {
            UserNameLabel.Text = nombreU;
            UserNameLabel.ForeColor = Color.Black;
            //UserLabel.Text = usuario;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CerrarSesionBtn_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
