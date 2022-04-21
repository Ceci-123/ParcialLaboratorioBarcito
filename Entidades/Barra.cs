using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Barra :Sitio
    {
        public Barra(bool estado, string nombre) 
        {
            consumicion = new List<Producto>();
            this.estaLibre = estado;
        }
        
    }
}
