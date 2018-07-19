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
        public void AddColumnWorksReallyWell()
        {
            var db = new Database();
            var runner = new DatabaseMigrationRunner(db);
            runner.Run("AddColumn", "col1", "");
            runner.Run("AddColumn", "col2", "");
            runner.Run("AddColumn", "col3", "");
            runner.Run("RemoveColumn", "col2", "");
            Assert.That(db.PrintSchema(), Is.EqualTo("col1 col3"));
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
