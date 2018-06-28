using DecoratorRefactor;
using NUnit.Framework;

namespace DecoratorTest
{
    public class Tests
    {
        [Test]
        public void HouseBlendPlainCostIsRight()
        {
            var coffee = new HouseBlendPlain();
            Assert.That(coffee.Cost(), Is.EqualTo(2.85));
        }

        [Test]
        public void HouseBlendWithMochaCostIsRight()
        {
            var coffee = new HouseBlendWithMocha();
            Assert.That(coffee.Cost(), Is.EqualTo(2.85 + 0.35));
        }

        [Test]
        public void HouseBlendWithMilkCostIsRight()
        {
            var coffee = new HouseBlendWithMilk();
            Assert.That(coffee.Cost(), Is.EqualTo(2.85 + 0.25));
        }

        [Test]
        public void DripCoffeePlainCostIsRight()
        {
            var coffee = new DripCoffeePlain();
            Assert.That(coffee.Cost(), Is.EqualTo(3.15));
        }

        [Test]
        public void DripCoffeeWithMochaCostIsRight()
        {
            var coffee = new DripCoffeeWithMocha();
            Assert.That(coffee.Cost(), Is.EqualTo(3.15 + 0.35));
        }

        [Test]
        public void DripCoffeeWithMilkCostIsRight()
        {
            var coffee = new DripCoffeeWithMilk();
            Assert.That(coffee.Cost(), Is.EqualTo(3.15 + 0.25));
        }
    }
}
