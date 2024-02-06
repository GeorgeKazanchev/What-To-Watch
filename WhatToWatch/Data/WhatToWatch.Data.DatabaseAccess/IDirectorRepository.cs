using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DatabaseAccess
{
    public interface IDirectorRepository
    {
        public List<Director> ReadMovieDirectors(string movieTitle);
    }
}