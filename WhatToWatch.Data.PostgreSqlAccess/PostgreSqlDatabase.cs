using System.Net;
using WhatToWatch.Data.DbAccessInterfaces;

namespace WhatToWatch.Data.PostgreSqlAccess
{
    public class PostgreSqlDatabase : IDatabase
    {
        public PostgreSqlDatabase(DatabaseConfiguration configuration)
        {
            Configuration = (DatabaseConfiguration) configuration.Clone();
            ServerEndpoint = new IPEndPoint(configuration.ServerAddress, configuration.Port);
        }

        public DatabaseConfiguration Configuration { get; }

        public IPEndPoint ServerEndpoint { get; }
        
        public string ConnectionStringTemplate =>
            $"Host={ServerEndpoint.Address};Port={ServerEndpoint.Port};Database={Configuration.DatabaseName};Search Path={Configuration.SchemeName};";

        public string DefaultConnectionString => GetConnectionString(Configuration.DefaultUsername, Configuration.DefaultPassword);
        
        public string GetConnectionString(string username, string password)
        {
            return $"{ConnectionStringTemplate}User ID={username};Password={password};";
        }
    }
}