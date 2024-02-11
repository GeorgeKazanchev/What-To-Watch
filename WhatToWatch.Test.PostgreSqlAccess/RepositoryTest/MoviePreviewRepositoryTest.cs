using System.Net;
using WhatToWatch.Data.DbAccessInterfaces;
using WhatToWatch.Data.PostgreSqlAccess;
using WhatToWatch.Data.PostgreSqlAccess.Repository;

namespace WhatToWatch.Test.PostgreSqlAccess.RepositoryTest
{
    [TestFixture]
    public class MoviePreviewRepositoryTest
    {
        public PostgreSqlDatabase Database { get; private set; }
        public MoviePreviewRepository Repository { get; private set; }

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
            Repository = new MoviePreviewRepository(Database.DefaultConnectionString);
        }

        [Test]
        public void ReadMoviePreviewsTest()
        {
            var movieTitle = "The Aviator";
            var reviews = Repository.ReadMoviePreviews(movieTitle);
            Assert.That(reviews, Has.Count.GreaterThan(0));
            Assert.That(reviews.Any(r => r.Type == "video/mp4" && r.Source == "/video/preview-aviator.mp4"), Is.True);
        }
    }
}