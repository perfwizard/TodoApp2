using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoApp2.API.Data.Repositories;
using TodoApp2.API.Models;

namespace TodoApp2.API.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository _todoRepository;

        public TodoController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> GetIncomepleteItems() 
        {
            return  _todoRepository.GetMany(t => t.IsCompleted == true, t => t.Task );
        }
    }
}