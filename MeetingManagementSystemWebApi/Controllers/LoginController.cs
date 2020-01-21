using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MeetingManagementSystemWebApi.Models;
using Microsoft.AspNetCore.Cors;

namespace MeetingManagementSystemWebApi.Controllers
{
    [EnableCors("AllowFromAll")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly MeetingManagementContext _context;

        public LoginController(MeetingManagementContext context)
        {
            _context = context;
        }
               
        [HttpPost("Authenticate")]
        public IActionResult AuthenticateUser([FromBody] LoginEntity loginObject)
        {           
            var loginEntity = _context.LoginEntity.Where(x => x.LoginId == loginObject.LoginId && x.Password == loginObject.Password);
          
            if (loginEntity == null)
            {
                return NotFound();
            }
            return Ok(new { status = 200, result= loginObject });
        }
        
        private bool LoginEntityExists(int id)
        {
            return _context.LoginEntity.Any(e => e.LoginId == id);
        }
    }
}