using WhatToWatch.Data.PostgreSqlAccess.Mappers;
using UserDomain = WhatToWatch.Domain.Entities.User;
using UserEntity = WhatToWatch.Data.PostgreSqlAccess.Entities.User;

namespace WhatToWatch.Test.PostgreSqlAccess.MappersTest
{
    [TestFixture]
    public class UserMapperTest
    {
        [Test]
        public void ToDomainTest()
        {
            var userEntity = new UserEntity
            {
                Name = "User",
                RegistrationDate = new DateOnly(2016, 01, 01)
            };

            var userDomain = UserMapper.ToDomain(userEntity);
            Assert.That(userDomain, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(userDomain.Name, Is.EqualTo(userEntity.Name));
                Assert.That(userDomain.RegistrationDate, Is.EqualTo(userEntity.RegistrationDate));
            });
        }

        [Test]
        public void ToEntityTest()
        {
            var userDomain = new UserDomain("User", new DateOnly(2016, 01, 01));
            var userEntity = UserMapper.ToEntity(userDomain);
            Assert.That(userEntity, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(userEntity.Name, Is.EqualTo(userDomain.Name));
                Assert.That(userEntity.RegistrationDate, Is.EqualTo(userDomain.RegistrationDate));
            });
        }
    }
}