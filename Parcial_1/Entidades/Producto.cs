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


        public Producto(Enum tipoDeProducto, string nombre, float precio)
        {
            this.tipoDeProducto = tipoDeProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = "";
            this.idProducto = ultimoIdProducto;
            Producto.ultimoIdProducto++;

        }

        public Producto(Enum tipoDeProducto, string nombre, float precio, string descripcion) : this(tipoDeProducto, nombre, precio)
        {
            this.descripcion = descripcion;
        }


        static void IdProducto()
        {
            Producto.ultimoIdProducto = 0;
        }

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
