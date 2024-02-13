using System.Net;

namespace WhatToWatch.Data.DbAccessInterfaces
{
    public interface IDatabase
    {
        public DatabaseConfiguration Configuration { get; }
        public IPEndPoint ServerEndpoint { get; }
        public string ConnectionStringTemplate { get; }
        public string DefaultConnectionString { get; }
        public string GetConnectionString(string username, string password);
    }
}