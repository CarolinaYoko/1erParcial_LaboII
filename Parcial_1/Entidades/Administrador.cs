﻿using System;
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
