
using Users.DTOs;
using Users.Interfaces;
using Users.Models;
using Users.Data;

namespace Users.Services;

public class UserService : IUserService
{
    private readonly UsersDbContext _context;

    public UserService(UsersDbContext context)
    {
        _context = context;
    }

    public User Create(UserCreateDto userDto)
    {
        var user = new User
        {
            Name = userDto.Name,
            Email = userDto.Email
        };

        _context.Users.Add(user);
        _context.SaveChanges();

        return user;
    }

    public IEnumerable<User> GetAll()
    {
        return _context.Users.ToList();
    }
}
