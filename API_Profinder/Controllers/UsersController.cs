using API_Profinder.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Profinder_Domain.Models;
using System.Linq;

namespace API_Profinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private ProfinderContext _data;
        public UsersController(ProfinderContext data)
        {
            _data = data;
        }
        [HttpGet]
        public IActionResult GetUser(string email, string password)
        {
            User userDb = _data.Users.FirstOrDefault(a => a.Email == email && a.Password == password);
            
            if(userDb == null)
            {
                return NotFound();
            }
            return new JsonResult(userDb);
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            // FALTA VALIDAÇÃO

            _data.Users.Add(user);
            _data.SaveChanges();

            return CreatedAtAction(nameof(GetUser), new { email = user.Email, password = user.Password }, user);


                }

    }
}
