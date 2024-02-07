using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DatabaseAccess
{
    public interface IReviewRepository
    {
        public List<Review> ReadMovieReviews(string movieTitle);
    }
}