using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Usuario
    {
        private int idUsuario;
        private string nombreUsuario;
        private string contrasenia;
        private string nombre;
        private string apellido;
        private int dni;
        private bool usuarioActivo;
        static int ultimoId;

        /// <summary>
        /// Inicializa el ID autoincremental del Usuario
        /// </summary>
        static Usuario()
        {
            Usuario.ultimoId = 0;
        }
           
        /// <summary>
        /// Propiedad con get y set del atributo usuarioActivo
        /// </summary>
        public bool UsuarioActivo
        {
            get { return this.usuarioActivo; }
            set { this.usuarioActivo = value; }
        }

        /// <summary>
        /// Propiedad con get del atributo IdUsuario
        /// </summary>
        public int IDUsuario
        {
            get { return this.idUsuario; }            
        }
               
        /// <summary>
        /// Propiedad con get y set del atributo nombreUsuario 
        /// </summary>
        public string NickNombreUsuario
        {
            get { return this.nombreUsuario; }
            set { this.nombreUsuario = value; }
        }
                
        /// <summary>
        /// Propiedad con get y set del atributo contrasenia
        /// </summary>
        public string Contrasenia 
        {
            get { return this.contrasenia; }
            set { this.contrasenia = value;} 
        }

        /// <summary>
        /// Propiedad con get y set del atributo nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        /// <summary>
        /// Propiedad con get y set del atributo apellido
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        /// <summary>
        /// Propiedad con get y set del atributo dni
        /// </summary>
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = value; }
        }       


        /// <summary>
        /// Construye un usuario de la applicación cargando nickname, contraseña, nombre, apellido y DNI
        /// </summary>
        /// <param name="auxNombreUsuario"></param>
        /// <param name="auxContrasenia"></param>
        /// <param name="auxNombre"></param>
        /// <param name="auxApellido"></param>
        /// <param name="auxDni"></param>
        public Usuario(string auxNombreUsuario, string auxContrasenia, string auxNombre, string auxApellido, int auxDni)
        {
            this.NickNombreUsuario = auxNombreUsuario;
            this.Contrasenia = auxContrasenia;
            this.Nombre = auxNombre;
            this.Apellido = auxApellido;
            this.DNI = auxDni;
            this.UsuarioActivo = true;
            this.idUsuario = Usuario.ultimoId;
            Usuario.ultimoId++;

        }

        
        /// <summary>
        /// Valida que los campos ingresados correspondan a los registrados en la aplicación
        /// </summary>
        /// <param name="auxUsuario"></param>
        /// <param name="auxContrasenia"></param>
        /// <returns> Si existen los datos devuelve un usuario, sino null </returns>
        public static Usuario ValidarUsuario(string auxUsuario, string auxContrasenia)
        {
            Usuario usuarioLogueado = null;

            foreach (Usuario itemUsuario in Petshop.ListaUsuarios)          
            {                     
                if(itemUsuario.nombre == auxUsuario && itemUsuario.contrasenia == auxContrasenia) 
                {
                    usuarioLogueado = itemUsuario;
                    break;
                }
            }
            
            return usuarioLogueado;
        }

        /// <summary>
        /// Editará un miembro de la clase Usuario
        /// </summary>
        public abstract void EditarUsuario();

        /// <summary>
        /// Eliminará de la lista de Usuarios el usuario pasado por parametro
        /// </summary>
        /// <param name="auxUsuario"></param>
        public static void EliminarUsuario(Usuario auxUsuario)
        {
            foreach (Usuario usuario in Petshop.ListaUsuarios)
            {
                if (usuario == auxUsuario)
                {
                    usuario.UsuarioActivo = false;
                    break;
                }
            }

        }

        /// <summary>
        /// Sobrecarga el == para comparar la referencia de los objetos 
        /// </summary>
        /// <param name="u1"></param>
        /// <param name="u2"></param>
        /// <returns> true si son iguales, sino false </returns>
        public static bool operator ==(Usuario u1, Usuario u2)
        {
            bool resultado = false;

            if (u1 is not null && u2 is not null && u1.idUsuario == u2.idUsuario)
            {
                resultado = true;
            }

            return resultado;
        }

        /// <summary>
        /// Sobrecarga el != para comparar la referencia de los objetos 
        /// </summary>
        /// <param name="u1"></param>
        /// <param name="u2"></param>
        /// <returns>true si son distintos, sino false</returns>
        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);

        }

        /// <summary>
        /// Compara los valores de los objetos
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>true si son iguales, sino false</returns>
        public override bool Equals(object usuario)
        {
            return this == (Usuario)usuario;
        }

        /// <summary>
        /// Clave para identificar un objeto Usuario
        /// </summary>
        /// <returns> un codigo int</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
