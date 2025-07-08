
using Microsoft.AspNetCore.Mvc;
using Users.DTOs;
using Users.Interfaces;
using Users.Models;

namespace Users.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public ActionResult<User> Create(UserCreateDto dto)
    {
        var user = _userService.Create(dto);
        return CreatedAtAction(nameof(GetAll), new { id = user.Id }, user);
    }

    [HttpGet]
    public ActionResult<IEnumerable<User>> GetAll()
    {
        return Ok(_userService.GetAll());
    }
}
