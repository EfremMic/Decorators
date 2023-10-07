namespace PizzaConstractor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a base pizza
            IPizza myPizza = new pizza();

            // Decorate the pizza with various toppings
            IPizza CheeseDecorator = new CheeseDecorator(myPizza);
            IPizza BaconDecorator = new BaconDecorator(CheeseDecorator);
            IPizza OnionDecorator = new OnionDecorator(BaconDecorator);
            IPizza TomatoDecorator = new TomatoDecorator(OnionDecorator);
            IPizza MeatDecorator = new MeatDecorator(TomatoDecorator);

            // Print the pizza type with all the added toppings
            Console.WriteLine(MeatDecorator.GetPizzaType());
            Console.ReadLine();
        }
    }

    // Define an interface for pizzas
    public interface IPizza
    {
        string GetPizzaType();
    }

    // Define a base pizza class

    public class pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "This is a normal pizza";
        }
    }

    // Define a base decorator class for pizzas
    public class PizzaDecorator : IPizza
    {
        protected IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string GetPizzaType()
        {
            return _pizza.GetPizzaType();
        }
    }

    // Define concrete decorator classes for different toppings

    class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n With extra cheese";
            return type;
        }
    }

    class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n With extra bacon";
            return type;
        }
    }

    class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n With extra onion";
            return type;
        }
    }

    class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n With extra tomato";
            return type;
        }
    }

    class MeatDecorator : PizzaDecorator
    {
        public MeatDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n With extra meat";
            return (type);
        }

    }
}
