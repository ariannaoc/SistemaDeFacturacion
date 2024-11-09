using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;

namespace Parcial2_SistemaDeFacturacion
{
    public partial class GestionUsuarios : UserControl
    {
        private static GestionUsuarios instance;
        private static readonly object _lock = new object();
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        public static GestionUsuarios Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new GestionUsuarios();
                    }
                    return instance;
                }
            }
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            GetUserData.CargarUsuarios();
            List < Usuario > usuarios = GetUserData.UserList;
            usuarios = usuarios.Where(u => u.Rol != "su").ToList();
            TablaUsuarios.DataSource = usuarios;
        }

        private void TablaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NuevoUsuarioBtn_Click(object sender, EventArgs e)
        {

            UserForm formularioUsuarios = new UserForm();
            formularioUsuarios.Show();
        }
    }
}
