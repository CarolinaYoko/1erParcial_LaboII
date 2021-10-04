
namespace PetShop
{
    partial class FrmListaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaProductos));
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.TipoDeProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrarListaProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProductos
            // 
            this.dgProductos.AllowUserToAddRows = false;
            this.dgProductos.AllowUserToDeleteRows = false;
            this.dgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProductos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDeProducto,
            this.Nombre,
            this.Descripcion,
            this.Precio,
            this.Stock});
            this.dgProductos.Location = new System.Drawing.Point(12, 75);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowTemplate.Height = 25;
            this.dgProductos.Size = new System.Drawing.Size(575, 505);
            this.dgProductos.TabIndex = 0;
            // 
            // TipoDeProducto
            // 
            this.TipoDeProducto.HeaderText = "Tipo de producto";
            this.TipoDeProducto.Name = "TipoDeProducto";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // btnCerrarListaProductos
            // 
            this.btnCerrarListaProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarListaProductos.BackgroundImage")));
            this.btnCerrarListaProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarListaProductos.FlatAppearance.BorderSize = 0;
            this.btnCerrarListaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarListaProductos.Location = new System.Drawing.Point(557, 12);
            this.btnCerrarListaProductos.Name = "btnCerrarListaProductos";
            this.btnCerrarListaProductos.Size = new System.Drawing.Size(30, 30);
            this.btnCerrarListaProductos.TabIndex = 1;
            this.btnCerrarListaProductos.UseVisualStyleBackColor = true;
            this.btnCerrarListaProductos.Click += new System.EventHandler(this.btnCerrarListaProductos_Click);
            // 
            // FrmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.btnCerrarListaProductos);
            this.Controls.Add(this.dgProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "FrmListaProductos";
            this.Text = "FrmoListaProductos";
            this.Load += new System.EventHandler(this.FrmoListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDeProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Button btnCerrarListaProductos;
    }
}