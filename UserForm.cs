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
        public event Action UserUpdated; // Evento para notificar que usuarios ha sido actualizado
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
            // datos nuevos
            string newUserUser = UserTxtForm.Texts;
            string newUserName = UsernameTxtFrom.Texts;
            string newUserRol = RolComboForm.Text;
            string newUserPassword = PasswordTxtForm.Texts;


            if (newUserName != "" && newUserUser != "" && newUserPassword != "" && newUserRol != "")
            {
                 if (UserFormAction == "agregar")
                 {
                    //Validar que el usuario no exista  
                    GetUserData.CargarUsuarios();
                    List<Usuario> usuariosExistentes = GetUserData.UserList;
                    int lastId = usuariosExistentes.Any() ? usuariosExistentes.Max(u => u.Id) : 0;

                    bool usuarioE = usuariosExistentes.Any(u => u.Username == newUserUser);

                    if (usuarioE)
                    {
                        AdvertenciaPanel.Visible = true;
                        AdvertenciaImg.Visible = true;
                        UsuarioRepetidoLabel.Visible = true;
                    }
                    else
                    {
                        int newId = lastId + 1;
                        // Gardar datos nuevo usuario 
                        usuariosExistentes.Add(new Usuario { Id = newId, Username = newUserUser, Name = newUserName, Password = newUserPassword, Rol = newUserRol });
                        string newJson = JsonSerializer.Serialize(usuariosExistentes, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText(@"..\..\Data\\usuarios.json", newJson);
                        UserUpdated?.Invoke();
                        this.Close();
                        MessageBox.Show("Usuario guardado correctamente");
                    }
                } else if (UserFormAction == "edit")
                {
                    // Editing user logic
                    GetUserData.CargarUsuarios();
                    List<Usuario> usuariosExistentes = GetUserData.UserList;

                    // Find the user to edit based on a unique identifier (e.g., Id)
                    int userIdToEdit = IdUser;

                    int indexOfUserToEdit = usuariosExistentes.FindIndex(u => u.Id == userIdToEdit);

                    if (indexOfUserToEdit != -1)
                    {
                        // Update user data
                        usuariosExistentes[indexOfUserToEdit].Username = newUserUser;
                        usuariosExistentes[indexOfUserToEdit].Name = newUserName;
                        usuariosExistentes[indexOfUserToEdit].Password = newUserPassword;
                        usuariosExistentes[indexOfUserToEdit].Rol = newUserRol;

                        string newJson = JsonSerializer.Serialize(usuariosExistentes, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText(@"..\..\Data\\usuarios.json", newJson);
                        UserUpdated?.Invoke();
                        this.Close(); 
                        MessageBox.Show("Usuario editado correctamente");
                    }
                    else
                    {
                        // User to edit not found
                        MessageBox.Show("Error: Usuario no encontrado para editar");
                    }
                }
            } 
            else
            {
                ValoresNulosLabel.Visible = true;
                AdvertenciaPanel.Visible = true;
                AdvertenciaImg.Visible = true;
            }

        }
    }
}
