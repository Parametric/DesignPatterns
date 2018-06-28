using DecoratorRefactor;
using NUnit.Framework;

namespace DecoratorTest
{
    public class Tests
    {
        [Test]
        public void HouseBlendPlainCostIsRight()
        {
            ICoffee coffee = new HouseBlendPlain();
            Assert.That(coffee.Cost(), Is.EqualTo(2.85));
        }

        [Test]
        public void HouseBlendWithMochaCostIsRight()
        {
            ICoffee coffee = new HouseBlendWithMocha();
            Assert.That(coffee.Cost(), Is.EqualTo(2.85 + 0.35));
        }

        [Test]
        public void HouseBlendWithMilkCostIsRight()
        {
            ICoffee coffee = new HouseBlendWithMilk();
            Assert.That(coffee.Cost(), Is.EqualTo(2.85 + 0.25));
        }

        [Test]
        public void DripCoffeePlainCostIsRight()
        {
            ICoffee coffee = new DripCoffeePlain();
            Assert.That(coffee.Cost(), Is.EqualTo(3.15));
        }

        [Test]
        public void DripCoffeeWithMochaCostIsRight()
        {
            ICoffee coffee = new DripCoffeeWithMocha();
            Assert.That(coffee.Cost(), Is.EqualTo(3.15 + 0.35));
        }

        [Test]
        public void DripCoffeeWithMilkCostIsRight()
        {
            ICoffee coffee = new DripCoffeeWithMilk();
            Assert.That(coffee.Cost(), Is.EqualTo(3.15 + 0.25));
        }
    }
}
