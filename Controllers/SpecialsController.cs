using BlazingPizza.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Controllers;

[Route("specials")]
[ApiController]
public class SpecialsController
{
    private readonly PizzaStoreContext _context;

    public SpecialsController(PizzaStoreContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecialsAsync()
    {
        return await _context.Specials.ToListAsync();
    }
}
