using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Database.Entity;
using UserService.Repository;

namespace UserService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginRepository _ILoginRepository;

        public LoginController(ILoginRepository iLoginRepository)
        {
            _ILoginRepository = iLoginRepository;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Authenticate([FromBody]Login model)
        {
            var user = _ILoginRepository.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }
       // [AllowAnonymous]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _ILoginRepository.GetAll();
            return Ok(users);
        }
    }
}