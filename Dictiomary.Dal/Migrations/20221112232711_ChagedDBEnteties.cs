using Microsoft.EntityFrameworkCore.Migrations;

namespace Dictiomary.Dal.Migrations
{
    public partial class ChagedDBEnteties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Examples",
                table: "Words",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Word",
                table: "Words",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Examples",
                table: "Ukranians",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Examples",
                table: "Englishes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Examples",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "Word",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "Examples",
                table: "Ukranians");

            migrationBuilder.DropColumn(
                name: "Examples",
                table: "Englishes");
        }
    }
}
