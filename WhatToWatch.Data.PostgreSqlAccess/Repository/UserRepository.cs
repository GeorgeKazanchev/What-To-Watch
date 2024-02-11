using WhatToWatch.Data.DbAccessInterfaces.Repository;
using WhatToWatch.Data.PostgreSqlAccess.Mappers;
using WhatToWatch.Domain.Entities;

namespace WhatToWatch.Data.PostgreSqlAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }

        public User ReadUser(string name)
        {
            using var db = new WtwContext(ConnectionString);
            var user = db.Users.FirstOrDefault(u => u.Name == name);
            if (user == null) throw new Exception("Пользователь с заданным именем не найден в БД.");
            return UserMapper.ToDomain(user);
        }
    }
}