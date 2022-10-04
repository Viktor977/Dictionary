using Microsoft.EntityFrameworkCore.Migrations;

namespace Dictiomary.Dal.Migrations
{
    public partial class Restrics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Words_Englishes_EnglishWordId",
                table: "Words");

            migrationBuilder.DropForeignKey(
                name: "FK_Words_Ukranians_UkranianWordId",
                table: "Words");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Words",
                table: "Words");

            migrationBuilder.DropIndex(
                name: "IX_Words_EnglishWordId",
                table: "Words");

            migrationBuilder.DropIndex(
                name: "IX_Words_UkranianWordId",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "EnglishWordId",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "UkranianWordId",
                table: "Words");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Words",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Word",
                table: "Ukranians",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Word",
                table: "Englishes",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Words",
                table: "Words",
                columns: new[] { "UkrId", "EngId" });

            migrationBuilder.CreateIndex(
                name: "IX_Words_EngId",
                table: "Words",
                column: "EngId");

            migrationBuilder.AddForeignKey(
                name: "FK_Words_Englishes_EngId",
                table: "Words",
                column: "EngId",
                principalTable: "Englishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Words_Ukranians_UkrId",
                table: "Words",
                column: "UkrId",
                principalTable: "Ukranians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Words_Englishes_EngId",
                table: "Words");

            migrationBuilder.DropForeignKey(
                name: "FK_Words_Ukranians_UkrId",
                table: "Words");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Words",
                table: "Words");

            migrationBuilder.DropIndex(
                name: "IX_Words_EngId",
                table: "Words");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Words",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "EnglishWordId",
                table: "Words",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UkranianWordId",
                table: "Words",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Word",
                table: "Ukranians",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Word",
                table: "Englishes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Words",
                table: "Words",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Words_EnglishWordId",
                table: "Words",
                column: "EnglishWordId");

            migrationBuilder.CreateIndex(
                name: "IX_Words_UkranianWordId",
                table: "Words",
                column: "UkranianWordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Words_Englishes_EnglishWordId",
                table: "Words",
                column: "EnglishWordId",
                principalTable: "Englishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Words_Ukranians_UkranianWordId",
                table: "Words",
                column: "UkranianWordId",
                principalTable: "Ukranians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
