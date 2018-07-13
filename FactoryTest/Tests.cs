using FactoryRefactor;
using NUnit.Framework;

namespace FactoryTest
{
    [TestFixture]
    public class Tests
    {
        //[Test]
        //public void RendersLinuxCorrectly()
        //{
        //    var renderer = new Renderer();
        //    var result = renderer.Draw("Linux");
        //    Assert.That(result, 
        //        Is.EqualTo("Linux button & Linux menu"));
        //}

        [Test]
        public void RendersWindowsCorrectly()
        {
            var renderer = new Renderer();
            var result = renderer.Draw(new WindowsFactory());
            Assert.That(result, 
                Is.EqualTo("Windows button & Windows menu"));
        }

        [Test]
        public void RendersFlatLinuxCorrectly()
        {
            var renderer = new Renderer();
            var result = renderer.Draw(new FlatLinuxFactory());
            Assert.That(result,
                Is.EqualTo("FlatLinux button & FlatLinux menu"));
        }

        [Test]
        public void RendersChromeOsCorrectly()
        {
            var renderer = new Renderer();
            var result = renderer.Draw(new ChromeOsFactory());
            Assert.That(result,
                Is.EqualTo("ChromeOS button & ChromeOS menu"));
        }

        [Test]
        public void RenderAndroidCorrectly()
        {
            var renderer = new Renderer();
            var result = renderer.Draw(new AndroidFactory());
            Assert.That(result,
                Is.EqualTo("Android button & Android menu"));
        }

    }
}
