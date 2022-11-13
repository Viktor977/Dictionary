using Dictionary.Bal.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dictionary.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EngController : ControllerBase
    {
        private readonly IWordService _service;
        public EngController(IWordService service)
        {
            _service = service;
        }
    }
}
