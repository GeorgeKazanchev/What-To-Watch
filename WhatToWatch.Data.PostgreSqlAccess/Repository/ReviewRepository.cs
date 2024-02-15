using WhatToWatch.Data.DbAccessInterfaces.Repository;
using WhatToWatch.Data.PostgreSqlAccess.Mappers;
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

            var reviews = db.Reviews.Where(r => r.IdMovie == movie.Id).ToList();
            var reviewsDomain = new List<Review>();
            foreach (var review in reviews)
            {
                var author = db.Users.FirstOrDefault(u => u.Id == review.IdAuthor);
                if (author == null) throw new Exception("Пользователь, которому принадлежит отзыв, не найден в БД.");
                var authorDomain = UserMapper.ToDomain(author);
                reviewsDomain.Add(ReviewMapper.ToDomain(review, authorDomain));
            }

            return reviewsDomain;
        }
    }
}