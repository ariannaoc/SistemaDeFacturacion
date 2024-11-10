using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using Newtonsoft;
using System.IO;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Parcial2_SistemaDeFacturacion
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            this.ShowInTaskbar = true;
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            ValoresNulosLabel.Visible = false;
            AdvertenciaPanel.Visible = false;
            AdvertenciaImg.Visible = false;
            UsuarioRepetidoLabel.Visible = false;

            if (UserFormAction == "edit")
            {
                UserTxtForm.Texts = usuario;
                UserTxtForm.Enabled = false;

                UsernameTxtFrom.Texts = nombreU;
                UsernameTxtFrom.Enabled = false;
                
                PasswordTxtForm.Texts = password;
                PasswordTxtForm.Enabled = false;

                RolComboForm.Text = rolU;
                RolComboForm.Enabled = false;
            } else
            {
            if (rolU != "su")
            {
                RolComboForm.Enabled = false;
                //RolComboForm.SelectedText = "operador";
                RolComboForm.SelectedItem = "operador";
                RolComboForm.SelectedValue = "operador";
                RolComboForm.Text = "operador";
            }

            }
            
        }

        private void edirUsernameBtn_Click(object sender, EventArgs e)
        {
            UsernameTxtFrom.Enabled = true;
        }

        private void editUserBtn_Click(object sender, EventArgs e)
        {
            UserTxtForm.Enabled = true;
        }

        private void editPasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordTxtForm.Enabled = true;
        }

        private void GuardarUserBtn_Click(object sender, EventArgs e)
        {
            // datos nuevo usuario
            string newUserUser = UserTxtForm.Texts;
            string newUserName = UsernameTxtFrom.Texts;
            var newUserRol = RolComboForm.Text;
            string newUserPassword = PasswordTxtForm.Texts;

            if (newUserName != "" && newUserUser != "" && newUserPassword != "")
            {
                 if (UserFormAction == "agregar")
                {
                    //MessageBox.Show(newUserRol);
                    //Validar que el usuario no exista  
                    GetUserData.CargarUsuarios();
                    List<Usuario> usuariosExistentes = GetUserData.UserList;
                    bool usuarioE = usuariosExistentes.Any(u => u.Username == newUserUser);

                    if (usuarioE)
                    {
                        AdvertenciaPanel.Visible = true;
                        AdvertenciaImg.Visible = true;
                        UsuarioRepetidoLabel.Visible = true;
                    }
                    else
                    {

                        // Gardar datos nuevo usuario 
                        usuariosExistentes.Add(new Usuario { Username = newUserUser, Name = newUserName, Password = newUserPassword, Rol = newUserRol });
                        string newJson = JsonSerializer.Serialize(usuariosExistentes, new JsonSerializerOptions { WriteIndented = true });

                        File.WriteAllText("C:\\Users\\Arianna\\Desktop\\PR2\\SistemaDeFacturacion\\Data\\usuarios.json", newJson);
                        this.Close();
                        GetUserData.CargarUsuarios();
                        //List<Usuario> usuariosExistentes = GetUserData.UserList;
                        MessageBox.Show("Usuario guardado correctamente");
                    }
                }
            } else
            {
                ValoresNulosLabel.Visible = true;
                AdvertenciaPanel.Visible = true;
                AdvertenciaImg.Visible = true;
            }

        }
    }
}
