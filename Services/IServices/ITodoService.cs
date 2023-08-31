using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Entities;

namespace ToDoApp.Services.IServices
{
    public interface ITodoService
    {
        Task<string> AddTodoAsync(Todo todo);
        Task<string> UpdateTodoAsync(Todo todo);
        Task<Todo> GetTodoById(Guid id);
        Task<List<Todo>> GetAllTodo();
        Task<string> DeleteTodoAsync(Todo todo);
    }
}