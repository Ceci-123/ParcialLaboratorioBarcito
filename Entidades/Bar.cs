using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Entidades
{
    public static class Bar
    {
        public static string Nombre { get { return "BAR UTN"; } }
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

        /// <summary>
        /// Devuelve el total en $ de lo consumido en un puesto de venta (la "cuenta")
        /// </summary>
        /// <param name="cualPuesto">Puesto a cerrar la cuenta </param>
        /// <returns>Total de lo consumido</returns>
        public static float SumarConsumicion(string cualPuesto)
        {
            float retorno = 0;
            if (!String.IsNullOrEmpty(cualPuesto))
            {
                foreach (PuestoDeVenta item in Bar.ListaDePuestosDeVenta)
                {
                    if (item.Nombre == cualPuesto)
                    {
                        item.LiberarPuestoDeVenta();
                        foreach (KeyValuePair<Producto, short> item2 in item.consumicion)
                        {
                            retorno += item2.Key.Precio;
                        }
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// Agrega un 10 % de recargo por pagar con tarjeta de credito
        /// </summary>
        /// <param name="totalPesos">Valor sin el aumento</param>
        /// <returns>Valor con el aumento agregado</returns>
        public static float CalcularTarjeta(float totalPesos)
        {
            float retorno = 0;
            if(totalPesos > 0)
            {
              retorno = totalPesos + (totalPesos * 0.10F);
            }
            return retorno;
        }

        /// <summary>
        /// Agrega el estacionamiento a la lista de productos consumidos por el puesto de venta
        /// </summary>
        /// <param name="cualPuesto">Puesto al cual se le agrega el estacionamiento</param>
        public static void CalcularEstacionamiento(string cualPuesto)
        {
            if (!String.IsNullOrEmpty(cualPuesto))
            {
                foreach (PuestoDeVenta item in ListaDePuestosDeVenta)
                {
                    if (item.Nombre == cualPuesto)
                    {
                        item.AgregarEstacionamiento();
                    }
                }
            }    
            
        }

        /// <summary>
        /// Descuenta un valor segun el rango de la persona que lo aplica
        /// </summary>
        /// <param name="totalPesos">Valor sin descuento</param>
        /// <param name="rango">Rango del empleado</param>
        /// <returns>El valor con el descuento aplicado</returns>
        public static float Descuentos(float totalPesos, int rango)
        {
            float retorno = totalPesos;
            if(rango == 1)
            {
                totalPesos = totalPesos + (totalPesos * 0.20F);
            }
            else
            {
                totalPesos = totalPesos + (totalPesos * 0.10F);
            }
            return retorno;
        }

        /// <summary>
        /// Hardcodea el bar con personal, puestos de venta y productos
        /// </summary>
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

        /// <summary>
        /// Muestra las consumisiones de un puesto de venta
        /// </summary>
        /// <param name="numeroPuesto">Puesto a mostrar las consumisiones</param>
        /// <returns>String con los datos</returns>
        public static string MostrarConsumiciones(string numeroPuesto)
        {
            StringBuilder sb = new StringBuilder();
            int flag = 0;
            if (!String.IsNullOrEmpty(numeroPuesto))
            {
                foreach (PuestoDeVenta item in Bar.ListaDePuestosDeVenta)
                {
                    if (item.Nombre == numeroPuesto)
                    {
                        sb.AppendLine(item.MostrarConsumiciones());
                        flag = 1;
                    }

                }
                if (flag == 0)
                {
                    sb.Append("No hay consumisiones para mostrar");
                }
         
            }
            return sb.ToString();

        }

        /// <summary>
        /// Busca los puestos de venta disponibles en el bar
        /// </summary>
        /// <returns>El listado de lugares libres</returns>
        public static string BuscarSitioLibre()
        {
            StringBuilder sb = new StringBuilder();
            int flag = 0;
            foreach (PuestoDeVenta item in puestosDeVenta)
            {
                if (item.EstaLibre == true)
                {
                    sb.AppendLine($"Disponible la {item.Nombre}\n");
                    flag = 1;
                }
               
            }
            if(flag == 0)
            {
                sb.AppendLine("No hay lugares disponibles en el bar");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Calcula el total facturado en el dia por el bar
        /// </summary>
        /// <returns>El total facturado en el dia por el bar</returns>
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
            Bar.TotalVentaDelDia = suma;
            return (float)suma;
        }

        /// <summary>
        /// Muestra los productos existentes en el inventario del bar
        /// </summary>
        /// <returns>El listado de productos en el inventario del bar</returns>
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

        /// <summary>
        /// Devuelve si hay o no stock de un producto en el bar
        /// </summary>
        /// <param name="unProducto">Producto a verificar</param>
        /// <returns>Si el producto esta disponible</returns>
        internal static bool ControlarSiHayStock(Producto unProducto)
        {
            bool resultado = false;
            if(unProducto is not null)
            {
                foreach (KeyValuePair<Producto, short> item in inventario)
                {
                    if (item.Key == unProducto && item.Value > 1)
                    {
                        resultado = true;
                    }

                }
            }
            
            return resultado;
        }

        /// <summary>
        /// Devuelve una lista del personal del bar
        /// </summary>
        /// <returns>Un string con la lista del personal del bar</returns>
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

        /// <summary>
        /// Agrega un producto al inventario del bar
        /// </summary>
        /// <param name="unProducto">Producto a agregar</param>
        /// <param name="cantidad">Cantidad de ese producto</param>
        public static void AgregarMercaderia(Producto unProducto, short cantidad)
        {
            if(unProducto is not null && cantidad > 0)
            {
               inventario.Add(unProducto, cantidad);

            }  
        }

        /// <summary>
        /// Agrega un producto al inventario del bar, creando dicho producto dentro del metodo
        /// </summary>
        /// <param name="nombre">Nombre del producto</param>
        /// <param name="esBebida">Si el producto es una bebida</param>
        /// <param name="precio">El precio del producto</param>
        /// <param name="esVegan">Si el producto es vegano</param>
        /// <param name="esAptoCeliaquia">Si el producto no tiene tacc</param>
        /// <param name="cantidad">Cantidad de ese producto</param>
        public static void AgregarMercaderia(string nombre, bool esBebida, float precio, bool esVegan, bool esAptoCeliaquia, short cantidad)
        {
            if (!String.IsNullOrEmpty(nombre) && cantidad > 0)
            {
                Producto unProducto = new Producto(nombre, esBebida, precio, esVegan, esAptoCeliaquia);
                inventario.Add(unProducto, cantidad);
            }
        }

        /// <summary>
        /// Agrega un producto a la consumision de un puesto de venta
        /// </summary>
        /// <param name="aDonde">Puesto de venta</param>
        /// <param name="queCosa">Producto a agregar</param>
        /// <param name="cantidad">Cantidad del producto</param>
        public static void Venta(string aDonde, string queCosa, string cantidad)
        {
            if (!String.IsNullOrEmpty(aDonde) && !String.IsNullOrEmpty(queCosa) && !String.IsNullOrEmpty(cantidad))
            {
                Producto prodParaAgregar = null;
                foreach (KeyValuePair<Producto, short> item in inventario)
                {
                    if (item.Key.Nombre == queCosa)
                    {
                        prodParaAgregar = item.Key;
                    }
                }
                if (!String.IsNullOrEmpty(aDonde))
                {
                    foreach (PuestoDeVenta item in Bar.ListaDePuestosDeVenta)
                    {
                        if (item.Nombre == aDonde)
                        {
                            short.TryParse(cantidad, out short cantidadNumerica);
                            if (prodParaAgregar is not null && cantidadNumerica > 0)
                            {
                                item.AgregarConsumicion(prodParaAgregar, cantidadNumerica, Bar.CosasEnElInventario);

                            }
                        }
                    }
                }
            }
            

            
        }

        /// <summary>
        /// Guarda el ticket de cobro en un archivo txt
        /// </summary>
        /// <param name="nombrePuesto">Puesto de venta del cual se requiere ticket</param>
        /// <param name="totalPesos">Valor a cobrar</param>
        /// <param name="checkedTarjeta">Si pago con tarjeta de credito</param>
        /// <param name="checkedEstacionamiento">Si utilizo el estacionamiento</param>
        /// <param name="checkedDescuento">Si le aplicaron descuento</param>
        /// <returns></returns>
        public static bool ImprimirTicket(string nombrePuesto, float totalPesos,
            bool checkedTarjeta, bool checkedEstacionamiento, bool checkedDescuento)
        {
            bool retorno = false;
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += "\\carpetaDePrueba";
            //
            foreach (PuestoDeVenta item in Bar.ListaDePuestosDeVenta)
            {
                if (item.Nombre == nombrePuesto)
                {
                    // encontre el puesto
                    if (!Directory.Exists(ruta))
                    {
                        try
                        {
                            Directory.CreateDirectory(ruta);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    try
                    {
                        ruta += "\\" + DateTime.Now.ToString("HH_mm_ss") + ".txt";

                        using (StreamWriter writer = new StreamWriter(ruta))
                        {
                            writer.WriteLine("Consumision de la " + item.Nombre);
                            foreach (KeyValuePair<Producto, short> item2 in item.consumicion)
                            {
                                writer.WriteLine(item2.Value.ToString());
                                writer.WriteLine(item2.Key.ToString());
                                retorno = true;
                            }
                            writer.WriteLine("Total $ " + totalPesos);
                            if (checkedTarjeta)
                            {
                                writer.WriteLine("Estas pagando con tarjeta de credito");
                            }
                            if (checkedEstacionamiento)
                            {
                                writer.WriteLine("Te agregamos el cargo de estacionamiento");
                            }
                            if (checkedDescuento)
                            {
                                writer.WriteLine("Tu descuento ya fue aplicado");
                            }
                        }
                    }
                    catch (Exception exp)
                    {
                        Console.Write(exp.Message);
                    }

                }
            }
            return retorno;
        }

        
    }
}
