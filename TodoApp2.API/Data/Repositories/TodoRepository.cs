using TodoApp2.API.Models;

namespace TodoApp2.API.Data.Repositories
{
    public class TodoRepository : BaseRepository<TodoItem>, ITodoRepository
    {
        public TodoRepository(TodoContext context) : base(context)
        {
        }
    }
}