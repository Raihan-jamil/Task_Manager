using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Database.Migrations
{
    /// <inheritdoc />
    public partial class changedLogModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Logs");

            migrationBuilder.AddColumn<DateTime>(
                name: "IncomingTime",
                table: "Logs",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LeavingTime",
                table: "Logs",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IncomingTime",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "LeavingTime",
                table: "Logs");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Logs",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Logs",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
