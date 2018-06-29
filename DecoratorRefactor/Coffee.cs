namespace DecoratorRefactor
{
    public interface ICoffee
    {
        double Cost();
    }

    public class Mocha : ICoffee
    {
        private ICoffee _coffee;
        public Mocha(ICoffee coffee)
        {
            _coffee = coffee;
        }
        public double Cost()
        {
            return _coffee.Cost() + 0.35;
        }
    }
    public class Milk : ICoffee
    {
        private ICoffee _coffee;
        public Milk(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public double Cost()
        {
            return _coffee.Cost() + 0.25;
        }
    }

    public class Syrup : ICoffee
    {
        private ICoffee _coffee;
        public Syrup(ICoffee coffee)
        {
            _coffee = coffee;
        }
        public double Cost()
        {
            return _coffee.Cost() + 0.50;
        }
    }

    public class HouseBlendPlain : ICoffee
    {
        public double Cost()
        {
            return 2.85;
        }
    }

    public class DripCoffeePlain : ICoffee
    {
        public double Cost()
        {
            return 3.15;
        }
    }
}
