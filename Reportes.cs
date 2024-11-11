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
    public partial class Reportes : UserControl
    {
        private static Reportes instance;

        private static readonly object _lock = new object();

        public Reportes()
        {
            InitializeComponent();
        }

        public static Reportes Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new Reportes();
                    }
                    return instance;
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }
    }
}
