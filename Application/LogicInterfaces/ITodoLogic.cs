using Domain.DTOs;
using Domain.Models;

namespace Application.LogicInterfaces;

public interface ITodoLogic
{
    Task<Todo> CreateAsync(TodoCreationDTO dto);
    Task<IEnumerable<Todo>> GetAsync(SearchTodoParametersDTO searchParameters);
    Task UpdateAsync(TodoUpdateDTO todo);

    Task DeleteAsync(int id);
    
    Task<TodoBasicDTO> GetByIdAsync(int id);
}