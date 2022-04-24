using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Password
        {
            get { return this.password; }
        }

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
                    if(item.Nombre == nombreIngresado && item.Password == passIngresado)
                    {
                        retorno = true;
                        break;

                    }
                }
            }
            return retorno;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Devuelve un int en caso que haya mas rangos en el futuro</returns>
        public static int ValidarRango(List<Persona> listado, string nombreIngresado, string passIngresado)
        {
            int retorno = -1;
            passIngresado = passIngresado.Trim().ToLower();
            nombreIngresado = nombreIngresado.Trim().ToLower();

            if (listado is not null && !string.IsNullOrEmpty(nombreIngresado) &&
                    !string.IsNullOrEmpty(passIngresado))
            {
                foreach (Persona item in listado)
                {
                    if (item.Nombre == nombreIngresado && item.Password == passIngresado)
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
