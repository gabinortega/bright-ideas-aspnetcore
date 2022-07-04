using Microsoft.AspNetCore.Mvc;

namespace BrightIdeas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IdeasController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Hola !!!");
        }
    }
}
