using System.Net;
using WhatToWatch.Data.DbAccessInterfaces;
using WhatToWatch.Data.PostgreSqlAccess;
using WhatToWatch.Data.PostgreSqlAccess.Repository;

namespace WhatToWatch.Test.PostgreSqlAccess.RepositoryTest
{
    [TestFixture]
    public class GenreRepositoryTest
    {
        public PostgreSqlDatabase Database { get; private set; }
        public GenreRepository Repository { get; private set; }

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
            Repository = new GenreRepository(Database.DefaultConnectionString);
        }

        [Test]
        public void ReadMovieGenresTest()
        {
            var movieTitle = "The Aviator";
            var genres = Repository.ReadMovieGenres(movieTitle);
            Assert.That(genres, Has.Count.GreaterThan(0));
            Assert.Multiple(() =>
            {
                Assert.That(genres.Any(g => g.Name == "Drama"), Is.True);
                Assert.That(genres.Any(g => g.Name == "Biography"), Is.True);
            });
        }

        [Test]
        public void ReadAllGenresTest()
        {
            var genres = Repository.ReadAllGenres();
            Assert.That(genres, Has.Count.GreaterThan(0));
            Assert.That(genres.Any(g => g.Name == "Adventure"), Is.True);
        }
    }
}