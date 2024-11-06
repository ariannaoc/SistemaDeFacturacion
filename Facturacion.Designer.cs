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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.botonRectanguloRedondo1.Location = new System.Drawing.Point(0, 357);
            this.botonRectanguloRedondo1.Name = "botonRectanguloRedondo1";
            this.botonRectanguloRedondo1.Size = new System.Drawing.Size(345, 158);
            this.botonRectanguloRedondo1.TabIndex = 0;
            this.botonRectanguloRedondo1.Text = "botonRectanguloRedondo1";
            this.botonRectanguloRedondo1.TextColor = System.Drawing.Color.White;
            this.botonRectanguloRedondo1.UseVisualStyleBackColor = false;
            this.botonRectanguloRedondo1.Click += new System.EventHandler(this.botonRectanguloRedondo1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 148);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1381, 830);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 148);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonRectanguloRedondo1);
            this.Name = "Facturacion";
            this.Size = new System.Drawing.Size(1551, 978);
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private BotonesCustomizados.botonRectanguloRedondo botonRectanguloRedondo1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
