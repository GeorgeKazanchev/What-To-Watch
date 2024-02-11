using WhatToWatch.Data.DbAccessInterfaces.Repository;
using WhatToWatch.Data.PostgreSqlAccess.Mappers;
using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.PostgreSqlAccess.Repository
{
    public class ActorRepository : IActorRepository
    {
        public ActorRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }

        public List<Actor> ReadMovieActors(string movieTitle)
        {
            using var db = new WtwContext(ConnectionString);
            var actors = db.Actors.Where(a => a.IdMovies.Any(m => m.Title == movieTitle));
            return actors.Select((actor) => ActorMapper.ToDomain(actor)).ToList();
        }
    }
}