using WhatToWatch.Data.DbAccessInterfaces.Repository;
using WhatToWatch.Data.PostgreSqlAccess.Mappers;
using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.PostgreSqlAccess.Repository
{
    public class MovieRepository : IMovieRepository
    {
        public MovieRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }

        public Movie ReadMovie(string title)
        {
            using var db = new WtwContext(ConnectionString);
            var movie = db.Movies.FirstOrDefault(m => m.Title == title);
            if (movie == null) throw new Exception("Фильм с заданным названием не найден в БД.");

            var actors = ReadMovieActors(title);
            var directors = ReadMovieDirectors(title);
            var genres = ReadMovieGenres(title);
            var descriptions = ReadMovieDescriptions(title);
            var reviews = ReadMovieReviews(title);
            var previews = ReadMoviePreviews(title);

            return MovieMapper.ToDomain(movie, actors, directors, genres, descriptions, reviews, previews);
        }

        public List<Movie> ReadAllMovies()
        {
            using var db = new WtwContext(ConnectionString);
            var movies = db.Movies.ToList();
            var moviesDomain = new List<Movie>();
            movies.ForEach(movie =>
            {
                var actors = ReadMovieActors(movie.Title);
                var directors = ReadMovieDirectors(movie.Title);
                var genres = ReadMovieGenres(movie.Title);
                var descriptions = ReadMovieDescriptions(movie.Title);
                var reviews = ReadMovieReviews(movie.Title);
                var previews = ReadMoviePreviews(movie.Title);
                moviesDomain.Add(MovieMapper.ToDomain(movie, actors, directors, genres, descriptions, reviews, previews));
            });
            return moviesDomain;
        }

        private List<Actor> ReadMovieActors(string movieTitle)
        {
            var actorRepository = new ActorRepository(ConnectionString);
            return actorRepository.ReadMovieActors(movieTitle);
        }

        private List<Director> ReadMovieDirectors(string movieTitle)
        {
            var directorRepository = new DirectorRepository(ConnectionString);
            return directorRepository.ReadMovieDirectors(movieTitle);
        }

        private List<Genre> ReadMovieGenres(string movieTitle)
        {
            var genreRepository = new GenreRepository(ConnectionString);
            return genreRepository.ReadMovieGenres(movieTitle);
        }

        private List<MovieDescription> ReadMovieDescriptions(string movieTitle)
        {
            var descriptionRepository = new MovieDescriptionRepository(ConnectionString);
            return descriptionRepository.ReadMovieDescriptions(movieTitle);
        }

        private List<MoviePreview> ReadMoviePreviews(string movieTitle)
        {
            var previewRepository = new MoviePreviewRepository(ConnectionString);
            return previewRepository.ReadMoviePreviews(movieTitle);
        }

        private List<Review> ReadMovieReviews(string movieTitle)
        {
            var reviewRepository = new ReviewRepository(ConnectionString);
            return reviewRepository.ReadMovieReviews(movieTitle);
        }
    }
}