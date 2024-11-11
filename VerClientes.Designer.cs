namespace Parcial2_SistemaDeFacturacion
{
    partial class VerClientes
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
            this.dataGridViewClientes1 = new System.Windows.Forms.DataGridView();
            this.btnAgregarCliente = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.roundedPanel1 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.RoundedPanel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes1)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewClientes1
            // 
            this.dataGridViewClientes1.AllowUserToAddRows = false;
            this.dataGridViewClientes1.AllowUserToDeleteRows = false;
            this.dataGridViewClientes1.AllowUserToResizeColumns = false;
            this.dataGridViewClientes1.AllowUserToResizeRows = false;
            this.dataGridViewClientes1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClientes1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewClientes1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes1.Location = new System.Drawing.Point(51, 148);
            this.dataGridViewClientes1.Name = "dataGridViewClientes1";
            this.dataGridViewClientes1.Size = new System.Drawing.Size(645, 313);
            this.dataGridViewClientes1.TabIndex = 0;
            this.dataGridViewClientes1.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridViewClientes1_CellValueNeeded);
            this.dataGridViewClientes1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridViewClientes1_Scroll);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregarCliente.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregarCliente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarCliente.BorderRadius = 0;
            this.btnAgregarCliente.BorderSize = 0;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Location = new System.Drawing.Point(546, 87);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(150, 40);
            this.btnAgregarCliente.TabIndex = 1;
            this.btnAgregarCliente.Text = "Agregar Cliente +";
            this.btnAgregarCliente.TextColor = System.Drawing.Color.White;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.botonRectanguloRedondo1_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundedPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.txtBusqueda);
            this.roundedPanel1.Location = new System.Drawing.Point(51, 88);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.roundedPanel1.Size = new System.Drawing.Size(423, 39);
            this.roundedPanel1.TabIndex = 2;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBusqueda.Location = new System.Drawing.Point(10, 10);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(403, 20);
            this.txtBusqueda.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Red;
            this.btnBuscar.Location = new System.Drawing.Point(457, 59);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // VerClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.dataGridViewClientes1);
            this.Name = "VerClientes";
            this.Size = new System.Drawing.Size(844, 486);
            this.Load += new System.EventHandler(this.VerClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes1)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BotonesCustomizados.botonRectanguloRedondo btnAgregarCliente;
        public System.Windows.Forms.DataGridView dataGridViewClientes1;
        private BotonesCustomizados.RoundedPanel roundedPanel1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
    }
}
