using WhatToWatch.Data.DbAccessInterfaces.Repository;
using WhatToWatch.Data.PostgreSqlAccess.Mappers;
using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.PostgreSqlAccess.Repository
{
    public class DirectorRepository : IDirectorRepository
    {
        public DirectorRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }

        public List<Director> ReadMovieDirectors(string movieTitle)
        {
            using var db = new WtwContext(ConnectionString);
            var directors = db.Directors.Where(d => d.IdMovies.Any(m => m.Title == movieTitle));
            return directors.Select((director) => DirectorMapper.ToDomain(director)).ToList();
        }
    }
}