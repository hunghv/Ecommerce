using System;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace E.Shared.Utils
{
    public static class Connection
    {
        public enum DatabaseName
        {
            Logging,
            Ecommerce
        }

        public static MySqlConnection GetConnection(DatabaseName dbName, IConfiguration config)
        {
            return new MySqlConnection(GetConnectionString(dbName, config));
        }

        private static string GetConnectionString(Connection.DatabaseName dbName, IConfiguration config)
        {
            var connectionString = config.GetConnectionString(dbName.ToString());
            if (connectionString == null)
                throw new Exception(string.Format("Connection string {0} not in config", dbName));

            return connectionString;
        }
    }
}
