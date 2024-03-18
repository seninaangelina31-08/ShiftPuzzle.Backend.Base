using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyTrackerAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssignedUserID",
                table: "TrackerTasks",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "TrackerTasks",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "TrackerTasks",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrackerTasks_AssignedUserID",
                table: "TrackerTasks",
                column: "AssignedUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_TrackerTasks_Users_AssignedUserID",
                table: "TrackerTasks",
                column: "AssignedUserID",
                principalTable: "Users",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrackerTasks_Users_AssignedUserID",
                table: "TrackerTasks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_TrackerTasks_AssignedUserID",
                table: "TrackerTasks");

            migrationBuilder.DropColumn(
                name: "AssignedUserID",
                table: "TrackerTasks");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "TrackerTasks");

            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "TrackerTasks");
        }
    }
}
