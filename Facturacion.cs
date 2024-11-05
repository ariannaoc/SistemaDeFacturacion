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
    public partial class Facturacion : UserControl
    {
        private static Facturacion instance;
        public Facturacion()
        {
            InitializeComponent();
        }

        public static Facturacion Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Facturacion();
                }
                return instance;    
            }
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            
        }

     
    }
}
