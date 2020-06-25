using LoginService.Interfaces;
using LoginService.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LoginService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAll());
        }

        [HttpGet]
        [Route("GetUserById/{id}")]
        public IActionResult GetUserById(string id)
        {
            return Ok(_userService.GetUserById(id));
        }

        [HttpPut]
        [Route("Editar")]
        public IActionResult Editar([FromBody] ApplicationUser user)
        {
            if (_userService.EditarUsuario(user))
                return Ok();
            else
                return BadRequest();

        }

        [HttpDelete]
        [Route("Eliminar/{userID}")]
        public IActionResult Eliminar(string userID)
        {
            if (_userService.EliminarUsuario(userID))
                return Ok();
            else
                return BadRequest();

        }
    }
}