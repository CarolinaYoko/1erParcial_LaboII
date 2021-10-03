using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipoDeProductos
    {
        Alimentos,
        Juguetes,
        Camas,
        Cuidado

    }

    public enum EUsuarios
    {        
        Empleado,
        Administrador

    }

    public static class Petshop
    {
        public static List<Usuario> ListaUsuarios;
        public static List<Cliente> ListaClientes;
        public static Dictionary<Producto, int> ListaProductos;
        static double recaudacionDelDia;

        
                
        static Petshop()
        { 
            Petshop.ListaUsuarios = new List<Usuario>();
            Petshop.ListaClientes = new List<Cliente>();
            Petshop.ListaProductos = new Dictionary<Producto, int>();
            Petshop.recaudacionDelDia = 0;

            CargarUsuarios();
            CargarClientes();
            CargarProductos();

        }

      
        public static double RecaudacionDelDia
        {
            get { return Petshop.recaudacionDelDia; }
            
        }

        private static void CargarUsuarios()
        {
            Empleado e1 = new Empleado("marta", "asd123", "Marta","Rodriguez", 34323323, 40000.00);
            Empleado e2 = new Empleado("jorge", "1234", "Jorge", "Hernandez", 23999000, 50000.00);
            Administrador a1 = new Administrador("gabriel", "qwe123", "Gabriel", "Perez", 3475884, 60000, 2000);
            Administrador a2 = new Administrador("franco", "zxc123", "Franco", "Garcia", 47382992, 70000, 4000);
           

            Petshop.ListaUsuarios.Add(e1);
            Petshop.ListaUsuarios.Add(e2);
            Petshop.ListaUsuarios.Add(a1);
            Petshop.ListaUsuarios.Add(a2);
           
        }
        private static void CargarClientes()
        {
            Cliente c1 = new Cliente("Carolina", "Yokoyama", 42699266, 5000);
            Cliente c2 = new Cliente("Jose", "Perez", 42648826, 7000);

            Petshop.ListaClientes.Add(c1);
            Petshop.ListaClientes.Add(c2);
        }

        private static void CargarProductos()
        {
            Producto p1 = new Producto(ETipoDeProductos.Alimentos, "Royal Caning", 600, "Urinari para gatos 1kg");
            Producto p2 = new Producto(ETipoDeProductos.Alimentos, "Proplan", 500, "Para perros adultos");
            Producto p3 = new Producto(ETipoDeProductos.Alimentos, "Dog Chau", 400, "Para perros adultos");
            Producto p4 = new Producto(ETipoDeProductos.Camas, "Piero Pet", 2300, "Tamaño medio");
            Producto p5 = new Producto(ETipoDeProductos.Camas, "Canon Pet", 2000, "Tamaño chico");
            Producto p6 = new Producto(ETipoDeProductos.Camas, "Cardeusse Pet", 2500, "Tamaño grande");
            Producto p7 = new Producto(ETipoDeProductos.Cuidado, "Shamppoo Burbujas", 300, "Para gatos y perros");
            Producto p8 = new Producto(ETipoDeProductos.Cuidado, "Pipeta", 500, "Para perros con peso > 6 kg ");
            Producto p9 = new Producto(ETipoDeProductos.Cuidado, "Cepillo", 400, "Para gatos");
            Producto p10 = new Producto(ETipoDeProductos.Juguetes, "Pelota", 300, " ");
            Producto p11 = new Producto(ETipoDeProductos.Juguetes, "Rascador FunnyCat", 1500, "Para gatos");

            ListaProductos.Add(p1, 300);
            ListaProductos.Add(p2, 300);
            ListaProductos.Add(p3, 300);
            ListaProductos.Add(p4, 300);
            ListaProductos.Add(p5, 300);
            ListaProductos.Add(p6, 300);
            ListaProductos.Add(p7, 300);
            ListaProductos.Add(p8, 300);
            ListaProductos.Add(p9, 300);
            ListaProductos.Add(p10, 300);
            ListaProductos.Add(p11, 300);


        }


        public static bool DescontarDeStock(int idProducto, int cantidad)
        {
            bool resultado = false;

            foreach (KeyValuePair<Producto, int> producto in Petshop.ListaProductos)
            {
                if (producto.Key.idProducto == idProducto)
                {
                    Petshop.ListaProductos.Remove(producto.Key);
                    Petshop.ListaProductos.Add(producto.Key, producto.Value - cantidad);                    
                    resultado = true;
                    break;
                }
            }                     

            return resultado;

        }

        public static void AumentarRecaudacion(double nuevaVenta)
        {
            Petshop.recaudacionDelDia += nuevaVenta;
        }




    }
}