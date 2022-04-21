using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class Bar
    {
        public static string Nombre { get { return "LES UTN"; }  }
        public static List<Persona> personal;
        public static Dictionary<Producto, short> inventario;
        public static List<Sitio> puestosDeVenta;
        
        static Bar()
        {
            personal = new List<Persona>();
            puestosDeVenta = new List<Sitio>();
        }

        public static void Harcodeo()
        {
            //harcodeo 1 admin y 4 vendedores
            Administrador a1 = new Administrador("mauricio", "mauri123");
            personal.Add(a1);
            Vendedor v1 = new Vendedor("lucas", "lucas123");
            Vendedor v2 = new Vendedor("lautaro", "lauti123");
            Vendedor v3 = new Vendedor("cecilia", "ceci123");
            Vendedor v4 = new Vendedor("morena", "more123");
            personal.Add(v2);
            personal.Add(v2);
            personal.Add(v3);
            personal.Add(v4);
            //harcodeo productos
            inventario = new Dictionary<Producto, short>();
            inventario.Add(new Producto("Cerveza", true),100);
            inventario.Add(new Producto("Coca cola", true),100);
            inventario.Add(new Producto("Fernet con coca", true),100);
            inventario.Add(new Producto("Daiquiri de frutilla", true),100);
            inventario.Add(new Producto("Manaos de uva", true),100);
            inventario.Add(new Producto("Tequeños de queso", false),50);
            inventario.Add(new Producto("Papas fritas con cheddar", false),50);
            inventario.Add(new Producto("Hamburguesa de soja con tomate,lechuga y queso", false),50);
            inventario.Add(new Producto("Empanadas", false), 50);
            inventario.Add(new Producto("Picadita", false), 50);
            //abro las mesas y barras
            Mesa mesa1 = new Mesa(true, "Mesa 1");
            Mesa mesa2 = new Mesa(true, "Mesa 2");
            Mesa mesa3 = new Mesa(true, "Mesa 3");
            Mesa mesa4 = new Mesa(true, "Mesa 4");
            Mesa mesa5 = new Mesa(true, "Mesa 5");
            Mesa mesa6 = new Mesa(true, "Mesa 6");
            Mesa mesa7 = new Mesa(true, "Mesa 7");
            Mesa mesa8 = new Mesa(true, "Mesa 8");
            Mesa mesa9 = new Mesa(true, "Mesa 9");
            Mesa mesa10 = new Mesa(true, "Mesa 10");
            Mesa mesa11 = new Mesa(true, "Mesa 11");
            Mesa mesa12 = new Mesa(true, "Mesa 12");
            Mesa mesa13 = new Mesa(true, "Mesa 13");
            Mesa mesa14 = new Mesa(true, "Mesa 14");
            Mesa mesa15 = new Mesa(true, "Mesa 15");
            Barra barra1 = new Barra(true, "Barra 1");
            Barra barra2 = new Barra(true, "Barra 2");
            Barra barra3 = new Barra(true, "Barra 3");
            Barra barra4 = new Barra(true, "Barra 4");
            Barra barra5 = new Barra(true, "Barra 5");
            puestosDeVenta.Add(mesa1);
            puestosDeVenta.Add(mesa2);
            puestosDeVenta.Add(mesa3);
            puestosDeVenta.Add(mesa4);
            puestosDeVenta.Add(mesa5);
            puestosDeVenta.Add(mesa6);
            puestosDeVenta.Add(mesa7);
            puestosDeVenta.Add(mesa8);
            puestosDeVenta.Add(mesa9);
            puestosDeVenta.Add(mesa10);
            puestosDeVenta.Add(mesa11);
            puestosDeVenta.Add(mesa12);
            puestosDeVenta.Add(mesa13);
            puestosDeVenta.Add(mesa14);
            puestosDeVenta.Add(mesa15);
            puestosDeVenta.Add(barra1);
            puestosDeVenta.Add(barra2);
            puestosDeVenta.Add(barra3);
            puestosDeVenta.Add(barra4);
            puestosDeVenta.Add(barra5);

        }

        public static Dictionary<Producto,short> Venta(Sitio unSitio, Producto producto,
            Dictionary<Producto, short> inventario)
        {
            unSitio.consumicion.Add(producto);
            
            for (int i = 0; i <inventario.Count; i++)
            {
                inventario[producto]--;
            }
            return inventario;
        }
        public static string BuscarSitioLibre()
        {
            string retorno = "No hay lugares disponibles en el bar";
            foreach (Sitio item in puestosDeVenta)
            {
                if(item.estaLibre == true)
                {
                    retorno = $"Tenemos disponible la {item.Nombre} ";
                    
                }
            }
            return retorno;
        }

    }
}
