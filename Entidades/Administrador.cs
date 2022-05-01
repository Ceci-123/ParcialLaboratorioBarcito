namespace Entidades
{
    public class Administrador : Persona
    {
        public Administrador(string nombre, string password) : base(nombre, password)
        {

        }
        public bool EsAdmin { get { return true; } }

        /// <summary>
        /// Descuenta un 20 % del valor ingresado (descuento de admin)
        /// </summary>
        /// <param name="valor">Precio sin descuento</param>
        /// <returns>Precio con el descuento aplicado</returns>
        public override float DescontarPromo(float valor)
        {
            return valor - (valor * 0.20F);
        }

    }

}
 