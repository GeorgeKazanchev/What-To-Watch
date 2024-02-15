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
            Database = Utility.CreateTestDatabase();
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