using System.Net;
using WhatToWatch.Data.DbAccessInterfaces;
using WhatToWatch.Data.PostgreSqlAccess;
using WhatToWatch.Data.PostgreSqlAccess.Repository;

namespace WhatToWatch.Test.PostgreSqlAccess.RepositoryTest
{
    [TestFixture]
    public class UserRepositoryTest
    {
        public PostgreSqlDatabase Database { get; private set; }
        public UserRepository Repository { get; private set; }

        [SetUp]
        public void InitializeDatabase()
        {
            string databaseName = "what-to-watch-test";
            string schemeName = "public";
            IPAddress serverAddress = new(new byte[] { 127, 0, 0, 1 });
            int port = 5432;
            DatabaseType databaseType = DatabaseType.PostgreSql;
            string defaultUsername = "wtw_test_user";
            string defaultPassword = "test_password";

            Database = new PostgreSqlDatabase(databaseName, schemeName, serverAddress, port, databaseType,
                defaultUsername, defaultPassword);
            Repository = new UserRepository(Database.DefaultConnectionString);
        }

        [Test]
        public void ReadUserTest()
        {
            string name = "RonellSowes";
            var user = Repository.ReadUser(name);
            Assert.That(user, Is.Not.Null);
            Assert.That(user.Name, Is.EqualTo(name));
        }
    }
}