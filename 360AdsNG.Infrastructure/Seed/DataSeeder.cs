using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using _360AdsNG.Domain.Entities;
using _360AdsNG.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Bogus;
using _360AdsNG.Domain.Enums;

namespace _360AdsNG.Infrastructure.Seed
{
    public class DataSeeder
    {
        private readonly UserManager<User> _userManager;
        private readonly AppDbContext _context;
        private readonly ILogger<DataSeeder> _logger;
        private readonly string _baseUrl;

        private readonly List<User> _users = new();
        private readonly List<Address> _addresses = new();
        private readonly List<Vendor> _vendors = new();
        private readonly List<Billboard> _billboards = new();

        public DataSeeder(UserManager<User> userManager, AppDbContext context, ILogger<DataSeeder> logger, IConfiguration config)
        {
            Randomizer.Seed = new Random(54093);
            _userManager = userManager;
            _context = context;
            _logger = logger;
            _baseUrl = config.GetSection("ApiUrl").Value!;
        }

        public async Task Run()
        {
            _logger.LogInformation("Starting data seeding...");
            await SeedUsers(10);
            await SeedAddresses(10);
            await SeedVendors(5);
            await SeedBillboards(20);

            await _context.SaveChangesAsync();
            _logger.LogInformation("Data seeding completed successfully.");
        }

        private async Task SeedUsers(int count)
        {
            _logger.LogInformation("Seeding {Count} users...", count);
            var faker = new Faker<User>()
                .RuleFor(u => u.FirstName, f => f.Person.FirstName)
                .RuleFor(u => u.LastName, f => f.Person.LastName)
                .RuleFor(u => u.Email, f => f.Internet.Email())
                .RuleFor(u => u.UserName, (f, u) => u.Email)
                .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(u => u.ImageUrl, f => f.Image.PicsumUrl())
                .RuleFor(u => u.CreatedAt, f => f.Date.PastOffset())
                .RuleFor(u => u.UpdatedAt, f => f.Date.RecentOffset());

            var users = faker.Generate(count);

            foreach (var user in users)
            {
                var result = await _userManager.CreateAsync(user, "Password@123");
                if (result.Succeeded)
                {
                    _users.Add(user);
                    _logger.LogInformation("User {Email} created successfully.", user.Email);
                }
                else
                {
                    _logger.LogError("Failed to create user {Email}. Errors: {Errors}", user.Email, string.Join(", ", result.Errors.Select(e => e.Description)));
                }
            }
        }

        private async Task SeedAddresses(int count)
        {
            _logger.LogInformation("Seeding {Count} addresses...", count);
            var addresses = new List<Address>();

            var addressFaker = new Faker<Address>()
                .RuleFor(a => a.Street, f => f.Address.StreetAddress())
                .RuleFor(a => a.City, f => f.Address.City())
                .RuleFor(a => a.State, f => f.Address.State())
                .RuleFor(a => a.Country, f => f.Address.Country())
                .RuleFor(a => a.Longitude, f => (double?)f.Address.Longitude())
                .RuleFor(a => a.Latitude, f => (double?)f.Address.Latitude())
                .RuleFor(a => a.CreatedAt, f => f.Date.PastOffset())
                .RuleFor(a => a.UpdatedAt, f => f.Date.RecentOffset());

            for (var i = 0; i < count; i++)
            {
                var address = addressFaker.Generate();
                await _context.Addresses.AddAsync(address);
                addresses.Add(address);
                _logger.LogInformation("Address {Street} added.", address.Street);
            }

            await _context.SaveChangesAsync();
        }

        private async Task SeedVendors(int count)
        {
            _logger.LogInformation("Seeding {Count} vendors...", count);

            var vendorFaker = new Faker<Vendor>()
                .RuleFor(v => v.UserId, f => f.PickRandom(_users).Id)
                .RuleFor(v => v.AddressId, f => f.PickRandom(_addresses).Id)
                .RuleFor(v => v.CompanyName, f => f.Company.CompanyName())
                .RuleFor(v => v.CreatedAt, f => f.Date.PastOffset())
                .RuleFor(v => v.UpdatedAt, f => f.Date.RecentOffset());

            var vendors = vendorFaker.Generate(count);

            _vendors.AddRange(vendors);
            await _context.Vendors.AddRangeAsync(vendors);
        }

        private async Task SeedBillboards(int count)
        {
            _logger.LogInformation("Seeding {Count} billboards...", count);

            var billboardFaker = new Faker<Billboard>()
                .RuleFor(b => b.UserId, f => f.PickRandom(_users).Id)
                .RuleFor(b => b.AddressId, f => f.PickRandom(_addresses).Id)
                .RuleFor(b => b.Name, f => f.Commerce.ProductName())
                .RuleFor(b => b.Price, f => f.Random.Number(100, 1000))
                .RuleFor(b => b.BoardType, f => f.PickRandom("Static", "Digital"))
                .RuleFor(b => b.DailyImpressions, f => f.Random.Number(1000, 10000))
                .RuleFor(b => b.DurationPerDisplay, f => f.Random.Number(5, 60))
                .RuleFor(b => b.Time, f => f.Random.Word())
                .RuleFor(b => b.Dimension, f => f.Random.Word())
                .RuleFor(b => b.PixelSize, f => f.Random.Word())
                .RuleFor(b => b.Orientation, f => f.PickRandom<OrientationType>())
                .RuleFor(b => b.Negotiable, f => f.PickRandom<NegotiableType>())
                .RuleFor(b => b.TrafficDescription, f => f.Lorem.Sentence())
                .RuleFor(b => b.ImageUrl, f => f.Image.PicsumUrl())
                .RuleFor(b => b.Note, f => f.Lorem.Paragraph())
                .RuleFor(b => b.CreatedAt, f => f.Date.PastOffset())
                .RuleFor(b => b.UpdatedAt, f => f.Date.RecentOffset());

            var billboards = billboardFaker.Generate(count);

            _billboards.AddRange(billboards);
            await _context.Billboards.AddRangeAsync(billboards);
        }
    }
}
