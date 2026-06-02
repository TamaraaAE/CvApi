using CvApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CvApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProfileController : ControllerBase
{
    private readonly CvDbContext _context;

    public ProfileController(CvDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        var profile = await _context.Profiles.FirstOrDefaultAsync();

        return Ok(profile);
    }
}



