using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DbAccessInterfaces
{
    public interface IMovieRepository
    {
        public Movie ReadMovie(string title);
        public List<Movie> ReadAllMovies();
    }
}