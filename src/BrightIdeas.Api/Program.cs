using BrightIdeas.Data;
using BrightIdeas.Data.EF;
using BrightIdeas.Data.EF.LocalDB;
using BrightIdeas.Data.EF.PostgreSQL;
using BrightIdeas.Data.EF.SQLite;
using BrightIdeas.Data.InMemoryDb;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerDocument(configure => configure.Title = "Brilliant Ideas");

switch (builder.Configuration["DatabaseProvider"]) // SQLite, LocalDb, PostgreSQL, InMemory (default)
{
    case "PostgreSQL":
        builder.Services.AddScoped<IDbRepository, InMemoryDbService>();
        builder.Services.AddDbContext<IdeasDbContext, PostgresDbContext>();
        break;
    case "SQLite":
        builder.Services.AddDbContext<IdeasDbContext, SQLiteDbContext>();
        builder.Services.AddScoped<IDbRepository, InMemoryDbService>();
        break;
    case "LocalDb":
        //builder.Services.AddDbContextPool<IdeasDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("IdeasDb")));
        builder.Services.AddDbContext<IdeasDbContext, LocalDbContext>();
        builder.Services.AddScoped<IDbRepository, InMemoryDbService>();
        break;
    case "InMemory":
    default:
        builder.Services.AddSingleton<IDbRepository, InMemoryDbService>();
        break;
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi(); // serve documents (same as app.UseSwagger())
    app.UseSwaggerUi3(); // serve Swagger UI
    //app.UseReDoc(); // serve ReDoc UI
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
