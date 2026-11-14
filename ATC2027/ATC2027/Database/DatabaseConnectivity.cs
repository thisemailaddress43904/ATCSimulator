using ATC2027.Clearance.WaypointControl;
using ATC2027.Interfaces;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Database
{
    public class DatabaseConnectivity
    {
        public static DatabaseConnectivity databaseConnectivity = new DatabaseConnectivity();

        private SqliteConnection connection;

        public DatabaseConnectivity(string dbName = "locations.db")
        {
            connection = new SqliteConnection($"Data Source={dbName}");
            connection.Open();
        }

        public SqliteCommand GetCommand(string commandText)
        {
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            return command;
        }

        public SqliteDataReader GetDataReader(string commandText)
        {
            return GetCommand(commandText).ExecuteReader();
        }
        public IList<T> ExecuteInsertionStatement<T>(string command, string columnName) where T : IFromString<T>, new()
        {
            SqliteDataReader sqliteDataReader = GetDataReader(command);

            IList<T> list = [];

            while (sqliteDataReader.Read())
            {
                T obj = new T();
                int columnIndex = sqliteDataReader.GetOrdinal(columnName);
                string columnValue = sqliteDataReader.GetString(columnIndex);
                obj = obj.fromString(columnValue);
                list.Add(obj);
            }

            return list;
        }

    }
}
