using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _360AdsNG.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "CreatedAt", "Latitude", "Longitude", "State", "Street", "UpdatedAt" },
                values: new object[,]
                {
                    { "0", "Admin City", "Admin Country", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3884), new TimeSpan(0, 0, 0, 0, 0)), 78.909999999999997, 100.111, "Admin State", "123 Admin St", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3885), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "1", "Cityville", "Countryland", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3890), new TimeSpan(0, 0, 0, 0, 0)), 78.909999999999997, 123.456, "Stateville", "123 Main St", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3891), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "2", "Townsville", "Anotherland", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3896), new TimeSpan(0, 0, 0, 0, 0)), 12.345000000000001, 45.677999999999997, "Countyville", "456 Elm St", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3896), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "3", "Villagetown", "Otherland", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3900), new TimeSpan(0, 0, 0, 0, 0)), 67.890000000000001, 90.123000000000005, "Provinceville", "789 Oak St", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3901), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "4", "Hamletville", "Someland", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3905), new TimeSpan(0, 0, 0, 0, 0)), 89.012, 34.567, "Territorytown", "1011 Pine St", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3906), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "5", "Countryside", "Landofthefree", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3910), new TimeSpan(0, 0, 0, 0, 0)), 23.456, 56.789000000000001, "Districtville", "1213 Cedar St", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3910), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "6", "Settlementtown", "Everywhere", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3918), new TimeSpan(0, 0, 0, 0, 0)), 34.567, 78.900999999999996, "Municipality", "1415 Birch St", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3919), new TimeSpan(0, 0, 0, 0, 0)) },
                    { "7", "Hollowville", "Otherland", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3931), new TimeSpan(0, 0, 0, 0, 0)), 90.123000000000005, 12.345000000000001, "Territorytown", "1617 Maple St", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3936), new TimeSpan(0, 0, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "BusinessName", "ConcurrencyStamp", "ConfirmPassword", "ContactName", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Occupation", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PublicId", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "user_id_1", 0, "1", "ABC Company", "ca8cf467-9b9c-4674-ab15-74380d128c5a", "Password@123", "Jane Doe", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 711, DateTimeKind.Unspecified).AddTicks(6857), new TimeSpan(0, 0, 0, 0, 0)), "john.doe@gmail.com", false, "John", "https://images.unsplash.com/photo-1633332755192-727a05c4013d?q=80&w=1780&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "Doe", false, null, "JOHN.DOE@GMAIL.COM", "JOHN.DOE@GMAIL.COM", "Developer", "Password@123", "AQAAAAIAAYagAAAAEOr1I72wwp8Ic/rp6PECghI/+eXi7ZpMFF5MhJYR5+rKbB2ZhIPRl5Zi5Ums8WGceg==", null, false, "public_id_1", "0e33e7c4-ae32-430d-bf69-5c42e1fc0b83", false, new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 711, DateTimeKind.Unspecified).AddTicks(6861), new TimeSpan(0, 0, 0, 0, 0)), "john.doe@gmail.com" },
                    { "user_id_2", 0, "2", "XYZ Company", "a57683bf-eeac-45c9-9cc2-21eb177a71e1", "Password@123", "John Smith", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 756, DateTimeKind.Unspecified).AddTicks(8532), new TimeSpan(0, 0, 0, 0, 0)), "alice.smith@gmail.com", false, "Alice", "https://unsplash.com/photos/closeup-photography-of-woman-smiling-mEZ3PoFGs_k", "Smith", false, null, "ALICE.SMITH@GMAIL.COM", "ALICE.SMITH@GMAIL.COM", "Designer", "Password@123", "AQAAAAIAAYagAAAAEJoOijBxbxyxsUOllATV1YImd/cGsP+gjAJVjmcx3mijw9iQH0DKtKhSzkM6VY4ASA==", null, false, "public_id_2", "5f597a6a-1da2-4520-9267-3b54048a15b2", false, new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 756, DateTimeKind.Unspecified).AddTicks(8537), new TimeSpan(0, 0, 0, 0, 0)), "alice.smith@gmail.com" },
                    { "user_id_3", 0, "3", "EFG Enterprises", "588a0fd3-db80-4856-8c24-2606a1e3e51f", "Password@123", "Michael Johnson", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 802, DateTimeKind.Unspecified).AddTicks(4087), new TimeSpan(0, 0, 0, 0, 0)), "emily.johnson@gmail.com", false, "Emily", "https://www.istockphoto.com/photo/headshot-portrait-of-smiling-male-employee-in-office-gm1309328823-399075075", "Johnson", false, null, "EMILY.JOHNSON@GMAIL.COM", "EMILY.JOHNSON@GMAIL.COM", "Writer", "Password@123", "AQAAAAIAAYagAAAAECvpJq30sJmR7ke2WJ0kyIjm+VA+MFUdjq35M30zl51mOyMBAF6HnItRBcKVOJsVHQ==", null, false, "public_id_3", "a896168d-6d93-43c8-a9e2-b6294790bd2c", false, new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 802, DateTimeKind.Unspecified).AddTicks(4092), new TimeSpan(0, 0, 0, 0, 0)), "emily.johnson@gmail.com" },
                    { "user_id_4", 0, "4", "DB Tech", "ea34bf0e-3df7-49c6-8177-6d6b9f922827", "Password@123", "Emma Brown", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 849, DateTimeKind.Unspecified).AddTicks(4539), new TimeSpan(0, 0, 0, 0, 0)), "david.brown@gmail.com", false, "David", "https://example.com/david.jpg", "Brown", false, null, "DAVID.BROWN@GMAIL.COM", "DAVID.BROWN@GMAIL.COM", "Engineer", "Password@123", "AQAAAAIAAYagAAAAED5B/288nusnLrVKSqBhn/ayLq2hKR5Vz/pVdm4LkfrpySMw3CaT9Rl2cLoIklIDcw==", null, false, "public_id_4", "47d7dbef-c265-4f4d-81e4-5f2e65e5005c", false, new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 849, DateTimeKind.Unspecified).AddTicks(4547), new TimeSpan(0, 0, 0, 0, 0)), "david.brown@gmail.com" },
                    { "user_id_5", 0, "5", "Artistic Creations", "8e233a28-d5f1-4a2b-9078-eea747e854eb", "Password@123", "Daniel Martinez", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 895, DateTimeKind.Unspecified).AddTicks(1849), new TimeSpan(0, 0, 0, 0, 0)), "sophia.martinez@gmail.com", false, "Sophia", "https://example.com/sophia.jpg", "Martinez", false, null, "SOPHIA.MARTINEZ@GMAIL.COM", "SOPHIA.MARTINEZ@GMAIL.COM", "Artist", "Password@123", "AQAAAAIAAYagAAAAELTo39wELgHjOxgMUDK+5I5AdtroX55/psf7VMZFU9ROMgQiTjXS5nYsGEJ80gmctQ==", null, false, "public_id_5", "edae1ac4-307e-43e2-a3c7-eb3abcd4269e", false, new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 895, DateTimeKind.Unspecified).AddTicks(1851), new TimeSpan(0, 0, 0, 0, 0)), "sophia.martinez@gmail.com" },
                    { "user_id_6", 0, "6", "Lee Marketing Solutions", "f82b5f40-a110-4d17-9254-bbc2fb576c32", "Password@123", "Olivia Lee", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 941, DateTimeKind.Unspecified).AddTicks(6746), new TimeSpan(0, 0, 0, 0, 0)), "james.lee@gmail.com", false, "James", "https://example.com/james.jpg", "Lee", false, null, "JAMES.LEE@GMAIL.COM", "JAMES.LEE@GMAIL.COM", "Marketing Manager", "Password@123", "AQAAAAIAAYagAAAAEOOWDdmqLjXka+fG35DtAoHp21UjGbjhRQ7cBeglNK3+6gAgPMQCyY7Qo7GTSIsluQ==", null, false, "public_id_6", "66f24dd8-0068-4304-8f6c-e9d519679477", false, new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 941, DateTimeKind.Unspecified).AddTicks(6747), new TimeSpan(0, 0, 0, 0, 0)), "james.lee@gmail.com" },
                    { "user_id_7", 0, "7", "Educational Institute", "72340568-1559-485d-b543-8df5eeaa916b", "Password@123", "Noah Wilson", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4019), new TimeSpan(0, 0, 0, 0, 0)), "emma.wilson@gmail.com", false, "Emma", "https://example.com/emma.jpg", "Wilson", false, null, "EMMA.WILSON@GMAIL.COM", "EMMA.WILSON@GMAIL.COM", "Teacher", "Password@123", "AQAAAAIAAYagAAAAEPEnHYKh/smxUfrbaGQH/cTm1yU9oZvPqv2huqbN5vrFeXRqyF3a7+bnq8ywaMw0/A==", null, false, "public_id_7", "8e56b238-911d-44c1-8b0b-570de93f5902", false, new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4024), new TimeSpan(0, 0, 0, 0, 0)), "emma.wilson@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Billboards",
                columns: new[] { "Id", "AddressId", "BoardType", "CreatedAt", "DailyImpressions", "Dimension", "DurationPerDisplay", "ImageUrl", "Name", "Negotiable", "Note", "Orientation", "PixelSize", "Price", "Time", "TrafficDescription", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { "1", "1", "Static", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(4047), new TimeSpan(0, 0, 0, 0, 0)), 1000, "10x20", 10, "https://images.examples.com/wp-content/uploads/2018/04/Urban-Billboard-Design-Example.jpg", "Billboard 1", 0, "Additional notes", 1, "1080p", 100, "Day", "High traffic area", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(4048), new TimeSpan(0, 0, 0, 0, 0)), "user_id_1" },
                    { "2", "2", "Static", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(4053), new TimeSpan(0, 0, 0, 0, 0)), 800, "20x40", 15, "https://images.examples.com/wp-content/uploads/2018/04/Street-Billboard-Design-Example.jpg", "Billboard 2", 1, "Some notes", 0, "4k", 150, "Night", "Moderate traffic area", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(4054), new TimeSpan(0, 0, 0, 0, 0)), "user_id_2" },
                    { "3", "3", "Static", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(4059), new TimeSpan(0, 0, 0, 0, 0)), 1000, "20x40", 15, "https://images.examples.com/wp-content/uploads/2018/04/School-Billboard-Design-Example.jpg", "Billboard 3", 1, "Some notes", 1, "4k", 250, "Night", "Moderate traffic area", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(4059), new TimeSpan(0, 0, 0, 0, 0)), "user_id_3" },
                    { "4", "4", "Dynamic", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(4064), new TimeSpan(0, 0, 0, 0, 0)), 1000, "20x40", 15, "https://images.examples.com/wp-content/uploads/2018/04/Metal-Billboard-Design-Example.jpg", "Billboard 4", 1, "Some notes", 1, "4k", 250, "Night", "Metal Billboard traffic area", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(4065), new TimeSpan(0, 0, 0, 0, 0)), "user_id_4" }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "Id", "AddressId", "CompanyName", "CreatedAt", "UpdatedAt", "UserId", "VendorType" },
                values: new object[,]
                {
                    { "1", "1", "Vendor Company", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4590), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4592), new TimeSpan(0, 0, 0, 0, 0)), "user_id_1", 1 },
                    { "2", "2", "Second Vendor Company", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4603), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4604), new TimeSpan(0, 0, 0, 0, 0)), "user_id_2", 1 },
                    { "3", "3", "Third Vendor Company", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4608), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4609), new TimeSpan(0, 0, 0, 0, 0)), "user_id_3", 1 },
                    { "4", "4", "Fourth Vendor Company", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4667), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4668), new TimeSpan(0, 0, 0, 0, 0)), "user_id_4", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_7");

            migrationBuilder.DeleteData(
                table: "Billboards",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Billboards",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Billboards",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Billboards",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_4");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "4");
        }
    }
}
