using Business.Abstract;
using Entiities.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;


        public UsersController(IUserService userService)
        {
            _userService = userService;

        }

        [HttpGet("getall")]
        public IActionResult Get()
        {

            var result = _userService.GetAll();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {

            var result = _userService.GetById(id);
            return Ok(result);

        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {

            _userService.Add(user);
            return Ok();

        }

        [HttpPost("delete")]
        public IActionResult Delete(User user)
        {
            _userService.Delete(user);
            return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(User user)
        {

            _userService.Update(user);
            return Ok();
        }
    }
}
