using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DatabaseAccess
{
    public interface IActorRepository
    {
        public List<Actor> ReadMovieActors(string movieTitle);
    }
}