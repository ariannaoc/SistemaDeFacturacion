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

    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Rol { get; set; }
    }
    public partial class Login : Form
    {
        // Lista de usuarios
        List<Usuario> userList = new List<Usuario>();

        public Login()
        {
            InitializeComponent();
            CargarUsuarios();
        }
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


        private void IniciarSesionBtn_Click(object sender, EventArgs e)
        {

            string username = UserTxt.Texts;
            string password = PasswordTxt.Texts;

            if (Autenticacion(username, password))
            {
                // Autenticacion exitosa
                PaginaPrincipal Dashboard = new PaginaPrincipal();
                Dashboard.usuario = username;
                Dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña inválidos", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            PasswordTxt.CustomPasswordChar = '*';
            PasswordTxt.Multiline = false;
            UserTxt.Multiline = false;
        }

        
    }
}
