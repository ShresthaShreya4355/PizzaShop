namespace PizzaShop
{
    public class ChickenPizza : IPizza
    {
        public string Bake()
        {
            return "200 degree for 15 minutes";
        }

        public string Box()
        {
            return "round";
        }

        public string Cut()
        {
            return "triangle";
        }

        public string Prepare()
        {
            return "Chicken";
        }
    }
}
