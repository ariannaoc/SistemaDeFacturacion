using Parcial2_SistemaDeFacturacion.BotonesCustomizados;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Drawing.Text;
using System.CodeDom;

namespace Parcial2_SistemaDeFacturacion
{


    public partial class Inventario : UserControl
    {
        private static Inventario instance;
        private const int stock_minimo = 5;
        private int ID_Producto = 1;
        private int eliminados = 0;

        List<Productos> ListaProductos = new List<Productos>();

        public Inventario()
        {
            InitializeComponent();
            CargarContador();
            CargarProductosDesdeCsv();
            ActualizarDataGridView();
            btnTodosProductos_Click(null, EventArgs.Empty);
            toolTipbtnImportar.SetToolTip(btnImportarProductos, "Sólo puede importar archivos con la extensión .csv. El archivo debe tener la siguiente estructura:\n Nombre del producto, estado del producto (Disponible o No Disponible), descripción del producto,\n stock del producto, categoría del producto (siempre está en Ninguna), marca del producto y \nprecio del producto separados por comas ','.");
            toolTipbtnEditarPrdt.SetToolTip(btnEditarProducto, "Para editar un Producto, seleccione una fila rellene \nlos campos con los datos nuevos y presione este botón");
            toolTipbtnAgregarPrdt.SetToolTip(btnGuardarProducto, "Para añadir un Producto, rellene los campos con \nlos datos solicitados y presione este botón");
            toolTipbtnEliminarPrdt.SetToolTip(btnEliminarProducto, "Para eliminar un Producto, seleccione una fila y presione este botón");
        }

        public static Inventario Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Inventario();
                }
                return instance;
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            btnTodosLosProductos.Select();
            
