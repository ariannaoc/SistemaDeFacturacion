using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;


namespace Parcial2_SistemaDeFacturacion
{
    public partial class BusquedaProductosFacturacion : Form
    {
        public event Action<Productos> ProductoSeleccionado;

        private BindingList<Productos> bindingList = new BindingList<Productos>();
        private List<Productos> allProducts = new List<Productos>();
        private int pageSize = 10;
        private int currentPage = 0;
        private DataGridViewButtonColumn selectButton;

        public BusquedaProductosFacturacion()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadInitialData(); // Load initial data into the grid  
        }

        private void InitializeDataGridView()
        {
            dataGridViewProductos.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewProductos.AutoGenerateColumns = false;

            dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "RowNum", HeaderText = "#", Width = 50 });
            dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre", DataPropertyName = "nombre_productos", Width = 150 });
            dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Descripcion", HeaderText = "Descripcion", DataPropertyName = "descripcion_productos", Width = 250 });
            dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Stock", HeaderText = "Stock", DataPropertyName = "stock_productos", Width = 80 });
            dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Categoria", HeaderText = "Categoria", DataPropertyName = "categoria_productos", Width = 100 });
            dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Marca", HeaderText = "Marca", DataPropertyName = "marca_productos", Width = 100 });

            dataGridViewProductos.DataSource = bindingList;
            dataGridViewProductos.Scroll += dataGridViewClientes2_Scroll;

            selectButton = new DataGridViewButtonColumn
            {
                Name = "Seleccionar",
                HeaderText = "Seleccionar",
                Text = "Seleccionar",
                UseColumnTextForButtonValue = true,
                Width = 75
            };
            dataGridViewProductos.Columns.Add(selectButton);
            dataGridViewProductos.CellClick += DataGridViewClientes2_CellClick;
        }

        private void DataGridViewClientes2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewProductos.Columns["Seleccionar"].Index && e.RowIndex >= 0)
            {
                var selectedProduct = bindingList[e.RowIndex];
                ProductoSeleccionado?.Invoke(selectedProduct);
                this.Close();
            }
        }

        private void LoadInitialData()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false // Disable header validation
            };

            using (var reader = new StreamReader(@"..\..\JSONS\Ejemplo.csv"))
            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap<ProductoMap>(); // Register the class map for Productos
                allProducts = csv.GetRecords<Productos>().ToList();
            }

            // Ensure all products are loaded initially
            bindingList.Clear();
            foreach (var product in allProducts)
            {
                bindingList.Add(product);
            }
        }

        private void LoadPage(int pageNumber)
        {
            int startIndex = pageNumber * pageSize;
            var pageProducts = allProducts.Skip(startIndex).Take(pageSize).ToList();
            foreach (var product in pageProducts)
            {
                bindingList.Add(product);
            }
        }

        private void dataGridViewClientes2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (e.NewValue + dataGridViewProductos.DisplayedRowCount(false) >= dataGridViewProductos.RowCount - 1)
                {
                    LoadMoreData();
                }
            }
        }

        private void LoadMoreData()
        {
            currentPage++;
            if (currentPage * pageSize < allProducts.Count)
            {
                LoadPage(currentPage);
            }
            else
            {
                currentPage--;
            }
        }

        private void botonRectanguloRedondo1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnadirCliente_Click(object sender, EventArgs e)
        {
            // (This method remains unchanged if it searches for clients)
        }

        private void BusquedaProductosFacturacion_Load(object sender, EventArgs e)
        {
            // (Optional: Add any loading logic if needed)
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchName = txtBusqueda.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchName))
            {
                MessageBox.Show("Por favor, ingrese un nombre para buscar.", "Resultados de Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<Productos> filteredProducts = allProducts
                .Where(p => p.nombre_productos.IndexOf(searchName, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            bindingList.Clear();
            foreach (var product in filteredProducts.Take(pageSize))
            {
                bindingList.Add(product);
            }

            MessageBox.Show(filteredProducts.Any() ? "Producto(s) encontrado!" : "Producto no encontrado.", "Resultados de Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // Define a mapping configuration for the class
    public sealed class ProductoMap : ClassMap<Productos>
    {
        public ProductoMap()
        {
            // Map columns by index since there are no headers in the CSV file
            Map(m => m.nombre_productos).Index(0);
            Map(m => m.descripcion_productos).Index(1);
            Map(m => m.stock_productos).Index(2);
            Map(m => m.categoria_productos).Index(3);
            Map(m => m.marca_productos).Index(4);
        }
    }


}
