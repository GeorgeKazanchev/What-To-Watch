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
            Database = Utility.CreateTestDatabase();
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