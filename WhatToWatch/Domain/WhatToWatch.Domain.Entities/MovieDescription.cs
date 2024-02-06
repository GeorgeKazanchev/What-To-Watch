namespace WhatToWatch.Domain.Entities
{
    public class MovieDescription : ICloneable
    {
        public MovieDescription(string content)
        {
            Content = content;
        }

        public MovieDescription(MovieDescription description)
        {
            Content = description.Content;
        }

        public string Content { get; }

        public object Clone()
        {
            return new MovieDescription(this);
        }
    }
}