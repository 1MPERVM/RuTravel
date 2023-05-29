using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RuTravel.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotosRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Towns_Photos_PhotosRefId",
                        column: x => x.PhotosRefId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Login = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CountOfTravels = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    TownsRefID = table.Column<int>(type: "int", nullable: false),
                    PhotosRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Photos_PhotosRefId",
                        column: x => x.PhotosRefId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Users_Towns_TownsRefID",
                        column: x => x.TownsRefID,
                        principalTable: "Towns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsersRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UsersRefId",
                        column: x => x.UsersRefId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PhotosRefId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Photos_PhotosRefId",
                        column: x => x.PhotosRefId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Posts_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Cafes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    OpenTime = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ClosingTime = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TownsRefID = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    CommentsRefId = table.Column<int>(type: "int", nullable: false),
                    PhotosRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cafes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cafes_Comments_CommentsRefId",
                        column: x => x.CommentsRefId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Cafes_Photos_PhotosRefId",
                        column: x => x.PhotosRefId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Cafes_Towns_TownsRefID",
                        column: x => x.TownsRefID,
                        principalTable: "Towns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Flats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TownsRefID = table.Column<int>(type: "int", nullable: false),
                    CountOfRooms = table.Column<int>(type: "int", nullable: false),
                    OwnersPhone = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    PricePerMonth = table.Column<double>(type: "float", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    PhotosRefId = table.Column<int>(type: "int", nullable: false),
                    CommentsRefId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flats_Comments_CommentsRefId",
                        column: x => x.CommentsRefId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Flats_Photos_PhotosRefId",
                        column: x => x.PhotosRefId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Flats_Towns_TownsRefID",
                        column: x => x.TownsRefID,
                        principalTable: "Towns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Flats_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TownsRefID = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    CommentsRefId = table.Column<int>(type: "int", nullable: false),
                    PhotosRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sights_Comments_CommentsRefId",
                        column: x => x.CommentsRefId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Sights_Photos_PhotosRefId",
                        column: x => x.PhotosRefId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Sights_Towns_TownsRefID",
                        column: x => x.TownsRefID,
                        principalTable: "Towns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cafes_CommentsRefId",
                table: "Cafes",
                column: "CommentsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Cafes_PhotosRefId",
                table: "Cafes",
                column: "PhotosRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Cafes_TownsRefID",
                table: "Cafes",
                column: "TownsRefID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UsersRefId",
                table: "Comments",
                column: "UsersRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Flats_CommentsRefId",
                table: "Flats",
                column: "CommentsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Flats_PhotosRefId",
                table: "Flats",
                column: "PhotosRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Flats_TownsRefID",
                table: "Flats",
                column: "TownsRefID");

            migrationBuilder.CreateIndex(
                name: "IX_Flats_UsersId",
                table: "Flats",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PhotosRefId",
                table: "Posts",
                column: "PhotosRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UsersId",
                table: "Posts",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Sights_CommentsRefId",
                table: "Sights",
                column: "CommentsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Sights_PhotosRefId",
                table: "Sights",
                column: "PhotosRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Sights_TownsRefID",
                table: "Sights",
                column: "TownsRefID");

            migrationBuilder.CreateIndex(
                name: "IX_Towns_PhotosRefId",
                table: "Towns",
                column: "PhotosRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PhotosRefId",
                table: "Users",
                column: "PhotosRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TownsRefID",
                table: "Users",
                column: "TownsRefID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cafes");

            migrationBuilder.DropTable(
                name: "Flats");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Sights");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Towns");

            migrationBuilder.DropTable(
                name: "Photos");
        }
    }
}
