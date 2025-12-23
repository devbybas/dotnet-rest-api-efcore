using DotnetRestApiEfCore.Data;
using DotnetRestApiEfCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotnetRestApiEfCore.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactsController : ControllerBase
{
    private readonly AppDbContext _db;

    public ContactsController(AppDbContext db) => _db = db;

    [HttpGet]
    public async Task<ActionResult<List<Contact>>> GetAll()
        => await _db.Contacts.OrderByDescending(x => x.CreatedAt).ToListAsync();

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Contact>> GetById(int id)
    {
        var item = await _db.Contacts.FindAsync(id);
        return item is null ? NotFound() : Ok(item);
    }

    [HttpPost]
    public async Task<ActionResult<Contact>> Create(Contact input)
    {
        _db.Contacts.Add(input);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = input.Id }, input);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var item = await _db.Contacts.FindAsync(id);
        if (item is null) return NotFound();

        _db.Contacts.Remove(item);
        await _db.SaveChangesAsync();
        return NoContent();
    }
}
