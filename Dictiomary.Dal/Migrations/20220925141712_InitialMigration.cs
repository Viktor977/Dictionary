using Microsoft.EntityFrameworkCore.Migrations;

namespace Dictiomary.Dal.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Englishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Word = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Englishes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ukranians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Word = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ukranians", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngId = table.Column<int>(type: "int", nullable: false),
                    EnglishWordId = table.Column<int>(type: "int", nullable: true),
                    UkrId = table.Column<int>(type: "int", nullable: false),
                    UkranianWordId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Words_Englishes_EnglishWordId",
                        column: x => x.EnglishWordId,
                        principalTable: "Englishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Words_Ukranians_UkranianWordId",
                        column: x => x.UkranianWordId,
                        principalTable: "Ukranians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Words_EnglishWordId",
                table: "Words",
                column: "EnglishWordId");

            migrationBuilder.CreateIndex(
                name: "IX_Words_UkranianWordId",
                table: "Words",
                column: "UkranianWordId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Words");

            migrationBuilder.DropTable(
                name: "Englishes");

            migrationBuilder.DropTable(
                name: "Ukranians");
        }
    }
}
