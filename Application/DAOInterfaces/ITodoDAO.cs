using Domain.DTOs;
using Domain.Models;

namespace Application.DAOInterfaces;

public interface ITodoDAO
{
    Task<Todo> CreateAsync(Todo todo);
    Task<IEnumerable<Todo>> GetAsync(SearchTodoParametersDTO searchParameters);

    Task UpdateAsync(Todo todo);

    Task<Todo> GetByIdAsync(int id);

    Task DeleteAsync(int id);
}