using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DbAccessInterfaces.Repository
{
    public interface IDirectorRepository
    {
        public List<Director> ReadMovieDirectors(string movieTitle);
    }
}