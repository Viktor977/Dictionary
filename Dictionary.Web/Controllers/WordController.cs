using Dictionary.Bal.Interfaces;
using Dictionary.Bal.ModelsDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dictionary.Web.Controllers
{
    [Route("words")]
    [ApiController]
    public class WordController : ControllerBase
    {
        private readonly IWordService service;
        public WordController(IWordService provider)
        {
            service = provider;
        }

        [HttpGet("ukr")]
        public async Task<ActionResult<IEnumerable<UkranianWordDto>>> GetAll([FromQuery]string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return BadRequest();
            }
            var fwords = await service.GetUkrWords(word);                     
            return Ok(fwords);
        }

        [HttpGet("eng")]
        public async Task<ActionResult<IEnumerable<EnglishWordDto>>> GetAllEnglish([FromQuery] string word)
        {
            var words= await service.GetEngWords(word);
            return Ok(words);
        }

        [HttpPost]
        public async Task<ActionResult>AddEng([FromBody]WordCreater words)
        {
            var word = GetWordDto(words);
            await service.AddWordAsync(word);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete([FromBody] WordCreater words)
        {
            var word = GetWordDto(words);
            await service.DeleteAsync(word);
            return Ok();
        }

        [HttpPatch]
        public async Task<ActionResult> Update([FromBody] WordCreater words)
        {
            var word = GetWordDto(words);
            await service.UpdateAsync(word);
            return Ok();
        }
        private WordDto GetWordDto(WordCreater words)
        {
            var word = new WordDto();
            word.EnglishWordDto = words.EnglishWord;
            word.UkranianWordDto = words.UkranianWord;
            return word;
        }
       
    }
}
