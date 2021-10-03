using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        string nombre;
        string apellido;
        long telefono;
        double saldo;
        bool clienteActivo = true;
        int idCliente;
        static int ultimoId;


        /// <summary>
        /// Propiedad con get del atributo idCliente
        /// </summary>
        public int IdCliente
        {
            get { return this.idCliente; }

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
        /// Propiedad con get y set del atributo telefono
        /// </summary>
        public long Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        /// <summary>
        /// Propiedad con get y set del atributo saldo
        /// </summary>
        public double Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }

        /// <summary>
        /// Propiedad con get y set del atributo clienteActivo
        /// </summary>
        public bool ClienteActivo
        {
            get { return this.clienteActivo; }
            set { this.clienteActivo = value; }
        }


        /// <summary>
        /// Inicializa el ID autoincremental del cliente en 0
        /// </summary>
        static Cliente()
        {
            Cliente.ultimoId = 0;
        }

        /// <summary>
        /// Construye un cliente a partir de nombre, apellido, teledono y saldo
        /// </summary>
        /// <param name="auxNombre"></param>
        /// <param name="auxApellido"></param>
        /// <param name="auxTelefono"></param>
        /// <param name="auxSaldo"></param>
        public Cliente(string auxNombre, string auxApellido, long auxTelefono, double auxSaldo)
        {
            this.Nombre = auxNombre;
            this.Apellido = auxApellido;
            this.telefono = auxTelefono;
            this.Saldo = auxSaldo;
            this.ClienteActivo = true;
            this.idCliente = Cliente.ultimoId;
            Cliente.ultimoId++;

        }

        /// <summary>
        /// Agrega un cliente al la lista de clientes
        /// </summary>
        /// <param name="auxCliente"></param>
        /// <returns></returns>
        public static bool AgregarCliente(Cliente auxCliente)
        {
            bool resultado;

            if (auxCliente is not null)
            {
                Petshop.ListaClientes.Add(auxCliente);
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;

        }

        /// <summary>
        /// Edita los campos de un cliente
        /// </summary>
        /// <param name="auxCliente"></param>
        public static void EditarCliente(Cliente auxCliente)
        {
            foreach (Cliente cliente in Petshop.ListaClientes)
            {
                if (cliente.idCliente == auxCliente.idCliente)
                {
                    cliente.Nombre = auxCliente.Nombre;
                    cliente.Apellido = auxCliente.Apellido;
                    cliente.Telefono = auxCliente.Telefono;
                    cliente.Saldo = auxCliente.Saldo;

                    break;
                }

            }

        }

        /// <summary>
        /// Busca un cliente por ID y lo retorna
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns>Cliente si lo encuentra, sino null</returns>
        public static Cliente BuscarClientePorId(int idCliente)
        {
            Cliente auxCliente = null;
            foreach (Cliente cliente in Petshop.ListaClientes)
            {
                if (cliente.idCliente == idCliente)
                {
                    auxCliente = cliente;
                    break;
                }

            }

            return auxCliente;

        }

        /// <summary>
        /// Elimina un cliente de la lista de clientes
        /// </summary>
        /// <param name="auxCliente"></param>
        public static void EliminarCliente(Cliente auxCliente)
        {
            foreach (Cliente cliente in Petshop.ListaClientes)
            {
                if (cliente == auxCliente)
                {
                    cliente.ClienteActivo = false;
                    break;
                }
            }

        }

        /// <summary>
        /// Resta el dinero utilizado para efectuar la compra
        /// </summary>
        /// <param name="dinero"></param>
        public void DescontarSaldo(double dinero)
        {
            this.Saldo -= dinero;
        }

        /// <summary>
        /// Sobrecarga el == comparar la referencia de los objetos 
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns>true si son iguales, sino false</returns>
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool resultado = false;

            if (c1 is not null && c2 is not null && c1.Nombre == c2.Nombre && c1.Apellido == c2.Apellido && c1.Saldo == c2.Saldo && c1.Telefono == c2.Telefono && c1.ClienteActivo == c2.ClienteActivo)
            {
                resultado = true;
            }

            return resultado;
        }

        /// <summary>
        /// Sobrecarga el != comparar la referencia de los objetos 
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns>true si son distintos, sino false</returns>
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);

        }

        /// <summary>
        /// Compara los valores de los objetos
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>true si son iguales, sino false</returns>
        public override bool Equals(Object cliente)
        {
            return this == (Cliente)cliente;
        }

        /// <summary>
        /// Clave para identificar un objeto Usuario
        /// </summary>
        /// <returns>un código int</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



    }
}
