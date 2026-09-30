using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace EcommApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LoginController : ControllerBase
    {

        [HttpGet]
        public IActionResult login()
        {
            var products = new string[] { "laptop", "mouse" };
            return Ok(products);
        }

    }
}
