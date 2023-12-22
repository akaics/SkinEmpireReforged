using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkinEmpireReforged.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skins_Brugere_BrugerId",
                table: "Skins");

            migrationBuilder.DropForeignKey(
                name: "FK_Skins_SkinTypes_SkinTypeId",
                table: "Skins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skins",
                table: "Skins");

            migrationBuilder.DropColumn(
                name: "Pris",
                table: "Brugere");

            migrationBuilder.DropColumn(
                name: "Stand",
                table: "Brugere");

            migrationBuilder.DropColumn(
                name: "VåbenType",
                table: "Brugere");

            migrationBuilder.RenameTable(
                name: "Skins",
                newName: "Skin");

            migrationBuilder.RenameColumn(
                name: "SkinNavn",
                table: "Brugere",
                newName: "Rolle");

            migrationBuilder.RenameColumn(
                name: "SkinId",
                table: "Skin",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Skins_SkinTypeId",
                table: "Skin",
                newName: "IX_Skin_SkinTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Skins_BrugerId",
                table: "Skin",
                newName: "IX_Skin_BrugerId");

            migrationBuilder.AlterColumn<string>(
                name: "VåbenType",
                table: "Skin",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Stand",
                table: "Skin",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SkinNavn",
                table: "Skin",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Pris",
                table: "Skin",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "BrugerId",
                table: "Skin",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Beskrivelse",
                table: "Skin",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skin",
                table: "Skin",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Skin_Brugere_BrugerId",
                table: "Skin",
                column: "BrugerId",
                principalTable: "Brugere",
                principalColumn: "BrugerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skin_SkinTypes_SkinTypeId",
                table: "Skin",
                column: "SkinTypeId",
                principalTable: "SkinTypes",
                principalColumn: "SkinTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skin_Brugere_BrugerId",
                table: "Skin");

            migrationBuilder.DropForeignKey(
                name: "FK_Skin_SkinTypes_SkinTypeId",
                table: "Skin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skin",
                table: "Skin");

            migrationBuilder.RenameTable(
                name: "Skin",
                newName: "Skins");

            migrationBuilder.RenameColumn(
                name: "Rolle",
                table: "Brugere",
                newName: "SkinNavn");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Skins",
                newName: "SkinId");

            migrationBuilder.RenameIndex(
                name: "IX_Skin_SkinTypeId",
                table: "Skins",
                newName: "IX_Skins_SkinTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Skin_BrugerId",
                table: "Skins",
                newName: "IX_Skins_BrugerId");

            migrationBuilder.AddColumn<double>(
                name: "Pris",
                table: "Brugere",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Stand",
                table: "Brugere",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VåbenType",
                table: "Brugere",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "VåbenType",
                table: "Skins",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Stand",
                table: "Skins",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SkinNavn",
                table: "Skins",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<double>(
                name: "Pris",
                table: "Skins",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "BrugerId",
                table: "Skins",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Beskrivelse",
                table: "Skins",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skins",
                table: "Skins",
                column: "SkinId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skins_Brugere_BrugerId",
                table: "Skins",
                column: "BrugerId",
                principalTable: "Brugere",
                principalColumn: "BrugerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skins_SkinTypes_SkinTypeId",
                table: "Skins",
                column: "SkinTypeId",
                principalTable: "SkinTypes",
                principalColumn: "SkinTypeId");
        }
    }
}
