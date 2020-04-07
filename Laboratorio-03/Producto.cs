using System;
namespace Laboratorio03
{
    public class Producto
    {
        private string nombre;
        private int precio;
        private string marca;
        public int stock;

        public Producto(String nombre, int precio, String marca, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
            this.stock = stock;
        }

        public String GetName()
        {
            return nombre;
        }

        public int GetPrice()
        {
            return precio;
        }

        public String GetBrand()
        {
            return marca;
        }

        public bool RevisarStock()
        {
            if (stock == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
