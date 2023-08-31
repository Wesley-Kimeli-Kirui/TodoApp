using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ToDoApp.Entities;
using ToDoApp.Requests;
using ToDoApp.ResponseDTO;

namespace ToDoApp.TodoProfiles
{
    public class TodosProfiles : Profile
    {
        public TodosProfiles()
        {
            // map from Todo to TodoResponse
            CreateMap<Todo, TodoResponse>().ReverseMap();
            // map from AddTodo to Todo
            CreateMap<AddTodo, Todo>();
        }
    }
}