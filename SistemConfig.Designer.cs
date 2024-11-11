namespace Parcial2_SistemaDeFacturacion
{
    partial class SistemConfig
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
            this.SCLabel = new System.Windows.Forms.Label();
            this.botonRectanguloRedondo1 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.PanelNE = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.RoundedPanel();
            this.NombreEmpresaLabel = new System.Windows.Forms.Label();
            this.Empresa = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.ConfigImgP = new System.Windows.Forms.Panel();
            this.PanelNE.SuspendLayout();
            this.SuspendLayout();
            // 
            // SCLabel
            // 
            this.SCLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SCLabel.AutoSize = true;
            this.SCLabel.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCLabel.ForeColor = System.Drawing.Color.Black;
            this.SCLabel.Location = new System.Drawing.Point(268, 73);
            this.SCLabel.Name = "SCLabel";
            this.SCLabel.Size = new System.Drawing.Size(457, 40);
            this.SCLabel.TabIndex = 0;
            this.SCLabel.Text = "Configuraciones del Sistema";
            // 
            // botonRectanguloRedondo1
            // 
            this.botonRectanguloRedondo1.BackColor = System.Drawing.Color.Transparent;
            this.botonRectanguloRedondo1.BackgroundColor = System.Drawing.Color.Transparent;
            this.botonRectanguloRedondo1.BorderColor = System.Drawing.Color.Black;
            this.botonRectanguloRedondo1.BorderRadius = 20;
            this.botonRectanguloRedondo1.BorderSize = 1;
            this.botonRectanguloRedondo1.FlatAppearance.BorderSize = 0;
            this.botonRectanguloRedondo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRectanguloRedondo1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRectanguloRedondo1.ForeColor = System.Drawing.Color.Gray;
            this.botonRectanguloRedondo1.Image = global::Parcial2_SistemaDeFacturacion.Properties.Resources.caution;
            this.botonRectanguloRedondo1.Location = new System.Drawing.Point(145, 444);
            this.botonRectanguloRedondo1.Name = "botonRectanguloRedondo1";
            this.botonRectanguloRedondo1.Size = new System.Drawing.Size(419, 190);
            this.botonRectanguloRedondo1.TabIndex = 4;
            this.botonRectanguloRedondo1.Text = "Editar Logo";
            this.botonRectanguloRedondo1.TextColor = System.Drawing.Color.Gray;
            this.botonRectanguloRedondo1.UseVisualStyleBackColor = false;
            // 
            // PanelNE
            // 
            this.PanelNE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelNE.BackColor = System.Drawing.Color.White;
            this.PanelNE.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.PanelNE.BorderRadius = 20;
            this.PanelNE.BorderSize = 0;
            this.PanelNE.Controls.Add(this.NombreEmpresaLabel);
            this.PanelNE.Location = new System.Drawing.Point(145, 320);
            this.PanelNE.Name = "PanelNE";
            this.PanelNE.Size = new System.Drawing.Size(370, 63);
            this.PanelNE.TabIndex = 3;
            // 
            // NombreEmpresaLabel
            // 
            this.NombreEmpresaLabel.AutoSize = true;
            this.NombreEmpresaLabel.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreEmpresaLabel.Location = new System.Drawing.Point(116, 18);
            this.NombreEmpresaLabel.Name = "NombreEmpresaLabel";
            this.NombreEmpresaLabel.Size = new System.Drawing.Size(162, 24);
            this.NombreEmpresaLabel.TabIndex = 2;
            this.NombreEmpresaLabel.Text = "NombreEmpresa";
            this.NombreEmpresaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NombreEmpresaLabel.Click += new System.EventHandler(this.NombreEmpresaLabel_Click);
            // 
            // Empresa
            // 
            this.Empresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Empresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.Empresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.Empresa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Empresa.BorderRadius = 20;
            this.Empresa.BorderSize = 0;
            this.Empresa.FlatAppearance.BorderSize = 0;
            this.Empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Empresa.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empresa.ForeColor = System.Drawing.Color.White;
            this.Empresa.Location = new System.Drawing.Point(570, 304);
            this.Empresa.Name = "Empresa";
            this.Empresa.Size = new System.Drawing.Size(273, 92);
            this.Empresa.TabIndex = 1;
            this.Empresa.Text = "Editar empresa";
            this.Empresa.TextColor = System.Drawing.Color.White;
            this.Empresa.UseVisualStyleBackColor = false;
            this.Empresa.Click += new System.EventHandler(this.Empresa_Click);
            // 
            // ConfigImgP
            // 
            this.ConfigImgP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConfigImgP.BackColor = System.Drawing.Color.Red;
            this.ConfigImgP.Location = new System.Drawing.Point(380, 116);
            this.ConfigImgP.Name = "ConfigImgP";
            this.ConfigImgP.Size = new System.Drawing.Size(251, 170);
            this.ConfigImgP.TabIndex = 5;
            // 
            // SistemConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConfigImgP);
            this.Controls.Add(this.botonRectanguloRedondo1);
            this.Controls.Add(this.PanelNE);
            this.Controls.Add(this.Empresa);
            this.Controls.Add(this.SCLabel);
            this.Name = "SistemConfig";
            this.Size = new System.Drawing.Size(941, 664);
            this.Load += new System.EventHandler(this.SistemConfig_Load);
            this.PanelNE.ResumeLayout(false);
            this.PanelNE.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SCLabel;
        private BotonesCustomizados.botonRectanguloRedondo Empresa;
        private System.Windows.Forms.Label NombreEmpresaLabel;
        private BotonesCustomizados.RoundedPanel PanelNE;
        private BotonesCustomizados.botonRectanguloRedondo botonRectanguloRedondo1;
        private System.Windows.Forms.Panel ConfigImgP;
    }
}
