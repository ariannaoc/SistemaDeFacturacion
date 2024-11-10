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
            ValoresNulosLabel.Visible = false;
            ValoresNulosImg.Visible = false;

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
                RolComboForm.SelectedText = "operador";
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
            string newUserUser = UsernameTxtFrom.Texts;
            string newUserName = UsernameTxtFrom.Texts;
            string newUserRol = RolComboForm.Text;
            string newUserPassword = PasswordTxtForm.Texts;

            if (newUserName != "" && newUserUser != "" && newUserPassword != "" && newUserRol != "")
            {
                //Guardar en el archivo 
                // if action edit or nuevo 
            } else
            {
                ValoresNulosLabel.Visible = true;
                ValoresNulosPanel.Visible = true;
                ValoresNulosImg.Visible = true;
            }

        }
    }
}
