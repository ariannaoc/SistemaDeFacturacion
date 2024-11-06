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
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.RoundedPanel();
            this.readOnlyRichTextBox1 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.ReadOnlyRichTextBox();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOLA A TODOS";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.readOnlyRichTextBox1);
            this.roundedPanel1.Location = new System.Drawing.Point(405, 896);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.roundedPanel1.Size = new System.Drawing.Size(179, 221);
            this.roundedPanel1.TabIndex = 1;
            // 
            // readOnlyRichTextBox1
            // 
            this.readOnlyRichTextBox1.BackColor = System.Drawing.Color.White;
            this.readOnlyRichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readOnlyRichTextBox1.Location = new System.Drawing.Point(12, 9);
            this.readOnlyRichTextBox1.Name = "readOnlyRichTextBox1";
            this.readOnlyRichTextBox1.Size = new System.Drawing.Size(155, 203);
            this.readOnlyRichTextBox1.TabIndex = 0;
            this.readOnlyRichTextBox1.Text = "hola aqui hay una prueba\npara que puedan usar esto en\nel resto del codigo\n";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.Name = "Inventario";
            this.Size = new System.Drawing.Size(1551, 978);
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BotonesCustomizados.RoundedPanel roundedPanel1;
        private BotonesCustomizados.ReadOnlyRichTextBox readOnlyRichTextBox1;
    }
}
