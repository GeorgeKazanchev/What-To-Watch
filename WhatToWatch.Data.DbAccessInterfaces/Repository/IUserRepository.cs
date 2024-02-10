using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DbAccessInterfaces.Repository
{
    public interface IUserRepository
    {
        public User ReadUser(string name);
    }
}