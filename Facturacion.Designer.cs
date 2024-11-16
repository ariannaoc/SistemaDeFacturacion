namespace Parcial2_SistemaDeFacturacion
{
    partial class Facturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.botonRectanguloRedondo1 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroDoc = new System.Windows.Forms.Label();
            this.lblRealizarVenta = new System.Windows.Forms.Label();
            this.btnAnadirCliente = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.roundedPanel1 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.RoundedPanel();
            this.btnAnadirProducto = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.panelTotales = new System.Windows.Forms.Panel();
            this.leerCliente = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.ReadOnlyRichTextBox();
            this.leerSubTotal = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.ReadOnlyRichTextBox();
            this.dataGridViewMostrarProductos = new System.Windows.Forms.DataGridView();
            this.FinishSellButton = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.btnCancelarCompra = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.lblnDoc = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.roundedPanel1.SuspendLayout();
            this.panelTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // botonRectanguloRedondo1
            // 
            this.botonRectanguloRedondo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonRectanguloRedondo1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botonRectanguloRedondo1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.botonRectanguloRedondo1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonRectanguloRedondo1.BorderRadius = 0;
            this.botonRectanguloRedondo1.BorderSize = 0;
            this.botonRectanguloRedondo1.FlatAppearance.BorderSize = 0;
            this.botonRectanguloRedondo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRectanguloRedondo1.ForeColor = System.Drawing.Color.White;
            this.botonRectanguloRedondo1.Location = new System.Drawing.Point(7714, 800);
            this.botonRectanguloRedondo1.Name = "botonRectanguloRedondo1";
            this.botonRectanguloRedondo1.Size = new System.Drawing.Size(345, 158);
            this.botonRectanguloRedondo1.TabIndex = 0;
            this.botonRectanguloRedondo1.Text = "botonRectanguloRedondo1";
            this.botonRectanguloRedondo1.TextColor = System.Drawing.Color.White;
            this.botonRectanguloRedondo1.UseVisualStyleBackColor = false;
            this.botonRectanguloRedondo1.Click += new System.EventHandler(this.botonRectanguloRedondo1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(468, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fecha de Documento";
            // 
            // lblNumeroDoc
            // 
            this.lblNumeroDoc.AutoSize = true;
            this.lblNumeroDoc.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDoc.ForeColor = System.Drawing.Color.Black;
            this.lblNumeroDoc.Location = new System.Drawing.Point(37, 96);
            this.lblNumeroDoc.Name = "lblNumeroDoc";
            this.lblNumeroDoc.Size = new System.Drawing.Size(232, 22);
            this.lblNumeroDoc.TabIndex = 14;
            this.lblNumeroDoc.Text = "Número de Documento ";
            // 
            // lblRealizarVenta
            // 
            this.lblRealizarVenta.AutoSize = true;
            this.lblRealizarVenta.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealizarVenta.ForeColor = System.Drawing.Color.Black;
            this.lblRealizarVenta.Location = new System.Drawing.Point(36, 18);
            this.lblRealizarVenta.Name = "lblRealizarVenta";
            this.lblRealizarVenta.Size = new System.Drawing.Size(232, 29);
            this.lblRealizarVenta.TabIndex = 13;
            this.lblRealizarVenta.Text = "Realizar una Venta";
            // 
            // btnAnadirCliente
            // 
            this.btnAnadirCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnAnadirCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnAnadirCliente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAnadirCliente.BorderRadius = 11;
            this.btnAnadirCliente.BorderSize = 0;
            this.btnAnadirCliente.FlatAppearance.BorderSize = 0;
            this.btnAnadirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirCliente.Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirCliente.ForeColor = System.Drawing.Color.White;
            this.btnAnadirCliente.Location = new System.Drawing.Point(4, 5);
            this.btnAnadirCliente.Name = "btnAnadirCliente";
            this.btnAnadirCliente.Size = new System.Drawing.Size(160, 43);
            this.btnAnadirCliente.TabIndex = 0;
            this.btnAnadirCliente.Text = "Añadir Cliente  +";
            this.btnAnadirCliente.TextColor = System.Drawing.Color.White;
            this.btnAnadirCliente.UseVisualStyleBackColor = false;
            this.btnAnadirCliente.Click += new System.EventHandler(this.btnAnadirCliente_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(185)))));
            this.roundedPanel1.BorderRadius = 11;
            this.roundedPanel1.BorderSize = 2;
            this.roundedPanel1.Controls.Add(this.btnAnadirProducto);
            this.roundedPanel1.Controls.Add(this.btnAnadirCliente);
            this.roundedPanel1.Location = new System.Drawing.Point(6, 170);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(764, 54);
            this.roundedPanel1.TabIndex = 12;
            // 
            // btnAnadirProducto
            // 
            this.btnAnadirProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnAnadirProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnAnadirProducto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAnadirProducto.BorderRadius = 11;
            this.btnAnadirProducto.BorderSize = 0;
            this.btnAnadirProducto.FlatAppearance.BorderSize = 0;
            this.btnAnadirProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirProducto.Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirProducto.ForeColor = System.Drawing.Color.White;
            this.btnAnadirProducto.Location = new System.Drawing.Point(598, 5);
            this.btnAnadirProducto.Name = "btnAnadirProducto";
            this.btnAnadirProducto.Size = new System.Drawing.Size(160, 43);
            this.btnAnadirProducto.TabIndex = 1;
            this.btnAnadirProducto.Text = "Añadir Producto";
            this.btnAnadirProducto.TextColor = System.Drawing.Color.White;
            this.btnAnadirProducto.UseVisualStyleBackColor = false;
            this.btnAnadirProducto.Click += new System.EventHandler(this.btnAnadirProducto_Click);
            // 
            // panelTotales
            // 
            this.panelTotales.BackColor = System.Drawing.Color.White;
            this.panelTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotales.Controls.Add(this.leerCliente);
            this.panelTotales.Controls.Add(this.leerSubTotal);
            this.panelTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(185)))));
            this.panelTotales.Location = new System.Drawing.Point(10, 482);
            this.panelTotales.Name = "panelTotales";
            this.panelTotales.Size = new System.Drawing.Size(760, 209);
            this.panelTotales.TabIndex = 16;
            // 
            // leerCliente
            // 
            this.leerCliente.BackColor = System.Drawing.Color.White;
            this.leerCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leerCliente.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leerCliente.ForeColor = System.Drawing.Color.Black;
            this.leerCliente.Location = new System.Drawing.Point(12, 14);
            this.leerCliente.Name = "leerCliente";
            this.leerCliente.Size = new System.Drawing.Size(494, 41);
            this.leerCliente.TabIndex = 0;
            this.leerCliente.Text = "";
            this.leerCliente.TextChanged += new System.EventHandler(this.leerCliente_TextChanged);
            // 
            // leerSubTotal
            // 
            this.leerSubTotal.BackColor = System.Drawing.Color.White;
            this.leerSubTotal.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leerSubTotal.ForeColor = System.Drawing.Color.Black;
            this.leerSubTotal.Location = new System.Drawing.Point(-1, 88);
            this.leerSubTotal.Name = "leerSubTotal";
            this.leerSubTotal.Size = new System.Drawing.Size(760, 120);
            this.leerSubTotal.TabIndex = 21;
            this.leerSubTotal.Text = "";
            this.leerSubTotal.TextChanged += new System.EventHandler(this.leerSubTotal_TextChanged);
            // 
            // dataGridViewMostrarProductos
            // 
            this.dataGridViewMostrarProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMostrarProductos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMostrarProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMostrarProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(185)))));
            this.dataGridViewMostrarProductos.Location = new System.Drawing.Point(10, 241);
            this.dataGridViewMostrarProductos.Name = "dataGridViewMostrarProductos";
            this.dataGridViewMostrarProductos.Size = new System.Drawing.Size(760, 214);
            this.dataGridViewMostrarProductos.TabIndex = 18;
            this.dataGridViewMostrarProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMostrarProductos_CellContentClick);
            // 
            // FinishSellButton
            // 
            this.FinishSellButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(78)))));
            this.FinishSellButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(78)))));
            this.FinishSellButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.FinishSellButton.BorderRadius = 11;
            this.FinishSellButton.BorderSize = 0;
            this.FinishSellButton.FlatAppearance.BorderSize = 0;
            this.FinishSellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishSellButton.ForeColor = System.Drawing.Color.White;
            this.FinishSellButton.Location = new System.Drawing.Point(620, 711);
            this.FinishSellButton.Name = "FinishSellButton";
            this.FinishSellButton.Size = new System.Drawing.Size(150, 57);
            this.FinishSellButton.TabIndex = 22;
            this.FinishSellButton.Text = "Finalizar Compra";
            this.FinishSellButton.TextColor = System.Drawing.Color.White;
            this.FinishSellButton.UseVisualStyleBackColor = false;
            this.FinishSellButton.Click += new System.EventHandler(this.FinishSellButton_Click_1);
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.BackColor = System.Drawing.Color.Red;
            this.btnCancelarCompra.BackgroundColor = System.Drawing.Color.Red;
            this.btnCancelarCompra.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelarCompra.BorderRadius = 11;
            this.btnCancelarCompra.BorderSize = 0;
            this.btnCancelarCompra.FlatAppearance.BorderSize = 0;
            this.btnCancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCompra.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCompra.Location = new System.Drawing.Point(440, 711);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(150, 57);
            this.btnCancelarCompra.TabIndex = 23;
            this.btnCancelarCompra.Text = "Cancelar";
            this.btnCancelarCompra.TextColor = System.Drawing.Color.White;
            this.btnCancelarCompra.UseVisualStyleBackColor = false;
            this.btnCancelarCompra.Click += new System.EventHandler(this.btnCancelarCompra_Click);
            // 
            // lblnDoc
            // 
            this.lblnDoc.AutoSize = true;
            this.lblnDoc.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(229)))));
            this.lblnDoc.Location = new System.Drawing.Point(89, 134);
            this.lblnDoc.Name = "lblnDoc";
            this.lblnDoc.Size = new System.Drawing.Size(0, 19);
            this.lblnDoc.TabIndex = 24;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(144)))), ((int)(((byte)(229)))));
            this.lblFecha.Location = new System.Drawing.Point(519, 132);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 19);
            this.lblFecha.TabIndex = 25;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblnDoc);
            this.Controls.Add(this.btnCancelarCompra);
            this.Controls.Add(this.FinishSellButton);
            this.Controls.Add(this.dataGridViewMostrarProductos);
            this.Controls.Add(this.panelTotales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumeroDoc);
            this.Controls.Add(this.lblRealizarVenta);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.botonRectanguloRedondo1);
            this.Name = "Facturacion";
            this.Size = new System.Drawing.Size(738, 679);
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.panelTotales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BotonesCustomizados.botonRectanguloRedondo botonRectanguloRedondo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroDoc;
        private System.Windows.Forms.Label lblRealizarVenta;
        private BotonesCustomizados.botonRectanguloRedondo btnAnadirCliente;
        private BotonesCustomizados.RoundedPanel roundedPanel1;
        private BotonesCustomizados.botonRectanguloRedondo btnAnadirProducto;
        private System.Windows.Forms.Panel panelTotales;
        private BotonesCustomizados.ReadOnlyRichTextBox leerCliente;
        private BotonesCustomizados.ReadOnlyRichTextBox leerSubTotal;
        private BotonesCustomizados.botonRectanguloRedondo FinishSellButton;
        private BotonesCustomizados.botonRectanguloRedondo btnCancelarCompra;
        public System.Windows.Forms.DataGridView dataGridViewMostrarProductos;
        private System.Windows.Forms.Label lblnDoc;
        private System.Windows.Forms.Label lblFecha;
    }
}
