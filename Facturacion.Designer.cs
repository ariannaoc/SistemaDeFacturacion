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
            this.botonRectanguloRedondo1 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
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
            this.botonRectanguloRedondo1.Location = new System.Drawing.Point(20, 135);
            this.botonRectanguloRedondo1.Name = "botonRectanguloRedondo1";
            this.botonRectanguloRedondo1.Size = new System.Drawing.Size(345, 158);
            this.botonRectanguloRedondo1.TabIndex = 0;
            this.botonRectanguloRedondo1.Text = "botonRectanguloRedondo1";
            this.botonRectanguloRedondo1.TextColor = System.Drawing.Color.White;
            this.botonRectanguloRedondo1.UseVisualStyleBackColor = false;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.botonRectanguloRedondo1);
            this.Name = "Facturacion";
            this.Size = new System.Drawing.Size(1551, 978);
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private BotonesCustomizados.botonRectanguloRedondo botonRectanguloRedondo1;
    }
}