            cbbCatgProducto.DataSource = ListasGlobales.ListaCategorias;
            ListasGlobales.ListaCategorias.Insert(0, "Ninguna");
            cbbEstadoProducto.Items.Add("Disponible");
            cbbEstadoProducto.Items.Add("No Disponible");

        }


        private void VerificarStock()
        {
            foreach (DataGridViewRow row in DGV_inventarioProductos.Rows)
            {
                int stockActual = Convert.ToInt32(row.Cells[4].Value);

                if (stockActual <= stock_minimo)
                {
                    string nombreProducto = row.Cells[1].Value.ToString();
                    MessageBox.Show($"Quedan pocas unidades del producto: {nombreProducto}");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonRectanguloRedondo1_Click(object sender, EventArgs e)
        {

        }
        private void btnTodosProductos_Click(object sender, EventArgs e)
        {
            btnTodosLosProductos.BackColor = Color.LightPink;
            btnTodosLosProductos.TextColor = Color.DarkRed;
            btnProductosActivos.BackColor = Color.White;
            btnProductosActivos.TextColor = Color.Black;
            btnProductosArchivados.BackColor = Color.White;
            btnProductosArchivados.TextColor = Color.Black;
            foreach (DataGridViewRow row in DGV_inventarioProductos.Rows)
            {
                row.Visible = true;
            }
        }

        private void btn_actProductos_Click(object sender, EventArgs e)
        {
            btnProductosActivos.BackColor = Color.LightPink;
            btnProductosActivos.TextColor = Color.DarkRed;
            btnTodosLosProductos.BackColor = Color.White;
            btnTodosLosProductos.TextColor = Color.Black;
            btnProductosArchivados.BackColor = Color.White;
            btnProductosArchivados.TextColor = Color.Black;

            foreach (DataGridViewRow row in DGV_inventarioProductos.Rows)
            {
                string estado = row.Cells[2].Value.ToString();
                row.Visible = estado != "No Disponible";
            }

        }

        private void btn_archProductos_Click(object sender, EventArgs e)
        {
            btnProductosArchivados.BackColor = Color.LightPink;
            btnProductosArchivados.TextColor = Color.DarkRed;
            btnProductosActivos.BackColor = Color.White;
            btnProductosActivos.TextColor = Color.Black;
            btnTodosLosProductos.BackColor = Color.White;
            btnTodosLosProductos.TextColor = Color.Black;

            foreach (DataGridViewRow row in DGV_inventarioProductos.Rows)
            {
                string estado = row.Cells[2].Value.ToString();
                row.Visible = estado != "Disponible";
            }

        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadirProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnExportarProductos_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "C:\\";
                saveFileDialog.Filter = "CSV files (.csv)|.csv|All files (.)|.";
                saveFileDialog.Title = "Guardar archivo CSV";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    GuardarProductosParaExportarEnCsv(filePath);
                }
            }
        }

        private void GuardarProductosParaExportarEnCsv(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    
                    foreach (var producto in ListaProductos)
                    {
                        string linea = $"{producto.id_productos},{producto.nombre_productos},{producto.estado_productos},{producto.descripcion_productos},{producto.stock_productos},{producto.categoria_productos},{producto.marca_productos},{producto.precio_productos}";
                        writer.WriteLine(linea);
                    }
                }

                MessageBox.Show("Archivo CSV exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al exportar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void DGV_inventarioProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void escribirNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void escribirDescProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerraAggProducto_Click(object sender, EventArgs e)
        {

        }

        
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (DGV_inventarioProductos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de querer eliminar la fila seleccionada?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in DGV_inventarioProductos.SelectedRows)
                    {
                        int indicefila = row.Index;
                        DGV_inventarioProductos.Rows.RemoveAt(row.Index);
                        DGV_inventarioProductos.ClearSelection();
                        ListaProductos.RemoveAt(indicefila);
                    }
                    GuardarProductosEnCsv();
                    eliminados += 1;
                    GuardarContador();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una fila para eliminar.");
            }
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(escribirNombreProducto.Text) && !string.IsNullOrWhiteSpace(escribirDescProducto.Text) && !string.IsNullOrWhiteSpace(escribirStockProducto.Text) && !string.IsNullOrWhiteSpace(escribirMarcaProducto.Text) && cbbCatgProducto.SelectedItem != null && cbbEstadoProducto.SelectedItem != null && !string.IsNullOrWhiteSpace(escribirPrecioProducto.Text))
            {
                string inputText = escribirNombreProducto.Text.Trim();
                string inputText2 = escribirDescProducto.Text.Trim();
                string inputText3 = cbbCatgProducto.SelectedItem.ToString();
                string inputText4 = escribirStockProducto.Text.Trim();
                string inputText5 = escribirMarcaProducto.Text.Trim();
                string inputText6 = cbbEstadoProducto.SelectedItem.ToString();
                string inputText7 = escribirPrecioProducto.Text.Trim();

                if (System.Text.RegularExpressions.Regex.IsMatch(inputText, @"^[0-9\p{P}\s]+$") || System.Text.RegularExpressions.Regex.IsMatch(inputText2, @"^[0-9\p{P}\s]+$") || System.Text.RegularExpressions.Regex.IsMatch(inputText3, @"^[0-9\p{P}\s]+$") || !System.Text.RegularExpressions.Regex.IsMatch(inputText4, @"^\d+$") || System.Text.RegularExpressions.Regex.IsMatch(inputText5, @"^[0-9\p{P}\s]+$") || !System.Text.RegularExpressions.Regex.IsMatch(inputText7, @"^\d+$"))
                {
                    MessageBox.Show("Por favor ingrese datos válidos.");
                }
                if (inputText.Contains(",") || inputText2.Contains(",") || inputText5.Contains(",") || inputText7.Contains(","))
                {
                    MessageBox.Show("El contenido no puede tener comas ','");
                }
                else if (!string.IsNullOrWhiteSpace(escribirNombreProducto.Text) && !string.IsNullOrWhiteSpace(escribirDescProducto.Text) && !string.IsNullOrWhiteSpace(escribirStockProducto.Text) && !string.IsNullOrWhiteSpace(escribirMarcaProducto.Text) && cbbCatgProducto.SelectedItem != null && cbbEstadoProducto.SelectedItem != null && !string.IsNullOrWhiteSpace(escribirPrecioProducto.Text))
                {

                    int cantfilas = DGV_inventarioProductos.Rows.Add();
                    DGV_inventarioProductos.Rows[cantfilas].Cells[0].Value = ID_Producto;
                    DGV_inventarioProductos.Rows[cantfilas].Cells[1].Value = escribirNombreProducto.Text;
                    DGV_inventarioProductos.Rows[cantfilas].Cells[2].Value = cbbEstadoProducto.SelectedItem;
                    DGV_inventarioProductos.Rows[cantfilas].Cells[3].Value = escribirDescProducto.Text;
                    DGV_inventarioProductos.Rows[cantfilas].Cells[4].Value = escribirStockProducto.Text;
                    DGV_inventarioProductos.Rows[cantfilas].Cells[5].Value = cbbCatgProducto.SelectedItem;
                    DGV_inventarioProductos.Rows[cantfilas].Cells[6].Value = escribirMarcaProducto.Text;
                    DGV_inventarioProductos.Rows[cantfilas].Cells[7].Value = escribirPrecioProducto.Text;


                    Productos nuevoProducto = new Productos()
                    {
                        id_productos = ID_Producto,
                        nombre_productos = escribirNombreProducto.Text,
                        estado_productos = cbbEstadoProducto.SelectedItem.ToString(),
                        descripcion_productos = escribirDescProducto.Text,
                        stock_productos = int.Parse(escribirStockProducto.Text), 
                        categoria_productos = cbbCatgProducto.SelectedItem.ToString(),
                        marca_productos = escribirMarcaProducto.Text,
                        precio_productos = double.Parse(escribirPrecioProducto.Text)
                    };

                    ListaProductos.Add(nuevoProducto);

                    escribirNombreProducto.Text = "";
                    cbbEstadoProducto.SelectedItem = null;
                    escribirDescProducto.Text = "";
                    cbbCatgProducto.SelectedItem = null;
                    escribirStockProducto.Text = "";
                    escribirMarcaProducto.Text = "";
                    escribirPrecioProducto.Text = "";
                    ID_Producto += 1;
                    DGV_inventarioProductos.ClearSelection();
                    GuardarProductosEnCsv();


                }
                else
                {
                    MessageBox.Show("Ningún campo puede estar vacío.");
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar llenos.");
            }
        }

        private void cbbCatgProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(escribirNombreProducto.Text) && !string.IsNullOrWhiteSpace(escribirDescProducto.Text) && !string.IsNullOrWhiteSpace(escribirStockProducto.Text) && !string.IsNullOrWhiteSpace(escribirMarcaProducto.Text) && cbbCatgProducto.SelectedItem != null && cbbEstadoProducto.SelectedItem != null && !string.IsNullOrWhiteSpace(escribirPrecioProducto.Text))
            {
                string inputText = escribirNombreProducto.Text.Trim();
                string inputText2 = escribirDescProducto.Text.Trim();
                string inputText3 = cbbCatgProducto.SelectedItem.ToString();
                string inputText4 = escribirStockProducto.Text.Trim();
                string inputText5 = escribirMarcaProducto.Text.Trim();
                string inputText6 = cbbEstadoProducto.SelectedItem.ToString();
                string inputText7 = escribirPrecioProducto.Text.Trim();

                if (DGV_inventarioProductos.SelectedRows.Count > 0)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(inputText, @"^[0-9\p{P}\s]+$") || System.Text.RegularExpressions.Regex.IsMatch(inputText2, @"^[0-9\p{P}\s,]+$") || System.Text.RegularExpressions.Regex.IsMatch(inputText3, @"^[0-9\p{P}\s]+$") || !System.Text.RegularExpressions.Regex.IsMatch(inputText4, @"^\d+$") || System.Text.RegularExpressions.Regex.IsMatch(inputText5, @"^[0-9\p{P}\s]+$") || !System.Text.RegularExpressions.Regex.IsMatch(inputText7, @"^\d+$"))
                    {
                        MessageBox.Show("Por favor ingrese datos válidos.");
                    }
                    if (inputText.Contains(",") || inputText2.Contains(",") || inputText5.Contains(",") || inputText7.Contains(","))
                    {
                        MessageBox.Show("El contenido no puede tener comas ','");
                    }
                    else if (!string.IsNullOrWhiteSpace(escribirNombreProducto.Text) && !string.IsNullOrWhiteSpace(escribirDescProducto.Text) && !string.IsNullOrWhiteSpace(escribirStockProducto.Text) && !string.IsNullOrWhiteSpace(escribirMarcaProducto.Text) && cbbCatgProducto.SelectedItem != null && cbbEstadoProducto.SelectedItem != null && !string.IsNullOrWhiteSpace(escribirPrecioProducto.Text))
                    {
                        if (MessageBox.Show("¿Está seguro de querer editar la fila seleccionada?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            foreach (DataGridViewRow row in DGV_inventarioProductos.SelectedRows)
                            {
                                DataGridViewRow editardatos = DGV_inventarioProductos.Rows[row.Index];
                                int indicefila = row.Index;
                                editardatos.Cells[1].Value = escribirNombreProducto.Text;
                                editardatos.Cells[2].Value = cbbEstadoProducto.SelectedItem;
                                editardatos.Cells[3].Value = escribirDescProducto.Text;
                                editardatos.Cells[4].Value = escribirStockProducto.Text;
                                editardatos.Cells[5].Value = cbbCatgProducto.SelectedItem;
                                editardatos.Cells[6].Value = escribirMarcaProducto.Text;
                                editardatos.Cells[7].Value = escribirPrecioProducto.Text;

                                Productos producto = new Productos
                                {
                                    id_productos = indicefila +1 + eliminados,
                                    nombre_productos = escribirNombreProducto.Text,
                                    estado_productos = cbbEstadoProducto.SelectedItem.ToString(),
                                    descripcion_productos = escribirDescProducto.Text,
                                    stock_productos = Convert.ToInt32(escribirStockProducto.Text),
                                    categoria_productos = cbbCatgProducto.SelectedItem.ToString(),
                                    marca_productos = escribirMarcaProducto.Text,
                                    precio_productos = Convert.ToInt32(escribirPrecioProducto.Text)
                                };
                                ListaProductos.RemoveAt(indicefila);
                                ListaProductos.Insert(indicefila, producto);

                                escribirNombreProducto.Text = "";
                                escribirDescProducto.Text = "";
                                cbbCatgProducto.SelectedItem = null;
                                escribirStockProducto.Text = "";
                                escribirMarcaProducto.Text = "";
                                cbbEstadoProducto.SelectedItem = null;
                                escribirPrecioProducto.Text = "";
                                DGV_inventarioProductos.ClearSelection();
                                

                            }
                            GuardarProductosEnCsv();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Los campos no pueden estar vacío.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila para editar.");
                }
            }
        }

        private void cbbEstadoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public bool ValidarCsv(string filePath, out List<string> errores, List<Productos> listaProductos)
        {

            errores = new List<string>();

            if (!File.Exists(filePath))
            {
                errores.Add("El archivo no existe.");
                return false;
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string linea;
                int numeroLinea = 0;

                while ((linea = reader.ReadLine()) != null)
                {
                    numeroLinea++;
                    var columnas = linea.Split(',');

                    if (columnas.Length != 7)
                    {
                        errores.Add($"La línea {numeroLinea} no tiene el número correcto de columnas.");
                        continue;
                    }
                    if (columnas[1] != "Disponible" && columnas[1] != "No Disponible")
                    {
                        errores.Add($"La línea {numeroLinea} tiene un estado de producto inválido.");
                    }
                    if (columnas[4] != "Ninguna")
                    {
                        errores.Add($"La línea {numeroLinea} debe tener 'Ninguna' como categoría.");
                    }
                    if (!int.TryParse(columnas[3], out int stock) || stock < 0)
                    {
                        errores.Add($"El stock en la línea {numeroLinea} debe ser un número entero natural (0 o positivo).");
                        continue;
                    }
                    if (!double.TryParse(columnas[6], out double precio) || precio < 0)
                    {
                        errores.Add($"El precio en la línea {numeroLinea} debe ser un número decimal natural (0 o positivo).");
                        continue;
                    }

                    var producto = new Productos();
                    producto.id_productos = ID_Producto++;
                    producto.nombre_productos = columnas[0];
                    producto.estado_productos = columnas[1];
                    producto.descripcion_productos = columnas[2];
                    producto.stock_productos = stock;
                    producto.categoria_productos = columnas[4];
                    producto.marca_productos = columnas[5];
                    producto.precio_productos = precio;

                    listaProductos.Add(producto);
                    GuardarProductosEnCsv();

                }
            }

            return !errores.Any();
        }

        private void btnImportarProductos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer importar datos?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "C:\\";
                    openFileDialog.Filter = "CSV files (.csv)|.csv|All files (.)|.";
                    openFileDialog.Title = "Selecciona un archivo CSV";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                        if (Path.GetExtension(filePath).ToLower() != ".csv")
                        {
                            MessageBox.Show("Por favor, selecciona un archivo con extensión .csv.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (ValidarCsv(filePath, out List<string> errores, ListaProductos))
                        {
                            MessageBox.Show("El archivo CSV es válido y los productos han sido importados.");
                            ActualizarDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Errores encontrados:\n" + string.Join("\n", errores));
                        }
                    }
                }
            }
        }

        private void ActualizarDataGridView()
        {
            DGV_inventarioProductos.Rows.Clear();
            foreach (var producto in ListaProductos)
            {
                DGV_inventarioProductos.Rows.Add(producto.id_productos, producto.nombre_productos, producto.estado_productos, producto.descripcion_productos, producto.stock_productos, producto.categoria_productos, producto.marca_productos, producto.precio_productos);
            }
        }
        private void escribirPrecioProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuardarProductosEnCsv()
        {

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "importarCSV", "listaProductos.csv");
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var producto in ListaProductos)
                    {
                        string linea = $"{producto.id_productos},{producto.nombre_productos},{producto.estado_productos},{producto.descripcion_productos},{producto.stock_productos},{producto.categoria_productos},{producto.marca_productos},{producto.precio_productos}";
                        writer.WriteLine(linea);
                    }
                }
        }

        private void CargarProductosDesdeCsv()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "importarCSV", "listaProductos.csv");
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        var columnas = linea.Split(',');
                        if (columnas.Length == 8) 
                        {
                            
                            var producto = new Productos
                            {
                                id_productos = int.Parse(columnas[0]),
                                nombre_productos = columnas[1],
                                estado_productos = columnas[2],
                                descripcion_productos = columnas[3],
                                stock_productos = int.Parse(columnas[4]),
                                categoria_productos = columnas[5],
                                marca_productos = columnas[6],
                                precio_productos = double.Parse(columnas[7])

                            };
                            ListaProductos.Add(producto);
                            ID_Producto = int.Parse(columnas[0])+1;
                        }
                    }
                }
            }
        }

        private void escribirBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            string textoBusqueda = escribirBusqueda.Text.ToLower();
            bool esNumerico = int.TryParse(textoBusqueda, out _);
            DGV_inventarioProductos.DataSource = null;
            DGV_inventarioProductos.Columns.Clear();

            var listaFiltrada = ListaProductos.Where(
                obj => (esNumerico && obj.id_productos.ToString().ToLower().Contains(textoBusqueda)) ||
                       (!esNumerico && (
                           obj.nombre_productos.ToLower().Contains(textoBusqueda) ||
                           obj.categoria_productos.ToLower().Contains(textoBusqueda) ||
                           obj.marca_productos.ToLower().Contains(textoBusqueda)
                       ))
            ).ToList();
            DGV_inventarioProductos.DataSource = listaFiltrada;
            DGV_inventarioProductos.ReadOnly = true;
            DGV_inventarioProductos.Columns[8].Visible = false;
            DGV_inventarioProductos.Columns[0].Width = 45;
            DGV_inventarioProductos.Columns[1].Width = 226;
            DGV_inventarioProductos.Columns[2].Width = 95;
            DGV_inventarioProductos.Columns[3].Width = 213;
            DGV_inventarioProductos.Columns[4].Width = 52;
            DGV_inventarioProductos.Columns[5].Width = 186;
            DGV_inventarioProductos.Columns[6].Width = 114;
            DGV_inventarioProductos.Columns[7].Width = 66;
        }

       
        private void GuardarContador()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "importarCSV", "eliminaciones.txt");
            File.WriteAllText(filePath, eliminados.ToString());
        }

        private void CargarContador()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "importarCSV", "eliminaciones.txt");

            if (File.Exists(filePath))
            {
                string contenido = File.ReadAllText(filePath);
                if (int.TryParse(contenido, out int valorRecuperado))
                {
                    eliminados = valorRecuperado;
                }
                else
                {
                    MessageBox.Show("Error al leer el valor del contador.");
                }
            }
        }

        private void DGV_inventarioProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var filaSeleccionada = DGV_inventarioProductos.Rows[e.RowIndex];

                escribirNombreProducto.Text = filaSeleccionada.Cells[1].Value.ToString();
                cbbEstadoProducto.SelectedItem = filaSeleccionada.Cells[2].Value?.ToString();
                escribirDescProducto.Text = filaSeleccionada.Cells[3].Value.ToString();
                escribirStockProducto.Text = filaSeleccionada.Cells[4].Value.ToString();
                cbbCatgProducto.SelectedItem = filaSeleccionada.Cells[5].Value.ToString();
                escribirMarcaProducto.Text = filaSeleccionada.Cells[6].Value.ToString();
                escribirPrecioProducto.Text = filaSeleccionada.Cells[7].Value.ToString();
 
            }
        }

        private void escribirBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void escribirMarcaProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void escribirStockProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
