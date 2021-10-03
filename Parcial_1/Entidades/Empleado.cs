using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Usuario
    {
        private double sueldo;

        public Empleado(string nombreUsuario, string contrasenia, string nombre, string apellido, int dni, double sueldo) : base (nombreUsuario, contrasenia, nombre, apellido, dni)
        {
            this.sueldo = sueldo;
        }
               

        public double Sueldo
        {
            get { return this.sueldo; }
            set { this.sueldo = value; }
        }


       public override void EditarUsuario()
        {
            foreach (Usuario usuario in Petshop.ListaUsuarios)
            {
                if (usuario.IDUsuario == this.IDUsuario)
                {

                    usuario.NickNombreUsuario = this.NickNombreUsuario;
                    usuario.Contrasenia = this.Contrasenia;
                    usuario.DNI = this.DNI;
                    usuario.Nombre = this.Nombre;
                    usuario.Apellido = this.Apellido;
                    ((Empleado)usuario).Sueldo = this.Sueldo;

                    break;
                }

            }

        }                       

        public static Empleado BuscarEmpleadoPorId(int idEmpleado)
        {
            Empleado auxEmpleado = null;

            foreach (Empleado empleado in Petshop.ListaUsuarios)
            {
                if (empleado.IDUsuario == idEmpleado)
                {
                    auxEmpleado = empleado;
                    break;
                }
            }

            return auxEmpleado;
        }

        public static bool AgregarUsuario(Usuario auxUsuario)
        {
            bool resultado;

            if (auxUsuario is not null)
            {
                Petshop.ListaUsuarios.Add(auxUsuario);
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;

        }

        


    }
}
