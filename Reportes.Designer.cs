namespace Parcial2_SistemaDeFacturacion
{
    partial class Reportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.roundedPanel1 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.RoundedPanel();
            this.dataGridViewFacturas = new System.Windows.Forms.DataGridView();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBusqueda.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(10, 10);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(544, 15);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Red;
            this.btnBuscar.Location = new System.Drawing.Point(603, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 43);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(185)))));
            this.roundedPanel1.BorderRadius = 8;
            this.roundedPanel1.BorderSize = 2;
            this.roundedPanel1.Controls.Add(this.txtBusqueda);
            this.roundedPanel1.Location = new System.Drawing.Point(33, 51);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.roundedPanel1.Size = new System.Drawing.Size(564, 39);
            this.roundedPanel1.TabIndex = 6;
            // 
            // dataGridViewFacturas
            // 
            this.dataGridViewFacturas.AllowUserToAddRows = false;
            this.dataGridViewFacturas.AllowUserToDeleteRows = false;
            this.dataGridViewFacturas.AllowUserToResizeColumns = false;
            this.dataGridViewFacturas.AllowUserToResizeRows = false;
            this.dataGridViewFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewFacturas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFacturas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewFacturas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(185)))));
            this.dataGridViewFacturas.Location = new System.Drawing.Point(33, 111);
            this.dataGridViewFacturas.Name = "dataGridViewFacturas";
            this.dataGridViewFacturas.Size = new System.Drawing.Size(645, 313);
            this.dataGridViewFacturas.TabIndex = 4;
            this.dataGridViewFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFacturas_CellContentClick);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.dataGridViewFacturas);
            this.Name = "Reportes";
            this.Size = new System.Drawing.Size(721, 662);
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private BotonesCustomizados.RoundedPanel roundedPanel1;
        public System.Windows.Forms.DataGridView dataGridViewFacturas;
    }
}
