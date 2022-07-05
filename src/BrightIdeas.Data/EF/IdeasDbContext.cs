using BrightIdeas.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BrightIdeas.Data.EF
{
    public abstract class IdeasDbContext : DbContext
    {
        private protected readonly IConfiguration Configuration;

        protected IdeasDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public DbSet<Idea> Ideas { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
