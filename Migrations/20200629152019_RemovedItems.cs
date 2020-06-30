using Microsoft.EntityFrameworkCore.Migrations;

namespace Api3.Migrations
{
    public partial class RemovedItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Artists_ArtistId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Genres_GenreId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Items_ArtistId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_GenreId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "LabelName",
                table: "Items");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabelName",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_ArtistId",
                table: "Items",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_GenreId",
                table: "Items",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Artists_ArtistId",
                table: "Items",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Genres_GenreId",
                table: "Items",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
