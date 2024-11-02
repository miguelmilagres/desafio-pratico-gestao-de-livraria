using Microsoft.AspNetCore.Mvc;

using BookstoreManagement.Entities;
using BookstoreManagement.Communication.Responses;
using BookstoreManagement.Communication.Requests;

namespace BookstoreManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            List<Book>? response = null;

            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredBookJson), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] RequestRegisterBookJson request)
        {
            ResponseRegisteredBookJson? response = null;

            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateBookInfoJson request)
        {
            return NoContent();
        }
        
        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete([FromRoute] int id, [FromBody] RequestUpdateBookInfoJson request)
        {
            return NoContent();
        }
    }
}
    
