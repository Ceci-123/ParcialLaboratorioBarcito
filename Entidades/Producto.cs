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

        public Producto(string nombre, bool esBebida)
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
    }
}
