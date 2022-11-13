using Dictionary.Bal.Interfaces;
using Dictionary.Bal.ModelsDto;
using Dictionary.Bal.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dictionary.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EngController : ControllerBase
    {
        private readonly IEngWordService _service;
        public EngController(IEngWordService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UkranianWordDto>>Get([FromQuery] EnglishWordDto wordDto )
        {
            var result = _service.GetUkrWords(wordDto);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
