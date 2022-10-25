using Application.DAOInterfaces;
using Application.LogicInterfaces;
using Domain.DTOs;
using Domain.Models;

namespace Application.Logic;

public class UserLogic : IUserLogic
{
    private readonly IUserDAO UserDao;

    public UserLogic(IUserDAO userDao)
    {
        this.UserDao = userDao;
    }
    
    public async Task<User> CreateAsync(UserCreationDTO dto)
    {
        User? existing = await UserDao.GetByUsername(dto.UserName);
        if (existing != null)
        {
            throw new Exception("Username already taken");
        }

        ValidateData(dto);
        {
            User toCreate = new User
            {
                UserName = dto.UserName
            };

            User created = await UserDao.CreateAsync(toCreate);

            return created;
        }
    }

    public Task<IEnumerable<User>> GetAsync(SearchUserParameterDTO searchUserParameters)
    {
        return UserDao.GetAsync(searchUserParameters);
    }

    private static void ValidateData(UserCreationDTO userToCreate)
    {
        string userName = userToCreate.UserName;

        if (userName.Length < 3)
            throw new Exception("Username must be at least 3 characters long");

        if (userName.Length > 15)
            throw new Exception("Username must be less than 16 characters");
    }
}