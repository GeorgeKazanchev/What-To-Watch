using NUnit.Framework;
using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Test.Entities
{
    [TestFixture]
    public class ReviewTest
    {
        public Review MockReview { get; private set; }

        [SetUp]
        public void SetMockReview()
        {
            User user = new("Prismark10", new DateOnly(2017, 07, 01));
            string content = "Fantastic Beasts: The Crimes of Grindelwald shows that J K Rowling should " +
                "not be writing screenplays";
            byte rating = 50;
            DateTime creationTime = new(2018, 11, 22);
            MockReview = new(user, content, rating, creationTime);
        }

        [Test]
        public void ConstructorTest()
        {
            User author = new("carmelarcher_01", new DateOnly(2015, 05, 07));
            string content = "Almost impossible to keep up with what was going on! Just jumped from one thing to " +
                "the next with no development, such a shame.";
            byte rating = 40;
            DateTime creationTime = new(2018, 12, 31);
            
            Review review = new(author, content, rating, creationTime);
            Assert.Multiple(() =>
            {
                Assert.That(review.Content, Is.EqualTo(content));
                Assert.That(review.Rating, Is.EqualTo(rating));
                Assert.That(review.CreationTime, Is.EqualTo(creationTime));
                Assert.That(review.Author, Is.Not.Null);
            });
            Assert.Multiple(() =>
            {
                Assert.That(review.Author.Name, Is.EqualTo(author.Name));
                Assert.That(review.Author.RegistrationDate, Is.EqualTo(author.RegistrationDate));
            });
        }

        [Test]
        public void CopyConstructorTest()
        {
            Review review = new(MockReview);
            Assert.Multiple(() =>
            {
                Assert.That(review.Content, Is.EqualTo(MockReview.Content));
                Assert.That(review.Rating, Is.EqualTo(MockReview.Rating));
                Assert.That(review.CreationTime, Is.EqualTo(MockReview.CreationTime));
                Assert.That(review.Author, Is.Not.Null);
            });
            Assert.Multiple(() =>
            {
                Assert.That(review.Author.Name, Is.EqualTo(MockReview.Author.Name));
                Assert.That(review.Author.RegistrationDate, Is.EqualTo(MockReview.Author.RegistrationDate));
            });
        }
    }
}