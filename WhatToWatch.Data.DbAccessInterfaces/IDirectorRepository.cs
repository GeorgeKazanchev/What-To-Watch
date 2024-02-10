using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DbAccessInterfaces
{
    public interface IDirectorRepository
    {
        public List<Director> ReadMovieDirectors(string movieTitle);
    }
}