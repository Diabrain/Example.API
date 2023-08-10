using Example.API.Managers;
using Example.API.Models.CreateModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PublishersController : ControllerBase
{
    private readonly IPublisherManager _manager;
    public PublishersController(IPublisherManager manager)
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
    public async Task<IActionResult> Create([FromBody] CreatePublisherModel model)
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
    [HttpGet("{publisherId}")]
    public async Task<IActionResult> GetById(int publisherId)
    {
        try
        {
            return Ok(await _manager.Get(publisherId));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
