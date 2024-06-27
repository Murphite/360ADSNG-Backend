using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _360AdsNG.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MakePublicIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PublicId",
                table: "AspNetUsers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "0",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6410), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6412), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6418), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6418), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6424), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6424), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6429), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6430), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6439), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6440), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6445), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6449), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6454), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6454), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6467), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_id",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6ddfb67d-b389-4d0f-b840-9e51ec439948", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 468, DateTimeKind.Unspecified).AddTicks(9957), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEI/cgBcVtvIPidN9IaqeHPqWdxQkrraGrtJwDCucjJ6tt9Fe5x24EnjczbdNYQgQGA==", "6cda5d40-e8f4-4723-b8ee-507f924952a0", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 468, DateTimeKind.Unspecified).AddTicks(9962), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f3dd61f9-94ce-4a41-af0f-0dfb932b6f98", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 515, DateTimeKind.Unspecified).AddTicks(9521), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEKCKKyxY2Y4h7AVZY9vt+IvpyW1L5CCeAQdlFRwT1hHtM41UTymyb3NS6ohWdq6EyA==", "a01c6f11-fc86-4eb2-a785-d0806262fcbb", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 515, DateTimeKind.Unspecified).AddTicks(9529), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "92bea39d-762f-4c9e-bb03-5ec4a7b855bb", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 564, DateTimeKind.Unspecified).AddTicks(2690), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAELRScobVMatgZCsIXVAY8VH0PZSKqvV/q5L46gA1/06vxPtRX71kETX3VG3ms7bnOA==", "5bee6181-043e-44ab-acf5-4f0f465397c6", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 564, DateTimeKind.Unspecified).AddTicks(2691), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "63a8f3ed-3bae-49d8-8a16-24701aef7770", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 607, DateTimeKind.Unspecified).AddTicks(3037), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEOhNGU9nqy3U61W2n/OhG8bUBD0E08G7rtgDqn8xNj5C7Tq9cFhnN901CoV32ZSRvA==", "71d9f413-65c0-4d0c-b0a8-5b7472c4ca0d", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 607, DateTimeKind.Unspecified).AddTicks(3037), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "377112c0-0aa7-44c7-9ab8-15a0e573df1f", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 654, DateTimeKind.Unspecified).AddTicks(8572), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEJ0XVsWP3JUTwxGUH0c2/yFQydzp+OPXeVMV+FN0lGZOG2M16nLhVMEa/BRYhTbUQw==", "4c3cbef9-dbcd-4c1b-855e-ec4a78dc890e", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 654, DateTimeKind.Unspecified).AddTicks(8575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d4c1ede9-d3a7-4a6d-8ccc-c81420f88670", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 702, DateTimeKind.Unspecified).AddTicks(801), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEG6nQSfLjDmBlCHafPb2y6FpHvPMWdSdrG2/KBPcguvP9N/Ys48vCQFNtyYnZkrf8w==", "312113e3-9d11-40d7-972f-abfd3e0a31e2", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 702, DateTimeKind.Unspecified).AddTicks(802), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d09acb0a-e6df-4918-b770-32dbf36ed12a", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 749, DateTimeKind.Unspecified).AddTicks(5950), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEAAx227mOOEu5Y4gMTKRqYaUnOZaWHPk6iAF1J+S6Ni9FAdFsQCah44/yBignxb2IQ==", "0232a0ea-57f1-4c28-b6a9-2450ef1de455", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 749, DateTimeKind.Unspecified).AddTicks(5951), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user_id_7",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c567a698-d09d-4e46-9c8a-c34049e16824", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 798, DateTimeKind.Unspecified).AddTicks(1704), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAEIPxJsCQiyisfRAn41R9LYANVeDwcvHEJg8/ORzU4Vb0HfN+Pt5RDsx4KXJXmBhyPA==", "f592ad06-014f-4dea-b385-f78f858e1690", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 798, DateTimeKind.Unspecified).AddTicks(1707), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Billboards",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6663), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Billboards",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6670), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6671), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Billboards",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6677), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6678), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Billboards",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6683), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 418, DateTimeKind.Unspecified).AddTicks(6684), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 798, DateTimeKind.Unspecified).AddTicks(2194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 798, DateTimeKind.Unspecified).AddTicks(2195), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 798, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 798, DateTimeKind.Unspecified).AddTicks(2202), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 798, DateTimeKind.Unspecified).AddTicks(2205), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 798, DateTimeKind.Unspecified).AddTicks(2206), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 798, DateTimeKind.Unspecified).AddTicks(2210), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 19, 8, 54, 40, 798, DateTimeKind.Unspecified).AddTicks(2211), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PublicId",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_id",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "15d239af-d32c-4e37-a637-ee004a485b99", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 707, DateTimeKind.Unspecified).AddTicks(6736), new TimeSpan(0, 0, 0, 0, 0)), "AQAAAAIAAYagAAAAELX9r5SFj/TsKZt5yhgKrQV+aWJaQJvPL+tjRxu8DL1MAFupfpKBQ6cj7UQGNuF2/A==", "c5d88764-89e9-4c12-a14a-fd88c9758785", new DateTimeOffset(new DateTime(2024, 6, 19, 8, 20, 50, 707, DateTimeKind.Unspecified).AddTicks(6743), new TimeSpan(0, 0, 0, 0, 0)) });

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
        }
    }
}
