using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkinEmpireReforged.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skin_Brugere_BrugerId",
                table: "Skin");

            migrationBuilder.DropTable(
                name: "Brugere");

            migrationBuilder.DropIndex(
                name: "IX_Skin_BrugerId",
                table: "Skin");

            migrationBuilder.DropColumn(
                name: "BrugerId",
                table: "Skin");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "BrugerId",
                table: "Skin",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Brugere",
                columns: table => new
                {
                    BrugerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rolle = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brugere", x => x.BrugerId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skin_BrugerId",
                table: "Skin",
                column: "BrugerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skin_Brugere_BrugerId",
                table: "Skin",
                column: "BrugerId",
                principalTable: "Brugere",
                principalColumn: "BrugerId");
        }
    }
}
