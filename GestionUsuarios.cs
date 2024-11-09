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
        //List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(File.ReadAllText("usuarios.json"));
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void TablaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
