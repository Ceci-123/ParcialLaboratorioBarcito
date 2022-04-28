using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        public string aDonde;
        public Producto queCosa;
        public short cantidad;

        public Venta(string aDonde, Producto queCosa, short cantidad)
        {
            this.aDonde = aDonde;
            this.queCosa = queCosa;
            this.cantidad = cantidad;
        }
    }
}
