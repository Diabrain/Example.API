using Example.API.Managers;
using Example.API.Models.CreateModels;
using Example.API.Models.UpdateModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorsController : ControllerBase
{
    private readonly IAuthorManager _authorManager;
    public AuthorsController(IAuthorManager authorManager)
    {
        _authorManager = authorManager;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            return Ok(await _authorManager.GetAllAsync());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPost]
    
    public async Task<IActionResult> Create([FromBody] CreateAuthorModel model)
    {
        try
        {
            return Ok(await _authorManager.CreateAsync(model));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpGet("{authorId}")]
    public async Task<IActionResult> Get(int authorId)
    {
        try
        {
            return Ok(await _authorManager.GetByIdAsync(authorId));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{authorId}")]
    public async Task<IActionResult> Update(int authorId, [FromBody] UpdateAuthorModel model)
    {
        try
        {
            return Ok(await _authorManager.UpdateAsync(authorId,model));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpDelete("{authorId}")]
    public async Task<IActionResult> Delete(int authorId)
    {
        try
        {
            await _authorManager.DeleteAsync(authorId);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
