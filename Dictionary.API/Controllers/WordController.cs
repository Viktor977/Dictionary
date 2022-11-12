using Dictionary.Bal.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Dictionary.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        private readonly IWordService _service;
        public WordController(IWordService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return BadRequest(404);
        }
    }
}
