using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CinemaApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserMovieWishlist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("55217f66-bbb7-47e2-8991-5eaf18e4eecd"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("9d2111b9-9c11-4acb-b50c-85cb3a3fc948"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("e3067069-cb28-45da-86ff-5bfed03ecbe4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ed67269c-165b-414d-ada4-62ea6460d04e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f4ca0d32-771b-41f4-93ec-770c4adf30bf"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "ApplicationUserMovie",
                columns: table => new
                {
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserMovie", x => new { x.ApplicationUserId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserMovie_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserMovie_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserMovie_MovieId",
                table: "ApplicationUserMovie",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserMovie");

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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { new Guid("55217f66-bbb7-47e2-8991-5eaf18e4eecd"), "Sofia", "Cinema City" },
                    { new Guid("9d2111b9-9c11-4acb-b50c-85cb3a3fc948"), "Plovdiv", "Cinema City" },
                    { new Guid("e3067069-cb28-45da-86ff-5bfed03ecbe4"), "Varna", "Cinemax" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Duration", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("ed67269c-165b-414d-ada4-62ea6460d04e"), "Description not yet implemented", "Mike Newel", 157, "Fantasy", new DateTime(2005, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Goblet of Fire" },
                    { new Guid("f4ca0d32-771b-41f4-93ec-770c4adf30bf"), "Description not yet implemented", "Peter Jackson", 178, "Fantasy", new DateTime(2001, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lord of the Rings" }
                });
        }
    }
}
