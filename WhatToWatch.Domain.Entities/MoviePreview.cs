namespace WhatToWatch.Domain.Entities
{
    public class MoviePreview : ICloneable
    {
        public MoviePreview(string type, string source)
        {
            Type = type;
            Source = source;
        }

        public MoviePreview(MoviePreview preview)
        {
            Type = preview.Type;
            Source = preview.Source;
        }

        public string Type { get; }

        public string Source { get; }

        public object Clone()
        {
            return new MoviePreview(this);
        }
    }
}