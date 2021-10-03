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
    public partial class FrmApp : Form
    {
        public FrmApp(Usuario usuarioLogeado)
        {
            InitializeComponent();
                        

            if (usuarioLogeado.GetType() == typeof(Empleado))
            {
                btnEmpleados.Visible = false;
                btnAdministradores.Visible = false;
                
            }


            dgListasPetshop.Visible = false;
            btnAgregarCliente.Visible = false;
            btnBorrar.Visible = false;
            btnEditar.Visible = false;
            btnVender.Visible = false;

        }

        private void ActualizarDataGrid()
        {
           
            dgListasPetshop.Rows.Clear();
                        
            //dgListasPetshop.DataSource = Petshop.ListaClientes;

            dgListasPetshop.AutoGenerateColumns = true;

            dgListasPetshop.DataSource = Petshop.ListaUsuarios;


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
            int indiceFila = dgListasPetshop.CurrentRow.Index;

            if (indiceFila >= 0)
            {
                DataGridViewRow fila = dgListasPetshop.Rows[indiceFila];

                int id = (int) fila.Cells["ID"].Value;
                
                string nombre = fila.Cells["Nombre"].Value.ToString();
                string apellido = fila.Cells["Apellido"].Value.ToString();
                long telefono = (long)fila.Cells["Telefono"].Value;
                double saldo = (double)fila.Cells["Saldo"].Value;

                cliente = Cliente.BuscarClientePorId(id);
                //switch ((EUsuario)this.cmbTipoUsuario.SelectedItem)
                //{
                //    case EUsuario.Administador:
                //    case EUsuario.Empleado:
                //        string nombreUsuario = fila.Cells["nombreUsuario"].Value.ToString();
                //        string contrasenia = fila.Cells["contrasenia"].Value.ToString();
                //        usuario = new Empleado(dni, nombre, apellido, nombreUsuario, contrasenia);
                //        break;
                //    case EUsuario.Cliente:
                //        double dineroInvertido = (double)fila.Cells["dineroInvertido"].Value;
                //        usuario = new Cliente(dni, nombre, apellido);
                //        break;
                //}
            }



            return cliente;
        }

        

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            dgListasPetshop.Visible = true;
            btnAgregarCliente.Visible = true;
            btnBorrar.Visible = true;
            btnEditar.Visible = true;
            btnVender.Visible = true;

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmAltaCliente formAltaCliente = new FrmAltaCliente();
            
            this.Visible = false;        
            formAltaCliente.ShowDialog();
            this.Visible = true;

            ActualizarDataGrid();
           
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Cliente.EliminarCliente(ObtenerDatosFilaDataGrid());
            ActualizarDataGrid();                             

        }

      
        private void btnEditar_Click(object sender, EventArgs e)
        {                     

            FrmEditarCliente formEditarCliente = new FrmEditarCliente(ObtenerDatosFilaDataGrid());

            this.Visible = false;
            formEditarCliente.ShowDialog();
            this.Visible = true;            

            ActualizarDataGrid();

        }

        private void dgListasPetshop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
