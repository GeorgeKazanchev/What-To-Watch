using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DbAccessInterfaces
{
    public interface IUserRepository
    {
        public User ReadUser(string name);
    }
}