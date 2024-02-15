using WhatToWatch.Data.PostgreSqlAccess;
using WhatToWatch.Data.PostgreSqlAccess.Repository;

namespace WhatToWatch.Test.PostgreSqlAccess.RepositoryTest
{
    [TestFixture]
    public class ActorRepositoryTest
    {
        public PostgreSqlDatabase Database { get; private set; }
        public ActorRepository Repository { get; private set; }

        [SetUp]
        public void InitializeDatabase()
        {
            Database = Utility.CreateTestDatabase();
            Repository = new ActorRepository(Database.DefaultConnectionString);
        }

        [Test]
        public void ReadMovieActorsTest()
        {
            var movieTitle = "The Aviator";
            var actors = Repository.ReadMovieActors(movieTitle);
            Assert.That(actors, Has.Count.GreaterThan(0));
            Assert.Multiple(() =>
            {
                Assert.That(actors.Any(a => a.Name == "Leonardo DiCaprio"));
                Assert.That(actors.Any(a => a.Name == "Cate Blanchett"));
                Assert.That(actors.Any(a => a.Name == "Kate Beckinsale"));
                Assert.That(actors.Any(a => a.Name == "John C. Reilly"));
            });
        }
    }
}