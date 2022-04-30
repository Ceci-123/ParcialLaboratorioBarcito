using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        protected string nombre;
        protected bool esBebida;
        protected float precio;
        protected bool esVegano;
        protected bool esAptoCeliacos;

        public Producto(string nombre, bool esBebida, float precio)
        {
            this.nombre = nombre;
            this.esBebida = esBebida;
            this.precio = precio;
        }

        public Producto(string nombre, bool esBebida, float precio, bool esVegano, bool esAptoCeliacos)
            :this(nombre, esBebida, precio)
        {
            this.esVegano = esVegano;
            this.esAptoCeliacos = esAptoCeliacos;
        }

        public bool EsBebida
        {
            get
            {
                return esBebida;
            }
        }
        public float Precio
        {
            get
            {
                return precio;
            }
        }

        public string Nombre { get; }

        internal string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"  {nombre}  ");
            sb.AppendLine($" $ {precio.ToString()}  ");
            return sb.ToString();
            
        }
    }
}
