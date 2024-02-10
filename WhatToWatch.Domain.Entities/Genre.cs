namespace WhatToWatch.Domain.Entities
{
    public class Genre : ICloneable
    {
        public Genre(string name)
        {
            Name = name;
        }

        public Genre(Genre genre)
        {
            Name = genre.Name;
        }

        public string Name { get; }

        public object Clone()
        {
            return new Genre(this);
        }
    }
}