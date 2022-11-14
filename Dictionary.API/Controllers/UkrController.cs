using Dictionary.Bal.Interfaces;
using Dictionary.Bal.ModelsDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dictionary.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UkrController : ControllerBase
    {
        private readonly IUkrWordService _service;
        public UkrController(IUkrWordService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<EnglishWordDto>> Get([FromQuery] UkranianWordDto ukrWord)
        {
            if (string.IsNullOrWhiteSpace(ukrWord.Word))
            {
                return NoContent();
            }
            var words = _service.GetEnglishWords(ukrWord);
            if(words == null)
            {
                return NotFound();
            }

            return Ok(words);
        }
    }
}
