using WhatToWatch.Domain.Entities;
using ReviewDomain = WhatToWatch.Domain.Entities.Review;
using ReviewEntity = WhatToWatch.Data.PostgreSqlAccess.Entities.Review;

namespace WhatToWatch.Data.PostgreSqlAccess.Mappers
{
    public static class ReviewMapper
    {
        public static ReviewDomain ToDomain(ReviewEntity entity, User author)
        {
            var review = new ReviewDomain(author, entity.Content, entity.Rating, entity.CreationTime);
            return review;
        }

        public static ReviewEntity ToEntity(ReviewDomain domain)
        {
            var review = new ReviewEntity
            {
                Content = domain.Content,
                Rating = domain.Rating,
                CreationTime = domain.CreationTime
            };
            return review;
        }
    }
}