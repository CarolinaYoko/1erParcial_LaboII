using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Caja
    {
        
        static Dictionary<Producto, int> ListaProductosComprados;

        static Caja()
        {
            Caja.ListaProductosComprados = new Dictionary<Producto, int>();
        }

        public static bool VerificarStock(Producto auxProducto, int auxCantidadProducto)
        {                     
            bool resultado = false;

            if((int)auxProducto > 0)
            {
                if ((int)auxProducto > auxCantidadProducto)
                {
                   resultado = true;
                }                 
            }                                   

            return resultado;

        }

        public static bool VerificarSaldo(Cliente auxCliente, double precioTotal)
        {
            bool saldoOptimo = false;

            if (precioTotal < auxCliente.Saldo)
            {
                saldoOptimo = true;
            }

            return saldoOptimo;
        }

        public static double VerSaldoFinal(Cliente auxCliente , double precioTotal)
        {       
            
            return auxCliente.Saldo - precioTotal;

        }

        public static bool AgregarAlCarrito(Producto producto, int cantidad)
        {
            bool resultado = false;
            
            if(producto != null && cantidad > 0 && VerificarStock(producto, cantidad))
            {
                ListaProductosComprados.Add(producto, cantidad);
                resultado = true;
            }
            return resultado;
        }

        





    }
}
