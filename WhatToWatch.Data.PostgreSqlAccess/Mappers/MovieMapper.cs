using WhatToWatch.Domain.Entities;
using MovieDomain = WhatToWatch.Domain.Entities.Movie;
using MovieEntity = WhatToWatch.Data.PostgreSqlAccess.Entities.Movie;

namespace WhatToWatch.Data.PostgreSqlAccess.Mappers
{
    public static class MovieMapper
    {
        public static MovieDomain ToDomain(MovieEntity entity, List<Actor> actors, List<Director> directors,
            List<Genre> genres, List<MovieDescription> descriptions, List<Review> reviews, List<MoviePreview> previews)
        {
            var movie = new MovieDomain(entity.Title, TimeSpan.FromMinutes(entity.Runtime), entity.ReleaseYear, entity.EndYear,
                actors, directors, genres, descriptions, reviews, previews);
            return movie;
        }

        public static MovieEntity ToEntity(MovieDomain domain)
        {
            var movie = new MovieEntity
            {
                Title = domain.Title,
                Runtime = domain.RunTime.Minutes,
                ReleaseYear = domain.ReleaseYear,
                EndYear = domain.EndYear
            };
            return movie;
        }
    }
}