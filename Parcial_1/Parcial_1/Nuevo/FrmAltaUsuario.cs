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
    public partial class FrmAltaUsuario : Form
    {
        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            this.cmbUsuario.DataSource = Enum.GetValues(typeof(EUsuarios));

        }

        protected virtual void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            switch ((EUsuarios)cmbUsuario.SelectedItem)
            {
                case EUsuarios.Empleado:
                   
                    Empleado auxEmpleado = new Empleado(txtNickNombreUsuario.Text, 
                                                        txtContraseniaUsuario.Text, 
                                                        txtNombreUsuario.Text, 
                                                        txtApellidoUsuario.Text, 
                                                        int.Parse(txtDni.Text), 
                                                        double.Parse(txtSueldoUsuario.Text));
                    Empleado.AgregarUsuario(auxEmpleado);
                    break;
                
                case EUsuarios.Administrador:

                    Administrador auxAdministrador = new Administrador(txtNickNombreUsuario.Text,
                                                        txtContraseniaUsuario.Text,
                                                        txtNombreUsuario.Text,
                                                        txtApellidoUsuario.Text,
                                                        int.Parse(txtDni.Text),
                                                        double.Parse(txtSueldoUsuario.Text), double.Parse(txtBonoAdmin.Text));
                    Empleado.AgregarUsuario(auxAdministrador);
                    break;
            }

            this.Close();
        }       
      
    }
}
