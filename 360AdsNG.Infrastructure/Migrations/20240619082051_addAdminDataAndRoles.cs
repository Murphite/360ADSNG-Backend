using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _360AdsNG.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addAdminDataAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6348), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6350), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6356), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6356), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6361), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6361), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6366), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6366), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6377), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6377), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6382), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6390), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6403), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6403), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6407), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6408), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8E4D3983-F718-4A22-AA52-3C59BCA7ABA4", "user_id_1" },
                    { "8E4D3983-F718-4A22-AA52-3C59BCA7ABA4", "user_id_2" },
                    { "8E4D3983-F718-4A22-AA52-3C59BCA7ABA4", "user_id_3" },
                    { "8E4D3983-F718-4A22-AA52-3C59BCA7ABA4", "user_id_4" },
                    { "588731E6-8914-4A5F-8385-7218ED3241E1", "user_id_5" },
                    { "588731E6-8914-4A5F-8385-7218ED3241E1", "user_id_6" },
                    { "588731E6-8914-4A5F-8385-7218ED3241E1", "user_id_7" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f89fe82f-5fd9-4cc9-9a0e-5b9be0fc87aa", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 758, DateTimeKind.Unspecified).AddTicks(6947), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEAwqvYPIgeCjJ2a44CCeBUpKAJUWpk/LDdGah+EiCEvf0XOIlgsNoTbXMBYQXm9ozA==", "87576d5a-c18e-4a19-a976-42cb57c6a82f", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 758, DateTimeKind.Unspecified).AddTicks(6955), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "16d2aa2d-ccff-4d75-8735-2abe33cf03ea", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 809, DateTimeKind.Unspecified).AddTicks(7696), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEHDDZ7VNL2cM6fjsI98wD8DV3RoqF35+ZJhIoixY2hjtAGDdjXJtkHVvCltdNdQNJw==", "cbcece57-b1f9-49e4-9213-4ace74ced2fb", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 809, DateTimeKind.Unspecified).AddTicks(7702), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "491a5c55-778e-4750-b1c3-66867609a500", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 860, DateTimeKind.Unspecified).AddTicks(7094), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEI1d/tikh8m/47JWYV5grTILo7r1gKoJlO//kIcOgMDdDZr04LUqzgcdl0vkyCVniw==", "f7d5deaa-d065-43f9-99b3-9efefc9211f4", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 860, DateTimeKind.Unspecified).AddTicks(7099), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4e4bff9f-7a2e-41c1-89ad-7bdb4e32f31b", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 904, DateTimeKind.Unspecified).AddTicks(9998), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEIz9Bm0yekVhNnBseR0y4jw3GddedQyhcbwHbRVrhFZyLn6YOkN9jm4PpNuW2+hDUg==", "0295656c-76ae-417c-af8a-235843bacb8b", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 905, DateTimeKind.Unspecified).AddTicks(4), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "eba98548-ee4f-4f6a-a140-60b2c9b19ee8", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 950, DateTimeKind.Unspecified).AddTicks(7104), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEEvZ2Ga1VA8zQjERe0PGsqzfwGju5V84YK5vpgjsfy7ps7qA6+6O7z4I5GHoSqXEWA==", "ec2fd4b7-e87c-4300-92a3-8ab6bbc5818a", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 950, DateTimeKind.Unspecified).AddTicks(7108), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c6b8e6bc-9c2f-4ab2-bae7-a3987f0ee422", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 995, DateTimeKind.Unspecified).AddTicks(6137), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAED/4icpi1oYrL753/ECMA+HCXLifnIMj+19KFHf3J+1DGSH6HI3ruIkVAKb3+D8I5Q==", "000296ba-6b58-42d4-a109-67953b42bfef", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 995, DateTimeKind.Unspecified).AddTicks(6138), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_7",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "48f47508-cbd5-43a0-a5b4-6e2f0602da9d", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 51, 42, DateTimeKind.Unspecified).AddTicks(4203), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEGNgq/ZU9Clh61IGzxKt9BpdYm20OjJdqK/pfv1CpsYvD9io4cxaG6gk9+ricGXygA==", "61ebf221-e993-41a1-b468-8857870bf7b3", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 51, 42, DateTimeKind.Unspecified).AddTicks(4204), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "BusinessName", "ConcurrencyStamp", "ConfirmPassword", "ContactName", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Occupation", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PublicId", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[] { "admin_id", 0, "0", null, "15d239af-d32c-4e37-a637-ee004a485b99", "Admin@123", null, new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 707, DateTimeKind.Unspecified).AddTicks(6736), new TimeSpan(0, 0, 0, 0, 0)), "admin@admin.com", false, "Admin", null, "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", null, "Admin@123", "AQAAAAIAAYagAAAAELX9r5SFj/TsKZt5yhgKrQV+aWJaQJvPL+tjRxu8DL1MAFupfpKBQ6cj7UQGNuF2/A==", "08130990162", false, "public_id_0", "c5d88764-89e9-4c12-a14a-fd88c9758785", false, new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 707, DateTimeKind.Unspecified).AddTicks(6743), new TimeSpan(0, 0, 0, 0, 0)), "admin@admin.com" });

            migrationBuilder.UpdateData(
                table: "Billboards",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6554), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6555), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Billboards",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6561), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6562), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Billboards",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6567), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6568), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Billboards",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6572), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 658, DateTimeKind.Unspecified).AddTicks(6573), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 51, 42, DateTimeKind.Unspecified).AddTicks(4677), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 51, 42, DateTimeKind.Unspecified).AddTicks(4679), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 51, 42, DateTimeKind.Unspecified).AddTicks(4683), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 51, 42, DateTimeKind.Unspecified).AddTicks(4685), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 51, 42, DateTimeKind.Unspecified).AddTicks(4689), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 51, 42, DateTimeKind.Unspecified).AddTicks(4690), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 51, 42, DateTimeKind.Unspecified).AddTicks(4694), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 51, 42, DateTimeKind.Unspecified).AddTicks(4696), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "C7D92975-6187-4A4A-AA7A-2CDE79566E27", "admin_id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "C7D92975-6187-4A4A-AA7A-2CDE79566E27", "admin_id" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8E4D3983-F718-4A22-AA52-3C59BCA7ABA4", "user_id_1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8E4D3983-F718-4A22-AA52-3C59BCA7ABA4", "user_id_2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8E4D3983-F718-4A22-AA52-3C59BCA7ABA4", "user_id_3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8E4D3983-F718-4A22-AA52-3C59BCA7ABA4", "user_id_4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "588731E6-8914-4A5F-8385-7218ED3241E1", "user_id_5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "588731E6-8914-4A5F-8385-7218ED3241E1", "user_id_6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "588731E6-8914-4A5F-8385-7218ED3241E1", "user_id_7" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_id");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3884), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3885), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3890), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3891), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3896), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3896), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3900), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3901), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3905), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3906), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3910), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3910), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3918), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3919), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3931), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(3936), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ca8cf467-9b9c-4674-ab15-74380d128c5a", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 711, DateTimeKind.Unspecified).AddTicks(6857), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEOr1I72wwp8Ic/rp6PECghI/+eXi7ZpMFF5MhJYR5+rKbB2ZhIPRl5Zi5Ums8WGceg==", "0e33e7c4-ae32-430d-bf69-5c42e1fc0b83", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 711, DateTimeKind.Unspecified).AddTicks(6861), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a57683bf-eeac-45c9-9cc2-21eb177a71e1", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 756, DateTimeKind.Unspecified).AddTicks(8532), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEJoOijBxbxyxsUOllATV1YImd/cGsP+gjAJVjmcx3mijw9iQH0DKtKhSzkM6VY4ASA==", "5f597a6a-1da2-4520-9267-3b54048a15b2", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 756, DateTimeKind.Unspecified).AddTicks(8537), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "588a0fd3-db80-4856-8c24-2606a1e3e51f", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 802, DateTimeKind.Unspecified).AddTicks(4087), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAECvpJq30sJmR7ke2WJ0kyIjm+VA+MFUdjq35M30zl51mOyMBAF6HnItRBcKVOJsVHQ==", "a896168d-6d93-43c8-a9e2-b6294790bd2c", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 802, DateTimeKind.Unspecified).AddTicks(4092), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "ea34bf0e-3df7-49c6-8177-6d6b9f922827", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 849, DateTimeKind.Unspecified).AddTicks(4539), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAED5B/288nusnLrVKSqBhn/ayLq2hKR5Vz/pVdm4LkfrpySMw3CaT9Rl2cLoIklIDcw==", "47d7dbef-c265-4f4d-81e4-5f2e65e5005c", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 849, DateTimeKind.Unspecified).AddTicks(4547), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8e233a28-d5f1-4a2b-9078-eea747e854eb", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 895, DateTimeKind.Unspecified).AddTicks(1849), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAELTo39wELgHjOxgMUDK+5I5AdtroX55/psf7VMZFU9ROMgQiTjXS5nYsGEJ80gmctQ==", "edae1ac4-307e-43e2-a3c7-eb3abcd4269e", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 895, DateTimeKind.Unspecified).AddTicks(1851), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f82b5f40-a110-4d17-9254-bbc2fb576c32", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 941, DateTimeKind.Unspecified).AddTicks(6746), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEOOWDdmqLjXka+fG35DtAoHp21UjGbjhRQ7cBeglNK3+6gAgPMQCyY7Qo7GTSIsluQ==", "66f24dd8-0068-4304-8f6c-e9d519679477", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 941, DateTimeKind.Unspecified).AddTicks(6747), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_7",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "72340568-1559-485d-b543-8df5eeaa916b", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4019), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEPEnHYKh/smxUfrbaGQH/cTm1yU9oZvPqv2huqbN5vrFeXRqyF3a7+bnq8ywaMw0/A==", "8e56b238-911d-44c1-8b0b-570de93f5902", new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4024), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Billboards",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(4047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(4048), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Billboards",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(4053), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(4054), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Billboards",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(4059), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(4059), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Billboards",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(4064), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 652, DateTimeKind.Unspecified).AddTicks(4065), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4590), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4592), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4603), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4604), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4608), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4609), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4667), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 7, 34, 55, 985, DateTimeKind.Unspecified).AddTicks(4668), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
