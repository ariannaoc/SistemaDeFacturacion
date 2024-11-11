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
    public partial class InfoUserEmergente : Form
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

        public void ShowCustomDialog()
        {
            using (InfoUserEmergente dialog = new InfoUserEmergente())
            {
               
                dialog.StartPosition = FormStartPosition.Manual;
                dialog.AutoSize = false;
                dialog.MaximizeBox = false;
                dialog.MinimizeBox = false;
                
                dialog.Location = new Point(395, 25);

                
                dialog.Move += (sender, e) => { dialog.Location = new Point(395, 25); };

               
                dialog.ShowDialog();
            }
        }

      
        private void CerrarSesionBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void InfoUserEmergente_Load(object sender, EventArgs e)
        {

            UserNameLabel.Text = nombreU;
            UserLabel.Text = usuario;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CerrarSesionBtn_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
            Application.OpenForms["PaginaPrincipal"].Close();

        }

       

        private void BtnConfigU_Click(object sender, EventArgs e)
        {
            UserFormAction = "edit";
            UserForm userForm = new UserForm();
            userForm.UserFormAction = UserFormAction;
            userForm.usuario = usuario;
            userForm.IdUser = IdUser;
            userForm.nombreU = nombreU;
            userForm.password = password;
            userForm.rolU = rolU;
            userForm.Show();
        }
    }
}
