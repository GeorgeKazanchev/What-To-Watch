using System.Net;
using WhatToWatch.Data.DbAccessInterfaces;
using WhatToWatch.Data.PostgreSqlAccess;

namespace WhatToWatch.Test.PostgreSqlAccess
{
    public static class Utility
    {
        public static PostgreSqlDatabase CreateTestDatabase()
        {
            string databaseName = "what-to-watch-test";
            string schemeName = "public";
            IPAddress serverAddress = new(new byte[] { 127, 0, 0, 1 });
            int port = 5432;
            DatabaseType databaseType = DatabaseType.PostgreSql;
            string defaultUsername = "wtw_test_user";
            string defaultPassword = "test_password";

            var configuration = new DatabaseConfiguration(databaseName, schemeName, serverAddress, port, databaseType,
                defaultUsername, defaultPassword);
            var database = new PostgreSqlDatabase(configuration);
            return database;
        }
    }
}