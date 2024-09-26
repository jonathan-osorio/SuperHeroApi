using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperHeroApi.Migrations
{
    /// <inheritdoc />
    public partial class FixColumnNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_villains",
                table: "villains");

            migrationBuilder.RenameTable(
                name: "villains",
                newName: "Villains");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Villains",
                table: "Villains",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Villains",
                table: "Villains");

            migrationBuilder.RenameTable(
                name: "Villains",
                newName: "villains");

            migrationBuilder.AddPrimaryKey(
                name: "PK_villains",
                table: "villains",
                column: "Id");
        }
    }
}
