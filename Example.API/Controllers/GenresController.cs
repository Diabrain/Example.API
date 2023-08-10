using Example.API.Managers;
using Example.API.Models.CreateModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GenresController : ControllerBase
{
    private readonly IGenreManager _manager;
    public GenresController(IGenreManager manager)
    {
        _manager = manager;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            return Ok(await _manager.GetAll());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateGenreModel model)
    {
        try
        {
            return Ok(await _manager.Create(model));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpGet("{genreId}")]
    public async Task<IActionResult> GetById(int genreId)
    {
        try
        {
            return Ok(await _manager.Get(genreId));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
