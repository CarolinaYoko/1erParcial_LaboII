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

        /// <summary>
        /// Construye un Empleado a partir del constructor de Usuario y agregando el atributo sueldo
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contrasenia"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="sueldo"></param>
        public Empleado(string nombreUsuario, string contrasenia, string nombre, string apellido, int dni, double sueldo) : base (nombreUsuario, contrasenia, nombre, apellido, dni)
        {
            this.sueldo = sueldo;
        }
               
        /// <summary>
        /// Propiedad get y set del atributo sueldo
        /// </summary>
        public double Sueldo
        {
            get { return this.sueldo; }
            set { this.sueldo = value; }
        }

        /// <summary>
        /// Define el metodo que edita los campos del Usuario
        /// </summary>
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

        /// <summary>
        /// Busca un empleado por ID y lo retorna
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns>Empleado si lo encuentra, sino null</returns>
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

        /// <summary>
        /// Agrega un usuario a la lista
        /// </summary>
        /// <param name="auxUsuario"></param>
        /// <returns>true si lo logra, sino false</returns>
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

        /// <summary>
        /// Filtra los usuarios de tipo administrador y los guarda en una lista
        /// </summary>
        /// <returns> Lista de usuarios de tipo Empleado</returns>
        public static List<Usuario> FiltrarEmpleados()
        {
            List<Usuario> auxLista = new List<Usuario>();

            foreach (Usuario usuario in Petshop.ListaUsuarios)
            {
                if (usuario.GetType() == typeof(Empleado))
                {
                    auxLista.Add(usuario);
                }
            }
            return auxLista;
        }
    }
}
