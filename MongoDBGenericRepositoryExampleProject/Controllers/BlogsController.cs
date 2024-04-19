using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDBGenericRepositoryExampleProject.Entities;
using MongoDBGenericRepositoryExampleProject.Repository.Abstract;

namespace MongoDBGenericRepositoryExampleProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogsController : ControllerBase
{
    private readonly IBlogRepository _blogRepository;

    public BlogsController(IBlogRepository blogRepository)
    {
        _blogRepository = blogRepository;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var result = _blogRepository.GetList();
        if (result == null)
        {
            return BadRequest("Not found");
        }

        return Ok(result.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(ObjectId id)
    {
        var result = _blogRepository.GetByIdAsync(id);
        if (result == null)
        {
            return BadRequest("Not found");
        }

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Blog data)
    {
        await _blogRepository.AddAsync(data);
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Update(ObjectId id, [FromBody] Blog data)
    {
        var result = _blogRepository.UpdateAsync(id, data);
        if (result == null)
        {
            return BadRequest("Not found");
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(ObjectId id)
    {
        var result = _blogRepository.DeleteAsync(id);
        if (result == null)
        {
            return BadRequest("Not found");
        }

        return NoContent();
    }
}
