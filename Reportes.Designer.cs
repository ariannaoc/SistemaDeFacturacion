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
            this.ReporteLabel = new System.Windows.Forms.Label();
            this.TablaReporte = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TablaReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteLabel
            // 
            this.ReporteLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReporteLabel.AutoSize = true;
            this.ReporteLabel.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteLabel.ForeColor = System.Drawing.Color.Black;
            this.ReporteLabel.Location = new System.Drawing.Point(373, 116);
            this.ReporteLabel.Name = "ReporteLabel";
            this.ReporteLabel.Size = new System.Drawing.Size(302, 40);
            this.ReporteLabel.TabIndex = 0;
            this.ReporteLabel.Text = "Reporte de Ventas";
            // 
            // TablaReporte
            // 
            this.TablaReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaReporte.BackgroundColor = System.Drawing.Color.White;
            this.TablaReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaReporte.Location = new System.Drawing.Point(115, 237);
            this.TablaReporte.Name = "TablaReporte";
            this.TablaReporte.RowHeadersWidth = 51;
            this.TablaReporte.RowTemplate.Height = 24;
            this.TablaReporte.Size = new System.Drawing.Size(810, 223);
            this.TablaReporte.TabIndex = 1;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TablaReporte);
            this.Controls.Add(this.ReporteLabel);
            this.Name = "Reportes";
            this.Size = new System.Drawing.Size(1020, 642);
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReporteLabel;
        private System.Windows.Forms.DataGridView TablaReporte;
    }
}
