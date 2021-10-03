using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int idProducto;
        public static int ultimoIdProducto;
        public Enum tipoDeProducto;
        public string nombre;
        public string descripcion;
        public float precio;
        public int stock;

        /// <summary>
        /// Inicializa el ID autoincremental del producto.
        /// </summary>
        static void IdProducto()
        {
            Producto.ultimoIdProducto = 0;
        }

        /// <summary>
        /// Contruye un Producto con su tipo, nombre y precio.
        /// </summary>
        /// <param name="tipoDeProducto"></param>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        public Producto(Enum tipoDeProducto, string nombre, float precio)
        {
            this.tipoDeProducto = tipoDeProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = " ";
            this.idProducto = ultimoIdProducto;
            Producto.ultimoIdProducto++;

        }

        /// <summary>
        /// Construye un Producto con su tipo, nombre, precio y descripcion.
        /// </summary>
        /// <param name="tipoDeProducto"></param>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="descripcion"></param>
        public Producto(Enum tipoDeProducto, string nombre, float precio, string descripcion) : this(tipoDeProducto, nombre, precio)
        {
            this.descripcion = descripcion;
        }


        /// <summary>
        /// Busca el producto a partir del ID y lo devuelve.
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns> Retorna el Producto si lo encontró, sino null </returns>
        public static Producto BuscarProductoPorId(int idProducto)
        {
            Producto auxProducto = null;

            foreach (KeyValuePair<Producto, int> producto in Petshop.ListaProductos)
            {
                if (producto.Key.idProducto == idProducto)
                {
                    auxProducto = producto.Key;
                    break;
                }
            }
            return auxProducto;
        }


        /// <summary>
        /// Convierte de manera explicita un objeto de tipo Producto a int que representa el Stock actual del producto.
        /// </summary>
        /// <param name="auxProducto"></param>
        public static explicit operator int(Producto auxProducto)
        {
            int stock = -1;

            foreach (KeyValuePair<Producto, int> producto in Petshop.ListaProductos)
            {
                if (producto.Key.idProducto == auxProducto.idProducto)
                {
                    stock = producto.Value;
                    break;
                }                
            }

            return stock;
        }
                
    }
}
