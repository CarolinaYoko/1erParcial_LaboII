
namespace PetShop
{
    partial class FrmFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturacion));
            this.lblTextoRecaudacion = new System.Windows.Forms.Label();
            this.lblRecaudacion = new System.Windows.Forms.Label();
            this.btnCerrarFacturacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextoRecaudacion
            // 
            this.lblTextoRecaudacion.AutoSize = true;
            this.lblTextoRecaudacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTextoRecaudacion.Location = new System.Drawing.Point(45, 164);
            this.lblTextoRecaudacion.Name = "lblTextoRecaudacion";
            this.lblTextoRecaudacion.Size = new System.Drawing.Size(208, 22);
            this.lblTextoRecaudacion.TabIndex = 0;
            this.lblTextoRecaudacion.Text = "Recaudación del día:";
            // 
            // lblRecaudacion
            // 
            this.lblRecaudacion.AutoSize = true;
            this.lblRecaudacion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecaudacion.Location = new System.Drawing.Point(295, 159);
            this.lblRecaudacion.Name = "lblRecaudacion";
            this.lblRecaudacion.Size = new System.Drawing.Size(168, 28);
            this.lblRecaudacion.TabIndex = 1;
            this.lblRecaudacion.Text = "Recaudacion";
            // 
            // btnCerrarFacturacion
            // 
            this.btnCerrarFacturacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarFacturacion.BackgroundImage")));
            this.btnCerrarFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarFacturacion.FlatAppearance.BorderSize = 0;
            this.btnCerrarFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarFacturacion.Location = new System.Drawing.Point(542, 12);
            this.btnCerrarFacturacion.Name = "btnCerrarFacturacion";
            this.btnCerrarFacturacion.Size = new System.Drawing.Size(30, 30);
            this.btnCerrarFacturacion.TabIndex = 2;
            this.btnCerrarFacturacion.UseVisualStyleBackColor = true;
            this.btnCerrarFacturacion.Click += new System.EventHandler(this.btnCerrarFacturacion_Click);
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnCerrarFacturacion);
            this.Controls.Add(this.lblRecaudacion);
            this.Controls.Add(this.lblTextoRecaudacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFacturacion";
            this.Text = "FrmFacturacion";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoRecaudacion;
        private System.Windows.Forms.Label lblRecaudacion;
        private System.Windows.Forms.Button btnCerrarFacturacion;
    }
}