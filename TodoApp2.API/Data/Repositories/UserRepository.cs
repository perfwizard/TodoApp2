using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TodoApp2.API.Models;

namespace TodoApp2.API.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(TodoContext context) : base(context)
        {
        }
    }
}