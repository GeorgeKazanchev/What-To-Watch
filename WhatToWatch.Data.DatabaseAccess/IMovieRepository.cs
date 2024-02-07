using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DatabaseAccess
{
    public interface IMovieRepository
    {
        public Movie ReadMovie(string title);
        public List<Movie> ReadAllMovies();
    }
}