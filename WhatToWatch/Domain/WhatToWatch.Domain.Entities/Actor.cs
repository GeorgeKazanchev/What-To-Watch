namespace WhatToWatch.Domain.Entities
{
    public class Actor : ICloneable
    {
        public Actor(string name)
        {
            Name = name;
        }

        public Actor(Actor actor)
        {
            Name = actor.Name;
        }

        public string Name { get; }

        public object Clone()
        {
            return new Actor(this);
        }
    }
}