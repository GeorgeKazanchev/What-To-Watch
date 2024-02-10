using System.Net;

namespace WhatToWatch.Data.DbAccessInterfaces
{
    public interface IDatabase
    {
        public string DatabaseName { get; }
        public string SchemeName { get; }
        public IPAddress ServerIpAddress { get; }
        public int Port { get; }
        public IPEndPoint ServerEndpoint { get; }
        public DatabaseType DatabaseType { get; }
        public string DefaultUsername { get; }
        public string DefaultPassword { get; }
        public string ConnectionStringTemplate { get; }
        public string DefaultConnectionString { get; }
        public string GetConnectionString(string username, string password);
    }
}