using DescriptionDomain = WhatToWatch.Domain.Entities.MovieDescription;
using DescriptionEntity = WhatToWatch.Data.PostgreSqlAccess.Entities.MovieDescription;

namespace WhatToWatch.Data.PostgreSqlAccess.Mappers
{
    public static class MovieDescriptionMapper
    {
        public static DescriptionDomain ToDomain(DescriptionEntity entity)
        {
            var description = new DescriptionDomain(entity.Content);
            return description;
        }

        public static DescriptionEntity ToEntity(DescriptionDomain domain)
        {
            var description = new DescriptionEntity { Content = domain.Content };
            return description;
        }
    }
}