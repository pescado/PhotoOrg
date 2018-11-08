using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace PhotoOrg.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<PhotoFile> PhotoFiles { get; set; }
    }
}