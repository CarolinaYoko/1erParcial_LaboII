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
        public Administrador(string nombreUsuario, string contrasenia, string nombre, string apellido, int dni, double sueldo, double bono) : base(nombreUsuario, contrasenia, nombre, apellido, dni, sueldo)
        {
            this.Bono = bono;
        }

        public double Bono
        {
            get { return this.bono; }
            set { this.bono = value; }
        }

        public override void EditarUsuario()
        {            
            foreach (Administrador admin in Petshop.ListaUsuarios)
            {
                if (admin.IDUsuario == this.IDUsuario)
                {
                    admin.NickNombreUsuario = this.NickNombreUsuario;
                    admin.Contrasenia = this.Contrasenia;
                    admin.DNI = this.DNI;
                    admin.Nombre = this.Nombre;
                    admin.Apellido = this.Apellido;
                    admin.Sueldo = this.Sueldo;
                    admin.Bono = this.Bono;
                    break;
                }
            }

        }

        

    }
}
