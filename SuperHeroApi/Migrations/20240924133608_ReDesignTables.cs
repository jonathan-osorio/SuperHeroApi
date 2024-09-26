using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperHeroApi.Migrations
{
    /// <inheritdoc />
    public partial class ReDesignTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "villains");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "villains");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "villains");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "SuperHeroes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "villains",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "villains",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "villains",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "villains",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Faction",
                table: "villains",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "villains",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Individuality",
                table: "villains",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IndividualityDescription",
                table: "villains",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Likes",
                table: "villains",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePictureURL",
                table: "villains",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "SuperHeroes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Faction",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "SuperHeroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Individuality",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IndividualityDescription",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Likes",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePictureURL",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alias",
                table: "villains");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "villains");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "villains");

            migrationBuilder.DropColumn(
                name: "Faction",
                table: "villains");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "villains");

            migrationBuilder.DropColumn(
                name: "Individuality",
                table: "villains");

            migrationBuilder.DropColumn(
                name: "IndividualityDescription",
                table: "villains");

            migrationBuilder.DropColumn(
                name: "Likes",
                table: "villains");

            migrationBuilder.DropColumn(
                name: "ProfilePictureURL",
                table: "villains");

            migrationBuilder.DropColumn(
                name: "Alias",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Faction",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Individuality",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "IndividualityDescription",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Likes",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "ProfilePictureURL",
                table: "SuperHeroes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "villains",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "villains",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "villains",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "villains",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
