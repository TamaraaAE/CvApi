using CvApi.Data;
using CvApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CvApi.DTOs;


namespace CvApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProfileController : ControllerBase
{
    private readonly IProfileService _service;

    public ProfileController(IProfileService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        var profile = await _service.GetProfileAsync();

        return Ok(profile);
    }
}



