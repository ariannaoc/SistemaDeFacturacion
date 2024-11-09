using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Parcial2_SistemaDeFacturacion
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private bool Autenticacion(string username, string password)
        {
            return GetUserData.UserList.Any(user => user.Username.ToLower() == username.ToLower() && user.Password == password);
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HabilitarBotonIniciarSesion(object sender, EventArgs e)
        {
            IniciarSesionBtn.Enabled = false;
            //IniciarSesionBtn.Enabled = !string.IsNullOrEmpty(UserTxt.Text) && !string.IsNullOrEmpty(PasswordTxt.Text);
        }
        private void IniciarSesionBtn_Click(object sender, EventArgs e)
        {
            string username = UserTxt.Texts;
            string password = PasswordTxt.Texts;

            if (Autenticacion(username, password))
            {
                // Autenticación exitosa
                Usuario usuarioAutenticado = GetUserData.UserList.FirstOrDefault(user => user.Username.ToLower() == username.ToLower());

                if (usuarioAutenticado != null)
                {
                    PaginaPrincipal Dashboard = new PaginaPrincipal();
                    Dashboard.usuario = usuarioAutenticado.Username;
                    Dashboard.nombreU = usuarioAutenticado.Name;
                    Dashboard.rolU = usuarioAutenticado.Rol;

                    Dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error interno: Usuario no encontrado en la lista autenticada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña inválidos", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);


                UserTxt.Text = "";
                PasswordTxt.Text = "";
            }
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
            //IniciarSesionBtn.Enabled = false;
            PasswordTxt.CustomPasswordChar = '*';
            PasswordTxt.Multiline = false;
            UserTxt.Multiline = false;
        }
    }
}
