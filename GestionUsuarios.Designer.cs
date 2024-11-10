using System.Collections.Generic;
using System.Windows.Forms;

namespace Parcial2_SistemaDeFacturacion
{
    partial class GestionUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TablaUsuarios = new System.Windows.Forms.DataGridView();
            this.NuevoUsuarioBtn = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.GestUserLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.TablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaUsuarios
            // 
            this.TablaUsuarios.AllowUserToAddRows = false;
            this.TablaUsuarios.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.TablaUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TablaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TablaUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.TablaUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaUsuarios.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.TablaUsuarios.GridColor = System.Drawing.SystemColors.Control;
            this.TablaUsuarios.Location = new System.Drawing.Point(175, 329);
            this.TablaUsuarios.Name = "TablaUsuarios";
            this.TablaUsuarios.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TablaUsuarios.RowHeadersWidth = 60;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.TablaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TablaUsuarios.RowTemplate.Height = 24;
            this.TablaUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TablaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaUsuarios.Size = new System.Drawing.Size(731, 254);
            this.TablaUsuarios.TabIndex = 0;
            this.TablaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaUsuarios_CellContentClick);
            // 
            // NuevoUsuarioBtn
            // 
            this.NuevoUsuarioBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.NuevoUsuarioBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.NuevoUsuarioBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.NuevoUsuarioBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.NuevoUsuarioBtn.BorderRadius = 15;
            this.NuevoUsuarioBtn.BorderSize = 0;
            this.NuevoUsuarioBtn.FlatAppearance.BorderSize = 0;
            this.NuevoUsuarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoUsuarioBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoUsuarioBtn.ForeColor = System.Drawing.Color.White;
            this.NuevoUsuarioBtn.Location = new System.Drawing.Point(858, 189);
            this.NuevoUsuarioBtn.Name = "NuevoUsuarioBtn";
            this.NuevoUsuarioBtn.Size = new System.Drawing.Size(185, 50);
            this.NuevoUsuarioBtn.TabIndex = 1;
            this.NuevoUsuarioBtn.Text = "+ Nuevo Usuario";
            this.NuevoUsuarioBtn.TextColor = System.Drawing.Color.White;
            this.NuevoUsuarioBtn.UseVisualStyleBackColor = false;
            this.NuevoUsuarioBtn.Click += new System.EventHandler(this.NuevoUsuarioBtn_Click);
            // 
            // GestUserLabel
            // 
            this.GestUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GestUserLabel.AutoSize = true;
            this.GestUserLabel.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestUserLabel.ForeColor = System.Drawing.Color.Black;
            this.GestUserLabel.Location = new System.Drawing.Point(395, 86);
            this.GestUserLabel.Name = "GestUserLabel";
            this.GestUserLabel.Size = new System.Drawing.Size(326, 40);
            this.GestUserLabel.TabIndex = 2;
            this.GestUserLabel.Text = "Gestión de Usuarios";
            this.GestUserLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CausesValidation = false;
            this.Controls.Add(this.GestUserLabel);
            this.Controls.Add(this.NuevoUsuarioBtn);
            this.Controls.Add(this.TablaUsuarios);
            this.Name = "GestionUsuarios";
            this.Size = new System.Drawing.Size(1093, 607);
            this.Load += new System.EventHandler(this.GestionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaUsuarios;
        private BotonesCustomizados.botonRectanguloRedondo NuevoUsuarioBtn;
        private System.Windows.Forms.Label GestUserLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public string rolU = "";
        public string usuario = "";
        public string nombreU = "";
        public string password = "";
        public string UserFormAction = "";
        public List<Usuario> tablausuarios = new List<Usuario>();
    }
}
