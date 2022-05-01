using System.Collections.Generic;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string password;

        public Persona(string nombre, string password)
        {
            this.nombre = nombre;
            this.password = password;
        }
        public string Nombre { get { return this.nombre; } }
        public string Password {  get { return this.password; } }

        /// <summary>
        /// Valida si el nombre y password ingresados corresponden con los datos de un usuario valido
        /// </summary>
        /// <param name="listado">listado de usuarios</param>
        /// <param name="nombreIngresado">nombre ingresado por el usuario</param>
        /// <param name="passIngresado">password ingresado por el usuario</param>
        /// <returns></returns>
        public static bool ValidarUser(List<Persona> listado, string nombreIngresado, string passIngresado)
        {
            bool retorno = false;
            passIngresado = passIngresado.Trim().ToLower();
            nombreIngresado = nombreIngresado.Trim().ToLower();

            if (listado is not null && !string.IsNullOrEmpty(nombreIngresado) &&
                    !string.IsNullOrEmpty(passIngresado))
            {
                foreach (Persona item in listado)
                {
                    if (item.Nombre == nombreIngresado && item.Password == passIngresado)
                    {
                        retorno = true;
                        break;

                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// Descuenta un porcentaje diferente segun lo aplique un vendedor o un admin
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public abstract float DescontarPromo(float valor);

        /// <summary>
        /// Descuenta el 50 % del valor ingresado
        /// </summary>
        /// <param name="valor">Precio sin promo</param>
        /// <returns></returns>
        public virtual float DescontarHappyHour(float valor)
        {
            return valor / 2;
        }
        /// <summary>
        /// Devuelve un entero segun el rango del usuario
        /// </summary>
        /// <returns>Devuelve 1 si es admin y 2 si es vendedor(escalable a futuro)</returns>
        public static int ValidarRango(List<Persona> listado, string nombreIngresado)
        {
            int retorno = -1;
            nombreIngresado = nombreIngresado.Trim().ToLower();

            if (listado is not null && !string.IsNullOrEmpty(nombreIngresado))
            {
                foreach (Persona item in listado)
                {
                    if (item.Nombre == nombreIngresado)
                    {
                        if (item is Vendedor)
                        {
                            retorno = 2;
                            break;
                        }
                        else if (item is Administrador)
                        {
                            retorno = 1;
                            break;
                        }
                        else
                        {
                            retorno = 0;
                        }
                    }
                }
            }
            return retorno;
        }
    }
}
