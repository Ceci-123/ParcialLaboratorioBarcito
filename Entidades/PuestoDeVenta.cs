using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoDeVenta
    {
        public bool estaLibre;
        public Dictionary<Producto,short> consumicion;
        public string nombre;
        public bool esBarra;

        public PuestoDeVenta(string nombre, bool esBarra)
        {
            consumicion = new Dictionary<Producto, short>();
            this.nombre = nombre;
            this.estaLibre = true;
            this.esBarra = esBarra;
        }

        public bool EstaLibre { get { return estaLibre; }
                                set { estaLibre = value; }
        }
        public string Nombre { get { return nombre; } }

        public bool EsBarra { get { return esBarra; } }

        public void AgregarConsumicion(Producto producto, short cantidad,Dictionary<Producto, short> inventario)
        {
            if ((this.EsBarra == true && producto.EsBebida == true) || this.EsBarra == false)
            {
               if(Bar.ControlarSiHayStock(producto) == true)
                {
                    this.consumicion.Add(producto, cantidad);
                    inventario[producto]--;
                    //TODO solo resta un producto
                }
            } 
                
                       
        }

        public static string MostrarConsumiciones(PuestoDeVenta unPuesto)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<Producto, short> item in unPuesto.consumicion)
            {
                sb.AppendLine(item.Value.ToString() + item.Key.ToString());
            }
            return sb.ToString();
        }

        private float CalcularTarjeta(float costo)
        {
            return costo * 0.10F;
        }

        private void AgregarEstacionamiento()
        {
            this.consumicion.Add(new Producto("Estacionamiento",false, 200F),1);
            
        }

        

    }
}
