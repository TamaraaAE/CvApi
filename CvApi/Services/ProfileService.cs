using CvApi.Data;
using CvApi.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CvApi.Services;

public class ProfileService : IProfileService
{
    private readonly CvDbContext _context;

    public ProfileService(CvDbContext context)
    {
        _context = context;
    }

    public async Task<ProfileDto?> GetProfileAsync()
    {
        var profile = await _context.Profiles.FirstOrDefaultAsync();

        if (profile == null) return null;

        return new ProfileDto
        {
            Name = profile.Name,
            Title = profile.Title,
            Email = profile.Email,
            LinkedIn = profile.LinkedIn,
            GitHub = profile.GitHub,
            Summary = profile.Summary
        };
    }
}
