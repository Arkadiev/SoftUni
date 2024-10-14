using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CinemaApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMovieImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("126e6ebb-6637-4cf7-9ab7-a617c5960e92"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("1cf5efa3-97cd-4368-b959-ec4f60361aa9"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("d3e360f0-e043-456a-8a62-9b20fc345bb8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("03eb4702-a9c7-4062-ba6a-58469bc33bd3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("93965045-f5f8-4b74-aaf5-839294cc4f5c"));

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Movies",
                type: "nvarchar(2083)",
                maxLength: 2083,
                nullable: true,
                defaultValue: "~/images/no-image.jpg");

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { new Guid("07fe2097-6209-4e69-8b73-f845b7bf1706"), "Plovdiv", "Cinema City" },
                    { new Guid("214a5d1f-551b-4e88-8126-8cc92e75160b"), "Varna", "Cinemax" },
                    { new Guid("faaef338-5753-4f37-8240-7e85e5199af1"), "Sofia", "Cinema City" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Duration", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("21c60bdb-6ca8-4c76-86e0-0531784a1292"), "Description not yet implemented", "Peter Jackson", 178, "Fantasy", new DateTime(2001, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lord of the Rings" },
                    { new Guid("8cabaab2-8f3e-4cac-97d1-18bae6d92436"), "Description not yet implemented", "Mike Newel", 157, "Fantasy", new DateTime(2005, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Goblet of Fire" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("07fe2097-6209-4e69-8b73-f845b7bf1706"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("214a5d1f-551b-4e88-8126-8cc92e75160b"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("faaef338-5753-4f37-8240-7e85e5199af1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("21c60bdb-6ca8-4c76-86e0-0531784a1292"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8cabaab2-8f3e-4cac-97d1-18bae6d92436"));

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Movies");

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { new Guid("126e6ebb-6637-4cf7-9ab7-a617c5960e92"), "Varna", "Cinemax" },
                    { new Guid("1cf5efa3-97cd-4368-b959-ec4f60361aa9"), "Sofia", "Cinema City" },
                    { new Guid("d3e360f0-e043-456a-8a62-9b20fc345bb8"), "Plovdiv", "Cinema City" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Duration", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("03eb4702-a9c7-4062-ba6a-58469bc33bd3"), "Description not yet implemented", "Peter Jackson", 178, "Fantasy", new DateTime(2001, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lord of the Rings" },
                    { new Guid("93965045-f5f8-4b74-aaf5-839294cc4f5c"), "Description not yet implemented", "Mike Newel", 157, "Fantasy", new DateTime(2005, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Goblet of Fire" }
                });
        }
    }
}
