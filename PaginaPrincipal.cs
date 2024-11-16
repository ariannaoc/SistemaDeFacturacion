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
            Dashboard dashboard = Dashboard.Instance;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(dashboard);
            dashboard.Dock = DockStyle.Fill;
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
            //MessageBox.Show("Control added to the panel and docked.", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information); debugging
        }


        public void ActualizarPanelPrincipal(UserControl newControl)
        {
            var parentForm = this.FindForm() as PaginaPrincipal;
            if (parentForm != null)
            {
                //MessageBox.Show("Parent form found, updating panel...");
                parentForm.UpdatePanel(newControl);
            }
            else
            {
                //MessageBox.Show("Parent form not found.");
            }
        }

        //***********************************************************************


        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            if (rolU == "operador")
            {
                btnUsuarios.Visible = false;
            }
            else if (rolU == "superUsuario")
            {
                btnDashboard.Text = "Sistema";
                SistemConfig sistem = new SistemConfig();
                this.splitContainer2.Panel2.Controls.Clear();
                this.splitContainer2.Panel2.Controls.Add(sistem);
                sistem.Dock = DockStyle.Fill;
                btnAnadirCategoria.Visible = false;
                btnCliente.Visible = false;
                btnFacturacion.Visible = false;
                btnProductos.Visible = false;
                btnReportes.Visible = false;
                //btnOrdenes.Visible = false;
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
           

            if (rolU == "superUsuario")
            {
                SistemConfig sistem = new SistemConfig();
                this.splitContainer2.Panel2.Controls.Clear();
                this.splitContainer2.Panel2.Controls.Add(sistem);
                sistem.Dock = DockStyle.Fill;
            }
            else
            {
                Dashboard dashboard = Dashboard.Instance;

                splitContainer2.Panel2.Controls.Clear();
                splitContainer2.Panel2.Controls.Add(dashboard);

                dashboard.Dock = DockStyle.Fill;
            }

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
            GestionUsuarios gestionarUsuarios = GestionUsuarios.Instance;
            gestionarUsuarios.usuario = usuario;
            gestionarUsuarios.nombreU = nombreU;
            gestionarUsuarios.password = password;
            gestionarUsuarios.rolU = rolU;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(gestionarUsuarios);

            gestionarUsuarios.Dock = DockStyle.Fill;
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
            InfoUserEmergente infouser = new InfoUserEmergente();
            infouser.usuario = usuario;
            infouser.nombreU = nombreU;
            infouser.password = password;
            infouser.IdUser = IdUser;
            infouser.rolU = rolU;
            infouser.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            VerClientes mostrarCompradores = VerClientes.Instance;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(mostrarCompradores);

            mostrarCompradores.Dock = DockStyle.Fill;

        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            //GenerarPDF pdf = new GenerarPDF();
            //pdf.generarPDF();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes reporte = Reportes.Instance;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(reporte);

            reporte.Dock = DockStyle.Fill;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = Inventario.Instance;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(inventario);

            inventario.Dock = DockStyle.Fill;
        }
    }
}
