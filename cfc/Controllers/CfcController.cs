using Microsoft.AspNetCore.Mvc;

namespace cfc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CfcController : Controller
    {
        [HttpGet("get")]
        public IActionResult Index()
        {
            return Ok("Welcome to CFC API");
        }
    }
}
