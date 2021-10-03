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
    public partial class FrmListaClientes : Form
    {
        static Cliente clienteSeleccion;
        public FrmListaClientes()
        {
            InitializeComponent();
            ActualizarDataGrid();
            clienteSeleccion = null;
        }             

        public static Cliente ClienteSeleccion
        {
            get { return FrmListaClientes.clienteSeleccion; }
                      
        }

        private void ActualizarDataGrid()
        {
            List<Cliente> auxLista = new List<Cliente>();

            foreach (Cliente cliente in Petshop.ListaClientes)
            {
                if (cliente.ClienteActivo)
                {
                    auxLista.Add(cliente);
                }
            }
                       
            dgListaClientes.DataSource = auxLista;

            dgListaClientes.AutoGenerateColumns = true;
           

            dgListaClientes.Columns["ClienteActivo"].Visible = false;

            //foreach (Cliente item in Petshop.ListaClientes)
            //{

            //    if (item.ClienteActivo)
            //    {
            //        dgListasPetshop.Rows.Add(item.IdCliente, item.Nombre, item.Apellido, item.Telefono, item.Saldo);
            //    } 
            //}
        }

        private Cliente ObtenerDatosFilaDataGrid()
        {
            Cliente cliente = null;
            int indiceFila = dgListaClientes.CurrentRow.Index;

            if (indiceFila >= 0)
            {
                DataGridViewRow fila = dgListaClientes.Rows[indiceFila];

                int id = (int)fila.Cells["ID"].Value;
               
                cliente = Cliente.BuscarClientePorId(id);
              
            }

            return cliente;
        }


        private void btnCerrarListaClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            this.ActualizarDataGrid();
            this.CargarCliente();
        }     
        

        private void FrmListaClientes_Leave(object sender, EventArgs e)
        {
            this.CargarCliente();
        }

        private void CargarCliente()
        {
            int indiceFila = dgListaClientes.CurrentRow is not null ? dgListaClientes.CurrentRow.Index: -1;

            if (indiceFila >= 0)
            {
                DataGridViewRow fila = dgListaClientes.Rows[indiceFila];
                int auxId = int.Parse(fila.Cells["IdCliente"].Value.ToString());

                FrmListaClientes.clienteSeleccion = Cliente.BuscarClientePorId(auxId);
            }
        }
               

        private void btnVenta_Click(object sender, EventArgs e)
        {
            this.CargarCliente();

            if(clienteSeleccion is not null)
            {
                FrmVentas venta = new FrmVentas(clienteSeleccion);
                venta.Show();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un cliente");
            }


        }

    }
}
