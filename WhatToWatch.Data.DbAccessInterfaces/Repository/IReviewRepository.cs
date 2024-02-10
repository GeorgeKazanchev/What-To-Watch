using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DbAccessInterfaces.Repository
{
    public interface IReviewRepository
    {
        public List<Review> ReadMovieReviews(string movieTitle);
    }
}