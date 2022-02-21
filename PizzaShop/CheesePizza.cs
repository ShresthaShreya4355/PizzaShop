namespace PizzaShop
{
    public class CheesePizza : IPizza
    {
        public string Bake()
        {
            return "120 degree for 15 minutes";
        }

        public string Box()
        {
            return "square";
        }

        public string Cut()
        {
            return "triangle";
        }

        public string Prepare()
        {
            return "Cheese";
        }
    }
}
