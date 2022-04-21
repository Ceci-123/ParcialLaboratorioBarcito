namespace Entidades
{
    public class Administrador : Persona
    {
        public Administrador(string nombre, string password) : base(nombre, password)
        {

        }
        public bool EsAdmin { get { return true; } }


    }

}
