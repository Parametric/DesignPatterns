using NUnit.Framework;
using StrategyRefactor;

namespace StrategyTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void DucklingSaysTweet()
        {
            var duck = new Duckling();
            var greeting = duck.InvokeGreeting();
            Assert.That(greeting, Is.EqualTo("tweet"));
        }

        [Test]
        public void GrownUpDuckSaysQuack()
        {
            var duck = new GrownUp();
            var greeting = duck.InvokeGreeting();
            Assert.That(greeting, Is.EqualTo("quack"));
        }

        [Test]
        public void GrownUpDuckWithSoreThroatSaysNothing()
        {
            var duck = new GrownUp();
            var greeting = duck.InvokeGreeting();
            Assert.That(greeting, Is.EqualTo("quack"));

            duck.UpdateQuackStrategy(new DecoyStrategy());
            var newGreeting = duck.InvokeGreeting();
            Assert.That(newGreeting, Is.EqualTo("< silence >"));
        }

        [Test]
        public void DuckCallSaysQuack()
        {
            var duck = new DuckCall();
            var greeting = duck.InvokeGreeting();
            Assert.That(greeting, Is.EqualTo("quack"));
        }

        [Test]
        public void DecoyIsSilent()
        {
            var duck = new Decoy();
            var greeting = duck.InvokeGreeting();
            Assert.That(greeting, Is.EqualTo("< silence >"));
        }
    }
}


