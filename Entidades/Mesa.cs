using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mesa :Sitio 
    {
        public Mesa(string nombre) :base(nombre)
        {
            consumicion = new List<Producto>();
        }

       
    }
}
