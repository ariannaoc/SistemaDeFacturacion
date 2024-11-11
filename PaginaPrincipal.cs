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
    public partial class PaginaPrincipal : Form
    {
        private static PaginaPrincipal _instance;
        private static readonly object _lock = new object();
        private Boolean mostrarPanelProductos = false;
        private Boolean mostrarPanelFacturacion = false;
        //pongan aqui como atributos sus controles de Usuario
        
        
        public PaginaPrincipal()
        {
            InitializeComponent();
            TooglePanels();
            

        }

        public static PaginaPrincipal Instance
        {

            get
            {
                lock (_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new PaginaPrincipal();
                    }
                    return _instance;
                }
            }
        }

        //se usa con baseActualizarPanel para poder tener acceso a esta pagina
        public void UpdatePanel(UserControl control)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            this.splitContainer2.Panel2.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
        //***********************************************************************
       

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {



        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonRectanguloRedondo2_Click(object sender, EventArgs e)
        {

        }

        private void botonRectanguloRedondo1_Click(object sender, EventArgs e)
        {

        }

  
        private void facturacion1_Load(object sender, EventArgs e)
        {

        }

       
    

        private void TooglePanels()
        {
            if(mostrarPanelProductos)
            {
                panelProductos.Height = 130;
            }
            else
            {
                panelProductos.Height = 0;
            }

            //*****************************

            if (mostrarPanelFacturacion)
            {
                panelFacturacion.Height = 130;
            }
            else
            {
                panelFacturacion.Height = 0;
            }
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            //PRUEBA DE COLORES NADA MAS
            //int red = Convert.ToInt32("28", 16);
            //int green = Convert.ToInt32("28", 16);
            //int blue = Convert.ToInt32("36", 16);

            //// Create a Color object with the specified RGB values
            //Color customColor = Color.FromArgb(red, green, blue);
            //btnProductos.BackColor = customColor;
            //btnProductos.ForeColor = Color.Red;

            mostrarPanelProductos = !mostrarPanelProductos;
            TooglePanels();

        }



       private void btnFacturacion_Click(object sender, EventArgs e)
        {
           
                mostrarPanelFacturacion = !mostrarPanelFacturacion;
                TooglePanels();
            
        }

        

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }


        private void btnIniciarVenta_Click(object sender, EventArgs e)
        {

            Facturacion facturacion = Facturacion.Instance;
            
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(facturacion);

            facturacion.Dock = DockStyle.Fill;

        }

        private void textBoxRedondo1__TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxRedondo1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxRedondo1_Load_1(object sender, EventArgs e)
        {

        }

        private void baseControl_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAnadirCategoria_Click(object sender, EventArgs e)
        {
            AñadirCatgProducto añadirCatgProducto = AñadirCatgProducto.Instance;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(añadirCatgProducto);

            añadirCatgProducto.Dock = DockStyle.Fill;
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            VerClientes mostrarCompradores = VerClientes.Instance;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(mostrarCompradores);

            mostrarCompradores.Dock = DockStyle.Fill;

        }
    }
}
