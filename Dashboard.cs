using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace Parcial2_SistemaDeFacturacion
{
    public partial class Dashboard : BaseActualizarPanel
    {
        private static Dashboard _instance;
        private static readonly object _lock = new object();
        private const string DocumentNumberFilePath = @"../../JSONS/numeroDeFactura.json";
        public Dashboard()
        {
            InitializeComponent();
            string lastDocumentNumber = GetLastDocumentNumberFromJson();
            int lastNumber = int.Parse(lastDocumentNumber.Substring(3));
            lblFecha.Text = DateTime.Now.ToString("dd/mm//yy");

            lblVentasTotales.Text = $"{lastNumber:D2}";
            UpdateSalesLabel();
        }

        public static Dashboard Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Dashboard();
                    }
                    return _instance;
                }
            }
        }

        private void UpdateSalesLabel()
        {
            List<InvoiceInfo> recentSales = GetSalesInLastWeek();
            int totalSales = recentSales.Sum(i => i.VentasMeses);

            //lblmeses.Text = $"{totalSales}";
            
        }

        public List<InvoiceInfo> GetSalesInLastWeek()
        {
            string jsonFilePath = @"..\..\JSONS\invoices.json";

            if (File.Exists(jsonFilePath))
            {
                try
                {
                    var jsonData = File.ReadAllText(jsonFilePath);
                    var invoices = JsonConvert.DeserializeObject<List<InvoiceInfo>>(jsonData) ?? new List<InvoiceInfo>();

                    // Filter invoices from the last week  
                    var oneWeekAgo = DateTime.Now.AddDays(-7);
                    var recentSales = invoices.Where(i => i.Date >= oneWeekAgo).ToList();

                    return recentSales;
                }
                catch (Exception ex)
                {
                    // Log the exception (this could be to a file, database, etc.)
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            return new List<InvoiceInfo>();
        }


        private void btnDashboardVenta_Click(object sender, EventArgs e)
        {
            

        }

        private void botonRectanguloRedondo1_Click(object sender, EventArgs e)
        {
            Facturacion facturacion = Facturacion.Instance; 
            //MessageBox.Show("Facturacion instance created.", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            ActualizarPanelPrincipal(facturacion); 
                                                   
                       
           //MessageBox.Show("ActualizarPanelPrincipal called.", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information); //debugging, no me salia

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void lblVentasTotales_Click(object sender, EventArgs e)
        {
           
        }

        private string GetLastDocumentNumberFromJson()
        {
            if (!File.Exists(DocumentNumberFilePath))
            {
                return "doc0000"; // Default starting number if the file doesn't exist
            }

            var jsonData = File.ReadAllText(DocumentNumberFilePath);
            var jsonObj = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonData);

            if (jsonObj != null && jsonObj.ContainsKey("lastDocumentNumber"))
            {
                return jsonObj["lastDocumentNumber"];
            }

            return "doc0000"; // Default starting number if the key doesn't exist
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
