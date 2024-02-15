using WhatToWatch.Data.PostgreSqlAccess.Mappers;
using ActorDomain = WhatToWatch.Domain.Entities.Actor;
using ActorEntity = WhatToWatch.Data.PostgreSqlAccess.Entities.Actor;

namespace WhatToWatch.Test.PostgreSqlAccess.MappersTest
{
    [TestFixture]
    public class ActorMapperTest
    {
        [Test]
        public void ToDomainTest()
        {
            var actorEntity = new ActorEntity { Name = "Kate Beckinsale" };
            var actorDomain = ActorMapper.ToDomain(actorEntity);
            Assert.That(actorDomain, Is.Not.Null);
            Assert.That(actorDomain.Name, Is.EqualTo(actorEntity.Name));
        }

        [Test]
        public void ToEntityTest()
        {
            var actorDomain = new ActorDomain("Kate Beckinsale");
            var actorEntity = ActorMapper.ToEntity(actorDomain);
            Assert.That(actorEntity, Is.Not.Null);
            Assert.That(actorEntity.Name, Is.EqualTo(actorDomain.Name));
        }
    }
}