using CvApi.Data;
using CvApi.DTOs;
using Microsoft.EntityFrameworkCore;


namespace CvApi.Services
{
    public class SkillService : ISkillService
    {
        private readonly CvDbContext _context;

        public SkillService(CvDbContext context)
        {
            _context = context;
        }

        public async Task<List<SkillDTO>> GetSkillsAsync()
        {
            var skills = await _context.Skills.ToListAsync();

            return skills.Select(skill => new SkillDTO
            {
                Name = skill.Name,
                Level = skill.Level

            }).ToList();
        }
    }
}
