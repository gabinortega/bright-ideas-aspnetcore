using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BrightIdeas.Data.EF.LocalDB
{
    public class LocalDbContext : IdeasDbContext
    {
        public LocalDbContext(IConfiguration configuration) : base(configuration)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("MsSqlConnection"));
        }
    }
}
