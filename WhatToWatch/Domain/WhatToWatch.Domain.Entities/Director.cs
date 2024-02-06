namespace WhatToWatch.Domain.Entities
{
    public class Director : ICloneable
    {
        public Director(string name)
        {
            Name = name;
        }

        public Director(Director director)
        {
            Name = director.Name;
        }

        public string Name { get; }

        public object Clone()
        {
            return new Director(this);
        }
    }
}