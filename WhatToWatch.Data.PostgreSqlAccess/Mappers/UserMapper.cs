using UserDomain = WhatToWatch.Domain.Entities.User;
using UserEntity = WhatToWatch.Data.PostgreSqlAccess.Entities.User;

namespace WhatToWatch.Data.PostgreSqlAccess.Mappers
{
    public static class UserMapper
    {
        public static UserDomain ToDomain(UserEntity entity)
        {
            var user = new UserDomain(entity.Name, entity.RegistrationDate);
            return user;
        }

        public static UserEntity ToEntity(UserDomain domain)
        {
            var user = new UserEntity
            {
                Name = domain.Name,
                RegistrationDate = domain.RegistrationDate,
            };
            return user;
        }
    }
}