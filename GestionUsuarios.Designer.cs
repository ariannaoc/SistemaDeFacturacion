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
            this.TablaUsuarios = new System.Windows.Forms.DataGridView();
            this.RolUsuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaUsuarios
            // 
            this.TablaUsuarios.AllowUserToOrderColumns = true;
            this.TablaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaUsuarios.BackgroundColor = System.Drawing.Color.Silver;
            this.TablaUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RolUsuarios,
            this.NombreUsuarios,
            this.Usuario});
            this.TablaUsuarios.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.TablaUsuarios.GridColor = System.Drawing.SystemColors.Control;
            this.TablaUsuarios.Location = new System.Drawing.Point(246, 294);
            this.TablaUsuarios.Name = "TablaUsuarios";
            this.TablaUsuarios.RowHeadersWidth = 60;
            this.TablaUsuarios.RowTemplate.Height = 24;
            this.TablaUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TablaUsuarios.Size = new System.Drawing.Size(437, 228);
            this.TablaUsuarios.TabIndex = 0;
            this.TablaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaUsuarios_CellContentClick);
            // 
            // RolUsuarios
            // 
            this.RolUsuarios.HeaderText = "Rol";
            this.RolUsuarios.MinimumWidth = 6;
            this.RolUsuarios.Name = "RolUsuarios";
            this.RolUsuarios.Width = 125;
            // 
            // NombreUsuarios
            // 
            this.NombreUsuarios.HeaderText = "Nombre";
            this.NombreUsuarios.MinimumWidth = 6;
            this.NombreUsuarios.Name = "NombreUsuarios";
            this.NombreUsuarios.Width = 125;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 125;
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TablaUsuarios);
            this.Name = "GestionUsuarios";
            this.Size = new System.Drawing.Size(896, 607);
            ((System.ComponentModel.ISupportInitialize)(this.TablaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
    }
}
