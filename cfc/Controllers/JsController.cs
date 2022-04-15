using Microsoft.AspNetCore.Mvc;

namespace cfc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JsController : Controller
    {
        [HttpGet("get")]
        public IActionResult Index()
        {
            return Ok("Welcome to Job Scanner API");
        }
    }
}
