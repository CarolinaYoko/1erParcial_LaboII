
namespace PetShop
{
    partial class FrmEditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarUsuario));
            this.btnCerrarAltaEmpleado = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.txtSueldoUsuario = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellidoUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseniaUsuario = new System.Windows.Forms.TextBox();
            this.txtNickNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnCerrarEditarUsuario = new System.Windows.Forms.Button();
            this.txtBono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCerrarAltaEmpleado
            // 
            this.btnCerrarAltaEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarAltaEmpleado.BackgroundImage")));
            this.btnCerrarAltaEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarAltaEmpleado.FlatAppearance.BorderSize = 0;
            this.btnCerrarAltaEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarAltaEmpleado.Location = new System.Drawing.Point(612, -37);
            this.btnCerrarAltaEmpleado.Name = "btnCerrarAltaEmpleado";
            this.btnCerrarAltaEmpleado.Size = new System.Drawing.Size(30, 30);
            this.btnCerrarAltaEmpleado.TabIndex = 17;
            this.btnCerrarAltaEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarUsuario.Location = new System.Drawing.Point(179, 502);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(210, 48);
            this.btnEditarUsuario.TabIndex = 16;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // txtSueldoUsuario
            // 
            this.txtSueldoUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSueldoUsuario.Location = new System.Drawing.Point(109, 358);
            this.txtSueldoUsuario.Name = "txtSueldoUsuario";
            this.txtSueldoUsuario.PlaceholderText = "Sueldo";
            this.txtSueldoUsuario.Size = new System.Drawing.Size(393, 26);
            this.txtSueldoUsuario.TabIndex = 15;
            this.txtSueldoUsuario.TextChanged += new System.EventHandler(this.txtSueldoUsuario_TextChanged);
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDni.Location = new System.Drawing.Point(109, 301);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "D.N.I";
            this.txtDni.Size = new System.Drawing.Size(393, 26);
            this.txtDni.TabIndex = 14;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // txtApellidoUsuario
            // 
            this.txtApellidoUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellidoUsuario.Location = new System.Drawing.Point(109, 244);
            this.txtApellidoUsuario.Name = "txtApellidoUsuario";
            this.txtApellidoUsuario.PlaceholderText = "Apellido";
            this.txtApellidoUsuario.Size = new System.Drawing.Size(393, 26);
            this.txtApellidoUsuario.TabIndex = 13;
            this.txtApellidoUsuario.TextChanged += new System.EventHandler(this.txtApellidoUsuario_TextChanged);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreUsuario.Location = new System.Drawing.Point(109, 187);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.PlaceholderText = "Nombre";
            this.txtNombreUsuario.Size = new System.Drawing.Size(393, 26);
            this.txtNombreUsuario.TabIndex = 12;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.txtNombreUsuario_TextChanged);
            // 
            // txtContraseniaUsuario
            // 
            this.txtContraseniaUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContraseniaUsuario.Location = new System.Drawing.Point(109, 130);
            this.txtContraseniaUsuario.Name = "txtContraseniaUsuario";
            this.txtContraseniaUsuario.PlaceholderText = "Contraseña";
            this.txtContraseniaUsuario.Size = new System.Drawing.Size(393, 26);
            this.txtContraseniaUsuario.TabIndex = 11;
            this.txtContraseniaUsuario.TextChanged += new System.EventHandler(this.txtContraseniaUsuario_TextChanged);
            // 
            // txtNickNombreUsuario
            // 
            this.txtNickNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNickNombreUsuario.Location = new System.Drawing.Point(109, 73);
            this.txtNickNombreUsuario.Name = "txtNickNombreUsuario";
            this.txtNickNombreUsuario.PlaceholderText = "Nombre de usuario";
            this.txtNickNombreUsuario.Size = new System.Drawing.Size(393, 26);
            this.txtNickNombreUsuario.TabIndex = 10;
            this.txtNickNombreUsuario.TextChanged += new System.EventHandler(this.txtNickNombreUsuario_TextChanged);
            // 
            // btnCerrarEditarUsuario
            // 
            this.btnCerrarEditarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarEditarUsuario.BackgroundImage")));
            this.btnCerrarEditarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarEditarUsuario.FlatAppearance.BorderSize = 0;
            this.btnCerrarEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarEditarUsuario.Location = new System.Drawing.Point(558, 12);
            this.btnCerrarEditarUsuario.Name = "btnCerrarEditarUsuario";
            this.btnCerrarEditarUsuario.Size = new System.Drawing.Size(30, 30);
            this.btnCerrarEditarUsuario.TabIndex = 18;
            this.btnCerrarEditarUsuario.UseVisualStyleBackColor = true;
            this.btnCerrarEditarUsuario.Click += new System.EventHandler(this.btnCerrarEditarUsuario_Click);
            // 
            // txtBono
            // 
            this.txtBono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBono.Location = new System.Drawing.Point(109, 415);
            this.txtBono.Name = "txtBono";
            this.txtBono.PlaceholderText = "Bono";
            this.txtBono.Size = new System.Drawing.Size(393, 26);
            this.txtBono.TabIndex = 19;
            this.txtBono.TextChanged += new System.EventHandler(this.txtBono_TextChanged);
            // 
            // FrmEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.txtBono);
            this.Controls.Add(this.btnCerrarEditarUsuario);
            this.Controls.Add(this.btnCerrarAltaEmpleado);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.txtSueldoUsuario);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellidoUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtContraseniaUsuario);
            this.Controls.Add(this.txtNickNombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarUsuario";
            this.Text = "FrmEditarUsuario";
            this.Load += new System.EventHandler(this.FrmEditarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarAltaEmpleado;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.TextBox txtSueldoUsuario;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellidoUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtContraseniaUsuario;
        private System.Windows.Forms.TextBox txtNickNombreUsuario;
        private System.Windows.Forms.Button btnCerrarEditarUsuario;
        private System.Windows.Forms.TextBox txtBono;
    }
}