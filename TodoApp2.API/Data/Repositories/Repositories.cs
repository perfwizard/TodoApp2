using TodoApp2.API.Models;

namespace TodoApp2.API.Data.Repositories
{
    public interface IUserRepository : IRepository<User> {}
    public interface ITodoRepository : IRepository<TodoItem> {}
    public interface ITaskRepository : IRepository<Task> {}
    
}