namespace Parcial2_SistemaDeFacturacion
{
    partial class Inventario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DGV_inventarioProductos = new System.Windows.Forms.DataGridView();
            this.DTV_idProductoInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTV_nombreProductoInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTV_estadoProductoInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTV_descripcionProductoInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTV_stockProductoInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTV_categoriaProductoInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTV_marcaProductoInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTV_precioProductoInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escribirMarcaProducto = new System.Windows.Forms.TextBox();
            this.escribirStockProducto = new System.Windows.Forms.TextBox();
            this.escribirDescProducto = new System.Windows.Forms.TextBox();
            this.escribirNombreProducto = new System.Windows.Forms.TextBox();
            this.cbbCatgProducto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTipbtnEditarPrdt = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipbtnAgregarPrdt = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipbtnEliminarPrdt = new System.Windows.Forms.ToolTip(this.components);
            this.cbbEstadoProducto = new System.Windows.Forms.ComboBox();
            this.escribirPrecioProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTipbtnImportar = new System.Windows.Forms.ToolTip(this.components);
            this.readOnlyRichTextBox2 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.ReadOnlyRichTextBox();
            this.readOnlyRichTextBox1 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.ReadOnlyRichTextBox();
            this.btnEliminarProducto = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.btnEditarProducto = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.lblMarca = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.ReadOnlyRichTextBox();
            this.lblStock = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.ReadOnlyRichTextBox();
            this.lblCategoria = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.ReadOnlyRichTextBox();
            this.lblDescripcion = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.ReadOnlyRichTextBox();
            this.lblProducto = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.ReadOnlyRichTextBox();
            this.btnGuardarProducto = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.roundedPanel2 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.RoundedPanel();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.escribirBusqueda = new System.Windows.Forms.TextBox();
            this.btnExportarProductos = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.btnImportarProductos = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.btnProductosArchivados = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.btnProductosActivos = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.btnTodosLosProductos = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_inventarioProductos)).BeginInit();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(95, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(134, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "PRODUCTO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(281, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "ESTADO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(419, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "DESCRIPCIÓN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(540, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "STOCK";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(638, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "CATEGORÍA";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(759, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "MARCA";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(41, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 34);
            this.label10.TabIndex = 13;
            this.label10.Text = "Productos";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // DGV_inventarioProductos
            // 
            this.DGV_inventarioProductos.AllowUserToAddRows = false;
            this.DGV_inventarioProductos.AllowUserToDeleteRows = false;
            this.DGV_inventarioProductos.AllowUserToResizeColumns = false;
            this.DGV_inventarioProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.DGV_inventarioProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_inventarioProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_inventarioProductos.BackgroundColor = System.Drawing.Color.White;
            this.DGV_inventarioProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_inventarioProductos.ColumnHeadersVisible = false;
            this.DGV_inventarioProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DTV_idProductoInv,
            this.DTV_nombreProductoInv,
            this.DTV_estadoProductoInv,
            this.DTV_descripcionProductoInv,
            this.DTV_stockProductoInv,
            this.DTV_categoriaProductoInv,
            this.DTV_marcaProductoInv,
            this.DTV_precioProductoInv});
            this.DGV_inventarioProductos.Location = new System.Drawing.Point(81, 481);
            this.DGV_inventarioProductos.MultiSelect = false;
            this.DGV_inventarioProductos.Name = "DGV_inventarioProductos";
            this.DGV_inventarioProductos.RowHeadersVisible = false;
            this.DGV_inventarioProductos.RowHeadersWidth = 51;
            this.DGV_inventarioProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_inventarioProductos.Size = new System.Drawing.Size(836, 315);
            this.DGV_inventarioProductos.TabIndex = 36;
            this.DGV_inventarioProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_inventarioProductos_CellClick);
            this.DGV_inventarioProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_inventarioProductos_CellContentClick);
            // 
            // DTV_idProductoInv
            // 
            this.DTV_idProductoInv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DTV_idProductoInv.FillWeight = 45.9533F;
            this.DTV_idProductoInv.HeaderText = "ID";
            this.DTV_idProductoInv.MinimumWidth = 6;
            this.DTV_idProductoInv.Name = "DTV_idProductoInv";
            this.DTV_idProductoInv.ReadOnly = true;
            this.DTV_idProductoInv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DTV_nombreProductoInv
            // 
            this.DTV_nombreProductoInv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DTV_nombreProductoInv.FillWeight = 232.2337F;
            this.DTV_nombreProductoInv.HeaderText = "PRODUCTO";
            this.DTV_nombreProductoInv.MinimumWidth = 6;
            this.DTV_nombreProductoInv.Name = "DTV_nombreProductoInv";
            this.DTV_nombreProductoInv.ReadOnly = true;
            this.DTV_nombreProductoInv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DTV_estadoProductoInv
            // 
            this.DTV_estadoProductoInv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DTV_estadoProductoInv.FillWeight = 96.91159F;
            this.DTV_estadoProductoInv.HeaderText = "ESTADO";
            this.DTV_estadoProductoInv.MinimumWidth = 6;
            this.DTV_estadoProductoInv.Name = "DTV_estadoProductoInv";
            this.DTV_estadoProductoInv.ReadOnly = true;
            this.DTV_estadoProductoInv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DTV_descripcionProductoInv
            // 
            this.DTV_descripcionProductoInv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DTV_descripcionProductoInv.FillWeight = 217.7967F;
            this.DTV_descripcionProductoInv.HeaderText = "DESCRIPCIÓN";
            this.DTV_descripcionProductoInv.MinimumWidth = 6;
            this.DTV_descripcionProductoInv.Name = "DTV_descripcionProductoInv";
            this.DTV_descripcionProductoInv.ReadOnly = true;
            this.DTV_descripcionProductoInv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DTV_stockProductoInv
            // 
            this.DTV_stockProductoInv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DTV_stockProductoInv.FillWeight = 53.39976F;
            this.DTV_stockProductoInv.HeaderText = "STOCK";
            this.DTV_stockProductoInv.MinimumWidth = 6;
            this.DTV_stockProductoInv.Name = "DTV_stockProductoInv";
            this.DTV_stockProductoInv.ReadOnly = true;
            this.DTV_stockProductoInv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DTV_categoriaProductoInv
            // 
            this.DTV_categoriaProductoInv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DTV_categoriaProductoInv.FillWeight = 190.6421F;
            this.DTV_categoriaProductoInv.HeaderText = "CATEGORIA";
            this.DTV_categoriaProductoInv.MinimumWidth = 6;
            this.DTV_categoriaProductoInv.Name = "DTV_categoriaProductoInv";
            this.DTV_categoriaProductoInv.ReadOnly = true;
            this.DTV_categoriaProductoInv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DTV_marcaProductoInv
            // 
            this.DTV_marcaProductoInv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DTV_marcaProductoInv.FillWeight = 117.4376F;
            this.DTV_marcaProductoInv.HeaderText = "MARCA";
            this.DTV_marcaProductoInv.MinimumWidth = 6;
            this.DTV_marcaProductoInv.Name = "DTV_marcaProductoInv";
            this.DTV_marcaProductoInv.ReadOnly = true;
            this.DTV_marcaProductoInv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DTV_precioProductoInv
            // 
            this.DTV_precioProductoInv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DTV_precioProductoInv.FillWeight = 67.42864F;
            this.DTV_precioProductoInv.HeaderText = "PRECIO";
            this.DTV_precioProductoInv.MinimumWidth = 6;
            this.DTV_precioProductoInv.Name = "DTV_precioProductoInv";
            this.DTV_precioProductoInv.ReadOnly = true;
            this.DTV_precioProductoInv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // escribirMarcaProducto
            // 
            this.escribirMarcaProducto.BackColor = System.Drawing.Color.LightGray;
            this.escribirMarcaProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.escribirMarcaProducto.ForeColor = System.Drawing.Color.Black;
            this.escribirMarcaProducto.Location = new System.Drawing.Point(494, 297);
            this.escribirMarcaProducto.Name = "escribirMarcaProducto";
            this.escribirMarcaProducto.Size = new System.Drawing.Size(177, 20);
            this.escribirMarcaProducto.TabIndex = 77;
            this.escribirMarcaProducto.TextChanged += new System.EventHandler(this.escribirMarcaProducto_TextChanged);
            // 
            // escribirStockProducto
            // 
            this.escribirStockProducto.BackColor = System.Drawing.Color.LightGray;
            this.escribirStockProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.escribirStockProducto.ForeColor = System.Drawing.Color.Black;
            this.escribirStockProducto.Location = new System.Drawing.Point(494, 254);
            this.escribirStockProducto.Name = "escribirStockProducto";
            this.escribirStockProducto.Size = new System.Drawing.Size(177, 20);
            this.escribirStockProducto.TabIndex = 76;
            this.escribirStockProducto.TextChanged += new System.EventHandler(this.escribirStockProducto_TextChanged);
            // 
            // escribirDescProducto
            // 
            this.escribirDescProducto.BackColor = System.Drawing.Color.LightGray;
            this.escribirDescProducto.Location = new System.Drawing.Point(175, 292);
            this.escribirDescProducto.Multiline = true;
            this.escribirDescProducto.Name = "escribirDescProducto";
            this.escribirDescProducto.Size = new System.Drawing.Size(176, 75);
            this.escribirDescProducto.TabIndex = 75;
            this.escribirDescProducto.TextChanged += new System.EventHandler(this.escribirDescProducto_TextChanged);
            // 
            // escribirNombreProducto
            // 
            this.escribirNombreProducto.BackColor = System.Drawing.Color.LightGray;
            this.escribirNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.escribirNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.escribirNombreProducto.Location = new System.Drawing.Point(175, 254);
            this.escribirNombreProducto.Name = "escribirNombreProducto";
            this.escribirNombreProducto.Size = new System.Drawing.Size(177, 20);
            this.escribirNombreProducto.TabIndex = 74;
            this.escribirNombreProducto.TextChanged += new System.EventHandler(this.escribirNombreProducto_TextChanged);
            // 
            // cbbCatgProducto
            // 
            this.cbbCatgProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCatgProducto.FormattingEnabled = true;
            this.cbbCatgProducto.Location = new System.Drawing.Point(175, 392);
            this.cbbCatgProducto.Name = "cbbCatgProducto";
            this.cbbCatgProducto.Size = new System.Drawing.Size(176, 21);
            this.cbbCatgProducto.TabIndex = 73;
            this.cbbCatgProducto.SelectedIndexChanged += new System.EventHandler(this.cbbCatgProducto_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(75, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 24);
            this.label11.TabIndex = 78;
            this.label11.Text = "Nuevo Producto";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cbbEstadoProducto
            // 
            this.cbbEstadoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstadoProducto.FormattingEnabled = true;
            this.cbbEstadoProducto.Location = new System.Drawing.Point(494, 346);
            this.cbbEstadoProducto.Name = "cbbEstadoProducto";
            this.cbbEstadoProducto.Size = new System.Drawing.Size(176, 21);
            this.cbbEstadoProducto.TabIndex = 81;
            this.cbbEstadoProducto.SelectedIndexChanged += new System.EventHandler(this.cbbEstadoProducto_SelectedIndexChanged);
            // 
            // escribirPrecioProducto
            // 
            this.escribirPrecioProducto.BackColor = System.Drawing.Color.LightGray;
            this.escribirPrecioProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.escribirPrecioProducto.Location = new System.Drawing.Point(494, 392);
            this.escribirPrecioProducto.Name = "escribirPrecioProducto";
            this.escribirPrecioProducto.Size = new System.Drawing.Size(177, 20);
            this.escribirPrecioProducto.TabIndex = 85;
            this.escribirPrecioProducto.TextChanged += new System.EventHandler(this.escribirPrecioProducto_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(944, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 14);
            this.label8.TabIndex = 86;
            this.label8.Text = "PRECIO";
            // 
            // readOnlyRichTextBox2
            // 
            this.readOnlyRichTextBox2.BackColor = System.Drawing.Color.White;
            this.readOnlyRichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyRichTextBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyRichTextBox2.ForeColor = System.Drawing.Color.Black;
            this.readOnlyRichTextBox2.Location = new System.Drawing.Point(382, 392);
            this.readOnlyRichTextBox2.Name = "readOnlyRichTextBox2";
            this.readOnlyRichTextBox2.Size = new System.Drawing.Size(101, 19);
            this.readOnlyRichTextBox2.TabIndex = 84;
            this.readOnlyRichTextBox2.Text = "Precio x Und:";
            // 
            // readOnlyRichTextBox1
            // 
            this.readOnlyRichTextBox1.BackColor = System.Drawing.Color.White;
            this.readOnlyRichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyRichTextBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyRichTextBox1.ForeColor = System.Drawing.Color.Black;
            this.readOnlyRichTextBox1.Location = new System.Drawing.Point(382, 346);
            this.readOnlyRichTextBox1.Name = "readOnlyRichTextBox1";
            this.readOnlyRichTextBox1.Size = new System.Drawing.Size(83, 19);
            this.readOnlyRichTextBox1.TabIndex = 82;
            this.readOnlyRichTextBox1.Text = "Estado:";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarProducto.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnEliminarProducto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminarProducto.BorderRadius = 8;
            this.btnEliminarProducto.BorderSize = 0;
            this.btnEliminarProducto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarProducto.Location = new System.Drawing.Point(685, 358);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(121, 48);
            this.btnEliminarProducto.TabIndex = 80;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.TextColor = System.Drawing.Color.Black;
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditarProducto.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditarProducto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditarProducto.BorderRadius = 8;
            this.btnEditarProducto.BorderSize = 0;
            this.btnEditarProducto.FlatAppearance.BorderSize = 0;
            this.btnEditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnEditarProducto.Location = new System.Drawing.Point(685, 306);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(121, 46);
            this.btnEditarProducto.TabIndex = 79;
            this.btnEditarProducto.Text = "Editar";
            this.btnEditarProducto.TextColor = System.Drawing.Color.Black;
            this.btnEditarProducto.UseVisualStyleBackColor = false;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.BackColor = System.Drawing.Color.White;
            this.lblMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMarca.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.Black;
            this.lblMarca.Location = new System.Drawing.Point(382, 297);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(66, 19);
            this.lblMarca.TabIndex = 72;
            this.lblMarca.Text = "Marca:";
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.Color.White;
            this.lblStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblStock.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.Black;
            this.lblStock.Location = new System.Drawing.Point(382, 256);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(50, 19);
            this.lblStock.TabIndex = 71;
            this.lblStock.Text = "Stock:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.Color.White;
            this.lblCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(47, 392);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(106, 19);
            this.lblCategoria.TabIndex = 70;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BackColor = System.Drawing.Color.White;
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(47, 297);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(112, 19);
            this.lblDescripcion.TabIndex = 69;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblProducto
            // 
            this.lblProducto.BackColor = System.Drawing.Color.White;
            this.lblProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblProducto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.Black;
            this.lblProducto.Location = new System.Drawing.Point(75, 255);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(84, 19);
            this.lblProducto.TabIndex = 68;
            this.lblProducto.Text = "Nombre:";
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(78)))));
            this.btnGuardarProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(78)))));
            this.btnGuardarProducto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarProducto.BorderRadius = 8;
            this.btnGuardarProducto.BorderSize = 0;
            this.btnGuardarProducto.FlatAppearance.BorderSize = 0;
            this.btnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarProducto.Location = new System.Drawing.Point(685, 256);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(121, 45);
            this.btnGuardarProducto.TabIndex = 66;
            this.btnGuardarProducto.Text = "Agregar";
            this.btnGuardarProducto.TextColor = System.Drawing.Color.Black;
            this.btnGuardarProducto.UseVisualStyleBackColor = false;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(185)))));
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.BorderSize = 2;
            this.roundedPanel2.Controls.Add(this.label9);
            this.roundedPanel2.Controls.Add(this.label8);
            this.roundedPanel2.Controls.Add(this.pbBuscar);
            this.roundedPanel2.Controls.Add(this.escribirBusqueda);
            this.roundedPanel2.Controls.Add(this.btnExportarProductos);
            this.roundedPanel2.Controls.Add(this.btnImportarProductos);
            this.roundedPanel2.Controls.Add(this.btnProductosArchivados);
            this.roundedPanel2.Controls.Add(this.btnProductosActivos);
            this.roundedPanel2.Controls.Add(this.btnTodosLosProductos);
            this.roundedPanel2.Controls.Add(this.label2);
            this.roundedPanel2.Controls.Add(this.label3);
            this.roundedPanel2.Controls.Add(this.label4);
            this.roundedPanel2.Controls.Add(this.label5);
            this.roundedPanel2.Controls.Add(this.label6);
            this.roundedPanel2.Controls.Add(this.label7);
            this.roundedPanel2.ForeColor = System.Drawing.Color.Black;
            this.roundedPanel2.Location = new System.Drawing.Point(22, 93);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(935, 762);
            this.roundedPanel2.TabIndex = 3;
            this.roundedPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel2_Paint);
            // 
            // pbBuscar
            // 
            this.pbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscar.Image")));
            this.pbBuscar.Location = new System.Drawing.Point(617, 19);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(26, 27);
            this.pbBuscar.TabIndex = 10;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
            // 
            // escribirBusqueda
            // 
            this.escribirBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.escribirBusqueda.Location = new System.Drawing.Point(204, 22);
            this.escribirBusqueda.Multiline = true;
            this.escribirBusqueda.Name = "escribirBusqueda";
            this.escribirBusqueda.Size = new System.Drawing.Size(399, 24);
            this.escribirBusqueda.TabIndex = 9;
            this.escribirBusqueda.TextChanged += new System.EventHandler(this.escribirBusqueda_TextChanged);
            this.escribirBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.escribirBusqueda_KeyPress);
            // 
            // btnExportarProductos
            // 
            this.btnExportarProductos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExportarProductos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnExportarProductos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExportarProductos.BorderRadius = 8;
            this.btnExportarProductos.BorderSize = 0;
            this.btnExportarProductos.FlatAppearance.BorderSize = 0;
            this.btnExportarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarProductos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarProductos.ForeColor = System.Drawing.Color.Black;
            this.btnExportarProductos.Location = new System.Drawing.Point(763, 11);
            this.btnExportarProductos.Name = "btnExportarProductos";
            this.btnExportarProductos.Size = new System.Drawing.Size(104, 40);
            this.btnExportarProductos.TabIndex = 8;
            this.btnExportarProductos.Text = "Exportar";
            this.btnExportarProductos.TextColor = System.Drawing.Color.Black;
            this.btnExportarProductos.UseVisualStyleBackColor = false;
            this.btnExportarProductos.Click += new System.EventHandler(this.btnExportarProductos_Click);
            // 
            // btnImportarProductos
            // 
            this.btnImportarProductos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnImportarProductos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnImportarProductos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnImportarProductos.BorderRadius = 8;
            this.btnImportarProductos.BorderSize = 0;
            this.btnImportarProductos.FlatAppearance.BorderSize = 0;
            this.btnImportarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarProductos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarProductos.ForeColor = System.Drawing.Color.Black;
            this.btnImportarProductos.Location = new System.Drawing.Point(652, 11);
            this.btnImportarProductos.Name = "btnImportarProductos";
            this.btnImportarProductos.Size = new System.Drawing.Size(104, 40);
            this.btnImportarProductos.TabIndex = 7;
            this.btnImportarProductos.Text = "Importar";
            this.btnImportarProductos.TextColor = System.Drawing.Color.Black;
            this.btnImportarProductos.UseVisualStyleBackColor = false;
            this.btnImportarProductos.Click += new System.EventHandler(this.btnImportarProductos_Click);
            // 
            // btnProductosArchivados
            // 
            this.btnProductosArchivados.BackColor = System.Drawing.Color.White;
            this.btnProductosArchivados.BackgroundColor = System.Drawing.Color.White;
            this.btnProductosArchivados.BorderColor = System.Drawing.Color.White;
            this.btnProductosArchivados.BorderRadius = 8;
            this.btnProductosArchivados.BorderSize = 1;
            this.btnProductosArchivados.FlatAppearance.BorderSize = 0;
            this.btnProductosArchivados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosArchivados.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosArchivados.ForeColor = System.Drawing.Color.Black;
            this.btnProductosArchivados.Location = new System.Drawing.Point(127, 15);
            this.btnProductosArchivados.Name = "btnProductosArchivados";
            this.btnProductosArchivados.Size = new System.Drawing.Size(71, 34);
            this.btnProductosArchivados.TabIndex = 6;
            this.btnProductosArchivados.Text = "Archivado";
            this.btnProductosArchivados.TextColor = System.Drawing.Color.Black;
            this.btnProductosArchivados.UseVisualStyleBackColor = false;
            this.btnProductosArchivados.Click += new System.EventHandler(this.btn_archProductos_Click);
            // 
            // btnProductosActivos
            // 
            this.btnProductosActivos.BackColor = System.Drawing.Color.White;
            this.btnProductosActivos.BackgroundColor = System.Drawing.Color.White;
            this.btnProductosActivos.BorderColor = System.Drawing.Color.White;
            this.btnProductosActivos.BorderRadius = 8;
            this.btnProductosActivos.BorderSize = 1;
            this.btnProductosActivos.FlatAppearance.BorderSize = 0;
            this.btnProductosActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosActivos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosActivos.ForeColor = System.Drawing.Color.Black;
            this.btnProductosActivos.Location = new System.Drawing.Point(66, 15);
            this.btnProductosActivos.Name = "btnProductosActivos";
            this.btnProductosActivos.Size = new System.Drawing.Size(55, 34);
            this.btnProductosActivos.TabIndex = 5;
            this.btnProductosActivos.Text = "Activo";
            this.btnProductosActivos.TextColor = System.Drawing.Color.Black;
            this.btnProductosActivos.UseVisualStyleBackColor = false;
            this.btnProductosActivos.Click += new System.EventHandler(this.btn_actProductos_Click);
            // 
            // btnTodosLosProductos
            // 
            this.btnTodosLosProductos.BackColor = System.Drawing.Color.White;
            this.btnTodosLosProductos.BackgroundColor = System.Drawing.Color.White;
            this.btnTodosLosProductos.BorderColor = System.Drawing.Color.White;
            this.btnTodosLosProductos.BorderRadius = 8;
            this.btnTodosLosProductos.BorderSize = 1;
            this.btnTodosLosProductos.FlatAppearance.BorderSize = 0;
            this.btnTodosLosProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosLosProductos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosLosProductos.ForeColor = System.Drawing.Color.Black;
            this.btnTodosLosProductos.Location = new System.Drawing.Point(18, 15);
            this.btnTodosLosProductos.Name = "btnTodosLosProductos";
            this.btnTodosLosProductos.Size = new System.Drawing.Size(42, 34);
            this.btnTodosLosProductos.TabIndex = 4;
            this.btnTodosLosProductos.Text = "Todo";
            this.btnTodosLosProductos.TextColor = System.Drawing.Color.Black;
            this.btnTodosLosProductos.UseVisualStyleBackColor = false;
            this.btnTodosLosProductos.Click += new System.EventHandler(this.btnTodosProductos_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(847, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 14);
            this.label9.TabIndex = 87;
            this.label9.Text = "PRECIO";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.escribirPrecioProducto);
            this.Controls.Add(this.readOnlyRichTextBox2);
            this.Controls.Add(this.readOnlyRichTextBox1);
            this.Controls.Add(this.cbbEstadoProducto);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.escribirMarcaProducto);
            this.Controls.Add(this.escribirStockProducto);
            this.Controls.Add(this.escribirDescProducto);
            this.Controls.Add(this.escribirNombreProducto);
            this.Controls.Add(this.cbbCatgProducto);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.DGV_inventarioProductos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundedPanel2);
            this.Name = "Inventario";
            this.Size = new System.Drawing.Size(1551, 978);
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_inventarioProductos)).EndInit();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BotonesCustomizados.RoundedPanel roundedPanel2;
        private BotonesCustomizados.botonRectanguloRedondo btnTodosLosProductos;
        private BotonesCustomizados.botonRectanguloRedondo btnProductosArchivados;
        private BotonesCustomizados.botonRectanguloRedondo btnProductosActivos;
        private BotonesCustomizados.botonRectanguloRedondo btnImportarProductos;
        private BotonesCustomizados.botonRectanguloRedondo btnExportarProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DGV_inventarioProductos;
        private System.Windows.Forms.TextBox escribirMarcaProducto;
        private System.Windows.Forms.TextBox escribirStockProducto;
        private System.Windows.Forms.TextBox escribirDescProducto;
        private System.Windows.Forms.TextBox escribirNombreProducto;
        private System.Windows.Forms.ComboBox cbbCatgProducto;
        private BotonesCustomizados.ReadOnlyRichTextBox lblMarca;
        private BotonesCustomizados.ReadOnlyRichTextBox lblStock;
        private BotonesCustomizados.ReadOnlyRichTextBox lblCategoria;
        private BotonesCustomizados.ReadOnlyRichTextBox lblDescripcion;
        private BotonesCustomizados.ReadOnlyRichTextBox lblProducto;
        private BotonesCustomizados.botonRectanguloRedondo btnGuardarProducto;
        private System.Windows.Forms.Label label11;
        private BotonesCustomizados.botonRectanguloRedondo btnEditarProducto;
        private BotonesCustomizados.botonRectanguloRedondo btnEliminarProducto;
        private System.Windows.Forms.ToolTip toolTipbtnEditarPrdt;
        private System.Windows.Forms.ToolTip toolTipbtnAgregarPrdt;
        private System.Windows.Forms.ToolTip toolTipbtnEliminarPrdt;
        private System.Windows.Forms.ComboBox cbbEstadoProducto;
        private BotonesCustomizados.ReadOnlyRichTextBox readOnlyRichTextBox1;
        private BotonesCustomizados.ReadOnlyRichTextBox readOnlyRichTextBox2;
        private System.Windows.Forms.TextBox escribirPrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTV_idProductoInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTV_nombreProductoInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTV_estadoProductoInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTV_descripcionProductoInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTV_stockProductoInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTV_categoriaProductoInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTV_marcaProductoInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTV_precioProductoInv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTipbtnImportar;
        private System.Windows.Forms.TextBox escribirBusqueda;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.Label label9;
    }
}
