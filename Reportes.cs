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
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Parcial2_SistemaDeFacturacion
{
    public partial class Reportes : BaseActualizarPanel
    {
        private static Reportes _instance;
        private static readonly object _lock = new object();
        private BindingList<InvoiceInfo> bindingList = new BindingList<InvoiceInfo>(); // Use BindingList for automatic updates

        public Reportes()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridViewFacturas.AutoGenerateColumns = false;
            dataGridViewFacturas.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewFacturas.Columns.Add(new DataGridViewTextBoxColumn { Name = "NumeroDocumento", HeaderText = "Numero de Documento", DataPropertyName = "DocumentNumber" });
            dataGridViewFacturas.Columns.Add(new DataGridViewTextBoxColumn { Name = "FilePath", HeaderText = "Ruta del Archivo", DataPropertyName = "FilePath" });

            // Add button column to open PDF
            var openButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Open",
                HeaderText = "Abrir",
                Text = "Abrir",
                UseColumnTextForButtonValue = true
            };
            dataGridViewFacturas.Columns.Add(openButtonColumn);

            dataGridViewFacturas.DataSource = bindingList; // Set data source
            dataGridViewFacturas.CellContentClick += dataGridViewFacturas_CellContentClick;
        }

        public static Reportes Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Reportes();
                    }
                    return _instance;
                }
            }
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // Load the initial data if needed
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for text changed event if needed
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string documentNumber = txtBusqueda.Text.Trim();
            LoadInvoices(documentNumber);
        }

        private void LoadInvoices(string documentNumber)
        {
            bindingList.Clear();

            string jsonFilePath = @"..\..\JSONS\invoices.json";

            if (File.Exists(jsonFilePath))
            {
                var jsonData = File.ReadAllText(jsonFilePath);
                var invoices = JsonConvert.DeserializeObject<List<InvoiceInfo>>(jsonData);

                if (invoices != null)
                {
                    if (string.IsNullOrEmpty(documentNumber))
                    {
                        foreach (var invoice in invoices)
                        {
                            bindingList.Add(invoice);
                        }
                    }
                    else
                    {
                        var filteredInvoices = invoices.Where(i => i.DocumentNumber.Contains(documentNumber)).ToList();
                        foreach (var invoice in filteredInvoices)
                        {
                            bindingList.Add(invoice);
                        }
                    }

                    MessageBox.Show(bindingList.Any() ? "Factura(s) encontrada(s)!" : "Factura no encontrada.", "Resultados de Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudieron cargar las facturas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El archivo invoices.json no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewFacturas.Columns[e.ColumnIndex].Name == "Open")
            {
                var invoice = bindingList[e.RowIndex];
                if (File.Exists(invoice.FilePath))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = invoice.FilePath,
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("El archivo PDF no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
