using NUnit.Framework;
using StrategyRefactor;

namespace StrategyTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void YoungDuckSaysTweet()
        {
            var duck = new Duck(20, true, 0);
            var greeting = duck.SayHello();
            Assert.That(greeting, Is.EqualTo("tweet"));
        }

        [Test]
        public void OldDuckSaysQuack()
        {
            var duck = new Duck(61, true, 0);
            var greeting = duck.SayHello();
            Assert.That(greeting, Is.EqualTo("quack"));
        }

        [Test]
        public void LowUtilityDuckToolSaysSqueak()
        {
            var duck = new Duck(0, false, 0);
            var greeting = duck.SayHello();
            Assert.That(greeting, Is.EqualTo("squeak"));
        }

        [Test]
        public void NonZeroUtilityDuckToolSaysQuack()
        {
            var duck = new Duck(0, false, 10);
            var greeting = duck.SayHello();
            Assert.That(greeting, Is.EqualTo("quack"));
        }
    }
}


