using System;
namespace Laboratorio03
{
    public class Producto
    {
        private string nombre;
        private int precio;
        private string marca;
        private int stock;

        public Producto(String nombre, int precio, String marca, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
            this.stock = stock;
        }
    }
}
