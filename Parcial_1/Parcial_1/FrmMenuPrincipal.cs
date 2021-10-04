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
    public partial class FrmMenuPrincipal : Form
    {

        private Form activeForm = null;

        public FrmMenuPrincipal(Usuario usuarioLogueado)
        {
            InitializeComponent();
            Personalizar();
            this.ConfiguracionDeVistas(usuarioLogueado);
        }

        /// <summary>
        /// Oculta los submenu de cliente y empleado
        /// </summary>
        private void Personalizar()
        {
            panelSubMenuCliente.Visible = false;
            panelSubMenuEmpleado.Visible = false;

        }

        /// <summary>
        /// Si los submenu estan visibles, los oculta, y si estan ocultos, los muestra
        /// </summary>
        private void OcultarSubmenus()
        {
            if (panelSubMenuCliente.Visible == true)
                panelSubMenuCliente.Visible = false;
            if (panelSubMenuEmpleado.Visible == true)
                panelSubMenuEmpleado.Visible = false;

        }

        /// <summary>
        /// Muestra el panel de submenu ingresado
        /// </summary>
        /// <param name="submenu"></param>
        private void MostrarSubmenus(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                OcultarSubmenus();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            openChiledForm(new FrmListaProductos());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openChiledForm(new FrmListaClientes());
            MostrarSubmenus(panelSubMenuCliente);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            openChiledForm(new FrmListaUsuario());
            MostrarSubmenus(panelSubMenuEmpleado);
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            openChiledForm(new FrmAltaCliente());
            OcultarSubmenus();
        }


        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            openChiledForm(new FrmEditarCliente(FrmListaClientes.ClienteSeleccion));
            OcultarSubmenus();
        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            Cliente.EliminarCliente(FrmListaClientes.ClienteSeleccion);
            openChiledForm(new FrmListaClientes());
            OcultarSubmenus();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            openChiledForm(new FrmAltaUsuario());
            OcultarSubmenus();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            openChiledForm(new FrmEditarUsuario(FrmListaUsuario.UsuarioSeleccion));
            OcultarSubmenus();
        }

        private void btnBorrarUsuario_Click(object sender, EventArgs e)
        {
            Usuario.EliminarUsuario(FrmListaUsuario.UsuarioSeleccion);
            openChiledForm(new FrmListaUsuario());
            OcultarSubmenus();
        }


        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            openChiledForm(new FrmFacturacion());

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Muestra un formulario instanciado y lo adapta al panel
        /// </summary>
        /// <param name="childForm"></param>
        private void openChiledForm(Form FormularioHijo)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            panelChild.Controls.Add(FormularioHijo);
            panelChild.Tag = FormularioHijo;

            FormularioHijo.BringToFront();
            FormularioHijo.Show();
        }

        /// <summary>
        /// Cambia las vistas segun el tipo de usuario logueado (Administrador o Empleado)
        /// </summary>
        /// <param name="usuarioLogueado"></param>
        private void ConfiguracionDeVistas(Usuario usuarioLogueado)
        {
            if (usuarioLogueado.GetType() == typeof(Empleado))
            {
                btnUsuario.Visible = false;
                btnFacturacion.Visible = false;
            }

        }

    }
}
