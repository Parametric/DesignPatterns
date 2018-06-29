using System.Data;
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
            ICoffee coffee = new HouseBlendPlain();
            coffee = new Mocha(coffee);
            Assert.That(coffee.Cost(), Is.EqualTo(2.85 + 0.35));
        }

        [Test]
        public void HouseBlendWithMilkCostIsRight()
        {
            ICoffee coffee = new HouseBlendPlain();
            coffee = new Milk(coffee);
            Assert.That(coffee.Cost(), Is.EqualTo(2.85 + 0.25));
        }

        [Test]
        public void HouseBlendWithFourMochas()
        {
            ICoffee coffee = new HouseBlendPlain();
            coffee = new Mocha(coffee);
            coffee = new Mocha(coffee);
            coffee = new Mocha(coffee);
            coffee = new Mocha(coffee);
            Assert.That(coffee.Cost(), Is.EqualTo(2.85 + 0.35 + 0.35 + 0.35 + 0.35));
        }

        [Test]
        public void MochaCostIsCorrect()
        {
            ICoffee mocha = new Mocha(new FakeCoffee());
            Assert.That(mocha.Cost(), Is.EqualTo(0.35));
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
            ICoffee coffee = new DripCoffeePlain();
            coffee = new Mocha(new DripCoffeePlain());
            Assert.That(coffee.Cost(), Is.EqualTo(3.15 + 0.35));
        }

        [Test]
        public void DripCoffeeWithMilkCostIsRight()
        {
            ICoffee coffee = new DripCoffeePlain();
            coffee = new Milk(coffee);
            Assert.That(coffee.Cost(), Is.EqualTo(3.15 + 0.25));
        }

        [Test]
        public void SyrupCostIsRight()
        {
            ICoffee syrup = new Syrup(new FakeCoffee());
            Assert.That(syrup.Cost(), Is.EqualTo(0.50));
        }

        [Test]
        public void CoffeWSyrup()
        {
            ICoffee coffee = new DripCoffeePlain();
            coffee = new Syrup(coffee);
            Assert.That(coffee.Cost(), Is.EqualTo(3.15 + 0.50));
        }
    }

    public class FakeCoffee : ICoffee
    {
        public double Cost()
        {
            return 0.0;
        }
    }
}
