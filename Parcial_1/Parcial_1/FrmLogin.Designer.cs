
namespace Parcial_1
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.lblAdministrador = new System.Windows.Forms.LinkLabel();
            this.lblEmpleado = new System.Windows.Forms.LinkLabel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnCerrarLogin = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.Location = new System.Drawing.Point(261, 112);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Ingrese usuario";
            this.txtUsuario.Size = new System.Drawing.Size(302, 26);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(261, 170);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Ingrese contraseña";
            this.txtPassword.Size = new System.Drawing.Size(302, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAcceder.ForeColor = System.Drawing.Color.Transparent;
            this.btnAcceder.Location = new System.Drawing.Point(261, 227);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(302, 30);
            this.btnAcceder.TabIndex = 2;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdministrador.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAdministrador.Location = new System.Drawing.Point(307, 286);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(201, 17);
            this.lblAdministrador.TabIndex = 3;
            this.lblAdministrador.TabStop = true;
            this.lblAdministrador.Text = "Autocompletar Administrador";
            this.lblAdministrador.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAdministrador_LinkClicked);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpleado.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEmpleado.Location = new System.Drawing.Point(319, 321);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(178, 17);
            this.lblEmpleado.TabIndex = 4;
            this.lblEmpleado.TabStop = true;
            this.lblEmpleado.Text = "Autocompletar Empleado";
            this.lblEmpleado.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEmpleado_LinkClicked);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(204, 363);
            this.panelLogin.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.Color.Transparent;
            this.lblLogin.Location = new System.Drawing.Point(360, 30);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(105, 36);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "LOGIN";
            // 
            // btnCerrarLogin
            // 
            this.btnCerrarLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarLogin.BackgroundImage")));
            this.btnCerrarLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarLogin.FlatAppearance.BorderSize = 0;
            this.btnCerrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarLogin.Location = new System.Drawing.Point(576, 12);
            this.btnCerrarLogin.Name = "btnCerrarLogin";
            this.btnCerrarLogin.Size = new System.Drawing.Size(30, 30);
            this.btnCerrarLogin.TabIndex = 7;
            this.btnCerrarLogin.UseVisualStyleBackColor = true;
            this.btnCerrarLogin.Click += new System.EventHandler(this.btnCerrarLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(155)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(618, 363);
            this.Controls.Add(this.btnCerrarLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblAdministrador);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PETSHOP Login";
            this.panelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.LinkLabel lblAdministrador;
        private System.Windows.Forms.LinkLabel lblEmpleado;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnCerrarLogin;
    }
}

