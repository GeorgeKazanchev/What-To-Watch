using WhatToWatch.Data.DbAccessInterfaces.Repository;
using WhatToWatch.Data.PostgreSqlAccess.Mappers;
using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.PostgreSqlAccess.Repository
{
    public class MovieDescriptionRepository : IMovieDescriptionRepository
    {
        public MovieDescriptionRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }

        public List<MovieDescription> ReadMovieDescriptions(string movieTitle)
        {
            using var db = new WtwContext(ConnectionString);
            var movie = db.Movies.FirstOrDefault(m => m.Title == movieTitle);
            if (movie == null) throw new Exception("Фильм с заданным названием не найден в БД.");
            var descriptions = db.MovieDescriptions.Where(d => d.IdMovie == movie.Id).ToList();
            return descriptions.Select(MovieDescriptionMapper.ToDomain).ToList();
        }
    }
}