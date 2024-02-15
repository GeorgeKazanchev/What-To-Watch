using WhatToWatch.Data.PostgreSqlAccess;
using WhatToWatch.Data.PostgreSqlAccess.Repository;

namespace WhatToWatch.Test.PostgreSqlAccess.RepositoryTest
{
    [TestFixture]
    public class UserRepositoryTest
    {
        public PostgreSqlDatabase Database { get; private set; }
        public UserRepository Repository { get; private set; }

        [SetUp]
        public void InitializeDatabase()
        {
            Database = Utility.CreateTestDatabase();
            Repository = new UserRepository(Database.DefaultConnectionString);
        }

        [Test]
        public void ReadUserTest()
        {
            string name = "RonellSowes";
            var user = Repository.ReadUser(name);
            Assert.That(user, Is.Not.Null);
            Assert.That(user.Name, Is.EqualTo(name));
        }
    }
}