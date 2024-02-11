using System.Net;
using WhatToWatch.Data.DbAccessInterfaces;
using WhatToWatch.Data.PostgreSqlAccess;
using WhatToWatch.Data.PostgreSqlAccess.Repository;

namespace WhatToWatch.Test.PostgreSqlAccess.RepositoryTest
{
    [TestFixture]
    public class DirectorRepositoryTest
    {
        public PostgreSqlDatabase Database { get; private set; }
        public DirectorRepository Repository { get; private set; }

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
            Repository = new DirectorRepository(Database.DefaultConnectionString);
        }

        [Test]
        public void ReadMovieDirectorsTest()
        {
            var movieTitle = "The Aviator";
            var directors = Repository.ReadMovieDirectors(movieTitle);
            Assert.That(directors, Has.Count.EqualTo(1));
            Assert.That(directors.Any(d => d.Name == "Martin Scorsese"), Is.True);
        }
    }
}