using CvApi.DTOs;

namespace CvApi.Services;

public interface IProfileService
{
    Task<ProfileDto?> GetProfileAsync();
}