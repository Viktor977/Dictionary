using Dictionary.Bal.Interfaces;
using Dictionary.Bal.ModelsDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dictionary.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        private readonly IWordService provider;
        public WordController(IWordService provider)
        {
            this.provider = provider;
        }

        [HttpGet("ukrwords")]
        public async Task<ActionResult<IEnumerable<UkranianWordDto>>> GetAll([FromQuery]string word)
        {
            var fwords = await provider.GetUkrWords(word);                     
            return Ok(fwords);
        }

        [HttpGet("engwords")]
        public async Task<ActionResult<IEnumerable<EnglishWordDto>>> GetAllEnglish([FromQuery] string word)
        {
            var words= await provider.GetEngWords(word);
            return Ok(words);
        }

        [HttpPost]
        public async Task<ActionResult>Add([FromBody]WordDto word)
        {
            await provider.AddEngWord(word);
            return Ok();
        }
    }
}
