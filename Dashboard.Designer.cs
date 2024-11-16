namespace Parcial2_SistemaDeFacturacion
{
    partial class Dashboard
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
            this.roundedPanel1 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.RoundedPanel();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblVentasTotales = new System.Windows.Forms.Label();
            this.btnDashboardVenta = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.roundedPanel2 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHola = new System.Windows.Forms.Label();
            this.roundedPanel3 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.RoundedPanel();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 3;
            this.roundedPanel1.Controls.Add(this.lblVentas);
            this.roundedPanel1.Controls.Add(this.lblVentasTotales);
            this.roundedPanel1.Location = new System.Drawing.Point(327, 118);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(372, 189);
            this.roundedPanel1.TabIndex = 0;
            this.roundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Helvetica", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.Black;
            this.lblVentas.Location = new System.Drawing.Point(15, 31);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(346, 45);
            this.lblVentas.TabIndex = 1;
            this.lblVentas.Text = "VENTAS TOTALES";
            // 
            // lblVentasTotales
            // 
            this.lblVentasTotales.AutoSize = true;
            this.lblVentasTotales.Font = new System.Drawing.Font("Helvetica Compressed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasTotales.ForeColor = System.Drawing.Color.Black;
            this.lblVentasTotales.Location = new System.Drawing.Point(135, 90);
            this.lblVentasTotales.Name = "lblVentasTotales";
            this.lblVentasTotales.Size = new System.Drawing.Size(182, 79);
            this.lblVentasTotales.TabIndex = 0;
            this.lblVentasTotales.Text = "label1";
            this.lblVentasTotales.Click += new System.EventHandler(this.lblVentasTotales_Click);
            // 
            // btnDashboardVenta
            // 
            this.btnDashboardVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(167)))), ((int)(((byte)(36)))));
            this.btnDashboardVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(167)))), ((int)(((byte)(36)))));
            this.btnDashboardVenta.BorderColor = System.Drawing.Color.Black;
            this.btnDashboardVenta.BorderRadius = 20;
            this.btnDashboardVenta.BorderSize = 2;
            this.btnDashboardVenta.FlatAppearance.BorderSize = 0;
            this.btnDashboardVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardVenta.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardVenta.ForeColor = System.Drawing.Color.Black;
            this.btnDashboardVenta.Location = new System.Drawing.Point(29, 118);
            this.btnDashboardVenta.Name = "btnDashboardVenta";
            this.btnDashboardVenta.Size = new System.Drawing.Size(273, 139);
            this.btnDashboardVenta.TabIndex = 1;
            this.btnDashboardVenta.Text = "INICIAR UNA VENTA";
            this.btnDashboardVenta.TextColor = System.Drawing.Color.Black;
            this.btnDashboardVenta.UseVisualStyleBackColor = false;
            this.btnDashboardVenta.Click += new System.EventHandler(this.botonRectanguloRedondo1_Click);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(185)))));
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.BorderSize = 3;
            this.roundedPanel2.Controls.Add(this.lblHola);
            this.roundedPanel2.Location = new System.Drawing.Point(29, 32);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(670, 67);
            this.roundedPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Actual:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Helvetica", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(51, 73);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(152, 57);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "fecha";
            // 
            // lblHola
            // 
            this.lblHola.AutoSize = true;
            this.lblHola.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHola.ForeColor = System.Drawing.Color.Black;
            this.lblHola.Location = new System.Drawing.Point(17, 16);
            this.lblHola.Name = "lblHola";
            this.lblHola.Size = new System.Drawing.Size(386, 29);
            this.lblHola.TabIndex = 1;
            this.lblHola.Text = "¡Hola! ¿Qué quieres hacer hoy?";
            this.lblHola.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.White;
            this.roundedPanel3.BorderColor = System.Drawing.Color.Red;
            this.roundedPanel3.BorderRadius = 20;
            this.roundedPanel3.BorderSize = 3;
            this.roundedPanel3.Controls.Add(this.label1);
            this.roundedPanel3.Controls.Add(this.lblFecha);
            this.roundedPanel3.Location = new System.Drawing.Point(29, 332);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(285, 189);
            this.roundedPanel3.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.btnDashboardVenta);
            this.Controls.Add(this.roundedPanel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(721, 645);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BotonesCustomizados.RoundedPanel roundedPanel1;
        private BotonesCustomizados.botonRectanguloRedondo btnDashboardVenta;
        private System.Windows.Forms.Label lblVentasTotales;
        private System.Windows.Forms.Label lblVentas;
        private BotonesCustomizados.RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label lblHola;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
        private BotonesCustomizados.RoundedPanel roundedPanel3;
    }
}
