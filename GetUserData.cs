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