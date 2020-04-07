using System;
using System.Collections.Generic;
namespace Laboratorio03
{
    public class Cart
    {
        private Persona CartOwner;
        private List<Producto> CartList;
        private int Total;

        public Cart(Persona CartOwner, List<Producto> CartList)
        {
            this.CartOwner = CartOwner;
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
