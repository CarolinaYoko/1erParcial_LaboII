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
    public partial class FrmEditarCliente : FrmAltaCliente
    {
        Cliente cliente;

        public FrmEditarCliente(Cliente auxCliente)
        {
            InitializeComponent();
            this.cliente = auxCliente;

        }

        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {            
            this.btnRegistrarAlta.Text = "Editar";
            txtNombreAlta.Text = cliente.Nombre;
            txtApellidoAlta.Text = cliente.Apellido;
            txtTelefonoAlta.Text = cliente.Telefono.ToString();
            txtSaldoAlta.Text = cliente.Saldo.ToString();
        }

        private void txtNombreAlta_TextChanged(object sender, EventArgs e)
        {
            this.cliente.Nombre = txtNombreAlta.Text;
        }

        private void txtApellidoAlta_TextChanged(object sender, EventArgs e)
        {
            this.cliente.Apellido = txtApellidoAlta.Text;
        }

        private void txtTelefonoAlta_TextChanged(object sender, EventArgs e)
        {
            this.cliente.Telefono = long.Parse(txtTelefonoAlta.Text);
        }

        private void txtSaldoAlta_TextChanged(object sender, EventArgs e)
        {
            this.cliente.Saldo = float.Parse(txtSaldoAlta.Text);
        }

        protected override void btnRegistrarAlta_Click(object sender, EventArgs e)
        {

            Cliente.EditarCliente(cliente);
            this.Close();

        }

       
    }
}
