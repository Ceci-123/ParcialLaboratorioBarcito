using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public static class Bar
    {
        public static string Nombre { get { return "LES UTN"; }  }
        private static List<Persona> personal;
        private static Dictionary<Producto, short> inventario;
        private static List<PuestoDeVenta> puestosDeVenta;
        private static float totalVentaDelDia;

        public static List<PuestoDeVenta> ListaDePuestosDeVenta{ get { return Bar.puestosDeVenta; } }

        public static Dictionary<Producto, short> CosasEnElInventario { get { return Bar.inventario; } }

        static Bar()
        {
            personal = new List<Persona>();
            puestosDeVenta = new List<PuestoDeVenta>();
            inventario = new Dictionary<Producto, short>();
            totalVentaDelDia = 0;
            Harcodeo();
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
            personal.Add(v1);
            personal.Add(v2);
            personal.Add(v3);
            personal.Add(v4);
            //harcodeo productos
            inventario.Add(new Producto("Cerveza", true, 120F),100);
            inventario.Add(new Producto("Coca cola", true, 150F), 100);
            inventario.Add(new Producto("Fernet con coca", true, 200F),100);
            inventario.Add(new Producto("Daiquiri de frutilla", true, 250F),100);
            inventario.Add(new Producto("Manaos de uva", true, 80F),100);
            inventario.Add(new Producto("Tequeños de queso", false, 20F),50);
            inventario.Add(new Producto("Papas fritas con cheddar", false, 180F),50);
            inventario.Add(new Producto("Hamburguesa de soja con tomate,lechuga y queso", false, 250F),50);
            inventario.Add(new Producto("Empanadas", false, 80F), 50);
            inventario.Add(new Producto("Picadita", false,300F), 50);
            //abro las mesas y barras
            PuestoDeVenta puesto1 = new PuestoDeVenta("Mesa 1", false);
            PuestoDeVenta puesto2 = new PuestoDeVenta("Mesa 2", false);
            PuestoDeVenta puesto3 = new PuestoDeVenta("Mesa 3", false);
            PuestoDeVenta puesto4 = new PuestoDeVenta("Mesa 4", false);
            PuestoDeVenta puesto5 = new PuestoDeVenta("Mesa 5", false);
            PuestoDeVenta puesto6 = new PuestoDeVenta("Mesa 6", false);
            PuestoDeVenta puesto7 = new PuestoDeVenta("Mesa 7", false);
            PuestoDeVenta puesto8 = new PuestoDeVenta("Mesa 8", false);
            PuestoDeVenta puesto9 = new PuestoDeVenta("Mesa 9", false);
            PuestoDeVenta puesto10 = new PuestoDeVenta("Mesa 10", false);
            PuestoDeVenta puesto11 = new PuestoDeVenta("Mesa 11", false);
            PuestoDeVenta puesto12 = new PuestoDeVenta("Mesa 12", false);
            PuestoDeVenta puesto13 = new PuestoDeVenta("Mesa 13", false);
            PuestoDeVenta puesto14 = new PuestoDeVenta("Mesa 14", false);
            PuestoDeVenta puesto15 = new PuestoDeVenta("Mesa 15", false);
            PuestoDeVenta puesto16 = new PuestoDeVenta("Barra 1", true);
            PuestoDeVenta puesto17 = new PuestoDeVenta("Barra 2", true);
            PuestoDeVenta puesto18 = new PuestoDeVenta("Barra 3", true);
            PuestoDeVenta puesto19 = new PuestoDeVenta("Barra 4", true);
            PuestoDeVenta puesto20 = new PuestoDeVenta("Barra 5", true);
           
            puestosDeVenta.Add(puesto1);
            puestosDeVenta.Add(puesto2);
            puestosDeVenta.Add(puesto3);
            puestosDeVenta.Add(puesto4);
            puestosDeVenta.Add(puesto5);
            puestosDeVenta.Add(puesto6);
            puestosDeVenta.Add(puesto7);
            puestosDeVenta.Add(puesto8);
            puestosDeVenta.Add(puesto9);
            puestosDeVenta.Add(puesto10);
            puestosDeVenta.Add(puesto11);
            puestosDeVenta.Add(puesto12);
            puestosDeVenta.Add(puesto13);
            puestosDeVenta.Add(puesto14);
            puestosDeVenta.Add(puesto15);
            puestosDeVenta.Add(puesto16);
            puestosDeVenta.Add(puesto17);
            puestosDeVenta.Add(puesto18);
            puestosDeVenta.Add(puesto19);
            puestosDeVenta.Add(puesto20);

        }

              
        public static string BuscarSitioLibre()
        {
            string retorno = "No hay lugares disponibles en el bar";
            foreach (PuestoDeVenta item in puestosDeVenta)
            {
                if(item.estaLibre == true)
                {
                    retorno = $"Disponible la {item.Nombre} ";
                    break;
                }
            }
            return retorno;
        }

        
        public static float FacturacionDelDia()
        {
            short suma = 0;
            foreach (PuestoDeVenta item in puestosDeVenta)
            {
                foreach (KeyValuePair<Producto, short> par in item.consumicion)
                {
                    suma += ((short)par.Value);
                }
            }
            return (float)suma;
        }
        public static string MostrarInventario()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----INVENTARIO----");
            
            foreach (KeyValuePair<Producto, short> item in inventario)
            {
                sb.AppendLine($"Producto {item.Key.Mostrar()}  ");
                sb.AppendLine($"Cantidad en stock {item.Value.ToString()}  ");
                sb.AppendLine("-----------------------");
            }
            return sb.ToString();
        }

        internal static bool ControlarSiHayStock(Producto unProducto)
        {
            bool resultado = false;
            foreach (KeyValuePair<Producto, short> item in inventario)
            {
                if(item.Key == unProducto && item.Value > 1)
                {
                    resultado = true;
                }

            }
            return resultado;
        }
        public static string MostrarPersonal()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Persona item in personal)
            {
                sb.Append(item.Nombre);
                if(item is Vendedor)
                {
                    sb.AppendLine(" - Vendedor");
                }
                if (item is Administrador)
                {
                    sb.AppendLine(" - Administrador");
                }
            }
            return sb.ToString();
        }

        public static void AgregarMercaderia(Producto unProducto, short cantidad)
        {
            inventario.Add(unProducto, cantidad);
        }
    }
}
