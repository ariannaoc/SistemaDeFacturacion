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
    public partial class EditarComprador : Form
    {
        public Cliente Cliente { get; set; }

        public EditarComprador(Cliente cliente)
        {
            InitializeComponent();
            Cliente = cliente;
            if (Cliente != null)
            {
                LlenarForm(cliente);
            }
        }

        private void LlenarForm(Cliente cliente)
        {
            txtNombres.Text = cliente.Nombres;
            txtApellidos.Text = cliente.Apellidos;
            txtCedula.Text = cliente.ID;
            txtEmail.Text = cliente.Email;
            txtNumeroTelefono.Text = cliente.NumeroTelefono;
            txtCalle.Text = cliente.Direccion?.Calle;
            txtCiudad.Text = cliente.Direccion?.Ciudad;
            txtEstado.Text = cliente.Direccion?.Estado;
            cmbContribuyenteEspecial.SelectedItem = cliente.ContribuyenteEspecial ? "Si" : "No";
            cmbEstadoLegal.SelectedItem = cliente.EstadoLegal.ToString();
        }

        private void EditarComprador_Load(object sender, EventArgs e)
        {
            // nada aqui
        }

       
        private void btnAceptar_Click(object sender, EventArgs e)
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

            Cliente.Nombres = txtNombres.Text;
            Cliente.Apellidos = txtApellidos.Text;
            Cliente.ID = txtCedula.Text;
            Cliente.Email = txtEmail.Text;
            Cliente.NumeroTelefono = txtNumeroTelefono.Text;
            Cliente.Direccion = new Direccion(txtCalle.Text, txtCiudad.Text, txtEstado.Text);
            Cliente.ContribuyenteEspecial = cmbContribuyenteEspecial.SelectedItem.ToString() == "Si";
            Cliente.EstadoLegal = (EstadoLegal)Enum.Parse(typeof(EstadoLegal), cmbEstadoLegal.SelectedItem.ToString());

            // Intenta actualizar al cliente
            if (ClientManager.Clients.Any(c => c.ID == Cliente.ID && c != Cliente))
            {
                MessageBox.Show("Un cliente con la misma Cedula ya existe. Por favor ingresa una cedula diferente.", "Duplicate ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClientManager.ActualizarCliente(Cliente);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }


}
