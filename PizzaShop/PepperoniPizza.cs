using PizzaShop.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop
{
    public class PepperoniPizza : IPizza

    {
        public string Bake()
        {
            return "100 degree for 18 minutes";
        }

        public string Box()
        {
            return "triangle";
        }

        public string Cut()
        {
            return "triangle";
        }

        public string Prepare()
        {
            return "pepperoni";
        }
    }
}
