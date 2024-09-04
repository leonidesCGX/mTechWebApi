using mTechWebApi.str;
using System.Collections.Generic;
using System.Linq;

public class UserService : IUserService
{
    private static readonly List<User> _users = new List<User>
    {
        new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
        new User { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" }
    };

    public IEnumerable<User> GetUsers()
    {
        return _users;
    }
}
