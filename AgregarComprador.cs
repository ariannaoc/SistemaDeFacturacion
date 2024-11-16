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
            this.FormClosed += AgregarComprador_FormClosed; // Anexa el FormClosed evento handler
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
            // Optional: Add any logic needed when the form is closed
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

            // Validate and normalize the input fields
            string nombres = ValidarPalabra(txtNombres.Text, "Ingrese sus nombres:");
            string apellidos = ValidarPalabra(txtApellidos.Text, "Ingrese sus apellidos:");
            string calles = ValidarPalabra(txtCalle.Text, "Ingrese su calle:");
            string ciudad = ValidarPalabra(txtCiudad.Text, "Ingrese su ciudad:");
            string estado = ValidarPalabra(txtEstado.Text, "Ingrese su estado:");
            EstadoLegal nacionalidad = (EstadoLegal)Enum.Parse(typeof(EstadoLegal), cmbEstadoLegal.SelectedItem.ToString());
            string cedula = ValidarCedula(txtCedula.Text, nacionalidad, "Ingrese su cédula:");
            string email = ValidarEmail(txtEmail.Text, "Ingrese su email:");
            string numeroTelefono = ValidarNumeroTelefono(txtNumeroTelefono.Text, "Ingrese su numero de telefono:");

            if (nombres == "-----------" || apellidos == "-----------" || calles == "-----------" || ciudad == "-----------" || estado == "-----------" || cedula == "-----------" || email == "-----------" || numeroTelefono == "-----------")
            {
                return; // If any validation failed, return early
            }

            if (Cliente == null)
            {
                Cliente = new Cliente();
            }

            Cliente.Nombres = nombres;
            Cliente.Apellidos = apellidos;
            Cliente.ID = cedula;
            Cliente.Email = email;
            Cliente.NumeroTelefono = numeroTelefono;
            Cliente.Direccion = new Direccion(calles, ciudad, estado);
            Cliente.ContribuyenteEspecial = cmbContribuyenteEspecial.SelectedItem.ToString() == "Si"; //REVISAR
            Cliente.EstadoLegal = (EstadoLegal)Enum.Parse(typeof(EstadoLegal), cmbEstadoLegal.SelectedItem.ToString());

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private string ValidarPalabra(string palabra, string mensaje)
        {
            palabra = Utils.MayusculaPrimeraLetra(palabra);

            if (palabra == "-----------")
            {
                MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return palabra;
            }

            if (!Utils.ChecarPalabras(palabra))
            {
                MessageBox.Show("Por favor ingresa solo palabras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "-----------";
            }

            return palabra;
        }

        private string ValidarCedula(string cedula, EstadoLegal nacionalidad, string mensaje)
        {
            string validCedula = Utils.ValidarCedula(cedula, nacionalidad);

            if (validCedula == "-----------")
            {
                MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return validCedula;
            }

            return validCedula;
        }

        private string ValidarEmail(string email, string mensaje)
        {
            if (!Utils.ValidarEmail(email))
            {
                MessageBox.Show("Por favor ingresa un email válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "-----------";
            }

            return email;
        }

        private string ValidarNumeroTelefono(string numeroTelefono, string mensaje)
        {
            string validNumber = Utils.ValidarNumeroTelefono(numeroTelefono);

            if (validNumber == "Invalid phone number")
            {
                MessageBox.Show("Por favor ingresa un número de teléfono válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "-----------";
            }

            return validNumber;
        }

       
            private void AgregarComprador_Load(object sender, EventArgs e)
        {
            // Optional: Add any logic needed when the form loads
        }
    }


}
