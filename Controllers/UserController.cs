using Microsoft.AspNetCore.Mvc;
using mTechWebApi.str;
using System.Collections.Generic;

[Route("users")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet()]
    public ActionResult<IEnumerable<User>> GetUsers()
    {
        var users = _userService.GetUsers();
        return Ok(users);
    }
}
