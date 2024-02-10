using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DbAccessInterfaces
{
    public interface IGenreRepository
    {
        public List<Genre> ReadMovieGenres(string movieTitle);
        public List<Genre> ReadAllGenres();
    }
}