using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sitio
    {
        public bool estaLibre;
        public List<Producto> consumicion;
        public string nombre;

        public bool EstaLibre { get { return estaLibre; } }
        public string Nombre { get { return nombre; } }
    }
}
