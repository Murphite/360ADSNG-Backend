using _360AdsNG.API.Extensions;
using _360AdsNG.API.Middlewares;
using _360AdsNG.Infrastructure.Persistence;
using _360AdsNG.Infrastructure.Seed;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbServices(builder.Configuration);

// Register logger service
var logger = builder.Services.BuildServiceProvider().GetRequiredService<ILogger<LoggingCategory>>();
builder.Services.AddServices(builder.Configuration, logger);

var app = builder.Build();

// Configure the HTTP request pipeline.
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
    logger.LogError(ex, "An error occurred during seeding.");
}

app.Run();


//void SeedDatabase()
//{
//    using (var scope = app.Services.CreateScope())
//    {
//        var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
//        dbInitializer.Initialize();
//    }
//}