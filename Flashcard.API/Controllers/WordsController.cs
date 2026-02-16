using Flashcard.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Flashcard.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController] // Attributes
    public class WordsController: ControllerBase
    {
        private readonly IWordService _wordService;
        public WordsController(IWordService wordService)
        {
         _wordService = wordService;

          }

        [HttpGet("Getall")]
        public IActionResult GetAll()
        {
            var result = _wordService.GetAll(); 
            
            return Ok(result);
        }

    }
}
