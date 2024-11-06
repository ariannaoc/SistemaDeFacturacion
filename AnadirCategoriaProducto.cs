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
    public partial class AñadirCatgProducto : UserControl
    {
        private static AñadirCatgProducto instance;
        private static readonly object _lock = new object();
        public AñadirCatgProducto()
        {
            InitializeComponent();
        }

        public static AñadirCatgProducto Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new AñadirCatgProducto();
                    }
                    return instance;
                }
            }
        }
        private void AñadirCatgProducto_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            VTNagregarCategoria vtnagregarcatg = new VTNagregarCategoria();
            
            vtnagregarcatg.ShowDialog();
        }
    }
}
