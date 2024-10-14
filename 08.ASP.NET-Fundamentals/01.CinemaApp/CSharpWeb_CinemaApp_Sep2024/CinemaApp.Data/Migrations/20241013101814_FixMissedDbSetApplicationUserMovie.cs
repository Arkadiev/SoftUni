using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CinemaApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixMissedDbSetApplicationUserMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserMovie_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserMovie_Movies_MovieId",
                table: "ApplicationUserMovie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserMovie",
                table: "ApplicationUserMovie");

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

            migrationBuilder.RenameTable(
                name: "ApplicationUserMovie",
                newName: "UsersMovies");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserMovie_MovieId",
                table: "UsersMovies",
                newName: "IX_UsersMovies_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersMovies",
                table: "UsersMovies",
                columns: new[] { "ApplicationUserId", "MovieId" });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { new Guid("336fd906-5e3a-49cb-81ff-17b710a05680"), "Plovdiv", "Cinema City" },
                    { new Guid("536bb177-36eb-4a3e-bc4f-c225687b4634"), "Varna", "Cinemax" },
                    { new Guid("94157479-c238-4ac7-9a0f-1946b052f276"), "Sofia", "Cinema City" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Duration", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("a1487906-80ea-488b-8346-73f044c185dc"), "Description not yet implemented", "Peter Jackson", 178, "Fantasy", new DateTime(2001, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lord of the Rings" },
                    { new Guid("de3bd664-5ea7-4783-932c-ae8a19fed4ff"), "Description not yet implemented", "Mike Newel", 157, "Fantasy", new DateTime(2005, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Goblet of Fire" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UsersMovies_AspNetUsers_ApplicationUserId",
                table: "UsersMovies",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersMovies_Movies_MovieId",
                table: "UsersMovies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersMovies_AspNetUsers_ApplicationUserId",
                table: "UsersMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersMovies_Movies_MovieId",
                table: "UsersMovies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersMovies",
                table: "UsersMovies");

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("336fd906-5e3a-49cb-81ff-17b710a05680"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("536bb177-36eb-4a3e-bc4f-c225687b4634"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("94157479-c238-4ac7-9a0f-1946b052f276"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a1487906-80ea-488b-8346-73f044c185dc"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("de3bd664-5ea7-4783-932c-ae8a19fed4ff"));

            migrationBuilder.RenameTable(
                name: "UsersMovies",
                newName: "ApplicationUserMovie");

            migrationBuilder.RenameIndex(
                name: "IX_UsersMovies_MovieId",
                table: "ApplicationUserMovie",
                newName: "IX_ApplicationUserMovie_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserMovie",
                table: "ApplicationUserMovie",
                columns: new[] { "ApplicationUserId", "MovieId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserMovie_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserMovie",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserMovie_Movies_MovieId",
                table: "ApplicationUserMovie",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
