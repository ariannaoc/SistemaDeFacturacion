using Newtonsoft.Json;
using Parcial2_SistemaDeFacturacion;
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
using System.IO;
using System.Text.Json.Serialization;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace Parcial2_SistemaDeFacturacion
{
    public partial class Facturacion : BaseActualizarPanel
    {
        private static Facturacion _instance;
        private static readonly object _lock = new object();
        private BindingList<Cliente> clientList; // lista existente de clientes
        private BindingList<Productos> productList; // nueva lista de productos 
        private VerClientes verClientes; 
        private Cliente selectedClient; // Campo para guardar el cliente seleccionado 
        private Productos selectedProduct; // Field to store the selected product

        public const double IVA = 0.16; // constante de IVA
        public const double IGTF = 0.03; // constante para el IGTF (clientes especiales)
        private const string DocumentNumberFilePath = @"../../JSONS/numeroDeFactura.json";
        private int nextNumber;

        public Facturacion()
        {
            InitializeComponent();
            verClientes = VerClientes.Instance;
            clientList = new BindingList<Cliente>();
            productList = new BindingList<Productos>(); // inicializa la lista de productos
            dataGridViewMostrarProductos.DataSource = productList; // enlaza el DataGridView a la lista de productos
            //*************************************************
            
            string lastDocumentNumber = GetLastDocumentNumberFromJson();
            int lastNumber = int.Parse(lastDocumentNumber.Substring(3));
            nextNumber = lastNumber + 1;
           
            lblnDoc.Text = $"DOC{nextNumber:D4}";

            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");


        }

        public static Facturacion Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Facturacion();
                    }
                    return _instance;
                }
            }
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            InitializeProductDataGridView(); // inicializa DataGridView para los productos  
        }

        private void InitializeProductDataGridView()
        {
            dataGridViewMostrarProductos.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewMostrarProductos.AutoGenerateColumns = false;
            dataGridViewMostrarProductos.Columns.Clear(); // Limpia existentes columnas para prevenir los duplicados

            dataGridViewMostrarProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre", DataPropertyName = "nombre_productos", Width = 150, ReadOnly = true });
            //dataGridViewMostrarProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Descripcion", HeaderText = "Descripcion", DataPropertyName = "descripcion_productos", Width = 250, ReadOnly = true });
            //dataGridViewMostrarProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Stock", HeaderText = "Stock", DataPropertyName = "stock_productos", Width = 80, ReadOnly = true });
            dataGridViewMostrarProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Categoria", HeaderText = "Categoria", DataPropertyName = "categoria_productos", Width = 100, ReadOnly = true });
            dataGridViewMostrarProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Marca", HeaderText = "Marca", DataPropertyName = "marca_productos", Width = 100, ReadOnly = true });
            dataGridViewMostrarProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cantidad", HeaderText = "Cantidad", DataPropertyName = "Cantidad", Width = 80, ReadOnly = false });
            dataGridViewMostrarProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Precio", HeaderText = "Precio", DataPropertyName = "precio_productos", Width = 100, ReadOnly = true });

            // Anade el boton de eliminar en la compra (colocar icono)
            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "Eliminar",
                HeaderText = "Accion",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
                Width = 75
            };
            dataGridViewMostrarProductos.Columns.Add(deleteButton);

            dataGridViewMostrarProductos.CellClick += DataGridViewMostrarProductos_CellClick;
            dataGridViewMostrarProductos.CellEndEdit += DataGridViewMostrarProductos_CellEndEdit;
        }


        private void DataGridViewMostrarProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewMostrarProductos.Columns["Eliminar"].Index)
            {
                productList.RemoveAt(e.RowIndex); // remueve el item seleccionado
            }
        }

        private void DataGridViewMostrarProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewMostrarProductos.Columns["Cantidad"].Index)
            {
                var product = productList[e.RowIndex];
                int cantidad;
                if (!int.TryParse(dataGridViewMostrarProductos.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString()  , out cantidad)|| cantidad < 0)
                {
                    
                    MessageBox.Show("Cantidad Invalida. Por favor ingrese un numero entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                double unitPrice = Convert.ToDouble(product.precio_productos);
                double totalPrice = cantidad * unitPrice;
                dataGridViewMostrarProductos.Rows[e.RowIndex].Cells["Precio"].Value = totalPrice.ToString();
                leerSubTotal_TextChanged(sender, e); // actualiza el subtotal
            }
        }


        public double SubTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridViewMostrarProductos.Rows)
            {
                if (row.Cells["Precio"].Value != null)
                {
                    double price = Convert.ToDouble(row.Cells["Precio"].Value.ToString().Replace("$", "").Replace(",", "").Trim());
                    total += price;
                }
            }
            return total;
        }


        private void FinishSellButton_Click(object sender, EventArgs e)
        {
           
        }


        private void botonRectanguloRedondo1_Click(object sender, EventArgs e)
        {
            //Inventario facturacion = Inventario.Instance;
            //ActualizarPanelPrincipal(facturacion);
        }

        private void btnAnadirCliente_Click(object sender, EventArgs e) // Cliente existente funcionalidad  
        {
            using (var searchForm = new BusquedaClientesFacturacion())
            {
                searchForm.ClienteSeleccionado += SearchForm_ClienteSeleccionado;
                searchForm.ShowDialog();
            }
        }

        private void SearchForm_ClienteSeleccionado(Cliente client)
        {
            selectedClient = client; // Almacena el cliente
            leerCliente_TextChanged(leerCliente, EventArgs.Empty);
        }

        private void leerCliente_TextChanged(object sender, EventArgs e)
        {
            if (selectedClient != null)
            {
                leerCliente.Text = $"Cliente: {selectedClient.Nombres} {selectedClient.Apellidos}\nCedula: {selectedClient.ID}";
            }
        }

        private void btnAnadirProducto_Click(object sender, EventArgs e) // anadir producto busqueda  
        {
            if (selectedClient == null)
            {
                MessageBox.Show("Por favor añadir un cliente antes de agregar un producto.", "Client Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var searchForm = new BusquedaProductosFacturacion()) // abrir el form de busqueda de productos
            {
                searchForm.ProductoSeleccionado += SearchForm_ProductoSeleccionado; 
                searchForm.ShowDialog();
            }
        }


        private void SearchForm_ProductoSeleccionado(Productos product)
        {
            selectedProduct = product; // Guarda el producto seleccionado 
            productList.Add(product); // Anade el producto seleccionado al DataGridView  
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            // nada 
        }

        private void dataGridViewMostrarProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // nada
        }

        private void SubtotalMostrar_Click(object sender, EventArgs e)
        {

        }

        private void leerSubTotal_TextChanged(object sender, EventArgs e)
        {
            if (selectedClient == null)
            {
                MessageBox.Show(@"Cliente no ha sido seleccionado. Por favor ingresa un cliente primero antes de seleccionar un producto. Es necesario para el calculo de impuestos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double subTotal = SubTotal();
            double ivaTotal = subTotal * IVA;
            double igtfTotal = selectedClient.ContribuyenteEspecial ? subTotal * IGTF : 0;
            double total = subTotal + ivaTotal + igtfTotal;

            leerSubTotal.Text = $"SubTotal: {subTotal:C2}\nIVA: {ivaTotal:C2}\nIGTF: {igtfTotal:C2}\n\nTotal: {total:C2}";
        }

        private string GenerateNextDocumentNumber()
        {
            string lastDocumentNumber = GetLastDocumentNumberFromJson();
            int lastNumber = int.Parse(lastDocumentNumber.Substring(3));
             nextNumber = lastNumber + 1;
            return $"doc{nextNumber:D4}";
        }

        private string GetLastDocumentNumberFromJson()
        {
            if (!File.Exists(DocumentNumberFilePath))
            {
                return "doc0000"; // si no existe un numero empieza aqui
            }

            var jsonData = File.ReadAllText(DocumentNumberFilePath);
            var jsonObj = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonData);

            if (jsonObj != null && jsonObj.ContainsKey("lastDocumentNumber"))
            {
                return jsonObj["lastDocumentNumber"];
            }

            return "doc0000"; // default
        }

        private void SaveDocumentNumberToJson(string documentNumber)
        {
            var jsonObj = new Dictionary<string, string>
    {
        { "lastDocumentNumber", documentNumber }
    };

            var jsonData = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
            File.WriteAllText(DocumentNumberFilePath, jsonData);
        }

        private void SaveInvoiceDetailsToJson(string documentNumber, string filePath)
        {
            string jsonFilePath = @"..\..\JSONS\invoices.json";

            List<InvoiceInfo> invoices = new List<InvoiceInfo>();

            
            if (File.Exists(jsonFilePath))
            {
                var jsonData = File.ReadAllText(jsonFilePath);
                invoices = JsonConvert.DeserializeObject<List<InvoiceInfo>>(jsonData) ?? new List<InvoiceInfo>();
            }

            
            invoices.Add(new InvoiceInfo { DocumentNumber = documentNumber, FilePath = filePath, Date = DateTime.Now });

            
            var updatedJsonData = JsonConvert.SerializeObject(invoices, Formatting.Indented);
            File.WriteAllText(jsonFilePath, updatedJsonData);
        }


        private List<Productos> LoadProductsFromCsv()
        {
            var products = new List<Productos>();
            var csvFilePath = "Ejemplo.csv"; 

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true 
            };

            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap<ProductoMap>(); 
                products = csv.GetRecords<Productos>().ToList();
            }

            return products;
        }

        private void FinishSellButton_Click_1(object sender, EventArgs e)
        {
            
            var existingProducts = LoadProductsFromCsv();

            if (SubTotal() == 0) //no deja al usuario proceder si su compra es de 0
            {
                MessageBox.Show(@"No hay Productos seleccionados. Por favor seleccione un producto antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow row in dataGridViewMostrarProductos.Rows)
            {
                if (row.Cells["Nombre"].Value != null && row.Cells["Cantidad"].Value != null)
                {
                    string nombreProducto = row.Cells["Nombre"].Value.ToString();
                    int cantidadVendida = Convert.ToInt32(row.Cells["Cantidad"].Value);

                   
                    var product = existingProducts.FirstOrDefault(p => p.nombre_productos == nombreProducto);
                    if (product != null)
                    {
                        
                        if (cantidadVendida <= product.stock_productos)
                        {
                            
                            product.stock_productos -= cantidadVendida;
                        }
                        else
                        {
                            MessageBox.Show($"No hay suficiente stock para {product.nombre_productos}", "Error de Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; 
                        }
                    }
                }
            }

           
            SaveUpdatedStockToCsv(existingProducts);

           
            dataGridViewMostrarProductos.Refresh();
            leerSubTotal_TextChanged(sender, e); // Actualiza el subtotal

           
            MessageBox.Show("Stock actualizado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            string newDocumentNumber = GenerateNextDocumentNumber();
            SaveDocumentNumberToJson(newDocumentNumber);

            
            double subtotal = SubTotal();
            double ivaTotal = subtotal * IVA;
            double igtfTotal = selectedClient.ContribuyenteEspecial ? subtotal * IGTF : 0;
            double total = subtotal + ivaTotal + igtfTotal;

            
            var generarPDF = new GenerarPDF();
            string pdfFilePath = Path.Combine(@"..\..\Facturas", $"{newDocumentNumber}.pdf");
            generarPDF.generarPDF(selectedClient, productList, newDocumentNumber, subtotal, total, ivaTotal, igtfTotal);

          
            SaveInvoiceDetailsToJson(newDocumentNumber, pdfFilePath);

            // limpia la data de los clientes en la facturacion
            selectedClient = null;
            leerSubTotal.Text = "";
            leerCliente.Text = "";
            productList.Clear();
            dataGridViewMostrarProductos.Refresh();

           
            MessageBox.Show($"Pagaste: Bs {total}", "Total", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }

        
        private void SaveUpdatedStockToCsv(List<Productos> updatedProducts)
        {
            var csvFilePath = @"Ejemplo.csv"; 

            using (var writer = new StreamWriter(csvFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<ProductoMap>(); 
                csv.WriteHeader<Productos>();
                csv.NextRecord();
                csv.WriteRecords(updatedProducts);
            }
        }


        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Estas seguro que quieres cancelar la compra?", "Cancelar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Limpia el cliente seleccionado
                selectedClient = null;
                leerCliente.Text = "";
                leerSubTotal.Text = null;

                // Limpia DataGridView
                productList.Clear();
                dataGridViewMostrarProductos.Refresh();

                MessageBox.Show("Compra cancelada exitosamente.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //No hay nada porque regresa a facturacion
            }
        }

        
    }

   
}

