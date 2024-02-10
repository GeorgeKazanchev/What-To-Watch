using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DbAccessInterfaces.Repository
{
    public interface IActorRepository
    {
        public List<Actor> ReadMovieActors(string movieTitle);
    }
}