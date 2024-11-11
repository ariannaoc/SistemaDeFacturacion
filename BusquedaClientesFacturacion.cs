using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_SistemaDeFacturacion
{
    public partial class BusquedaClientesFacturacion : Form
    {
        public event Action<Cliente> ClienteSeleccionado;

        private BindingList<Cliente> bindingList = new BindingList<Cliente>();
        private List<Cliente> allClients = new List<Cliente>();
        private int pageSize = 10;
        private int currentPage = 0;
        private DataGridViewButtonColumn selectButton; // Field to store the "Select" button column

        public BusquedaClientesFacturacion()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadInitialData(); // Load initial data into the grid
        }

        private void InitializeDataGridView()
        {
            dataGridViewClientes2.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewClientes2.AutoGenerateColumns = false;

            // Define columns here
            dataGridViewClientes2.Columns.Add(new DataGridViewTextBoxColumn { Name = "RowNum", HeaderText = "#", Width = 50 });
            var nombresColumn = new DataGridViewTextBoxColumn { Name = "Nombres", HeaderText = "Nombres", DataPropertyName = "Nombres", Width = 150, Visible = false }; // Initially hidden
            dataGridViewClientes2.Columns.Add(nombresColumn);
            var idColumn = new DataGridViewTextBoxColumn { Name = "ID", HeaderText = "ID", DataPropertyName = "ID", Width = 100, Visible = false }; // Initially hidden
            dataGridViewClientes2.Columns.Add(idColumn);

            dataGridViewClientes2.DataSource = bindingList;
            dataGridViewClientes2.Scroll += dataGridViewClientes2_Scroll; // Attach scroll event

            // Add Select button
            selectButton = new DataGridViewButtonColumn
            {
                Name = "Select",
                HeaderText = "Select",
                Text = "Select",
                UseColumnTextForButtonValue = true,
                Width = 75,
                Visible = false // Initially hidden
            };
            dataGridViewClientes2.Columns.Add(selectButton);

            dataGridViewClientes2.CellClick += DataGridViewClientes2_CellClick; // Attach cell click event
        }

        private void DataGridViewClientes2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewClientes2.Columns["Select"].Index && e.RowIndex >= 0)
            {
                var selectedClient = bindingList[e.RowIndex];
                ClienteSeleccionado?.Invoke(selectedClient);
                this.Close(); // Close the form after selection
            }
        }

        private void LoadInitialData()
        {
            allClients = ClientManager.Clients.ToList(); // Get all clients directly from ClientManager
            foreach (var client in allClients.Take(pageSize))
            {
                bindingList.Add(client); // Load the first page of clients
            }
        }

        private void LoadPage(int pageNumber)
        {
            int startIndex = pageNumber * pageSize;
            var pageClients = allClients.Skip(startIndex).Take(pageSize).ToList();
            foreach (var client in pageClients)
            {
                bindingList.Add(client); // Add more clients to the binding list
            }
        }

        private void dataGridViewClientes2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (e.NewValue + dataGridViewClientes2.DisplayedRowCount(false) >= dataGridViewClientes2.RowCount - 1)
                {
                    LoadMoreData();
                }
            }
        }

        private void LoadMoreData()
        {
            currentPage++;
            if (currentPage * pageSize < allClients.Count)
            {
                LoadPage(currentPage);
            }
            else
            {
                currentPage--; // Revert the page count if there are no more clients
            }
        }

        private void botonRectanguloRedondo1_Click(object sender, EventArgs e)
        {
            string searchID = txtBusqueda.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchID))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.", "Resultados de Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<Cliente> filteredClients = allClients.Where(c => c.ID.Contains(searchID)).ToList();

            bindingList.Clear(); // Clear existing data in binding list
            foreach (var client in filteredClients.Take(pageSize))
            {
                bindingList.Add(client); // Load filtered data
            }

            // Show the Nombres, ID, and Select columns after filtering
            dataGridViewClientes2.Columns["Nombres"].Visible = true;
            dataGridViewClientes2.Columns["ID"].Visible = true;
            selectButton.Visible = true;

            MessageBox.Show(filteredClients.Any() ? "Cliente(s) encontrado!" : "Cliente no encontrado.", "Resultados de Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAnadirCliente_Click(object sender, EventArgs e)
        {
            string searchID = txtBusqueda.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchID))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.", "Resultados de Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<Cliente> filteredClients = allClients.Where(c => c.ID.Equals(searchID, StringComparison.Ordinal)).ToList(); // Ensure exact match

            bindingList.Clear(); // Clear existing data in binding list

            foreach (var client in filteredClients.Take(pageSize))
            {
                bindingList.Add(client); // Load filtered data
            }

            // Show the Nombres, ID, and Select columns after filtering
            dataGridViewClientes2.Columns["Nombres"].Visible = true;
            dataGridViewClientes2.Columns["ID"].Visible = true;
            selectButton.Visible = true;

            if (filteredClients.Count == 0)
            {
                MessageBox.Show("Cliente no encontrado.", "Resultados de Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cliente(s) encontrado!", "Resultados de Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BusquedaClientesFacturacion_Load(object sender, EventArgs e)
        {

        }
    }


}
