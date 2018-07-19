using CommandRefactor;
using NUnit.Framework;

namespace CommandTest
{
    [TestFixture]
    public class MigrationTest
    {
        [Test]
        public void AddColumnWorks()
        {
            var runner = new MigrationRunner();
            runner.Run("AddColumn", "col1", "");
            Assert.That(runner.PrintSchema(), Is.EqualTo("col1"));
        }

        [Test]
        public void RemoveColumnWorks()
        {
            var runner = new MigrationRunner();
            runner.Run("AddColumn", "col1", "");
            runner.Run("RemoveColumn", "col1", "");
            Assert.That(runner.PrintSchema(), Is.EqualTo(""));
        }

        [Test]
        public void AddColumnWorksReallyWell()
        {
            var runner = new MigrationRunner();
            runner.Run("AddColumn", "col1", "");
            runner.Run("AddColumn", "col2", "");
            runner.Run("AddColumn", "col3", "");
            runner.Run("RemoveColumn", "col2", "");
            Assert.That(runner.PrintSchema(), Is.EqualTo("col1 col3"));
        }

        [Test]
        public void ChangeColumnName()
        {
            var runner = new MigrationRunner();
            runner.Run("AddColumn", "col1", "");
            runner.Run("ChangeColumnName", "col1", "SuperCol");
            Assert.That(runner.PrintSchema(), Is.EqualTo("SuperCol"));
        }
    }
}
