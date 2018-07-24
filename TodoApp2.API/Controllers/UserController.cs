using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApp2.API.Data;
using TodoApp2.API.Data.Repositories;
using TodoApp2.API.Models;

namespace TodoApp2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userrRepository;

        public UserController(IUserRepository userrRepository)
        {
            _userrRepository = userrRepository;
        }
        
        [HttpGet]
        public  ActionResult<IEnumerable<User>> Get()
        {
            return _userrRepository.GetAll().ToList();
        }

        [HttpGet("id")]
        public ActionResult<User> GetById(int id)
        {
            return _userrRepository.GetById(id);
        }
        
        [HttpPost]
        public void Create([FromBody]User user)
        {
            _userrRepository.Add(user);
        }

        [HttpPut]
        public void Update([FromBody]User user)
        {
            _userrRepository.Update(user);
        }
    }
}