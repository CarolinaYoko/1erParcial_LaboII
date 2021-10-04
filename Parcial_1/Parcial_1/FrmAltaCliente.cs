using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
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
            long telefono;
            double saldo;
            
            if (!string.IsNullOrWhiteSpace(txtNombreAlta.Text) && !string.IsNullOrWhiteSpace(txtApellidoAlta.Text) && long.TryParse(txtTelefonoAlta.Text, out telefono) == true && double.TryParse(txtSaldoAlta.Text, out saldo) == true)
            {
                Cliente nuevoCliente = new Cliente(txtNombreAlta.Text, txtApellidoAlta.Text, long.Parse(txtTelefonoAlta.Text), double.Parse(txtSaldoAlta.Text));

                Cliente.AgregarCliente(nuevoCliente);

                SystemSounds.Asterisk.Play();
            }
            else
            {
                MessageBox.Show("Faltan algunos campos por rellenar o son valores no válidos");
            }

            this.Close();
                                   
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
