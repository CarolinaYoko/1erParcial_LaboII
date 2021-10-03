
namespace PetShop
{
    partial class FrmAltaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaCliente));
            this.txtNombreAlta = new System.Windows.Forms.TextBox();
            this.txtTelefonoAlta = new System.Windows.Forms.TextBox();
            this.txtSaldoAlta = new System.Windows.Forms.TextBox();
            this.txtApellidoAlta = new System.Windows.Forms.TextBox();
            this.btnRegistrarAlta = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreAlta
            // 
            this.txtNombreAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreAlta.Location = new System.Drawing.Point(107, 123);
            this.txtNombreAlta.Name = "txtNombreAlta";
            this.txtNombreAlta.PlaceholderText = "Introducir nombre";
            this.txtNombreAlta.Size = new System.Drawing.Size(342, 23);
            this.txtNombreAlta.TabIndex = 0;
            // 
            // txtTelefonoAlta
            // 
            this.txtTelefonoAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefonoAlta.Location = new System.Drawing.Point(107, 257);
            this.txtTelefonoAlta.Name = "txtTelefonoAlta";
            this.txtTelefonoAlta.PlaceholderText = "Introducir telefono";
            this.txtTelefonoAlta.Size = new System.Drawing.Size(342, 23);
            this.txtTelefonoAlta.TabIndex = 2;
            // 
            // txtSaldoAlta
            // 
            this.txtSaldoAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSaldoAlta.Location = new System.Drawing.Point(107, 321);
            this.txtSaldoAlta.Name = "txtSaldoAlta";
            this.txtSaldoAlta.PlaceholderText = "Introducir saldo";
            this.txtSaldoAlta.Size = new System.Drawing.Size(342, 23);
            this.txtSaldoAlta.TabIndex = 3;
            // 
            // txtApellidoAlta
            // 
            this.txtApellidoAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellidoAlta.Location = new System.Drawing.Point(107, 190);
            this.txtApellidoAlta.Name = "txtApellidoAlta";
            this.txtApellidoAlta.PlaceholderText = "Introducir apellido";
            this.txtApellidoAlta.Size = new System.Drawing.Size(342, 23);
            this.txtApellidoAlta.TabIndex = 1;
            // 
            // btnRegistrarAlta
            // 
            this.btnRegistrarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarAlta.Location = new System.Drawing.Point(161, 433);
            this.btnRegistrarAlta.Name = "btnRegistrarAlta";
            this.btnRegistrarAlta.Size = new System.Drawing.Size(217, 46);
            this.btnRegistrarAlta.TabIndex = 4;
            this.btnRegistrarAlta.Text = "Registrar";
            this.btnRegistrarAlta.UseVisualStyleBackColor = true;
            this.btnRegistrarAlta.Click += new System.EventHandler(this.btnRegistrarAlta_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(536, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistrarAlta);
            this.Controls.Add(this.txtApellidoAlta);
            this.Controls.Add(this.txtSaldoAlta);
            this.Controls.Add(this.txtTelefonoAlta);
            this.Controls.Add(this.txtNombreAlta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox txtNombreAlta;
        protected System.Windows.Forms.TextBox txtTelefonoAlta;
        protected System.Windows.Forms.TextBox txtSaldoAlta;
        protected System.Windows.Forms.TextBox txtApellidoAlta;
        protected System.Windows.Forms.Button btnRegistrarAlta;
        private System.Windows.Forms.Button btnCerrar;
    }
}