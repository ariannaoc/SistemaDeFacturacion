using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using System.IO;

namespace Parcial2_SistemaDeFacturacion
{
    internal class GetUserData
    {
        private static List<Usuario> _userList;
        public static List<Usuario> UserList
        {
            get
            {
                if (_userList == null)
                {
                    CargarUsuarios();
                }
                return _userList;
            }
        }

        public static void CargarUsuarios()
        {
            try
            {
                string json = File.ReadAllText(@"..\..\Data\\usuarios.json");
                _userList = JsonConvert.DeserializeObject<List<Usuario>>(json);

                if (_userList.Count == 0)
                {
                    MessageBox.Show("No se encontraron usuarios en el archivo JSON.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void EliminarUsuario(int id)
        {
            try
            {
                // Buscar usuario por ID
                var usuarioAEliminar = _userList.FirstOrDefault(u => u.Id == id);

                if (usuarioAEliminar != null)
                {
                    // Eliminar el usuario 
                    _userList.Remove(usuarioAEliminar);

                    // Guardar la lista en el archivo 
                    GuardarUsuarios();

                    MessageBox.Show("Usuario eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void GuardarUsuarios()
        {
            try
            {
                string json = JsonConvert.SerializeObject(_userList, Formatting.Indented);
                File.WriteAllText(@"..\..\Data\\usuarios.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Rol { get; set; }
    }
}