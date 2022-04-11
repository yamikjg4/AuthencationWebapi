using AuthencationWebapi.Model;
using AuthencationWebapi.Repositry;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AuthencationWebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepositry _user;
        public UserController(IUserRepositry user) { _user = user; }
        [HttpPost]
        public async Task<ActionResult> Resgister([FromForm]tbluser user)
        {
       
               var res= await _user.register(user); 
            if (res.Succeeded) { return Ok("User Register Succesfully"); }
               
       
             return Unauthorized();
           
           
        }
        [Route("/Login")]
        [HttpPost]
        public async Task<ActionResult> login([FromForm] loginmodel login)
        {
            var res = await _user.LoginAsync(login);
            if (string.IsNullOrEmpty(res))
            {
                return Unauthorized();
            }
            return Ok(res);
        }
        [Authorize]
        [HttpGet]
        public async Task<ActionResult> userlist()
        {
          return Ok(await _user.userlists());
        }
        
    }
}
