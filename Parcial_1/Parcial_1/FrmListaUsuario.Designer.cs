
namespace PetShop
{
    partial class FrmListaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaUsuario));
            this.btnCerrarListaUsuarios = new System.Windows.Forms.Button();
            this.dgUsuario = new System.Windows.Forms.DataGridView();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarListaUsuarios
            // 
            this.btnCerrarListaUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarListaUsuarios.BackgroundImage")));
            this.btnCerrarListaUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarListaUsuarios.FlatAppearance.BorderSize = 0;
            this.btnCerrarListaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarListaUsuarios.Location = new System.Drawing.Point(558, 12);
            this.btnCerrarListaUsuarios.Name = "btnCerrarListaUsuarios";
            this.btnCerrarListaUsuarios.Size = new System.Drawing.Size(30, 30);
            this.btnCerrarListaUsuarios.TabIndex = 0;
            this.btnCerrarListaUsuarios.UseVisualStyleBackColor = true;
            this.btnCerrarListaUsuarios.Click += new System.EventHandler(this.btnCerrarListaUsuarios_Click);
            // 
            // dgUsuario
            // 
            this.dgUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUsuario.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuario.Location = new System.Drawing.Point(12, 92);
            this.dgUsuario.Name = "dgUsuario";
            this.dgUsuario.RowTemplate.Height = 25;
            this.dgUsuario.Size = new System.Drawing.Size(576, 458);
            this.dgUsuario.TabIndex = 1;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(167, 38);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(257, 23);
            this.cmbTipo.TabIndex = 2;
            this.cmbTipo.SelectedValueChanged += new System.EventHandler(this.cmbTipo_SelectedValueChanged);
            // 
            // FrmListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.dgUsuario);
            this.Controls.Add(this.btnCerrarListaUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "FrmListaUsuario";
            this.ShowIcon = false;
            this.Text = "FrmListaUsuario";
            this.Load += new System.EventHandler(this.FrmListaUsuario_Load);
            this.Leave += new System.EventHandler(this.FrmListaUsuario_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarListaUsuarios;
        private System.Windows.Forms.DataGridView dgUsuario;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}