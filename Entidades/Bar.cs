﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public static class Bar
    {
        public static string Nombre { get { return "LES UTN"; }  }
        public static List<Persona> personal;
        public static Dictionary<Producto, short> inventario;
        private static List<Sitio> puestosDeVenta;
        public static float totalVentaDelDia;

        public static List<Sitio> ListaDePuestosDeVenta{ get { return Bar.puestosDeVenta; } }

        public static Dictionary<Producto, short> CosasEnElInventario { get { return Bar.inventario; } }

        static Bar()
        {
            personal = new List<Persona>();
            puestosDeVenta = new List<Sitio>();
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
            inventario = new Dictionary<Producto, short>();
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
            Mesa mesa1 = new Mesa("Mesa 1");
            Mesa mesa2 = new Mesa("Mesa 2");
            Mesa mesa3 = new Mesa("Mesa 3");
            Mesa mesa4 = new Mesa("Mesa 4");
            Mesa mesa5 = new Mesa("Mesa 5");
            Mesa mesa6 = new Mesa("Mesa 6");
            Mesa mesa7 = new Mesa("Mesa 7");
            Mesa mesa8 = new Mesa("Mesa 8");
            Mesa mesa9 = new Mesa("Mesa 9");
            Mesa mesa10 = new Mesa("Mesa 10");
            Mesa mesa11 = new Mesa("Mesa 11");
            Mesa mesa12 = new Mesa("Mesa 12");
            Mesa mesa13 = new Mesa("Mesa 13");
            Mesa mesa14 = new Mesa("Mesa 14");
            Mesa mesa15 = new Mesa("Mesa 15");
            Barra barra1 = new Barra("Barra 1");
            Barra barra2 = new Barra("Barra 2");
            Barra barra3 = new Barra("Barra 3");
            Barra barra4 = new Barra("Barra 4");
            Barra barra5 = new Barra("Barra 5");
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

        public static Dictionary<Producto,short> VentaEnMesa(Sitio unSitio, Producto producto,
            Dictionary<Producto, short> inventario)
        {
            if (ControlarSiHayStock(producto) == true)
            {
                unSitio.consumicion.Add(producto);

                for (int i = 0; i < inventario.Count; i++)
                {
                    inventario[producto]--;
                }
            }
            
            return inventario;
        }

        public static Dictionary<Producto, short> VentaEnBarra(Sitio unSitio, Producto producto,
            Dictionary<Producto, short> inventario)
        {
            if(producto.EsBebida == true && ControlarSiHayStock(producto) == true)
            {
               unSitio.consumicion.Add(producto);
                for (int i = 0; i < inventario.Count; i++)
                {
                    inventario[producto]--;
                }

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
                    retorno = $"Disponible la {item.Nombre} ";
                    break;
                }
            }
            return retorno;
        }

        public static void MostrarConsumiciones(Sitio unSitio)
        {
            foreach (Producto item in unSitio.consumicion)
            {
                item.Mostrar();
            }
            
        }
        
        public static float SumarConsumicion(Sitio unSitio)
        {
            float suma = 0f;
            foreach (Producto item in unSitio.consumicion)
            {
               suma += item.Precio;
            }
            return suma;
        }
       
        public static float CalcularTarjeta(float costo)
        {
            return costo * 0.10F;
        }
        public static void AgregarEstacionamiento(Sitio unSitio)
        {
            unSitio.consumicion.Add(new Producto("Estacionamiento", false, 200));
        }

        public static float FacturacionDelDia()
        {
            float suma = 0f;
            foreach (Sitio item in puestosDeVenta)
            {
                suma += 2;
            }
            return suma;
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

        private static bool ControlarSiHayStock(Producto unProducto)
        {
            bool resultado = false;
            foreach (KeyValuePair<Producto, short> item in inventario)
            {
                if(item.Key == unProducto)
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

    }
}
