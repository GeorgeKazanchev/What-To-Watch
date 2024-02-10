using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DbAccessInterfaces
{
    public interface IMovieDescriptionRepository
    {
        public List<MovieDescription> ReadMovieDescriptions(string movieTitle);
    }
}