namespace Parcial2_SistemaDeFacturacion
{
    partial class AñadirCatgProducto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_categoriasExistentes = new System.Windows.Forms.DataGridView();
            this.DTV_CategoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTipbtnAñadirCatg = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipbtnEditarCatg = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipbtnEliminarCatg = new System.Windows.Forms.ToolTip(this.components);
            this.roundedPanel1 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.RoundedPanel();
            this.escribirNombreCategoria = new System.Windows.Forms.TextBox();
            this.btnEliminarCategoria = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.btnEditarCategoria = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.btnAgregarCategoria = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.botonRectanguloRedondo();
            this.roundedPanel2 = new Parcial2_SistemaDeFacturacion.BotonesCustomizados.RoundedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_categoriasExistentes)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(35, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 34);
            this.label10.TabIndex = 25;
            this.label10.Text = "Categorías";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Categorías Existentes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nueva Categoría";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DGV_categoriasExistentes
            // 
            this.DGV_categoriasExistentes.AllowUserToAddRows = false;
            this.DGV_categoriasExistentes.AllowUserToDeleteRows = false;
            this.DGV_categoriasExistentes.AllowUserToResizeColumns = false;
            this.DGV_categoriasExistentes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DGV_categoriasExistentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_categoriasExistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_categoriasExistentes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_categoriasExistentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_categoriasExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_categoriasExistentes.ColumnHeadersVisible = false;
            this.DGV_categoriasExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DTV_CategoriaProducto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_categoriasExistentes.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_categoriasExistentes.Location = new System.Drawing.Point(43, 280);
            this.DGV_categoriasExistentes.MultiSelect = false;
            this.DGV_categoriasExistentes.Name = "DGV_categoriasExistentes";
            this.DGV_categoriasExistentes.RowHeadersVisible = false;
            this.DGV_categoriasExistentes.RowHeadersWidth = 51;
            this.DGV_categoriasExistentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_categoriasExistentes.Size = new System.Drawing.Size(780, 434);
            this.DGV_categoriasExistentes.TabIndex = 35;
            this.DGV_categoriasExistentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriasExistentes_CellContentClick_1);
            this.DGV_categoriasExistentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriasExistentes_CellContentClick_1);
            this.DGV_categoriasExistentes.SelectionChanged += new System.EventHandler(this.categoriasExistentes_SelectionChanged);
            // 
            // DTV_CategoriaProducto
            // 
            this.DTV_CategoriaProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DTV_CategoriaProducto.FillWeight = 236.0406F;
            this.DTV_CategoriaProducto.HeaderText = "CATEGORIA";
            this.DTV_CategoriaProducto.MinimumWidth = 6;
            this.DTV_CategoriaProducto.Name = "DTV_CategoriaProducto";
            this.DTV_CategoriaProducto.ReadOnly = true;
            this.DTV_CategoriaProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(185)))));
            this.roundedPanel1.BorderRadius = 11;
            this.roundedPanel1.BorderSize = 2;
            this.roundedPanel1.Controls.Add(this.escribirNombreCategoria);
            this.roundedPanel1.Location = new System.Drawing.Point(41, 194);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(316, 46);
            this.roundedPanel1.TabIndex = 39;
            // 
            // escribirNombreCategoria
            // 
            this.escribirNombreCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.escribirNombreCategoria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escribirNombreCategoria.ForeColor = System.Drawing.Color.Black;
            this.escribirNombreCategoria.Location = new System.Drawing.Point(6, 14);
            this.escribirNombreCategoria.Name = "escribirNombreCategoria";
            this.escribirNombreCategoria.Size = new System.Drawing.Size(302, 14);
            this.escribirNombreCategoria.TabIndex = 36;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarCategoria.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnEliminarCategoria.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminarCategoria.BorderRadius = 8;
            this.btnEliminarCategoria.BorderSize = 0;
            this.btnEliminarCategoria.FlatAppearance.BorderSize = 0;
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(620, 194);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(102, 46);
            this.btnEliminarCategoria.TabIndex = 38;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.TextColor = System.Drawing.Color.Black;
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditarCategoria.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditarCategoria.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditarCategoria.BorderRadius = 8;
            this.btnEditarCategoria.BorderSize = 0;
            this.btnEditarCategoria.FlatAppearance.BorderSize = 0;
            this.btnEditarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnEditarCategoria.Location = new System.Drawing.Point(502, 194);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(102, 46);
            this.btnEditarCategoria.TabIndex = 37;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.TextColor = System.Drawing.Color.Black;
            this.btnEditarCategoria.UseVisualStyleBackColor = false;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(78)))));
            this.btnAgregarCategoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(78)))));
            this.btnAgregarCategoria.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarCategoria.BorderRadius = 8;
            this.btnAgregarCategoria.BorderSize = 0;
            this.btnAgregarCategoria.FlatAppearance.BorderSize = 0;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(384, 194);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(102, 46);
            this.btnAgregarCategoria.TabIndex = 26;
            this.btnAgregarCategoria.Text = "Añadir";
            this.btnAgregarCategoria.TextColor = System.Drawing.Color.Black;
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.AutoScroll = true;
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(185)))));
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.BorderSize = 2;
            this.roundedPanel2.Location = new System.Drawing.Point(17, 76);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(834, 708);
            this.roundedPanel2.TabIndex = 15;
            // 
            // AñadirCatgProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnEditarCategoria);
            this.Controls.Add(this.DGV_categoriasExistentes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundedPanel2);
            this.Name = "AñadirCatgProducto";
            this.Size = new System.Drawing.Size(1551, 978);
            this.Load += new System.EventHandler(this.AñadirCatgProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_categoriasExistentes)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private BotonesCustomizados.botonRectanguloRedondo btnAgregarCategoria;
        private BotonesCustomizados.RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_categoriasExistentes;
        private System.Windows.Forms.TextBox escribirNombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTV_CategoriaProducto;
        private BotonesCustomizados.botonRectanguloRedondo btnEditarCategoria;
        private BotonesCustomizados.botonRectanguloRedondo btnEliminarCategoria;
        private System.Windows.Forms.ToolTip toolTipbtnAñadirCatg;
        private System.Windows.Forms.ToolTip toolTipbtnEditarCatg;
        private System.Windows.Forms.ToolTip toolTipbtnEliminarCatg;
        private BotonesCustomizados.RoundedPanel roundedPanel1;
    }
}
