using System.Diagnostics;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using System;

namespace Parcial2_SistemaDeFacturacion
{
    public class GenerarPDF
    {
        public void generarPDF(Cliente selectedClient, BindingList<Productos> productList, string documentNumber, double subtotal, double total, double ivaTotal, double igtfTotal)
        {
            // Definicion del path para salvar el PDF
            string pdfFolderPath = @"..\..\Facturas";
            string pdfFileName = $"{documentNumber}.pdf";
            string pdfFilePath = Path.Combine(pdfFolderPath, pdfFileName);

            // Asegurarnos que el directorio existe
            Directory.CreateDirectory(pdfFolderPath);
            Console.WriteLine($"El PDF sera salvado en: {pdfFilePath}");

            // Genera y guarda del PDF
            Document.Create(document =>
            {
                document.Page(page =>
                {
                    page.Margin(30);

                    page.Header().ShowOnce().Row(row =>
                    {
                        row.ConstantItem(140).Height(60).Placeholder(); // Add store image

                        row.RelativeItem().Column(col =>
                        {
                            col.Item().AlignCenter().Text("La Tiendita").Bold().FontSize(14);
                            col.Item().AlignCenter().Text("Campo Claro N378 - Venezuela").FontSize(9);
                            col.Item().AlignCenter().Text("04127490917 / 04148399901").FontSize(9);
                            col.Item().AlignCenter().Text("latiendita@prueba.com").FontSize(9);
                        });

                        row.RelativeItem().Column(col =>
                        {
                            col.Item().Border(1).BorderColor("#121221")
                            .AlignCenter().Text(DateTime.Now.ToString("dd/MM/yyyy")); // anade fecha actual

                            col.Item().Background("#121221").Border(1)
                            .BorderColor("#121221").AlignCenter()
                            .Text("Boleta de venta").FontColor("#fff");

                            col.Item().Border(1).BorderColor("#121221")
                            .AlignCenter().Text(documentNumber); // anade numero de documento
                        });
                    });

                    page.Content().PaddingVertical(10).Column(col1 =>
                    {
                        col1.Item().Column(col2 =>
                        {
                            col2.Item().Text("Datos del cliente").Underline().Bold();

                            col2.Item().Text(txt =>
                            {
                                txt.Span("Nombre: ").SemiBold().FontSize(10);
                                txt.Span(selectedClient.Nombres).FontSize(10); // Nombre del selectedClient
                            });

                            col2.Item().Text(txt =>
                            {
                                txt.Span("Cedula: ").SemiBold().FontSize(10);
                                txt.Span(selectedClient.ID).FontSize(10); // ID del selectedClient
                            });

                            col2.Item().Text(txt =>
                            {
                                txt.Span("Direccion: ").SemiBold().FontSize(10);
                                txt.Span($"{selectedClient.Direccion.Calle}, {selectedClient.Direccion.Ciudad}, {selectedClient.Direccion.Estado}").FontSize(10); // Direccion del selectedClient
                            });

                            col2.Item().Text(txt =>
                            {
                                txt.Span("Telefono: ").SemiBold().FontSize(10);
                                txt.Span(selectedClient.NumeroTelefono).FontSize(10); // Telefono del selectedClient
                            });

                            col2.Item().Text(txt =>
                            {
                                txt.Span("Email: ").SemiBold().FontSize(10);
                                txt.Span(selectedClient.Email).FontSize(10); // Email del selectedClient
                            });
                        });

                        col1.Item().LineHorizontal(0.5f);

                        col1.Item().Table(tabla =>
                        {
                            tabla.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                            });

                            tabla.Header(header =>
                            {
                                header.Cell().Background("#121221")
                                .Padding(2).Text("Producto").FontColor("#fff");

                                header.Cell().Background("#121221")
                                .Padding(2).Text("Cantidad").FontColor("#fff");

                                header.Cell().Background("#121221")
                                .Padding(2).Text("SubTotal").FontColor("#fff");
                            });

                            foreach (DataGridViewRow row in Facturacion.Instance.dataGridViewMostrarProductos.Rows)
                            {
                                if (row.Cells["Precio"].Value != null)
                                {
                                    double price = Convert.ToDouble(row.Cells["Precio"].Value.ToString().Replace("$", "").Replace(",", "").Trim());
                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(row.Cells["Nombre"].Value.ToString()).FontSize(10);
                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(row.Cells["Cantidad"].Value.ToString()).FontSize(10);
                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text($"S/. {price}").FontSize(10);
                                }
                            }
                        });

                        col1.Item().AlignRight().Text($"SubTotal:  {subtotal}").Bold().FontSize(12);
                        col1.Item().AlignRight().Text($"SubTotal:  {ivaTotal}").Bold().FontSize(12);
                        col1.Item().AlignRight().Text($"igtfTotal: {igtfTotal}").Bold().FontSize(12);
                        col1.Item().AlignRight().Text($"Total:     {total}").Bold().FontSize(14);

                        col1.Spacing(10);
                    });

                    page.Footer().AlignRight().Text(txt =>
                    {
                        txt.Span("Pagina ").FontSize(10);
                        txt.CurrentPageNumber().FontSize(10);
                        txt.Span(" de ").FontSize(10);
                        txt.TotalPages().FontSize(10);
                    });
                });
            }).GeneratePdf(pdfFilePath);

            // Verifica que el pdf se salva
            if (File.Exists(pdfFilePath))
            {
                Console.WriteLine($"PDF fue guardado exitosamente en: {pdfFilePath}");
                // abre el PDF guarado usando el  PDF viewer por defecto
                Process.Start(new ProcessStartInfo
                {
                    FileName = pdfFilePath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Error: El PDF no fue salvado correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error: El PDF no fue salvado correctamente.");
            }
        }
    }
}

