
namespace PetShop
{
    partial class FrmAltaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaUsuario));
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.txtNickNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseniaUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtApellidoUsuario = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtSueldoUsuario = new System.Windows.Forms.TextBox();
            this.btnAltaUsuario = new System.Windows.Forms.Button();
            this.txtBonoAdmin = new System.Windows.Forms.TextBox();
            this.btnCerrarAltaUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(89, 46);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(394, 28);
            this.cmbUsuario.TabIndex = 0;
            this.cmbUsuario.SelectedValueChanged += new System.EventHandler(this.cmbUsuario_SelectedValueChanged);
            // 
            // txtNickNombreUsuario
            // 
            this.txtNickNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNickNombreUsuario.Location = new System.Drawing.Point(90, 103);
            this.txtNickNombreUsuario.Name = "txtNickNombreUsuario";
            this.txtNickNombreUsuario.PlaceholderText = "Nombre de usuario";
            this.txtNickNombreUsuario.Size = new System.Drawing.Size(393, 26);
            this.txtNickNombreUsuario.TabIndex = 1;
            this.txtNickNombreUsuario.Tag = "";
            // 
            // txtContraseniaUsuario
            // 
            this.txtContraseniaUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContraseniaUsuario.Location = new System.Drawing.Point(90, 158);
            this.txtContraseniaUsuario.Name = "txtContraseniaUsuario";
            this.txtContraseniaUsuario.PlaceholderText = "Contraseña";
            this.txtContraseniaUsuario.Size = new System.Drawing.Size(393, 26);
            this.txtContraseniaUsuario.TabIndex = 2;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreUsuario.Location = new System.Drawing.Point(90, 213);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.PlaceholderText = "Nombre";
            this.txtNombreUsuario.Size = new System.Drawing.Size(393, 26);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // txtApellidoUsuario
            // 
            this.txtApellidoUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellidoUsuario.Location = new System.Drawing.Point(90, 268);
            this.txtApellidoUsuario.Name = "txtApellidoUsuario";
            this.txtApellidoUsuario.PlaceholderText = "Apellido";
            this.txtApellidoUsuario.Size = new System.Drawing.Size(393, 26);
            this.txtApellidoUsuario.TabIndex = 4;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDni.Location = new System.Drawing.Point(90, 323);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "D.N.I";
            this.txtDni.Size = new System.Drawing.Size(393, 26);
            this.txtDni.TabIndex = 5;
            // 
            // txtSueldoUsuario
            // 
            this.txtSueldoUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSueldoUsuario.Location = new System.Drawing.Point(89, 378);
            this.txtSueldoUsuario.Name = "txtSueldoUsuario";
            this.txtSueldoUsuario.PlaceholderText = "Sueldo";
            this.txtSueldoUsuario.Size = new System.Drawing.Size(393, 26);
            this.txtSueldoUsuario.TabIndex = 6;
            // 
            // btnAltaUsuario
            // 
            this.btnAltaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAltaUsuario.Location = new System.Drawing.Point(181, 488);
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Size = new System.Drawing.Size(210, 48);
            this.btnAltaUsuario.TabIndex = 7;
            this.btnAltaUsuario.Text = "Agregar";
            this.btnAltaUsuario.UseVisualStyleBackColor = true;
            this.btnAltaUsuario.Click += new System.EventHandler(this.btnAltaUsuario_Click);
            // 
            // txtBonoAdmin
            // 
            this.txtBonoAdmin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBonoAdmin.Location = new System.Drawing.Point(90, 433);
            this.txtBonoAdmin.Name = "txtBonoAdmin";
            this.txtBonoAdmin.PlaceholderText = "Bono";
            this.txtBonoAdmin.Size = new System.Drawing.Size(393, 26);
            this.txtBonoAdmin.TabIndex = 8;
            // 
            // btnCerrarAltaUsuario
            // 
            this.btnCerrarAltaUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarAltaUsuario.BackgroundImage")));
            this.btnCerrarAltaUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarAltaUsuario.FlatAppearance.BorderSize = 0;
            this.btnCerrarAltaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarAltaUsuario.Location = new System.Drawing.Point(542, 12);
            this.btnCerrarAltaUsuario.Name = "btnCerrarAltaUsuario";
            this.btnCerrarAltaUsuario.Size = new System.Drawing.Size(30, 30);
            this.btnCerrarAltaUsuario.TabIndex = 19;
            this.btnCerrarAltaUsuario.UseVisualStyleBackColor = true;
            this.btnCerrarAltaUsuario.Click += new System.EventHandler(this.btnCerrarEditarUsuario_Click);
            // 
            // FrmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnCerrarAltaUsuario);
            this.Controls.Add(this.txtBonoAdmin);
            this.Controls.Add(this.btnAltaUsuario);
            this.Controls.Add(this.txtSueldoUsuario);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellidoUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtContraseniaUsuario);
            this.Controls.Add(this.txtNickNombreUsuario);
            this.Controls.Add(this.cmbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaUsuario";
            this.Text = "FrmAltaEmpleado";
            this.Load += new System.EventHandler(this.FrmAltaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.TextBox txtNickNombreUsuario;
        private System.Windows.Forms.TextBox txtContraseniaUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtApellidoUsuario;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtSueldoUsuario;
        private System.Windows.Forms.Button btnAltaUsuario;
        private System.Windows.Forms.TextBox txtBonoAdmin;
        private System.Windows.Forms.Button btnCerrarAltaUsuario;
    }
}