using Flashcard.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Flashcard.Entities.Concrete;

namespace Flashcard.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController] // Attributes
    public class WordsController : ControllerBase
    {
        private readonly IWordService _wordService;
        public WordsController(IWordService wordService)
        {
            _wordService = wordService;

        }

        [HttpPost("Add")]
        public void Add(Word word)
        {

            if (_wordService != null)
                _wordService.Add(word);
        }


        [HttpGet("Getall")]
        public IActionResult GetAll()
        {
            var result = _wordService.GetAll();

            return Ok(result);
        }

        [HttpGet("get/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _wordService.GetById(id);
            if (result != null)

                return Ok(result);

            return NotFound("Kelime bulunamadı.");

        }

        [HttpDelete("delete/{id}")]

        public IActionResult Delete(int id)

        {
           var result = _wordService.Delete(id);

            if (result != null) {

                return Ok(result);

             }

            return NotFound("kelime silinemedi");

        }

        [HttpPut("Update/{id}")]
        public IActionResult Update (int id, Word word)
        {
            var result = _wordService.Update(word);

            if (result != null) {
                return Ok(result);

        }
            return BadRequest(result);    

        }
    }
}
