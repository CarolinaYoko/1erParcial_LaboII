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
    public partial class FrmListaProductos : Form
    {
        public FrmListaProductos()
        {
            InitializeComponent();
        }

        private void FrmoListaProductos_Load(object sender, EventArgs e)
        {

            foreach (KeyValuePair<Producto, int> item in Petshop.ListaProductos)
            {
                dgProductos.Rows.Add(item.Key.tipoDeProducto, item.Key.nombre, item.Key.descripcion, item.Key.precio, item.Value);

            }

        }

        private void btnCerrarListaProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
