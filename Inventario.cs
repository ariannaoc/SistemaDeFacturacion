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

   
    public partial class Inventario : UserControl
    {
        private static Inventario instance;
        public Inventario()
        {
            InitializeComponent();

            // ... (in your form or control)

          
        }

        public static Inventario Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Inventario();
                }
                return instance;
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            
        }

        

       
    }
}
