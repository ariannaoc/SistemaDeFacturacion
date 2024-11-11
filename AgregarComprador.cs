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
    public partial class AgregarComprador : Form
    {
        public Cliente Cliente { get; set; }
        public AgregarComprador()
        {
            InitializeComponent();
            this.FormClosed += AgregarComprador_FormClosed; // Anexa el  FormClosed evento handler
        }

        public AgregarComprador(Cliente cliente)
        {
            InitializeComponent();
            if (cliente != null)
            {
                Cliente = cliente;
               
            }
           
        }

        private void AgregarComprador_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btnAceptar_Click_2(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtNumeroTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCalle.Text) ||
                string.IsNullOrWhiteSpace(txtCiudad.Text) ||
                string.IsNullOrWhiteSpace(txtEstado.Text) ||
                cmbEstadoLegal.SelectedItem == null ||
                cmbContribuyenteEspecial.SelectedItem == null)
            {
                MessageBox.Show("Por favor llena todos los campos requeridos.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Cliente == null)
            {
                Cliente = new Cliente();
            }

            Cliente.Nombres = txtNombres.Text;
            Cliente.Apellidos = txtApellidos.Text;
            Cliente.ID = txtCedula.Text;
            Cliente.Email = txtEmail.Text;
            Cliente.NumeroTelefono = txtNumeroTelefono.Text;
            Cliente.Direccion = new Direccion(txtCalle.Text, txtCiudad.Text, txtEstado.Text);
            Cliente.ContribuyenteEspecial = cmbContribuyenteEspecial.SelectedItem.ToString() == "Si"; //REVISAR
            Cliente.EstadoLegal = (EstadoLegal)Enum.Parse(typeof(EstadoLegal), cmbEstadoLegal.SelectedItem.ToString());

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AgregarComprador_Load(object sender, EventArgs e)
        {

        }
    }


}
