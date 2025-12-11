using FirstApiRest.Data;
using FirstApiRest.Models;
using Microsoft.AspNetCore.Mvc;


namespace FirstApiRest.Controllers;

[ApiController]
[Route("api/[controller]")]

public class UsuarioController : ControllerBase
{
    private readonly AppDbContext _appDbContext;

    public UsuarioController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    [HttpPost]
    public async Task<IActionResult> AddUsuario(User user)
    {
        _appDbContext.Users.Add(user);
        await _appDbContext.SaveChangesAsync();
        return CreatedAtAction(nameof(AddUsuario), new { id = user.Id }, user);
    }
}

