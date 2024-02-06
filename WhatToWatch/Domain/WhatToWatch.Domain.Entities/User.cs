namespace WhatToWatch.Domain.Entities
{
    public class User : ICloneable
    {
        public User(string name, DateTime registrationDate)
        {
            Name = name;
            RegistrationDate = registrationDate;
        }

        public User(User user)
        {
            Name = user.Name;
            RegistrationDate = user.RegistrationDate;
        }

        public string Name { get; }

        public DateTime RegistrationDate { get; }

        public object Clone()
        {
            return new User(this);
        }
    }
}