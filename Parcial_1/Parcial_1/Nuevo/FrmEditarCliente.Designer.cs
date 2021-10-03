
namespace PetShop
{
    partial class FrmEditarCliente
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
            this.SuspendLayout();
            // 
            // txtNombreAlta
            // 
            this.txtNombreAlta.Location = new System.Drawing.Point(137, 125);
            this.txtNombreAlta.TextChanged += new System.EventHandler(this.txtNombreAlta_TextChanged);
            // 
            // txtTelefonoAlta
            // 
            this.txtTelefonoAlta.Location = new System.Drawing.Point(137, 259);
            this.txtTelefonoAlta.TextChanged += new System.EventHandler(this.txtTelefonoAlta_TextChanged);
            // 
            // txtSaldoAlta
            // 
            this.txtSaldoAlta.Location = new System.Drawing.Point(137, 323);
            this.txtSaldoAlta.TextChanged += new System.EventHandler(this.txtSaldoAlta_TextChanged);
            // 
            // txtApellidoAlta
            // 
            this.txtApellidoAlta.Location = new System.Drawing.Point(137, 192);
            this.txtApellidoAlta.TextChanged += new System.EventHandler(this.txtApellidoAlta_TextChanged);
            // 
            // btnRegistrarAlta
            // 
            this.btnRegistrarAlta.Location = new System.Drawing.Point(191, 435);
            // 
            // FrmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Name = "FrmEditarCliente";
            this.Text = "Editar Cliente";
            this.Load += new System.EventHandler(this.FrmEditarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}