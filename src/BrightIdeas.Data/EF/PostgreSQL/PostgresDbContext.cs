using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BrightIdeas.Data.EF.PostgreSQL
{
    public class PostgresDbContext : IdeasDbContext
    {
        public PostgresDbContext(IConfiguration configuration) : base(configuration)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("PostgreSqlConnection"));
        }
    }
}
