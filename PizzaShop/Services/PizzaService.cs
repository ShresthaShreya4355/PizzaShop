using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Services
{
    public class PizzaService
    {
        public void Order(IPizza pizza)
        {
            if (pizza != null)
            {
                Console.WriteLine("Prepare : " + pizza.Prepare());
                Console.WriteLine("Bake : " + pizza.Bake());
                Console.WriteLine("Cut : " + pizza.Cut());
                Console.WriteLine("Box : " + pizza.Box());
            }
        }
    }
}
