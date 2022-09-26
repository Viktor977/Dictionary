using Dictionary.Bal.Interfaces;
using Dictionary.Bal.ModelsDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Dictionary.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UkranianController : ControllerBase
    {
        private readonly IUkranianWordService _service;
        public UkranianController(IUkranianWordService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<UkranianWordDto>> GetAll()
        {
            try
            {
                var words = await _service.GetAllAsync();
                return Ok(words);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
