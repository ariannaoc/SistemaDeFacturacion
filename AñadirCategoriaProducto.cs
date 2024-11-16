using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parcial2_SistemaDeFacturacion
{
    public partial class AñadirCatgProducto : UserControl
    {

        private static AñadirCatgProducto instance;
        public AñadirCatgProducto()
        {
            
            InitializeComponent();
            CargarCategoriasDesdeCsv();
            ActualizarDataGridViewCategorias();
            toolTipbtnEditarCatg.SetToolTip(btnEditarCategoria, "Para editar una Categoria, seleccione una fila rellene el campo con \nlos datos nuevos y presione este botón");
            toolTipbtnAñadirCatg.SetToolTip(btnAgregarCategoria, "Para añadir una Categoria, rellene el campo con \nlos datos solicitados y presione este botón");
            toolTipbtnEliminarCatg.SetToolTip(btnEliminarCategoria, "Para eliminar una Categoria, seleccione una fila y presione este botón");
        }

        public static AñadirCatgProducto Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AñadirCatgProducto();
                }
                return instance;
            }
        }

        private void AñadirCatgProducto_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            string inputText = escribirNombreCategoria.Text.Trim();

            if (System.Text.RegularExpressions.Regex.IsMatch(inputText, @"^[0-9\p{P}\s]+$"))
            {
                MessageBox.Show("Por favor ingrese un nombre válido.");
                escribirNombreCategoria.Text = "";
            }
            if (inputText.Contains(","))
            {
                MessageBox.Show("El contenido no puede tener comas ','");
            }
            else if (!string.IsNullOrWhiteSpace(escribirNombreCategoria.Text))
            {
                //var palabrasMinusculas = ListaCategoriasGlobal.ListaCategorias.Select(palabra => palabra.ToLower()).ToList();

                if (!ListasGlobales.ListaCategorias.Contains(escribirNombreCategoria.Text.ToLower()))
                {
                    int cantfilas = DGV_categoriasExistentes.Rows.Add();
                    DGV_categoriasExistentes.Rows[cantfilas].Cells[0].Value = escribirNombreCategoria.Text;
                    ListasGlobales.ListaCategorias.Add(escribirNombreCategoria.Text);
                    GuardarCategoriasEnCsv();
                    escribirNombreCategoria.Text = "";
                    DGV_categoriasExistentes.ClearSelection();
                }
                else
                {
                    MessageBox.Show("El elemento ya existe en la lista.");
                }
            }
            else
            {
                MessageBox.Show("El campo 'Nueva Categoría' no puede estar vacío.");
            }


        }

        private void categoriasExistentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void categoriasExistentes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void categoriasExistentes_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (DGV_categoriasExistentes.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de querer eliminar la fila seleccionada?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in DGV_categoriasExistentes.SelectedRows)
                    {
                        int indicefila = row.Index;
                        DGV_categoriasExistentes.Rows.RemoveAt(row.Index);
                        DGV_categoriasExistentes.ClearSelection();
                        ListasGlobales.ListaCategorias.RemoveAt(indicefila);
                    }
                    GuardarCategoriasEnCsv();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una fila para eliminar.");
            }
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        { 
            string inputText = escribirNombreCategoria.Text.Trim();
            if (DGV_categoriasExistentes.SelectedRows.Count > 0)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(inputText, @"^[0-9\p{P}\s]+$"))
                {
                    MessageBox.Show("Por favor ingrese un nombre válido.");
                    escribirNombreCategoria.Text = "";
                }
                if (inputText.Contains(","))
                {
                    MessageBox.Show("El contenido no puede tener comas ','");
                }
                else if (!string.IsNullOrWhiteSpace(escribirNombreCategoria.Text))
                {
                    foreach (DataGridViewRow row in DGV_categoriasExistentes.SelectedRows)
                    {
                        int indicefila = row.Index;
                        DataGridViewRow editardatos = DGV_categoriasExistentes.Rows[row.Index];
                        editardatos.Cells[0].Value = escribirNombreCategoria.Text;

                        var categoria = new BindingList<string>();
                        categoria.Add(escribirNombreCategoria.Text);

                        ListasGlobales.ListaCategorias.RemoveAt(indicefila);
                        ListasGlobales.ListaCategorias.Insert(indicefila, categoria.ToString());

                        escribirNombreCategoria.Text = "";
                        DGV_categoriasExistentes.ClearSelection();
                    }
                    GuardarCategoriasEnCsv();
                }
                else
                {
                    MessageBox.Show("El campo no puede estar vacío.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para editar.");
            }
        }

        private void GuardarCategoriasEnCsv()
        {

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "importarCSV", "listaCategorias.csv");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var categoria in ListasGlobales.ListaCategorias)
                {
                    if (categoria != "Ninguna")
                    {
                        string linea = $"{categoria}";
                        writer.WriteLine(linea);
                    }
                }
            }
        }

        public void CargarCategoriasDesdeCsv()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "importarCSV", "listaCategorias.csv");

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string categoria = linea.Trim();
                        if (!string.IsNullOrEmpty(categoria))
                        {
                            ListasGlobales.ListaCategorias.Add(categoria);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El archivo de categorías no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarDataGridViewCategorias()
        {
            DGV_categoriasExistentes.Rows.Clear();

            foreach (var categoria in ListasGlobales.ListaCategorias)
            {
                DGV_categoriasExistentes.Rows.Add(categoria);
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
