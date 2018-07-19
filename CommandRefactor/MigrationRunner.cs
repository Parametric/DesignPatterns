using System;
using System.Collections.Generic;
using System.Text;

namespace CommandRefactor
{
    public class MigrationRunner
    {
        private readonly List<string> _schema;
        public MigrationRunner()
        {
            _schema = new List<string>();
        }

        public void Run(string migrationType, string columnName, string newColumnName)
        {
            switch (migrationType)
            {
                case "AddColumn":
                {
                    _schema.Add(columnName);
                    break;
                }
                case "RemoveColumn":
                {
                    _schema.Remove(columnName);
                    break;
                }
                case "ChangeColumnName":
                {
                    var colIdx = _schema.FindIndex(x => x.Equals(columnName));
                    _schema[colIdx] = newColumnName;
                    break;
                }
            }
        }

        public string PrintSchema()
        {
            var sb = new StringBuilder();
            _schema.ForEach(x => sb.Append($"{x} "));
            return sb.ToString().TrimEnd(' ');
        }
    }
}
