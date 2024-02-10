using System.Net;
using WhatToWatch.Data.DbAccessInterfaces;

namespace WhatToWatch.Data.PostgreSqlAccess
{
    public class PostgreSqlDatabase : IDatabase
    {
        public PostgreSqlDatabase(string databaseName, string schemeName, IPAddress serverIpAddress, int port,
            DatabaseType databaseType, string defaultUsername, string defaultPassword) 
            : this(databaseName, schemeName, serverIpAddress, port, databaseType)
        {
            DefaultUsername = defaultUsername;
            DefaultPassword = defaultPassword;
        }

        public PostgreSqlDatabase(string databaseName, string schemeName, IPAddress serverIpAddress, int port,
            DatabaseType databaseType)
        {
            DatabaseName = databaseName;
            SchemeName = schemeName;
            ServerIpAddress = serverIpAddress;
            Port = port;
            ServerEndpoint = new IPEndPoint(serverIpAddress, port);
            DatabaseType = databaseType;
            DefaultUsername = string.Empty;
            DefaultPassword = string.Empty;
        }

        public string DatabaseName { get; }
        
        public string SchemeName { get; }
        
        public IPAddress ServerIpAddress { get; }
        
        public int Port { get; }
        
        public IPEndPoint ServerEndpoint { get; }
        
        public DatabaseType DatabaseType { get; }
        
        public string DefaultUsername { get; }
        
        public string DefaultPassword { get; }
        
        public string ConnectionStringTemplate =>
            $"Host={ServerEndpoint.Address};Port={ServerEndpoint.Port};Database={DatabaseName};Search Path={SchemeName};";

        public string DefaultConnectionString => GetConnectionString(DefaultUsername, DefaultPassword);
        
        public string GetConnectionString(string username, string password)
        {
            return $"{ConnectionStringTemplate}User ID={username};Password={password};";
        }
    }
}