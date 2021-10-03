using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PetShop
{
    public partial class FrmEditarUsuario : Form
    {
        Usuario usuario;

        public FrmEditarUsuario(Usuario auxUsuario)
        {
            InitializeComponent();
            this.usuario = auxUsuario;
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            txtNickNombreUsuario.Text = usuario.NickNombreUsuario;            
            txtContraseniaUsuario.Text = usuario.Contrasenia;
            txtNombreUsuario.Text = usuario.Nombre;
            txtApellidoUsuario.Text = usuario.Apellido;
            txtDni.Text = usuario.DNI.ToString();
            txtSueldoUsuario.Text = ((Empleado)usuario).Sueldo.ToString();

        }

        private void btnCerrarEditarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
        private void txtNickNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            this.usuario.NickNombreUsuario = txtNickNombreUsuario.Text;
        }
        private void txtContraseniaUsuario_TextChanged(object sender, EventArgs e)
        {
            this.usuario.Contrasenia = txtContraseniaUsuario.Text;
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            this.usuario.Nombre = txtNombreUsuario.Text;
        }

        private void txtApellidoUsuario_TextChanged(object sender, EventArgs e)
        {
            this.usuario.Apellido = txtApellidoUsuario.Text;
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            this.usuario.DNI = int.Parse(txtDni.Text);
        }

        private void txtSueldoUsuario_TextChanged(object sender, EventArgs e)
        {
            
            ((Empleado)this.usuario).Sueldo = double.Parse(txtSueldoUsuario.Text);
        }

        private void txtBono_TextChanged(object sender, EventArgs e)
        {
            ((Administrador)this.usuario).Bono = double.Parse(txtBono.Text);
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {

            switch ((EUsuarios)cmbUsuario.SelectedItem)
            {
                case EUsuarios.Empleado:

                    ((Empleado)this.usuario).EditarUsuario();
                    break;

                case EUsuarios.Administrador:

                    ((Administrador)this.usuario).EditarUsuario();
                    break;
            }

            this.Close();       

        }

    }







}
