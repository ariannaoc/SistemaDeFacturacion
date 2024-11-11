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
            dataGridViewClientes1.Columns.Add("NumeroCliente", "#");
            dataGridViewClientes1.Columns.Add("Nombres", "Nombres");
            dataGridViewClientes1.Columns.Add("Apellidos", "Apellidos");
            dataGridViewClientes1.Columns.Add("Cedula", "Cedula");
            dataGridViewClientes1.Columns.Add("Email", "Email");
            dataGridViewClientes1.Columns.Add("NumeroTelefono", "Numero Telefono");

            // Anade boton a la columna de editar
            DataGridViewButtonColumn editarBotonColumna = new DataGridViewButtonColumn
            {
                Name = "Editar",
                HeaderText = "Editar",
                Text = "Editar",
                UseColumnTextForButtonValue = true
            };
            dataGridViewClientes1.Columns.Add(editarBotonColumna);

            // Anade boton a la columna de eliminar
            DataGridViewButtonColumn eliminarBotonColumna = new DataGridViewButtonColumn
            {
                Name = "Eliminar",
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
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
                            bindingList[e.RowIndex] = form.Cliente; // Actualiza binding list
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
                        bindingList.RemoveAt(e.RowIndex); // Actualiza binding list y automaticamente actualiza el DataGridView  
                    }
                }
            }
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
            InicializarDataGridView();
            LoadInitialData();
        }

        private void InicializarDataGridView()
        {
            dataGridViewClientes1.CellValueNeeded += dataGridViewClientes1_CellValueNeeded;
            dataGridViewClientes1.Scroll += new ScrollEventHandler(dataGridViewClientes1_Scroll);
            dataGridViewClientes1.DataSource = bindingList; // Settea la fuente inicial de datos  
        }

        private void LoadInitialData()
        {
            allClients = ClientManager.Clients.ToList();
            foreach (var client in allClients.Take(pageSize))
            {
                bindingList.Add(client); // Llena el binding list  
            }
        }

        private void LoadPage(int pageNumber)
        {
            int startIndex = pageNumber * pageSize;
            var pageClients = allClients.Skip(startIndex).Take(pageSize).ToList();
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
            if (paginaActual * pageSize < allClients.Count)
            {
                LoadPage(paginaActual);
            }
            else
            {
                paginaActual--; // Revierte el conteo de pagina si no hay mas cliente
            }
        }

        private void botonRectanguloRedondo1_Click(object sender, EventArgs e)
        {
            using (var form = new AgregarComprador())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int conteoInicial = ClientManager.Clients.Count;
                    ClientManager.AddClient(form.Cliente);
                    if (ClientManager.Clients.Count > conteoInicial)
                    {
                        bindingList.Add(form.Cliente); // Anade el cliente mas recientemente anadido al binding list  
                    }
                }
            }
        }

       
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
                string busquedaID = txtBusqueda.Text.Trim();
                List<Cliente> filteredClients = string.IsNullOrWhiteSpace(busquedaID)
                    ? ClientManager.Clients.ToList()
                    : ClientManager.Clients.Where(c => c.ID.Contains(busquedaID)).ToList();

                bindingList.Clear(); // Limpia data existente en el binding list  
                foreach (var client in filteredClients)
                {
                    bindingList.Add(client); // Llena el binding list con los resultados de filtrado 
                }

                MessageBox.Show(filteredClients.Any() ? "Cliente(s) encontrado!" : "Cliente no encontrado.", "Resultados de Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

