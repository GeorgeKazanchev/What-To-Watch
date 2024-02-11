using System.Net;
using WhatToWatch.Data.DbAccessInterfaces;
using WhatToWatch.Data.PostgreSqlAccess;
using WhatToWatch.Data.PostgreSqlAccess.Repository;

namespace WhatToWatch.Test.PostgreSqlAccess.RepositoryTest
{
    [TestFixture]
    public class MovieDescriptionRepositoryTest
    {
        public PostgreSqlDatabase Database { get; private set; }
        public MovieDescriptionRepository Repository { get; private set; }

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
            Repository = new MovieDescriptionRepository(Database.DefaultConnectionString);
        }

        [Test]
        public void ReadMovieDescriptionsTest()
        {
            var movieTitle = "The Aviator";
            var descriptions = Repository.ReadMovieDescriptions(movieTitle);
            Assert.That(descriptions, Has.Count.GreaterThan(0));
            Assert.That(descriptions.Any(d => d.Content.Length > 0), Is.True);
        }
    }
}