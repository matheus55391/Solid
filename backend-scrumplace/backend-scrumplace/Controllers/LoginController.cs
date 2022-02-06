using backend_scrumplace.src.Login.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_scrumplace.src.Login
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public ActionResult<String> Post(LoginDTO credentials)
        {
            return StatusCode(200,"TESTESTETESTE");
        }
        
    }
}
