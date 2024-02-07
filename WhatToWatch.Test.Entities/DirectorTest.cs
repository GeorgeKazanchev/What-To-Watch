using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Test.Entities
{
    [TestFixture]
    public class DirectorTest
    {
        public Director MockDirector { get; private set; }

        [SetUp]
        public void SetMockDirector()
        {
            string name = "Quentin Tarantino";
            MockDirector = new(name);
        }

        [Test]
        public void ConstructorTest()
        {
            string name = "Quentin Tarantino";
            Director director = new(name);
            Assert.That(director.Name, Is.EqualTo(name));
        }

        [Test]
        public void CopyConstructorTest()
        {
            Director director = new(MockDirector);
            Assert.That(director.Name, Is.EqualTo(MockDirector.Name));
        }
    }
}