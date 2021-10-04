using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (usuario.GetType() == typeof(Administrador))
            {
                txtBono.Text = ((Administrador)usuario).Bono.ToString();
            }


            this.CambiarVistas();

        }

        private void btnCerrarEditarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNickNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNickNombreUsuario.Text))
            {
                this.usuario.NickNombreUsuario = txtNickNombreUsuario.Text;
            }

        }

        private void txtContraseniaUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtContraseniaUsuario.Text))
            {
                this.usuario.Contrasenia = txtContraseniaUsuario.Text;
            }

        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                this.usuario.Nombre = txtNombreUsuario.Text;
            }
        }

        private void txtApellidoUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtApellidoUsuario.Text))
            {
                this.usuario.Apellido = txtApellidoUsuario.Text;
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            int dni;
            if (int.TryParse(txtDni.Text, out dni))
            {
                this.usuario.DNI = dni;
            }
        }

        private void txtSueldoUsuario_TextChanged(object sender, EventArgs e)
        {
            double sueldo;
            if (double.TryParse(txtSueldoUsuario.Text, out sueldo))
            {
                ((Empleado)this.usuario).Sueldo = sueldo;
            }
        }

        private void txtBono_TextChanged(object sender, EventArgs e)
        {
            double bono;
            if (double.TryParse(txtSueldoUsuario.Text, out bono))
            {
                ((Administrador)this.usuario).Bono = bono;
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (usuario.GetType() == typeof(Empleado))
            {
                ((Empleado)this.usuario).EditarUsuario();
            }
            else
            {
                ((Administrador)this.usuario).EditarUsuario();

            }



            this.Close();

        }

        /// <summary>
        /// Cambia la vista según el tipo de usuario que se desea cargar
        /// </summary>
        private void CambiarVistas()
        {
            if (usuario.GetType() == typeof(Empleado))
            {
                txtBono.Visible = false;
            }
            else
            {
                txtBono.Visible = true;
            }
        }



    }







}
