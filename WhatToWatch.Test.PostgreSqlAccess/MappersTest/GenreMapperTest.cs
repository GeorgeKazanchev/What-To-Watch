using WhatToWatch.Data.PostgreSqlAccess.Mappers;
using GenreDomain = WhatToWatch.Domain.Entities.Genre;
using GenreEntity = WhatToWatch.Data.PostgreSqlAccess.Entities.Genre;

namespace WhatToWatch.Test.PostgreSqlAccess.MappersTest
{
    [TestFixture]
    public class GenreMapperTest
    {
        [Test]
        public void ToDomainTest()
        {
            var genreEntity = new GenreEntity { Name = "Western" };
            var genreDomain = GenreMapper.ToDomain(genreEntity);
            Assert.That(genreDomain, Is.Not.Null);
            Assert.That(genreDomain.Name, Is.EqualTo(genreEntity.Name));
        }

        [Test]
        public void ToEntityTest()
        {
            var genreDomain = new GenreDomain("Western");
            var genreEntity = GenreMapper.ToEntity(genreDomain);
            Assert.That(genreEntity, Is.Not.Null);
            Assert.That(genreEntity.Name, Is.EqualTo(genreDomain.Name));
        }
    }
}