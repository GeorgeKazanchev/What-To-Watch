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
            Database = Utility.CreateTestDatabase();
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