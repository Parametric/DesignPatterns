namespace DecoratorRefactor
{
    public interface ICoffee
    {
        double Cost();
    }

    public class HouseBlendPlain : ICoffee
    {
        public double Cost()
        {
            return 2.85;
        }
    }

    public class HouseBlendWithMocha : ICoffee
    {
        public double Cost()
        {
            return 2.85 + 0.35;
        }
    }

    public class HouseBlendWithMilk : ICoffee
    {
        public double Cost()
        {
            return 2.85 + 0.25;
        }
    }

    public class DripCoffeePlain : ICoffee
    {
        public double Cost()
        {
            return 3.15;
        }
    }

    public class DripCoffeeWithMocha : ICoffee
    {
        public double Cost()
        {
            return 3.15 + 0.35;
        }
    }

    public class DripCoffeeWithMilk : ICoffee
    {
        public double Cost()
        {
            return 3.15 + 0.25;
        }
    }
}
