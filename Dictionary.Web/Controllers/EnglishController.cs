using Dictionary.Bal.Interfaces;
using Dictionary.Bal.ModelsDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dictionary.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnglishController : ControllerBase
    {
        private readonly IEnglishWordService _service;
        public EnglishController(IEnglishWordService englishWordService)
        {
            _service = englishWordService;
        }

        [HttpGet]
        public async  Task<ActionResult<IEnumerable<EnglishWordDto>>> GetWords()
        {
            try
            {
               var words =await _service.GetAllAsync();
               return Ok(words);
            }
            catch (Exception )
            {
                return BadRequest();
            }         
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EnglishWordDto>>GetById(int id)
        {
            try
            {
                var word= await _service.GetByIdAsync(id);   
                return Ok(word);
            }
            catch (Exception )
            {
                return NotFound();
            }

        }

        [HttpPost]
        public async Task<ActionResult> CreateWord([FromBody] EnglishWordDto word)
        {
            try
            {
                if (word is null)
                {
                    return BadRequest("English word is null");
                }

                _service.Add(word);
                return Ok();
            }
            catch (Exception )
            {

                return StatusCode(500, "Internal server error");
            }

        }

        [HttpDelete]
        public async Task<ActionResult> Delete([FromBody] EnglishWordDto word)
        {
            try
            {
                if(word is null)
                {
                    return BadRequest();
                }
                else
                {
                    _service.Delete(word);
                }

            }
            catch (Exception)
            {

                return StatusCode(500, "Internal server error");
            }

            return NoContent();
        }
    }
}
