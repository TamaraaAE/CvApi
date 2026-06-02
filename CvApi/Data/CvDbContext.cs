using Microsoft.EntityFrameworkCore;
using CvApi.Models;

namespace CvApi.Data
{
    public class CvDbContext : DbContext
    {
        public CvDbContext(DbContextOptions<CvDbContext> options)
            : base(options)
        {

        }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Skill> Skills { get; set; }

    }
}
