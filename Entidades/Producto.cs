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

        public Producto(string nombre, bool esBebida, float precio)
        {
            this.nombre = nombre;
            this.esBebida = esBebida;
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

        internal string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"  {nombre}  ");
            sb.AppendLine($" $ {precio}  ");
            sb.AppendLine($"------------------------");
            return sb.ToString();
            
        }
    }
}
