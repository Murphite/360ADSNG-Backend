using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _360AdsNG.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: true),
                    Latitude = table.Column<double>(type: "double precision", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Occupation = table.Column<string>(type: "text", nullable: true),
                    BusinessName = table.Column<string>(type: "text", nullable: true),
                    ContactName = table.Column<string>(type: "text", nullable: true),
                    PublicId = table.Column<string>(type: "text", nullable: false),
                    AddressId = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Billboards",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    AddressId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    BoardType = table.Column<string>(type: "text", nullable: false),
                    DailyImpressions = table.Column<int>(type: "integer", nullable: false),
                    DurationPerDisplay = table.Column<int>(type: "integer", nullable: false),
                    Time = table.Column<string>(type: "text", nullable: false),
                    Dimension = table.Column<string>(type: "text", nullable: false),
                    PixelSize = table.Column<string>(type: "text", nullable: false),
                    Orientation = table.Column<int>(type: "integer", nullable: false),
                    Negotiable = table.Column<int>(type: "integer", nullable: false),
                    TrafficDescription = table.Column<string>(type: "text", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Billboards_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Billboards_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    AddressId = table.Column<string>(type: "text", nullable: true),
                    CompanyName = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendors_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vendors_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "CreatedAt", "Latitude", "Longitude", "State", "Street", "UpdatedAt" },
                values: new object[,]
                {
                    { "0", "Admin City", "Admin Country", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(1830), new TimeSpan(0, 0, 0, 0, 0)), 78.909999999999997, 100.111, "Admin State", "123 Admin St", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(1834), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "1", "Cityville", "Countryland", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(1843), new TimeSpan(0, 0, 0, 0, 0)), 78.909999999999997, 123.456, "Stateville", "123 Main St", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(1844), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "2", "Townsville", "Anotherland", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(1849), new TimeSpan(0, 0, 0, 0, 0)), 12.345000000000001, 45.677999999999997, "Countyville", "456 Elm St", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(1850), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "3", "Villagetown", "Otherland", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(1862), new TimeSpan(0, 0, 0, 0, 0)), 67.890000000000001, 90.123000000000005, "Provinceville", "789 Oak St", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(1863), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "4", "Hamletville", "Someland", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(1867), new TimeSpan(0, 0, 0, 0, 0)), 89.012, 34.567, "Territorytown", "1011 Pine St", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(1874), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "5", "Countryside", "Landofthefree", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(1878), new TimeSpan(0, 0, 0, 0, 0)), 23.456, 56.789000000000001, "Districtville", "1213 Cedar St", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(1879), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "6", "Settlementtown", "Everywhere", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(1883), new TimeSpan(0, 0, 0, 0, 0)), 34.567, 78.900999999999996, "Municipality", "1415 Birch St", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(1883), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "7", "Hollowville", "Otherland", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(1887), new TimeSpan(0, 0, 0, 0, 0)), 90.123000000000005, 12.345000000000001, "Territorytown", "1617 Maple St", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(1888), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "BusinessName", "ConcurrencyStamp", "ConfirmPassword", "ContactName", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Occupation", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PublicId", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "admin_id", 0, "0", null, "a998b576-adcd-4af8-9509-e8e37d958edf", "Admin@123", null, new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 237, DateTimeKind.Unspecified).AddTicks(7941), new TimeSpan(0, 0, 0, 0, 0)), "admin@admin.com", false, "Admin", null, "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", null, "Admin@123", "AQAAAAIAAYagAAAAEMlSx0lFvcbTKyrTVmRKq5IC5Y3TOa16vw1yV0BNa37n+9e3cMLGUjMIKkerHDTW/w==", "08130990162", false, "public_id_0", "61015d8e-2b39-4ce7-849a-61281f89079c", false, new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 237, DateTimeKind.Unspecified).AddTicks(7945), new TimeSpan(0, 0, 0, 0, 0)), "admin@admin.com" },
                    { "user_id_1", 0, "1", "ABC Company", "620efb65-26a2-4669-b8df-4ec3d217f1ce", "Password@123", "Jane Doe", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 378, DateTimeKind.Unspecified).AddTicks(3860), new TimeSpan(0, 0, 0, 0, 0)), "john.doe@gmail.com", false, "John", "https://images.unsplash.com/photo-1633332755192-727a05c4013d?q=80&w=1780&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Doe", false, null, "JOHN.DOE@GMAIL.COM", "JOHN.DOE@GMAIL.COM", "Developer", "Password@123", "AQAAAAIAAYagAAAAEB0R4ZQcU9rVCvIAxoL0Wy93FBMnG6bbN3mg572mH6hWeKFWgUugVITAB71oIoILaQ==", null, false, "public_id_1", "e6cd3028-4498-43f2-b596-175cd0854576", false, new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 378, DateTimeKind.Unspecified).AddTicks(3866), new TimeSpan(0, 0, 0, 0, 0)), "john.doe@gmail.com" },
                    { "user_id_2", 0, "2", "XYZ Company", "e271c1f7-d9de-4484-a4aa-d13a7c423162", "Password@123", "John Smith", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 496, DateTimeKind.Unspecified).AddTicks(2267), new TimeSpan(0, 0, 0, 0, 0)), "alice.smith@gmail.com", false, "Alice", "https://unsplash.com/photos/closeup-photography-of-woman-smiling-mEZ3PoFGs_k", "Smith", false, null, "ALICE.SMITH@GMAIL.COM", "ALICE.SMITH@GMAIL.COM", "Designer", "Password@123", "AQAAAAIAAYagAAAAEAzw3oM6K1HEva57Aq0nP2ivZJeD/1hBdgtJDXMlTSDDiNDgkAedcHYWszbgZNa5Hw==", null, false, "public_id_2", "35df2c5f-882e-467e-92b6-5fb8847c7738", false, new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 496, DateTimeKind.Unspecified).AddTicks(2275), new TimeSpan(0, 0, 0, 0, 0)), "alice.smith@gmail.com" },
                    { "user_id_3", 0, "3", "EFG Enterprises", "19de1629-ebda-43a0-961b-a9956ceda372", "Password@123", "Michael Johnson", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 617, DateTimeKind.Unspecified).AddTicks(7157), new TimeSpan(0, 0, 0, 0, 0)), "emily.johnson@gmail.com", false, "Emily", "https://www.istockphoto.com/photo/headshot-portrait-of-smiling-male-employee-in-office-gm1309328823-399075075", "Johnson", false, null, "EMILY.JOHNSON@GMAIL.COM", "EMILY.JOHNSON@GMAIL.COM", "Writer", "Password@123", "AQAAAAIAAYagAAAAEFkYX0F3Q9NDReJAu5yUY49Wa2hmxQ8M/x24fKDyTIgd7L2WaWqTNwf2TZF71xemrw==", null, false, "public_id_3", "887fb302-e008-4d23-bf5b-65117960477a", false, new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 617, DateTimeKind.Unspecified).AddTicks(7162), new TimeSpan(0, 0, 0, 0, 0)), "emily.johnson@gmail.com" },
                    { "user_id_4", 0, "4", "DB Tech", "1dff1dd2-459d-4c0d-a97e-9c7a73e7e04c", "Password@123", "Emma Brown", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 727, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 0, 0, 0, 0)), "david.brown@gmail.com", false, "David", "https://example.com/david.jpg", "Brown", false, null, "DAVID.BROWN@GMAIL.COM", "DAVID.BROWN@GMAIL.COM", "Engineer", "Password@123", "AQAAAAIAAYagAAAAEGu/ObVF6swfVOjRy8bGplHPPItqqSprm/vI/G9RnmL0x7sccut26gBGTIdMS8iccw==", null, false, "public_id_4", "d351801b-d686-40fd-a961-bc00e422a187", false, new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 727, DateTimeKind.Unspecified).AddTicks(4851), new TimeSpan(0, 0, 0, 0, 0)), "david.brown@gmail.com" },
                    { "user_id_5", 0, "5", "Artistic Creations", "3430640a-9829-4dea-a299-9614c9f562cb", "Password@123", "Daniel Martinez", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 832, DateTimeKind.Unspecified).AddTicks(5824), new TimeSpan(0, 0, 0, 0, 0)), "sophia.martinez@gmail.com", false, "Sophia", "https://example.com/sophia.jpg", "Martinez", false, null, "SOPHIA.MARTINEZ@GMAIL.COM", "SOPHIA.MARTINEZ@GMAIL.COM", "Artist", "Password@123", "AQAAAAIAAYagAAAAEODi3migON7xmzgeZCtXZdYwnoQK/lrJ/WFTEeznlSnRVwYN7EkdZJ2TYN8Xo8ERGA==", null, false, "public_id_5", "0d856bb9-0d6d-4f11-a9e3-73f13365bf35", false, new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 832, DateTimeKind.Unspecified).AddTicks(5828), new TimeSpan(0, 0, 0, 0, 0)), "sophia.martinez@gmail.com" },
                    { "user_id_6", 0, "6", "Lee Marketing Solutions", "c9810d79-5635-4f29-939f-209a5dab938e", "Password@123", "Olivia Lee", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 970, DateTimeKind.Unspecified).AddTicks(7178), new TimeSpan(0, 0, 0, 0, 0)), "james.lee@gmail.com", false, "James", "https://example.com/james.jpg", "Lee", false, null, "JAMES.LEE@GMAIL.COM", "JAMES.LEE@GMAIL.COM", "Marketing Manager", "Password@123", "AQAAAAIAAYagAAAAEIgAoMqrMTfR6LuW/xQcVpUbk9L6YtYESGsyXCU+I3ir0zmLDetMehLOr9zHq09i6w==", null, false, "public_id_6", "cc02af1e-e6c0-41d1-b8e8-7bb20fe692a4", false, new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 970, DateTimeKind.Unspecified).AddTicks(7184), new TimeSpan(0, 0, 0, 0, 0)), "james.lee@gmail.com" },
                    { "user_id_7", 0, "7", "Educational Institute", "15146a88-7fef-420a-8185-38fc1eeb6cf9", "Password@123", "Noah Wilson", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 10, 0, 115, DateTimeKind.Unspecified).AddTicks(8993), new TimeSpan(0, 0, 0, 0, 0)), "emma.wilson@gmail.com", false, "Emma", "https://example.com/emma.jpg", "Wilson", false, null, "EMMA.WILSON@GMAIL.COM", "EMMA.WILSON@GMAIL.COM", "Teacher", "Password@123", "AQAAAAIAAYagAAAAEBXAlLo06iKDR3SXkf/YQjye7S10vFZgcYljx0BApkLSM9cYyYEVI6fZwmbk43pWJw==", null, false, "public_id_7", "5161e48a-7046-4eb6-8c81-077c06b2d8e0", false, new DateTimeOffset(new DateTime(2024, 5, 29, 19, 10, 0, 115, DateTimeKind.Unspecified).AddTicks(8998), new TimeSpan(0, 0, 0, 0, 0)), "emma.wilson@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Billboards",
                columns: new[] { "Id", "AddressId", "BoardType", "CreatedAt", "DailyImpressions", "Dimension", "DurationPerDisplay", "ImageUrl", "Name", "Negotiable", "Note", "Orientation", "PixelSize", "Price", "Time", "TrafficDescription", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { "1", "1", "Static", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(2163), new TimeSpan(0, 0, 0, 0, 0)), 1000, "10x20", 10, "https://images.examples.com/wp-content/uploads/2018/04/Urban-Billboard-Design-Example.jpg", "Billboard 1", 0, "Additional notes", 1, "1080p", 100, "Day", "High traffic area", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(2163), new TimeSpan(0, 0, 0, 0, 0)), "user_id_1" },
                    { "2", "2", "Static", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(2176), new TimeSpan(0, 0, 0, 0, 0)), 800, "20x40", 15, "https://images.examples.com/wp-content/uploads/2018/04/Street-Billboard-Design-Example.jpg", "Billboard 2", 1, "Some notes", 0, "4k", 150, "Night", "Moderate traffic area", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(2177), new TimeSpan(0, 0, 0, 0, 0)), "user_id_2" },
                    { "3", "3", "Static", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, 0, 0, 0, 0)), 1000, "20x40", 15, "https://images.examples.com/wp-content/uploads/2018/04/School-Billboard-Design-Example.jpg", "Billboard 3", 1, "Some notes", 1, "4k", 250, "Night", "Moderate traffic area", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, 0, 0, 0, 0)), "user_id_3" },
                    { "4", "4", "Dynamic", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(2226), new TimeSpan(0, 0, 0, 0, 0)), 1000, "20x40", 15, "https://images.examples.com/wp-content/uploads/2018/04/Metal-Billboard-Design-Example.jpg", "Billboard 4", 1, "Some notes", 1, "4k", 250, "Night", "Metal Billboard traffic area", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 9, 59, 129, DateTimeKind.Unspecified).AddTicks(2226), new TimeSpan(0, 0, 0, 0, 0)), "user_id_4" }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "Id", "AddressId", "CompanyName", "CreatedAt", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { "1", "1", "Vendor Company", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 10, 0, 116, DateTimeKind.Unspecified).AddTicks(219), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 29, 19, 10, 0, 116, DateTimeKind.Unspecified).AddTicks(226), new TimeSpan(0, 0, 0, 0, 0)), "user_id_1" },
                    { "2", "2", "Second Vendor Company", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 10, 0, 116, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 29, 19, 10, 0, 116, DateTimeKind.Unspecified).AddTicks(360), new TimeSpan(0, 0, 0, 0, 0)), "user_id_2" },
                    { "3", "3", "Third Vendor Company", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 10, 0, 116, DateTimeKind.Unspecified).AddTicks(382), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 29, 19, 10, 0, 116, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 0, 0, 0, 0)), "user_id_3" },
                    { "4", "4", "Fourth Vendor Company", new DateTimeOffset(new DateTime(2024, 5, 29, 19, 10, 0, 116, DateTimeKind.Unspecified).AddTicks(387), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 29, 19, 10, 0, 116, DateTimeKind.Unspecified).AddTicks(388), new TimeSpan(0, 0, 0, 0, 0)), "user_id_4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Billboards_AddressId",
                table: "Billboards",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Billboards_UserId",
                table: "Billboards",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_AddressId",
                table: "Vendors",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_UserId",
                table: "Vendors",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Billboards");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
