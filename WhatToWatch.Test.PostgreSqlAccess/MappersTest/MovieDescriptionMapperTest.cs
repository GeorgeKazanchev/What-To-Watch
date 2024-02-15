using WhatToWatch.Data.PostgreSqlAccess.Mappers;
using DescriptionDomain = WhatToWatch.Domain.Entities.MovieDescription;
using DescriptionEntity = WhatToWatch.Data.PostgreSqlAccess.Entities.MovieDescription;

namespace WhatToWatch.Test.PostgreSqlAccess.MappersTest
{
    [TestFixture]
    public class MovieDescriptionMapperTest
    {
        [Test]
        public void ToDomainTest()
        {
            var descriptionEntity = new DescriptionEntity { Content = "Description" };
            var descriptionDomain = MovieDescriptionMapper.ToDomain(descriptionEntity);
            Assert.That(descriptionDomain, Is.Not.Null);
            Assert.That(descriptionDomain.Content, Is.EqualTo(descriptionEntity.Content));
        }

        [Test]
        public void ToEntityTest()
        {
            var descriptionDomain = new DescriptionDomain("Description");
            var descriptionEntity = MovieDescriptionMapper.ToEntity(descriptionDomain);
            Assert.That(descriptionEntity, Is.Not.Null);
            Assert.That(descriptionEntity.Content, Is.EqualTo(descriptionDomain.Content));
        }
    }
}