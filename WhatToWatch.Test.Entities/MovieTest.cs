using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Test.Entities
{
    [TestFixture]
    public class MovieTest
    {
        public Movie MockMovie { get; private set; }

        [SetUp]
        public void SetMockMovie()
        {
            string title = "Pulp Fiction";
            TimeSpan runTime = TimeSpan.FromMinutes(154);
            ushort? releaseYear = 1994;
            ushort? endYear = null;
            List<Actor> actors = new() { new Actor("John Travolta"), new Actor("Uma Thurman"), new Actor("Samuel L. Jackson") };
            List<Director> directors = new() { new Director("Quentin Tarantino") };
            List<Genre> genres = new() { new Genre("Drama"), new Genre("Crime") };
            List<MovieDescription> descriptions = new() { new MovieDescription(
                "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner " +
                "bandits intertwine in four tales of violence and redemption.")
            };
            List<Review> reviews = new() { new Review(new User("bevo-13678", new DateTime(2017, 05, 14)),
                "I like the bit with the cheeseburger. It makes me want to go and get a cheeseburger",
                100, new DateTime(2020, 03, 30))
            };
            List<MoviePreview> previews = new() { new MoviePreview("video/mp4", "/video/preview-pulp-fiction.mp4") };

            MockMovie = new(title, runTime, releaseYear, endYear, actors, directors, genres, descriptions, reviews, previews);
        }

        [Test]
        public void ConstructorTest()
        {
            string title = "The Grand Budapest Hotel";
            TimeSpan runTime = TimeSpan.FromMinutes(99);
            ushort? releaseYear = 2014;
            ushort? endYear = null;
            List<Actor> actors = new() { new Actor("Ralph Fiennes"), new Actor("F. Murray Abraham") };
            List<Director> directors = new() { new Director("Wes Anderson") };
            List<Genre> genres = new() { new Genre("Adventure"), new Genre("Comedy"), new Genre("Crime") };
            List<MovieDescription> descriptions = new() { new MovieDescription(
                "A writer encounters the owner of an aging high-class hotel, who tells him " + 
                "of his early years serving as a lobby boy in the hotel\\'s glorious years " +
                "under an exceptional concierge.") 
            };
            List<Review> reviews = new() { new Review(new User("iliasalk", new DateTime(2014, 01, 01)),
                "A totally dysfunctional and unrelated cast, an incomprehensible story and tons and tons of computer graphics",
                30, new DateTime(2018, 12, 21))
            };
            List<MoviePreview> previews = new() { new MoviePreview("video/mp4", "/video/preview-the-grand-budapest-hotel.mp4") };

            Movie movie = new(title, runTime, releaseYear, endYear, actors, directors, genres, descriptions,
                reviews, previews);
            Assert.Multiple(() =>
            {
                Assert.That(movie.Title, Is.EqualTo(title));
                Assert.That(movie.RunTime, Is.EqualTo(runTime));
                Assert.That(movie.ReleaseYear, Is.EqualTo(releaseYear));
                Assert.That(movie.EndYear, Is.EqualTo(endYear));
                Assert.That(movie.Actors, Is.Not.Null);
                Assert.That(movie.Directors, Is.Not.Null);
                Assert.That(movie.Genres, Is.Not.Null);
                Assert.That(movie.Descriptions, Is.Not.Null);
                Assert.That(movie.Reviews, Is.Not.Null);
                Assert.That(movie.Previews, Is.Not.Null);
                Assert.That(movie.Actors, Has.Count.EqualTo(actors.Count));
                Assert.That(movie.Directors, Has.Count.EqualTo(directors.Count));
                Assert.That(movie.Genres, Has.Count.EqualTo(genres.Count));
                Assert.That(movie.Descriptions, Has.Count.EqualTo(descriptions.Count));
                Assert.That(movie.Reviews, Has.Count.EqualTo(reviews.Count));
                Assert.That(movie.Previews, Has.Count.EqualTo(previews.Count));
            });
        }

        [Test]
        public void CopyConstructorTest()
        {
            Movie movie = new(MockMovie);
            Assert.Multiple(() =>
            {
                Assert.That(movie.Title, Is.EqualTo(MockMovie.Title));
                Assert.That(movie.RunTime, Is.EqualTo(MockMovie.RunTime));
                Assert.That(movie.ReleaseYear, Is.EqualTo(MockMovie.ReleaseYear));
                Assert.That(movie.EndYear, Is.EqualTo(MockMovie.EndYear));
                Assert.That(movie.Actors, Is.Not.Null);
                Assert.That(movie.Directors, Is.Not.Null);
                Assert.That(movie.Genres, Is.Not.Null);
                Assert.That(movie.Descriptions, Is.Not.Null);
                Assert.That(movie.Reviews, Is.Not.Null);
                Assert.That(movie.Previews, Is.Not.Null);
                Assert.That(movie.Actors, Has.Count.EqualTo(MockMovie.Actors.Count));
                Assert.That(movie.Directors, Has.Count.EqualTo(MockMovie.Directors.Count));
                Assert.That(movie.Genres, Has.Count.EqualTo(MockMovie.Genres.Count));
                Assert.That(movie.Descriptions, Has.Count.EqualTo(MockMovie.Descriptions.Count));
                Assert.That(movie.Reviews, Has.Count.EqualTo(MockMovie.Reviews.Count));
                Assert.That(movie.Previews, Has.Count.EqualTo(MockMovie.Previews.Count));
            });
        }
    }
}