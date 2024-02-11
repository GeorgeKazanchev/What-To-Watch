using WhatToWatch.Data.DbAccessInterfaces.Repository;
using WhatToWatch.Data.PostgreSqlAccess.Mappers;
using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.PostgreSqlAccess.Repository
{
    public class MoviePreviewRepository : IMoviePreviewRepository
    {
        public MoviePreviewRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }

        public List<MoviePreview> ReadMoviePreviews(string movieTitle)
        {
            using var db = new WtwContext(ConnectionString);
            var movie = db.Movies.FirstOrDefault(m => m.Title == movieTitle);
            if (movie == null) throw new Exception("Фильм с заданным названием не найден в БД.");
            var previews = db.MoviePreviews.Where(mp => mp.IdMovie == movie.Id).ToList();
            return previews.Select(MoviePreviewMapper.ToDomain).ToList();
        }
    }
}