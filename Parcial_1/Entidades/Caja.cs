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

        /// <summary>
        /// Construya una caja con su lista de productos obtenidos de la seleccion
        /// </summary>
        static Caja()
        {
            Caja.ListaProductosComprados = new Dictionary<Producto, int>();
        }

        /// <summary>
        /// Verifica si hay Stock del producto según la cantidad pretendida
        /// </summary>
        /// <param name="auxProducto"></param>
        /// <param name="auxCantidadProducto"></param>
        /// <returns>true si hay suficiente, sino false </returns>
        public static bool VerificarStock(Producto auxProducto, int auxCantidadProducto)
        {
            bool resultado = false;

            if ((int)auxProducto > 0)
            {
                if ((int)auxProducto > auxCantidadProducto)
                {
                    resultado = true;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Verifica si el saldo del clienta es suficiente para cubri el precio total de la compra
        /// </summary>
        /// <param name="auxCliente"></param>
        /// <param name="precioTotal"></param>
        /// <returns>true si es suficiente, sino false</returns>
        public static bool VerificarSaldo(Cliente auxCliente, double precioTotal)
        {
            bool saldoOptimo = false;

            if (precioTotal < auxCliente.Saldo)
            {
                saldoOptimo = true;
            }

            return saldoOptimo;
        }
        
        /// <summary>
        /// Agrega un producto a la lista de productos a comprar
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public static bool AgregarAlCarrito(Producto producto, int cantidad)
        {
            bool resultado = false;

            if (producto != null && cantidad > 0 && VerificarStock(producto, cantidad))
            {
                ListaProductosComprados.Add(producto, cantidad);
                resultado = true;
            }
            return resultado;
        }

    }
}
