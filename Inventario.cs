using Parcial2_SistemaDeFacturacion.BotonesCustomizados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_SistemaDeFacturacion
{

   
    public partial class Inventario : BaseActualizarPanel
    {
        private static Inventario _instance;
        private static readonly object _lock = new object();
        public Inventario()
        {
            InitializeComponent();

        }

        public static Inventario Instance
        {

            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Inventario();
                    }
                    return _instance;
                }
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            
        }

        

       
    }
}
