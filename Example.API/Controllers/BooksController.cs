using Example.API.Managers;
using Example.API.Models.CreateModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookManager _bookManager;
        public BooksController(IBookManager bookManager)
        {
            _bookManager = bookManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _bookManager.Getall());
            }
            catch (Exception ex)
            {
                return  BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBookModel model)
        {
            try
            {
                return Ok(await _bookManager.Create(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{bookId}")]
        public async Task<IActionResult> GetById(int bookId)
        {
            try
            {
                return Ok(await _bookManager.Get(bookId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
