using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DbAccessInterfaces.Repository
{
    public interface IMovieDescriptionRepository
    {
        public List<MovieDescription> ReadMovieDescriptions(string movieTitle);
    }
}