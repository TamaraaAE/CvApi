using CvApi.DTOs;

namespace CvApi.Services
{
    public interface ISkillService
    {
        Task<List<SkillDTO>> GetSkillsAsync();
    }
}
