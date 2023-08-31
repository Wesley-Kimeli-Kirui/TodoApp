using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Data;
using ToDoApp.Entities;
using ToDoApp.Services.IServices;

// Repository Pattern
namespace ToDoApp.Services
{
    public class TodoService : ITodoService
    {
        private readonly TodoDbContext _db;
        public TodoService(TodoDbContext context)
        {
            _db = context;
        }

        public async Task<string> AddTodoAsync(Todo todo)
        {
            _db.Todos.Add(todo);
            await _db.SaveChangesAsync();
            return "Todo Added Successfully";
        }
        public async Task<string> UpdateTodoAsync(Todo todo)
        {
            _db.Todos.Update(todo);
            await _db.SaveChangesAsync();
            return "Todo Updated Successfully";
        }

        public async Task<Todo> GetTodoById(Guid id)
        {
            return await _db.Todos.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        public async Task<List<Todo>> GetAllTodo()
        {
            return await _db.Todos.ToListAsync();
        }
        public async Task<string> DeleteTodoAsync(Todo todo)
        {
            _db.Todos.Remove(todo);
            await _db.SaveChangesAsync();
            return "Todo Deleted Successfully";
        }

    }
}