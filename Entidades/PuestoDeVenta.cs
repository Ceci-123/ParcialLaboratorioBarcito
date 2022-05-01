using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class PuestoDeVenta
    {
        private bool estaLibre;
        private Dictionary<Producto, short> consumicion;
        private string nombre;
        private bool esBarra;

        public PuestoDeVenta(string nombre, bool esBarra)
        {
            consumicion = new Dictionary<Producto, short>();
            this.nombre = nombre;
            this.estaLibre = true;
            this.esBarra = esBarra;
        }

        public bool EstaLibre { get { return estaLibre; } set { estaLibre = value; }  }
        public string Nombre { get { return nombre; } }

        public bool EsBarra { get { return esBarra; } }

        public Dictionary<Producto, short> ListaConsumicion { get => consumicion; set => consumicion = value; }

        /// <summary>
        /// Agrega una consumicion al puesto de venta y la resta del inventario
        /// </summary>
        /// <param name="producto">Producto vendido</param>
        /// <param name="cantidad">Cantidad del producto</param>
        /// <param name="inventario">Inventario de productos del bar</param>
        public void AgregarConsumicion(Producto producto, short cantidad, Dictionary<Producto, short> inventario)
        {
            if (producto is not null && cantidad > 0 && inventario is not null)
            {
                if ((this.EsBarra == true && producto.EsBebida == true) || this.EsBarra == false)
                {
                    if (Bar.ControlarSiHayStock(producto) == true)
                    {
                        this.consumicion.Add(producto, cantidad);
                        inventario[producto]--;
                        //TODO solo resta un producto
                    }
                }
            }
            
        }

        /// <summary>
        /// Muestra lo que lleva consumido un puesto de venta
        /// </summary>
        /// <param name="unPuesto">Puesto de venta</param>
        /// <returns>Un string con los datos</returns>
        public string MostrarConsumiciones()
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<Producto, short> item in this.consumicion)
            {
                sb.AppendLine(item.Value.ToString() + item.Key.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Agrega al puesto de venta el item de estacionamiento en la consumision
        /// </summary>
        public void AgregarEstacionamiento()
        {
            this.consumicion.Add(new Producto("Estacionamiento", false, 200F), 1);

        }

        /// <summary>
        /// Vuelve a colocar el puesto de venta como libre
        /// </summary>
        public void LiberarPuestoDeVenta()
        {
            this.estaLibre = true;
        }


    }
}
