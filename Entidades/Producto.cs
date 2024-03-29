﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        protected string nombre;
        protected bool esBebida;
        protected float precio;
        protected bool esVegano;
        protected bool esAptoCeliacos;

        public Producto(string nombre, bool esBebida, float precio)
        {
            this.nombre = nombre;
            this.esBebida = esBebida;
            this.precio = precio;
        }

        public Producto(string nombre, bool esBebida, float precio, bool esVegano, bool esAptoCeliacos)
            :this(nombre, esBebida, precio)
        {
            this.esVegano = esVegano;
            this.esAptoCeliacos = esAptoCeliacos;
        }

        public bool EsBebida { get { return esBebida; } }
        public float Precio  { get { return precio; } }
        public string Nombre { get { return nombre; } }

        /// <summary>
        /// Muestra un producto
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"  {nombre}  ");
            sb.AppendLine($" $ {precio.ToString()}  ");
            if (this.esVegano)
            {
                sb.AppendLine("Producto vegano");
            }
            if (this.esAptoCeliacos)
            {
                sb.AppendLine("Producto sin TACC");
            }
            return sb.ToString();
            
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
           return p1.Nombre == p2.Nombre;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
    }
}
