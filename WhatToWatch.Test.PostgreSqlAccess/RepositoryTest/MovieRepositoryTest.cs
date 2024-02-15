using WhatToWatch.Data.PostgreSqlAccess;
using WhatToWatch.Data.PostgreSqlAccess.Repository;

namespace WhatToWatch.Test.PostgreSqlAccess.RepositoryTest
{
    [TestFixture]
    public class MovieRepositoryTest
    {
        public PostgreSqlDatabase Database { get; private set; }
        public MovieRepository Repository { get; private set; }

        [SetUp]
        public void InitializeDatabase()
        {
            Database = Utility.CreateTestDatabase();
            Repository = new MovieRepository(Database.DefaultConnectionString);
        }

        [Test]
        public void ReadMovieTest()
        {
            var title = "The Aviator";
            var movie = Repository.ReadMovie(title);
            Assert.That(movie, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(movie.Title, Is.EqualTo(title));
                Assert.That(movie.RunTime, Is.EqualTo(TimeSpan.FromMinutes(170)));
                Assert.That(movie.ReleaseYear, Is.EqualTo(2004));
                Assert.That(movie.EndYear, Is.EqualTo(null));
            });
            Assert.Multiple(() =>
            {
                Assert.That(movie.Actors, Is.Not.Null);
                Assert.That(movie.Directors, Is.Not.Null);
                Assert.That(movie.Genres, Is.Not.Null);
                Assert.That(movie.Descriptions, Is.Not.Null);
                Assert.That(movie.Previews, Is.Not.Null);
                Assert.That(movie.Reviews, Is.Not.Null);
            });
            Assert.Multiple(() =>
            {
                Assert.That(movie.Actors, Has.Count.EqualTo(4));
                Assert.That(movie.Directors, Has.Count.EqualTo(1));
                Assert.That(movie.Directors[0].Name, Is.EqualTo("Martin Scorsese"));
                Assert.That(movie.Genres, Has.Count.EqualTo(2));
                Assert.That(movie.Descriptions, Has.Count.EqualTo(1));
                Assert.That(movie.Descriptions[0].Content, Is.EqualTo("A biopic depicting the early years of legendary director " +
                    "and aviator Howard Hughes career from the late 1920s to the mid 1940s."));
                Assert.That(movie.Previews, Has.Count.EqualTo(1));
                Assert.That(movie.Previews[0].Type, Is.EqualTo("video/mp4"));
                Assert.That(movie.Previews[0].Source, Is.EqualTo("/video/preview-aviator.mp4"));
                Assert.That(movie.Genres, Has.Count.EqualTo(2));
                Assert.That(movie.Genres.Any(g => g.Name == "Drama"), Is.True);
                Assert.That(movie.Genres.Any(g => g.Name == "Biography"), Is.True);
                Assert.That(movie.Reviews, Has.Count.EqualTo(2));
                Assert.That(movie.Reviews.Any(r => r.Rating == 93), Is.True);
                Assert.That(movie.Reviews.Any(r => r.Rating == 72), Is.True);
                Assert.That(movie.Reviews.Any(r => r.Author.Name == "hankychan"), Is.True);
                Assert.That(movie.Reviews.Any(r => r.Author.Name == "RonellSowes"), Is.True);
                Assert.That(movie.Reviews.Any(r => r.CreationTime.Date == new DateTime(2019, 11, 18)), Is.True);
                Assert.That(movie.Reviews.Any(r => r.CreationTime.Date == new DateTime(2022, 02, 16)), Is.True);
            });
        }

        [Test]
        public void ReadAllMoviesTest()
        {
            var movies = Repository.ReadAllMovies();
            Assert.That(movies, Is.Not.Null);
            Assert.That(movies, Has.Count.GreaterThan(0));
        }
    }
}