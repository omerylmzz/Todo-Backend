using Marten;
using Microsoft.AspNetCore.Mvc;
using todoapp_backend.Models;

namespace todoapp_backend.Controllers;

// localhost:XXXX/api/task
[ApiController] // Provides an identity to the controller
[Route("api/task")] // The controller needs a router (Route("api/[controller]"))
public class TasksController : ControllerBase
{
    private readonly IDocumentSession _session;
    // Constructor
    public TasksController(IDocumentSession session)
    {
        _session = session;
    }
    // GET Request
    [HttpGet]
    public async Task<IActionResult> GetAllTasks()
    {
        var tasks = await _session.Query<Models.Task>().ToListAsync();
        // Condition that checks whether there is data
        if (tasks == null) return NotFound();

        return Ok(tasks);
    }
    // GET Request (According to the spesific ID)
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var task = await _session.LoadAsync<Models.Task>(id);
        // Condition that checks whether there is data
        if (task == null) return NotFound();

        return Ok(task);
    }
    // POST Request
    [HttpPost]
    public async Task<IActionResult> CreateTask(Models.Task task)
    {
        // The object is kept in memory and the operation is marked as “insert”
        _session.Store(task);
        // Inserts object into SQL table
        await _session.SaveChangesAsync();
        return Ok(task);
    }
    // DELETE Request
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteTask(Guid id)
    {
        _session.Delete<Models.Task>(id);
        // Deletes object from SQL table
        await _session.SaveChangesAsync();
        return NoContent();
    }
}