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
    public partial class Facturacion : BaseActualizarPanel
    {
        private static Facturacion _instance;
        private static readonly object _lock = new object();
        public Facturacion()
        {
            InitializeComponent();
        }

        public static Facturacion Instance
        {

            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Facturacion();
                    }
                    return _instance;
                }
            }
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            
        }

        private void botonRectanguloRedondo1_Click(object sender, EventArgs e)
        {
            Inventario facturacion = Inventario.Instance;
            ActualizarPanelPrincipal(facturacion);
        }
    }
}
