using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Test.Entities
{
    [TestFixture]
    public class MovieDescriptionTest
    {
        public MovieDescription MockDescription { get; private set; }

        [SetUp]
        public void SetMockDescription()
        {
            string content = "While out hunting, Llewelyn finds the grisly aftermath of a drug deal. Though he " +
                "knows better, he cannot resist the cash left behind and takes it. The hunter becomes the hunted " +
                "when a merciless killer named Chigurh picks up his trail.";
            MockDescription = new MovieDescription(content);
        }

        [Test]
        public void ConstructorTest()
        {
            string content = "An alien invasion threatens the future of humanity.";
            MovieDescription description = new(content);
            Assert.That(description.Content, Is.EqualTo(content));
        }

        [Test]
        public void CopyConstructorTest()
        {
            MovieDescription description = new(MockDescription);
            Assert.That(description.Content, Is.EqualTo(MockDescription.Content));
        }
    }
}