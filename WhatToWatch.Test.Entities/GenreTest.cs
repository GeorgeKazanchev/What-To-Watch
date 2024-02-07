using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Test.Entities
{
    [TestFixture]
    public class GenreTest
    {
        public Genre MockGenre { get; private set; }

        [SetUp]
        public void SetMockGenre()
        {
            string name = "Neo-noir";
            MockGenre = new Genre(name);
        }

        [Test]
        public void ConstructorTest()
        {
            string name = "Drama";
            Genre genre = new(name);
            Assert.That(genre.Name, Is.EqualTo(name));
        }

        [Test]
        public void CopyConstructorTest()
        {
            Genre genre = new(MockGenre);
            Assert.That(genre.Name, Is.EqualTo(MockGenre.Name));
        }
    }
}