using System.Net;

namespace WhatToWatch.Data.DbAccessInterfaces
{
    public class DatabaseConfiguration : ICloneable
    {
        public DatabaseConfiguration(string databaseName, string schemeName, IPAddress serverAddress, int port,
            DatabaseType databaseType, string defaultUsername, string defaultPassword) 
            : this(databaseName, schemeName, serverAddress, port, databaseType)
        {
            DefaultUsername = defaultUsername;
            DefaultPassword = defaultPassword;
        }

        public DatabaseConfiguration(string databaseName, string schemeName, IPAddress serverAddress, int port,
            DatabaseType databaseType)
        {
            DatabaseName = databaseName;
            SchemeName = schemeName;
            ServerAddress = serverAddress;
            Port = port;
            DatabaseType = databaseType;
            DefaultUsername = string.Empty;
            DefaultPassword = string.Empty;
        }

        public DatabaseConfiguration(DatabaseConfiguration configuration)
        {
            DatabaseName = configuration.DatabaseName;
            SchemeName = configuration.SchemeName;
            ServerAddress = configuration.ServerAddress;
            Port = configuration.Port;
            DatabaseType = configuration.DatabaseType;
            DefaultUsername = configuration.DefaultUsername;
            DefaultPassword = configuration.DefaultPassword;
        }

        public DatabaseType DatabaseType { get; }

        public string DatabaseName { get; }

        public string SchemeName { get; }

        public IPAddress ServerAddress { get; }

        public int Port { get; }

        public string DefaultUsername { get; }

        public string DefaultPassword { get; }

        public object Clone()
        {
            return new DatabaseConfiguration(this);
        }
    }
}