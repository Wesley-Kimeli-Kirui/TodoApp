using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Entities;
using ToDoApp.Requests;
using ToDoApp.ResponseDTO;
using ToDoApp.Services.IServices;

namespace ToDoApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService, IMapper mapper)
        {
            _mapper = mapper;
            _todoService = todoService;
        }
        [HttpPost]
        public async Task<ActionResult<TodoSuccess>> AddTodo(AddTodo newTodo)
        {
            var todo = _mapper.Map<Todo>(newTodo);
            var result = await _todoService.AddTodoAsync(todo);
            return CreatedAtAction(nameof(AddTodo), new TodoSuccess(200, result));
            // return Ok(new TodoSuccess(200, result));
        }
    }
}