using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public static class Bar
    {
        public static string Nombre { get { return "LES UTN"; } }
        private static List<Persona> personal;
        private static Dictionary<Producto, short> inventario;
        private static List<PuestoDeVenta> puestosDeVenta;
        private static float totalVentaDelDia;

        public static List<PuestoDeVenta> ListaDePuestosDeVenta { get { return Bar.puestosDeVenta; } }

        public static Dictionary<Producto, short> CosasEnElInventario { get { return Bar.inventario; } }

        public static List<Persona> ListadoDePersonal { get { return Bar.personal; } }

        public static float TotalVentaDelDia { get; set; }


        static Bar()
        {
            personal = new List<Persona>();
            puestosDeVenta = new List<PuestoDeVenta>();
            inventario = new Dictionary<Producto, short>();
            totalVentaDelDia = 0;
            Harcodear();
        }

        public static float SumarConsumicion(string cualPuesto)
        {
            //TODO
            return 10F;
        }

        public static float CalcularTarjeta(float totalPesos)
        {
            //TODO
            return 10F;
        }

        public static float CalcularEstacionamiento(float totalPesos)
        {
            throw new NotImplementedException();
        }

        public static float Descuentos(float totalPesos, int v)
        {
            throw new NotImplementedException();
        }



        public static void Harcodear()
        {
            //harcodeo 1 admin y 4 vendedores
            personal.Add(new Administrador("mauricio", "mauri123"));
            personal.Add(new Vendedor("lucas", "lucas123"));
            personal.Add(new Vendedor("lautaro", "lauti123"));
            personal.Add(new Vendedor("cecilia", "ceci123"));
            personal.Add(new Vendedor("morena", "more123"));
            //harcodeo productos
            inventario.Add(new Producto("Cerveza", true, 120F), 100);
            inventario.Add(new Producto("Cocacola", true, 150F), 100);
            inventario.Add(new Producto("Fernet", true, 200F), 100);
            inventario.Add(new Producto("Daiquiri", true, 250F), 100);
            inventario.Add(new Producto("Manaos", true, 80F), 100);
            inventario.Add(new Producto("Tequeños", false, 20F), 50);
            inventario.Add(new Producto("Papasfritas", false, 180F), 50);
            inventario.Add(new Producto("Hamburguesa", false, 250F), 50);
            inventario.Add(new Producto("Empanadas", false, 80F), 50);
            inventario.Add(new Producto("Picadita", false, 300F), 50);
            //abro las mesas y barras

            puestosDeVenta.Add(new PuestoDeVenta("Mesa 1", false));
            puestosDeVenta.Add(new PuestoDeVenta("Mesa 2", false));
            puestosDeVenta.Add(new PuestoDeVenta("Mesa 3", false));
            puestosDeVenta.Add(new PuestoDeVenta("Mesa 4", false));
            puestosDeVenta.Add(new PuestoDeVenta("Mesa 5", false));
            puestosDeVenta.Add(new PuestoDeVenta("Mesa 6", false));
            puestosDeVenta.Add(new PuestoDeVenta("Mesa 7", false));
            puestosDeVenta.Add(new PuestoDeVenta("Mesa 8", false));
            puestosDeVenta.Add(new PuestoDeVenta("Mesa 9", false));
            puestosDeVenta.Add(new PuestoDeVenta("Mesa 10", false));
            puestosDeVenta.Add(new PuestoDeVenta("Mesa 11", false));
            puestosDeVenta.Add(new PuestoDeVenta("Mesa 12", false));
            puestosDeVenta.Add(new PuestoDeVenta("Mesa 13", false));
            puestosDeVenta.Add(new PuestoDeVenta("Mesa 14", false));
            puestosDeVenta.Add(new PuestoDeVenta("Mesa 15", false));
            puestosDeVenta.Add(new PuestoDeVenta("Barra 1", true));
            puestosDeVenta.Add(new PuestoDeVenta("Barra 2", true));
            puestosDeVenta.Add(new PuestoDeVenta("Barra 3", true));
            puestosDeVenta.Add(new PuestoDeVenta("Barra 4", true));
            puestosDeVenta.Add(new PuestoDeVenta("Barra 5", true));

        }

        public static void ImprimirTicket(float totalPesos, bool checked1, bool checked2, bool checked3)
        {
            throw new NotImplementedException();
        }

        public static string MostrarConsumiciones(string numeroPuesto)
        {
            return "listado aqui";
        }

        public static string BuscarSitioLibre()
        {
            StringBuilder sb = new StringBuilder();
            string retorno = "No hay lugares disponibles en el bar";
            foreach (PuestoDeVenta item in puestosDeVenta)
            {
                if (item.estaLibre == true)
                {
                    sb.Append($"Disponible la {item.Nombre}\n");

                    retorno = sb.ToString();

                }
            }
            return retorno;
        }


        public static float CalcularFacturacionDelDia()
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
                if (item.Key == unProducto && item.Value > 1)
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
                if (item is Vendedor)
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

        public static void AgregarMercaderia(string nombre, bool esBebida, float precio, bool esVegan, bool esAptoCeliaquia, short cantidad)
        {
            Producto unProducto = new Producto(nombre, esBebida, precio, esVegan, esAptoCeliaquia);
            inventario.Add(unProducto, cantidad);
        }
        public static void Venta(string aDonde, string queCosa, string cantidad)
        {
            if (!String.IsNullOrEmpty(aDonde))
            {
                foreach (PuestoDeVenta item in Bar.ListaDePuestosDeVenta)
                {
                    if (item.Nombre == aDonde)
                    {
                        short.TryParse(cantidad, out short cantidadNumerica);
                        //item.AgregarConsumicion(producto,cantidadNumerica,Bar.CosasEnElInventario);
                    }
                }
            }
        }

    }
}
