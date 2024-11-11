namespace Parcial2_SistemaDeFacturacion
{
    partial class InfoUserEmergente
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
            this.PanelInfoUser = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.RoundedPanel();
            this.UserLabel = new System.Windows.Forms.Label();
            this.CerrarSesionBtn = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.roundedPanel1 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.RoundedPanel();
            this.botonRectanguloRedondo1 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.PanelInfoUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelInfoUser
            // 
            this.PanelInfoUser.BackColor = System.Drawing.Color.White;
            this.PanelInfoUser.BorderColor = System.Drawing.Color.White;
            this.PanelInfoUser.BorderRadius = 20;
            this.PanelInfoUser.BorderSize = 0;
            this.PanelInfoUser.Controls.Add(this.UserLabel);
            this.PanelInfoUser.Controls.Add(this.CerrarSesionBtn);
            this.PanelInfoUser.Controls.Add(this.UserNameLabel);
            this.PanelInfoUser.Controls.Add(this.roundedPanel1);
            this.PanelInfoUser.Controls.Add(this.botonRectanguloRedondo1);
            this.PanelInfoUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelInfoUser.Location = new System.Drawing.Point(0, 0);
            this.PanelInfoUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelInfoUser.Name = "PanelInfoUser";
            this.PanelInfoUser.Size = new System.Drawing.Size(246, 189);
            this.PanelInfoUser.TabIndex = 1;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UserLabel.Location = new System.Drawing.Point(104, 106);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(37, 16);
            this.UserLabel.TabIndex = 3;
            this.UserLabel.Text = "user";
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UserLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // CerrarSesionBtn
            // 
            this.CerrarSesionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.CerrarSesionBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.CerrarSesionBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CerrarSesionBtn.BorderRadius = 15;
            this.CerrarSesionBtn.BorderSize = 0;
            this.CerrarSesionBtn.FlatAppearance.BorderSize = 0;
            this.CerrarSesionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarSesionBtn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarSesionBtn.ForeColor = System.Drawing.Color.White;
            this.CerrarSesionBtn.Location = new System.Drawing.Point(118, 141);
            this.CerrarSesionBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CerrarSesionBtn.Name = "CerrarSesionBtn";
            this.CerrarSesionBtn.Size = new System.Drawing.Size(110, 37);
            this.CerrarSesionBtn.TabIndex = 0;
            this.CerrarSesionBtn.Text = "Cerrar Sesión";
            this.CerrarSesionBtn.TextColor = System.Drawing.Color.White;
            this.CerrarSesionBtn.UseVisualStyleBackColor = false;
            this.CerrarSesionBtn.Click += new System.EventHandler(this.CerrarSesionBtn_Click_1);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(96, 80);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(62, 16);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "Nombre";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.BackgroundImage = global::Parcial2_SistemaDeFacturacion.Properties.Resources.user_b;
            this.roundedPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 2;
            this.roundedPanel1.Location = new System.Drawing.Point(97, 14);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(52, 57);
            this.roundedPanel1.TabIndex = 1;
            // 
            // botonRectanguloRedondo1
            // 
            this.botonRectanguloRedondo1.BackColor = System.Drawing.Color.Transparent;
            this.botonRectanguloRedondo1.BackgroundColor = System.Drawing.Color.Transparent;
            this.botonRectanguloRedondo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonRectanguloRedondo1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonRectanguloRedondo1.BorderRadius = 0;
            this.botonRectanguloRedondo1.BorderSize = 0;
            this.botonRectanguloRedondo1.FlatAppearance.BorderSize = 0;
            this.botonRectanguloRedondo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRectanguloRedondo1.ForeColor = System.Drawing.Color.White;
            this.botonRectanguloRedondo1.Location = new System.Drawing.Point(34, 141);
            this.botonRectanguloRedondo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonRectanguloRedondo1.Name = "botonRectanguloRedondo1";
            this.botonRectanguloRedondo1.Size = new System.Drawing.Size(30, 32);
            this.botonRectanguloRedondo1.TabIndex = 0;
            this.botonRectanguloRedondo1.TextColor = System.Drawing.Color.White;
            this.botonRectanguloRedondo1.UseVisualStyleBackColor = false;
            // 
            // InfoUserEmergente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(246, 189);
            this.Controls.Add(this.PanelInfoUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(1024, 50);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoUserEmergente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InfoUserEmergente_Load);
            this.PanelInfoUser.ResumeLayout(false);
            this.PanelInfoUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public string usuario = "";
        public int IdUser = 0;
        public string nombreU = "";
        public string password = "";
        public string rolU = "";
        private BotonesCustomizados.botonRectanguloRedondo CerrarSesionBtn;
        private BotonesCustomizados.RoundedPanel PanelInfoUser;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private BotonesCustomizados.RoundedPanel roundedPanel1;
        private BotonesCustomizados.botonRectanguloRedondo botonRectanguloRedondo1;
    }
}
