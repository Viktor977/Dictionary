using Dictionary.Bal.Interfaces;
using Dictionary.Bal.ModelsDto;
using Dictionary.Bal.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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
        public ActionResult<IEnumerable<UkranianWordDto>> Get([FromQuery] EnglishWordDto wordDto)
        {
            if (string.IsNullOrWhiteSpace(wordDto.Word))
            {
                return NoContent();
            }
            var result = _service.GetUkrWords(wordDto);

            if (result is null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromQuery] WordDto wordDto)
        {
            try
            {

                if (wordDto == null)
                {
                    return BadRequest("EnglishWordDto is null");
                }
                if (string.IsNullOrWhiteSpace(wordDto.EnglishWordDto.Word))
                {
                    return BadRequest("Word is null or whitespace");
                }

                await _service.Add(wordDto);

                return Ok();

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server ERROR");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] WordDto wordDto)
        {

            if (wordDto is null)
            {
                return NotFound();
            }
            await _service.Delete(wordDto);

            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromQuery]WordDto wordDto)
        {
            //TODO
            if(wordDto is null)
            {
                return NotFound();
            }
            await _service.Update(wordDto);
            return Ok();
        }
    }
}
