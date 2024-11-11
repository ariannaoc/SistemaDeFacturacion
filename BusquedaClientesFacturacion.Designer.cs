namespace Parcial2_SistemaDeFacturacion
{
    partial class BusquedaClientesFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundedPanel1 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.RoundedPanel();
            this.btnAnadir = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.dataGridViewClientes2 = new System.Windows.Forms.DataGridView();
            this.roundedPanel2 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.RoundedPanel();
            this.btnBusqueda = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes2)).BeginInit();
            this.roundedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.AutoScroll = true;
            this.roundedPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundedPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.btnAnadir);
            this.roundedPanel1.Controls.Add(this.dataGridViewClientes2);
            this.roundedPanel1.Controls.Add(this.roundedPanel2);
            this.roundedPanel1.Location = new System.Drawing.Point(97, 53);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(640, 588);
            this.roundedPanel1.TabIndex = 0;
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAnadir.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAnadir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAnadir.BorderRadius = 0;
            this.btnAnadir.BorderSize = 0;
            this.btnAnadir.FlatAppearance.BorderSize = 0;
            this.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadir.ForeColor = System.Drawing.Color.White;
            this.btnAnadir.Location = new System.Drawing.Point(447, 516);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(150, 40);
            this.btnAnadir.TabIndex = 2;
            this.btnAnadir.Text = "anadir cliente";
            this.btnAnadir.TextColor = System.Drawing.Color.White;
            this.btnAnadir.UseVisualStyleBackColor = false;
            // 
            // dataGridViewClientes2
            // 
            this.dataGridViewClientes2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClientes2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes2.Location = new System.Drawing.Point(58, 91);
            this.dataGridViewClientes2.Name = "dataGridViewClientes2";
            this.dataGridViewClientes2.Size = new System.Drawing.Size(514, 237);
            this.dataGridViewClientes2.TabIndex = 1;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.BorderSize = 0;
            this.roundedPanel2.Controls.Add(this.btnBusqueda);
            this.roundedPanel2.Controls.Add(this.txtBusqueda);
            this.roundedPanel2.Location = new System.Drawing.Point(58, 18);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(514, 43);
            this.roundedPanel2.TabIndex = 0;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.Red;
            this.btnBusqueda.BackgroundColor = System.Drawing.Color.Red;
            this.btnBusqueda.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBusqueda.BorderRadius = 0;
            this.btnBusqueda.BorderSize = 0;
            this.btnBusqueda.FlatAppearance.BorderSize = 0;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnBusqueda.Location = new System.Drawing.Point(418, 12);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(61, 25);
            this.btnBusqueda.TabIndex = 1;
            this.btnBusqueda.Text = "botonRectanguloRedondo1";
            this.btnBusqueda.TextColor = System.Drawing.Color.White;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.botonRectanguloRedondo1_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(18, 15);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(394, 20);
            this.txtBusqueda.TabIndex = 0;
            // 
            // BusquedaClientesFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1072, 450);
            this.Controls.Add(this.roundedPanel1);
            this.Name = "BusquedaClientesFacturacion";
            this.Text = "BusquedaClientesFacturacion";
            this.Load += new System.EventHandler(this.BusquedaClientesFacturacion_Load);
            this.roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes2)).EndInit();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BotonesCustomizados.RoundedPanel roundedPanel1;
        private BotonesCustomizados.RoundedPanel roundedPanel2;
        private BotonesCustomizados.botonRectanguloRedondo btnBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dataGridViewClientes2;
        private BotonesCustomizados.botonRectanguloRedondo btnAnadir;
    }
}