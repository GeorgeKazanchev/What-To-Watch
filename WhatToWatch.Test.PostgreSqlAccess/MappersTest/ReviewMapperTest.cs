using WhatToWatch.Data.PostgreSqlAccess.Mappers;
using WhatToWatch.Domain.Entities;
using ReviewDomain = WhatToWatch.Domain.Entities.Review;
using ReviewEntity = WhatToWatch.Data.PostgreSqlAccess.Entities.Review;

namespace WhatToWatch.Test.PostgreSqlAccess.MappersTest
{
    [TestFixture]
    public class ReviewMapperTest
    {
        [Test]
        public void ToDomainTest()
        {
            var author = new User("Author", new DateOnly(2018, 06, 07));
            var reviewEntity = new ReviewEntity
            {
                Content = "Review's content",
                Rating = 88,
                CreationTime = new DateTime(2021, 09, 03)
            };

            var reviewDomain = ReviewMapper.ToDomain(reviewEntity, author);
            Assert.That(reviewDomain, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(reviewDomain.Content, Is.EqualTo(reviewEntity.Content));
                Assert.That(reviewDomain.Rating, Is.EqualTo(reviewEntity.Rating));
                Assert.That(reviewDomain.CreationTime, Is.EqualTo(reviewEntity.CreationTime));
            });
        }

        [Test]
        public void ToEntityTest()
        {
            var author = new User("Author", new DateOnly(2018, 06, 07));
            var reviewDomain = new ReviewDomain(author, "Review's content", 88, new DateTime(2021, 09, 03));
            var reviewEntity = ReviewMapper.ToEntity(reviewDomain);
            Assert.That(reviewEntity, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(reviewEntity.Content, Is.EqualTo(reviewDomain.Content));
                Assert.That(reviewEntity.Rating, Is.EqualTo(reviewDomain.Rating));
                Assert.That(reviewEntity.CreationTime, Is.EqualTo(reviewDomain.CreationTime));
            });
        }
    }
}