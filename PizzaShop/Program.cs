using PizzaShop.Factory;
using PizzaShop.Services;
using System;

namespace PizzaShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name of pizza eg. Chicken, Cheese, Pepperoni: ");
            string pizzaName = Console.ReadLine();
            if(string.IsNullOrEmpty(pizzaName))
            {
                Console.Write("Invalid Pizza Name");
            }
            else
            {
                IPizza pizza = PizzaFactory.Create(pizzaName);
                PizzaService pizzaService = new PizzaService();
                pizzaService.Order(pizza);

            }
          
            Console.ReadLine();

        }
    }
}
