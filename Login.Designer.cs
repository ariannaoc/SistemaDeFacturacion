namespace Parcial2_SistemaDeFacturacion
{
    partial class Login
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
            this.LoginPanel = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.RoundedPanel();
            //this.UserTxt = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.TextBoxRedondo();
            this.IniciarSesionLabel = new System.Windows.Forms.Label();
            this.IniciarSesionBtn = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.LoginPanel.BorderColor = System.Drawing.Color.Transparent;
            this.LoginPanel.BorderRadius = 20;
            this.LoginPanel.BorderSize = 0;
            //this.LoginPanel.Controls.Add(this.UserTxt);
            this.LoginPanel.Controls.Add(this.IniciarSesionLabel);
            this.LoginPanel.Controls.Add(this.IniciarSesionBtn);
            this.LoginPanel.Location = new System.Drawing.Point(550, 200);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(800, 600);
            this.LoginPanel.TabIndex = 1;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // UserTxt
            // 
            //this.UserTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            //| System.Windows.Forms.AnchorStyles.Right)));
            //this.UserTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            //this.UserTxt.BorderColor = System.Drawing.Color.Transparent;
            //this.UserTxt.BorderFocusColor = System.Drawing.Color.DarkOrange;
            //this.UserTxt.BorderRadius = 15;
            //this.UserTxt.BorderSize = 1;
            //this.UserTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            //this.UserTxt.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.UserTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            //this.UserTxt.Location = new System.Drawing.Point(165, 184);
            //this.UserTxt.Multiline = true;
            //this.UserTxt.Name = "UserTxt";
            //this.UserTxt.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            //this.UserTxt.PasswordChar = false;
            //this.UserTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            //this.UserTxt.PlaceholderText = "";
            //this.UserTxt.Size = new System.Drawing.Size(500, 60);
            //this.UserTxt.TabIndex = 3;
            //this.UserTxt.Texts = "";
            //this.UserTxt.UnderlinedStyle = false;
            // 
            // IniciarSesionLabel
            // 
            this.IniciarSesionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IniciarSesionLabel.AutoSize = true;
            this.IniciarSesionLabel.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IniciarSesionLabel.Location = new System.Drawing.Point(303, 71);
            this.IniciarSesionLabel.Name = "IniciarSesionLabel";
            this.IniciarSesionLabel.Size = new System.Drawing.Size(227, 40);
            this.IniciarSesionLabel.TabIndex = 1;
            this.IniciarSesionLabel.Text = "Iniciar Sesión";
            this.IniciarSesionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // IniciarSesionBtn
            // 
            this.IniciarSesionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IniciarSesionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(167)))), ((int)(((byte)(36)))));
            this.IniciarSesionBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(167)))), ((int)(((byte)(36)))));
            this.IniciarSesionBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.IniciarSesionBtn.BorderRadius = 20;
            this.IniciarSesionBtn.BorderSize = 0;
            this.IniciarSesionBtn.FlatAppearance.BorderSize = 0;
            this.IniciarSesionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciarSesionBtn.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesionBtn.ForeColor = System.Drawing.Color.Black;
            this.IniciarSesionBtn.Location = new System.Drawing.Point(535, 448);
            this.IniciarSesionBtn.Name = "IniciarSesionBtn";
            this.IniciarSesionBtn.Size = new System.Drawing.Size(180, 60);
            this.IniciarSesionBtn.TabIndex = 0;
            this.IniciarSesionBtn.Text = "Iniciar Sesión";
            this.IniciarSesionBtn.TextColor = System.Drawing.Color.Black;
            this.IniciarSesionBtn.UseVisualStyleBackColor = false;
            this.IniciarSesionBtn.Click += new System.EventHandler(this.IniciarSesionBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.LoginPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2554, 1318);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BotonesCustomizados.RoundedPanel LoginPanel;
        private BotonesCustomizados.botonRectanguloRedondo IniciarSesionBtn;
        private System.Windows.Forms.Label IniciarSesionLabel;
        //private BotonesCustomizados.TextBoxRedondo UserTxt;
    }
}