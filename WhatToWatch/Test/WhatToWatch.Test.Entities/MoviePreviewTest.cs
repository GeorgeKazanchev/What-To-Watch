using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Test.Entities
{
    [TestFixture]
    public class MoviePreviewTest
    {
        public MoviePreview MockPreview { get; private set; }

        [SetUp]
        public void SetMockPreview()
        {
            string type = "video/mp4";
            string source = "/video/preview-pulp-fiction.mp4";
            MockPreview = new(type, source);
        }

        [Test]
        public void ConstructorTest()
        {
            string type = "video/mp4";
            string source = "/video/preview-pulp-fiction.mp4";
            MoviePreview preview = new(type, source);
            Assert.Multiple(() =>
            {
                Assert.That(preview.Type, Is.EqualTo(type));
                Assert.That(preview.Source, Is.EqualTo(source));
            });
        }

        [Test]
        public void CopyConstructorTest()
        {
            MoviePreview preview = new(MockPreview);
            Assert.Multiple(() =>
            {
                Assert.That(preview, Is.Not.Null);
                Assert.That(preview.Type, Is.EqualTo(MockPreview.Type));
                Assert.That(preview.Source, Is.EqualTo(MockPreview.Source));
            });
        }
    }
}