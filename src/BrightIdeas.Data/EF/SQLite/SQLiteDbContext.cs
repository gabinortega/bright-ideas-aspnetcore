using Microsoft.Extensions.Configuration;

namespace BrightIdeas.Data.EF.SQLite
{
    public class SQLiteDbContext : IdeasDbContext
    {
        public SQLiteDbContext(IConfiguration configuration) : base(configuration)
        {
        }
    }

}
