using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool existe = false;
            for (int i = 0; i < e.GetProductos().Length && !existe; i++)
            {
                if (e.GetProductos()[i] == p)
                {
                    existe = true;
                }
            }
            return existe;
        }

        public static bool operator +(Estante e, Producto p)
        {
            return true;
        }


        public static bool operator -(Estante e, Producto p)
        {
            return !(e + p);
        }
    }
}
