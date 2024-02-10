using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Test.Entities
{
    [TestFixture]
    public class UserTest
    {
        public User MockUser { get; private set; }

        [SetUp]
        public void SetMockUser()
        {
            string name = "Chameleon777";
            DateOnly registrationDate = new(2017, 06, 05);
            MockUser = new(name, registrationDate);
        }

        [Test]
        public void ConstructorTest()
        {
            string name = "Chameleon007";
            DateOnly registrationDate = new(2018, 04, 01);
            User user = new(name, registrationDate);
            Assert.Multiple(() =>
            {
                Assert.That(user.Name, Is.EqualTo(name));
                Assert.That(user.RegistrationDate, Is.EqualTo(registrationDate));
            });
        }

        [Test]
        public void CopyConstructorTest()
        {
            User user = new(MockUser);
            Assert.Multiple(() =>
            {
                Assert.That(user.Name, Is.EqualTo(MockUser.Name));
                Assert.That(user.RegistrationDate, Is.EqualTo(MockUser.RegistrationDate));
            });
        }
    }
}