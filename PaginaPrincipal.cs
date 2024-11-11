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
            if (rolU == "operador")
            {
                btnUsuarios.Visible = false;
            } else if (rolU == "superUsuario")
            {
                btnAnadirCategoria.Visible = false;
                btnCliente.Visible = false;
                btnFacturacion.Visible = false;
                btnProductos.Visible = false;
                btnReportes.Visible = false;
                btnOrdenes.Visible = false; 
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
            InfoUser.Visible= true;
            UserLabel.Text = usuario; 
            UserLabelName.Text = nombreU;
            //UserBtn.Enabled = false;
            UserBtn.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CerrarSesionBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void PaginaPrincipal_Click(object sender, EventArgs e)
        {
            InfoUser.Visible = false;
            UserBtn.Visible = true;
        }

        private void splitContainer2_Panel2_Click(object sender, EventArgs e)
        {
            InfoUser.Visible = false;
            UserBtn.Visible = true;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            InfoUser.Visible = false;
            UserBtn.Visible = true;
        }

        private void UserLabel_Click(object sender, EventArgs e)
        {

        }

        private void ConfigUserBtn_Click(object sender, EventArgs e)
        {
            UserFormAction = "edit";
            UserForm userForm = new UserForm();
            userForm.UserFormAction = UserFormAction;
            userForm.usuario = usuario;
            userForm.IdUser = IdUser;
            userForm.nombreU = nombreU;
            userForm.password = password;
            userForm.rolU = rolU;
            userForm.Show();
        }
    }
}
