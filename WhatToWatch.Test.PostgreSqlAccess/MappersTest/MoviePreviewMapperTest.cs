using WhatToWatch.Data.PostgreSqlAccess.Mappers;
using PreviewDomain = WhatToWatch.Domain.Entities.MoviePreview;
using PreviewEntity = WhatToWatch.Data.PostgreSqlAccess.Entities.MoviePreview;

namespace WhatToWatch.Test.PostgreSqlAccess.MappersTest
{
    [TestFixture]
    public class MoviePreviewMapperTest
    {
        [Test]
        public void ToDomainTest()
        {
            var previewEntity = new PreviewEntity
            {
                Type = "video/mp4",
                Source = "/video/preview-aviator.mp4"
            };

            var previewDomain = MoviePreviewMapper.ToDomain(previewEntity);
            Assert.That(previewDomain, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(previewDomain.Type, Is.EqualTo(previewEntity.Type));
                Assert.That(previewDomain.Source, Is.EqualTo(previewEntity.Source));
            });
        }

        [Test]
        public void ToEntityTest()
        {
            var previewDomain = new PreviewDomain("video/mp4", "/video/preview-aviator.mp4");
            var previewEntity = MoviePreviewMapper.ToEntity(previewDomain);
            Assert.That(previewEntity, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(previewEntity.Type, Is.EqualTo(previewDomain.Type));
                Assert.That(previewEntity.Source, Is.EqualTo(previewDomain.Source));
            });
        }
    }
}