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
            this.CambiarVistas();
        }

        protected virtual void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            int dni;
            double sueldo;

            switch ((EUsuarios)cmbUsuario.SelectedItem)
            {
                case EUsuarios.Empleado:

                    if (!string.IsNullOrWhiteSpace(txtNickNombreUsuario.Text) &&
                                                        !string.IsNullOrWhiteSpace(txtContraseniaUsuario.Text) &&
                                                        !string.IsNullOrWhiteSpace(txtNombreUsuario.Text) &&
                                                        !string.IsNullOrWhiteSpace(txtApellidoUsuario.Text) &&
                                                        int.TryParse(txtDni.Text, out dni) == true &&
                                                        double.TryParse(txtSueldoUsuario.Text, out sueldo) == true)
                    {
                        Empleado auxEmpleado = new Empleado(txtNickNombreUsuario.Text,
                                                            txtContraseniaUsuario.Text,
                                                            txtNombreUsuario.Text,
                                                            txtApellidoUsuario.Text,
                                                            int.Parse(txtDni.Text),
                                                            double.Parse(txtSueldoUsuario.Text));
                        Empleado.AgregarUsuario(auxEmpleado);
                    }
                    else
                    {
                        MessageBox.Show("Faltan algunos campos por rellenar o son valores no válidos");
                    }
                    break;
                
                case EUsuarios.Administrador:

                    if (!string.IsNullOrWhiteSpace(txtNickNombreUsuario.Text) &&
                                                        !string.IsNullOrWhiteSpace(txtContraseniaUsuario.Text) &&
                                                        !string.IsNullOrWhiteSpace(txtNombreUsuario.Text) &&
                                                        !string.IsNullOrWhiteSpace(txtApellidoUsuario.Text) &&
                                                        int.TryParse(txtDni.Text, out dni) == true &&
                                                        double.TryParse(txtSueldoUsuario.Text, out sueldo) == true)
                    {
                        Administrador auxAdministrador = new Administrador(txtNickNombreUsuario.Text,
                                                        txtContraseniaUsuario.Text,
                                                        txtNombreUsuario.Text,
                                                        txtApellidoUsuario.Text,
                                                        int.Parse(txtDni.Text),
                                                        double.Parse(txtSueldoUsuario.Text), double.Parse(txtBonoAdmin.Text));
                        Empleado.AgregarUsuario(auxAdministrador);
                    }
                    else
                    {
                        MessageBox.Show("Faltan algunos campos por rellenar o son incorrectos");
                    }
                    break;
            }
            SystemSounds.Asterisk.Play();
           
            
            
            this.Close();
        }

        /// <summary>
        /// Cambia la vista según el tipo de usuario que se desea cargar
        /// </summary>
        private void CambiarVistas()
        {
            switch ((EUsuarios)cmbUsuario.SelectedItem)
            {
                case EUsuarios.Administrador:
                    txtBonoAdmin.Visible = true;
                    break;
                case EUsuarios.Empleado:
                    txtBonoAdmin.Visible = false;
                    break;
            }
        }

        private void cmbUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            this.CambiarVistas();
        }

        private void btnCerrarEditarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
