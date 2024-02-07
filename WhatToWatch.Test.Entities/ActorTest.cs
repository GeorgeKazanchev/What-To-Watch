using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Test.Entities
{
    [TestFixture]
    public class ActorTest
    {
        public Actor MockActor { get; private set; }

        [SetUp]
        public void SetMockActor()
        {
            string name = "Leonardo DiCaprio";
            MockActor = new(name);
        }

        [Test]
        public void ConstructorTest()
        {
            string name = "Leonardo DiCaprio";
            Actor actor = new(name);
            Assert.That(actor.Name, Is.EqualTo(name));
        }

        [Test]
        public void CopyConstructorTest()
        {
            Actor actor = new(MockActor);
            Assert.That(actor.Name, Is.EqualTo(MockActor.Name));
        }
    }
}