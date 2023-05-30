using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RuTravel.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class alpha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cafes_Comments_CommentsRefId",
                table: "Cafes");

            migrationBuilder.DropForeignKey(
                name: "FK_Cafes_Photos_PhotosRefId",
                table: "Cafes");

            migrationBuilder.DropForeignKey(
                name: "FK_Flats_Comments_CommentsRefId",
                table: "Flats");

            migrationBuilder.DropForeignKey(
                name: "FK_Flats_Photos_PhotosRefId",
                table: "Flats");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Photos_PhotosRefId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Sights_Comments_CommentsRefId",
                table: "Sights");

            migrationBuilder.DropForeignKey(
                name: "FK_Sights_Photos_PhotosRefId",
                table: "Sights");

            migrationBuilder.DropForeignKey(
                name: "FK_Towns_Photos_PhotosRefId",
                table: "Towns");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Photos_PhotosRefId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Towns_TownsRefID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PhotosRefId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Towns_PhotosRefId",
                table: "Towns");

            migrationBuilder.DropIndex(
                name: "IX_Sights_CommentsRefId",
                table: "Sights");

            migrationBuilder.DropIndex(
                name: "IX_Sights_PhotosRefId",
                table: "Sights");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PhotosRefId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Flats_CommentsRefId",
                table: "Flats");

            migrationBuilder.DropIndex(
                name: "IX_Flats_PhotosRefId",
                table: "Flats");

            migrationBuilder.DropIndex(
                name: "IX_Cafes_CommentsRefId",
                table: "Cafes");

            migrationBuilder.DropIndex(
                name: "IX_Cafes_PhotosRefId",
                table: "Cafes");

            migrationBuilder.DropColumn(
                name: "PhotosRefId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhotosRefId",
                table: "Towns");

            migrationBuilder.DropColumn(
                name: "CommentsRefId",
                table: "Sights");

            migrationBuilder.DropColumn(
                name: "PhotosRefId",
                table: "Sights");

            migrationBuilder.DropColumn(
                name: "PhotosRefId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CommentsRefId",
                table: "Flats");

            migrationBuilder.DropColumn(
                name: "PhotosRefId",
                table: "Flats");

            migrationBuilder.DropColumn(
                name: "CommentsRefId",
                table: "Cafes");

            migrationBuilder.DropColumn(
                name: "PhotosRefId",
                table: "Cafes");

            migrationBuilder.AddColumn<int>(
                name: "CafesRefId",
                table: "Photos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FlatsRefId",
                table: "Photos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PostsRefId",
                table: "Photos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SightsRefId",
                table: "Photos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TownsRefId",
                table: "Photos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsersRefId",
                table: "Photos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CafesRefId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FlatsRefId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SightsRefId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_CafesRefId",
                table: "Photos",
                column: "CafesRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_FlatsRefId",
                table: "Photos",
                column: "FlatsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_PostsRefId",
                table: "Photos",
                column: "PostsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_SightsRefId",
                table: "Photos",
                column: "SightsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_TownsRefId",
                table: "Photos",
                column: "TownsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UsersRefId",
                table: "Photos",
                column: "UsersRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CafesRefId",
                table: "Comments",
                column: "CafesRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_FlatsRefId",
                table: "Comments",
                column: "FlatsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_SightsRefId",
                table: "Comments",
                column: "SightsRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Cafes_CafesRefId",
                table: "Comments",
                column: "CafesRefId",
                principalTable: "Cafes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Flats_FlatsRefId",
                table: "Comments",
                column: "FlatsRefId",
                principalTable: "Flats",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Sights_SightsRefId",
                table: "Comments",
                column: "SightsRefId",
                principalTable: "Sights",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Cafes_CafesRefId",
                table: "Photos",
                column: "CafesRefId",
                principalTable: "Cafes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Flats_FlatsRefId",
                table: "Photos",
                column: "FlatsRefId",
                principalTable: "Flats",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Posts_PostsRefId",
                table: "Photos",
                column: "PostsRefId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Sights_SightsRefId",
                table: "Photos",
                column: "SightsRefId",
                principalTable: "Sights",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Towns_TownsRefId",
                table: "Photos",
                column: "TownsRefId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Users_UsersRefId",
                table: "Photos",
                column: "UsersRefId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Towns_TownsRefID",
                table: "Users",
                column: "TownsRefID",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Cafes_CafesRefId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Flats_FlatsRefId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Sights_SightsRefId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Cafes_CafesRefId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Flats_FlatsRefId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Posts_PostsRefId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Sights_SightsRefId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Towns_TownsRefId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Users_UsersRefId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Towns_TownsRefID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Photos_CafesRefId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_FlatsRefId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_PostsRefId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_SightsRefId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_TownsRefId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_UsersRefId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CafesRefId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_FlatsRefId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_SightsRefId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CafesRefId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "FlatsRefId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "PostsRefId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "SightsRefId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "TownsRefId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "UsersRefId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "CafesRefId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "FlatsRefId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "SightsRefId",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "PhotosRefId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PhotosRefId",
                table: "Towns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommentsRefId",
                table: "Sights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PhotosRefId",
                table: "Sights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PhotosRefId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommentsRefId",
                table: "Flats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PhotosRefId",
                table: "Flats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommentsRefId",
                table: "Cafes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PhotosRefId",
                table: "Cafes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PhotosRefId",
                table: "Users",
                column: "PhotosRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Towns_PhotosRefId",
                table: "Towns",
                column: "PhotosRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Sights_CommentsRefId",
                table: "Sights",
                column: "CommentsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Sights_PhotosRefId",
                table: "Sights",
                column: "PhotosRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PhotosRefId",
                table: "Posts",
                column: "PhotosRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Flats_CommentsRefId",
                table: "Flats",
                column: "CommentsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Flats_PhotosRefId",
                table: "Flats",
                column: "PhotosRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Cafes_CommentsRefId",
                table: "Cafes",
                column: "CommentsRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Cafes_PhotosRefId",
                table: "Cafes",
                column: "PhotosRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cafes_Comments_CommentsRefId",
                table: "Cafes",
                column: "CommentsRefId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Cafes_Photos_PhotosRefId",
                table: "Cafes",
                column: "PhotosRefId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Flats_Comments_CommentsRefId",
                table: "Flats",
                column: "CommentsRefId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Flats_Photos_PhotosRefId",
                table: "Flats",
                column: "PhotosRefId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Photos_PhotosRefId",
                table: "Posts",
                column: "PhotosRefId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Sights_Comments_CommentsRefId",
                table: "Sights",
                column: "CommentsRefId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Sights_Photos_PhotosRefId",
                table: "Sights",
                column: "PhotosRefId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Towns_Photos_PhotosRefId",
                table: "Towns",
                column: "PhotosRefId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Photos_PhotosRefId",
                table: "Users",
                column: "PhotosRefId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Towns_TownsRefID",
                table: "Users",
                column: "TownsRefID",
                principalTable: "Towns",
                principalColumn: "Id");
        }
    }
}
