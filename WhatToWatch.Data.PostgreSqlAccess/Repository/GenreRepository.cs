using WhatToWatch.Data.DbAccessInterfaces.Repository;
using WhatToWatch.Data.PostgreSqlAccess.Mappers;
using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.PostgreSqlAccess.Repository
{
    public class GenreRepository : IGenreRepository
    {
        public GenreRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }

        public List<Genre> ReadMovieGenres(string movieTitle)
        {
            using var db = new WtwContext(ConnectionString);
            var genres = db.Genres.Where(g => g.IdMovies.Any(m => m.Title == movieTitle));
            return genres.Select(GenreMapper.ToDomain).ToList();
        }

        public List<Genre> ReadAllGenres()
        {
            using var db = new WtwContext(ConnectionString);
            var genres = db.Genres;
            return genres.Select(GenreMapper.ToDomain).ToList();
        }
    }
}