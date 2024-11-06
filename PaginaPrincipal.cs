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
        private Boolean mostrarPanelProductos = false;
        private Boolean mostrarPanelFacturacion = false;
      
        
        public PaginaPrincipal()
        {
            InitializeComponent();
            TooglePanels();
            

            // Set the Dock style for the panels
            splitContainer1.Panel1.Dock = DockStyle.Left;
            splitContainer1.Panel2.Dock = DockStyle.Fill;

            // Calcular y "setea" el minimo y maximo de la distancia de la division
            int minWidth = CalculateMinimumPanel1Width();
            int maxWidth = CalculateMaximumPanel1Width();

            splitContainer1.SplitterDistance = minWidth;
            splitContainer1.SplitterWidth = 200; // Ajusta el ancho de la separacion como sea necesario

           
            splitContainer2.Panel1.Dock = DockStyle.Top;
            splitContainer2.Panel2.Dock = DockStyle.Fill;

            int minWidth2 = CalculateMinimumPanel1Height2();
            int maxWidth2 = CalculateMaximumPanel1Height2();

            splitContainer2.SplitterDistance = minWidth2;
            splitContainer2.SplitterWidth = 62; // Ajusta el ancho de la separacion como sea necesario

        }

        private int CalculateMinimumPanel1Width()
        {
            // Calculate the required width based on Panel1's controls
            int minWidth = 0;
            foreach (Control control in splitContainer1.Panel1.Controls)
            {
                minWidth += control.Width + 10; // Add padding 
            }
            return minWidth;
        }

        private int CalculateMaximumPanel1Width()
        {
            // Calcula el maximo de ancho
            int maxWidth = splitContainer1.Width / 3; // Ajusta la relacion como necesite
            return maxWidth;
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (e.SplitX > CalculateMaximumPanel1Width())
            {
                e.SplitX = CalculateMaximumPanel1Width();
            }
        }


        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            label2.Text = this.usuario;
            

        }

        private int CalculateFixedPanel1Width()
        {
            // Calculate the desired fixed width for Panel1
            int fixedWidth = 234; // Adjust this value as needed
            return fixedWidth;
        }
        //******************************************* horizontal******************
        private int CalculateMinimumPanel1Height2()
        {
            // Calculate the required height based on Panel1's controls
            int minHeight = 0;
            foreach (Control control in splitContainer2.Panel1.Controls)
            {
                minHeight += control.Height + 10; // Add padding as needed
            }
            return minHeight;
        }

        private int CalculateMaximumPanel1Height2()
        {
            // Calculate the maximum height based on the form size and desired layout
            int maxHeight = splitContainer2.Height / 3; // Adjust the ratio as needed
            return maxHeight;
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (e.SplitY > CalculateMaximumPanel1Height2())
            {
                e.SplitY = CalculateMaximumPanel1Height2();
            }
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
                panelProductos.Height = 110;
            }
            else
            {
                panelProductos.Height = 0;
            }

            //*****************************

            if (mostrarPanelFacturacion)
            {
                panelFacturacion.Height = 110;
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
            Inventario facturacion = Inventario.Instance;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(facturacion);

            facturacion.Dock = DockStyle.Fill;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void PaginaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void baseReal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonRectanguloRedondo1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
