using GenreDomain = WhatToWatch.Domain.Entities.Genre;
using GenreEntity = WhatToWatch.Data.PostgreSqlAccess.Entities.Genre;

namespace WhatToWatch.Data.PostgreSqlAccess.Mappers
{
    public static class GenreMapper
    {
        public static GenreDomain ToDomain(GenreEntity entity)
        {
            var genre = new GenreDomain(entity.Name);
            return genre;
        }

        public static GenreEntity ToEntity(GenreDomain domain)
        {
            var genre = new GenreEntity { Name = domain.Name };
            return genre;
        }
    }
}