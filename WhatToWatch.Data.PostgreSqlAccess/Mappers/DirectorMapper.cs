using DirectorDomain = WhatToWatch.Domain.Entities.Director;
using DirectorEntity = WhatToWatch.Data.PostgreSqlAccess.Entities.Director;

namespace WhatToWatch.Data.PostgreSqlAccess.Mappers
{
    public static class DirectorMapper
    {
        public static DirectorDomain ToDomain(DirectorEntity entity)
        {
            var director = new DirectorDomain(entity.Name);
            return director;
        }

        public static DirectorEntity ToEntity(DirectorDomain domain)
        {
            var director = new DirectorEntity { Name = domain.Name };   //  TODO: Список фильмов, поставленных режиссёром?
            return director;
        }
    }
}