namespace Entidades
{
    public class Administrador : Persona
    {
        public Administrador(string nombre, string password) : base(nombre, password)
        {

        }
        public bool EsAdmin { get { return true; } }

        public override float DescontarPromo(float valor)
        {
            return valor - (valor * 0.20F);
        }

    }

}
 