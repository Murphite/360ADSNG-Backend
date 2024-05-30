using _360AdsNG.Domain.Entities;
using _360AdsNG.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _360AdsNG.Infrastructure.Persistence
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Billboard> Billboards { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Addresses
            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    Id = "0",
                    Street = "123 Admin St",
                    City = "Admin City",
                    State = "Admin State",
                    Country = "Admin Country",
                    Longitude = 100.111,
                    Latitude = 78.910,
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new Address
                {
                    Id = "1",
                    Street = "123 Main St",
                    City = "Cityville",
                    State = "Stateville",
                    Country = "Countryland",
                    Longitude = 123.456,
                    Latitude = 78.910,
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new Address
                {
                    Id = "2",
                    Street = "456 Elm St",
                    City = "Townsville",
                    State = "Countyville",
                    Country = "Anotherland",
                    Longitude = 45.678,
                    Latitude = 12.345,
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new Address
                {
                    Id = "3",
                    Street = "789 Oak St",
                    City = "Villagetown",
                    State = "Provinceville",
                    Country = "Otherland",
                    Longitude = 90.123,
                    Latitude = 67.890,
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new Address
                {
                    Id = "4",
                    Street = "1011 Pine St",
                    City = "Hamletville",
                    State = "Territorytown",
                    Country = "Someland",
                    Longitude = 34.567,
                    Latitude = 89.012,
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new Address
                {
                    Id = "5",
                    Street = "1213 Cedar St",
                    City = "Countryside",
                    State = "Districtville",
                    Country = "Landofthefree",
                    Longitude = 56.789,
                    Latitude = 23.456,
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new Address
                {
                    Id = "6",
                    Street = "1415 Birch St",
                    City = "Settlementtown",
                    State = "Municipality",
                    Country = "Everywhere",
                    Longitude = 78.901,
                    Latitude = 34.567,
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new Address
                {
                    Id = "7",
                    Street = "1617 Maple St",
                    City = "Hollowville",
                    State = "Territorytown",
                    Country = "Otherland",
                    Longitude = 12.345,
                    Latitude = 90.123,
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                }
            );

            modelBuilder.Entity<Billboard>().HasData(
                new Billboard
                {
                    Id = "1",
                    UserId = "user_id_1",
                    AddressId = "1",
                    Name = "Billboard 1",
                    Price = 100,
                    BoardType = "Static",
                    DailyImpressions = 1000,
                    DurationPerDisplay = 10,
                    Time = "Day",
                    Dimension = "10x20",
                    PixelSize = "1080p",
                    Orientation = OrientationType.LandScape,
                    Negotiable = NegotiableType.Yes,
                    TrafficDescription = "High traffic area",
                    ImageUrl = "https://images.examples.com/wp-content/uploads/2018/04/Urban-Billboard-Design-Example.jpg",
                    Note = "Additional notes",
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new Billboard
                {
                    Id = "2",
                    UserId = "user_id_2",
                    AddressId = "2",
                    Name = "Billboard 2",
                    Price = 150,
                    BoardType = "Static",
                    DailyImpressions = 800,
                    DurationPerDisplay = 15,
                    Time = "Night",
                    Dimension = "20x40",
                    PixelSize = "4k",
                    Orientation = OrientationType.Portrait,
                    Negotiable = NegotiableType.No,
                    TrafficDescription = "Moderate traffic area",
                    ImageUrl = "https://images.examples.com/wp-content/uploads/2018/04/Street-Billboard-Design-Example.jpg",
                    Note = "Some notes",
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new Billboard
                {
                    Id = "3",
                    UserId = "user_id_3",
                    AddressId = "3",
                    Name = "Billboard 3",
                    Price = 250,
                    BoardType = "Static",
                    DailyImpressions = 1000,
                    DurationPerDisplay = 15,
                    Time = "Night",
                    Dimension = "20x40",
                    PixelSize = "4k",
                    Orientation = OrientationType.LandScape,
                    Negotiable = NegotiableType.No,
                    TrafficDescription = "Moderate traffic area",
                    ImageUrl = "https://images.examples.com/wp-content/uploads/2018/04/School-Billboard-Design-Example.jpg",
                    Note = "Some notes",
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new Billboard
                {
                    Id = "4",
                    UserId = "user_id_4",
                    AddressId = "4",
                    Name = "Billboard 4",
                    Price = 250,
                    BoardType = "Dynamic",
                    DailyImpressions = 1000,
                    DurationPerDisplay = 15,
                    Time = "Night",
                    Dimension = "20x40",
                    PixelSize = "4k",
                    Orientation = OrientationType.LandScape,
                    Negotiable = NegotiableType.No,
                    TrafficDescription = "Metal Billboard traffic area",
                    ImageUrl = "https://images.examples.com/wp-content/uploads/2018/04/Metal-Billboard-Design-Example.jpg",
                    Note = "Some notes",
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                }
            );

            // Seed Users
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = "admin_id",
                    FirstName = "Admin",
                    LastName = "Admin",
                    Email = "admin@admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.COM",
                    UserName = "admin@admin.com",
                    NormalizedUserName = "ADMIN@ADMIN.COM",
                    PhoneNumber = "08130990162",
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "Admin@123"),
                    PublicId = "public_id_0",
                    AddressId = "0",
                    Password = "Admin@123",
                    ConfirmPassword = "Admin@123",
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new User
                {
                    Id = "user_id_1",
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@gmail.com",
                    NormalizedEmail = "JOHN.DOE@GMAIL.COM",
                    UserName = "john.doe@gmail.com",
                    NormalizedUserName = "JOHN.DOE@GMAIL.COM",
                    ImageUrl = "https://images.unsplash.com/photo-1633332755192-727a05c4013d?q=80&w=1780&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    Occupation = "Developer",
                    BusinessName = "ABC Company",
                    ContactName = "Jane Doe",
                    PublicId = "public_id_1",
                    AddressId = "1",
                    Password = "Password@123",
                    ConfirmPassword = "Password@123",
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "Password@123"),
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new User
                {
                    Id = "user_id_2",
                    FirstName = "Alice",
                    LastName = "Smith",
                    Email = "alice.smith@gmail.com",
                    NormalizedEmail = "ALICE.SMITH@GMAIL.COM",
                    UserName = "alice.smith@gmail.com",
                    NormalizedUserName = "ALICE.SMITH@GMAIL.COM",
                    ImageUrl = "https://unsplash.com/photos/closeup-photography-of-woman-smiling-mEZ3PoFGs_k",
                    Occupation = "Designer",
                    BusinessName = "XYZ Company",
                    ContactName = "John Smith",
                    PublicId = "public_id_2",
                    AddressId = "2",
                    Password = "Password@123",
                    ConfirmPassword = "Password@123",
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "Password@123"),
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new User
                {
                    Id = "user_id_3",
                    FirstName = "Emily",
                    LastName = "Johnson",
                    Email = "emily.johnson@gmail.com",
                    NormalizedEmail = "EMILY.JOHNSON@GMAIL.COM",
                    UserName = "emily.johnson@gmail.com",  
                    NormalizedUserName = "EMILY.JOHNSON@GMAIL.COM",
                    ImageUrl = "https://www.istockphoto.com/photo/headshot-portrait-of-smiling-male-employee-in-office-gm1309328823-399075075",
                    Occupation = "Writer",
                    BusinessName = "EFG Enterprises",
                    ContactName = "Michael Johnson",
                    PublicId = "public_id_3",
                    AddressId = "3",
                    Password = "Password@123",
                    ConfirmPassword = "Password@123",
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "Password@123"),
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new User
                {
                    Id = "user_id_4",
                    FirstName = "David",
                    LastName = "Brown",
                    Email = "david.brown@gmail.com",
                    NormalizedEmail = "DAVID.BROWN@GMAIL.COM",
                    UserName = "david.brown@gmail.com", 
                    NormalizedUserName = "DAVID.BROWN@GMAIL.COM",
                    ImageUrl = "https://example.com/david.jpg",
                    Occupation = "Engineer",
                    BusinessName = "DB Tech",
                    ContactName = "Emma Brown",
                    PublicId = "public_id_4",
                    AddressId = "4",
                    Password = "Password@123",
                    ConfirmPassword = "Password@123",
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "Password@123"),
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new User
                {
                    Id = "user_id_5",
                    FirstName = "Sophia",
                    LastName = "Martinez",
                    Email = "sophia.martinez@gmail.com",
                    NormalizedEmail = "SOPHIA.MARTINEZ@GMAIL.COM",
                    UserName = "sophia.martinez@gmail.com",
                    NormalizedUserName = "SOPHIA.MARTINEZ@GMAIL.COM",
                    ImageUrl = "https://example.com/sophia.jpg",
                    Occupation = "Artist",
                    BusinessName = "Artistic Creations",
                    ContactName = "Daniel Martinez",
                    PublicId = "public_id_5",
                    AddressId = "5",
                    Password = "Password@123",
                    ConfirmPassword = "Password@123",
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "Password@123"),
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new User
                {
                    Id = "user_id_6",
                    FirstName = "James",
                    LastName = "Lee",
                    Email = "james.lee@gmail.com",
                    NormalizedEmail = "JAMES.LEE@GMAIL.COM",
                    UserName = "james.lee@gmail.com",
                    NormalizedUserName = "JAMES.LEE@GMAIL.COM",
                    ImageUrl = "https://example.com/james.jpg",
                    Occupation = "Marketing Manager",
                    BusinessName = "Lee Marketing Solutions",
                    ContactName = "Olivia Lee",
                    PublicId = "public_id_6",
                    AddressId = "6",
                    Password = "Password@123",
                    ConfirmPassword = "Password@123",
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "Password@123"),
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new User
                {
                    Id = "user_id_7",
                    FirstName = "Emma",
                    LastName = "Wilson",
                    Email = "emma.wilson@gmail.com",
                    NormalizedEmail = "EMMA.WILSON@GMAIL.COM",
                    UserName = "emma.wilson@gmail.com",
                    NormalizedUserName = "EMMA.WILSON@GMAIL.COM",
                    ImageUrl = "https://example.com/emma.jpg",
                    Occupation = "Teacher",
                    BusinessName = "Educational Institute",
                    ContactName = "Noah Wilson",
                    PublicId = "public_id_7",
                    AddressId = "7",
                    Password = "Password@123",
                    ConfirmPassword = "Password@123",
                    PasswordHash = new PasswordHasher<User>().HashPassword(null, "Password@123"),
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                }
            );



            modelBuilder.Entity<Vendor>().HasData(
                new Vendor
                {
                    Id = "1",
                    UserId = "user_id_1",
                    AddressId = "1",
                    CompanyName = "Vendor Company",
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new Vendor
                {
                    Id = "2",
                    UserId = "user_id_2",
                    AddressId = "2",
                    CompanyName = "Second Vendor Company",
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new Vendor
                {
                    Id = "3",
                    UserId = "user_id_3",
                    AddressId = "3",
                    CompanyName = "Third Vendor Company",
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                },
                new Vendor
                {
                    Id = "4",
                    UserId = "user_id_4",
                    AddressId = "4",
                    CompanyName = "Fourth Vendor Company",
                    CreatedAt = DateTimeOffset.UtcNow,
                    UpdatedAt = DateTimeOffset.UtcNow
                }
            );


        }

    }
}
