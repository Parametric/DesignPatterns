using FactoryRefactor;
using NUnit.Framework;

namespace FactoryTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void RendersLinuxCorrectly()
        {
            var renderer = new Renderer();
            var result = renderer.Draw("Linux");
            Assert.That(result, Is.EqualTo("Linux button & Linux menu"));
        }

        [Test]
        public void RendersWindowsCorrectly()
        {
            var renderer = new Renderer();
            var result = renderer.Draw("Windows");
            Assert.That(result, Is.EqualTo("Windows button & Windows menu"));
        }
    }
}
