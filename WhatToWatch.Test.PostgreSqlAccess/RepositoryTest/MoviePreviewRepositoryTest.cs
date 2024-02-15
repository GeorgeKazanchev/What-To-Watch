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
            Database = Utility.CreateTestDatabase();
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