using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor : Persona
    {
        public Vendedor(string nombre, string password) : base(nombre, password)
        {

        }

        public bool EsVendedor { get { return true; } }

        /// <summary>
        /// Descuenta un 10% del valor ingresado (descuento de vendedor)
        /// </summary>
        /// <param name="valor">Precio sin promo</param>
        /// <returns>El precio promocional</returns>
        public override float DescontarPromo(float valor)
        {
            return valor - (valor * 0.10F);
        }
    }  
}
