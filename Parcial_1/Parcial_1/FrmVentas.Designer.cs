
namespace PetShop
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.btnAgregarAlCarrito = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lvProductos = new System.Windows.Forms.ListView();
            this.lvCarrito = new System.Windows.Forms.ListView();
            this.btnQuitarDelCarrito = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCerrarVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarAlCarrito
            // 
            this.btnAgregarAlCarrito.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarAlCarrito.Location = new System.Drawing.Point(331, 50);
            this.btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            this.btnAgregarAlCarrito.Size = new System.Drawing.Size(97, 36);
            this.btnAgregarAlCarrito.TabIndex = 2;
            this.btnAgregarAlCarrito.Text = "Agregar";
            this.btnAgregarAlCarrito.UseVisualStyleBackColor = true;
            this.btnAgregarAlCarrito.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(115, 58);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(142, 23);
            this.txtCantidad.TabIndex = 3;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizar.Location = new System.Drawing.Point(182, 515);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(209, 37);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lvProductos
            // 
            this.lvProductos.HideSelection = false;
            this.lvProductos.Location = new System.Drawing.Point(12, 102);
            this.lvProductos.MultiSelect = false;
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(254, 389);
            this.lvProductos.TabIndex = 6;
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            // 
            // lvCarrito
            // 
            this.lvCarrito.HideSelection = false;
            this.lvCarrito.Location = new System.Drawing.Point(312, 102);
            this.lvCarrito.Name = "lvCarrito";
            this.lvCarrito.Size = new System.Drawing.Size(260, 389);
            this.lvCarrito.TabIndex = 7;
            this.lvCarrito.UseCompatibleStateImageBehavior = false;
            // 
            // btnQuitarDelCarrito
            // 
            this.btnQuitarDelCarrito.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuitarDelCarrito.Location = new System.Drawing.Point(445, 50);
            this.btnQuitarDelCarrito.Name = "btnQuitarDelCarrito";
            this.btnQuitarDelCarrito.Size = new System.Drawing.Size(97, 36);
            this.btnQuitarDelCarrito.TabIndex = 8;
            this.btnQuitarDelCarrito.Text = "Quitar";
            this.btnQuitarDelCarrito.UseVisualStyleBackColor = true;
            this.btnQuitarDelCarrito.Click += new System.EventHandler(this.btnQuitarDelCarrito_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(27, 60);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(71, 17);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(57, 18);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(41, 18);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "Error";
            // 
            // btnCerrarVenta
            // 
            this.btnCerrarVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarVenta.BackgroundImage")));
            this.btnCerrarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarVenta.FlatAppearance.BorderSize = 0;
            this.btnCerrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVenta.Location = new System.Drawing.Point(542, 6);
            this.btnCerrarVenta.Name = "btnCerrarVenta";
            this.btnCerrarVenta.Size = new System.Drawing.Size(30, 30);
            this.btnCerrarVenta.TabIndex = 12;
            this.btnCerrarVenta.UseVisualStyleBackColor = true;
            this.btnCerrarVenta.Click += new System.EventHandler(this.btnCerrarVenta_Click);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnCerrarVenta);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnQuitarDelCarrito);
            this.Controls.Add(this.lvCarrito);
            this.Controls.Add(this.lvProductos);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnAgregarAlCarrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarAlCarrito;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.ListView lvCarrito;
        private System.Windows.Forms.Button btnQuitarDelCarrito;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnCerrarVenta;
    }
}