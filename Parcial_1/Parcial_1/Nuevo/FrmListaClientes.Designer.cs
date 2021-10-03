
namespace PetShop
{
    partial class FrmListaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaClientes));
            this.dgListaClientes = new System.Windows.Forms.DataGridView();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnCerrarListaClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListaClientes
            // 
            this.dgListaClientes.AllowUserToAddRows = false;
            this.dgListaClientes.AllowUserToDeleteRows = false;
            this.dgListaClientes.AllowUserToResizeRows = false;
            this.dgListaClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgListaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListaClientes.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaClientes.Location = new System.Drawing.Point(12, 69);
            this.dgListaClientes.MultiSelect = false;
            this.dgListaClientes.Name = "dgListaClientes";
            this.dgListaClientes.ReadOnly = true;
            this.dgListaClientes.RowTemplate.Height = 25;
            this.dgListaClientes.Size = new System.Drawing.Size(576, 449);
            this.dgListaClientes.TabIndex = 0;
            // 
            // btnVenta
            // 
            this.btnVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVenta.Location = new System.Drawing.Point(179, 538);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(245, 38);
            this.btnVenta.TabIndex = 1;
            this.btnVenta.Text = "Vender";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnCerrarListaClientes
            // 
            this.btnCerrarListaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarListaClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarListaClientes.BackgroundImage")));
            this.btnCerrarListaClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarListaClientes.FlatAppearance.BorderSize = 0;
            this.btnCerrarListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarListaClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarListaClientes.Location = new System.Drawing.Point(558, 12);
            this.btnCerrarListaClientes.Name = "btnCerrarListaClientes";
            this.btnCerrarListaClientes.Size = new System.Drawing.Size(30, 30);
            this.btnCerrarListaClientes.TabIndex = 2;
            this.btnCerrarListaClientes.UseVisualStyleBackColor = true;
            this.btnCerrarListaClientes.Click += new System.EventHandler(this.btnCerrarListaClientes_Click);
            // 
            // FrmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.btnCerrarListaClientes);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.dgListaClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "FrmListaClientes";
            this.Text = "FrmListaClientes";
            this.Load += new System.EventHandler(this.FrmListaClientes_Load);
            this.Leave += new System.EventHandler(this.FrmListaClientes_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaClientes;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnCerrarListaClientes;
    }
}