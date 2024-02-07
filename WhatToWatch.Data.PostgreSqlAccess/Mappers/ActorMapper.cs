using ActorDomain = WhatToWatch.Domain.Entities.Actor;
using ActorEntity = WhatToWatch.Data.PostgreSqlAccess.Entities.Actor;

namespace WhatToWatch.Data.PostgreSqlAccess.Mappers
{
    public static class ActorMapper
    {
        public static ActorDomain ToDomain(ActorEntity entity)
        {
            var actor = new ActorDomain(entity.Name);
            return actor;
        }

        public static ActorEntity ToEntity(ActorDomain domain)
        {
            var actor = new ActorEntity { Name = domain.Name };     //  TODO: Список фильмов, в которых снимался актёр?
            return actor;
        }
    }
}