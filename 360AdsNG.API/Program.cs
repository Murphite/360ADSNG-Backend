using _360AdsNG.API.Extensions;
using _360AdsNG.API.Middlewares;
using _360AdsNG.Infrastructure.Persistence;
using _360AdsNG.Infrastructure.Seed;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbServices(builder.Configuration);

builder.Services.AddServices(builder.Configuration, builder.Services.BuildServiceProvider().GetRequiredService<ILogger<LoggingCategory>>());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseCors("AllowAllOrigins");
}

app.UseMiddleware<ExceptionMiddleware>();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

try
{
    using (var serviceScope = app.Services.CreateScope())
    {
        var serviceProvider = serviceScope.ServiceProvider;
        var context = serviceProvider.GetRequiredService<AppDbContext>();
        context.Database.Migrate();
        await Seeder.Run(serviceProvider);
    }
}
catch (Exception ex)
{
    var logger = app.Services.GetRequiredService<ILogger<LoggingCategory>>();
    logger.LogError(ex, "An error occurred during seeding.");
}

app.Run();


