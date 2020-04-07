using System;
using System.Collections.Generic;
namespace Laboratorio03
{
    public class Cart
    {
        private Persona CartOwner;
        public List<Producto> CartList;
        private int Total;

        public Cart(List<Producto> CartList)
        {
            this.CartList = CartList;
        }

        public int GetTotal()
        {
            int CartTotal = 0;
            foreach (Producto Product in CartList)
            {
                CartTotal += Product.GetPrice();
            }
            return CartTotal;
        }
    }
}
