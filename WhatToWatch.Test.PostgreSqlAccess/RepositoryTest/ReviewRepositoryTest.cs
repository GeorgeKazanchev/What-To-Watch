using WhatToWatch.Data.PostgreSqlAccess;
using WhatToWatch.Data.PostgreSqlAccess.Repository;

namespace WhatToWatch.Test.PostgreSqlAccess.RepositoryTest
{
    [TestFixture]
    public class ReviewRepositoryTest
    {
        public PostgreSqlDatabase Database { get; private set; }
        public ReviewRepository Repository { get; private set; }

        [SetUp]
        public void InitializeDatabase()
        {
            Database = Utility.CreateTestDatabase();
            Repository = new ReviewRepository(Database.DefaultConnectionString);
        }

        [Test]
        public void ReadMovieReviewsTest()
        {
            var movieTitle = "The Aviator";
            var reviews = Repository.ReadMovieReviews(movieTitle).OrderByDescending(r => r.Rating).ToList();
            Assert.That(reviews, Has.Count.EqualTo(2));
            Assert.Multiple(() =>
            {
                Assert.That(reviews[0].Author.Name, Is.EqualTo("hankychan"));
                Assert.That(reviews[1].Author.Name, Is.EqualTo("RonellSowes"));
                Assert.That(reviews[0].Rating, Is.EqualTo(93));
                Assert.That(reviews[1].Rating, Is.EqualTo(72));
                Assert.That(reviews[0].Content, Has.Length.GreaterThan(0));
                Assert.That(reviews[1].Content, Has.Length.GreaterThan(0));
                Assert.That(reviews[0].CreationTime.Date, Is.EqualTo(new DateTime(2019, 11, 18)));
                Assert.That(reviews[1].CreationTime.Date, Is.EqualTo(new DateTime(2022, 02, 16)));
            });
        }
    }
}