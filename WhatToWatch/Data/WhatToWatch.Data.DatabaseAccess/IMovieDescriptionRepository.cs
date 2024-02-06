using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DatabaseAccess
{
    public interface IMovieDescriptionRepository
    {
        public List<MovieDescription> ReadMovieDescriptions(string movieTitle);
    }
}