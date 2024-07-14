using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using user_info.Data;
using user_info.Entities;

namespace user_info.Controllers
{


    [Route("api/[controller]")]
    [ApiController]

    public class UsersController : ControllerBase
    {

        private readonly DataContext _Context;

        public UsersController(DataContext Context)
        {
            _Context = Context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _Context.Users.ToListAsync();

            return users;


        }


        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await _Context.Users.FindAsync(id);

            return Ok(user);
        }

    }
}
