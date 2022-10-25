using Domain.DTOs;
using Domain.Models;

namespace Application.DAOInterfaces;

public interface IUserDAO
{
    Task<User> CreateAsync(User user);
    Task<User?> GetByUsername(string userName);
    public Task<IEnumerable<User>> GetAsync(SearchUserParameterDTO searchParameters);
    Task<User?> GetByIDAsync(int id);
}