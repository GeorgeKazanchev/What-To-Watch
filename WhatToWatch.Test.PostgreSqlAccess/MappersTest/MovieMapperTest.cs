using WhatToWatch.Data.PostgreSqlAccess.Mappers;
using WhatToWatch.Domain.Entities;
using MovieDomain = WhatToWatch.Domain.Entities.Movie;
using MovieEntity = WhatToWatch.Data.PostgreSqlAccess.Entities.Movie;

namespace WhatToWatch.Test.PostgreSqlAccess.MappersTest
{
    [TestFixture]
    public class MovieMapperTest
    {
        public List<Actor> Actors { get; private set; }
        public List<Director> Directors { get; private set; }
        public List<Genre> Genres { get; private set; }
        public List<MovieDescription> Descriptions { get; private set; }
        public List<Review> Reviews { get; private set; }
        public List<MoviePreview> Previews { get; private set; }

        [SetUp]
        public void InitializeTestMovie()
        {
            Actors = new List<Actor> { new Actor("Leonardo DiCaprio"), new Actor("Cate Blanchett") };
            Directors = new List<Director> { new Director("Martin Scorsese") };
            Genres = new List<Genre> { new Genre("Drama"), new Genre("Biography") };
            Descriptions = new List<MovieDescription> { new MovieDescription("One of the best films ever.") };
            Previews = new List<MoviePreview> { new MoviePreview("video/mp4", "/video/preview-aviator.mp4") };
            var reviewAuthor = new User("Review's author", new DateOnly(2016, 03, 05));
            Reviews = new List<Review> { new Review(reviewAuthor, "I think that's the best film ever.", 100, new DateTime(2018, 02, 04)) };
        }

        [Test]
        public void ToDomainTest()
        {
            var movieEntity = new MovieEntity
            {
                Title = "The Aviator",
                Runtime = 170,
                ReleaseYear = 2004,
                EndYear = null
            };

            var movieDomain = MovieMapper.ToDomain(movieEntity, Actors, Directors, Genres, Descriptions, Reviews, Previews);
            Assert.That(movieDomain, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(movieDomain.Actors, Is.Not.Null);
                Assert.That(movieDomain.Directors, Is.Not.Null);
                Assert.That(movieDomain.Genres, Is.Not.Null);
                Assert.That(movieDomain.Descriptions, Is.Not.Null);
                Assert.That(movieDomain.Previews, Is.Not.Null);
                Assert.That(movieDomain.Reviews, Is.Not.Null);
            });
            Assert.Multiple(() =>
            {
                Assert.That(movieDomain.Title, Is.EqualTo(movieEntity.Title));
                Assert.That(movieDomain.RunTime, Is.EqualTo(TimeSpan.FromMinutes(movieEntity.Runtime)));
                Assert.That(movieDomain.ReleaseYear, Is.EqualTo(movieEntity.ReleaseYear));
                Assert.That(movieDomain.EndYear, Is.EqualTo(movieEntity.EndYear));
                Assert.That(movieDomain.Actors, Has.Count.EqualTo(Actors.Count));
                Assert.That(movieDomain.Directors, Has.Count.EqualTo(Directors.Count));
                Assert.That(movieDomain.Genres, Has.Count.EqualTo(Genres.Count));
                Assert.That(movieDomain.Descriptions, Has.Count.EqualTo(Descriptions.Count));
                Assert.That(movieDomain.Previews, Has.Count.EqualTo(Previews.Count));
                Assert.That(movieDomain.Reviews, Has.Count.EqualTo(Reviews.Count));
            });
        }

        [Test]
        public void ToEntityTest()
        {
            var movieDomain = new MovieDomain("The Aviator", TimeSpan.FromMinutes(170), 2004, null, Actors, Directors,
                Genres, Descriptions, Reviews, Previews);
            var movieEntity = MovieMapper.ToEntity(movieDomain);
            Assert.That(movieEntity, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(movieEntity.Title, Is.EqualTo(movieDomain.Title));
                Assert.That(movieEntity.Runtime, Is.EqualTo(movieDomain.RunTime.Minutes));
                Assert.That(movieEntity.ReleaseYear, Is.EqualTo(movieDomain.ReleaseYear));
                Assert.That(movieEntity.EndYear, Is.EqualTo(movieDomain.EndYear));
            });
        }
    }
}