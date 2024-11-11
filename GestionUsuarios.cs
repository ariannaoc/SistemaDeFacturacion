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
    public partial class GestionUsuarios : BaseActualizarPanel
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
        private void ActualizarListaUsuarios()
        {
            GetUserData.CargarUsuarios();
            List<Usuario> usuarios = GetUserData.UserList;
            if (rolU != "superUsuario")
            {
                usuarios = usuarios.Where(u => u.Rol != "superUsuario").ToList();
            }
            TablaUsuarios.DataSource = usuarios;
        }
        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
           ActualizarListaUsuarios();

            // Anade boton a la columna de editar
            DataGridViewButtonColumn editarBotonColumna = new DataGridViewButtonColumn
            {
                Name = "Editar",
                HeaderText = "Editar",
                Text = "Editar",
                UseColumnTextForButtonValue = true
            };
            TablaUsuarios.Columns.Add(editarBotonColumna);

            // Anade boton a la columna de eliminar
            DataGridViewButtonColumn eliminarBotonColumna = new DataGridViewButtonColumn
            {
                Name = "Eliminar",
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
            };
            TablaUsuarios.Columns.Add(eliminarBotonColumna);
        }


        private void TablaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == TablaUsuarios.Columns["Editar"].Index)
            {
                // Obtener el usuario seleccionado 
                Usuario usuarioSeleccionado = (Usuario)TablaUsuarios.Rows[e.RowIndex].DataBoundItem;
                //MessageBox.Show(usuarioSeleccionado.Name);

                UserFormAction = "edit";
                // Abriendo formulario de edicion
                UserForm userForm = new UserForm();
                userForm.UserFormAction = UserFormAction;
                userForm.usuario = usuarioSeleccionado.Username;
                userForm.IdUser = usuarioSeleccionado.Id;
                userForm.nombreU = usuarioSeleccionado.Name;
                userForm.password = usuarioSeleccionado.Password;
                userForm.rolU = usuarioSeleccionado.Rol;
                userForm.Show();
                userForm.UserUpdated += ActualizarListaUsuarios;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == TablaUsuarios.Columns["Eliminar"].Index)
            {
                // Obtener el usuario seleccionado
                Usuario usuarioSeleccionado = (Usuario)TablaUsuarios.Rows[e.RowIndex].DataBoundItem;

                if (usuarioSeleccionado.Rol == "superUsuario")
                {
                    MessageBox.Show("El Super Usuario no puede ser eliminado");
                }
                else
                {
                // Confirmar la eliminación
                var resultado = MessageBox.Show($"¿Estás seguro de que deseas eliminar al usuario {usuarioSeleccionado.Username}?",
                                                 "Confirmar eliminación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    GetUserData.EliminarUsuario(usuarioSeleccionado.Id);
                    // Actualizar la lista de usuarios
                    ActualizarListaUsuarios();
                }
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


       
        private void NuevoUsuarioBtn_Click(object sender, EventArgs e)
        {
            UserFormAction = "agregar";
            UserForm formularioUsuarios = new UserForm();
            formularioUsuarios.UserUpdated += ActualizarListaUsuarios;
            formularioUsuarios.UserFormAction = UserFormAction;
            formularioUsuarios.IdUser = IdUser;
            formularioUsuarios.rolU = rolU;
            formularioUsuarios.usuario = usuario;
            formularioUsuarios.password = password;
            formularioUsuarios.nombreU = nombreU;
            formularioUsuarios.Show();
        }
    }
}
