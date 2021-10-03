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
    public partial class FrmMenuPrincipal : Form
    {
 
        public FrmMenuPrincipal(Usuario usuarioLogueado)
        {
            InitializeComponent();
            customizeDesign();
            this.ConfiguracionDeVistas(usuarioLogueado);
        }

        private void customizeDesign()
        {
            panelSubMenuCliente.Visible = false;
            panelSubMenuEmpleado.Visible = false;

        } 

        private void hideSubMenu()
        {
            if (panelSubMenuCliente.Visible == true)
                panelSubMenuCliente.Visible = false;
            if (panelSubMenuEmpleado.Visible == true)
                panelSubMenuEmpleado.Visible = false;

        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
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
            showSubmenu(panelSubMenuCliente);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            openChiledForm(new FrmListaUsuario());
            showSubmenu(panelSubMenuEmpleado);
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            openChiledForm(new FrmAltaCliente());
            hideSubMenu();
        }

       
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            openChiledForm(new FrmEditarCliente(FrmListaClientes.ClienteSeleccion));
            hideSubMenu();
        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            Cliente.EliminarCliente(FrmListaClientes.ClienteSeleccion);
            openChiledForm(new FrmListaClientes());
            hideSubMenu();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            openChiledForm(new FrmAltaUsuario());
            hideSubMenu();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            openChiledForm(new FrmEditarUsuario(FrmListaUsuario.UsuarioSeleccion));
            hideSubMenu();
        }

        private void btnBorrarUsuario_Click(object sender, EventArgs e)
        {
            Usuario.EliminarUsuario(FrmListaUsuario.UsuarioSeleccion);
            openChiledForm(new FrmListaUsuario());

            hideSubMenu();
        }

        
        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            openChiledForm(new FrmFacturacion());         

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeForm = null;
        private void openChiledForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            
            childForm.BringToFront();
            childForm.Show();

        }

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
