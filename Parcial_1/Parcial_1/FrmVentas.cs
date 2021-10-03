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
    public partial class FrmVentas : Form
    {
        Dictionary<Producto, int> auxCarrito;
        Cliente cliente;

        public FrmVentas(Cliente auxCliente)
        {
            InitializeComponent();
            auxCarrito = new Dictionary<Producto, int>();

            if (auxCliente is not null)
                this.cliente = auxCliente;

        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            txtCantidad.Text = "1";

            foreach (KeyValuePair<Producto, int> producto in Petshop.ListaProductos)
            {
                lvProductos.Items.Add(producto.Key.idProducto.ToString(), producto.Key.nombre + " - " + producto.Key.descripcion, 0);
            }
            
            lvProductos.View = View.SmallIcon;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad;
            int idProducto;

            if (lvProductos.SelectedItems.Count > 0 && int.TryParse(txtCantidad.Text, out cantidad))
            {
                ListViewItem itemProducto = (ListViewItem)lvProductos.SelectedItems[0].Clone();

                itemProducto.Name = lvProductos.SelectedItems[0].Name;

                if (int.TryParse(itemProducto.Name, out idProducto) && auxCarrito.TryAdd(Producto.BuscarProductoPorId(idProducto), cantidad))
                {
                    lvCarrito.Items.Add(itemProducto.Name, itemProducto.Text + " | Cantidad: " + cantidad.ToString(), 0);
                }
            }

            else
            {
                lblError.Text = "No ha seleccionado un producto";
                lblError.Visible = true;
            }

            lvCarrito.View = View.SmallIcon;

        }


        private double PrecioTotalDeVenta()
        {
            double total = 0;

            foreach (KeyValuePair<Producto, int> producto in auxCarrito)
            {
                total += producto.Key.precio * producto.Value;
            }

            return total;
        }


        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            double precioTotal = PrecioTotalDeVenta();

            if (Caja.VerificarSaldo(this.cliente, precioTotal))
            {

                foreach (KeyValuePair<Producto, int> producto in this.auxCarrito)
                {
                    if (Caja.VerificarStock(producto.Key, producto.Value) && Petshop.DescontarDeStock(producto.Key.idProducto, producto.Value))
                    {
                        Caja.AgregarAlCarrito(producto.Key, producto.Value);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema", "El Producto:" + producto.Key.nombre + ", no se puede cargar", MessageBoxButtons.OK);
                        return;
                    }
                }

                Petshop.AumentarRecaudacion(precioTotal);
                this.cliente.DescontarSaldo(precioTotal);
                MessageBox.Show("Venta Exitosa");
                
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }

        }

        private void btnQuitarDelCarrito_Click(object sender, EventArgs e)
        {

            ListViewItem itemProducto = (ListViewItem)lvCarrito.SelectedItems[0];

            lvCarrito.Items[itemProducto.Index].Remove();

            this.auxCarrito.Remove(Producto.BuscarProductoPorId(int.Parse(itemProducto.Name)));

        }

        private void btnCerrarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
