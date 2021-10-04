using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Empleado
    {
        double bono;

        /// <summary>
        /// Construye un Administrador a partir de del constructor de Empleado agregando el atributo bono
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contrasenia"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="sueldo"></param>
        /// <param name="bono"></param>
        public Administrador(string nombreUsuario, string contrasenia, string nombre, string apellido, int dni, double sueldo, double bono) : base(nombreUsuario, contrasenia, nombre, apellido, dni, sueldo)
        {
            this.Bono = bono;
        }

        /// <summary>
        /// Propiedad get y set del atributo bono
        /// </summary>
        public double Bono
        {
            get { return this.bono; }
            set { this.bono = value; }
        }

        /// <summary>
        /// Define el metodo que edita los campos del Administrador
        /// </summary>
        public override void EditarUsuario()
        {            
            foreach (Usuario admin in Petshop.ListaUsuarios)
            {
                if (admin is Administrador  && ((Administrador)admin).IDUsuario == this.IDUsuario)
                {
                    admin.NickNombreUsuario = this.NickNombreUsuario;
                    admin.Contrasenia = this.Contrasenia;
                    admin.DNI = this.DNI;
                    admin.Nombre = this.Nombre;
                    admin.Apellido = this.Apellido;
                    ((Administrador)admin).Sueldo = this.Sueldo;
                    ((Administrador)admin).Bono = this.Bono;
                    break;
                }
            }

        }

        /// <summary>
        /// Filtra los usuarios de tipo administrador y los guarda en una lista
        /// </summary>
        /// <returns>lista de usuarios de tipo empleado</returns>
        public static List<Usuario> FiltrarAdministradores()
        {
            List<Usuario> auxLista = new List<Usuario>();

            foreach (Usuario usuario in Petshop.ListaUsuarios)
            {
                if (usuario.GetType() == typeof(Administrador))
                {
                    auxLista.Add(usuario);
                }
            }

            return auxLista;

        }

    }
}
