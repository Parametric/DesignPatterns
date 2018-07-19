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
            var db = new Database();
            var runner = new DatabaseMigrationRunner(db);
            runner.Run("AddColumn", "col1", "");
            Assert.That(db.PrintSchema(), Is.EqualTo("col1"));
        }

        [Test]
        public void RemoveColumnWorks()
        {
            var db = new Database();
            var runner = new DatabaseMigrationRunner(db);
            runner.Run("AddColumn", "col1", "");
            runner.Run("RemoveColumn", "col1", "");
            Assert.That(db.PrintSchema(), Is.EqualTo(""));
        }

        [Test]
        public void ChangeColumnName()
        {
            var db = new Database();
            var runner = new DatabaseMigrationRunner(db);
            runner.Run("AddColumn", "col1", "");
            runner.Run("ChangeColumnName", "col1", "SuperCol");
            Assert.That(db.PrintSchema(), Is.EqualTo("SuperCol"));
        }
    }
}
