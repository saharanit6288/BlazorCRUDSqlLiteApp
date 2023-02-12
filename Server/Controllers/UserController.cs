using BlazorCRUDSqlLiteApp.Server.Interfaces;
using BlazorCRUDSqlLiteApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCRUDSqlLiteApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUser _IUser;

        public UserController(IUser user)
        {
            _IUser = user;

        }
        [HttpGet]
        [Route("GetUsers")]
        public List<User> GetUsers()
        {
            return _IUser.GetUsers();
        }

        [HttpGet]
        [Route("GetUser/{id}")]
        public IActionResult GetUser(int id)
        {
            User user = _IUser.GetUserById(id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("AddUser")]
        public void AddUser(User user)
        {
            _IUser.AddUser(user);
        }

        [HttpPut]
        [Route("UpdateUser")]
        public void UpdateUser(User user)
        {
            _IUser.UpdateUser(user);
        }

        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public IActionResult Delete(int id)
        {
            _IUser.DeleteUser(id);
            return Ok();
        }
    }
}
