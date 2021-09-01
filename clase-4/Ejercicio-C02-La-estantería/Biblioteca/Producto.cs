using System;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public string MostrarProducto(Producto p)
        {
            return $"Codigo de barra: {p.codigoDeBarra} - Marca: {p.GetMarca()} - Precio: {p.GetPrecio()}";
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator ==(Producto p, string marca)
        {
            return p.GetMarca().Equals(marca);
        }

        public static bool operator !=(Producto p, Producto p2)
        {
            return !(p == p2);
        }


        public static bool operator ==(Producto p, Producto p2)
        {
            return p.GetMarca().Equals(p2.GetMarca()) && ((string)p).Equals((string)p2);
        }
    }
}
