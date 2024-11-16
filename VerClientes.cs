using Parcial2_SistemaDeFacturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_SistemaDeFacturacion
{
    public partial class VerClientes : BaseActualizarPanel
    {
        private static VerClientes _instance;
        private static readonly object _lock = new object();
        private BindingList<Cliente> bindingList = new BindingList<Cliente>(); // Use BindingList para actualizacion automatica  
        private List<Cliente> allClients = new List<Cliente>();
        private int pageSize = 15;
        private int paginaActual = 0;

        public BindingList<Cliente> ClientBindingList
        {
            get { return bindingList; }
        }
        public VerClientes()
        {
            InitializeComponent();
            this.Load += new EventHandler(VerClientes_Load);
            DefinirColumnas();
        }

        private void DefinirColumnas()
        {
            dataGridViewClientes1.CellContentClick += new DataGridViewCellEventHandler(dataGridViewClientes1_CellContentClick);
            dataGridViewClientes1.VirtualMode = true;
            dataGridViewClientes1.AutoGenerateColumns = false;
            dataGridViewClientes1.DefaultCellStyle.ForeColor = Color.Black;

            var columnNumeroCliente = new DataGridViewTextBoxColumn { Name = "NumeroCliente", HeaderText = "#", ReadOnly = true };
            var columnNombres = new DataGridViewTextBoxColumn { Name = "Nombres", HeaderText = "Nombres", ReadOnly = true };
            var columnApellidos = new DataGridViewTextBoxColumn { Name = "Apellidos", HeaderText = "Apellidos", ReadOnly = true };
            var columnCedula = new DataGridViewTextBoxColumn { Name = "Cedula", HeaderText = "Cedula", ReadOnly = true };
            var columnEmail = new DataGridViewTextBoxColumn { Name = "Email", HeaderText = "Email", ReadOnly = true };
            var columnNumeroTelefono = new DataGridViewTextBoxColumn { Name = "NumeroTelefono", HeaderText = "Numero Telefono", ReadOnly = true };

            dataGridViewClientes1.Columns.AddRange(columnNumeroCliente, columnNombres, columnApellidos, columnCedula, columnEmail, columnNumeroTelefono);

            // Add button to the edit column
            DataGridViewButtonColumn editarBotonColumna = new DataGridViewButtonColumn
            {
                Name = "Editar",
                HeaderText = "Editar",
                Text = "Editar",
                UseColumnTextForButtonValue = true,
                ReadOnly = false // Allow interaction with the button
            };
            dataGridViewClientes1.Columns.Add(editarBotonColumna);

            // Add button to the delete column
            DataGridViewButtonColumn eliminarBotonColumna = new DataGridViewButtonColumn
            {
                Name = "Eliminar",
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
                ReadOnly = false // Allow interaction with the button
            };
            dataGridViewClientes1.Columns.Add(eliminarBotonColumna);
        }


        private void dataGridViewClientes1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridViewClientes1.Columns[e.ColumnIndex].Name == "Editar")
                {
                    var client = bindingList[e.RowIndex];
                    using (var form = new EditarComprador(client))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            ClientManager.ActualizarCliente(form.Cliente);
                            bindingList[e.RowIndex] = form.Cliente; // Update the binding list
                            RefreshDataGridView(); // Refresh the DataGridView
                        }
                    }
                }
                else if (dataGridViewClientes1.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    var client = bindingList[e.RowIndex];
                    var result = MessageBox.Show("Estas seguro que quieres eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        ClientManager.EliminarCliente(client);
                        bindingList.RemoveAt(e.RowIndex); // Update the binding list and automatically update the DataGridView
                    }
                }
            }
        }
        private void RefreshDataGridView()
        {
            dataGridViewClientes1.VirtualMode = true;
            dataGridViewClientes1.DataSource = null; // Reset DataSource  
            dataGridViewClientes1.DataSource = bindingList; // Rebind the DataGridView to the binding list  
            dataGridViewClientes1.Refresh(); // Refresh to show updates  
        }

        public static VerClientes Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new VerClientes();
                    }
                    return _instance;
                }
            }
        }

        private void VerClientes_Load(object sender, EventArgs e)
        {
            LoadInitialData(); // Initialize data  
            InicializarDataGridView(); // Set up DataGridView after data has been loaded  
        }

        private void InicializarDataGridView()
        {
            dataGridViewClientes1.CellValueNeeded += dataGridViewClientes1_CellValueNeeded;
            dataGridViewClientes1.Scroll += new ScrollEventHandler(dataGridViewClientes1_Scroll);
            dataGridViewClientes1.DataSource = bindingList; // Settea la fuente inicial de datos  
        }

        private void LoadInitialData()
        {
            bindingList.Clear(); // Clear the binding list before loading initial data
            paginaActual = 0;
            allClients = ClientManager.Clients
                           .GroupBy(c => c.ID)
                           .Select(g => g.First())
                           .ToList(); // Ensure uniqueness
            LoadPage(paginaActual);
        }


        private void LoadPage(int pageNumber)
        {
            int startIndex = pageNumber * pageSize;
            var pageClients = allClients.Skip(startIndex).Take(pageSize).ToList();

            bindingList.Clear(); // Clear the binding list before adding new data

            foreach (var client in pageClients)
            {
                bindingList.Add(client);
            }
        }



        private void dataGridViewClientes1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < bindingList.Count)
            {
                var client = bindingList[e.RowIndex];
                switch (e.ColumnIndex)
                {
                    case 0: e.Value = e.RowIndex; break;
                    case 1: e.Value = client.Nombres; break;
                    case 2: e.Value = client.Apellidos; break;
                    case 3: e.Value = client.ID; break;
                    case 4: e.Value = client.Email; break;
                    case 5: e.Value = client.NumeroTelefono; break;
                }
            }
        }


        private void dataGridViewClientes1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (e.NewValue + dataGridViewClientes1.DisplayedRowCount(false) >= dataGridViewClientes1.RowCount - 1)
                {
                    LoadMoreData();
                }
            }
        }

        private void LoadMoreData()
        {
            paginaActual++;
            int startIndex = paginaActual * pageSize;

            // Check if there are more clients to load
            if (startIndex < allClients.Count)
            {
                var pageClients = allClients.Skip(startIndex).Take(pageSize).ToList();

                // Add more clients to the BindingList
                foreach (var client in pageClients)
                {
                    bindingList.Add(client);
                }

                dataGridViewClientes1.Refresh(); // Refresh to show updated data
            }
            else
            {
                paginaActual--; // Revert if no more clients to load
            }

            
        }


        private void botonRectanguloRedondo1_Click(object sender, EventArgs e)
        {
            using (var form = new AgregarComprador())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ClientManager.AddClient(form.Cliente);
                    RefreshClientList(); // Refresh the client list and DataGridView
                }
            }
        }



        private void RefreshClientList()
        {
            //bindingList.Clear(); // Clear existing data to avoid duplicates
            LoadInitialData();
            //// Fetch the complete list again and ensure uniqueness  
            //allClients = ClientManager.Clients
            //                    .GroupBy(c => c.ID)
            //                    .Select(g => g.First())
            //                    .ToList();

            //// Add all clients to the BindingList  
            //foreach (var client in allClients)
            //{
            //    bindingList.Add(client);
            //}

            //dataGridViewClientes1.DataSource = null;
            //dataGridViewClientes1.DataSource = bindingList; // Re-bind the DataGridView to the BindingList
            //dataGridViewClientes1.Refresh(); // Refresh the DataGridView
        }





        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string busquedaID = txtBusqueda.Text.Trim();
            List<Cliente> filteredClients = string.IsNullOrWhiteSpace(busquedaID)
              ? ClientManager.Clients.ToList() // All clients if no search term  
              : ClientManager.Clients.Where(c => c.ID.Contains(busquedaID)).ToList(); // Filtered clients

            bindingList.Clear();

            foreach (var client in filteredClients)
            {
                bindingList.Add(client);
            }

            if (filteredClients.Any())
            {
                MessageBox.Show("Cliente(s) encontrado!", "Resultados de Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.", "Resultados de Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

