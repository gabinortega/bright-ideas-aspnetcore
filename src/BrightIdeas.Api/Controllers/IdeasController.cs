using BrightIdeas.Data;
using Microsoft.AspNetCore.Mvc;

namespace BrightIdeas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IdeasController : ControllerBase
    {
        private readonly IDbRepository _repository;

        public IdeasController(IDbRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok($"Hola !!! {_repository.GetIdeaByIdAsync(1).Result?.Title}");
        }
    }
}
