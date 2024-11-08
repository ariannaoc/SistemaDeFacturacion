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
            this.PasswordImg = new System.Windows.Forms.Panel();
            this.UserImg = new System.Windows.Forms.Panel();
            this.UserTxt = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.TextBoxRedondo();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTxt = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.TextBoxRedondo();
            this.IniciarSesionLabel = new System.Windows.Forms.Label();
            this.IniciarSesionBtn = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.LoginPanel.BorderColor = System.Drawing.Color.Transparent;
            this.LoginPanel.BorderRadius = 20;
            this.LoginPanel.BorderSize = 0;
            this.LoginPanel.Controls.Add(this.PasswordImg);
            this.LoginPanel.Controls.Add(this.UserImg);
            this.LoginPanel.Controls.Add(this.UserTxt);
            this.LoginPanel.Controls.Add(this.UsuarioLabel);
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Controls.Add(this.PasswordTxt);
            this.LoginPanel.Controls.Add(this.IniciarSesionLabel);
            this.LoginPanel.Controls.Add(this.IniciarSesionBtn);
            this.LoginPanel.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginPanel.Location = new System.Drawing.Point(550, 200);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(800, 600);
            this.LoginPanel.TabIndex = 1;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPanel_Paint);
            // 
            // PasswordImg
            // 
            this.PasswordImg.BackgroundImage = global::Parcial2_SistemaDeFacturacion.Properties.Resources._lock;
            this.PasswordImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PasswordImg.Location = new System.Drawing.Point(170, 342);
            this.PasswordImg.Name = "PasswordImg";
            this.PasswordImg.Size = new System.Drawing.Size(50, 50);
            this.PasswordImg.TabIndex = 8;
            // 
            // UserImg
            // 
            this.UserImg.BackgroundImage = global::Parcial2_SistemaDeFacturacion.Properties.Resources.user_w;
            this.UserImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserImg.Location = new System.Drawing.Point(170, 202);
            this.UserImg.Name = "UserImg";
            this.UserImg.Size = new System.Drawing.Size(50, 50);
            this.UserImg.TabIndex = 7;
            // 
            // UserTxt
            // 
            this.UserTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.UserTxt.BorderColor = System.Drawing.Color.Transparent;
            this.UserTxt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.UserTxt.BorderRadius = 20;
            this.UserTxt.BorderSize = 2;
            this.UserTxt.CustomPasswordChar = '\0';
            this.UserTxt.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserTxt.Location = new System.Drawing.Point(245, 192);
            this.UserTxt.Multiline = true;
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.UserTxt.PasswordChar = false;
            this.UserTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.UserTxt.PlaceholderText = "";
            this.UserTxt.Size = new System.Drawing.Size(470, 60);
            this.UserTxt.TabIndex = 6;
            this.UserTxt.Texts = "";
            this.UserTxt.UnderlinedStyle = false;
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(151, 151);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(96, 28);
            this.UsuarioLabel.TabIndex = 5;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordLabel.Location = new System.Drawing.Point(151, 288);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(136, 28);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Contraseña";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.PasswordTxt.BorderColor = System.Drawing.Color.Transparent;
            this.PasswordTxt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.PasswordTxt.BorderRadius = 20;
            this.PasswordTxt.BorderSize = 2;
            this.PasswordTxt.CustomPasswordChar = '\0';
            this.PasswordTxt.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordTxt.Location = new System.Drawing.Point(243, 332);
            this.PasswordTxt.Multiline = true;
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.PasswordTxt.PasswordChar = false;
            this.PasswordTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.PasswordTxt.PlaceholderText = "";
            this.PasswordTxt.Size = new System.Drawing.Size(470, 60);
            this.PasswordTxt.TabIndex = 2;
            this.PasswordTxt.Texts = "";
            this.PasswordTxt.UnderlinedStyle = false;
            this.PasswordTxt.Load += new System.EventHandler(this.textBoxRedondo2_Load);
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
            this.Load += new System.EventHandler(this.Login_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BotonesCustomizados.RoundedPanel LoginPanel;
        private BotonesCustomizados.botonRectanguloRedondo IniciarSesionBtn;
        private System.Windows.Forms.Label IniciarSesionLabel;
        private BotonesCustomizados.TextBoxRedondo PasswordTxt;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsuarioLabel;
        private BotonesCustomizados.TextBoxRedondo UserTxt;
        private System.Windows.Forms.Panel UserImg;
        private System.Windows.Forms.Panel PasswordImg;
        //private BotonesCustomizados.TextBoxRedondo UserTxt;
    }
}