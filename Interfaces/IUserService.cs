
using Users.DTOs;
using Users.Models;

namespace Users.Interfaces;

public interface IUserService
{
    User Create(UserCreateDto userDto);
    IEnumerable<User> GetAll();
}
