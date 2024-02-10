using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DbAccessInterfaces
{
    public interface IActorRepository
    {
        public List<Actor> ReadMovieActors(string movieTitle);
    }
}