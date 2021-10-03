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
using PetShop;

namespace PetShop
{
    public partial class FrmAltaCliente : Form
    {
        
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        
        protected virtual void btnRegistrarAlta_Click(object sender, EventArgs e)
        {

            Cliente nuevoCliente = new Cliente(txtNombreAlta.Text, txtApellidoAlta.Text, long.Parse(txtTelefonoAlta.Text), double.Parse(txtSaldoAlta.Text));
            Cliente.AgregarCliente(nuevoCliente);

            this.Close();
                                   
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
