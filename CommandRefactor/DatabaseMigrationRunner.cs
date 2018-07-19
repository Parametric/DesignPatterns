using System;
using System.Collections.Generic;
using System.Text;

namespace CommandRefactor
{

    public class Database
    {
        public List<string> Schema = new List<string>();
        public string PrintSchema()
        {
            var sb = new StringBuilder();
            Schema.ForEach(x => sb.Append($"{x} "));
            return sb.ToString().TrimEnd(' ');
        }
    }

    public class DatabaseMigrationRunner
    {
        private readonly Database _database;
        public DatabaseMigrationRunner(Database database)
        {
            _database = database;
        }

        public void Run(string migrationType, string columnName, string newColumnName)
        {
            switch (migrationType)
            {
                case "AddColumn":
                {
                    _database.Schema.Add(columnName);
                    break;
                }
                case "RemoveColumn":
                {
                    _database.Schema.Remove(columnName);
                    break;
                }
                case "ChangeColumnName":
                {
                    var colIdx = _database.Schema.FindIndex(x => x.Equals(columnName));
                    _database.Schema[colIdx] = newColumnName;
                    break;
                }
            }
        }
    }
}
