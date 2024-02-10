using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DbAccessInterfaces
{
    public interface IReviewRepository
    {
        public List<Review> ReadMovieReviews(string movieTitle);
    }
}