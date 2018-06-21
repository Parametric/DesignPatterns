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
            var greeting = duck.SayHello();
            Assert.That(greeting, Is.EqualTo("tweet"));
        }

        [Test]
        public void GrownUpDuckSaysQuack()
        {
            var duck = new GrownUp();
            var greeting = duck.SayHello();
            Assert.That(greeting, Is.EqualTo("quack"));
        }

        [Test]
        public void DuckCallSaysQuack()
        {
            var duck = new DuckCall();
            var greeting = duck.SayHello();
            Assert.That(greeting, Is.EqualTo("quack"));
        }

        [Test]
        public void DecoyIsSilent()
        {
            var duck = new Decoy();
            var greeting = duck.SayHello();
            Assert.That(greeting, Is.EqualTo("< silence >"));
        }
    }
}


