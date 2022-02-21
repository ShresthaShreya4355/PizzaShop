namespace PizzaShop.Factory
{
    public class PizzaFactory
    {
        public static IPizza Create(string name)
        {
            IPizza pizza = null;
            if (name == "Chicken")
            {
                pizza = new ChickenPizza();
            }
            else if (name == "Cheese")
            {
                pizza = new CheesePizza();
            }
            else if (name == "Pepperoni")
            {
                pizza = new PepperoniPizza();
            }
            return pizza;
        }
    }
}
