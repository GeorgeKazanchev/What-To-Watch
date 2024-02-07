using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.DatabaseAccess
{
    public interface IUserRepository
    {
        public User ReadUser(string name);
    }
}