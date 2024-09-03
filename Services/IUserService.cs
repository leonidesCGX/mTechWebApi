using mTechWebApi.str;
using System.Collections.Generic;

public interface IUserService
{
    IEnumerable<User> GetUsers();
}
