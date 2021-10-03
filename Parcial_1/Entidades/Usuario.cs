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


        static Usuario()
        {
            Usuario.ultimoId = 0;
        }
             

        public bool UsuarioActivo
        {
            get { return this.usuarioActivo; }
            set { this.usuarioActivo = value; }
        }

        public int IDUsuario
        {
            get { return this.idUsuario; }            
        }
               
        public string NickNombreUsuario
        {
            get { return this.nombreUsuario; }
            set { this.nombreUsuario = value; }
        }
                        
        public string Contrasenia 
        {
            get { return this.contrasenia; }
            set { this.contrasenia = value;} 
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public int DNI
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
               

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


        public abstract void EditarUsuario();

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


        public static bool operator ==(Usuario u1, Usuario u2)
        {
            bool resultado = false;

            if (u1 is not null && u2 is not null && u1.idUsuario == u2.idUsuario)
            {
                resultado = true;
            }

            return resultado;
        }

        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);

        }

        public override bool Equals(object usuario)
        {
            return this == (Usuario)usuario;
        }

        


    }
}
