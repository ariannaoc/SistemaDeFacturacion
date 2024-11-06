namespace Parcial2_SistemaDeFacturacion
{
    partial class VTNagregarCategoria
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelarAggCatg = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.btnConfirmarAggCatg = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.escribirNombreCatg = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.TextBoxRedondo();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Agregar Categoría";
            // 
            // btnCancelarAggCatg
            // 
            this.btnCancelarAggCatg.BackColor = System.Drawing.Color.Red;
            this.btnCancelarAggCatg.BackgroundColor = System.Drawing.Color.Red;
            this.btnCancelarAggCatg.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelarAggCatg.BorderRadius = 8;
            this.btnCancelarAggCatg.BorderSize = 0;
            this.btnCancelarAggCatg.FlatAppearance.BorderSize = 0;
            this.btnCancelarAggCatg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAggCatg.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAggCatg.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarAggCatg.Location = new System.Drawing.Point(36, 128);
            this.btnCancelarAggCatg.Name = "btnCancelarAggCatg";
            this.btnCancelarAggCatg.Size = new System.Drawing.Size(121, 32);
            this.btnCancelarAggCatg.TabIndex = 34;
            this.btnCancelarAggCatg.Text = "Cancelar";
            this.btnCancelarAggCatg.TextColor = System.Drawing.Color.Black;
            this.btnCancelarAggCatg.UseVisualStyleBackColor = false;
            this.btnCancelarAggCatg.Click += new System.EventHandler(this.btnCancelarAggCatg_Click);
            // 
            // btnConfirmarAggCatg
            // 
            this.btnConfirmarAggCatg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(78)))));
            this.btnConfirmarAggCatg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(78)))));
            this.btnConfirmarAggCatg.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirmarAggCatg.BorderRadius = 8;
            this.btnConfirmarAggCatg.BorderSize = 0;
            this.btnConfirmarAggCatg.FlatAppearance.BorderSize = 0;
            this.btnConfirmarAggCatg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarAggCatg.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarAggCatg.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarAggCatg.Location = new System.Drawing.Point(236, 128);
            this.btnConfirmarAggCatg.Name = "btnConfirmarAggCatg";
            this.btnConfirmarAggCatg.Size = new System.Drawing.Size(121, 32);
            this.btnConfirmarAggCatg.TabIndex = 33;
            this.btnConfirmarAggCatg.Text = "Añadir";
            this.btnConfirmarAggCatg.TextColor = System.Drawing.Color.Black;
            this.btnConfirmarAggCatg.UseVisualStyleBackColor = false;
            this.btnConfirmarAggCatg.Click += new System.EventHandler(this.btnConfirmarAggCatg_Click);
            // 
            // escribirNombreCatg
            // 
            this.escribirNombreCatg.BackColor = System.Drawing.Color.White;
            this.escribirNombreCatg.BorderColor = System.Drawing.Color.White;
            this.escribirNombreCatg.BorderFocusColor = System.Drawing.Color.Purple;
            this.escribirNombreCatg.BorderRadius = 8;
            this.escribirNombreCatg.BorderSize = 2;
            this.escribirNombreCatg.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escribirNombreCatg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.escribirNombreCatg.Location = new System.Drawing.Point(33, 71);
            this.escribirNombreCatg.Multiline = true;
            this.escribirNombreCatg.Name = "escribirNombreCatg";
            this.escribirNombreCatg.Padding = new System.Windows.Forms.Padding(7, 9, 7, 7);
            this.escribirNombreCatg.PasswordChar = false;
            this.escribirNombreCatg.PlaceholderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.escribirNombreCatg.PlaceholderText = "   Ingrese el nombre de la nueva categoría";
            this.escribirNombreCatg.Size = new System.Drawing.Size(324, 30);
            this.escribirNombreCatg.TabIndex = 32;
            this.escribirNombreCatg.Texts = "";
            this.escribirNombreCatg.UnderlinedStyle = false;
            this.escribirNombreCatg.Load += new System.EventHandler(this.escribirNombreCatg_Load);
            // 
            // VTNagregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(397, 177);
            this.Controls.Add(this.btnCancelarAggCatg);
            this.Controls.Add(this.btnConfirmarAggCatg);
            this.Controls.Add(this.escribirNombreCatg);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VTNagregarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ventanaAgregarCategoria";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private BotonesCustomizados.TextBoxRedondo escribirNombreCatg;
        private BotonesCustomizados.botonRectanguloRedondo btnConfirmarAggCatg;
        private BotonesCustomizados.botonRectanguloRedondo btnCancelarAggCatg;
    }
}