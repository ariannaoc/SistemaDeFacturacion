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
            CargarUsuarios();
        }

        // Lista de usuarios
        List<Usuario> userList = new List<Usuario>();

        private void CargarUsuarios()
        {
            try
            {
                // Leer archivo JSON
                string json = File.ReadAllText("C:\\Users\\Arianna\\Desktop\\PR2\\SistemaDeFacturacion\\Data\\usuarios.json");
                
                // Deserializar JSON en una lista
                userList = JsonConvert.DeserializeObject<List<Usuario>>(json);

                if (userList.Count == 0)
                {
                    MessageBox.Show("No se encontraron usuarios en el archivo JSON.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Autenticacion(string username, string password)
        {
           
            
            return userList.Any(user => user.Username == username.ToLower() && user.Password == password);
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
                Usuario authenticatedUser = userList.FirstOrDefault(user => user.Username.ToLower() == username.ToLower());

                if (authenticatedUser != null)
                {
                    PaginaPrincipal Dashboard = new PaginaPrincipal();
                    Dashboard.usuario = authenticatedUser.Username;
                    Dashboard.nombreU = authenticatedUser.Name; 
                    Dashboard.rolU = authenticatedUser.Rol; 

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

            //if (Autenticacion(username, password))
            //{
            //    // Autenticacion exitosa
            //    PaginaPrincipal Dashboard = new PaginaPrincipal();
            //    //Dashboard.nombreU = 
            //    Dashboard.usuario = username;
            //    Dashboard.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Usuario o contraseña inválidos", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    UserTxt.Texts = "";
            //    PasswordTxt.Texts = "";
            //    //IniciarSesionBtn.Enabled = false;

            //}

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
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Rol { get; set; }
    }
}
