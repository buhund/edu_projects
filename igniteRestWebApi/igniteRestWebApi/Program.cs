using igniteRestWebApi.Data;

namespace igniteRestWebApi;

/**
 * Add dotnet tools to PATH:
 * export PATH="$PATH:$HOME/.dotnet/tools/"
 *
 * To create a new migration, run:
 * dotnet ef migrations add InitialMigrationName -c AppDbContext
 *
 * Manual migration of table:
 * dotnet ef database update
 *
 * View Scalar at
 * localhost:XYZA/scalar
 */
public class Program
{
    public static void Main(string[] args)
    {
        // Set up the builder
        var builder = WebApplication.CreateBuilder(args);

        // Set up logging and add minimum logging level
        builder.Services.AddLogging();
        builder.Logging.SetMinimumLevel(LogLevel.Trace);

        // Add database context


        // Add services to the service container.

        builder.Services.AddControllers();
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}