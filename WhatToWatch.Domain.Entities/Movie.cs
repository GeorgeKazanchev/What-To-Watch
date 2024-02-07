namespace WhatToWatch.Domain.Entities
{
    public class Movie : ICloneable
    {
        public Movie(string title, TimeSpan runTime, ushort? releaseYear, ushort? endYear,
            List<Actor> actors, List<Director> directors, List<Genre> genres, List<MovieDescription> descriptions,
            List<Review> reviews, List<MoviePreview> previews)
        {
            Title = title;
            RunTime = runTime;
            ReleaseYear = releaseYear;
            EndYear = endYear;
            Actors = new List<Actor>(actors);
            Directors = new List<Director>(directors);
            Genres = new List<Genre>(genres);
            Descriptions = new List<MovieDescription>(descriptions);
            Reviews = new List<Review>(reviews);
            Previews = new List<MoviePreview>(previews);
        }

        public Movie(Movie movie)
        {
            Title = movie.Title;
            RunTime = movie.RunTime;
            ReleaseYear = movie.ReleaseYear;
            EndYear = movie.EndYear;
            Actors = new List<Actor>(movie.Actors);
            Directors = new List<Director>(movie.Directors);
            Genres = new List<Genre>(movie.Genres);
            Descriptions = new List<MovieDescription>(movie.Descriptions);
            Reviews = new List<Review>(movie.Reviews);
            Previews = new List<MoviePreview>(movie.Previews);
        }

        public string Title { get; }

        public TimeSpan RunTime { get; }

        public ushort? ReleaseYear { get; }

        public ushort? EndYear { get; }

        public List<Actor> Actors { get; }

        public List<Director> Directors { get; }

        public List<Genre> Genres { get; }

        public List<MovieDescription> Descriptions { get; }

        public List<Review> Reviews { get; }

        public List<MoviePreview> Previews { get; }

        public object Clone()
        {
            return new Movie(this);
        }
    }
}