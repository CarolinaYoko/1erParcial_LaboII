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
      
        
        public int IdCliente
        {
            get { return this.idCliente; }
            
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

        public long Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public double Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }

        public bool ClienteActivo
        {
            get { return this.clienteActivo; }
            set { this.clienteActivo = value; }
        }
                     


        static Cliente()
        {
            Cliente.ultimoId = 0;
        }


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


        public void DescontarSaldo(double dinero)
        {
            this.Saldo -= dinero;
        }
             

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool resultado = false;

            if (c1 is not null && c2 is not null && c1.Nombre == c2.Nombre && c1.Apellido == c2.Apellido && c1.Saldo==c2.Saldo && c1.Telefono == c2.Telefono && c1.ClienteActivo == c2.ClienteActivo )
            {
                 resultado = true;
            }

            return resultado;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);

        }

        public override bool Equals(Object cliente)
        {
            return this == (Cliente)cliente;    
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }



    }
}
