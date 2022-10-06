using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.AppDbContext.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLikeMovies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    IsLike = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLikeMovies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Created", "CreatedBy", "Deleted", "Images", "Likes", "Title", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5336), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 1", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5337), "" },
                    { 2, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5339), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 2", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5340), "" },
                    { 3, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5341), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 3", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5341), "" },
                    { 4, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5342), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 4", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5343), "" },
                    { 5, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5344), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 5", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5344), "" },
                    { 6, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5345), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 6", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5345), "" },
                    { 7, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5346), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 7", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5346), "" },
                    { 8, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5347), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 8", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5349), "" },
                    { 9, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5349), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 9", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5350), "" },
                    { 10, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5351), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 10", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5351), "" },
                    { 11, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5352), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 11", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5352), "" },
                    { 12, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5354), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 12", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5354), "" },
                    { 13, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5355), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 13", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5355), "" },
                    { 14, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5357), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 14", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5358), "" },
                    { 15, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5359), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 15", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5359), "" },
                    { 16, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5360), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 16", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5360), "" },
                    { 17, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5361), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 17", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5362), "" },
                    { 18, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5363), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 18", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5364), "" },
                    { 19, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5364), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 19", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5365), "" },
                    { 20, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5367), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 20", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5367), "" },
                    { 21, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5368), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 21", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5368), "" },
                    { 22, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5369), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 22", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5369), "" },
                    { 23, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5372), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 23", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5372), "" },
                    { 24, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5373), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 24", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5374), "" },
                    { 25, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5375), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 25", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5375), "" },
                    { 26, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5376), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 26", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5377), "" },
                    { 27, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5377), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 27", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5378), "" },
                    { 28, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5380), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 28", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5380), "" },
                    { 29, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5381), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 29", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5381), "" },
                    { 30, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5382), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 30", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5383), "" },
                    { 31, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5383), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 31", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5385), "" },
                    { 32, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5386), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 32", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5386), "" },
                    { 33, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5388), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 33", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5390), "" },
                    { 34, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5391), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 34", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5391), "" },
                    { 35, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5392), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 35", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5393), "" },
                    { 36, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5394), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 36", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5395), "" },
                    { 37, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5396), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 37", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5397), "" },
                    { 38, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5398), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 38", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5398), "" },
                    { 39, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5399), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 39", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5399), "" },
                    { 40, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5401), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 40", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5402), "" },
                    { 41, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5403), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 41", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5403), "" },
                    { 42, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5404), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 42", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5404), "" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Created", "CreatedBy", "Deleted", "Images", "Likes", "Title", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { 43, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5405), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 43", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5406), "" },
                    { 44, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5406), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 44", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5407), "" },
                    { 45, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5408), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 45", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5408), "" },
                    { 46, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5409), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 46", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5410), "" },
                    { 47, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5412), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 47", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5413), "" },
                    { 48, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5414), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 48", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5415), "" },
                    { 49, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5416), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 49", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5417), "" },
                    { 50, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5419), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 50", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5419), "" },
                    { 51, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5421), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 51", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5421), "" },
                    { 52, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5422), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 52", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5423), "" },
                    { 53, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5426), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 53", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5427), "" },
                    { 54, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5428), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 54", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5428), "" },
                    { 55, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5431), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 55", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5431), "" },
                    { 56, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5432), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 56", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5433), "" },
                    { 57, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5434), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 57", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5434), "" },
                    { 58, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5435), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 58", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5436), "" },
                    { 59, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5437), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 59", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5438), "" },
                    { 60, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5439), "", false, "https://znews-photo.zingcdn.me/w1920/Uploaded/xbhunku/2019_03_15/D1nkY7UVAAUs7KN.jpg", 0, "Phim số 60", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5439), "" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "CreatedBy", "Deleted", "Email", "PasswordHash", "Updated", "UpdatedBy", "UserName" },
                values: new object[] { 1, new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5209), "", false, "user@gmail.com", "$2a$10$8gmvdASPQtXPwQQuwpR66u.VOUvH.E66QUoG8egLGUSzcgfpIZgOG", new DateTime(2022, 10, 7, 0, 24, 12, 906, DateTimeKind.Local).AddTicks(5222), "", "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "UserLikeMovies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
