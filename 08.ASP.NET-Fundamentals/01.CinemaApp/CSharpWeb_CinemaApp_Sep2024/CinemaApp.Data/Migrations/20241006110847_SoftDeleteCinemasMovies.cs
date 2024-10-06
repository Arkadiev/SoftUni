using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CinemaApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SoftDeleteCinemasMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("03dbe05e-379f-41f0-81c1-e4a508b28cf1"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("4e50dc5e-a418-4d01-964c-6c974b22fbc9"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("64d855ba-ca78-4ef6-9854-381365e9a64f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("46d99c36-e9e8-49c9-99df-b8c4bc9fa9d1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("be6a28c8-6337-4508-ae91-294f0be8dbca"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CinemaMovies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { new Guid("086eec92-e4ef-4a1d-876f-e1e9b6773fe8"), "Sofia", "Cinema City" },
                    { new Guid("15ec2caf-ac71-4b53-ac02-f6a1ecb346e2"), "Plovdiv", "Cinema City" },
                    { new Guid("3d046b94-ab2b-46c1-baae-310ad0138ceb"), "Varna", "Cinemax" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Duration", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("6d5b8697-42cd-4562-a9d1-23336257b8af"), "Description not yet implemented", "Mike Newel", 157, "Fantasy", new DateTime(2005, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Goblet of Fire" },
                    { new Guid("8731ce58-d9c3-4bae-a7ba-affdcafcdcf1"), "Description not yet implemented", "Peter Jackson", 178, "Fantasy", new DateTime(2001, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lord of the Rings" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("086eec92-e4ef-4a1d-876f-e1e9b6773fe8"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("15ec2caf-ac71-4b53-ac02-f6a1ecb346e2"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("3d046b94-ab2b-46c1-baae-310ad0138ceb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6d5b8697-42cd-4562-a9d1-23336257b8af"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8731ce58-d9c3-4bae-a7ba-affdcafcdcf1"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CinemaMovies");

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { new Guid("03dbe05e-379f-41f0-81c1-e4a508b28cf1"), "Sofia", "Cinema City" },
                    { new Guid("4e50dc5e-a418-4d01-964c-6c974b22fbc9"), "Plovdiv", "Cinema City" },
                    { new Guid("64d855ba-ca78-4ef6-9854-381365e9a64f"), "Varna", "Cinemax" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Duration", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("46d99c36-e9e8-49c9-99df-b8c4bc9fa9d1"), "Description not yet implemented", "Mike Newel", 157, "Fantasy", new DateTime(2005, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Goblet of Fire" },
                    { new Guid("be6a28c8-6337-4508-ae91-294f0be8dbca"), "Description not yet implemented", "Peter Jackson", 178, "Fantasy", new DateTime(2001, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lord of the Rings" }
                });
        }
    }
}
