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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TablaUsuarios = new System.Windows.Forms.DataGridView();
            this.GestUserLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.NuevoUsuarioBtn = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            ((System.ComponentModel.ISupportInitialize)(this.TablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaUsuarios
            // 
            this.TablaUsuarios.AllowUserToAddRows = false;
            this.TablaUsuarios.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.TablaUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.TablaUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TablaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TablaUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.TablaUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.TablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaUsuarios.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaUsuarios.DefaultCellStyle = dataGridViewCellStyle8;
            this.TablaUsuarios.GridColor = System.Drawing.SystemColors.Control;
            this.TablaUsuarios.Location = new System.Drawing.Point(86, 384);
            this.TablaUsuarios.Name = "TablaUsuarios";
            this.TablaUsuarios.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.TablaUsuarios.RowHeadersWidth = 60;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.TablaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.TablaUsuarios.RowTemplate.Height = 24;
            this.TablaUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TablaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaUsuarios.Size = new System.Drawing.Size(900, 254);
            this.TablaUsuarios.TabIndex = 0;
            this.TablaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaUsuarios_CellContentClick);
            // 
            // GestUserLabel
            // 
            this.GestUserLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GestUserLabel.AutoSize = true;
            this.GestUserLabel.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestUserLabel.ForeColor = System.Drawing.Color.Black;
            this.GestUserLabel.Location = new System.Drawing.Point(422, 104);
            this.GestUserLabel.Name = "GestUserLabel";
            this.GestUserLabel.Size = new System.Drawing.Size(326, 40);
            this.GestUserLabel.TabIndex = 2;
            this.GestUserLabel.Text = "Gestión de Usuarios";
            this.GestUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GestUserLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NuevoUsuarioBtn
            // 
            this.NuevoUsuarioBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.NuevoUsuarioBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NuevoUsuarioBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.NuevoUsuarioBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.NuevoUsuarioBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.NuevoUsuarioBtn.BorderRadius = 15;
            this.NuevoUsuarioBtn.BorderSize = 0;
            this.NuevoUsuarioBtn.FlatAppearance.BorderSize = 0;
            this.NuevoUsuarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoUsuarioBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoUsuarioBtn.ForeColor = System.Drawing.Color.White;
            this.NuevoUsuarioBtn.Location = new System.Drawing.Point(756, 249);
            this.NuevoUsuarioBtn.Name = "NuevoUsuarioBtn";
            this.NuevoUsuarioBtn.Size = new System.Drawing.Size(185, 50);
            this.NuevoUsuarioBtn.TabIndex = 1;
            this.NuevoUsuarioBtn.Text = "+ Nuevo Usuario";
            this.NuevoUsuarioBtn.TextColor = System.Drawing.Color.White;
            this.NuevoUsuarioBtn.UseVisualStyleBackColor = false;
            this.NuevoUsuarioBtn.Click += new System.EventHandler(this.NuevoUsuarioBtn_Click);
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
            this.Size = new System.Drawing.Size(1093, 712);
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
        public int IdUser = 0;
        public string usuario = "";
        public string nombreU = "";
        public string password = "";
        public string UserFormAction = "";
        public List<Usuario> tablausuarios = new List<Usuario>();
    }
}
