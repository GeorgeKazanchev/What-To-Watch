using WhatToWatch.Data.PostgreSqlAccess.Mappers;
using DirectorDomain = WhatToWatch.Domain.Entities.Director;
using DirectorEntity = WhatToWatch.Data.PostgreSqlAccess.Entities.Director;

namespace WhatToWatch.Test.PostgreSqlAccess.MappersTest
{
    [TestFixture]
    public class DirectorMapperTest
    {
        [Test]
        public void ToDomainTest()
        {
            var directorEntity = new DirectorEntity { Name = "Stanley Kubrick" };
            var directorDomain = DirectorMapper.ToDomain(directorEntity);
            Assert.That(directorDomain, Is.Not.Null);
            Assert.That(directorDomain.Name, Is.EqualTo(directorEntity.Name));
        }

        [Test]
        public void ToEntityTest()
        {
            var directorDomain = new DirectorDomain("Stanley Kubrick");
            var directorEntity = DirectorMapper.ToEntity(directorDomain);
            Assert.That(directorEntity, Is.Not.Null);
            Assert.That(directorEntity.Name, Is.EqualTo(directorDomain.Name));
        }
    }
}