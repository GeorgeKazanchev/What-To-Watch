using WhatToWatch.Data.DbAccessInterfaces.Repository;
using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.PostgreSqlAccess.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        public ReviewRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }

        public List<Review> ReadMovieReviews(string movieTitle)
        {
            using var db = new WtwContext(ConnectionString);
            var movie = db.Movies.FirstOrDefault(m => m.Title == movieTitle);
            if (movie == null) throw new Exception("Фильм с заданным названием не найден в БД.");
            throw new NotImplementedException();
        }
    }
}